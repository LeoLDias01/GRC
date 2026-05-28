using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRC.Componentes
{
    public partial class RoundedComboBox : UserControl
    {
        private ComboBox comboBox = new ComboBox();
        private PictureBox iconBox = new PictureBox();
        private Timer animationTimer = new Timer();

        private bool isFocused = false;
        private float underlineProgress = 0f;

        private FontStyle textStyle = FontStyle.Regular;

        public enum IconPositionEnum
        {
            Left,
            Right
        }

        private IconPositionEnum iconPosition = IconPositionEnum.Left;

        #region EVENTS

        public event EventHandler IconClick;

        public new event EventHandler TextChanged;
        public event EventHandler SelectedIndexChanged;
        public event EventHandler SelectedValueChanged;
        public event EventHandler DropDown;
        public event EventHandler DropDownClosed;

        #endregion

        #region APPEARANCE

        public int BorderRadius { get; set; } = 12;

        public Color BorderColor { get; set; } = Color.FromArgb(200, 200, 200);

        public Color FillColor { get; set; } = Color.White;

        public Color UnderlineColor { get; set; } = Color.FromArgb(0, 120, 215);

        public int UnderlineSize { get; set; } = 2;

        #endregion

        #region ICON

        public Image Icon
        {
            get => iconBox.Image;
            set
            {
                iconBox.Image = value;
                UpdateLayout();
            }
        }

        public IconPositionEnum IconPosition
        {
            get => iconPosition;
            set
            {
                iconPosition = value;
                UpdateLayout();
            }
        }

        #endregion

        #region COMBOBOX PROPERTIES

        [Browsable(true)]
        public override string Text
        {
            get => comboBox.Text;
            set => comboBox.Text = value;
        }

        public override Font Font
        {
            get => comboBox.Font;
            set
            {
                comboBox.Font = new Font(value.FontFamily, value.Size, textStyle);
                UpdateLayout();
                Invalidate();
            }
        }

        public FontStyle TextStyle
        {
            get => textStyle;
            set
            {
                textStyle = value;

                comboBox.Font = new Font(
                    comboBox.Font.FontFamily,
                    comboBox.Font.Size,
                    textStyle);

                Invalidate();
            }
        }

        public Color TextColor
        {
            get => comboBox.ForeColor;
            set => comboBox.ForeColor = value;
        }

        public ComboBoxStyle DropDownStyle
        {
            get => comboBox.DropDownStyle;
            set => comboBox.DropDownStyle = value;
        }

        public AutoCompleteMode AutoCompleteMode
        {
            get => comboBox.AutoCompleteMode;
            set => comboBox.AutoCompleteMode = value;
        }

        public AutoCompleteSource AutoCompleteSource
        {
            get => comboBox.AutoCompleteSource;
            set => comboBox.AutoCompleteSource = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ComboBox.ObjectCollection Items => comboBox.Items;

        public object DataSource
        {
            get => comboBox.DataSource;
            set => comboBox.DataSource = value;
        }

        public string DisplayMember
        {
            get => comboBox.DisplayMember;
            set => comboBox.DisplayMember = value;
        }

        public string ValueMember
        {
            get => comboBox.ValueMember;
            set => comboBox.ValueMember = value;
        }

        public object SelectedItem
        {
            get => comboBox.SelectedItem;
            set => comboBox.SelectedItem = value;
        }

        public int SelectedIndex
        {
            get => comboBox.SelectedIndex;
            set => comboBox.SelectedIndex = value;
        }

        public object SelectedValue
        {
            get => comboBox.SelectedValue;
            set => comboBox.SelectedValue = value;
        }

        public int MaxDropDownItems
        {
            get => comboBox.MaxDropDownItems;
            set => comboBox.MaxDropDownItems = value;
        }

        public int DropDownWidth
        {
            get => comboBox.DropDownWidth;
            set => comboBox.DropDownWidth = value;
        }

        public int ItemHeight
        {
            get => comboBox.ItemHeight;
            set => comboBox.ItemHeight = value;
        }

        public bool DroppedDown
        {
            get => comboBox.DroppedDown;
            set => comboBox.DroppedDown = value;
        }

        public DrawMode DrawMode
        {
            get => comboBox.DrawMode;
            set => comboBox.DrawMode = value;
        }

        public FlatStyle FlatStyle
        {
            get => comboBox.FlatStyle;
            set => comboBox.FlatStyle = value;
        }

        public ComboBox InnerComboBox => comboBox;

        #endregion

        public RoundedComboBox()
        {
            Height = 40;
            Padding = new Padding(10);
            BackColor = Color.Transparent;

            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.Font = new Font("Segoe UI", 10);
            comboBox.ForeColor = Color.Black;
            comboBox.BackColor = Color.White;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            // Eventos com a remoção da seleção azul integrada
            comboBox.SelectedIndexChanged += (s, e) =>
            {
                SelectedIndexChanged?.Invoke(this, e);
                RemoveTextSelection();
            };

            comboBox.SelectedValueChanged += (s, e) =>
            {
                OnSelectedValueChanged(e);
                RemoveTextSelection();
            };

            comboBox.TextChanged += (s, e) =>
            {
                TextChanged?.Invoke(this, e);
            };

            comboBox.DropDown += (s, e) =>
            {
                DropDown?.Invoke(this, e);
            };

            comboBox.DropDownClosed += (s, e) =>
            {
                DropDownClosed?.Invoke(this, e);
                RemoveTextSelection();
            };

            comboBox.Click += (s, e) => OnClick(e);
            comboBox.DoubleClick += (s, e) => OnDoubleClick(e);

            comboBox.KeyDown += (s, e) => OnKeyDown(e);
            comboBox.KeyPress += (s, e) => OnKeyPress(e);
            comboBox.KeyUp += (s, e) => OnKeyUp(e);

            comboBox.Enter += (s, e) =>
            {
                isFocused = true;
                animationTimer.Start();
                RemoveTextSelection();
            };

            comboBox.Leave += (s, e) =>
            {
                isFocused = false;
                animationTimer.Start();
            };

            iconBox.Size = new Size(20, 20);
            iconBox.SizeMode = PictureBoxSizeMode.Zoom;
            iconBox.Cursor = Cursors.Hand;

            iconBox.Click += (s, e) =>
            {
                comboBox.DroppedDown = true;
                IconClick?.Invoke(this, EventArgs.Empty);
            };

            Controls.Add(comboBox);
            Controls.Add(iconBox);

            animationTimer.Interval = 15;
            animationTimer.Tick += AnimateUnderline;

            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw,
                     true);

            DoubleBuffered = true;

            Load += (s, e) =>
            {
                UpdateLayout();
            };
        }

        #region METHODS

        // Remove a seleção de texto de forma assíncrona para evitar falhas visuais do WinForms
        private void RemoveTextSelection()
        {
            if (comboBox.DropDownStyle == ComboBoxStyle.DropDownList)
            {
                this.BeginInvoke(new Action(() =>
                {
                    if (!comboBox.IsDisposed)
                    {
                        comboBox.Select(0, 0);
                    }
                }));
            }
        }

        protected virtual void OnSelectedValueChanged(EventArgs e)
        {
            SelectedValueChanged?.Invoke(this, e);
        }

        public void AddItem(object item)
        {
            comboBox.Items.Add(item);
        }

        public void RemoveItem(object item)
        {
            comboBox.Items.Remove(item);
        }

        public void ClearItems()
        {
            comboBox.Items.Clear();
        }

        public int FindString(string text)
        {
            return comboBox.FindString(text);
        }

        public int FindStringExact(string text)
        {
            return comboBox.FindStringExact(text);
        }

        #endregion

        #region ANIMATION

        private void AnimateUnderline(object sender, EventArgs e)
        {
            float speed = 0.1f;

            if (isFocused)
                underlineProgress = Math.Min(1f, underlineProgress + speed);
            else
                underlineProgress = Math.Max(0f, underlineProgress - speed);

            if (underlineProgress == 0f || underlineProgress == 1f)
                animationTimer.Stop();

            Invalidate();
        }

        #endregion

        #region LAYOUT

        private void UpdateLayout()
        {
            int padding = 10;

            int iconSpace = iconBox.Image != null
                ? iconBox.Width + 5
                : 0;

            if (iconPosition == IconPositionEnum.Left)
            {
                iconBox.Location = new Point(
                    padding,
                    (Height - iconBox.Height) / 2);
            }
            else
            {
                iconBox.Location = new Point(
                    Width - iconBox.Width - padding,
                    (Height - iconBox.Height) / 2);
            }

            int comboHeight = comboBox.PreferredHeight;

            int comboY = (Height - comboHeight) / 2;

            int comboX = iconPosition == IconPositionEnum.Left
                ? padding + iconSpace
                : padding;

            int comboWidth = iconPosition == IconPositionEnum.Left
                ? Width - comboX - padding
                : Width - padding - iconSpace - padding;

            comboBox.Location = new Point(comboX, comboY);
            comboBox.Width = comboWidth;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            UpdateLayout();
            Invalidate();
        }

        #endregion

        #region PAINT

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

                Region?.Dispose();
                Region = new Region(path);
            }

            int lineWidth = (int)(Width * underlineProgress);

            using (Pen pen = new Pen(UnderlineColor, UnderlineSize))
            {
                e.Graphics.DrawLine(
                    pen,
                    (Width - lineWidth) / 2,
                    Height - 2,
                    (Width + lineWidth) / 2,
                    Height - 2);
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

        #endregion
    }
}