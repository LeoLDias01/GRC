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
using System.Windows.Forms.DataVisualization.Charting;
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
            FazerLogin();
            
        }
        private void FazerLogin()
        {
            this.Hide();

            if (new Login().ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void WorkFlow_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // Libera o mouse para a operação
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); // Envia comando de mover
            }
        }

   
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnEncerrarJanelas_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        // Método genérico: aceita QUALQUER User Control que você criar
        public void AlterarTela(UserControl novaTela)
        {
            // 1. Verifica se já existe alguma tela no painel
            if (pnWorkflow.Controls.Count > 0)
            {
                // Remove a tela antiga e libera a memória dela imediatamente
                pnWorkflow.Controls[0].Dispose();
                pnWorkflow.Controls.Clear();
            }

            // 2. Configura a nova tela para preencher todo o painel dinamicamente
            novaTela.Dock = DockStyle.Fill;

            // 3. Adiciona a nova tela dentro do painel e joga ela para a frente
            pnWorkflow.Controls.Add(novaTela);
            novaTela.BringToFront();
            sidebar1.BringToFront(); 
        }


    }
}
