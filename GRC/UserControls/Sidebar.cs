using Business.Session;
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
    public partial class Sidebar : UserControl
    {
        public Sidebar()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            PopUpUsuario card = new PopUpUsuario();
            card.StartPosition = FormStartPosition.Manual;

            // 1. Define a largura da barra lateral ativa
            int sidebarWidth = tlpMenu.Visible ? tlpMenu.Width : tlpMenuRedux.Width;

            // 2. Posição X: Colado na lateral direita da sidebar
            int x = this.Left + sidebarWidth;

            // 3. Posição Y: Alinhado à base (fundo) do seu formulário principal minus a altura do próprio card
            // Isso garante que o rodapé do card fique alinhado com o rodapé do seu programa
            int y = this.Bottom - card.Height;

            // Se você quiser que ele fique colado no canto inferior da TELA DO WINDOWS inteira (perto da barra de tarefas):
            // Rectangle areaTrabalho = Screen.FromControl(this).WorkingArea;
            // int x = areaTrabalho.Left + sidebarWidth; // ou apenas areaTrabalho.Left se quiser ignorar a sidebar
            // int y = areaTrabalho.Bottom - card.Height;

            card.Location = new Point(x, y);
            card.Show();

        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            ExpandirMenu(true);
            lbNomeUser.Text = Sessao.UsuarioNome;
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            ExpandirMenu(false);
        }

        private void ExpandirMenu(bool expandido)
        {
            tlpMenu.Visible = expandido;
            tlpMenuRedux.Visible = !expandido;

            this.Width = expandido ? tlpMenu.Width : tlpMenuRedux.Width;
        }

        private void btnDashboardEx_Click(object sender, EventArgs e)
        {
            MudaForm(new usrDashboard());
        }

        private void btnOSEx_Click(object sender, EventArgs e)
        {
            new PesquisaOS().ShowDialog();
        }

        private void btnVendasEx_Click(object sender, EventArgs e)
        {
            new Vendas().ShowDialog();
        }

        private void btnClientesEx_Click(object sender, EventArgs e)
        {
            MudaForm(new usrClientes());
        }

        private void Sidebar_Load(object sender, EventArgs e)
        {
            MudaForm(new usrDashboard());
        }

        private void btnFornecedoresEx_Click(object sender, EventArgs e)
        {
            MudaForm(new usrFornecedores());
        }
        private void MudaForm(UserControl tela)
        {
            // Encontra o Form Principal onde a sidebar está espetada
            if (this.FindForm() is WorkFlow formPrincipal)
            {
                // Envia para o método do Form Principal exibir
                formPrincipal.AlterarTela(tela);
            }
        }

        private void btnEstoqueEx_Click(object sender, EventArgs e)
        {
            MudaForm(new usrEstoque());
        }

        private void btnMovimentacoesEx_Click(object sender, EventArgs e)
        {
            MudaForm(new usrMovimento());
        }
    }
}
