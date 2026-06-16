using Business.EmailSender;
using Business.Helper;
using Business.Services;
using Data.Models;
using GRC.Componentes;
using GRC.Properties;
using iText.Kernel.Pdf.Function;
using iText.Layout.Element;
using iText.Signatures.Validation;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace GRC.Telas
{
    public partial class CadastroOS : Form
    {
        #region Campos e Propriedades

        private int _dicas = 0;
        private int _idOS = 0;
        private bool _favorito = false;
        private int _StatusAntigo = 0;
        private int _padrao = 0;
        private Cliente _cliente = new Cliente();

        private List<ItemCard> _itensOS = new List<ItemCard>();
        ServiceOrdemServico _service = new ServiceOrdemServico();

        private List<OrdemServico> _OSImpressao = new List<OrdemServico>();

        #endregion

        #region Importação de APIs do Windows (Estética e Movimentação)

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

        #region Construtor e Inicialização
        public CadastroOS(int id = 0)
        {
            InitializeComponent();
            _idOS = id;

            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            RegistrarEventos();
        }

        private void RegistrarEventos()
        {
            this.Load += CadastroOS_Load;
            this.KeyDown += CadastroOS_KeyDown;
            this.MouseDown += CadastroOS_MouseDown;

            dgvItens.Paint += dgvItens_Paint;
            dgvItens.CellContentClick += dgvItens_CellContentClick;

            btnFechar.Click += (s, e) => this.Close();
            btnNovoItem.Click += btnNovoItem_Click;
            btnConsultaItem.Click += btnConsultaItem_Click;
            btnExportar.Click += (s, e) => Exportar();
            btnSalvar.Click += (s, e) => Salvar();


            pcFavorito.Click += pcbFavorito_Click;
            pcLogo.Click += pcLogo_Click;

            cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;

            txtDataEntrada.TextChanged += txtDataEntrada_TextChanged;
            txtFimPrevisto.TextChanged += txtFimPrevisto_TextChanged;
            txtInicioGarantia.TextChanged += txtInicioGarantia_TextChanged;
            txtFimGarantia.TextChanged += txtFimGarantia_TextChanged;
            txtGarantia.TextChanged += txtGarantia_TextChanged;

            txtGarantia.Leave += txtGarantia_Leave;
            txtInicioGarantia.Leave += txtInicioGarantia_Leave;

            txtMaoObra.KeyDown += txtMaoObra_KeyDown;
            txtMaoObra.KeyPress += txtMaoObra_KeyPress;
            txtMaoObra.Enter += txtMaoObra_Enter;
            txtMaoObra.Leave += txtMaoObra_Leave;
            txtMaoObra.TextChanged += txtMaoObra_TextChanged;

            txtAcrescimo.KeyDown += txtAcrescimo_KeyDown;
            txtAcrescimo.KeyPress += txtAcrescimo_KeyPress;
            txtAcrescimo.Enter += txtAcrescimo_Enter;
            txtAcrescimo.Leave += txtAcrescimo_Leave;
            txtAcrescimo.TextChanged += txtAcrescimo_TextChanged;

            txtDesconto.KeyDown += txtDesconto_KeyDown;
            txtDesconto.KeyPress += txtDesconto_KeyPress;
            txtDesconto.Enter += txtDesconto_Enter;
            txtDesconto.Leave += txtDesconto_Leave;
            txtDesconto.TextChanged += txtDesconto_TextChanged;

            txtCustoManual.TextChanged += txtCustoManual_TextChanged;
            txtTotalPecas.TextChanged += txtTotalPecas_TextChanged;
            txtTotalServico.TextChanged += txtTotalServico_TextChanged;

            txtCliente.Click += txtCliente_Click;

            chkOutros.CheckedChanged += chkOutros_CheckedChanged;

            lbApagar.Click += lbApagar_Click;
            lbA.Click += lbA_Click;
            lbB.Click += lbB_Click;
            lbC.Click += lbC_Click;
            lbD.Click += lbD_Click;
            lbE.Click += lbE_Click;
            lbF.Click += lbF_Click;
            lbG.Click += lbG_Click;
            lbH.Click += lbH_Click;
            lbI.Click += lbI_Click;
        }

        #endregion

        #region Visual - Grid de Itens (Configuração e Estilo)

        private void InicializarColunasGrid()
        {
            dgvItens.Columns.Clear();
            dgvItens.AutoGenerateColumns = false;

            var colId = new DataGridViewTextBoxColumn { Name = "colId", HeaderText = "ID", Visible = false };
            dgvItens.Columns.Add(colId);

            dgvItens.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDescricao", HeaderText = "Nome", Width = 200 });
            dgvItens.Columns.Add(new DataGridViewTextBoxColumn { Name = "colQtdItem", HeaderText = "Estoque", Width = 90 });
            dgvItens.Columns.Add(new DataGridViewTextBoxColumn { Name = "colValues", HeaderText = "Valor Gasto", Width = 200 });

            var colAtivo = new DataGridViewImageColumn { Name = "colExcluir", HeaderText = "", Width = 100, ImageLayout = DataGridViewImageCellLayout.Normal, Image = Resources.remove };
            dgvItens.Columns.Add(colAtivo);
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

        private void ConfigurarEstiloGrid()
        {
            dgvItens.SuspendLayout();

            dgvItens.DefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet;
            dgvItens.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet;
            dgvItens.AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet;

            dgvItens.DefaultCellStyle.Padding = Padding.Empty;
            dgvItens.RowsDefaultCellStyle.Padding = Padding.Empty;
            dgvItens.AlternatingRowsDefaultCellStyle.Padding = Padding.Empty;

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
            dgvItens.RowTemplate.Height = 96;

            dgvItens.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dgvItens.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            dgvItens.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            dgvItens.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;

            dgvItens.RowsDefaultCellStyle.BackColor = Color.White;
            dgvItens.RowsDefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41);
            dgvItens.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10F);

            dgvItens.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 243, 248);
            dgvItens.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41);
            dgvItens.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10F);

            dgvItens.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvItens.ColumnHeadersHeight = 52;
            dgvItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            DataGridViewCellStyle estiloHeader = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.FromArgb(44, 62, 80),
                Font = new Font("Segoe UI Semibold", 10.5f),
                SelectionBackColor = Color.White,
                SelectionForeColor = Color.FromArgb(44, 62, 80)
            };
            dgvItens.ColumnHeadersDefaultCellStyle = estiloHeader;

            foreach (DataGridViewColumn coluna in dgvItens.Columns)
            {
                if (coluna is DataGridViewTextBoxColumn)
                {
                    if (coluna.Name == "colQtdItem")
                    {
                        coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        coluna.HeaderCell.Style.Padding = Padding.Empty;
                        coluna.DefaultCellStyle.Padding = Padding.Empty;
                    }
                    else
                    {
                        coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        coluna.HeaderCell.Style.Padding = new Padding(16, 0, 0, 0);
                        coluna.DefaultCellStyle.Padding = new Padding(16, 0, 0, 0);
                    }
                }
                else
                {
                    coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    coluna.HeaderCell.Style.Padding = Padding.Empty;
                }
            }

            dgvItens.DefaultCellStyle.SelectionBackColor = Color.FromArgb(226, 236, 248);
            dgvItens.DefaultCellStyle.SelectionForeColor = Color.FromArgb(20, 20, 20);
            dgvItens.ClearSelection();

            dgvItens.ResumeLayout();
        }

        #endregion

        #region Visual - Cards de Itens (ConfiguraCard, CriaCard, PiscarCard)

        private void ConfiguraCard()
        {
            flpItens.AutoScroll = true;
            flpItens.FlowDirection = FlowDirection.TopDown;
            flpItens.WrapContents = false;
        }

        private void CriaCard(ItemCard item, bool validarDuplicado)
        {
            decimal.TryParse(item.Custo.ToString(), NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal unit);

            if (validarDuplicado)
            {
                bool jaExiste = _itensOS.Any(i => i.IdItem == item.IdItem);
                if (jaExiste)
                {
                    var cardExistente = flpItens.Controls
                        .OfType<CustomPanel>()
                        .FirstOrDefault(c => c.Tag is ItemCard os && os.IdItem == item.IdItem);

                    if (cardExistente != null)
                    {
                        flpItens.ScrollControlIntoView(cardExistente);
                        PiscarCard(cardExistente);
                    }

                    new AlertBox(
                        Color.Goldenrod,
                        Color.Black,
                        Color.Yellow,
                        Resources.Warning,
                        "Item já adicionado",
                        item.Descricao,
                        "Este item já está na ordem de serviço.",
                        false
                    ).ShowDialog();

                    return;
                }
            }

            ItemCard itemOS = new ItemCard
            {
                Id = item.Id,
                IdItem = (int)item.IdItem,
                Descricao = item.Descricao,
                ValorUnitario = unit,
                Quantidade = item.Quantidade,
                QuantidadeMaxima = item.QuantidadeMaxima,
                FotoItem = item.FotoItem,
            };

            CustomPanel card = new CustomPanel
            {
                Width = flpItens.Width - 8,
                Height = 90,
                TamanhoRaio = 15,
                BackColor = Color.Azure,
                Tag = itemOS
            };

            PictureBox foto = new PictureBox
            {
                Width = 68,
                Height = 68,
                Location = new Point(10, 10),
                BackColor = Color.Azure,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            foto.Image = string.IsNullOrEmpty(item.FotoItem) ? null : CriptoImagem.Base64ToImage(item.FotoItem);

            Label lblNome = new Label
            {
                Text = item.Descricao,
                Width = 250,
                Height = 30,
                AutoEllipsis = true,
                Font = new Font("Roboto", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(43, 69, 98),
                BackColor = Color.Transparent,
                Location = new Point(90, 10),
                AutoSize = false
            };

            CustomButton btnMenos = new CustomButton
            {
                Text = "➖",
                Width = 30,
                Height = 30,
                TamanhoRaio = 5,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.FromArgb(0, 136, 184),
                Location = new Point(90, 40)
            };

            MaterialTextBox txtQuantidade = new MaterialTextBox
            {
                Text = item.Quantidade.ToString(),
                Width = 60,
                Height = 25,
                Location = new Point(130, 40),
                UseTallSize = false,
                Cursor = Cursors.Default
            };

            CustomButton btnMais = new CustomButton
            {
                Text = "➕",
                Width = 30,
                Height = 30,
                TamanhoRaio = 5,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.FromArgb(0, 136, 184),
                Location = new Point(200, 40)
            };

            Label lblPreco = new Label
            {
                Text = $"Valor: {item.Custo}",
                Location = new Point(240, 47),
                Font = new Font("Roboto", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(43, 69, 98),
                BackColor = Color.Transparent,
                AutoSize = true
            };

            CustomButton btnExcluir = new CustomButton
            {
                Text = " ❌",
                Width = 40,
                Height = 30,
                TamanhoRaio = 5,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.DarkRed,
                Location = new Point(card.Width - 50, 30)
            };
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatAppearance.MouseOverBackColor = Color.FromArgb(43, 69, 98);

            void AtualizarSubtotal()
            {
                txtQuantidade.Text = itemOS.Quantidade.ToString();
                lblPreco.Text = $"Valor: {itemOS.Subtotal:C2}";
                AtualizarTotalOS();
            }

            btnExcluir.Click += (s, e) =>
            {
                _itensOS.Remove(itemOS);
                flpItens.Controls.Remove(card);
                card.Dispose();
                AtualizarSubtotal();
                AtualizarTotalOS();
            };

            btnMenos.Click += (s, e) =>
            {
                if (itemOS.Quantidade > 1)
                {
                    itemOS.Quantidade--;
                    AtualizarSubtotal();
                    AtualizarTotalOS();
                }
            };

            btnMais.Click += (s, e) =>
            {
                if (itemOS.Quantidade < item.QuantidadeMaxima)
                {
                    itemOS.Quantidade++;
                    AtualizarSubtotal();
                    AtualizarTotalOS();
                }
                else
                    new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Item de Estoque", item.Descricao.ToString(), "Não existe quantidade suficiente no estoque!", false).ShowDialog();
            };

            txtQuantidade.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            };

            txtQuantidade.Leave += (s, e) =>
            {
                if (!int.TryParse(txtQuantidade.Text, out int qtd) || qtd < 1)
                    qtd = 1;

                if (qtd > item.QuantidadeMaxima)
                    qtd = item.QuantidadeMaxima;

                itemOS.Quantidade = qtd;
            };

            txtQuantidade.Enter += (s, e) =>
            {
                LimpaValorAoFocar("1", txtQuantidade);
            };

            txtQuantidade.TextChanged += (s, e) =>
            {
                if (int.TryParse(txtQuantidade.Text, out int qtd))
                {
                    if (qtd < 1)
                        qtd = 1;
                    if (qtd > item.QuantidadeMaxima)
                        qtd = item.QuantidadeMaxima;

                    itemOS.Quantidade = qtd;
                    AtualizarSubtotal();
                    txtQuantidade.SelectionStart = txtQuantidade.Text.Length;
                }
            };

            _itensOS.Add(itemOS);
            card.Controls.Add(foto);
            card.Controls.Add(lblNome);
            card.Controls.Add(btnMenos);
            card.Controls.Add(txtQuantidade);
            card.Controls.Add(btnMais);
            card.Controls.Add(lblPreco);
            card.Controls.Add(btnExcluir);
            flpItens.Controls.Add(card);
            AtualizarSubtotal();
        }

        private async void PiscarCard(Control card)
        {
            Color corOriginal = card.BackColor;
            Color corDestaque = Color.FromArgb(255, 220, 180);

            for (int i = 0; i < 3; i++)
            {
                card.BackColor = corDestaque;
                await Task.Delay(180);

                card.BackColor = corOriginal;
                await Task.Delay(180);
            }
        }

        #endregion

        #region Visual - Painel de Status e Favorito

        private void Favorito()
        {
            if (_favorito == true)
            {
                pcFavorito.Image = Resources.star;
                _favorito = false;
            }
            else
            {
                pcFavorito.Image = Resources.starOff;
                _favorito = true;
            }
        }

        private void PermiteAddItens(bool ativo)
        {
            btnConsultaItem.Enabled = ativo;
            flpItens.Enabled = ativo;

            if (ativo)
            {
                flpItens.BackColor = Color.FromArgb(43, 69, 98);
            }
            else
            {
                flpItens.BackColor = Color.FromArgb(52, 57, 66);
            }
        }

        private void MudaCorPainel(Color cor1, Color cor2)
        {
        }

        #endregion

        #region Visual - Formatação de Campos (Data e Moeda)

        private void FormataData(MaterialTextBox txt)
        {
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

        private void FormataMoeda(object sender)
        {
            MaterialTextBox txt = (MaterialTextBox)sender;
            string apenasNumeros = new string(txt.Text.Where(char.IsDigit).ToArray());

            if (string.IsNullOrEmpty(apenasNumeros))
            {
                txt.Text = "";
                return;
            }

            apenasNumeros = apenasNumeros.TrimStart('0');

            if (apenasNumeros.Length < 3)
                apenasNumeros = apenasNumeros.PadLeft(3, '0');

            string valorFormatado = apenasNumeros.Insert(apenasNumeros.Length - 2, ",");

            txt.Text = "R$ " + valorFormatado;
            txt.SelectionStart = txt.Text.Length;
        }

        private void ZeraValorAoDesfocar(string valor, MaterialTextBox txtBox)
        {
            if (string.IsNullOrWhiteSpace(txtBox.Text))
                txtBox.Text = valor;
        }

        private void LimpaValorAoFocar(string valor, MaterialTextBox txtBox)
        {
            if (txtBox.Text == valor)
                txtBox.Clear();
        }

        private void VerificaKeyV(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                string texto = Clipboard.GetText();

                if (!texto.All(char.IsDigit))
                    e.SuppressKeyPress = true;
            }
        }

        private void DesativaCaracteres(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        #endregion

        #region Lógica - Carregamento de Dados e Combos

        private void PreencherCombo<T>(MaterialComboBox cb, List<T> lista, string display, string value)
        {
            var itemSelecione = Activator.CreateInstance<T>();

            var propId = typeof(T).GetProperty(value);
            var propDesc = typeof(T).GetProperty(display);

            propId?.SetValue(itemSelecione, 0);
            propDesc?.SetValue(itemSelecione, "Selecione...");

            lista.Insert(0, itemSelecione);

            cb.DisplayMember = display;
            cb.ValueMember = value;
            cb.DataSource = lista;
            cb.SelectedIndex = 0;
        }

        private void CarregaCombos()
        {
            PreencherCombo(cbTipoServico, _service.BuscaTipoServico(), "Descricao", "Id");
            PreencherCombo(cbStatus, _service.BuscaStatus(), "Descricao", "Id");
        }

        private void CarregaDados()
        {
            try
            {
                flpItens.Controls.Clear();
                _itensOS.Clear();

                _OSImpressao = _service.BuscaCompleta(_idOS);

                var dadosOs = _OSImpressao.FirstOrDefault();

                if (dadosOs == null)
                    return;

                _cliente = dadosOs.DadosCliente;
                txtCliente.Text = _cliente.Nome;
                txtIdentidade.Text = _cliente.Identidade;

                txtId.Text = _idOS.ToString();
                txtRelatorioTecnico.Text = dadosOs.DescricaoProblema;
                txtDescricaoSaida.Text = dadosOs.DescricaoSolucao.ToString();
                cbTipoServico.SelectedValue = dadosOs.TipoServico;
                _StatusAntigo = dadosOs.Status;
                cbStatus.SelectedValue = _StatusAntigo;
                txtDataEntrada.Text = dadosOs.DataEntrada;
                txtFimPrevisto.Text = dadosOs.FimPrevisto;
                txtFimReal.Text = dadosOs.FimReal;
                txtGarantia.Text = dadosOs.DuracaoGarantia;
                txtInicioGarantia.Text = dadosOs.DtInicioGarantia;
                txtFimGarantia.Text = dadosOs.DtFimGarantia;
                txtObservacoesLoja.Text = dadosOs.ObservacoesLoja;
                txtObservacoesCliente.Text = dadosOs.ObservacoesCliente;

                txtCustoManual.Text = dadosOs.CustoManual;
                txtValorCobrado.Text = dadosOs.MaoObra;

                _favorito = dadosOs.Favorito;
                Favorito();

                if (dadosOs.ItensOrdemServico != null && dadosOs.ItensOrdemServico.Count > 0)
                {
                    ConfiguraCard();
                    flpItens.Controls.Clear();
                    _itensOS.Clear();

                    foreach (var item in dadosOs.ItensOrdemServico)
                    {
                        CriaCard(item, false);
                    }
                }

                if (dadosOs.ItensEsporadicos != null && dadosOs.ItensEsporadicos.Count > 0)
                {
                    foreach (var itm in dadosOs.ItensEsporadicos)
                    {
                    }
                }

                btnExportar.Enabled = true;
            }
            catch (Exception ex)
            {
                EmailError.EnviarEmailErro(ex.ToString());
                new AlertBox(Color.FromArgb(64, 0, 0), Color.Red, Color.Crimson, Resources.Error, "Um erro ocorreu:", "Entidade: OS", "Erro ao Carregar o dados da OS!", false).ShowDialog();
            }
        }

        #endregion

        #region Lógica - Totais e Garantia

        private void AtualizarTotalOS()
        {
            decimal total = _itensOS.Sum(i => i.Subtotal);
            txtTotalPecas.Text = $"{total:C2}";
        }

        private void AdicionarItemOS(ItemCard item)
        {
        }

        private void CalculaTotal()
        {
            bool MaoObraOk = decimal.TryParse(txtValorCobrado.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal mo);
            bool PecasOk = decimal.TryParse(txtTotalPecas.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal pc);
            bool CustoManualOk = decimal.TryParse(txtCustoManual.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal cm);

            decimal total = 0;

            if (MaoObraOk)
                total += mo;

            if (PecasOk)
                total += pc;

            if (CustoManualOk)
                total += cm;

            txtLucro.Text = total.ToString("C2", CultureInfo.CurrentCulture);
        }

        private void AtualizarFimGarantia()
        {
            if (!string.IsNullOrWhiteSpace(txtInicioGarantia.Text) && !string.IsNullOrWhiteSpace(txtGarantia.Text))
            {
                if (!DateTime.TryParse(txtInicioGarantia.Text, out DateTime dataInicio))
                    return;

                if (!int.TryParse(txtGarantia.Text, out int diasGarantia))
                    return;

                var dataFim = dataInicio.AddDays(diasGarantia);
                txtFimGarantia.Text = dataFim.ToString("dd/MM/yyyy");
            }
            else txtFimGarantia.Clear();
        }

        #endregion

        #region Lógica - Salvar, Limpar e Validar

        private void Salvar()
        {
            try
            {
                if (!ValidaCampos())
                    return;

                bool fim = false;

                if (_StatusAntigo != Convert.ToInt32(cbStatus.SelectedValue))
                {
                    if (Convert.ToInt32(cbStatus.SelectedValue) == 10 || Convert.ToInt32(cbStatus.SelectedValue) == 11)
                    {
                        fim = true;
                    }
                }

                var os = new OrdemServico
                {
                    Id = _idOS,
                    DadosCliente = _cliente,
                    DescricaoProblema = !string.IsNullOrWhiteSpace(txtRelatorioTecnico.Text) ? txtRelatorioTecnico.Text : string.Empty,
                    DescricaoSolucao = !string.IsNullOrWhiteSpace(txtDescricaoSaida.Text) ? txtDescricaoSaida.Text : string.Empty,
                    TipoServico = Convert.ToInt32(cbTipoServico.SelectedValue),
                    StatusAntigo = _StatusAntigo,
                    Status = Convert.ToInt32(cbStatus.SelectedValue),
                    DuracaoGarantia = !string.IsNullOrWhiteSpace(txtGarantia.Text) ? txtGarantia.Text.Trim() : string.Empty,
                    DataEntrada = !string.IsNullOrWhiteSpace(txtDataEntrada.Text) ? txtDataEntrada.Text : string.Empty,
                    FimPrevisto = !string.IsNullOrWhiteSpace(txtFimPrevisto.Text) ? txtFimPrevisto.Text : string.Empty,
                    FimReal = fim == true ? DateTime.Today.ToString("dd/MM/yyyy") : string.Empty,
                    DtInicioGarantia = !string.IsNullOrWhiteSpace(txtInicioGarantia.Text) ? txtInicioGarantia.Text : string.Empty,
                    DtFimGarantia = !string.IsNullOrWhiteSpace(txtFimGarantia.Text) ? txtFimGarantia.Text : string.Empty,
                    MaoObra = !string.IsNullOrWhiteSpace(txtValorCobrado.Text) ? txtValorCobrado.Text : string.Empty,
                    CustoManual = !string.IsNullOrWhiteSpace(txtCustoManual.Text) ? txtCustoManual.Text : string.Empty,

                    ObservacoesLoja = txtObservacoesLoja.Text,
                    ObservacoesCliente = txtObservacoesCliente.Text,
                    Favorito = _favorito == true ? false : true,
                    ItensOrdemServico = _itensOS.ToList(),
                    ItensEsporadicos = dgvItens.Rows.Cast<DataGridViewRow>()
                    .Where(r => !r.IsNewRow)
                    .Select(r =>
                    {
                        var iditem = r.Cells["colId"].Value;
                        var nome = r.Cells["colDescricao"].Value;

                        return new ItemCard
                        {
                            Id = Convert.ToInt32(iditem),
                            Descricao = nome.ToString()
                        };
                    }).ToList()
                };

                int? retorno = _service.SalvaOS(os);

                if (retorno > 0)
                    new AlertBox(Color.FromArgb(0, 60, 4), Color.LimeGreen, Color.Green, Resources.Confirm, "Ordem de Serviço", $"Do cliente: {os.DadosCliente.Nome}", "Foi cadastrado com sucesso!", false).ShowDialog();
                else if (retorno == 0)
                    new AlertBox(Color.FromArgb(0, 60, 4), Color.LimeGreen, Color.Green, Resources.Confirm, "Ordem de Serviço", $"Do cliente: {os.DadosCliente.Nome}", "Foi alterado com sucesso!", false).ShowDialog();

                LimpaCampos();
            }
            catch (Exception ex)
            {
                EmailError.EnviarEmailErro(ex.ToString());
                new AlertBox(Color.FromArgb(64, 0, 0), Color.Red, Color.Crimson, Resources.Error, "Um erro ocorreu:", "Entidade: OS", "Erro ao salvar OS!", false).ShowDialog();
            }
        }

        private void LimpaCampos()
        {
            _idOS = 0;
            _cliente = null;
            _favorito = false;

            Favorito();
            CarregaCombos();

            txtId.Clear();
            txtCliente.Clear();
            txtIdentidade.Clear();
            txtDescricaoSaida.Clear();
            txtRelatorioTecnico.Clear();
            txtObservacoesCliente.Clear();
            txtGarantia.Clear();
            txtDataEntrada.Clear();
            txtFimPrevisto.Clear();
            txtInicioGarantia.Clear();
            txtFimGarantia.Clear();
            txtValorCobrado.Clear();
            txtTotalPecas.Clear();

            txtObservacoesLoja.Clear();
            txtLucro.Clear();
            dgvItens.Rows.Clear();
            txtCustoManual.Clear();

            foreach (Control ctrl in flpItens.Controls)
            {
                ctrl.Dispose();
            }

            flpItens.Controls.Clear();

            _itensOS.Clear();
        }
        private bool ValidaData(MaterialTextBox txt)
        {
            string formato = "dd/MM/yyyy";

            bool dataValida = DateTime.TryParseExact(
                txt.Text,
                formato,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime dataResult
            );
            return dataValida;
        }
        private bool ValidaCampos()
        {
            int status = Convert.ToInt32(cbStatus.SelectedValue) > 0 ? Convert.ToInt32(cbStatus.SelectedValue) : 0;

            if (status == 0)
            {
                new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Ordem de Serviço", "Status não selecionado", "Selecione uma das opções", false).ShowDialog();
                cbStatus.Focus();
                return false;
            }

            else if (string.IsNullOrWhiteSpace(txtDataEntrada.Text) || ValidaData(txtDataEntrada) == false)
            {
                new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Ordem de Serviço", "Data de entrada inválida", "Preencha corretamente o campo", false).ShowDialog();
                txtDataEntrada.Focus();
                return false;
            }
            else if((int)cbTipoServico.SelectedValue < 1)
            {
                new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Ordem de Serviço", "Tipo de serviço não selecionado", "Selecione uma das opções", false).ShowDialog();
                cbTipoServico.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtResumoServico.Text))
            {
                new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Ordem de Serviço", "Resumo do serviço vazio", "Preencha o campo pois é obrigatório", false).ShowDialog();
                txtResumoServico.Focus();
                return false;
            }







            if (string.IsNullOrWhiteSpace(txtRelatorioTecnico.Text))
            {
                new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Ordem de Serviço", "Item sem nome válido", "O nome do item é obrigatório", false).ShowDialog();
                txtDescricaoSaida.Focus();
                return false;
            }
            if (_cliente.Id < 1 && _cliente.Nome != string.Empty)
            {
                new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Ordem de Serviço", "Cliente não foi selecioando", "Selecione o cliente", false).ShowDialog();
                txtCliente.Focus();
                return false;
            }
            


            else if (_idOS == 0 && (Convert.ToInt32(cbStatus.SelectedValue) == 11 || Convert.ToInt32(cbStatus.SelectedValue) == 10))
            {
                new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Ordem de Serviço", "Status Inválido para Inserção", "O Status da OS deve seguir o fluxo, não pode iniciar como Finalizado ou Cancelado", false).ShowDialog();
                cbStatus.Focus();
                return false;
            }

            else return true;
        }

        #endregion

        #region Lógica - Exportação

        private void Exportar()
        {
            this.Cursor = Cursors.WaitCursor;
            CalculaTotal();
            new SelecaoImpressao(_OSImpressao, txtLucro.Text).ShowDialog();
            this.Cursor = Cursors.Default;
        }

        #endregion

        #region Lógica - Grid Esporádico

        private void PreencheGridItemEsporadico(int id, string item, string qtd, string valor)
        {
            ConfigurarEstiloGrid();
            dgvItens.Rows.Add(
                    id,
                    item,
                    qtd,
                    valor,
                    Resources.remove
                );
        }

        #endregion

        #region Lógica - Padrão de Desenho (Senha Visual)

        private void AtualizarPadrao(Label lb)
        {
            if (_padrao < 9 && lb.Text == "⚫️")
            {
                _padrao++;
                lb.Text = _padrao.ToString();
            }
        }

        #endregion

        #region Eventos - Form

        private void CadastroOS_Load(object sender, EventArgs e)
        {
            _favorito = false;
            Favorito();
            lbDataAtual.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txtDataEntrada.Text = DateTime.Today.ToString("dd/MM/yyyy");
            CarregaCombos();

            if (_idOS > 0)
                CarregaDados();
            else
                btnExportar.Enabled = false;

            txtDescricaoSaida.Focus();

            InicializarColunasGrid();
            ConfigurarEstiloGrid();
        }

        private void CadastroOS_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void CadastroOS_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                Salvar();
                return true;
            }

            if (keyData == (Keys.Control | Keys.F))
            {
                Favorito();
                return true;
            }

            if (keyData == Keys.F1 && btnExportar.Enabled == true)
            {
                Exportar();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        #region Eventos - Botões

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            new CadastroItem().ShowDialog();
        }
        private void btnConsultaItem_Click(object sender, EventArgs e)
        {
            using (var frm = new PesquisaItem())
            {
                frm.ShowDialog();

                if (frm._item != null && frm._item.Count > 0)
                {
                    ConfiguraCard();
                    foreach (var comp in frm._item)
                    {
                        if (comp.Quatidade > 0)
                        {
                            CriaCard(new ItemCard
                            {
                                Id = 0,
                                IdItem = (int)comp.Id > 0 ? (int)comp.Id : 0,
                                Descricao = comp.Descricao,
                                Quantidade = 1,
                                QuantidadeMaxima = comp.Quatidade,
                                FotoItem = comp.FotoItem,
                                Custo = comp.CustoUnitario
                            }, true);
                        }
                        else
                        {
                            new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Item de Estoque", comp.Descricao.ToString(), "Não pode ser adicionado pois estoque está zerado!", false).ShowDialog();
                        }
                    }
                }
            }
        }





        #endregion

        #region Eventos - Favorito e Logo

        private void pcbFavorito_Click(object sender, EventArgs e)
        {
            Favorito();
        }

        private void pcLogo_Click(object sender, EventArgs e)
        {
            _dicas = _dicas + 1;

            if (_dicas >= 3)
            {
                _dicas = 0;
                new DicasUso(" ATALHOS DA TELA DE OS: \n\n\n" +
                    " ⚫️ Salvar -> CTRL + S \n\n" +
                    " ⚫️ Favoritar -> CTRL + F \n\n" +
                    " ⚫️ Imprimir OS -> F1"
                    ).ShowDialog();
            }
        }

        #endregion

        #region Eventos - ComboBox Status

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cbStatus.SelectedValue) == 6)
            {
                PermiteAddItens(true);
                MudaCorPainel(Color.Gray, Color.DarkGray);
            }
            else if (Convert.ToInt32(cbStatus.SelectedValue) == 7)
            {
                PermiteAddItens(true);
                MudaCorPainel(Color.Yellow, Color.Goldenrod);
            }
            else if (Convert.ToInt32(cbStatus.SelectedValue) == 8)
            {
                PermiteAddItens(true);
                MudaCorPainel(Color.Orange, Color.DarkOrange);
            }
            else if (Convert.ToInt32(cbStatus.SelectedValue) == 9)
            {
                PermiteAddItens(true);
                MudaCorPainel(Color.Cyan, Color.DeepSkyBlue);
            }
            else if (Convert.ToInt32(cbStatus.SelectedValue) == 10)
            {
                PermiteAddItens(false);
                MudaCorPainel(Color.Lime, Color.Green);
            }
            else if (Convert.ToInt32(cbStatus.SelectedValue) == 11)
            {
                PermiteAddItens(false);
                MudaCorPainel(Color.DarkSalmon, Color.Crimson);
            }
        }

        #endregion

        #region Eventos - Campos de Data

        private void txtDataEntrada_TextChanged(object sender, EventArgs e)
        {
            FormataData(txtDataEntrada);
        }

        private void txtFimPrevisto_TextChanged(object sender, EventArgs e)
        {
            FormataData(txtFimPrevisto);
        }

        private void txtInicioGarantia_TextChanged(object sender, EventArgs e)
        {
            FormataData(txtInicioGarantia);
            AtualizarFimGarantia();
        }

        private void txtFimGarantia_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtGarantia_TextChanged(object sender, EventArgs e)
        {
            AtualizarFimGarantia();
        }

        private void txtGarantia_Leave(object sender, EventArgs e)
        {
        }

        private void txtInicioGarantia_Leave(object sender, EventArgs e)
        {
        }

        #endregion

        #region Eventos - Campos Monetários

        private void txtMaoObra_KeyDown(object sender, KeyEventArgs e)
        {
            VerificaKeyV(sender, e);
        }

        private void txtMaoObra_KeyPress(object sender, KeyPressEventArgs e)
        {
            DesativaCaracteres(sender, e);
        }

        private void txtMaoObra_Enter(object sender, EventArgs e)
        {
            LimpaValorAoFocar("R$ 0,00", txtValorCobrado);
        }

        private void txtMaoObra_Leave(object sender, EventArgs e)
        {
            ZeraValorAoDesfocar("R$ 0,00", txtValorCobrado);
        }

        private void txtMaoObra_TextChanged(object sender, EventArgs e)
        {
            FormataMoeda(sender);
            CalculaTotal();
        }

        private void txtAcrescimo_KeyDown(object sender, KeyEventArgs e)
        {
            VerificaKeyV(sender, e);
        }

        private void txtAcrescimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            DesativaCaracteres(sender, e);
        }

        private void txtAcrescimo_Enter(object sender, EventArgs e)
        {
            LimpaValorAoFocar("R$ 0,00", txtValorCobrado);
        }

        private void txtAcrescimo_Leave(object sender, EventArgs e)
        {
            ZeraValorAoDesfocar("R$ 0,00", txtValorCobrado);
        }

        private void txtAcrescimo_TextChanged(object sender, EventArgs e)
        {
            FormataMoeda(sender);
            CalculaTotal();
        }

        private void txtDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            VerificaKeyV(sender, e);
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            DesativaCaracteres(sender, e);
        }

        private void txtDesconto_Enter(object sender, EventArgs e)
        {
            LimpaValorAoFocar("R$ 0,00", txtValorCobrado);
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            ZeraValorAoDesfocar("R$ 0,00", txtValorCobrado);
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            FormataMoeda(sender);
            CalculaTotal();
        }

        private void txtCustoManual_TextChanged(object sender, EventArgs e)
        {
            FormataMoeda(sender);
            CalculaTotal();
        }

        private void txtTotalPecas_TextChanged(object sender, EventArgs e)
        {
            CalculaTotal();
        }

        private void txtTotalServico_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLucro.Text))
            {
                txtLucro.Text = "R$ 0,00";
            }
        }

        #endregion

        #region Eventos - Cliente e Itens Esporádicos

        private void txtCliente_Click(object sender, EventArgs e)
        {
            PesquisaRapidaCliente frm = new PesquisaRapidaCliente();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _cliente = frm.ClienteSelecionado;
                txtCliente.Text = _cliente.Nome;
                txtIdentidade.Text = _cliente.Identidade;
            }
        }

        private void dgvItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItens.Columns[e.ColumnIndex].Name == "colExcluir" && e.RowIndex >= 0)
            {
                var result = new AlertBox(Color.Goldenrod, Color.LimeGreen, Color.Yellow, Resources.Warning, "Aviso de Exclusão", string.Empty, "Deseja realmente excluir o item?", true).ShowDialog();
                if (result == DialogResult.Yes)
                {
                    dgvItens.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        #endregion

        #region Eventos - Checkbox e Padrão de Senha

        private void chkOutros_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTela.Checked)
                txtOutros.Visible = true;
            else
                txtOutros.Visible = false;
        }

        private void lbApagar_Click(object sender, EventArgs e)
        {
            lbA.Text = "⚫️";
            lbB.Text = "⚫️";
            lbC.Text = "⚫️";
            lbD.Text = "⚫️";
            lbE.Text = "⚫️";
            lbF.Text = "⚫️";
            lbG.Text = "⚫️";
            lbH.Text = "⚫️";
            lbI.Text = "⚫️";
            _padrao = 0;
            txtPass.Text = string.Empty;
        }

        private void lbA_Click(object sender, EventArgs e) => AtualizarPadrao(lbA);
        private void lbB_Click(object sender, EventArgs e) => AtualizarPadrao(lbB);
        private void lbC_Click(object sender, EventArgs e) => AtualizarPadrao(lbC);
        private void lbD_Click(object sender, EventArgs e) => AtualizarPadrao(lbD);
        private void lbE_Click(object sender, EventArgs e) => AtualizarPadrao(lbE);
        private void lbF_Click(object sender, EventArgs e) => AtualizarPadrao(lbF);
        private void lbG_Click(object sender, EventArgs e) => AtualizarPadrao(lbG);
        private void lbH_Click(object sender, EventArgs e) => AtualizarPadrao(lbH);
        private void lbI_Click(object sender, EventArgs e) => AtualizarPadrao(lbI);

        #endregion
    }
}

