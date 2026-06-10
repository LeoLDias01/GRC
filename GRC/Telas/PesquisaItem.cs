using Business.Helper;
using Business.Services;
using Data.Models;
using GRC.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO.Ports;
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
        private SerialPort _serialPort;
        #region ..:: Importação de APIs do Windows (Estética e Movimentação) ::..

        // Importa a função nativa do Windows responsável por criar regiões arredondadas no formulário
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coord do canto superior esquerdo
            int nTopRect,      // y-coord do canto superior esquerdo
            int nRightRect,    // x-coord do canto inferior direito
            int nBottomRect,   // y-coord do canto inferior direito
            int nWidthEllipse, // largura da elipse (quanto maior, mais arredondado)
            int nHeightEllipse // altura da elipse (quanto maior, mais arredondado)
        );

        // Importa as funções nativas para permitir o arrasto da tela sem usar a barra de título padrão
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Constantes numéricas exigidas pela API do Windows para capturar o movimento do mouse
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        #endregion


        public PesquisaItem()
        {
            InitializeComponent();
            // Aplica os cantos arredondados na janela do formulário (raio de 30px)
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

  
        private void RealizaPesquisa()
        {
            var item = new Item
            {
                CodBarras = string.IsNullOrWhiteSpace(lbCódigoBarras.Text) ? null : lbCódigoBarras.Text,
                Descricao = string.IsNullOrWhiteSpace(txtPesquisa.Text) ? string.Empty : txtPesquisa.Text,
                ItemVenda = chkItemVenda.Checked ? true : false
            };

            dgvItens.Rows.Clear();

            ConfigurarEstiloGrid();

            var lista = _service.BuscaTelaPesquisaBasica(item);

            if (lista != null)
            {
                foreach (var estoque in lista)
                {
                    if (estoque.Id > 0)
                    {
                        dgvItens.Rows.Add(
                        estoque.Id.ToString(),
                        !string.IsNullOrWhiteSpace(estoque.FotoItem) ? new Bitmap(CriptoImagem.Base64ToImage(estoque.FotoItem), new Size(80, 80)) : null,
                        estoque.ItemVenda == true ? "Venda" : "Estoque",              
                        estoque.Descricao
                        );
                    }
                }
            }
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

        private void PesquisaItem_Load(object sender, EventArgs e)
        {
            InicializarColunasGrid();
        }


        private void PesquisaItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // Libera o mouse para a operação
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); // Envia comando de mover
            }
        }


        private void btnEncerrarJanelas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkItemVenda_CheckedChanged(object sender, EventArgs e)
        {
            RealizaPesquisa();
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            RealizaPesquisa();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            new CadastroItem().ShowDialog();
            RealizaPesquisa();
        }

        private void dgvItens_Paint(object sender, PaintEventArgs e)
        {
            int alturaFaixa = 1;

            Rectangle headerRect = dgvItens.DisplayRectangle;
            headerRect.Y = dgvItens.ColumnHeadersHeight - alturaFaixa;
            headerRect.Height = alturaFaixa;

            using (Brush brush = new SolidBrush(Color.DarkGray))
            {
                e.Graphics.FillRectangle(brush, headerRect);
            }
        }
        private void InicializarColunasGrid()
        {
            dgvItens.Columns.Clear();
            dgvItens.AutoGenerateColumns = false;


            // 2. ID (Invisível)
            var colId = new DataGridViewTextBoxColumn { Name = "colId", HeaderText = "ID", Visible = false };
            dgvItens.Columns.Add(colId);

            // 3. Foto do Item (Imagem)
            var colImagem = new DataGridViewImageColumn { Name = "colImagem", HeaderText = "Foto", Width = 90, ImageLayout = DataGridViewImageCellLayout.Zoom };
            dgvItens.Columns.Add(colImagem);

            // 4. Marcação de Vendas/Estoque (Botão)
            var colTipoVenda = new DataGridViewImageColumn { Name = "colProduto", HeaderText = "Tipo", Width = 100, ImageLayout = DataGridViewImageCellLayout.Normal };
            dgvItens.Columns.Add(colTipoVenda);

            // 5. Nome / Descrição
            dgvItens.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDescricao", HeaderText = "Nome", Width = 200 });

            // 6. Código de Barras
            dgvItens.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCodigoBarras", HeaderText = "Cód. Barras", Width = 130 });
        }

        private void dgvItens_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvItens.Rows[e.RowIndex];

            // =================================================================
            // 3. TIPO PRODUTO (Venda [Azul] / Estoque [Invisível]) - Gerando Tag/Imagem
            // =================================================================
            if (dgvItens.Columns[e.ColumnIndex].Name == "colProduto" && e.Value != null)
            {
                string tipo = e.Value.ToString();

                if (tipo == "Venda")
                {
                    e.Value = CriarTagColorida("Venda", Color.FromArgb(52, 152, 219), Color.White);
                }
                else
                {
                    e.Value = CriarTagColorida("Estoque", Color.Goldenrod, Color.White);
                }
            }
        }
        // Método auxiliar de alta performance para desenhar as tags redondinhas na tela
        private Image CriarTagColorida(string texto, Color corFundo, Color corTexto)
        {
            // Define o tamanho da tag dentro da célula de 96px de altura
            int largura = 85;
            int altura = 26;
            int raioArredondamento = 12; // Quanto maior, mais redondo (12 a 14 vira uma pílula perfeita)

            Bitmap bmp = new Bitmap(largura, altura);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // ATENÇÃO: Essas três linhas garantem que as bordas curvas fiquem lisinhas e sem serrilhado
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                g.Clear(Color.Transparent);

                // Criando o caminho com cantos arredondados
                using (GraphicsPath path = new GraphicsPath())
                {
                    // Define o retângulo de desenho ligeiramente menor para não cortar os pixels da borda
                    Rectangle rect = new Rectangle(0, 0, largura - 1, altura - 1);

                    // Desenha os 4 cantos curvos
                    path.AddArc(rect.X, rect.Y, raioArredondamento, raioArredondamento, 180, 90);
                    path.AddArc(rect.Right - raioArredondamento, rect.Y, raioArredondamento, raioArredondamento, 270, 90);
                    path.AddArc(rect.Right - raioArredondamento, rect.Bottom - raioArredondamento, raioArredondamento, raioArredondamento, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - raioArredondamento, raioArredondamento, raioArredondamento, 90, 90);
                    path.CloseFigure();

                    // Preenche o fundo com a cor desejada
                    using (Brush brush = new SolidBrush(corFundo))
                    {
                        g.FillPath(brush, path);
                    }
                }

                // Desenha o texto centralizado na tag
                using (Font font = new Font("Segoe UI", 8.5f, FontStyle.Bold))
                using (Brush brushTexto = new SolidBrush(corTexto))
                {
                    StringFormat sf = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };

                    // Desenha o texto exatamente dentro dos limites da pílula
                    g.DrawString(texto, font, brushTexto, new RectangleF(0, 0, largura, altura), sf);
                }
            }
            return bmp;
        }
        private void ConfigurarEstiloGrid()
        {
            dgvItens.Visible = true;
            dgvItens.SuspendLayout();

            // =====================================================
            // RESET DE HERANÇAS INDESEJADAS
            // =====================================================
            dgvItens.DefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet;
            dgvItens.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet;
            dgvItens.AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet;

            dgvItens.DefaultCellStyle.Padding = Padding.Empty;
            dgvItens.RowsDefaultCellStyle.Padding = Padding.Empty;
            dgvItens.AlternatingRowsDefaultCellStyle.Padding = Padding.Empty;

            // =====================================================
            // CONFIGURAÇÕES GERAIS DO GRID
            // =====================================================
            dgvItens.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgvItens.BorderStyle = BorderStyle.None;
            dgvItens.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvItens.GridColor = Color.FromArgb(235, 238, 242);
            dgvItens.RowHeadersVisible = false;
            dgvItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItens.MultiSelect = false;
            dgvItens.AllowUserToResizeRows = false;
            dgvItens.AllowUserToResizeColumns = false;
            dgvItens.EnableHeadersVisualStyles = false;
            dgvItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItens.ScrollBars = ScrollBars.Vertical;
            dgvItens.Cursor = Cursors.Hand;
            dgvItens.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvItens.RowTemplate.Height = 80;

            // Bordas inferiores SaaS
            dgvItens.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dgvItens.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            dgvItens.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            dgvItens.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;

            // =====================================================
            // CONFIGURAÇÃO VISUAL DAS LINHAS (Cores e Destaque)
            // =====================================================
            dgvItens.RowsDefaultCellStyle.BackColor = Color.White;
            dgvItens.RowsDefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41);
            dgvItens.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10F);

            dgvItens.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 243, 248);
            dgvItens.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41);
            dgvItens.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10F);

            // =====================================================
            // CABEÇALHO (Header)
            // =====================================================
            dgvItens.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvItens.ColumnHeadersHeight = 45;
            dgvItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            DataGridViewCellStyle estiloHeader = new DataGridViewCellStyle
            {
                //BackColor = Color.FromArgb(44, 62, 80),
                // ForeColor = Color.White,

                BackColor = Color.White,
                ForeColor = Color.FromArgb(44, 62, 80),
                Font = new Font("Segoe UI Semibold", 10.5f),
                // SelectionBackColor = Color.FromArgb(44, 62, 80),
                // SelectionForeColor = Color.White

                SelectionBackColor = Color.White,
                SelectionForeColor = Color.FromArgb(44, 62, 80)
            };
            dgvItens.ColumnHeadersDefaultCellStyle = estiloHeader;

            // =====================================================
            // CONTROLE ABSOLUTO COLUNA POR COLUNA
            // =====================================================
            foreach (DataGridViewColumn coluna in dgvItens.Columns)
            {
                // SE FOR COLUNA DE TEXTO / NÚMERO
                if (coluna is DataGridViewTextBoxColumn)
                {
                   
                        // Demais colunas de texto (Nome, Código, Categoria, etc) continuam perfeitamente à esquerda
                        coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        coluna.HeaderCell.Style.Padding = new Padding(16, 0, 0, 0);
                        coluna.DefaultCellStyle.Padding = new Padding(16, 0, 0, 0);
                    
                }
                // SE FOR COLUNA DE IMAGENS / ÍCONES / PÍLULAS
                else
                {
                    coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    coluna.HeaderCell.Style.Padding = Padding.Empty;

                    if (coluna.Name == "colImagem")
                    {
                        if (coluna is DataGridViewImageColumn imgProduto)
                        {
                            imgProduto.ImageLayout = DataGridViewImageCellLayout.Zoom;
                            imgProduto.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                            imgProduto.Width = 90;
                            imgProduto.DefaultCellStyle.NullValue = null;
                            imgProduto.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            imgProduto.DefaultCellStyle.Padding = new Padding(6);
                        }
                    }
                   
                    else if (coluna.Name == "colProduto")
                    {
                        if (coluna is DataGridViewImageColumn imgProd)
                        {
                            imgProd.ImageLayout = DataGridViewImageCellLayout.Normal;
                            imgProd.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                            imgProd.Width = 135;
                            imgProd.DefaultCellStyle.NullValue = null;
                            imgProd.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            imgProd.DefaultCellStyle.Padding = Padding.Empty;
                        }
                    }
                }
            }

            dgvItens.DefaultCellStyle.SelectionBackColor = Color.FromArgb(226, 236, 248);
            dgvItens.DefaultCellStyle.SelectionForeColor = Color.FromArgb(20, 20, 20);
            dgvItens.ClearSelection();

            dgvItens.ResumeLayout();
        }
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
            dgvItens.Visible = false;
            txtPesquisa.Text = string.Empty;
            chkItemVenda.Checked = true;
            // Atribui o código ao TextBox
            lbCódigoBarras.Text = codigo;

            // Beep opcional para confirmar leitura ao usuário
            //Console.Beep(1500, 200);
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
