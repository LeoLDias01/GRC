using Business.Helper;
using Business.Services;
using Business.Session;
using Data.Models;
using GRC.Componentes;
using GRC.Properties;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace GRC.Telas
{
    public partial class Vendas : Form
    {
        private List<Item> _itemEstoque = new List<Item>();
        private Caixa _caixa = new Caixa();
        private Cliente _cliente = new Cliente();
        private Venda _venda = new Venda();
        private ServiceVenda _service = new ServiceVenda();

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
        public Vendas()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Garante que está sem borda
            this.DoubleBuffered = true; // Melhora a performance visual ao redimensionar
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        public static void SetDoubleBuffered(Control control)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, control, new object[] { true });
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
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Vendas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // Libera o mouse para a operação
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); // Envia comando de mover
            }
        }

        private void txtCliente_TrailingIconClick(object sender, EventArgs e)
        {
            
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            // Deixo a tela de vendas invisível
            this.Visible = false;

            // Busca o usuário logado no momento
            lbUser.Text = Sessao.UsuarioNome;

            SetDoubleBuffered(flpItens);

            #region Verificação de Caixa

            // Buscando do banco dados de caixa aberto, se não houver o retorno é null
            var validacaoCaixa = _service.VerificaCaixa();


            // Caso 1: Nenhum caixa aberto
            if (validacaoCaixa.FirstOrDefault() == null)
            {
                
                if (new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning,
                     "CAIXA", "O caixa está fechado no momento! Para conseguir vender abra o caixa... ", 
                     "Podemos iniciar a abertura?", true).ShowDialog() == DialogResult.Yes)
                {
                    GerenciamentoAbertura(1); // Abertura
                }
                else
                {
                    this.Close();
                }
            }
            // Caso 2: Caixa aberto com outra data 
            else if (validacaoCaixa.FirstOrDefault().DataAbertura == DateTime.Today)
            {
                if (new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning,
                      "CAIXA", "O caixa está aberto com uma data diferente\nFeche o caixa anterior e abra um novo com a data de hoje",
                      "Podemos iniciar o fechamento?", true).ShowDialog() == DialogResult.Yes)
                {
                    GerenciamentoAbertura(2); // Fechamento

                    if (new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning,
                    "CAIXA", "O caixa está fechado no momento! Para conseguir vender abra o caixa... ",
                    "Podemos iniciar a abertura?", true).ShowDialog() == DialogResult.Yes)
                    {
                        GerenciamentoAbertura(1); // Abertura
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                // CENÁRIO: Caixa já está aberto
                 _caixa.Id = (int)validacaoCaixa.FirstOrDefault().Id;
                 CarregaDadosCaixa();
            }
            #endregion

            CarregaItensVenda();

            // Simula o clique no primeiro botão (Todos) para organizar o layout inicial
            if (flpGrupos.Controls.Count > 0 && flpGrupos.Controls[0] is CustomButton btnTodos)
            {
                btnTodos.PerformClick();
            }

        }
        private void CarregaItensVenda()
        {

            flpGrupos.Controls.Clear();
            flpItens.Controls.Clear();
            var gruposItens = _service.BuscaGruposItens();

            // Busca todos os itens do estoque
            _itemEstoque = new List<Item>();
            _itemEstoque = _service.BuscaItens();
            if (gruposItens != null && gruposItens.Count > 0)
            {
                // Botão "TODOS" para limpar o filtro
                AdicionarBotaoGrupo("Todos", Color.SlateGray);

                foreach (var grupo in gruposItens)
                {
                    AdicionarBotaoGrupo(grupo.Descricao, Color.FromArgb(0, 149, 198), grupo.Id);
                }
            }
            if (_itemEstoque != null)
            {
                ConfiguraCard();
                foreach (var itm in _itemEstoque)
                {
                    if (itm.Quatidade > 0)
                    {
                        
                        CriaCardItem(new ItemCard
                        {
                            Id = 0,
                            IdItem = (int)itm.Id > 0 ? (int)itm.Id : 0,
                            Categoria = itm.Categoria,
                            Descricao = itm.DescricaoVenda,
                            CodBarras = itm.CodBarras,
                            Quantidade = 1,
                            QuantidadeMaxima = itm.Quatidade,
                            FotoItem = itm.FotoItem,
                            ValorUnitario = Convert.ToDecimal(itm.VendaUnitario.Replace("R$", "").Replace(",", "."))
                        }, true);
                    }
                    else
                    {
                        new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Item de Estoque", itm.Descricao.ToString(), "Não pode ser adicionado pois estoque está zerado!", false).ShowDialog();
                    }
                }
            }
        }
        private void AdicionarBotaoGrupo(string nome, Color cor, int idGrupo = 0)
        {
            CustomButton btn = new CustomButton();
            btn.Text = nome;
            btn.Size = new Size(120, 80); // Ajuste conforme seu layout
            btn.BackColor = cor;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.TamanhoRaio = 10;
            btn.TamanhoBorda = 2;
            btn.CorBorda = Color.White;
            btn.Cursor = Cursors.Hand;
            btn.Tag = idGrupo;

            // Evento de clique
            btn.Click += (s, e) => {
                var btnClicado = (CustomButton)s;
                int idFiltro = (int)btnClicado.Tag;

                // Se o ID for 0, passamos null para o filtro mostrar todos
                FiltrarItensPorGrupo(idFiltro == 0 ? (int?)null : idFiltro);
            };

            flpGrupos.Controls.Add(btn);
        }
        private void ConfiguraCard()
        {
            flpItens.AutoScroll = true;
            flpItens.FlowDirection = FlowDirection.LeftToRight; // Itens um ao lado do outro
            flpItens.WrapContents = true; // Quebra para a linha de baixo quando não couber

        }
        private void GerenciamentoAbertura(int operacao)
        {
            // Abre a sua tela de abertura de caixa
            using (var frm = new AberturaCaixa(operacao))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Se ele abriu o caixa com sucesso, você pega o novo ID e libera a tela

                    _caixa.Id = frm._dadosCaixa.Id;
                    CarregaDadosCaixa();
                }
                else
                {
                    this.Close(); // Se ele cancelar a abertura, fecha a tela de vendas
                }
            }

        }
        private PainelRadius _cardSelecionado = null;
        private List<ItemCard> _itensOS = new List<ItemCard>();
        private void CriaCardItem(ItemCard item, bool validarDuplicado)
        {
            decimal.TryParse(item.ValorUnitario.ToString(), NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal unit);

            if (validarDuplicado)
            {
                bool jaExiste = _itensOS.Any(i => i.IdItem == item.IdItem);
                if (jaExiste)
                {
                    var cardExistente = flpItens.Controls
                        .OfType<PainelRadius>()
                        .FirstOrDefault(c => c.Tag is ItemCard os && os.IdItem == item.IdItem);

                    if (cardExistente != null)
                    {
                        flpItens.ScrollControlIntoView(cardExistente);
                        PiscarCard(cardExistente);
                    }

                    new AlertBox(Color.Goldenrod, Color.Black, Color.Yellow, Resources.Warning,
                        "Item já adicionado", item.Descricao, "Este item já está na ordem de serviço.", false).ShowDialog();

                    return;
                }
            }

            ItemCard itemOS = new ItemCard
            {
                Id = item.Id,
                IdItem = (int)item.IdItem,
                Categoria = item.Categoria,
                Descricao = item.Descricao,
                ValorUnitario = unit,
                Quantidade = item.Quantidade,
                QuantidadeMaxima = item.QuantidadeMaxima,
                FotoItem = item.FotoItem,
            };

            PainelRadius card = new PainelRadius
            {
                Width = 180,
                Height = 280,
                Radius = 35,
                BackColor = Color.White,
                BorderColor = Color.WhiteSmoke,
                Thickness = 5,
                Tag = item,
                Cursor = Cursors.Hand
            };

            // Cores para a lógica de seleção
            Color corBordaNormal = Color.FromArgb(0, 46, 68);
            Color corBordaSelecao = Color.Orange;

            void SelecionarEsteCard()
            {
                if (_cardSelecionado == card) return;

                if (_cardSelecionado != null)
                {
                    _cardSelecionado.BorderColor = corBordaNormal;
                    _cardSelecionado.Invalidate();
                }

                _cardSelecionado = card;
                card.BorderColor = corBordaSelecao;
                card.Invalidate();
            }

            // --- Criação dos Controles Internos ---
            PictureBox foto = new PictureBox
            {
                Size = new Size(160, 140),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.Transparent,
                Image = string.IsNullOrEmpty(item.FotoItem) ? null : CriptoImagem.Base64ToImage(item.FotoItem)
            };

            Label lblCodigo = new Label { Text = item.CodBarras, Location = new Point(10, 155), Width = 160, Font = new Font("Segoe UI", 7), ForeColor = Color.Gray, AutoSize = false, TextAlign = ContentAlignment.MiddleLeft };
            Label lblNome = new Label { Text = item.Descricao, Location = new Point(10, 175), Width = 160, Height = 35, Font = new Font("Segoe UI", 9, FontStyle.Bold), ForeColor = Color.FromArgb(43, 69, 98), AutoEllipsis = true, AutoSize = false };
            Label lblPreco = new Label { Text = item.ValorUnitario.ToString("C2"), Location = new Point(10, 215), AutoSize = true, Font = new Font("Segoe UI", 12, FontStyle.Bold), ForeColor = Color.ForestGreen };
            Label lblEstoque = new Label { Text = $"Disponível: {item.QuantidadeMaxima}", Location = new Point(10, 245), AutoSize = true, Font = new Font("Segoe UI", 8, FontStyle.Italic), ForeColor = item.QuantidadeMaxima > 0 ? Color.DimGray : Color.Red };

            // Adiciona os controles ao card
            card.Controls.Add(foto);
            card.Controls.Add(lblCodigo);
            card.Controls.Add(lblNome);
            card.Controls.Add(lblPreco);
            card.Controls.Add(lblEstoque);

            // Eventos de Clique (Card e Filhos)
            card.Click += (s, e) => SelecionarEsteCard();
            foreach (Control c in card.Controls)
            {
                c.Cursor = Cursors.Hand;
                c.Click += (s, e) => SelecionarEsteCard();
            }

            flpItens.Controls.Add(card);
        }
 
        private async void PiscarCard(Control card)
        {

            // Pegamos o componente como PainelRadius para poder resetar a borda também
            var pnl = card as PainelRadius;
            Color corOriginal = Color.White;
            Color corBordaOriginal = Color.FromArgb(0, 46, 68);
            Color corDestaque = Color.FromArgb(255, 220, 180);

            try
            {
                for (int i = 0; i < 3; i++)
                {
                    card.BackColor = corDestaque;
                    if (pnl != null) pnl.BorderColor = Color.Orange; // Opcional: piscar borda

                    await Task.Delay(5);

                    card.BackColor = corOriginal;
                    if (pnl != null) pnl.BorderColor = corBordaOriginal;

                    await Task.Delay(5);
                }
            }
            finally
            {
                // Garante que o card volte ao estado normal e libera o Hover
                card.BackColor = corOriginal;
                if (pnl != null) pnl.BorderColor = corBordaOriginal;
              
                card.Refresh();
            }
        }
        private void FiltrarItensPorGrupo(int? idGrupoFiltro)
        {
            // Suspende o layout para evitar "piscadeira" enquanto esconde os itens
            flpItens.SuspendLayout();

            foreach (Control ctrl in flpItens.Controls)
            {
                // Tentamos pegar o item guardado na Tag do Card
                if (ctrl is PainelRadius card && card.Tag is ItemCard item)
                {
                    if (idGrupoFiltro == null)
                    {
                        // Se o filtro for nulo (Botão Todos), mostra tudo
                        ctrl.Visible = true;
                    }
                    else
                    {
                        // Se o ID do grupo do item for igual ao filtro, mostra. Senão, esconde.
                        ctrl.Visible = (item.Categoria == idGrupoFiltro);
                    }
                }
            }

            flpItens.ResumeLayout();
        }
        private void CarregaDadosCaixa()
        {
            var caixa = _service.CarregaDadosCaixa(_caixa.Id);
            if (caixa != null)
            {
                this.Visible = true;
                foreach (var dados in caixa)
                {
                    lbDataAbertura.Text = $"Abertura: {dados.DataAbertura.ToString("dd/MM/yyyy HH:mm")}";
                    lbSaldo.Text = $"Saldo: {dados.SaldoCaixa.ToString("C2")}";
                    lbUser.Text = dados.NomeUsuario;
                }

            }
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            new CadastroItem().ShowDialog();
            CarregaItensVenda();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            new CadastroCliente().ShowDialog();
        }
        
       /* private void FiltrarItensPorGrupo(int? idGrupoFiltro)
        {
          //  flpItens.SuspendLayout();

            foreach (Control ctrl in flpItens.Controls)
            {
                // Se idGrupoFiltro for null (Botão TODOS), mostra tudo.
                // Se não, tenta converter a Tag do Card para int e compara.
                if (idGrupoFiltro == null)
                {
                    ctrl.Visible = true;
                }
                else
                {
                    // Verifica se a Tag do controle é igual ao ID do grupo clicado
                    if (ctrl.Tag != null && int.TryParse(ctrl.Tag.ToString(), out int idGrupoCard))
                    {
                        ctrl.Visible = (idGrupoCard == idGrupoFiltro);
                    }
                    else
                    {
                        ctrl.Visible = false;
                    }
                }
            }

            //flpItens.ResumeLayout();
        }*/

        private void lbCliente_Click(object sender, EventArgs e)
        {
            BuscaCliente();
        }

        private void lbIdentidadeCliente_Click(object sender, EventArgs e)
        {
            BuscaCliente();
        }
        private void BuscaCliente()
        {
            PesquisaRapidaCliente frm = new PesquisaRapidaCliente(); if (frm.ShowDialog() == DialogResult.OK)

            {
                _cliente = frm.ClienteSelecionado;

                lbCliente.Text = $"Cliente: {_cliente.Nome}          CPF/CNPJ: {_cliente.Identidade}";

            }      
        }

        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {         
                GerenciamentoAbertura(2); // Fechamento
        }

        private void btnFinalizadores_Click(object sender, EventArgs e)
        {
            new Finalizadores().ShowDialog();
        }

        private void btnSangria_Click(object sender, EventArgs e)
        {
            GerenciamentoAbertura(3); // Fechamento
        }

        private void btnAcrescimo_Click(object sender, EventArgs e)
        {
            int operacao = 2;
            AlteraValorVenda(operacao);
        }

        private void btnDesconto_Click(object sender, EventArgs e)
        {
            int operacao = 1;
            AlteraValorVenda(operacao);
        }
        private void AlteraValorVenda(int operacao)
        {
            AlteracaoValorVenda frm = new AlteracaoValorVenda(_venda.Subtotal, operacao); 
            if (frm.ShowDialog() == DialogResult.OK)
            {
                

            }
        }
    }
}
