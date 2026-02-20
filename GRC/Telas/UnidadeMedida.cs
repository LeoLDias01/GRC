using Business.Services;
using Data.Models;
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
    public partial class UnidadeMedida : Form
    {
        private int _id = 0;
        ServiceTipo _services = new ServiceTipo();

        // Importar as DLLs do Windows para mover o formulário
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Constantes para a mensagem de movimento
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        public UnidadeMedida()
        {
            InitializeComponent();
        }

        private void UnidadeMedida_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
        }
        private bool ValidaCampo()
        {
            if (!string.IsNullOrWhiteSpace(txtDescricao.Text))
                return true;
            else return false;
        }
        private void CarregaDados()
        {
            dgvTipo.DataSource = null;
            dgvTipo.RowTemplate.Height = 30;
            dgvTipo.AutoGenerateColumns = false;
            dgvTipo.ColumnHeadersVisible = true;
            dgvTipo.ColumnHeadersHeight = 50;
            dgvTipo.DataSource = _services.BuscaUnidadeMedida();
            lbRegistros.Text = $"{dgvTipo.Rows.Count} cadastros!";
        }

        private void dgvTipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTipo.Columns[e.ColumnIndex].Name == "colExcluir")
            {
                int? id = PegaIDCatedoria(e);
                if (id.HasValue)
                {
                    var result = MessageBox.Show("Deseja realmente inativar esta categoria?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        _services.InativaUnidadeMedida(id.Value);
                        CarregaDados();
                    }
                }
            }
        }
        private int? PegaIDCatedoria(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvTipo.Rows[e.RowIndex];
                return Convert.ToInt32(row.Cells["colId"].Value);
            }
            return null;
        }

        private void txtDescricao_TrailingIconClick(object sender, EventArgs e)
        {
            if (!ValidaCampo())
                return;

            Tipo tipo = new Tipo();
            tipo.Id = _id;
            tipo.Descricao = txtDescricao.Text;
            _services.SalvaUnidadeMedida(tipo);
            txtDescricao.Clear();
            CarregaDados();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UnidadeMedida_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // Libera o mouse para a operação
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); // Envia comando de mover
            }
        }
    }
}
