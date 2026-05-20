using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GRC.Componentes
{
    public partial class ModernBox : Panel
    {
        private int _borderRadius = 12;
        private int _borderSize = 1;
        private Color _borderColor = Color.FromArgb(230, 230, 230);
        private Color _fillColor = Color.White;
        private int _shadowSize = 12;
        private Color _shadowColor = Color.FromArgb(40, 0, 0, 0);
        private int _shadowAngle = 135;

        [Category("Design Moderno")]
        public int BorderRadius
        {
            get => _borderRadius;
            set { _borderRadius = value; this.Invalidate(); }
        }

        [Category("Design Moderno")]
        public int BorderSize
        {
            get => _borderSize;
            set { _borderSize = value; this.Invalidate(); }
        }

        [Category("Design Moderno")]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; this.Invalidate(); }
        }

        [Category("Design Moderno")]
        public Color FillColor
        {
            get => _fillColor;
            set { _fillColor = value; this.Invalidate(); }
        }

        [Category("Sombra Moderna")]
        public int ShadowSize
        {
            get => _shadowSize;
            set { _shadowSize = value; AtualizarPadding(); this.Invalidate(); }
        }

        [Category("Sombra Moderna")]
        public Color ShadowColor
        {
            get => _shadowColor;
            set { _shadowColor = value; this.Invalidate(); }
        }

        [Category("Sombra Moderna")]
        public int ShadowAngle
        {
            get => _shadowAngle;
            set { _shadowAngle = value; this.Invalidate(); }
        }

        public ModernBox()
        {
            this.SetStyle(ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.ResizeRedraw, true);

            this.DoubleBuffered = true;
            this.BackColor = Color.Transparent;
            AtualizarPadding();
        }

        private void AtualizarPadding()
        {
            int margin = _shadowSize + _borderSize + 4;
            this.Padding = new Padding(margin);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // 1. Calcular o deslocamento (offset) baseado no ângulo e tamanho da sombra
            double angleRadians = (Math.PI / 180.0) * _shadowAngle;

            float offsetX = (float)(Math.Cos(angleRadians) * (_shadowSize / 2.0));
            float offsetY = (float)(Math.Sin(angleRadians) * (_shadowSize / 2.0));

            // 2. Definir o retângulo do card principal com margem de segurança
            RectangleF mainRect = new RectangleF(
                _shadowSize - (offsetX < 0 ? offsetX : 0),
                _shadowSize - (offsetY < 0 ? offsetY : 0),
                this.Width - (_shadowSize * 2) - 1,
                this.Height - (_shadowSize * 2) - 1
            );

            if (mainRect.Width <= 0 || mainRect.Height <= 0) return;

            // 3. Desenhar a Sombra Suave (Multi-camadas)
            if (_shadowSize > 0 && _shadowColor.A > 0)
            {
                int layers = 5;
                float maxSpread = _shadowSize;

                for (int i = layers; i >= 1; i--)
                {
                    float spread = (maxSpread / layers) * i;
                    int alpha = (int)(_shadowColor.A * (1.0 - (double)i / (layers + 1)));
                    Color layerColor = Color.FromArgb(alpha, _shadowColor.R, _shadowColor.G, _shadowColor.B);

                    RectangleF shadowRect = mainRect;
                    shadowRect.Offset(offsetX, offsetY);
                    shadowRect.Inflate(spread / 2f, spread / 2f);

                    using (GraphicsPath shadowPath = GetRoundedPath(shadowRect, _borderRadius + (int)(spread / 2f)))
                    using (SolidBrush shadowBrush = new SolidBrush(layerColor))
                    {
                        g.FillPath(shadowBrush, shadowPath);
                    }
                }
            }

            // 4. Desenhar o Fundo do Card
            using (GraphicsPath mainPath = GetRoundedPath(mainRect, _borderRadius))
            using (SolidBrush fillBrush = new SolidBrush(_fillColor))
            {
                g.FillPath(fillBrush, mainPath);

                // 5. Desenhar a Borda
                if (_borderSize > 0)
                {
                    using (Pen borderPen = new Pen(_borderColor, _borderSize))
                    {
                        borderPen.Alignment = PenAlignment.Inset;
                        g.DrawPath(borderPen, mainPath);
                    }
                }
            }
        }

        private GraphicsPath GetRoundedPath(RectangleF rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float d = radius * 2f;

            if (d > rect.Width) d = rect.Width;
            if (d > rect.Height) d = rect.Height;
            if (d <= 0) d = 1f;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);

            path.CloseFigure();
            return path;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AtualizarPadding();
            this.Invalidate();
        }
    }
}