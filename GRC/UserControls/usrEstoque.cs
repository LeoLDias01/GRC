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
        private readonly Color CorFiltroAtivo = Color.FromArgb(74, 101, 114);   // Azul bem claro esbranquiçado
        private readonly Color CorFiltroInativo = Color.Transparent;             // Se funde totalmente com o fundo
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

            // Eventos de clique que mudam o estado do filtro
            btnFiltroTodos.Click += (s, e) => { _statusSelecionado = null; AtualizarVisualFiltros(); RealizaPesquisa(); };
            btnFiltroAtivos.Click += (s, e) => { _statusSelecionado = true; AtualizarVisualFiltros(); RealizaPesquisa(); };
            btnFiltroInativos.Click += (s, e) => { _statusSelecionado = false; AtualizarVisualFiltros(); RealizaPesquisa(); };
        }
        private void usrEstoque_Load(object sender, EventArgs e)
        {
            CarregaCombos();
            cbRegistros.Text = "10";
            _statusSelecionado = null; // Começa exibindo Todos
            AtualizarVisualFiltros();
            RealizaPesquisa();
        }
        private void cbCategoria_DropDownClosed(object sender, EventArgs e)
        {
           chkItemVenda.Focus();
        }
        private void cbMarca_DropDownClosed(object sender, EventArgs e)
        {
            cbCategoria.Focus();
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
        private void PreencherCombo<T>(RoundedComboBox cb, List<T> lista, string display, string value)
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
            lbRegistros.Text = $"{dgvItens.Rows.Count} registros encontrados!";
        }
        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            txtPesquisa.Text = string.Empty;
            new CadastroItem().ShowDialog();
            RealizaPesquisa();
        }
        private void RealizaPesquisa()
        {
            int categoria = cbCategoria.SelectedValue != null ? Convert.ToInt32(cbCategoria.SelectedValue) : 0;
            int marca = cbMarca.SelectedValue != null ? Convert.ToInt32(cbMarca.SelectedValue) : 0;

            /// Monta o objeto com base na pesquisa
            var item = new Item
            {
                CodBarras = string.IsNullOrWhiteSpace(lbCódigoBarras.Text) ? string.Empty : lbCódigoBarras.Text,
                Descricao = string.IsNullOrWhiteSpace(txtPesquisa.Text) ? string.Empty : txtPesquisa.Text,
                Categoria = categoria > 0 ? categoria : 0,
                Fabricante = marca > 0 ? marca : 0,
                ItemVenda = chkItemVenda.Checked ? true : false,
                Ativo = _statusSelecionado


            };

            int registros = Convert.ToInt32(cbRegistros.Text);

            ConfigurarEstiloGrid();

            var lista = _service.BuscaLimitada(item, registros);
            if (lista != null)
            {
                dgvItens.Rows.Clear();
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
            // GRID
            // =====================================================
            dgvItens.BackgroundColor = Color.FromArgb(245, 247, 250);

            dgvItens.BorderStyle = BorderStyle.None;

            dgvItens.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvItens.GridColor = Color.FromArgb(235, 238, 242);

            dgvItens.RowHeadersVisible = false;

            dgvItens.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvItens.MultiSelect = false;

            dgvItens.AllowUserToResizeRows = false;
            dgvItens.AllowUserToResizeColumns = false;

            dgvItens.EnableHeadersVisualStyles = false;

            dgvItens.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvItens.ScrollBars = ScrollBars.Vertical;

            dgvItens.Cursor = Cursors.Hand;

            dgvItens.DefaultCellStyle.WrapMode =
                DataGridViewTriState.False;

            // Altura maior para visual SaaS
            dgvItens.RowTemplate.Height = 96;

            // =====================================================
            // REMOVE VISUAL ANTIGO
            // =====================================================
            dgvItens.AdvancedCellBorderStyle.Left =
                DataGridViewAdvancedCellBorderStyle.None;

            dgvItens.AdvancedCellBorderStyle.Right =
                DataGridViewAdvancedCellBorderStyle.None;

            dgvItens.AdvancedCellBorderStyle.Top =
                DataGridViewAdvancedCellBorderStyle.None;

            dgvItens.AdvancedCellBorderStyle.Bottom =
                DataGridViewAdvancedCellBorderStyle.Single;

            // =====================================================
            // HEADER
            // =====================================================
            dgvItens.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            dgvItens.ColumnHeadersHeight = 52;

            dgvItens.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            DataGridViewCellStyle estiloHeader =
                new DataGridViewCellStyle();

            estiloHeader.BackColor = Color.FromArgb(44, 62, 80);

            estiloHeader.ForeColor = Color.White;

            estiloHeader.Font =
                new Font("Segoe UI Semibold", 10.5f);

            // Centralizado corretamente
            estiloHeader.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            estiloHeader.Padding = Padding.Empty;

            estiloHeader.SelectionBackColor =
                Color.FromArgb(44, 62, 80);

            estiloHeader.SelectionForeColor =
                Color.White;

            dgvItens.ColumnHeadersDefaultCellStyle =
                estiloHeader;

            // =====================================================
            // LINHAS
            // =====================================================
            DataGridViewCellStyle estiloLinha =
                new DataGridViewCellStyle();

            estiloLinha.BackColor = Color.White;

            estiloLinha.ForeColor =
                Color.FromArgb(33, 37, 41);

            estiloLinha.Font =
                new Font("Segoe UI", 10F);

            // Padding mais equilibrado
            estiloLinha.Padding =
                new Padding(12, 6, 12, 6);

            estiloLinha.SelectionBackColor =
                Color.FromArgb(226, 236, 248);

            estiloLinha.SelectionForeColor =
                Color.FromArgb(20, 20, 20);

            estiloLinha.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            dgvItens.DefaultCellStyle = estiloLinha;

            // =====================================================
            // LINHAS ALTERNADAS
            // =====================================================
            DataGridViewCellStyle estiloAlternado =
                new DataGridViewCellStyle();

            estiloAlternado.BackColor =
                Color.FromArgb(250, 251, 252);

            estiloAlternado.ForeColor =
                Color.FromArgb(33, 37, 41);

            estiloAlternado.SelectionBackColor =
                Color.FromArgb(226, 236, 248);

            estiloAlternado.SelectionForeColor =
                Color.FromArgb(20, 20, 20);

            estiloAlternado.Padding =
                new Padding(12, 6, 12, 6);

            dgvItens.AlternatingRowsDefaultCellStyle =
                estiloAlternado;

            // =====================================================
            // CONFIGURAÇÃO DAS COLUNAS
            // =====================================================
            foreach (DataGridViewColumn coluna in dgvItens.Columns)
            {
                // Centraliza títulos
                coluna.HeaderCell.Style.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

                // Conteúdo padrão
                coluna.DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleLeft;

                // =================================================
                // IMAGEM PRINCIPAL DO PRODUTO
                // =================================================
                if (coluna.Name == "colImagem")
                {
                    if (coluna is DataGridViewImageColumn imgProduto)
                    {
                        imgProduto.ImageLayout =
                            DataGridViewImageCellLayout.Zoom;

                        // Coluna fixa
                        imgProduto.AutoSizeMode =
                            DataGridViewAutoSizeColumnMode.None;

                        // Tamanho maior
                        imgProduto.Width = 115;

                        imgProduto.DefaultCellStyle.NullValue = null;

                        imgProduto.DefaultCellStyle.Alignment =
                            DataGridViewContentAlignment.MiddleCenter;

                        // Padding pequeno para imagem crescer
                        imgProduto.DefaultCellStyle.Padding =
                            new Padding(2);
                    }
                }

                // =================================================
                // FAVORITO (ESTRELA)
                // =================================================
                if (coluna.Name == "colFavorito")
                {
                    if (coluna is DataGridViewImageColumn imgFavorito)
                    {
                        // Melhor para ícones pequenos
                        imgFavorito.ImageLayout =
                            DataGridViewImageCellLayout.Zoom;

                        imgFavorito.AutoSizeMode =
                            DataGridViewAutoSizeColumnMode.None;

                        // Coluna pequena
                        imgFavorito.Width = 32;

                        // Espaço interno controlado
                        imgFavorito.DefaultCellStyle.Padding =
                            new Padding(6);

                        imgFavorito.DefaultCellStyle.Alignment =
                            DataGridViewContentAlignment.MiddleCenter;

                        imgFavorito.DefaultCellStyle.NullValue = null;
                    }
                }

                // =====================================================
                // SELEÇÃO
                // =====================================================
                dgvItens.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(226, 236, 248);

                dgvItens.DefaultCellStyle.SelectionForeColor =
                    Color.FromArgb(20, 20, 20);

                dgvItens.ClearSelection();

                dgvItens.ResumeLayout();
            }
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
    }
}
