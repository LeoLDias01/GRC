using Business.Helper;
using Business.Services;
using Data.Models;
using GRC.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRC.Telas
{
    public partial class PesquisaItem : Form
    {
        public List<Item> _item = new List<Item>();
        ServiceItemEstoque _service = new ServiceItemEstoque();


        // Importar as DLLs do Windows para mover o formulário
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Constantes para a mensagem de movimento
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        public PesquisaItem()
        {
            InitializeComponent();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            dgvItens.Rows.Clear();
            txtCodigo.Clear();
            txtItem.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RealizaPesquisa();
        }

        private void RealizaPesquisa()
        {
            var item = new Item
            {
                Id = string.IsNullOrWhiteSpace(txtCodigo.Text) ? 0 : Convert.ToInt32(txtCodigo.Text),
                Descricao = string.IsNullOrWhiteSpace(txtItem.Text) ? string.Empty : txtItem.Text,
            };

            int registros = Convert.ToInt32(cbxQtdRegistros.Text);

            dgvItens.Visible = true;
            dgvItens.Rows.Clear();
            dgvItens.RowTemplate.Height = 85;
            dgvItens.AutoGenerateColumns = false;
            dgvItens.ColumnHeadersVisible = true;
            dgvItens.ColumnHeadersHeight = 40;
            dgvItens.DefaultCellStyle.ForeColor = Color.Black;

            var lista = _service.BuscaTelaPesquisaBasica(item, registros);

            if (lista != null)
            {
                foreach (var estoque in lista)
                {
                    if (estoque.Id > 0)
                    {
                        dgvItens.Rows.Add(
                        !string.IsNullOrWhiteSpace(estoque.FotoItem) ? new Bitmap(CriptoImagem.Base64ToImage(estoque.FotoItem), new Size(80, 80)) : null,
                        estoque.Id.ToString(),
                        estoque.Descricao,
                        estoque.Quatidade.ToString(),
                        estoque.CustoUnitario
                        );
                    }
                }
            }

            lbRegistros.Text = $"{dgvItens.Rows.Count} registros encontrados!";
        }

        private void dgvItens_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lbRegistros.Text = $"{dgvItens.Rows.Count} registros encontrados!";
        }
        private int? PegaId(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvItens.Rows[e.RowIndex];
                return Convert.ToInt32(row.Cells["colId"].Value);
            }
            return null;
        }

        private void dgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int? id = PegaId(e);
            if (id.HasValue)
            {
                _item = _service.BuscaTelaPesquisaCompleta((int)id.Value);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void cbxQtdRegistros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite dígitos e a tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignora o caractere digitado
            }
        }

        private void cbxQtdRegistros_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbxQtdRegistros.Text))
            {
                if (Convert.ToInt32(cbxQtdRegistros.Text) > 100)
                    cbxQtdRegistros.Text = "100";
            }
            else cbxQtdRegistros.Text = "10";

            RealizaPesquisa();
        }

        private void PesquisaItem_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void PesquisaItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // Libera o mouse para a operação
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); // Envia comando de mover
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            new CadastroItem().ShowDialog();
        }
    }
}
