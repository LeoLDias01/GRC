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
            ConfigurarGraficoLucratividade();
            ConfigurarGraficoOS();
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
            lbNome.Text = Sessao.UsuarioNome;
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


        

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            prUsuario.Visible = false;
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // Libera o mouse para a operação
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); // Envia comando de mover
            }
        }

        private void tlpMenuRedux_MouseHover(object sender, EventArgs e)
        {
            
            tlpMenuRedux.Visible = false;
        }


        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
         
            tlpMenuRedux.Visible = false;
        }

        private void customButton4_MouseHover(object sender, EventArgs e)
        {
            
            tlpMenuRedux.Visible = false;
        }

        private void btnCustomFilter_Click(object sender, EventArgs e)
        {
            ConfiguraBtn(btnCustomFilter);
            pnCustomFilter.Visible = true;
        }

        private void btnOS_Click(object sender, EventArgs e)
        {
            new PesquisaOS().ShowDialog();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            new ItemEstoque().ShowDialog();
        }

        private void btnHoje_Click(object sender, EventArgs e)
        {
            ConfiguraBtn(btnHoje);
        }
        private void ConfiguraBtn(System.Windows.Forms.Button btn)
        {
            pnCustomFilter.Visible = false;
            btnCustomFilter.BackColor = Color.FromArgb(0, 20, 30);
            btnHoje.BackColor = Color.FromArgb(0, 20, 30);
            btnOntem.BackColor = Color.FromArgb(0, 20, 30);
            btnSemana.BackColor = Color.FromArgb(0, 20, 30);
            btnMes.BackColor = Color.FromArgb(0, 20, 30);

            btn.BackColor = Color.DarkSlateBlue;  
        }

        private void btnOntem_Click(object sender, EventArgs e)
        {
            ConfiguraBtn(btnOntem);
        }

        private void btnSemana_Click(object sender, EventArgs e)
        {
            ConfiguraBtn(btnSemana);
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            ConfiguraBtn(btnMes);
        }





        // ============================================
        // GRÁFICO DE LUCRATIVIDADE (Spline)
        // ============================================
        private void ConfigurarGraficoLucratividade()
        {
            crtDadosProdutividade.Series.Clear();
            crtDadosProdutividade.ChartAreas.Clear();
            crtDadosProdutividade.Titles.Clear();

            ChartArea area = new ChartArea("AreaPrincipal");

            area.BackColor = Color.White;

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(230, 230, 230);

            area.AxisX.LabelStyle.ForeColor = Color.DimGray;
            area.AxisY.LabelStyle.ForeColor = Color.DimGray;

            area.AxisX.LineColor = Color.LightGray;
            area.AxisY.LineColor = Color.LightGray;

            area.AxisX.Interval = 1;

            crtDadosProdutividade.ChartAreas.Add(area);

            Series serieLucro = new Series("Lucro")
            {
                ChartType = SeriesChartType.Spline,
                BorderWidth = 4,
                Color = Color.FromArgb(0, 120, 215),
                XValueType = ChartValueType.String,
                IsValueShownAsLabel = true,
                LabelForeColor = Color.Black,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };

            // Dados falsos
            serieLucro.Points.AddXY("Jan", 4200);
            serieLucro.Points.AddXY("Fev", 5100);
            serieLucro.Points.AddXY("Mar", 4800);
            serieLucro.Points.AddXY("Abr", 6200);
            serieLucro.Points.AddXY("Mai", 7300);
            serieLucro.Points.AddXY("Jun", 6900);
            serieLucro.Points.AddXY("Jul", 8100);

            crtDadosProdutividade.Series.Add(serieLucro);

            Title titulo = new Title
            {
                Text = "Lucratividade Mensal",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.FromArgb(45, 45, 45)
            };

            crtDadosProdutividade.Titles.Add(titulo);

            crtDadosProdutividade.Legends.Clear();
        }

        // ============================================
        // GRÁFICO STATUS DAS OS (Doughnut)
        // ============================================
        private void ConfigurarGraficoOS()
        {
            crtDadosOS.Series.Clear();
            crtDadosOS.ChartAreas.Clear();
            crtDadosOS.Titles.Clear();
            crtDadosOS.Legends.Clear();

            ChartArea area = new ChartArea("AreaOS");
            area.BackColor = Color.White;

            crtDadosOS.ChartAreas.Add(area);

            Legend legenda = new Legend
            {
                Docking = Docking.Bottom,
                Alignment = StringAlignment.Center,
                Font = new Font("Segoe UI", 9)
            };

            crtDadosOS.Legends.Add(legenda);

            Series serieOS = new Series("Status")
            {
                ChartType = SeriesChartType.Doughnut,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                IsValueShownAsLabel = true,
                LabelForeColor = Color.White
            };

            // Dados falsos
            serieOS.Points.AddXY("Concluídas", 45);
            serieOS.Points.AddXY("Em Andamento", 20);
            serieOS.Points.AddXY("Aguardando Peça", 12);
            serieOS.Points.AddXY("Canceladas", 5);

            // Cores
            serieOS.Points[0].Color = Color.FromArgb(40, 167, 69);
            serieOS.Points[1].Color = Color.FromArgb(0, 123, 255);
            serieOS.Points[2].Color = Color.FromArgb(255, 193, 7);
            serieOS.Points[3].Color = Color.FromArgb(220, 53, 69);

            // Efeito de "anel"
            serieOS["DoughnutRadius"] = "60";

            crtDadosOS.Series.Add(serieOS);

            Title titulo = new Title
            {
                Text = "Status das Ordens de Serviço",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.FromArgb(45, 45, 45)
            };

            crtDadosOS.Titles.Add(titulo);
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            new Vendas().ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            new PesquisaCliente().ShowDialog();
        }

        private void btnMovimentacao_Click(object sender, EventArgs e)
        {
            new Movimentacoes().ShowDialog();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            new Fornecedor().ShowDialog();
        }
    }
}
