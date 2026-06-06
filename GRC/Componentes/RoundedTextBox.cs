using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GRC.Componentes
{
    [DefaultEvent("TextChanged")] // Define TextChanged como o evento padrão no duplo clique no Designer
    public partial class RoundedTextBox : UserControl
    {
        private TextBox textBox = new TextBox();
        private PictureBox iconBox = new PictureBox();
        private Timer animationTimer = new Timer();

        private bool isFocused = false;
        private float underlineProgress = 0f;

        private string placeholder = "";
        private bool isPlaceholder = false;

        private FontStyle textStyle = FontStyle.Regular;

        public enum IconPositionEnum { Left, Right }
        private IconPositionEnum iconPosition = IconPositionEnum.Left;

        public event EventHandler IconClick;
        public event EventHandler SelectionChanged;

        // Propriedade SelectionStart (expõe o do TextBox interno)
        public int SelectionStart
        {
            get => textBox.SelectionStart;
            set => textBox.SelectionStart = value;
        }

        public int SelectionLength
        {
            get => textBox.SelectionLength;
            set => textBox.SelectionLength = value;
        }

        public string SelectedText
        {
            get => isPlaceholder ? "" : textBox.SelectedText;
            set => textBox.SelectedText = value;
        }

        public int BorderRadius { get; set; } = 12;
        public Color BorderColor { get; set; } = Color.FromArgb(200, 200, 200);
        public Color FillColor { get; set; } = Color.White;

        public Color UnderlineColor { get; set; } = Color.FromArgb(0, 120, 215);
        public int UnderlineSize { get; set; } = 2;

        public Color TextColor { get; set; } = Color.Black;

        public Image Icon
        {
            get => iconBox.Image;
            set { iconBox.Image = value; UpdateLayout(); }
        }

        public IconPositionEnum IconPosition
        {
            get => iconPosition;
            set { iconPosition = value; UpdateLayout(); }
        }

        [Browsable(true)] // Garante que a propriedade Text apareça no Designer
        public override string Text
        {
            get => isPlaceholder ? "" : textBox.Text;
            set
            {
                isPlaceholder = false;
                textBox.ForeColor = TextColor;
                textBox.Text = value;
            }
        }

        // 🔥 Fonte completa (família + tamanho + estilo)
        public override Font Font
        {
            get => textBox.Font;
            set
            {
                textBox.Font = new Font(value.FontFamily, value.Size, textStyle);
                UpdateLayout();
                this.Invalidate();
            }
        }

        // 🔥 Controle de estilo separado (negrito, itálico, etc.)
        public FontStyle TextStyle
        {
            get => textStyle;
            set
            {
                textStyle = value;
                textBox.Font = new Font(textBox.Font.FontFamily, textBox.Font.Size, textStyle);
                UpdateLayout();
                this.Invalidate();
            }
        }

        public HorizontalAlignment TextAlign
        {
            get => textBox.TextAlign;
            set => textBox.TextAlign = value;
        }

        public string Placeholder
        {
            get => placeholder;
            set { placeholder = value; SetPlaceholder(); }
        }

        public RoundedTextBox()
        {
            this.Height = 40;
            this.Padding = new Padding(10);
            this.BackColor = Color.Transparent;

            textBox.BorderStyle = BorderStyle.None;
            textBox.Font = new Font("Segoe UI", 10);
            textBox.ForeColor = TextColor;
            textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            // --- REPASSE DE EVENTOS DO TEXTBOX INTERNO PARA O USERCONTROL ---
            textBox.TextChanged += (s, e) =>
            {
                if (!isPlaceholder)
                    this.OnTextChanged(e);
            };
            textBox.KeyDown += (s, e) => this.OnKeyDown(e);
            textBox.KeyPress += (s, e) => this.OnKeyPress(e);
            textBox.KeyUp += (s, e) => this.OnKeyUp(e);
            textBox.Click += (s, e) => this.OnClick(e);
            textBox.DoubleClick += (s, e) => this.OnDoubleClick(e);
            // ----------------------------------------------------------------

            textBox.Enter += (s, e) =>
            {
                isFocused = true;
                RemovePlaceholder();
                animationTimer.Start();
            };

            textBox.Leave += (s, e) =>
            {
                isFocused = false;
                SetPlaceholder();
                animationTimer.Start();
            };

            iconBox.Size = new Size(20, 20);
            iconBox.SizeMode = PictureBoxSizeMode.Zoom;
            iconBox.Cursor = Cursors.Hand;
            iconBox.Click += (s, e) => IconClick?.Invoke(this, EventArgs.Empty);

            this.Controls.Add(textBox);
            this.Controls.Add(iconBox);

            animationTimer.Interval = 15;
            animationTimer.Tick += AnimateUnderline;

            this.SetStyle(ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.ResizeRedraw, true);

            this.DoubleBuffered = true;

            this.Load += (s, e) =>
            {
                SetPlaceholder();
                UpdateLayout();
            };
        }

        private void AnimateUnderline(object sender, EventArgs e)
        {
            float speed = 0.1f;

            if (isFocused)
                underlineProgress = Math.Min(1f, underlineProgress + speed);
            else
                underlineProgress = Math.Max(0f, underlineProgress - speed);

            if (underlineProgress == 0f || underlineProgress == 1f)
                animationTimer.Stop();

            this.Invalidate();
        }

        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(textBox.Text) && !isFocused)
            {
                isPlaceholder = true;
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
            }
        }

        private void RemovePlaceholder()
        {
            if (isPlaceholder)
            {
                textBox.Text = ""; // Limpa antes de mudar a flag para evitar evento fantasma
                isPlaceholder = false;
                textBox.ForeColor = TextColor;
            }
        }

        private void UpdateLayout()
        {
            int padding = 10;
            int iconSpace = iconBox.Image != null ? iconBox.Width + 5 : 0;

            if (iconPosition == IconPositionEnum.Left)
                iconBox.Location = new Point(padding, (Height - iconBox.Height) / 2);
            else
                iconBox.Location = new Point(Width - iconBox.Width - padding, (Height - iconBox.Height) / 2);

            int textHeight = TextRenderer.MeasureText("Text", textBox.Font).Height;
            textBox.Height = textHeight;

            int textY = (Height - textHeight) / 2;

            int textX = iconPosition == IconPositionEnum.Left
                ? padding + iconSpace
                : padding;

            int textWidth = iconPosition == IconPositionEnum.Left
                ? Width - textX - padding
                : Width - padding - iconSpace - padding;

            textBox.Location = new Point(textX, textY);
            textBox.Width = textWidth;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateLayout();
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;

            using (GraphicsPath path = GetRoundedPath(rect, BorderRadius))
            using (SolidBrush brush = new SolidBrush(FillColor))
            using (Pen borderPen = new Pen(BorderColor, 1))
            {
                e.Graphics.FillPath(brush, path);
                e.Graphics.DrawPath(borderPen, path);

                this.Region?.Dispose();
                this.Region = new Region(path);
            }

            int lineWidth = (int)(Width * underlineProgress);

            using (Pen pen = new Pen(UnderlineColor, UnderlineSize))
            {
                e.Graphics.DrawLine(
                    pen,
                    (Width - lineWidth) / 2,
                    Height - 2,
                    (Width + lineWidth) / 2,
                    Height - 2
                );
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
    }
}