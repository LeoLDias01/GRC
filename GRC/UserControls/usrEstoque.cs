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
        }
        private void usrEstoque_Load(object sender, EventArgs e)
        {
            CarregaCombos();
            cbRegistros.Text = "10";
            _statusSelecionado = null; // Começa exibindo Todos
            AtualizarVisualFiltros();
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

        private void cbxQtdRegistros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas dígitos e a tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvItens_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

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
            // 1. Configurações Gerais de Comportamento e Bordas
            dgvItens.BackgroundColor = Color.FromArgb(244, 246, 249); // Mesma cor do fundo da tela
            dgvItens.BorderStyle = BorderStyle.None;
            dgvItens.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvItens.GridColor = Color.FromArgb(226, 232, 240); // Linha divisória suave

            // Garante a seleção da linha inteira de forma limpa
            dgvItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItens.MultiSelect = false;
            dgvItens.RowHeadersVisible = false; // Remove aquela primeira coluna vazia da esquerda
            dgvItens.AllowUserToResizeRows = false;

            // 2. Configuração e Estilização do Header Nativo
            dgvItens.ColumnHeadersVisible = true;
            dgvItens.ColumnHeadersHeight = 48;    // Aumentado ligeiramente para dar mais destaque
            dgvItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvItens.EnableHeadersVisualStyles = false; // OBRIGATÓRIO para aceitar cores personalizadas

            DataGridViewCellStyle estiloHeader = new DataGridViewCellStyle();
            estiloHeader.BackColor = Color.FromArgb(44, 62, 80); // Seu azul escuro acinzentado do sistema
            estiloHeader.ForeColor = Color.White;                // Texto branco para alto contraste
            estiloHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            estiloHeader.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Tira o efeito visual de seleção do Header (mantém a cor original mesmo clicado)
            estiloHeader.SelectionBackColor = Color.FromArgb(44, 62, 80);
            estiloHeader.SelectionForeColor = Color.White;

            // Aplica o estilo ao cabeçalho
            dgvItens.ColumnHeadersDefaultCellStyle = estiloHeader;

            // 3. Estilo Padrão das Linhas (DefaultCellStyle)
            DataGridViewCellStyle estiloLinha = new DataGridViewCellStyle();
            estiloLinha.BackColor = Color.White;
            estiloLinha.ForeColor = Color.FromArgb(45, 52, 54); // Grafite escuro
            estiloLinha.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            estiloLinha.SelectionBackColor = Color.FromArgb(213, 225, 237); // Azul claro acinzentado para seleção
            estiloLinha.SelectionForeColor = Color.FromArgb(30, 39, 46);   // Texto escuro na seleção
            dgvItens.DefaultCellStyle = estiloLinha;

            // 4. Estilo das Linhas Alternadas (Zebrado)
            DataGridViewCellStyle estiloAlternado = new DataGridViewCellStyle();
            estiloAlternado.BackColor = Color.FromArgb(250, 250, 250); // Cinza quase branco
            estiloAlternado.ForeColor = Color.FromArgb(45, 52, 54);
            estiloAlternado.SelectionBackColor = Color.FromArgb(213, 225, 237);
            estiloAlternado.SelectionForeColor = Color.FromArgb(30, 39, 46);
            dgvItens.AlternatingRowsDefaultCellStyle = estiloAlternado;

            // 5. Altura das linhas (dá "respiro" para o visual)
            dgvItens.RowTemplate.Height = 50;
        }
    }
}
