using Business.Helper;
using Business.Services;
using Data.Models;
using GRC.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRC.UserControls
{
    public partial class usrFornecedores : UserControl
    {
        private ServiceFornecedor _serviceFornecedor = new ServiceFornecedor();

        // Cores para o efeito de filtro ativo/inativo
        private readonly Color CorFiltroAtivo = Color.DarkSlateBlue;   // Azul bem claro esbranquiçado
        private readonly Color CorFiltroInativo = Color.FromArgb(6, 31, 48);             // Se funde totalmente com o fundo
        private readonly Color CorTextoAtivo = Color.FromArgb(44, 62, 80);       // Seu azul escuro acinzentado
        private readonly Color CorTextoInativo = Color.FromArgb(127, 140, 141);  // Cinza fosco para o que está desligado

        // Estado do filtro atual: null = Todos, true = Ativos, false = Inativos
        private bool? _statusSelecionado = null;
        public usrFornecedores()
        {

            InitializeComponent();
            // Registra os eventos dos novos componentes via código
            this.Load += usrFornecedores_Load;

            cbRegistros.TextChanged += cbRegistros_TextChanged;
            cbRegistros.KeyPress += cbRegistros_KeyPress;

            dgvFornecedores.CellValueChanged += dgvFornecedores_CellValueChanged;
            dgvFornecedores.CellDoubleClick += dgvFornecedores_CellDoubleClick;
            dgvFornecedores.CellFormatting += dgvItens_CellFormatting;
            dgvFornecedores.Paint += dgvItens_Paint;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;

            // Se os seus filtros de Ativo/Inativo forem botões ou rádio buttons,
            // Configura o visual flat inicial dos botões de filtro
            ConfigurarLayoutBotoesFiltro();

            // Eventos de clique que mudam o estado do filtro
            btnFiltroTodos.Click += (s, e) => { _statusSelecionado = null; AtualizarVisualFiltros(); RealizaPesquisa(); };
            btnFiltroAtivos.Click += (s, e) => { _statusSelecionado = true; AtualizarVisualFiltros(); RealizaPesquisa(); };
            btnFiltroInativos.Click += (s, e) => { _statusSelecionado = false; AtualizarVisualFiltros(); RealizaPesquisa(); };


            btnNovoFornecedor.Click += btnNovoFornecedor_Click;


            InicializarColunasGrid();
            ConfigurarEstiloGrid();

        }
        private void dgvItens_Paint(object sender, PaintEventArgs e)
        {
            int alturaFaixa = 1;

            Rectangle headerRect = dgvFornecedores.DisplayRectangle;
            headerRect.Y = dgvFornecedores.ColumnHeadersHeight - alturaFaixa;
            headerRect.Height = alturaFaixa;

            using (Brush brush = new SolidBrush(Color.DarkGray))
            {
                e.Graphics.FillRectangle(brush, headerRect);
            }
        }
        private void ConfigurarEstiloGrid()
        {
            dgvFornecedores.SuspendLayout();

            // =====================================================
            // RESET DE HERANÇAS INDESEJADAS
            // =====================================================
            dgvFornecedores.DefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet;
            dgvFornecedores.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet;
            dgvFornecedores.AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet;

            dgvFornecedores.DefaultCellStyle.Padding = Padding.Empty;
            dgvFornecedores.RowsDefaultCellStyle.Padding = Padding.Empty;
            dgvFornecedores.AlternatingRowsDefaultCellStyle.Padding = Padding.Empty;

            // =====================================================
            // CONFIGURAÇÕES GERAIS DO GRID
            // =====================================================
            dgvFornecedores.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgvFornecedores.BorderStyle = BorderStyle.None;
            dgvFornecedores.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFornecedores.GridColor = Color.FromArgb(235, 238, 242);
            dgvFornecedores.RowHeadersVisible = false;
            dgvFornecedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFornecedores.MultiSelect = false;
            dgvFornecedores.AllowUserToResizeRows = false;
            dgvFornecedores.AllowUserToResizeColumns = false;
            dgvFornecedores.EnableHeadersVisualStyles = false;
            dgvFornecedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFornecedores.ScrollBars = ScrollBars.Vertical;
            dgvFornecedores.Cursor = Cursors.Hand;
            dgvFornecedores.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvFornecedores.RowTemplate.Height = 65;

            // Bordas inferiores SaaS
            dgvFornecedores.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dgvFornecedores.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            dgvFornecedores.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            dgvFornecedores.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;

            // =====================================================
            // CONFIGURAÇÃO VISUAL DAS LINHAS (Cores e Destaque)
            // =====================================================
            dgvFornecedores.RowsDefaultCellStyle.BackColor = Color.White;
            dgvFornecedores.RowsDefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41);
            dgvFornecedores.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10F);

            dgvFornecedores.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 243, 248);
            dgvFornecedores.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41);
            dgvFornecedores.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10F);

            // =====================================================
            // CABEÇALHO (Header)
            // =====================================================
            dgvFornecedores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFornecedores.ColumnHeadersHeight = 52;
            dgvFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

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
            dgvFornecedores.ColumnHeadersDefaultCellStyle = estiloHeader;

            // =====================================================
            // CONTROLE ABSOLUTO COLUNA POR COLUNA
            // =====================================================
            foreach (DataGridViewColumn coluna in dgvFornecedores.Columns)
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


                    if (coluna.Name == "colAtivo")
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

            dgvFornecedores.DefaultCellStyle.SelectionBackColor = Color.FromArgb(226, 236, 248);
            dgvFornecedores.DefaultCellStyle.SelectionForeColor = Color.FromArgb(20, 20, 20);
            dgvFornecedores.ClearSelection();

            dgvFornecedores.ResumeLayout();
        }
        private void usrFornecedores_Load(object sender, EventArgs e)
        {
            cbRegistros.Text = "10";
            _statusSelecionado = null; // Começa exibindo Todos
            AtualizarVisualFiltros();
            ConfigurarEstiloGrid();
            RealizaPesquisa();

        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            // Dispara a pesquisa unificada conforme o usuário digita
            RealizaPesquisa();
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

        private void cbRegistros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvFornecedores_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lbRegistros.Text = $"{dgvFornecedores.Rows.Count} registros encontrados!";
        }



        private void dgvFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int? idFornecedor = PegaIdFornecedor(e);
            if (idFornecedor.HasValue)
            {
                using (CadastroFornecedor cadForm = new CadastroFornecedor(idFornecedor.Value))
                {
                    cadForm.StartPosition = FormStartPosition.CenterParent;
                    cadForm.ShowDialog(this.FindForm());
                    RealizaPesquisa();
                }
            }
        }

        private void RealizaPesquisa()
        {
            string termo = txtPesquisa.Text.Trim();

            var fornecedor = new Fornecedores
            {
                Nome = Identidade.RetiraFormatacao(termo), // O seu método do banco lê essa propriedade como o filtro global
                Ativo = _statusSelecionado // Usa a nossa variável de controle de estado
            };

            int registros = Convert.ToInt32(cbRegistros.Text);
            dgvFornecedores.Rows.Clear();
            ConfigurarEstiloGrid();
            var lista = _serviceFornecedor.BuscaLimitada(fornecedor, registros);

            if (lista != null)
            {
                foreach (var forn in lista)
                {
                    if (forn.Id > 0)
                    {
                        dgvFornecedores.Rows.Add(
                            forn.Id,
                            forn.Nome,
                            forn.RazaoSocial,
                            Identidade.FormataIdentidade(forn.Cnpj),
                            forn.Endereco.Cidade,
                            forn.Endereco.Uf,
                            forn.Ativo == true ? "Ativo" : "Inativo"
                        );
                    }
                }
            }

            lbRegistros.Text = $"{dgvFornecedores.Rows.Count} registros encontrados!";
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
        private void ConfigurarLayoutBotoesFiltro()
        {
            // Usamos 'dynamic' na array para que o C# aceite tanto Button quanto CustomButton na mesma lista
            dynamic[] botoes = { btnFiltroTodos, btnFiltroAtivos, btnFiltroInativos };

            foreach (var btn in botoes)
            {
                try
                {
                    //btn.FlatStyle = FlatStyle.Flat;
                    // btn.FlatAppearance.BorderSize = 0; // Sem bordas
                    // btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);

                    // Remove a cor cinza escuro que o Windows Forms joga quando passa o mouse por cima
                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 244, 248);
                    btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(225, 235, 245);
                }
                catch (Exception)
                {
                    // Caso o seu CustomButton não possua alguma dessas propriedades Flat antigas expostas, 
                    // ele ignora o erro e não quebra a abertura da tela.
                    // btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                }
            }
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
        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            txtPesquisa.Text = string.Empty;
            new CadastroFornecedor().ShowDialog();
            RealizaPesquisa();
        }
        private void InicializarColunasGrid()
        {
            dgvFornecedores.Columns.Clear();
            dgvFornecedores.AutoGenerateColumns = false;


            var colId = new DataGridViewTextBoxColumn { Name = "colIdFornecedor", HeaderText = "ID", Visible = false };
            dgvFornecedores.Columns.Add(colId);


            dgvFornecedores.Columns.Add(new DataGridViewTextBoxColumn { Name = "colNomeFornecedor", HeaderText = "Fornecedor", Width = 200 });

            dgvFornecedores.Columns.Add(new DataGridViewTextBoxColumn { Name = "colRazaoSocial", HeaderText = "Razão Social", Width = 130 });

            dgvFornecedores.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCnpj", HeaderText = "CNPJ", Width = 130 });

            dgvFornecedores.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCidade", HeaderText = "Cidade", Width = 160 });


            dgvFornecedores.Columns.Add(new DataGridViewTextBoxColumn { Name = "colUf", HeaderText = "UF", Width = 50 });


            var colAtivo = new DataGridViewImageColumn { Name = "colAtivo", HeaderText = "Ativo", Width = 100, ImageLayout = DataGridViewImageCellLayout.Normal };
            dgvFornecedores.Columns.Add(colAtivo); ;
        }
        private void dgvItens_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvFornecedores.Rows[e.RowIndex];

            // =================================================================
            // 2. STATUS (Ativo [Verde] / Inativo [Vermelho]) - Gerando Tag/Imagem
            // =================================================================
            if (dgvFornecedores.Columns[e.ColumnIndex].Name == "colAtivo" && e.Value != null)
            {
                string status = e.Value.ToString();

                // Se você tiver os ícones prontos em Resources, use: e.Value = (status == "Ativo") ? Resources.tag_ativo : Resources.tag_inativo;
                // Caso queira que o próprio C# desenhe a pílula perfeita sem precisar de arquivos externos:
                if (status == "Ativo")
                    e.Value = CriarTagColorida("Ativo", Color.FromArgb(46, 204, 113), Color.White);
                else
                    e.Value = CriarTagColorida("Inativo", Color.FromArgb(231, 76, 60), Color.White);
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
    }
}
