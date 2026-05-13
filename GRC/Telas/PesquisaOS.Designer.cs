namespace GRC.Telas
{
    partial class PesquisaOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaOS));
            this.cbxQtdRegistros = new System.Windows.Forms.ComboBox();
            this.lbRegistros = new System.Windows.Forms.Label();
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.modernBox2 = new GRC.Componentes.ModernBox();
            this.dgvOs = new System.Windows.Forms.DataGridView();
            this.colFavorito = new System.Windows.Forms.DataGridViewImageColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modernBox1 = new GRC.Componentes.ModernBox();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.txtDataEntrada = new MaterialSkin.Controls.MaterialTextBox();
            this.txtId = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCliente = new MaterialSkin.Controls.MaterialTextBox();
            this.cbTipoServico = new MaterialSkin.Controls.MaterialComboBox();
            this.cbStatus = new MaterialSkin.Controls.MaterialComboBox();
            this.chkFavorito = new MaterialSkin.Controls.MaterialCheckbox();
            this.pn1 = new GRC.Componentes.RoundedPanel();
            this.btnSearch = new GRC.Componentes.CustomButton();
            this.btnClose = new GRC.Componentes.CustomButton();
            this.btnApagar = new GRC.Componentes.CustomButton();
            this.btnMaximize = new GRC.Componentes.CustomButton();
            this.btnNovaOS = new GRC.Componentes.CustomButton();
            this.btnMinimize = new GRC.Componentes.CustomButton();
            this.pnSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.modernBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOs)).BeginInit();
            this.modernBox1.SuspendLayout();
            this.flpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxQtdRegistros
            // 
            this.cbxQtdRegistros.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbxQtdRegistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxQtdRegistros.FormattingEnabled = true;
            this.cbxQtdRegistros.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.cbxQtdRegistros.Location = new System.Drawing.Point(819, 11);
            this.cbxQtdRegistros.Name = "cbxQtdRegistros";
            this.cbxQtdRegistros.Size = new System.Drawing.Size(59, 21);
            this.cbxQtdRegistros.TabIndex = 2;
            this.cbxQtdRegistros.Text = "10";
            this.cbxQtdRegistros.TextChanged += new System.EventHandler(this.cbxQtdRegistros_TextChanged);
            this.cbxQtdRegistros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxQtdRegistros_KeyPress);
            // 
            // lbRegistros
            // 
            this.lbRegistros.AutoSize = true;
            this.lbRegistros.BackColor = System.Drawing.Color.Transparent;
            this.lbRegistros.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbRegistros.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistros.ForeColor = System.Drawing.Color.White;
            this.lbRegistros.Location = new System.Drawing.Point(0, 0);
            this.lbRegistros.Name = "lbRegistros";
            this.lbRegistros.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lbRegistros.Size = new System.Drawing.Size(211, 36);
            this.lbRegistros.TabIndex = 1;
            this.lbRegistros.Text = "0 Registros Encontrados";
            // 
            // pnSuperior
            // 
            this.pnSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.pnSuperior.Controls.Add(this.pn1);
            this.pnSuperior.Controls.Add(this.btnSearch);
            this.pnSuperior.Controls.Add(this.pictureBox3);
            this.pnSuperior.Controls.Add(this.label1);
            this.pnSuperior.Controls.Add(this.btnClose);
            this.pnSuperior.Controls.Add(this.btnApagar);
            this.pnSuperior.Controls.Add(this.btnMaximize);
            this.pnSuperior.Controls.Add(this.btnNovaOS);
            this.pnSuperior.Controls.Add(this.btnMinimize);
            this.pnSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(903, 70);
            this.pnSuperior.TabIndex = 132;
            this.pnSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnSuperior_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(13, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 121;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 29);
            this.label1.TabIndex = 120;
            this.label1.Text = "Ordens de Serviço (OS)";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.panel2.Controls.Add(this.lbRegistros);
            this.panel2.Controls.Add(this.cbxQtdRegistros);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 594);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(903, 44);
            this.panel2.TabIndex = 163;
            // 
            // modernBox2
            // 
            this.modernBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modernBox2.BackColor = System.Drawing.Color.Transparent;
            this.modernBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.modernBox2.BorderRadius = 12;
            this.modernBox2.BorderSize = 1;
            this.modernBox2.Controls.Add(this.dgvOs);
            this.modernBox2.FillColor = System.Drawing.Color.White;
            this.modernBox2.Location = new System.Drawing.Point(13, 238);
            this.modernBox2.Name = "modernBox2";
            this.modernBox2.Padding = new System.Windows.Forms.Padding(10);
            this.modernBox2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.modernBox2.ShadowSize = 8;
            this.modernBox2.Size = new System.Drawing.Size(882, 350);
            this.modernBox2.TabIndex = 164;
            // 
            // dgvOs
            // 
            this.dgvOs.AllowUserToAddRows = false;
            this.dgvOs.AllowUserToDeleteRows = false;
            this.dgvOs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOs.BackgroundColor = System.Drawing.Color.White;
            this.dgvOs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOs.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvOs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOs.ColumnHeadersHeight = 35;
            this.dgvOs.ColumnHeadersVisible = false;
            this.dgvOs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFavorito,
            this.colId,
            this.colNome,
            this.colData,
            this.colStatus,
            this.colTipo});
            this.dgvOs.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOs.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOs.EnableHeadersVisualStyles = false;
            this.dgvOs.GridColor = System.Drawing.Color.DarkGray;
            this.dgvOs.Location = new System.Drawing.Point(10, 10);
            this.dgvOs.MultiSelect = false;
            this.dgvOs.Name = "dgvOs";
            this.dgvOs.ReadOnly = true;
            this.dgvOs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvOs.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvOs.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOs.Size = new System.Drawing.Size(862, 330);
            this.dgvOs.TabIndex = 22;
            this.dgvOs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOs_CellDoubleClick);
            this.dgvOs.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOs_CellValueChanged);
            // 
            // colFavorito
            // 
            this.colFavorito.DataPropertyName = "Favorito";
            this.colFavorito.FillWeight = 30F;
            this.colFavorito.HeaderText = "";
            this.colFavorito.Image = global::GRC.Properties.Resources.remove;
            this.colFavorito.Name = "colFavorito";
            this.colFavorito.ReadOnly = true;
            this.colFavorito.Visible = false;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.FillWeight = 20.35533F;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "NomeCliente";
            this.colNome.FillWeight = 95.16117F;
            this.colNome.HeaderText = "Cliente";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colData
            // 
            this.colData.DataPropertyName = "DataEntrada";
            this.colData.FillWeight = 95.16117F;
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "DescricaoStatus";
            this.colStatus.FillWeight = 95.16117F;
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.DataPropertyName = "DescricaoTipo";
            this.colTipo.FillWeight = 95.16117F;
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // modernBox1
            // 
            this.modernBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modernBox1.BackColor = System.Drawing.Color.Transparent;
            this.modernBox1.BorderColor = System.Drawing.Color.Transparent;
            this.modernBox1.BorderRadius = 20;
            this.modernBox1.BorderSize = 1;
            this.modernBox1.Controls.Add(this.flpMenu);
            this.modernBox1.FillColor = System.Drawing.Color.White;
            this.modernBox1.Location = new System.Drawing.Point(12, 84);
            this.modernBox1.Name = "modernBox1";
            this.modernBox1.Padding = new System.Windows.Forms.Padding(10);
            this.modernBox1.ShadowColor = System.Drawing.Color.Transparent;
            this.modernBox1.ShadowSize = 0;
            this.modernBox1.Size = new System.Drawing.Size(879, 148);
            this.modernBox1.TabIndex = 162;
            // 
            // flpMenu
            // 
            this.flpMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpMenu.BackColor = System.Drawing.Color.White;
            this.flpMenu.Controls.Add(this.txtDataEntrada);
            this.flpMenu.Controls.Add(this.txtId);
            this.flpMenu.Controls.Add(this.txtCliente);
            this.flpMenu.Controls.Add(this.cbTipoServico);
            this.flpMenu.Controls.Add(this.cbStatus);
            this.flpMenu.Controls.Add(this.chkFavorito);
            this.flpMenu.Location = new System.Drawing.Point(6, 13);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Padding = new System.Windows.Forms.Padding(10);
            this.flpMenu.Size = new System.Drawing.Size(860, 124);
            this.flpMenu.TabIndex = 103;
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.AcceptsTab = true;
            this.txtDataEntrada.AnimateReadOnly = false;
            this.txtDataEntrada.AutoWordSelection = true;
            this.txtDataEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataEntrada.Depth = 0;
            this.txtDataEntrada.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDataEntrada.Hint = "Data Entrada";
            this.txtDataEntrada.LeadingIcon = null;
            this.txtDataEntrada.LeaveOnEnterKey = true;
            this.txtDataEntrada.Location = new System.Drawing.Point(13, 13);
            this.txtDataEntrada.MaxLength = 60;
            this.txtDataEntrada.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDataEntrada.Multiline = false;
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(141, 50);
            this.txtDataEntrada.TabIndex = 90;
            this.txtDataEntrada.Text = "";
            this.txtDataEntrada.TrailingIcon = null;
            this.txtDataEntrada.UseAccent = false;
            this.txtDataEntrada.TextChanged += new System.EventHandler(this.txtDataEntrada_TextChanged);
            // 
            // txtId
            // 
            this.txtId.AcceptsTab = true;
            this.txtId.AnimateReadOnly = false;
            this.txtId.AutoWordSelection = true;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Depth = 0;
            this.txtId.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtId.Hint = "Nº ";
            this.txtId.LeadingIcon = null;
            this.txtId.LeaveOnEnterKey = true;
            this.txtId.Location = new System.Drawing.Point(160, 13);
            this.txtId.MaxLength = 60;
            this.txtId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(155, 50);
            this.txtId.TabIndex = 83;
            this.txtId.Text = "";
            this.txtId.TrailingIcon = null;
            this.txtId.UseAccent = false;
            // 
            // txtCliente
            // 
            this.txtCliente.AcceptsTab = true;
            this.txtCliente.AnimateReadOnly = true;
            this.txtCliente.AutoWordSelection = true;
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCliente.Depth = 0;
            this.txtCliente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCliente.Hint = "Cliente";
            this.txtCliente.LeadingIcon = null;
            this.txtCliente.LeaveOnEnterKey = true;
            this.txtCliente.Location = new System.Drawing.Point(321, 13);
            this.txtCliente.MaxLength = 60;
            this.txtCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCliente.Multiline = false;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(505, 50);
            this.txtCliente.TabIndex = 82;
            this.txtCliente.Text = "";
            this.txtCliente.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtCliente.TrailingIcon")));
            this.txtCliente.UseAccent = false;
            this.txtCliente.TrailingIconClick += new System.EventHandler(this.txtCliente_TrailingIconClick);
            // 
            // cbTipoServico
            // 
            this.cbTipoServico.AutoResize = false;
            this.cbTipoServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbTipoServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTipoServico.Depth = 0;
            this.cbTipoServico.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbTipoServico.DropDownHeight = 174;
            this.cbTipoServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoServico.DropDownWidth = 121;
            this.cbTipoServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbTipoServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTipoServico.FormattingEnabled = true;
            this.cbTipoServico.Hint = "Tipo de Serviço";
            this.cbTipoServico.IntegralHeight = false;
            this.cbTipoServico.ItemHeight = 43;
            this.cbTipoServico.Location = new System.Drawing.Point(13, 69);
            this.cbTipoServico.MaxDropDownItems = 4;
            this.cbTipoServico.MouseState = MaterialSkin.MouseState.OUT;
            this.cbTipoServico.Name = "cbTipoServico";
            this.cbTipoServico.Size = new System.Drawing.Size(243, 49);
            this.cbTipoServico.StartIndex = 0;
            this.cbTipoServico.TabIndex = 87;
            this.cbTipoServico.UseAccent = false;
            // 
            // cbStatus
            // 
            this.cbStatus.AutoResize = false;
            this.cbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbStatus.Depth = 0;
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbStatus.DropDownHeight = 174;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.DropDownWidth = 121;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Hint = "Status";
            this.cbStatus.IntegralHeight = false;
            this.cbStatus.ItemHeight = 43;
            this.cbStatus.Location = new System.Drawing.Point(262, 69);
            this.cbStatus.MaxDropDownItems = 4;
            this.cbStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(344, 49);
            this.cbStatus.StartIndex = 0;
            this.cbStatus.TabIndex = 88;
            this.cbStatus.UseAccent = false;
            // 
            // chkFavorito
            // 
            this.chkFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFavorito.AutoSize = true;
            this.chkFavorito.Depth = 0;
            this.chkFavorito.Location = new System.Drawing.Point(609, 84);
            this.chkFavorito.Margin = new System.Windows.Forms.Padding(0);
            this.chkFavorito.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkFavorito.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkFavorito.Name = "chkFavorito";
            this.chkFavorito.ReadOnly = false;
            this.chkFavorito.Ripple = true;
            this.chkFavorito.Size = new System.Drawing.Size(93, 37);
            this.chkFavorito.TabIndex = 89;
            this.chkFavorito.Text = "Favorito";
            this.chkFavorito.UseVisualStyleBackColor = true;
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.Color.Transparent;
            this.pn1.Color1 = System.Drawing.Color.Aqua;
            this.pn1.Color2 = System.Drawing.Color.DodgerBlue;
            this.pn1.CornerRadius = 8;
            this.pn1.GradientAngle = 280F;
            this.pn1.Location = new System.Drawing.Point(4, 64);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(353, 30);
            this.pn1.TabIndex = 127;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnSearch.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnSearch.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnSearch.CorTextoBotao = System.Drawing.Color.White;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(482, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(43, 43);
            this.btnSearch.TabIndex = 101;
            this.btnSearch.TamanhoBorda = 0;
            this.btnSearch.TamanhoRaio = 10;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnClose.CorBotao = System.Drawing.Color.Transparent;
            this.btnClose.CorTextoBotao = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(859, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 35);
            this.btnClose.TabIndex = 16;
            this.btnClose.TamanhoBorda = 0;
            this.btnClose.TamanhoRaio = 17;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnApagar.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnApagar.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnApagar.CorTextoBotao = System.Drawing.Color.White;
            this.btnApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.ForeColor = System.Drawing.Color.White;
            this.btnApagar.Image = ((System.Drawing.Image)(resources.GetObject("btnApagar.Image")));
            this.btnApagar.Location = new System.Drawing.Point(433, 18);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(43, 43);
            this.btnApagar.TabIndex = 14;
            this.btnApagar.TamanhoBorda = 0;
            this.btnApagar.TamanhoRaio = 10;
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnMaximize.CorBotao = System.Drawing.Color.Transparent;
            this.btnMaximize.CorTextoBotao = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(813, 17);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(40, 35);
            this.btnMaximize.TabIndex = 15;
            this.btnMaximize.TamanhoBorda = 0;
            this.btnMaximize.TamanhoRaio = 17;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnNovaOS
            // 
            this.btnNovaOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnNovaOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovaOS.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnNovaOS.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnNovaOS.CorTextoBotao = System.Drawing.Color.White;
            this.btnNovaOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovaOS.FlatAppearance.BorderSize = 0;
            this.btnNovaOS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnNovaOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaOS.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnNovaOS.ForeColor = System.Drawing.Color.White;
            this.btnNovaOS.Image = ((System.Drawing.Image)(resources.GetObject("btnNovaOS.Image")));
            this.btnNovaOS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovaOS.Location = new System.Drawing.Point(384, 17);
            this.btnNovaOS.Name = "btnNovaOS";
            this.btnNovaOS.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnNovaOS.Size = new System.Drawing.Size(43, 43);
            this.btnNovaOS.TabIndex = 0;
            this.btnNovaOS.TamanhoBorda = 0;
            this.btnNovaOS.TamanhoRaio = 10;
            this.btnNovaOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovaOS.UseVisualStyleBackColor = false;
            this.btnNovaOS.Click += new System.EventHandler(this.btnNovaOS_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnMinimize.CorBotao = System.Drawing.Color.Transparent;
            this.btnMinimize.CorTextoBotao = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(767, 17);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 35);
            this.btnMinimize.TabIndex = 14;
            this.btnMinimize.TamanhoBorda = 0;
            this.btnMinimize.TamanhoRaio = 17;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // PesquisaOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(903, 638);
            this.Controls.Add(this.modernBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.modernBox1);
            this.Controls.Add(this.pnSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PesquisaOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PesquisaOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PesquisaOS_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PesquisaOS_MouseDown);
            this.pnSuperior.ResumeLayout(false);
            this.pnSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.modernBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOs)).EndInit();
            this.modernBox1.ResumeLayout(false);
            this.flpMenu.ResumeLayout(false);
            this.flpMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxQtdRegistros;
        private System.Windows.Forms.Label lbRegistros;
        private Componentes.CustomButton btnSearch;
        private Componentes.CustomButton btnApagar;
        private System.Windows.Forms.DataGridView dgvOs;
        private MaterialSkin.Controls.MaterialTextBox txtId;
        private MaterialSkin.Controls.MaterialTextBox txtCliente;
        private MaterialSkin.Controls.MaterialComboBox cbTipoServico;
        private MaterialSkin.Controls.MaterialComboBox cbStatus;
        private MaterialSkin.Controls.MaterialCheckbox chkFavorito;
        private MaterialSkin.Controls.MaterialTextBox txtDataEntrada;
        private System.Windows.Forms.DataGridViewImageColumn colFavorito;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.Panel pnSuperior;
        private Componentes.RoundedPanel pn1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private Componentes.CustomButton btnClose;
        private Componentes.CustomButton btnMaximize;
        private Componentes.CustomButton btnNovaOS;
        private Componentes.CustomButton btnMinimize;
        private Componentes.ModernBox modernBox1;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Panel panel2;
        private Componentes.ModernBox modernBox2;
    }
}