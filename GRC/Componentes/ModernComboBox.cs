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
    public partial class ModernComboBox : UserControl
    {
        private Panel pnlHeader;
        private Label lblText;
        private Label lblArrow;

        private Panel pnlDropDown;
        private ListBox lstItems;

        private int borderRadius = 10;
        private Color borderColor = Color.FromArgb(220, 220, 220);

        public event EventHandler SelectedValueChanged;
        public event EventHandler SelectedIndexChanged;
        public event EventHandler DropDownClosed;
        public event EventHandler DropDownOpened;

        public ModernComboBox()
        {
            InitializeComponent();
            
            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.ResizeRedraw |
                ControlStyles.OptimizedDoubleBuffer,
                true);

            Height = 42;
            Width = 250;
            BackColor = Color.White;

            pnlHeader = new Panel();
            lblText = new Label();
            lblArrow = new Label();

            pnlDropDown = new Panel();
            lstItems = new ListBox();

            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 42;
            pnlHeader.BackColor = Color.Transparent;

            lblText.Dock = DockStyle.Fill;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(12, 0, 0, 0);
            lblText.Cursor = Cursors.Hand;

            lblArrow.Dock = DockStyle.Right;
            lblArrow.Width = 40;
            lblArrow.Text = "▼";
            lblArrow.TextAlign = ContentAlignment.MiddleCenter;
            lblArrow.Cursor = Cursors.Hand;

            pnlDropDown.Dock = DockStyle.Top;
            pnlDropDown.Height = 150;
            pnlDropDown.Visible = false;
            pnlDropDown.BorderStyle = BorderStyle.FixedSingle;

            lstItems.Dock = DockStyle.Fill;
            lstItems.BorderStyle = BorderStyle.None;

            pnlDropDown.Controls.Add(lstItems);

            pnlHeader.Controls.Add(lblText);
            pnlHeader.Controls.Add(lblArrow);

            Controls.Add(pnlDropDown);
            Controls.Add(pnlHeader);

            lblText.Click += ToggleDropDown;
            lblArrow.Click += ToggleDropDown;
            pnlHeader.Click += ToggleDropDown;

            lstItems.Click += ListItem_Click;

            Height = pnlHeader.Height;
        }



        #region Eventos

        private void ToggleDropDown(object sender, EventArgs e)
        {
            pnlDropDown.Visible = !pnlDropDown.Visible;

            if (pnlDropDown.Visible)
            {
                Height = pnlHeader.Height + pnlDropDown.Height;
                if (DropDownOpened != null)
                    DropDownOpened(this, EventArgs.Empty);
            }
            else
            {
                Height = pnlHeader.Height;
                if (DropDownClosed != null)
                    DropDownClosed(this, EventArgs.Empty);
            }
        }

        private void ListItem_Click(object sender, EventArgs e)
        {
            AtualizarTexto();

            if (SelectedIndexChanged != null)
                SelectedIndexChanged(this, EventArgs.Empty);

            if (SelectedValueChanged != null)
                SelectedValueChanged(this, EventArgs.Empty);

            pnlDropDown.Visible = false;
            Height = pnlHeader.Height;

            if (DropDownClosed != null)
                DropDownClosed(this, EventArgs.Empty);
        }

        #endregion

        #region Propriedades

        [Browsable(false)]
        public object DataSource
        {
            get { return lstItems.DataSource; }
            set { lstItems.DataSource = value; }
        }

        [Category("Data")]
        public string DisplayMember
        {
            get { return lstItems.DisplayMember; }
            set { lstItems.DisplayMember = value; }
        }

        [Category("Data")]
        public string ValueMember
        {
            get { return valueMember; }
            set { valueMember = value; }
        }

        private string valueMember;

        [Browsable(false)]
        public object SelectedItem
        {
            get { return lstItems.SelectedItem; }
            set
            {
                lstItems.SelectedItem = value;
                AtualizarTexto();
            }
        }

        [Browsable(false)]
        public int SelectedIndex
        {
            get { return lstItems.SelectedIndex; }
            set
            {
                lstItems.SelectedIndex = value;
                AtualizarTexto();
            }
        }

        [Browsable(false)]
        public object SelectedValue
        {
            get
            {
                if (SelectedItem == null)
                    return null;

                if (String.IsNullOrEmpty(ValueMember))
                    return SelectedItem;

                PropertyInfo prop =
                    SelectedItem.GetType().GetProperty(ValueMember);

                if (prop == null)
                    return null;

                return prop.GetValue(SelectedItem, null);
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ListBox.ObjectCollection Items
        {
            get { return lstItems.Items; }
        }

        #endregion

        #region Aparência

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(
                0,
                0,
                Width - 1,
                pnlHeader.Height - 1);

            GraphicsPath path = GetRoundedPath(rect, borderRadius);

            using (Pen pen = new Pen(borderColor))
            {
                e.Graphics.DrawPath(pen, path);
            }

            path.Dispose();
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

        private void AtualizarTexto()
        {
            if (SelectedItem == null)
            {
                lblText.Text = "";
                return;
            }

            lblText.Text = lstItems.Text;
        }
    }
}
