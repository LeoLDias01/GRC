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
    public partial class Fornecedor : Form
    {
        private ServiceFornecedor _serviceFornecedor = new ServiceFornecedor();

        // Importar as DLLs do Windows para mover o formulário
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Constantes para a mensagem de movimento
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        public Fornecedor()
        {
            InitializeComponent();
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

        private void cbxQtdRegistros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite dígitos e a tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignora o caractere digitado
            }
        }

        private void dgvFornecedores_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lbRegistros.Text = $"{dgvFornecedores.Rows.Count} registros encontrados!";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
        private void RealizaPesquisa()
        {
            /// Monta o objeto com base na pesquisa
            var fornecedor = new Fornecedores
            {
                Nome = txtFornecedor.Text,
                RazaoSocial = txtRazaoSocial.Text,
                Cnpj = txtCnpj.Text.Trim(),
                Ativo = chkAtivo.Checked ? true : false,
                Endereco = new Endereco
                {
                    Cidade = txtCidade.Text,
                    Uf = txtUf.Text.Trim(),
                }
            };
            int registros = Convert.ToInt32(cbxQtdRegistros.Text);

            dgvFornecedores.Visible = true;
            dgvFornecedores.Rows.Clear();
            dgvFornecedores.RowTemplate.Height = 30;
            dgvFornecedores.AutoGenerateColumns = false;
            dgvFornecedores.ColumnHeadersVisible = true;
            dgvFornecedores.ColumnHeadersHeight = 50;

            var lista = _serviceFornecedor.BuscaLimitada(fornecedor, registros);

            if (lista != null)
            {
                foreach (var estoque in lista)
                {
                    if (estoque.Id > 0)
                    {
                        dgvFornecedores.Rows.Add(
                            estoque.Id, 
                            estoque.Nome,
                            estoque.RazaoSocial,
                            estoque.Cnpj,
                            estoque.Endereco.Cidade,
                            estoque.Endereco.Uf,
                            Resources.remove
                        );
                    }
                }
            }

            lbRegistros.Text = $"{dgvFornecedores.Rows.Count} registros encontrados!";
        }

        private void LimpaCampos()
        {
            //dgvFornecedores.Visible = false;
            txtFornecedor.Clear();
            txtCnpj.Clear();
            txtRazaoSocial.Clear();
            txtCidade.Clear();
            txtUf.Clear();
            chkAtivo.Checked = true;
            dgvFornecedores.Rows.Clear();
            dgvFornecedores.ColumnHeadersVisible = false;
            cbxQtdRegistros.Text = "10";
        }
        private int? PegaIdFornecedor(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvFornecedores.Rows[e.RowIndex];
                return Convert.ToInt32(row.Cells["colIdFornecedor"].Value);
            }
            return null;
        }
        private void dgvFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int? idFornecedor = PegaIdFornecedor(e);
            if (idFornecedor.HasValue)
            {
                new CadastroFornecedor(idFornecedor.Value).ShowDialog();
                RealizaPesquisa();
            }
        }
        private void btnAddFornecedor_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RealizaPesquisa();
        }

        private void Fornecedor_Load(object sender, EventArgs e)
        {
            chkAtivo.Checked = true;
        }

        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            new CadastroFornecedor().ShowDialog();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                //flpMenu.Dock = DockStyle.None;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                //flpMenu.Dock = DockStyle.Fill;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // Libera o mouse para a operação
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); // Envia comando de mover
            }
        }

        private void Fornecedor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // Libera o mouse para a operação
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); // Envia comando de mover
            }
        }
    }
}
