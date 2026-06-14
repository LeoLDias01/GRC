using Business.Services;
using Data.Models;
using GRC.Componentes;
using GRC.Properties;
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
    public partial class usrOrdemServico : UserControl
    {
        ServiceOrdemServico _service = new ServiceOrdemServico();
        public usrOrdemServico()
        {
            InitializeComponent();

            // Registra os eventos dos novos componentes via código
            this.Load += usrOrdemServico_Load;
            lbTitulo.DoubleClick += lbTitulo_DoubleClick;
            cbRegistros.TextChanged += cbRegistros_TextChanged;
            cbRegistros.KeyPress += cbRegistros_KeyPress;
            dgvOs.CellValueChanged += dgvOs_CellValueChanged;
            dgvOs.CellDoubleClick += dgvOs_CellDoubleClick;
            btnNovaOS.Click += btnNovaOS_Click;
            cbStatus.DropDownClosed += cbStatus_DropDownClosed;


            txtPesquisa.KeyPress += txtPesquisa_KeyPress;

            dgvOs.Paint += dgvOs_Paint;
            dgvOs.CellFormatting += dgvOs_CellFormatting;
        }
        private void dgvOs_Paint(object sender, PaintEventArgs e)
        {
            int alturaFaixa = 1;

            Rectangle headerRect = dgvOs.DisplayRectangle;
            headerRect.Y = dgvOs.ColumnHeadersHeight - alturaFaixa;
            headerRect.Height = alturaFaixa;

            using (Brush brush = new SolidBrush(Color.DarkGray))
            {
                e.Graphics.FillRectangle(brush, headerRect);
            }
        }
        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            RealizaPesquisa();
        }
        private void btnNovaOS_Click(object sender, EventArgs e)
        {
            new CadastroOS().ShowDialog();
            RealizaPesquisa();
        }
        private void lbTitulo_DoubleClick(object sender, EventArgs e)
        {
            LimpaCampos();
        }
        private void LimpaCampos()
        {
            CarregaCombos();
            txtPesquisa.Text = string.Empty;
            dgvOs.Rows.Clear();
            dgvOs.ColumnHeadersVisible = false;
        }
        private void usrOrdemServico_Load(object sender, EventArgs e)
        {

            CarregaCombos();
            cbRegistros.Text = "10";
            InicializarColunasGrid();
            RealizaPesquisa();
            btnNovaOS.Focus();
            ConfigurarEstiloGrid();
        }
        private void CarregaCombos()
        {
            PreencherCombo(cbStatus, _service.BuscaStatus(), "Descricao", "Id");
        }
        private void PreencherCombo<T>(ModernComboBox cb, List<T> lista, string display, string value)
        {
            cb.DisplayMember = display;
            cb.ValueMember = value;
            cb.DataSource = lista;
            cb.SelectedIndex = -1; // nenhum item selecionado — exibe o placeholder
        }
        private void InicializarColunasGrid()
        {
            dgvOs.Columns.Clear();
            dgvOs.AutoGenerateColumns = false;

            var colFavorito = new DataGridViewImageColumn { Name = "colFavorito", HeaderText = "★", Width = 60, ImageLayout = DataGridViewImageCellLayout.Normal };
            dgvOs.Columns.Add(colFavorito);

            var colId = new DataGridViewTextBoxColumn { Name = "colId", HeaderText = "OS", Visible = false };
            dgvOs.Columns.Add(colId);

            dgvOs.Columns.Add(new DataGridViewTextBoxColumn { Name = "colNome", HeaderText = "Cliente", Width = 200 });

            var colTipoVenda = new DataGridViewImageColumn { Name = "colStatus", HeaderText = "Status", Width = 100, ImageLayout = DataGridViewImageCellLayout.Normal };
            dgvOs.Columns.Add(colTipoVenda);

            dgvOs.Columns.Add(new DataGridViewTextBoxColumn { Name = "colData", HeaderText = "Entrada", Width = 90 });
        }
        private void RealizaPesquisa()
        {
            int status = cbStatus.SelectedValue != null ? Convert.ToInt32(cbStatus.SelectedValue) : 0;

            /// Monta o objeto com base na pesquisa
            var os = new OrdemServico
            {

                DadosCliente = new Cliente
                {
                    Nome = txtPesquisa.Text
                },
                Status = status > 0 ? status : 0,
            };

            int registros = Convert.ToInt32(cbRegistros.Text);

            dgvOs.Visible = true;
            dgvOs.Rows.Clear();
            ConfigurarEstiloGrid();
            
            var lista = _service.BuscaLimitada(os, registros);
            if (lista != null)
            {
                foreach (var dadosOrdem in lista)
                {
                    if (dadosOrdem.Id > 0)
                    {
                        dgvOs.Rows.Add(

                        dadosOrdem.Favorito == true ? Resources.star : Resources.starOff,
                        dadosOrdem.Id.ToString(),
                        dadosOrdem.DadosCliente.Nome,
                        dadosOrdem.Status,
                        dadosOrdem.DataEntrada
                        );
                    }
                }
            }

            lbRegistros.Text = $"{dgvOs.Rows.Count} registros encontrados!";
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
            // Permite apenas dígitos e a tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void cbStatus_DropDownClosed(object sender, EventArgs e)
        {
            RealizaPesquisa();
        }
        private void dgvOs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lbRegistros.Text = $"{dgvOs.Rows.Count} registros encontrados!";
        }
        private void dgvOs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int? id = PegaId(e);
            if (id.HasValue)
            {
                new CadastroOS(id.Value).ShowDialog();
                RealizaPesquisa();
            }
        }
        private int? PegaId(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvOs.Rows[e.RowIndex];
                return Convert.ToInt32(row.Cells["colId"].Value);
            }
            return null;
        }
        private void dgvOs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvOs.Rows[e.RowIndex];


            // =================================================================
            // 3. TIPO PRODUTO (Venda [Azul] / Estoque [Invisível]) - Gerando Tag/Imagem
            // =================================================================
            if (dgvOs.Columns[e.ColumnIndex].Name == "colStatus" && e.Value != null)
            {
                int tipo = (int)e.Value;

                if (tipo == 6)
                    e.Value = CriarTagColorida("Aberta", Color.FromArgb(52, 152, 219), Color.White);
                else if (tipo == 7)
                    e.Value = CriarTagColorida("Em Análise", Color.Goldenrod, Color.White);
                else if (tipo == 8)
                    e.Value = CriarTagColorida("Aguardando Cliente", Color.DarkOrange, Color.White);
                else if (tipo == 9)
                    e.Value = CriarTagColorida("Aguardando Peças", Color.DarkOrange, Color.White);
                else if (tipo == 10)
                    e.Value = CriarTagColorida("Entregue", Color.DarkGreen, Color.White);
                else
                    e.Value = CriarTagColorida("Cancelada", Color.Crimson, Color.White);

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
            dgvOs.SuspendLayout();

            // =====================================================
            // RESET DE HERANÇAS INDESEJADAS
            // =====================================================
            dgvOs.DefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet;
            dgvOs.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet;
            dgvOs.AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet;

            dgvOs.DefaultCellStyle.Padding = Padding.Empty;
            dgvOs.RowsDefaultCellStyle.Padding = Padding.Empty;
            dgvOs.AlternatingRowsDefaultCellStyle.Padding = Padding.Empty;

            // =====================================================
            // CONFIGURAÇÕES GERAIS DO GRID
            // =====================================================
            dgvOs.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgvOs.BorderStyle = BorderStyle.None;
            dgvOs.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvOs.GridColor = Color.FromArgb(235, 238, 242);
            dgvOs.RowHeadersVisible = false;
            dgvOs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOs.MultiSelect = false;
            dgvOs.AllowUserToResizeRows = false;
            dgvOs.AllowUserToResizeColumns = false;
            dgvOs.EnableHeadersVisualStyles = false;
            dgvOs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOs.ScrollBars = ScrollBars.Vertical;
            dgvOs.Cursor = Cursors.Hand;
            dgvOs.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvOs.RowTemplate.Height = 96;

            // Bordas inferiores SaaS
            dgvOs.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dgvOs.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            dgvOs.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            dgvOs.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;

            // =====================================================
            // CONFIGURAÇÃO VISUAL DAS LINHAS (Cores e Destaque)
            // =====================================================
            dgvOs.RowsDefaultCellStyle.BackColor = Color.White;
            dgvOs.RowsDefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41);
            dgvOs.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10F);

            dgvOs.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 243, 248);
            dgvOs.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41);
            dgvOs.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10F);

            // =====================================================
            // CABEÇALHO (Header)
            // =====================================================
            dgvOs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvOs.ColumnHeadersHeight = 52;
            dgvOs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

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
            dgvOs.ColumnHeadersDefaultCellStyle = estiloHeader;

            // =====================================================
            // CONTROLE ABSOLUTO COLUNA POR COLUNA
            // =====================================================
            foreach (DataGridViewColumn coluna in dgvOs.Columns)
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

                    if (coluna.Name == "colStatus")
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
                }
            }

            dgvOs.DefaultCellStyle.SelectionBackColor = Color.FromArgb(226, 236, 248);
            dgvOs.DefaultCellStyle.SelectionForeColor = Color.FromArgb(20, 20, 20);
            dgvOs.ClearSelection();

            dgvOs.ResumeLayout();
        }
    }
}
