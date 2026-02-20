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
    public partial class PesquisaRapidaCliente : Form
    {
        public List<Cliente> _cliente = new List<Cliente>();
        private ServiceCliente _service = new ServiceCliente();

        // Constantes do Windows API
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 1;
        private const int HTCAPTION = 2;
        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTTOP = 12;
        private const int HTTOPLEFT = 13;
        private const int HTTOPRIGHT = 14;
        private const int HTBOTTOM = 15;
        private const int HTBOTTOMLEFT = 16;
        private const int HTBOTTOMRIGHT = 17;

        private const int borderSize = 5;


        // Importar as DLLs do Windows para mover o formulário
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Constantes para a mensagem de movimento
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        public Cliente ClienteSelecionado { get; private set; }
        public PesquisaRapidaCliente()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Garante que está sem borda
            this.DoubleBuffered = true; // Melhora a performance visual ao redimensionar
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST)
            {
                // Obtém a posição do mouse em coordenadas de tela
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);

                // Verifica se o mouse está nas extremidades para redimensionar
                if (pos.X <= borderSize)
                {
                    if (pos.Y <= borderSize) m.Result = (IntPtr)HTTOPLEFT;
                    else if (pos.Y >= this.ClientSize.Height - borderSize) m.Result = (IntPtr)HTBOTTOMLEFT;
                    else m.Result = (IntPtr)HTLEFT;
                }
                else if (pos.X >= this.ClientSize.Width - borderSize)
                {
                    if (pos.Y <= borderSize) m.Result = (IntPtr)HTTOPRIGHT;
                    else if (pos.Y >= this.ClientSize.Height - borderSize) m.Result = (IntPtr)HTBOTTOMRIGHT;
                    else m.Result = (IntPtr)HTRIGHT;
                }
                else if (pos.Y <= borderSize) m.Result = (IntPtr)HTTOP;
                else if (pos.Y >= this.ClientSize.Height - borderSize) m.Result = (IntPtr)HTBOTTOM;
                else
                {
                    // Se não estiver nas bordas, permite arrastar o form clicando em qualquer lugar "vazio"
                    if (m.Result == (IntPtr)HTCLIENT)
                        m.Result = (IntPtr)HTCAPTION;
                }
            }
        }
        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            new CadastroCliente().ShowDialog();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
        private void LimpaCampos()
        {
            txtCliente.Clear();
            txtIdentidade.Clear();
            rbtPF.Checked = true;
            rbtPJ.Checked = false;
            dgvClientes.Rows.Clear();
            dgvClientes.ColumnHeadersVisible = false;
            dgvClientes.DataSource = null;
            cbxQtdRegistros.Text = "10";
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RealizaPesquisa();
        }

        private void dgvClientes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lbRegistros.Text = $"{dgvClientes.Rows.Count} registros encontrados!";
        }
        private void RealizaPesquisa()
        {
            /// Monta o objeto com base na pesquisa
            var cliente = new Cliente
            {
                Nome = txtCliente.Text,
                TipoPessoa = rbtPF.Checked == true ? 1 : 2,
                Identidade = txtIdentidade.Text.Trim(),
                Ativo = true //Pegar sempre os clientes ativos nesse caso
            };
            int registros = Convert.ToInt32(cbxQtdRegistros.Text);

            dgvClientes.Visible = true;
            dgvClientes.Rows.Clear();
            dgvClientes.RowTemplate.Height = 30;
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.ColumnHeadersVisible = true;
            dgvClientes.ColumnHeadersHeight = 50;

            _cliente = _service.BuscaLimitada(cliente, registros);

            if (_cliente != null)
            {
                foreach (var pessoa in _cliente)
                {
                    if (pessoa.Id > 0)
                    {
                        dgvClientes.Rows.Add(
                            pessoa.Id,
                            pessoa.Nome,
                            pessoa.TipoPessoa == 1 ? "Pessoa Física" : "Pessoa Jurídica",
                            pessoa.Identidade
                        );
                    }
                }
            }

            lbRegistros.Text = $"{dgvClientes.Rows.Count} registros encontrados!";
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var linha = dgvClientes.Rows[e.RowIndex];
            int idCliente = Convert.ToInt32(linha.Cells["colIdCliente"].Value);

            var lista = _service.BuscaCompleta(idCliente);

            ClienteSelecionado = lista?.FirstOrDefault();

            if (ClienteSelecionado == null)
                return;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void PesquisaRapidaCliente_Load(object sender, EventArgs e)
        {
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PesquisaRapidaCliente_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // Libera o mouse para a operação
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); // Envia comando de mover
            }
        }
    }
}
