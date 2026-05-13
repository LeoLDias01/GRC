using Business.Helper;
using Business.Services;
using Data.Models;
using GRC.Properties;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace GRC.Telas
{
    public partial class ItemEstoque : Form
    {
        private ServiceItemEstoque _service = new ServiceItemEstoque();

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

        public ItemEstoque()
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
        private void ItemEstoque_Load(object sender, EventArgs e)
        {

            CarregaCombos();
            chkAtivo.Checked = true;
        }
        private void CarregaCombos()
        {
            PreencherCombo(cbCategoria, _service.BuscaCategoriaItem(), "Descricao", "Id");
            PreencherCombo(cbFabricante, _service.BuscaFabricante(), "Descricao", "Id");
            PreencherCombo(cbFornecedor, _service.BuscaFornecedor(), "Descricao", "Id");
        }
        private void PreencherCombo<T>(MaterialComboBox cb, List<T> lista, string display, string value)
        {
            // Cria dinamicamente o item "Selecione..."
            var itemSelecione = Activator.CreateInstance<T>();

            var propId = typeof(T).GetProperty(value);
            var propDesc = typeof(T).GetProperty(display);

            propId?.SetValue(itemSelecione, 0);
            propDesc?.SetValue(itemSelecione, "Selecione...");

            // Adiciona como primeiro item da lista
            lista.Insert(0, itemSelecione);

            // Configura o ComboBox
            cb.DisplayMember = display;
            cb.ValueMember = value;
            cb.DataSource = lista;
            cb.SelectedIndex = 0;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
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

        private void dgvItens_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lbRegistros.Text = $"{dgvItens.Rows.Count} registros encontrados!";
        }
        private void RealizaPesquisa()
        {
            int categoria = cbCategoria.SelectedValue != null ? Convert.ToInt32(cbCategoria.SelectedValue) : 0;
            int fabricante = cbFabricante.SelectedValue != null ? Convert.ToInt32(cbFabricante.SelectedValue) : 0;
            int fornecedor = cbFornecedor.SelectedValue != null ? Convert.ToInt32(cbFornecedor.SelectedValue) : 0;
            /// Monta o objeto com base na pesquisa
            var item = new Item
            {
                Id = string.IsNullOrWhiteSpace(txtCodigo.Text) ? 0 : Convert.ToInt32(txtCodigo.Text),
                CodBarras = string.IsNullOrWhiteSpace(txtCodigoBarras.Text) ? string.Empty : txtCodigoBarras.Text,
                Descricao = string.IsNullOrWhiteSpace(txtItem.Text) ? string.Empty : txtItem.Text,
                Categoria = categoria > 0 ? (int)cbCategoria.SelectedValue : 0,
                Fabricante = fabricante > 0 ? (int)cbFabricante.SelectedValue : 0,
                Fornecedor = fornecedor > 0 ? (int)cbFornecedor.SelectedValue : 0,
                ItemVenda = chkItemVenda.Checked ? true : false,
                Favorito = chkFavorito.Checked ? true : false,
                Ativo = chkAtivo.Checked ? true : false,


            };

            int registros = Convert.ToInt32(cbxQtdRegistros.Text);

            dgvItens.Visible = true;
            dgvItens.Rows.Clear();
            dgvItens.RowTemplate.Height = 75;
            dgvItens.AutoGenerateColumns = false;
            dgvItens.ColumnHeadersVisible = true;
            dgvItens.ColumnHeadersHeight = 40;
            var lista = _service.BuscaLimitada(item, registros);
            if (lista != null)
            {
                foreach (var estoque in lista)
                {
                    if (estoque.Id > 0)
                    {
                        dgvItens.Rows.Add(

                        estoque.Favorito == true ? Resources.star : Resources.starOff,
                        !string.IsNullOrWhiteSpace(estoque.FotoItem) ? new Bitmap(CriptoImagem.Base64ToImage(estoque.FotoItem), new Size(100, 100)) : null,
                        estoque.Id.ToString(),
                        estoque.Descricao,
                        estoque.CodBarras,
                        estoque.Quatidade.ToString(),
                        estoque.DescricaoCategoria,
                        estoque.DescricaoFabricante,
                        estoque.DescricaoFornecedor,
                        Convert.ToBoolean(estoque.ItemVenda),
                        Convert.ToBoolean(estoque.Ativo)
                        );
                    }
                }
            }

            lbRegistros.Text = $"{dgvItens.Rows.Count} registros encontrados!";
        }
        private void LimpaCampos()
        {
            txtCodigo.Clear();
            txtCodigoBarras.Clear();
            txtItem.Clear();
            CarregaCombos();
            chkAtivo.Checked = true;
            chkFavorito.Checked = false;
            chkItemVenda.Checked = false;
            dgvItens.Rows.Clear();
            dgvItens.ColumnHeadersVisible = false;
            cbxQtdRegistros.Text = "10";
        }
        private long? PegaId(DataGridViewCellEventArgs e)
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
            long? id = PegaId(e);
            if (id.HasValue)
            {
                new CadastroItem(id.Value).ShowDialog();
                RealizaPesquisa();
            }
        }

        private void tbnSearch_Click(object sender, EventArgs e)
        {
            RealizaPesquisa();
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            new CadastroItem().ShowDialog();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void ItemEstoque_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // Libera o mouse para a operação
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); // Envia comando de mover
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // Libera o mouse para a operação
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); // Envia comando de mover
            }
        }

        private void ItemEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtCodigoBarras_Enter(object sender, EventArgs e)
        {
           
        }

        private SerialPort _serialPort; // Objeto instanciado via código

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Chamamos a inicialização assim que o formulário carrega
            InicializarLeitor();
        }

        private void InicializarLeitor()
        {
            // Busca a porta usando sua classe de serviço
            string porta = ScannerSearch.LocalizarPortaLeitor();

            if (!string.IsNullOrEmpty(porta))
            {
                // Instanciamos o objeto manualmente já que não há componente no Designer
                _serialPort = new SerialPort(porta)
                {
                    BaudRate = 9600,
                    Parity = Parity.None,
                    DataBits = 8,
                    StopBits = StopBits.One,
                    Handshake = Handshake.None,
                    ReadTimeout = 500 // Evita que o app trave esperando dados infinitamente
                };

                // Assinamos o evento de recebimento de dados
                _serialPort.DataReceived += SerialPort_DataReceived;

                try
                {
                    _serialPort.Open();

                    // Atualiza Label de status se existir
                    if (lblStatusLeitor != null)
                    {
                        lblStatusLeitor.BackColor = Color.DarkGreen;
                        lblStatusLeitor.Text = $"Leitor OK";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"O leitor foi detectado na {porta}, mas o Windows negou o acesso: {ex.Message}", "Erro de Hardware", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (lblStatusLeitor != null)
                {
                    lblStatusLeitor.Text = "Leitor não encontrado";
                    lblStatusLeitor.BackColor = Color.DarkRed;
                }
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                // Aguarda um pequeno instante para garantir que o buffer receba o código completo
                System.Threading.Thread.Sleep(50);

                if (_serialPort == null || !_serialPort.IsOpen) return;

                string dados = _serialPort.ReadExisting();
                string codigoLimpo = dados.Trim(); // Remove o \r\n (Enter) que o leitor envia

                if (!string.IsNullOrEmpty(codigoLimpo))
                {
                    // Essencial: Porta Serial roda em Thread separada. Usamos Invoke para mexer na UI.
                    this.Invoke(new Action(() =>
                    {
                        ProcessarLeitura(codigoLimpo);
                    }));
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Falha na leitura serial: " + ex.Message);
            }
        }

        private void ProcessarLeitura(string codigo)
        {
            // Atribui o código ao TextBox
            txtCodigoBarras.Text = codigo;

            // Beep opcional para confirmar leitura ao usuário
            //Console.Beep(1500, 200);

            tbnSearch_Click(tbnSearch, EventArgs.Empty);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Destruição segura do objeto para não travar a porta COM no Windows
            if (_serialPort != null)
            {
                if (_serialPort.IsOpen)
                {
                    // Desassina o evento antes de fechar para evitar chamadas em objetos descartados
                    _serialPort.DataReceived -= SerialPort_DataReceived;
                    _serialPort.Close();
                }
                _serialPort.Dispose();
                _serialPort = null;
            }
            base.OnFormClosing(e);
        }
    }
}
