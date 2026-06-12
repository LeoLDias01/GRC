using GRC.Componentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GRC.UserControls
{
    public partial class usrDashboard : UserControl
    {
        public usrDashboard()
        {
            InitializeComponent();

            // Vincula todos os botões ao mesmo manipulador de eventos
            btnFiltroPersonalizado.Click += BotaoFiltro_Click;
            lbPersonalizado.Click += BotaoFiltro_Click;
            btnHoje.Click += BotaoFiltro_Click;
            lbHoje.Click += BotaoFiltro_Click;
            btnOntem.Click += BotaoFiltro_Click;
            lbOntem.Click += BotaoFiltro_Click;
            btnSemana.Click += BotaoFiltro_Click;
            lbSemana.Click += BotaoFiltro_Click;
            btnMes.Click += BotaoFiltro_Click;
            lbMes.Click += BotaoFiltro_Click;

            ConfigurarGraficoLucratividade();
            ConfigurarGraficoOS();
        }
        // O método que gerencia todos os cliques
        private void BotaoFiltro_Click(object sender, EventArgs e)
        {
            ModernBox botaoClicado = null;
            Label labelClicada = null;

            // Clique no Box
            if (sender is ModernBox box)
            {
                botaoClicado = box;

                if (box == btnFiltroPersonalizado) labelClicada = lbPersonalizado;
                else if (box == btnHoje) labelClicada = lbHoje;
                else if (box == btnOntem) labelClicada = lbOntem;
                else if (box == btnSemana) labelClicada = lbSemana;
                else if (box == btnMes) labelClicada = lbMes;
            }
            // Clique na Label
            else if (sender is Label lbl)
            {
                labelClicada = lbl;

                if (lbl == lbPersonalizado) botaoClicado = btnFiltroPersonalizado;
                else if (lbl == lbHoje) botaoClicado = btnHoje;
                else if (lbl == lbOntem) botaoClicado = btnOntem;
                else if (lbl == lbSemana) botaoClicado = btnSemana;
                else if (lbl == lbMes) botaoClicado = btnMes;
            }

            if (botaoClicado == null || labelClicada == null)
                return;

            ConfiguraBtn(botaoClicado, labelClicada);

            pnCustomFilter.Visible = (botaoClicado == btnFiltroPersonalizado);
        }
        private void ConfiguraBtn(ModernBox btnClicado, Label lb)
        {
            // Reset dos boxes
            btnFiltroPersonalizado.FillColor = Color.White;
            btnHoje.FillColor = Color.White;
            btnOntem.FillColor = Color.White;
            btnSemana.FillColor = Color.White;
            btnMes.FillColor = Color.White;

            // Reset das labels
            lbPersonalizado.ForeColor = Color.Black;
            lbHoje.ForeColor = Color.Black;
            lbOntem.ForeColor = Color.Black;
            lbSemana.ForeColor = Color.Black;
            lbMes.ForeColor = Color.Black;

            // Destaca o selecionado
            btnClicado.FillColor = Color.FromArgb(0, 57, 92);
            lb.ForeColor = Color.White;
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

        private void btnFiltroPersonalizado_Click(object sender, EventArgs e)
        {

        }
    }
}
