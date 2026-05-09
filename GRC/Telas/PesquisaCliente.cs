using Business.Services;
using Data.Models;
using GRC.Properties;
using MaterialSkin.Controls;
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
    public partial class PesquisaCliente : Form
    {
        private ServiceCliente _service = new ServiceCliente();
        public PesquisaCliente()
        {
            InitializeComponent();
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            
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

        private void dgvClientes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lbRegistros.Text = $"{dgvClientes.Rows.Count} registros encontrados!";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
        private void RealizaPesquisa()
        {
            /// Monta o objeto com base na pesquisa
            var cliente = new Cliente
            {
                Nome = txtCliente.Text,
                TipoPessoa = rbtPF.Checked == true ? 1 : 2,
                Identidade = txtIdentidade.Text.Trim(),
                Ativo = chkAtivo.Checked ? true : false,
                Endereco = new Endereco
                {
                    Cidade = txtCidade.Text,
                    Uf = txtUf.Text.Trim(),
                }
            };
            int registros = Convert.ToInt32(cbxQtdRegistros.Text);

            dgvClientes.Visible = true;
            dgvClientes.Rows.Clear();
            dgvClientes.RowTemplate.Height = 30;
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.ColumnHeadersVisible = true;
            dgvClientes.ColumnHeadersHeight = 50;

            var lista = _service.BuscaLimitada(cliente, registros);

            if (lista != null)
            {
                foreach (var estoque in lista)
                {
                    if (estoque.Id > 0)
                    {
                        dgvClientes.Rows.Add(
                            estoque.Id,
                            estoque.Nome,
                            estoque.TipoPessoa == 1 ? "Pessoa Física" : "Pessoa Jurídica",
                            estoque.Identidade,
                            estoque.Endereco.Cidade,
                            estoque.Endereco.Uf,
                            Resources.remove
                        );
                    }
                }
            }

            lbRegistros.Text = $"{dgvClientes.Rows.Count} registros encontrados!";
        }

        private void LimpaCampos()
        {
            txtCliente.Clear();
            txtIdentidade.Clear();
            rbtPF.Checked = true;
            rbtPJ.Checked = false;
            txtCidade.Clear();
            txtUf.Clear();
            chkAtivo.Checked = true;
            dgvClientes.Rows.Clear();
            dgvClientes.ColumnHeadersVisible = false;
            cbxQtdRegistros.Text = "10";
        }
        private int? PegaIdCliente(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvClientes.Rows[e.RowIndex];
                return Convert.ToInt32(row.Cells["colIdCliente"].Value);
            }
            return null;
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int? idCliente = PegaIdCliente(e);
            if (idCliente.HasValue)
            {
                new CadastroCliente(idCliente.Value).ShowDialog();
                RealizaPesquisa();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RealizaPesquisa();
        }

        private void PesquisaCliente_Load(object sender, EventArgs e)
        {
            chkAtivo.Checked = true;
            rbtPF.Checked = true;   
        }

        private void txtIdentidade_TextChanged(object sender, EventArgs e)
        {
            if (rbtPF.Checked)
                FormatarCpf(txtIdentidade);
            else if (rbtPJ.Checked)
                FormatarCnpj(txtIdentidade);
        }
        private void FormatarCpf(MaterialTextBox txtCpf)
        {
            string texto = new string(txtCpf.Text.Where(char.IsDigit).ToArray());

            if (texto.Length <= 3)
                txtCpf.Text = texto;
            else if (texto.Length <= 6)
                txtCpf.Text = texto.Insert(3, ".");
            else if (texto.Length <= 9)
                txtCpf.Text = texto.Insert(3, ".").Insert(7, ".");
            else
                txtCpf.Text = texto.Insert(3, ".").Insert(7, ".").Insert(11, "-");

            txtCpf.SelectionStart = txtCpf.Text.Length;
        }
        private void FormatarCnpj(MaterialTextBox txtCnpj)
        {
            string texto = new string(txtCnpj.Text.Where(char.IsDigit).ToArray());

            if (texto.Length <= 2)
                txtCnpj.Text = texto;
            else if (texto.Length <= 5)
                txtCnpj.Text = texto.Insert(2, ".");
            else if (texto.Length <= 8)
                txtCnpj.Text = texto.Insert(2, ".").Insert(6, ".");
            else if (texto.Length <= 12)
                txtCnpj.Text = texto.Insert(2, ".").Insert(6, ".").Insert(10, "/");
            else
                txtCnpj.Text = texto.Insert(2, ".").Insert(6, ".").Insert(10, "/").Insert(15, "-");

            txtCnpj.SelectionStart = txtCnpj.Text.Length; // mantém o cursor no final
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            new CadastroCliente().ShowDialog();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Importar as DLLs do Windows para mover o formulário
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Constantes para a mensagem de movimento
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private void pnSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // Libera o mouse para a operação
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); // Envia comando de mover
            }
        }

        private void PesquisaCliente_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // Libera o mouse para a operação
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); // Envia comando de mover
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // Libera o mouse para a operação
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); // Envia comando de mover
            }
        }
    }
}
