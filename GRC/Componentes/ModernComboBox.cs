using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRC.Componentes
{
    public enum ArrowPosition
    {
        Left,
        Right
    }

    public partial class ModernComboBox : UserControl, IMessageFilter
    {
        private ListBox lstItems;
        private Panel pnlDropDown;
        private DropDownForm frmDropDown;
        private Timer animTimer;

        private Color borderColor = Color.Silver;
        private int borderRadius = 12;
        private int borderSize = 1;
        private ArrowPosition arrowSide = ArrowPosition.Right;
        private Image arrowImage = null;
        private string placeholderText = "";
        private Color placeholderColor = Color.Silver;

        private bool isOpen = false;
        private int hoveredIndex = -1;
        private const int AnimTargetHeight = 200;
        private const int AnimStep = 20;

        public event EventHandler SelectedIndexChanged;
        public event EventHandler SelectionChangeCommitted;
        public event EventHandler DropDown;
        public event EventHandler DropDownClosed;

        public ModernComboBox()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor,
                true
            );
            DoubleBuffered = true;
            Height = 40;
            BackColor = Color.White;
            Cursor = Cursors.Hand;

            Click += ToggleDropDown;

            lstItems = new ListBox();
            lstItems.BorderStyle = BorderStyle.None;
            lstItems.IntegralHeight = false;
            lstItems.Dock = DockStyle.Fill;
            lstItems.Cursor = Cursors.Hand;
            lstItems.DrawMode = DrawMode.OwnerDrawFixed;
            lstItems.ItemHeight = 28;
            lstItems.DrawItem += LstItems_DrawItem;
            lstItems.Click += LstItems_Click;
            lstItems.SelectedIndexChanged += LstItems_SelectedIndexChanged;
            lstItems.MouseMove += LstItems_MouseMove;
            lstItems.MouseLeave += LstItems_MouseLeave;

            pnlDropDown = new Panel();
            pnlDropDown.Padding = new Padding(1);
            pnlDropDown.BackColor = Color.White;
            pnlDropDown.Controls.Add(lstItems);

            // DropDownForm é um Form customizado que não rouba foco
            frmDropDown = new DropDownForm();
            frmDropDown.Controls.Add(pnlDropDown);

            animTimer = new Timer();
            animTimer.Interval = 10;
            animTimer.Tick += AnimTimer_Tick;
        }

        // ── Form interno sem ativação ────────────────────────────────────────────
        // Evita o roubo de foco que causava o "duplo clique para fechar"
        private class DropDownForm : Form
        {
            public DropDownForm()
            {
                FormBorderStyle = FormBorderStyle.None;
                ShowInTaskbar = false;
                StartPosition = FormStartPosition.Manual;
                Height = 0;
            }

            // Impede o form de roubar o foco ao aparecer
            protected override bool ShowWithoutActivation => true;

            // Impede o Windows de ativar o form ao clicar nele
            protected override CreateParams CreateParams
            {
                get
                {
                    var cp = base.CreateParams;
                    cp.ExStyle |= 0x08000000; // WS_EX_NOACTIVATE
                    return cp;
                }
            }
        }

        // ── Propriedades ────────────────────────────────────────────────────────

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ListBox.ObjectCollection Items
        {
            get { return lstItems.Items; }
        }

        public object DataSource
        {
            get { return lstItems.DataSource; }
            set
            {
                lstItems.DataSource = null;
                lstItems.DataSource = value;
                Invalidate();
            }
        }

        public string DisplayMember
        {
            get { return lstItems.DisplayMember; }
            set { lstItems.DisplayMember = value; }
        }

        public string ValueMember
        {
            get { return lstItems.ValueMember; }
            set { lstItems.ValueMember = value; }
        }

        [Browsable(false)]
        public object SelectedItem
        {
            get { return lstItems.SelectedItem; }
            set { lstItems.SelectedItem = value; Invalidate(); }
        }

        [Browsable(false)]
        public object SelectedValue
        {
            get { return lstItems.SelectedValue; }
        }

        public int SelectedIndex
        {
            get { return lstItems.SelectedIndex; }
            set
            {
                if (lstItems.Items.Count > 0 && value >= 0 && value < lstItems.Items.Count)
                    lstItems.SelectedIndex = value;
                else
                    lstItems.SelectedIndex = -1;

                Invalidate();
            }
        }

        [Category("Modern")]
        [Description("Imagem customizada para a seta. Se nulo, desenha seta padrão.")]
        public Image ArrowImage
        {
            get { return arrowImage; }
            set { arrowImage = value; Invalidate(); }
        }

        [Category("Modern")]
        [Description("Lado onde a seta será exibida.")]
        public ArrowPosition ArrowSide
        {
            get { return arrowSide; }
            set { arrowSide = value; Invalidate(); }
        }

        [Category("Modern")]
        [Description("Cor da borda do controle.")]
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }

        [Category("Modern")]
        [Description("Raio do arredondamento das bordas.")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; Invalidate(); }
        }

        [Category("Modern")]
        [Description("Espessura da borda do controle.")]
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; Invalidate(); }
        }

        [Category("Modern")]
        [Description("Texto exibido quando nenhum item está selecionado.")]
        public string PlaceholderText
        {
            get { return placeholderText; }
            set { placeholderText = value; Invalidate(); }
        }

        [Category("Modern")]
        [Description("Cor do texto placeholder.")]
        public Color PlaceholderColor
        {
            get { return placeholderColor; }
            set { placeholderColor = value; Invalidate(); }
        }

        // ── Dropdown ────────────────────────────────────────────────────────────

        private void ToggleDropDown(object sender, EventArgs e)
        {
            if (isOpen)
                CloseDropDown();
            else
                OpenDropDown();
        }

        private void OpenDropDown()
        {
            if (isOpen) return;

            Point screenPos = PointToScreen(new Point(0, Height));
            frmDropDown.Location = screenPos;
            frmDropDown.Width = Width;
            frmDropDown.Height = 0;
            pnlDropDown.Size = new Size(Width, AnimTargetHeight);

            frmDropDown.Show();
            frmDropDown.BringToFront(); // garante que aparece na frente do form pai

            Application.AddMessageFilter(this);

            isOpen = true;
            animTimer.Start();

            DropDown?.Invoke(this, EventArgs.Empty);
            Invalidate();
        }

        private void CloseDropDown()
        {
            if (!isOpen) return;

            Application.RemoveMessageFilter(this);

            animTimer.Stop();
            frmDropDown.Hide();
            frmDropDown.Height = 0;
            isOpen = false;
            hoveredIndex = -1;

            DropDownClosed?.Invoke(this, EventArgs.Empty);
            Invalidate();
        }

        // Fecha ao clicar fora do combo e do dropdown
        public bool PreFilterMessage(ref Message m)
        {
            const int WM_LBUTTONDOWN = 0x0201;

            if (m.Msg == WM_LBUTTONDOWN)
            {
                Point click = Control.MousePosition;
                Rectangle comboRect = new Rectangle(PointToScreen(Point.Empty), Size);
                Rectangle dropRect = new Rectangle(frmDropDown.Location, frmDropDown.Size);

                if (comboRect.Contains(click))
                {
                    // Clique no próprio combo: deixa o Click do controle tratar (ToggleDropDown)
                    // Apenas remove o filtro e fecha — o ToggleDropDown reabrirá na sequência
                    CloseDropDown();
                    return false;
                }

                if (!dropRect.Contains(click))
                    CloseDropDown();
            }

            return false;
        }

        private void AnimTimer_Tick(object sender, EventArgs e)
        {
            if (frmDropDown.Height < AnimTargetHeight)
            {
                frmDropDown.Height = Math.Min(frmDropDown.Height + AnimStep, AnimTargetHeight);
                pnlDropDown.Height = frmDropDown.Height;
            }
            else
            {
                animTimer.Stop();
            }
        }

        // ── Eventos do ListBox ───────────────────────────────────────────────────

        private void LstItems_MouseMove(object sender, MouseEventArgs e)
        {
            // Calcula qual índice está sob o mouse
            int index = lstItems.IndexFromPoint(e.Location);
            if (index == hoveredIndex) return;

            hoveredIndex = index;
            lstItems.Invalidate(); // redesenha todos os itens para atualizar hover
        }

        private void LstItems_MouseLeave(object sender, EventArgs e)
        {
            hoveredIndex = -1;
            lstItems.Invalidate();
        }

        private void LstItems_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            bool isHovered = e.Index == hoveredIndex;

            Color bgColor;
            if (isSelected)
                bgColor = borderColor;
            else if (isHovered)
                bgColor = MixColors(lstItems.BackColor, borderColor, 0.15f); // toque sutil da cor da borda
            else
                bgColor = lstItems.BackColor;

            Color textColor = isSelected ? Color.White : lstItems.ForeColor;

            using (var brush = new SolidBrush(bgColor))
                e.Graphics.FillRectangle(brush, e.Bounds);

            string text = lstItems.GetItemText(lstItems.Items[e.Index]);
            TextRenderer.DrawText(
                e.Graphics, text, lstItems.Font,
                new Rectangle(e.Bounds.X + 10, e.Bounds.Y, e.Bounds.Width - 10, e.Bounds.Height),
                textColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.EndEllipsis
            );
        }

        private void LstItems_Click(object sender, EventArgs e)
        {
            SelectionChangeCommitted?.Invoke(this, EventArgs.Empty);
            CloseDropDown();
        }

        private void LstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            Invalidate();
            SelectedIndexChanged?.Invoke(this, EventArgs.Empty);
        }

        // ── Pintura ─────────────────────────────────────────────────────────────

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            Color parentColor = Parent?.BackColor ?? SystemColors.Control;
            using (var brush = new SolidBrush(parentColor))
                g.FillRectangle(brush, ClientRectangle);

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);
            using (var path = GetPath(rect, borderRadius))
            using (var brush = new SolidBrush(BackColor))
                g.FillPath(brush, path);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;

            int margin = borderSize;
            var rect = new Rectangle(margin, margin, Width - 1 - margin * 2, Height - 1 - margin * 2);

            using (var path = GetPath(rect, borderRadius))
            using (var pen = new Pen(borderColor, borderSize) { LineJoin = LineJoin.Round })
                g.DrawPath(pen, path);

            DrawText(g);
            DrawArrow(g);

            Color parentColor = Parent?.BackColor ?? SystemColors.Control;
            using (var outerPath = GetPath(new Rectangle(0, 0, Width - 1, Height - 1), borderRadius))
            using (var smoothPen = new Pen(parentColor, 2.5f) { LineJoin = LineJoin.Round })
                g.DrawPath(smoothPen, outerPath);

            using (var regionPath = GetPath(new Rectangle(0, 0, Width, Height), borderRadius))
                Region = new Region(regionPath);
        }

        private void DrawText(Graphics g)
        {
            const int arrowAreaWidth = 30;
            const int paddingLeft = 10;

            Rectangle textRect = arrowSide == ArrowPosition.Right
                ? new Rectangle(paddingLeft, 0, Width - arrowAreaWidth - paddingLeft, Height)
                : new Rectangle(arrowAreaWidth, 0, Width - arrowAreaWidth - paddingLeft, Height);

            bool hasSelection = lstItems.SelectedIndex >= 0 && lstItems.Items.Count > 0;

            string text = hasSelection ? lstItems.Text : placeholderText;
            Color color = hasSelection ? ForeColor : placeholderColor;

            if (string.IsNullOrEmpty(text)) return;

            TextRenderer.DrawText(g, text, Font, textRect, color,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.EndEllipsis);
        }

        private void DrawArrow(Graphics g)
        {
            const int arrowAreaWidth = 30;

            int cx = arrowSide == ArrowPosition.Right
                ? Width - arrowAreaWidth / 2 - borderSize
                : arrowAreaWidth / 2 + borderSize;
            int cy = Height / 2;

            if (arrowImage != null)
            {
                g.DrawImage(arrowImage, new Rectangle(
                    cx - arrowImage.Width / 2,
                    cy - arrowImage.Height / 2,
                    arrowImage.Width, arrowImage.Height));
                return;
            }

            const int aw = 10;
            const int ah = 6;

            Point[] pts = isOpen
                ? new[] {
                    new Point(cx - aw / 2, cy + ah / 2),
                    new Point(cx + aw / 2, cy + ah / 2),
                    new Point(cx,          cy - ah / 2)
                }
                : new[] {
                    new Point(cx - aw / 2, cy - ah / 2),
                    new Point(cx + aw / 2, cy - ah / 2),
                    new Point(cx,          cy + ah / 2)
                };

            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (var brush = new SolidBrush(ForeColor))
                g.FillPolygon(brush, pts);
        }

        // ── Utilitário ──────────────────────────────────────────────────────────

        private GraphicsPath GetPath(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            int d = radius * 2;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }

        // Mistura duas cores — amount 0.0 = somente base, 1.0 = somente overlay
        private static Color MixColors(Color base_, Color overlay, float amount)
        {
            return Color.FromArgb(
                (int)(base_.R + (overlay.R - base_.R) * amount),
                (int)(base_.G + (overlay.G - base_.G) * amount),
                (int)(base_.B + (overlay.B - base_.B) * amount)
            );
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (isOpen) Application.RemoveMessageFilter(this);
                animTimer?.Stop();
                animTimer?.Dispose();
                frmDropDown?.Dispose();
            }
            base.Dispose(disposing);
        }
    }

}
