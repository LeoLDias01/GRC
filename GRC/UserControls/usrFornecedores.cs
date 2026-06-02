using Business.Helper;
using Business.Services;
using Data.Models;
using GRC.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private readonly Color CorFiltroAtivo = Color.FromArgb(74, 101, 114);   // Azul bem claro esbranquiçado
        private readonly Color CorFiltroInativo = Color.FromArgb(6, 31, 48);             // Se funde totalmente com o fundo
        private readonly Color CorTextoAtivo = Color.FromArgb(44, 62, 80);       // Seu azul escuro acinzentado
        private readonly Color CorTextoInativo = Color.White;  // Cinza fosco para o que está desligado

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

            txtPesquisa.TextChanged += txtPesquisa_TextChanged;

            // Se os seus filtros de Ativo/Inativo forem botões ou rádio buttons,
            // Configura o visual flat inicial dos botões de filtro
            ConfigurarLayoutBotoesFiltro();

            // Eventos de clique que mudam o estado do filtro
            btnFiltroTodos.Click += (s, e) => { _statusSelecionado = null; AtualizarVisualFiltros(); RealizaPesquisa(); };
            btnFiltroAtivos.Click += (s, e) => { _statusSelecionado = true; AtualizarVisualFiltros(); RealizaPesquisa(); };
            btnFiltroInativos.Click += (s, e) => { _statusSelecionado = false; AtualizarVisualFiltros(); RealizaPesquisa(); };


            btnNovoFornecedor.Click += btnNovoFornecedor_Click;



            ConfigurarEstiloGrid();
        }

        private void ConfigurarEstiloGrid()
        {
            // 1. Configurações Gerais de Comportamento e Bordas
            dgvFornecedores.BackgroundColor = Color.FromArgb(244, 246, 249); // Mesma cor do fundo da tela
            dgvFornecedores.BorderStyle = BorderStyle.None;
            dgvFornecedores.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFornecedores.GridColor = Color.FromArgb(226, 232, 240); // Linha divisória suave

            // Garante a seleção da linha inteira de forma limpa
            dgvFornecedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFornecedores.MultiSelect = false;
            dgvFornecedores.RowHeadersVisible = false; // Remove aquela primeira coluna vazia da esquerda
            dgvFornecedores.AllowUserToResizeRows = false;

            // 2. Configuração e Estilização do Header Nativo
            dgvFornecedores.ColumnHeadersVisible = true;
            dgvFornecedores.ColumnHeadersHeight = 48;    // Aumentado ligeiramente para dar mais destaque
            dgvFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvFornecedores.EnableHeadersVisualStyles = false; // OBRIGATÓRIO para aceitar cores personalizadas

            DataGridViewCellStyle estiloHeader = new DataGridViewCellStyle();
            estiloHeader.BackColor = Color.FromArgb(44, 62, 80); // Seu azul escuro acinzentado do sistema
            estiloHeader.ForeColor = Color.White;                // Texto branco para alto contraste
            estiloHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
          
            estiloHeader.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Tira o efeito visual de seleção do Header (mantém a cor original mesmo clicado)
            estiloHeader.SelectionBackColor = Color.FromArgb(44, 62, 80);
            estiloHeader.SelectionForeColor = Color.White;

            // Aplica o estilo ao cabeçalho
            dgvFornecedores.ColumnHeadersDefaultCellStyle = estiloHeader;

            // 3. Estilo Padrão das Linhas (DefaultCellStyle)
            DataGridViewCellStyle estiloLinha = new DataGridViewCellStyle();
            estiloLinha.BackColor = Color.White;
            estiloLinha.ForeColor = Color.FromArgb(45, 52, 54); // Grafite escuro
            estiloLinha.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            estiloLinha.SelectionBackColor = Color.FromArgb(213, 225, 237); // Azul claro acinzentado para seleção
            estiloLinha.SelectionForeColor = Color.FromArgb(30, 39, 46);   // Texto escuro na seleção
            dgvFornecedores.DefaultCellStyle = estiloLinha;

            // 4. Estilo das Linhas Alternadas (Zebrado)
            DataGridViewCellStyle estiloAlternado = new DataGridViewCellStyle();
            estiloAlternado.BackColor = Color.FromArgb(250, 250, 250); // Cinza quase branco
            estiloAlternado.ForeColor = Color.FromArgb(45, 52, 54);
            estiloAlternado.SelectionBackColor = Color.FromArgb(213, 225, 237);
            estiloAlternado.SelectionForeColor = Color.FromArgb(30, 39, 46);
            dgvFornecedores.AlternatingRowsDefaultCellStyle = estiloAlternado;

            // 5. Altura das linhas (dá "respiro" para o visual)
            dgvFornecedores.RowTemplate.Height = 50;
        }
        private void usrFornecedores_Load(object sender, EventArgs e)
        {
            cbRegistros.Text = "10";
            _statusSelecionado = null; // Começa exibindo Todos
            AtualizarVisualFiltros();
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
                            forn.Endereco.Uf
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
    }
}
