using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRC.Componentes
{
    public partial class ModernBox : Panel
    {
        public int BorderRadius { get; set; } = 12;
        public int BorderSize { get; set; } = 1;
        public Color BorderColor { get; set; } = Color.FromArgb(230, 230, 230);
        public Color FillColor { get; set; } = Color.White;

        public int ShadowSize { get; set; } = 8;
        public Color ShadowColor { get; set; } = Color.FromArgb(50, 0, 0, 0);

        public ModernBox()
        {
            this.SetStyle(ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.ResizeRedraw, true);

            this.DoubleBuffered = true;
            this.Padding = new Padding(10);
            this.BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle shadowRect = new Rectangle(
                ShadowSize,
                ShadowSize,
                this.Width - ShadowSize - 1,
                this.Height - ShadowSize - 1
            );

            Rectangle mainRect = new Rectangle(
                0,
                0,
                this.Width - ShadowSize - 1,
                this.Height - ShadowSize - 1
            );

            using (GraphicsPath shadowPath = GetRoundedPath(shadowRect, BorderRadius))
            using (GraphicsPath mainPath = GetRoundedPath(mainRect, BorderRadius))
            using (SolidBrush shadowBrush = new SolidBrush(ShadowColor))
            using (SolidBrush fillBrush = new SolidBrush(FillColor))
            using (Pen borderPen = new Pen(BorderColor, BorderSize))
            {
                // sombra
                e.Graphics.FillPath(shadowBrush, shadowPath);

                // fundo
                e.Graphics.FillPath(fillBrush, mainPath);

                // borda
                if (BorderSize > 0)
                    e.Graphics.DrawPath(borderPen, mainPath);

                // região
                this.Region?.Dispose();
                this.Region = new Region(mainPath);
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

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
            this.Invalidate();
        }

    }
}
