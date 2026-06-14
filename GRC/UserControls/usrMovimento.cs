using Business.Helper;
using Business.Services;
using Data.Models;
using GRC.Componentes;
using GRC.Properties;
using GRC.Telas;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRC.UserControls
{
    public partial class usrMovimento : UserControl
    {
        private int _IdMovimentacao = 0;
        private int _idItem = 0;
        ServiceMovimentacao _service = new ServiceMovimentacao();
        Item _dadosItem = new Item();
        private string _dataInicial;
        private string _dataFinal;

        private SerialPort _serialPort;

        public usrMovimento()
        {
            InitializeComponent();
            // Registra os eventos dos novos componentes via código
            this.Load += usrMovimento_Load;
            txtPesquisa.KeyPress += txt_KeyPress;
            txtDataInicial.KeyPress += txtDataInicial_KeyPress;
            txtDataFinal.KeyPress += txtDataFinal_KeyPress;
            lbTitulo.DoubleClick += lbTitulo_DoubleClick;
            cbRegistros.TextChanged += cbRegistros_TextChanged;
            cbRegistros.KeyPress += cbRegistros_KeyPress;
           
            btnMovimentar.Click += btnNovoMovimento_Click;

            cbTipoMovimento.DropDownClosed += cbTipoMovimento_DropDownClosed;

            dgvMovimentacoes.CellValueChanged += dgvItens_CellValueChanged;
            dgvMovimentacoes.CellDoubleClick += dgvMovimentacoes_CellDoubleClick;
            dgvMovimentacoes.CellClick += dgvMovimentacoes_CellClick;
            dgvMovimentacoes.Paint += dgvItens_Paint;
            dgvMovimentacoes.CellFormatting += dgvItens_CellFormatting;


        }
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            RealizaPesquisa();
        }
        private void txtDataInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Executa a sua formatação existente
            FormataData(txtDataInicial);

            // 1. Obtém o texto atual do componente
            string textoAtual = txtDataInicial.Text;

            // 2. Se for uma tecla de controle (como Backspace), não precisamos validar o formato dd/MM/yyyy
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // 3. Monta o texto como ele vai ficar após o processamento da tecla atual
            string textoCompleto = textoAtual + e.KeyChar;

            // 4. Se o texto atingiu os 10 caracteres (dd/MM/yyyy), fazemos a validação e pesquisa
            if (textoCompleto.Length == 10)
            {
                if (DateTime.TryParseExact(textoCompleto, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataValida))
                {
                    _dataInicial = dataValida.ToString("dd/MM/yyyy");
                    RealizaPesquisa();
                }
            }
        }

        private void txtDataFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormataData(txtDataFinal);

            string textoAtual = txtDataFinal.Text;

            if (char.IsControl(e.KeyChar)) return;

            string textoCompleto = textoAtual + e.KeyChar;

            if (textoCompleto.Length == 10)
            {
                if (DateTime.TryParseExact(textoCompleto, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataValida))
                {
                    _dataFinal = dataValida.ToString("dd/MM/yyyy");
                    RealizaPesquisa();
                }
            }
        }
        private void FormataData(RoundedTextBox txt)
        {
            // Remove tudo que não é número
            string apenasNumeros = new string(txt.Text.Where(char.IsDigit).ToArray());

            if (apenasNumeros.Length > 8)
                apenasNumeros = apenasNumeros.Substring(0, 8);

            string formatado = "";

            if (apenasNumeros.Length <= 2)
            {
                formatado = apenasNumeros;
            }
            else if (apenasNumeros.Length <= 4)
            {
                formatado = apenasNumeros.Insert(2, "/");
            }
            else
            {
                formatado = apenasNumeros.Insert(2, "/").Insert(5, "/");
            }

            txt.Text = formatado;
            txt.SelectionStart = txt.Text.Length;
        }
        private void dgvItens_Paint(object sender, PaintEventArgs e)
        {
            int alturaFaixa = 1;

            Rectangle headerRect = dgvMovimentacoes.DisplayRectangle;
            headerRect.Y = dgvMovimentacoes.ColumnHeadersHeight - alturaFaixa;
            headerRect.Height = alturaFaixa;

            using (Brush brush = new SolidBrush(Color.DarkGray))
            {
                e.Graphics.FillRectangle(brush, headerRect);
            }
        }
        private void usrMovimento_Load(object sender, EventArgs e)
        {
            CarregaCombos();
            cbRegistros.Text = "10";
            InicializarColunasGrid();
            RealizaPesquisa();
            btnMovimentar.Focus();
            ConfigurarEstiloGrid();
        }
        private void cbTipoMovimento_DropDownClosed(object sender, EventArgs e)
        {
             RealizaPesquisa();
        }

        

        private void lbTitulo_DoubleClick(object sender, EventArgs e)
        {
            LimpaCampos();
        }
        private void CarregaCombos()
        {
            PreencherCombo(cbTipoMovimento, _service.BuscaTipoMovimentacao(), "Descricao", "Id");
        }
        private void PreencherCombo<T>(ModernComboBox cb, List<T> lista, string display, string value)
        {
            cb.DisplayMember = display;
            cb.ValueMember = value;
            cb.DataSource = lista;
            cb.SelectedIndex = -1; // nenhum item selecionado — exibe o placeholder
        }

        private void cbRegistros_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbRegistros.Text))
            {
                if (Convert.ToInt32(cbRegistros.Text) > 100)
                    cbRegistros.Text = "100";
            }
            else
            {
                cbRegistros.Text = "10";
            }

            RealizaPesquisa();
        }

        private void cbRegistros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas dígitos e a tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvItens_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lbRegistros.Text = $"{dgvMovimentacoes.Rows.Count} registros encontrados!";
        }
        private void btnNovoMovimento_Click(object sender, EventArgs e)
        {
            txtPesquisa.Text = string.Empty;
            new CadastroMovimentacao().ShowDialog();
            RealizaPesquisa();
        }
        private void InicializarColunasGrid()
        {
            dgvMovimentacoes.Columns.Clear();
            dgvMovimentacoes.AutoGenerateColumns = false;

            // 1. Favorito (Imagem)
            // 8. Categoria
            dgvMovimentacoes.Columns.Add(new DataGridViewTextBoxColumn { Name = "colData", HeaderText = "Data", Width = 80 });

            // 2. ID (Invisível)
            var colId = new DataGridViewTextBoxColumn { Name = "colId", HeaderText = "Id", Visible = false };
            dgvMovimentacoes.Columns.Add(colId);


            // 4. Marcação de Vendas/Estoque (Botão)
            var colTipoVenda = new DataGridViewImageColumn { Name = "colTipo", HeaderText = "Tipo", Width = 80, ImageLayout = DataGridViewImageCellLayout.Normal };
            dgvMovimentacoes.Columns.Add(colTipoVenda);

            // 5. Nome / Descrição
            dgvMovimentacoes.Columns.Add(new DataGridViewTextBoxColumn { Name = "colItem", HeaderText = "Item", Width = 300 });

            // 10. Quantidade Atual
            dgvMovimentacoes.Columns.Add(new DataGridViewTextBoxColumn { Name = "colQtd", HeaderText = "Qtd", Width = 90 });

            // 6. Código de Barras
            dgvMovimentacoes.Columns.Add(new DataGridViewTextBoxColumn { Name = "colMotivo", HeaderText = "Motivo", Width = 150 });

            // 7. Marca
            dgvMovimentacoes.Columns.Add(new DataGridViewImageColumn { Name = "colExcluir", HeaderText = "", Width = 80, Image = Resources.trash });
        }
        private void RealizaPesquisa()
        {
            int categoria = cbTipoMovimento.SelectedValue != null ? Convert.ToInt32(cbTipoMovimento.SelectedValue) : 0;
            /// Monta o objeto com base na pesquisa
            var mov = new Movimentacao
            {
                TipoMovimentacao = categoria,
                Descricao = txtPesquisa.Text,
                DadosItem  = new Item
                {
                    CodBarras = lbCódigoBarras.Text
                }
            };


            int registros = Convert.ToInt32(cbRegistros.Text);

            ConfigurarEstiloGrid();

            var lista = _service.BuscaLimitada(mov, registros, _dataInicial, _dataFinal);


            dgvMovimentacoes.Rows.Clear();


            if (lista != null)
            {
                foreach (var movimento in lista)
                {
                    if (movimento.Id > 0)
                    { 
                        dgvMovimentacoes.Rows.Add(

                        movimento.DataMovimentacao,
                        movimento.Id.ToString(),
                        movimento.Descricao,
                        movimento.DadosItem.Descricao,
                        movimento.DadosItem.Quatidade,
                        movimento.Motivo.ToString()
                        );
                    }
                }
            }

            lbRegistros.Text = $"{dgvMovimentacoes.Rows.Count} registros encontrados!";
        }
        private void dgvItens_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvMovimentacoes.Rows[e.RowIndex];

            // =================================================================
            // 1. QUANTIDADE (Preto vs Laranja) - Usando seus novos nomes
            // =================================================================
            if (dgvMovimentacoes.Columns[e.ColumnIndex].Name == "colQtd")
            {
                string tipo = row.Cells["colQtd"].Value != null ? row.Cells["colQtd"].Value.ToString() : "";
                
                if (tipo != "Entrada")
                {
                    e.CellStyle.ForeColor = Color.OrangeRed;
                    e.CellStyle.SelectionForeColor = Color.OrangeRed;
                    e.CellStyle.Font = new Font(dgvMovimentacoes.Font, FontStyle.Bold); // Dá um leve destaque extra
                }
                else
                {
                    e.CellStyle.ForeColor = Color.FromArgb(33, 37, 41);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(20, 20, 20);
                    e.CellStyle.Font = new Font(dgvMovimentacoes.Font, FontStyle.Regular);
                }
            }

            // =================================================================
            // 3. TIPO PRODUTO (Venda [Azul] / Estoque [Invisível]) - Gerando Tag/Imagem
            // =================================================================
            if (dgvMovimentacoes.Columns[e.ColumnIndex].Name == "colTipo" && e.Value != null)
            {
                string tipo = e.Value.ToString();

                if (tipo == "Entrada")
                {
                    e.Value = CriarTagColorida("Entrada", Color.DarkGreen, Color.White);
                }
                else
                {
                    e.Value = CriarTagColorida($"{tipo}", Color.DarkRed, Color.White);
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
        private void LimpaCampos()
        {
            txtPesquisa.Text = string.Empty;
            txtDataInicial.Text = string.Empty;
            txtDataFinal.Text = string.Empty;
            CarregaCombos();
            dgvMovimentacoes.Rows.Clear();
            dgvMovimentacoes.ColumnHeadersVisible = false;
            cbRegistros.Text = "10";
        }
        private void ConfigurarEstiloGrid()
        {
            dgvMovimentacoes.SuspendLayout();

            // =====================================================
            // RESET DE HERANÇAS INDESEJADAS
            // =====================================================
            dgvMovimentacoes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet;
            dgvMovimentacoes.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet;
            dgvMovimentacoes.AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet;

            dgvMovimentacoes.DefaultCellStyle.Padding = Padding.Empty;
            dgvMovimentacoes.RowsDefaultCellStyle.Padding = Padding.Empty;
            dgvMovimentacoes.AlternatingRowsDefaultCellStyle.Padding = Padding.Empty;

            // =====================================================
            // CONFIGURAÇÕES GERAIS DO GRID
            // =====================================================
            dgvMovimentacoes.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgvMovimentacoes.BorderStyle = BorderStyle.None;
            dgvMovimentacoes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMovimentacoes.GridColor = Color.FromArgb(235, 238, 242);
            dgvMovimentacoes.RowHeadersVisible = false;
            dgvMovimentacoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovimentacoes.MultiSelect = false;
            dgvMovimentacoes.AllowUserToResizeRows = false;
            dgvMovimentacoes.AllowUserToResizeColumns = false;
            dgvMovimentacoes.EnableHeadersVisualStyles = false;
            dgvMovimentacoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMovimentacoes.ScrollBars = ScrollBars.Vertical;
            dgvMovimentacoes.Cursor = Cursors.Hand;
            dgvMovimentacoes.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvMovimentacoes.RowTemplate.Height = 50;

            // Bordas inferiores SaaS
            dgvMovimentacoes.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dgvMovimentacoes.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            dgvMovimentacoes.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            dgvMovimentacoes.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;

            // =====================================================
            // CONFIGURAÇÃO VISUAL DAS LINHAS (Cores e Destaque)
            // =====================================================
            dgvMovimentacoes.RowsDefaultCellStyle.BackColor = Color.White;
            dgvMovimentacoes.RowsDefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41);
            dgvMovimentacoes.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10F);

            dgvMovimentacoes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 243, 248);
            dgvMovimentacoes.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41);
            dgvMovimentacoes.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10F);

            // =====================================================
            // CABEÇALHO (Header)
            // =====================================================
            dgvMovimentacoes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMovimentacoes.ColumnHeadersHeight = 52;
            dgvMovimentacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

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
            dgvMovimentacoes.ColumnHeadersDefaultCellStyle = estiloHeader;

            // =====================================================
            // CONTROLE ABSOLUTO COLUNA POR COLUNA
            // =====================================================
            foreach (DataGridViewColumn coluna in dgvMovimentacoes.Columns)
            {
                // SE FOR COLUNA DE TEXTO / NÚMERO
                if (coluna is DataGridViewTextBoxColumn)
                {
                    // ALTERAÇÃO AQUI: Verifica se são as colunas de quantidade
                    // IMPORTANTE: Verifique se os Names abaixo batem exatamente com as suas colunas
                    if (coluna.Name == "colQtd")
                    {
                        // Centraliza totalmente (Vertical e Horizontal) o Header e as Células
                        coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        // Remove paddings laterais para manter o número morto no centro
                        coluna.HeaderCell.Style.Padding = Padding.Empty;
                        coluna.DefaultCellStyle.Padding = Padding.Empty;
                    }
                    else
                    {
                        // Demais colunas de texto (Nome, Código, Categoria, etc) continuam perfeitamente à esquerda
                        coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        coluna.HeaderCell.Style.Padding = new Padding(16, 0, 0, 0);
                        coluna.DefaultCellStyle.Padding = new Padding(16, 0, 0, 0);
                    }
                }
                // SE FOR COLUNA DE IMAGENS / ÍCONES / PÍLULAS
                else
                {
                    coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    coluna.HeaderCell.Style.Padding = Padding.Empty;

                    if (coluna.Name == "colProduto")
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

            dgvMovimentacoes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(226, 236, 248);
            dgvMovimentacoes.DefaultCellStyle.SelectionForeColor = Color.FromArgb(20, 20, 20);
            dgvMovimentacoes.ClearSelection();

            dgvMovimentacoes.ResumeLayout();
        }

        private void dgvMovimentacoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            long? id = PegaId(e);
            if (id.HasValue)
            {
                new CadastroItem(id.Value).ShowDialog();
                 RealizaPesquisa();
            }
        }
        private void dgvMovimentacoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evita o erro se o usuário clicar na linha de cabeçalho (índice da linha é -1)
            if (e.RowIndex < 0) return;

            if (dgvMovimentacoes.Columns[e.ColumnIndex].Name == "colExcluir")
            {
                if (new AlertBox(Color.Goldenrod, Color.Yellow, Color.Gold, Resources.Warning, "Movimentação", $"Deseja excluir a movimentação?", "Seu estoque será recalculado!", true).ShowDialog() == DialogResult.Yes)
                {
                    long? id = PegaId(e);
                    if (id.HasValue)
                    {
                        var mov = new Movimentacao
                        {
                            Id = (int)id.Value,
                            Ativo = false
                        };
                        int? op = _service.SalvaMovimentacao(mov);

                        if(op == -1)
                        {
                            new AlertBox(Color.FromArgb(0, 60, 4), Color.LimeGreen, Color.Green, Resources.Confirm, "Movimentação", $"Movimentação Excluída com Sucesso!", "A movimenta foi excluída e não pode mais ser recuperada!", false).ShowDialog();
                        }
                        RealizaPesquisa();
                    }
                }
            }
            
        }
        private long? PegaId(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvMovimentacoes.Rows[e.RowIndex];
                return Convert.ToInt32(row.Cells["colId"].Value);
            }
            return null;
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
            LimpaCampos();
            // Atribui o código ao TextBox
            lbCódigoBarras.Text = codigo;

            // Beep opcional para confirmar leitura ao usuário
            //Console.Beep(1500, 200);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_serialPort != null)
                {
                    if (_serialPort.IsOpen)
                    {
                        _serialPort.DataReceived -= SerialPort_DataReceived;
                        _serialPort.Close();
                    }

                    _serialPort.Dispose();
                    _serialPort = null;
                }
            }

            base.Dispose(disposing);
        }
    }
}
