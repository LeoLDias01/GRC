using Business.EmailSender;
using Business.Helper;
using Business.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GRC.Telas
{
    public partial class WorkFlow : Form
    {
       /* CriacaoBanco _inicializacao = new CriacaoBanco();*/
        public WorkFlow()
        {
            InitializeComponent();
        }
        // Importar as DLLs do Windows para mover o formulário
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Constantes para a mensagem de movimento
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private void WorkFlow_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            /*_inicializacao.VerificaBanco();*/
            new Login().ShowDialog();
            this.Visible = true;
            //tdbMenuUsuario.Text = Sessao.UsuarioNome;
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            new Fornecedor().ShowDialog();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            new ItemEstoque().ShowDialog();
        }

        private void btnOrdemServiço_Click(object sender, EventArgs e)
        {
            new PesquisaOS().ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            new PesquisaCliente().ShowDialog();
        }

        private void btnMovimentacoes_Click(object sender, EventArgs e)
        {
            new Movimentacoes().ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            new Vendas().ShowDialog();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            prUsuario.Visible = true;
            prUsuario.BringToFront(); // garante que fique por cima
        }

        private void WorkFlow_MouseDown(object sender, MouseEventArgs e)
        {
            prUsuario.Visible = false;
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // Libera o mouse para a operação
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); // Envia comando de mover
            }
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            int identificador = 1;
            this.Visible = false;
            new Login(identificador).ShowDialog();
            this.Visible = true;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            tlpMenu.Visible = true;
            tlpMenu.BringToFront();
            btnMenu.Visible = false;
        }

        private void btnFechaMenuLateral_Click(object sender, EventArgs e)
        {
            tlpMenu.Visible = false;
            btnMenu.Visible = true;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
