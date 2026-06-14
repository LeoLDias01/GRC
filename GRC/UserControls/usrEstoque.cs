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
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace GRC.UserControls
{
    public partial class usrEstoque : UserControl
    {
        private ServiceItemEstoque _service = new ServiceItemEstoque();
        private SerialPort _serialPort;

        // Estado do filtro atual: null = Todos, true = Ativos, false = Inativos
        private bool? _statusSelecionado = null;




        // Cores para o efeito de filtro ativo/inativo
        private readonly Color CorFiltroAtivo = Color.DarkSlateBlue;   // Azul bem claro esbranquiçado
        private readonly Color CorFiltroInativo = Color.FromArgb(6, 31, 48);             // Se funde totalmente com o fundo
        private readonly Color CorTextoAtivo = Color.FromArgb(44, 62, 80);       // Seu azul escuro acinzentado
        private readonly Color CorTextoInativo = Color.FromArgb(127, 140, 141);  // Cinza fosco para o que está desligado
        public usrEstoque()
        {
            InitializeComponent();

            // Registra os eventos dos novos componentes via código
            this.Load += usrEstoque_Load;
            lbTitulo.DoubleClick += lbTitulo_DoubleClick;
            cbRegistros.TextChanged += cbRegistros_TextChanged;
            cbRegistros.KeyPress += cbRegistros_KeyPress;
            dgvItens.CellValueChanged += dgvItens_CellValueChanged;
            dgvItens.CellDoubleClick += dgvItens_CellDoubleClick;
            btnNovoItem.Click += btnNovoItem_Click;
            cbCategoria.DropDownClosed += cbCategoria_DropDownClosed;
            cbMarca.SelectedIndexChanged += cbMarca_DropDownClosed;
            chkItemVenda.CheckedChanged += chkItemVenda_CheckedChanged;

            txtPesquisa.KeyPress += txtPesquisa_KeyPress;

            // Eventos de clique que mudam o estado do filtro
            btnFiltroTodos.Click += (s, e) => { _statusSelecionado = null; AtualizarVisualFiltros(); RealizaPesquisa(); };
            btnFiltroAtivos.Click += (s, e) => { _statusSelecionado = true; AtualizarVisualFiltros(); RealizaPesquisa(); };
            btnFiltroInativos.Click += (s, e) => { _statusSelecionado = false; AtualizarVisualFiltros(); RealizaPesquisa(); };
            dgvItens.Paint += dgvItens_Paint;
            dgvItens.CellFormatting += dgvItens_CellFormatting;
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
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
        private void usrEstoque_Load(object sender, EventArgs e)
        {
            
            CarregaCombos();
            cbRegistros.Text = "10";
            _statusSelecionado = null; // Começa exibindo Todos
            AtualizarVisualFiltros();
            InicializarColunasGrid();
            ConfigurarEstiloGrid();
            RealizaPesquisa();
            btnNovoItem.Focus();
        }
        private void cbCategoria_DropDownClosed(object sender, EventArgs e)
        {
            RealizaPesquisa();
        }
        private void cbMarca_DropDownClosed(object sender, EventArgs e)
        {
            RealizaPesquisa();
        }
        private void chkItemVenda_CheckedChanged(object sender, EventArgs e)
        {
            RealizaPesquisa();
        }
        private void AtualizarVisualFiltros()
        {
            // Reseta o fundo de todos para o padrão inativo (transparente)
            btnFiltroTodos.BackColor = CorFiltroInativo;
            btnFiltroAtivos.BackColor = CorFiltroInativo;
            btnFiltroInativos.BackColor = CorFiltroInativo;

            // Aplica o azul bem claro apenas no fundo do botão que está selecionado
            if (_statusSelecionado == null)
            {
                btnFiltroTodos.BackColor = CorFiltroAtivo;
            }
            else if (_statusSelecionado == true)
            {
                btnFiltroAtivos.BackColor = CorFiltroAtivo;
            }
            else if (_statusSelecionado == false)
            {
                btnFiltroInativos.BackColor = CorFiltroAtivo;
            }
        }
        private void lbTitulo_DoubleClick(object sender, EventArgs e)
        {
            LimpaCampos();
        }
        private void CarregaCombos()
        {
            PreencherCombo(cbCategoria, _service.BuscaCategoriaItem(), "Descricao", "Id");
            PreencherCombo(cbMarca, _service.BuscaFabricante(), "Descricao", "Id");
        }
        private void PreencherCombo<T>(ModernComboBox cb, List<T> lista, string display, string value)
        {
            cb.DisplayMember = display;
            cb.ValueMember = value;
            cb.DataSource = lista;
            cb.SelectedIndex = -1; // nenhum item selecionado — exibe o placeholder
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
            lbRegistros.Text = $"{dgvItens.Rows.Count} registros encontrados!";
        }
        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            txtPesquisa.Text = string.Empty;
            new CadastroItem().ShowDialog();
            RealizaPesquisa();
        }
        private void InicializarColunasGrid()
        {
            dgvItens.Columns.Clear();
            dgvItens.AutoGenerateColumns = false;

            // 1. Favorito (Imagem)
            var colFavorito = new DataGridViewImageColumn { Name = "colFavorito", HeaderText = "★", Width = 60, ImageLayout = DataGridViewImageCellLayout.Normal };
            dgvItens.Columns.Add(colFavorito);

            // 2. ID (Invisível)
            var colId = new DataGridViewTextBoxColumn { Name = "colId", HeaderText = "ID", Visible = false };
            dgvItens.Columns.Add(colId);

            // 3. Foto do Item (Imagem)
            var colImagem = new DataGridViewImageColumn { Name = "colImagem", HeaderText = "Foto", Width = 110, ImageLayout = DataGridViewImageCellLayout.Zoom };
            dgvItens.Columns.Add(colImagem);

            // 4. Marcação de Vendas/Estoque (Botão)
            var colTipoVenda = new DataGridViewImageColumn { Name = "colProduto", HeaderText = "Tipo", Width = 100, ImageLayout = DataGridViewImageCellLayout.Normal };
            dgvItens.Columns.Add(colTipoVenda);

            // 5. Nome / Descrição
            dgvItens.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDescricao", HeaderText = "Nome", Width = 200 });

            // 6. Código de Barras
            dgvItens.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCodigoBarras", HeaderText = "Cód. Barras", Width = 130 });

            // 7. Marca
            dgvItens.Columns.Add(new DataGridViewTextBoxColumn { Name = "colFabricante", HeaderText = "Marca", Width = 110 });

            // 8. Categoria
            dgvItens.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCategoria", HeaderText = "Categoria", Width = 110 });

            // 9. Quantidade Mínima
            dgvItens.Columns.Add(new DataGridViewTextBoxColumn { Name = "colQtdMinima", HeaderText = "Qtd Mín.", Width = 90 });

            // 10. Quantidade Atual
            dgvItens.Columns.Add(new DataGridViewTextBoxColumn { Name = "colQtd", HeaderText = "Estoque", Width = 90 });

            // 11. Marcação Ativo/Inativo (Botão)
            var colAtivo = new DataGridViewImageColumn { Name = "colAtivo", HeaderText = "Status", Width = 100, ImageLayout = DataGridViewImageCellLayout.Normal };
            dgvItens.Columns.Add(colAtivo); ;
        }
        private void RealizaPesquisa()
        {
            int categoria = cbCategoria.SelectedValue != null ? Convert.ToInt32(cbCategoria.SelectedValue) : 0;
            int marca = cbMarca.SelectedValue != null ? Convert.ToInt32(cbMarca.SelectedValue) : 0;

            var item = new Item
            {
                CodBarras = string.IsNullOrWhiteSpace(lbCódigoBarras.Text) ? string.Empty : lbCódigoBarras.Text,
                Descricao = string.IsNullOrWhiteSpace(txtPesquisa.Text) ? string.Empty : txtPesquisa.Text,
                Categoria = categoria > 0 ? categoria : 0,
                Fabricante = marca > 0 ? marca : 0,
                ItemVenda = chkItemVenda.Checked,
                Ativo = _statusSelecionado
            };

            int registros = Convert.ToInt32(cbRegistros.Text);

            ConfigurarEstiloGrid();

            var lista = _service.BuscaLimitada(item, registros);

            dgvItens.Rows.Clear();

            if (lista != null)
            {
                foreach (var estoque in lista)
                {
                    if (estoque.Id > 0)
                    {
                        Image foto = null;
                        if (!string.IsNullOrWhiteSpace(estoque.FotoItem))
                        {
                            foto = CriptoImagem.Base64ToImage(estoque.FotoItem);
                        }

                        // IMPORTANTE: Agora passamos os valores booleanos originais ou strings puras, 
                        // e deixaremos o CellFormatting desenhar a imagem correspondente!
                        dgvItens.Rows.Add(
                            estoque.Favorito == true ? Resources.star : Resources.starOff, // 1. colFavorito
                            estoque.Id.ToString(),                                         // 2. colId (Invisível)
                            foto,                                                          // 3. colImagem
                            estoque.ItemVenda == true ? "Venda" : "Estoque",               // 4. colProduto (Texto base)
                            estoque.Descricao,                                             // 5. colDescricao
                            estoque.CodBarras,                                             // 6. colCodigoBarras
                            estoque.DescricaoFabricante,                                   // 7. colFabricante
                            estoque.DescricaoCategoria,                                    // 8. colCategoria
                            estoque.QuatidadeMinima.ToString(),                            // 9. colQtdMinima
                            estoque.Quatidade.ToString(),                                  // 10. colQtd
                            estoque.Ativo == true ? "Ativo" : "Inativo"                    // 11. colAtivo (Texto base)
                        );
                    }
                }
            }

            lbRegistros.Text = $"{dgvItens.Rows.Count} registros encontrados!";
        }
        private void dgvItens_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvItens.Rows[e.RowIndex];

            // =================================================================
            // 1. QUANTIDADE (Preto vs Laranja) - Usando seus novos nomes
            // =================================================================
            if (dgvItens.Columns[e.ColumnIndex].Name == "colQtd")
            {
                decimal qtdAtual = row.Cells["colQtd"].Value != null ? Convert.ToDecimal(row.Cells["colQtd"].Value) : 0;
                decimal qtdMinima = row.Cells["colQtdMinima"].Value != null ? Convert.ToDecimal(row.Cells["colQtdMinima"].Value) : 0;

                if (qtdAtual <= qtdMinima)
                {
                    e.CellStyle.ForeColor = Color.OrangeRed;
                    e.CellStyle.SelectionForeColor = Color.OrangeRed;
                    e.CellStyle.Font = new Font(dgvItens.Font, FontStyle.Bold); // Dá um leve destaque extra
                }
                else
                {
                    e.CellStyle.ForeColor = Color.FromArgb(33, 37, 41);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(20, 20, 20);
                    e.CellStyle.Font = new Font(dgvItens.Font, FontStyle.Regular);
                }
            }

            // =================================================================
            // 2. STATUS (Ativo [Verde] / Inativo [Vermelho]) - Gerando Tag/Imagem
            // =================================================================
            if (dgvItens.Columns[e.ColumnIndex].Name == "colAtivo" && e.Value != null)
            {
                string status = e.Value.ToString();

                // Se você tiver os ícones prontos em Resources, use: e.Value = (status == "Ativo") ? Resources.tag_ativo : Resources.tag_inativo;
                // Caso queira que o próprio C# desenhe a pílula perfeita sem precisar de arquivos externos:
                if (status == "Ativo")
                    e.Value = CriarTagColorida("Ativo", Color.FromArgb(46, 204, 113), Color.White);
                else
                    e.Value = CriarTagColorida("Inativo", Color.FromArgb(231, 76, 60), Color.White);
            }

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
        private void LimpaCampos()
        {
            txtPesquisa.Text = string.Empty;
            CarregaCombos();
            _statusSelecionado = null; // Começa exibindo Todos
            AtualizarVisualFiltros();
            chkItemVenda.Checked = false;
            dgvItens.Rows.Clear();
            dgvItens.ColumnHeadersVisible = false;
            cbRegistros.Text = "10";
        }
        private void ConfigurarEstiloGrid()
        {
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
            dgvItens.RowTemplate.Height = 96;

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
            dgvItens.ColumnHeadersHeight = 52;
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
                    // ALTERAÇÃO AQUI: Verifica se são as colunas de quantidade
                    // IMPORTANTE: Verifique se os Names abaixo batem exatamente com as suas colunas
                    if (coluna.Name == "colQtdMinima" || coluna.Name == "colQtd")
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

                    if (coluna.Name == "colImagem")
                    {
                        if (coluna is DataGridViewImageColumn imgProduto)
                        {
                            imgProduto.ImageLayout = DataGridViewImageCellLayout.Zoom;
                            imgProduto.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                            imgProduto.Width = 115;
                            imgProduto.DefaultCellStyle.NullValue = null;
                            imgProduto.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            imgProduto.DefaultCellStyle.Padding = new Padding(6);
                        }
                    }
                    else if (coluna.Name == "colFavorito")
                    {
                        if (coluna is DataGridViewImageColumn imgFavorito)
                        {
                            imgFavorito.ImageLayout = DataGridViewImageCellLayout.Normal;
                            imgFavorito.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                            imgFavorito.Width = 60;
                            imgFavorito.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            imgFavorito.DefaultCellStyle.NullValue = null;
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
                    else if (coluna.Name == "colAtivo")
                    {
                        if (coluna is DataGridViewImageColumn imgAtivo)
                        {
                            imgAtivo.ImageLayout = DataGridViewImageCellLayout.Normal;
                            imgAtivo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                            imgAtivo.Width = 120;
                            imgAtivo.DefaultCellStyle.NullValue = null;
                            imgAtivo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                            imgAtivo.DefaultCellStyle.Padding = new Padding(0, 0, 20, 0);
                            imgAtivo.HeaderCell.Style.Padding = new Padding(0, 0, 20, 0);
                        }
                    }
                }
            }

            dgvItens.DefaultCellStyle.SelectionBackColor = Color.FromArgb(226, 236, 248);
            dgvItens.DefaultCellStyle.SelectionForeColor = Color.FromArgb(20, 20, 20);
            dgvItens.ClearSelection();

            dgvItens.ResumeLayout();
        }
        private void cbRegistros_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbRegistros.Text))
            {
                if (Convert.ToInt32(cbRegistros.Text) > 100)
                    cbRegistros.Text = "100";
            }
            else cbRegistros.Text = "10";

            RealizaPesquisa();
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
        private long? PegaId(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvItens.Rows[e.RowIndex];
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
