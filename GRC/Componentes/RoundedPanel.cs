using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace GRC.Componentes
{
    public partial class RoundedPanel : Panel
    {
        // =========================================================
        // PROPRIEDADES DE APARÊNCIA (APENAS GRADIENTE E RAIO)
        // =========================================================

        private int _cornerRadius = 10;
        [Category("Aparência Personalizada")]
        [Description("Raio para arredondar os cantos do Painel.")]
        public int CornerRadius
        {
            get { return _cornerRadius; }
            set
            {
                _cornerRadius = Math.Max(1, value);
                this.SetRegion();
                this.Invalidate();
            }
        }

        // --- Gradiente ---
        private Color _color1 = Color.FromArgb(40, 100, 255);
        [Category("Aparência Personalizada")]
        [Description("Primeira cor do preenchimento gradiente.")]
        public Color Color1
        {
            get { return _color1; }
            set { _color1 = value; this.Invalidate(); }
        }

        private Color _color2 = Color.FromArgb(0, 50, 200);
        [Category("Aparência Personalizada")]
        [Description("Segunda cor do preenchimento gradiente.")]
        public Color Color2
        {
            get { return _color2; }
            set { _color2 = value; this.Invalidate(); }
        }

        private float _gradientAngle = 45f;
        [Category("Aparência Personalizada")]
        [Description("Ângulo do gradiente em graus.")]
        public float GradientAngle
        {
            get { return _gradientAngle; }
            set { _gradientAngle = value; this.Invalidate(); }
        }

        // =========================================================
        // CONSTRUTOR E MÉTODOS DE CONTROLE
        // =========================================================
        public RoundedPanel()
        {
            // Otimização para reduzir o flicker
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.ResizeRedraw |
                          ControlStyles.UserPaint, true);
            this.UpdateStyles();

            this.BackColor = Color.Transparent;
        }

        // Chama SetRegion na criação do handle e no redimensionamento
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SetRegion();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetRegion();
        }

        // Define a região de recorte para os controles filhos (importante para o arredondamento)
        private void SetRegion()
        {
            // O retângulo principal é o ClientRectangle, sem margem necessária.
            Rectangle rect = this.ClientRectangle;

            using (GraphicsPath path = GetRoundedRectanglePath(rect, _cornerRadius))
            {
                this.Region = new Region(path);
            }
        }

        // =========================================================
        // MÉTODOS DE DESENHO
        // =========================================================

        // Cria o GraphicsPath para o retângulo arredondado
        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            // Garante que o raio não exceda metade da menor dimensão
            int r = Math.Min(radius, Math.Min(rect.Width / 2, rect.Height / 2));

            int x = rect.X;
            int y = rect.Y;
            int w = rect.Width;
            int h = rect.Height;

            // Adiciona os arcos e linhas para criar o caminho arredondado
            path.AddArc(x, y, 2 * r, 2 * r, 180, 90);           // Superior Esquerdo
            path.AddArc(x + w - 2 * r, y, 2 * r, 2 * r, 270, 90);   // Superior Direito
            path.AddArc(x + w - 2 * r, y + h - 2 * r, 2 * r, 2 * r, 0, 90); // Inferior Direito
            path.AddArc(x, y + h - 2 * r, 2 * r, 2 * r, 90, 90);    // Inferior Esquerdo

            path.CloseAllFigures();

            return path;
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = this.ClientRectangle;

            // --- 1. DESENHAR O PAINEL PRINCIPAL (Gradiente) ---
            using (GraphicsPath mainPath = GetRoundedRectanglePath(rect, _cornerRadius))
            {
                // Desenha o gradiente (preenchimento)
                using (LinearGradientBrush gradientBrush = new LinearGradientBrush(
                    rect, _color1, _color2, _gradientAngle))
                {
                    g.FillPath(gradientBrush, mainPath);
                }
            }

            // A borda foi removida.

            base.OnPaint(e);
        }
    }
}
