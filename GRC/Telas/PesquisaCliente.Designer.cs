namespace GRC.Telas
{
    partial class PesquisaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbxQtdRegistros = new System.Windows.Forms.ComboBox();
            this.lbRegistros = new System.Windows.Forms.Label();
            this.txtCliente = new MaterialSkin.Controls.MaterialTextBox();
            this.txtIdentidade = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCidade = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUf = new MaterialSkin.Controls.MaterialTextBox();
            this.chkAtivo = new MaterialSkin.Controls.MaterialCheckbox();
            this.rbtPJ = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtPF = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnSearch = new GRC.Componentes.CustomButton();
            this.btnApagar = new GRC.Componentes.CustomButton();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.colIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdentidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.pn1 = new GRC.Componentes.RoundedPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new GRC.Componentes.CustomButton();
            this.btnMaximize = new GRC.Componentes.CustomButton();
            this.btnNovoCliente = new GRC.Componentes.CustomButton();
            this.btnMinimize = new GRC.Componentes.CustomButton();
            this.modernBox1 = new GRC.Componentes.ModernBox();
            this.painelRadius3 = new GRC.Componentes.PainelRadius();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.modernBox2 = new GRC.Componentes.ModernBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.pnSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.modernBox1.SuspendLayout();
            this.painelRadius3.SuspendLayout();
            this.flpMenu.SuspendLayout();
            this.modernBox2.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.cbxQtdRegistros.Location = new System.Drawing.Point(960, 11);
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
            // txtCliente
            // 
            this.txtCliente.AcceptsTab = true;
            this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliente.AnimateReadOnly = false;
            this.txtCliente.AutoWordSelection = true;
            this.txtCliente.BackColor = System.Drawing.Color.White;
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCliente.Depth = 0;
            this.txtCliente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCliente.Hint = "Cliente";
            this.txtCliente.LeadingIcon = null;
            this.txtCliente.LeaveOnEnterKey = true;
            this.txtCliente.Location = new System.Drawing.Point(266, 13);
            this.txtCliente.MaxLength = 80;
            this.txtCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCliente.Multiline = false;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(377, 50);
            this.txtCliente.TabIndex = 0;
            this.txtCliente.Text = "";
            this.txtCliente.TrailingIcon = null;
            this.txtCliente.UseAccent = false;
            // 
            // txtIdentidade
            // 
            this.txtIdentidade.AcceptsTab = true;
            this.txtIdentidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdentidade.AnimateReadOnly = false;
            this.txtIdentidade.AutoWordSelection = true;
            this.txtIdentidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentidade.Depth = 0;
            this.txtIdentidade.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdentidade.Hint = "CNPJ/CPF";
            this.txtIdentidade.LeadingIcon = null;
            this.txtIdentidade.LeaveOnEnterKey = true;
            this.txtIdentidade.Location = new System.Drawing.Point(13, 13);
            this.txtIdentidade.MaxLength = 18;
            this.txtIdentidade.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdentidade.Multiline = false;
            this.txtIdentidade.Name = "txtIdentidade";
            this.txtIdentidade.Size = new System.Drawing.Size(247, 50);
            this.txtIdentidade.TabIndex = 8;
            this.txtIdentidade.Text = "";
            this.txtIdentidade.TrailingIcon = null;
            this.txtIdentidade.UseAccent = false;
            this.txtIdentidade.TextChanged += new System.EventHandler(this.txtIdentidade_TextChanged);
            // 
            // txtCidade
            // 
            this.txtCidade.AcceptsTab = true;
            this.txtCidade.AnimateReadOnly = false;
            this.txtCidade.AutoWordSelection = true;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCidade.Depth = 0;
            this.txtCidade.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCidade.Hint = "Cidade";
            this.txtCidade.LeadingIcon = null;
            this.txtCidade.LeaveOnEnterKey = true;
            this.txtCidade.Location = new System.Drawing.Point(649, 13);
            this.txtCidade.MaxLength = 250;
            this.txtCidade.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCidade.Multiline = false;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(236, 50);
            this.txtCidade.TabIndex = 25;
            this.txtCidade.Text = "";
            this.txtCidade.TrailingIcon = null;
            this.txtCidade.UseAccent = false;
            // 
            // txtUf
            // 
            this.txtUf.AcceptsTab = true;
            this.txtUf.AnimateReadOnly = false;
            this.txtUf.AutoWordSelection = true;
            this.txtUf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUf.Depth = 0;
            this.txtUf.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUf.Hint = "UF";
            this.txtUf.LeadingIcon = null;
            this.txtUf.LeaveOnEnterKey = true;
            this.txtUf.Location = new System.Drawing.Point(891, 13);
            this.txtUf.MaxLength = 2;
            this.txtUf.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUf.Multiline = false;
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(70, 50);
            this.txtUf.TabIndex = 26;
            this.txtUf.Text = "";
            this.txtUf.TrailingIcon = null;
            this.txtUf.UseAccent = false;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Depth = 0;
            this.chkAtivo.Location = new System.Drawing.Point(361, 5);
            this.chkAtivo.Margin = new System.Windows.Forms.Padding(0);
            this.chkAtivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkAtivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.ReadOnly = false;
            this.chkAtivo.Ripple = true;
            this.chkAtivo.Size = new System.Drawing.Size(71, 37);
            this.chkAtivo.TabIndex = 102;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // rbtPJ
            // 
            this.rbtPJ.AutoSize = true;
            this.rbtPJ.Depth = 0;
            this.rbtPJ.Location = new System.Drawing.Point(159, 4);
            this.rbtPJ.Margin = new System.Windows.Forms.Padding(0);
            this.rbtPJ.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtPJ.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtPJ.Name = "rbtPJ";
            this.rbtPJ.Ripple = true;
            this.rbtPJ.Size = new System.Drawing.Size(148, 37);
            this.rbtPJ.TabIndex = 104;
            this.rbtPJ.TabStop = true;
            this.rbtPJ.Text = "Pessoa Jurídica";
            this.rbtPJ.UseVisualStyleBackColor = true;
            // 
            // rbtPF
            // 
            this.rbtPF.AutoSize = true;
            this.rbtPF.Depth = 0;
            this.rbtPF.Location = new System.Drawing.Point(9, 4);
            this.rbtPF.Margin = new System.Windows.Forms.Padding(0);
            this.rbtPF.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtPF.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtPF.Name = "rbtPF";
            this.rbtPF.Ripple = true;
            this.rbtPF.Size = new System.Drawing.Size(133, 37);
            this.rbtPF.TabIndex = 103;
            this.rbtPF.TabStop = true;
            this.rbtPF.Text = "Pessoa Física";
            this.rbtPF.UseVisualStyleBackColor = true;
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
            this.btnSearch.Location = new System.Drawing.Point(290, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(43, 43);
            this.btnSearch.TabIndex = 101;
            this.btnSearch.TamanhoBorda = 0;
            this.btnSearch.TamanhoRaio = 10;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnApagar.Location = new System.Drawing.Point(241, 17);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(43, 43);
            this.btnApagar.TabIndex = 14;
            this.btnApagar.TamanhoBorda = 0;
            this.btnApagar.TamanhoRaio = 10;
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.ColumnHeadersHeight = 35;
            this.dgvClientes.ColumnHeadersVisible = false;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdCliente,
            this.colNome,
            this.colTipoPessoa,
            this.colIdentidade,
            this.colCidade,
            this.colUf,
            this.colExcluir});
            this.dgvClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.GridColor = System.Drawing.Color.DarkGray;
            this.dgvClientes.Location = new System.Drawing.Point(13, 13);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvClientes.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(992, 350);
            this.dgvClientes.TabIndex = 18;
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            this.dgvClientes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellValueChanged);
            // 
            // colIdCliente
            // 
            this.colIdCliente.DataPropertyName = "Id";
            this.colIdCliente.FillWeight = 1F;
            this.colIdCliente.HeaderText = "Id";
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.ReadOnly = true;
            this.colIdCliente.Visible = false;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "Nome";
            this.colNome.HeaderText = "Cliente";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colTipoPessoa
            // 
            this.colTipoPessoa.DataPropertyName = "TipoPessoa";
            this.colTipoPessoa.HeaderText = "Tipo de Identidade";
            this.colTipoPessoa.Name = "colTipoPessoa";
            this.colTipoPessoa.ReadOnly = true;
            // 
            // colIdentidade
            // 
            this.colIdentidade.DataPropertyName = "Indentidade";
            this.colIdentidade.HeaderText = "CNPJ/CPF";
            this.colIdentidade.Name = "colIdentidade";
            this.colIdentidade.ReadOnly = true;
            // 
            // colCidade
            // 
            this.colCidade.DataPropertyName = "Cidade";
            this.colCidade.HeaderText = "Cidade";
            this.colCidade.Name = "colCidade";
            this.colCidade.ReadOnly = true;
            // 
            // colUf
            // 
            this.colUf.DataPropertyName = "Uf";
            this.colUf.FillWeight = 40F;
            this.colUf.HeaderText = "UF";
            this.colUf.Name = "colUf";
            this.colUf.ReadOnly = true;
            // 
            // colExcluir
            // 
            this.colExcluir.FillWeight = 30F;
            this.colExcluir.HeaderText = "";
            this.colExcluir.Image = global::GRC.Properties.Resources.remove;
            this.colExcluir.Name = "colExcluir";
            this.colExcluir.ReadOnly = true;
            this.colExcluir.Visible = false;
            // 
            // pnSuperior
            // 
            this.pnSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnSuperior.Controls.Add(this.pn1);
            this.pnSuperior.Controls.Add(this.btnSearch);
            this.pnSuperior.Controls.Add(this.pictureBox3);
            this.pnSuperior.Controls.Add(this.label1);
            this.pnSuperior.Controls.Add(this.btnClose);
            this.pnSuperior.Controls.Add(this.btnApagar);
            this.pnSuperior.Controls.Add(this.btnMaximize);
            this.pnSuperior.Controls.Add(this.btnNovoCliente);
            this.pnSuperior.Controls.Add(this.btnMinimize);
            this.pnSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(1042, 70);
            this.pnSuperior.TabIndex = 132;
            this.pnSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnSuperior_MouseDown);
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.Color.Transparent;
            this.pn1.Color1 = System.Drawing.Color.Blue;
            this.pn1.Color2 = System.Drawing.Color.Purple;
            this.pn1.CornerRadius = 8;
            this.pn1.GradientAngle = 280F;
            this.pn1.Location = new System.Drawing.Point(4, 64);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(160, 30);
            this.pn1.TabIndex = 127;
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
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 120;
            this.label1.Text = "Clientes";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
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
            this.btnClose.Location = new System.Drawing.Point(998, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 35);
            this.btnClose.TabIndex = 16;
            this.btnClose.TamanhoBorda = 0;
            this.btnClose.TamanhoRaio = 17;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnMaximize.Location = new System.Drawing.Point(952, 17);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(40, 35);
            this.btnMaximize.TabIndex = 15;
            this.btnMaximize.TamanhoBorda = 0;
            this.btnMaximize.TamanhoRaio = 17;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnNovoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovoCliente.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnNovoCliente.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnNovoCliente.CorTextoBotao = System.Drawing.Color.White;
            this.btnNovoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoCliente.FlatAppearance.BorderSize = 0;
            this.btnNovoCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnNovoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoCliente.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnNovoCliente.ForeColor = System.Drawing.Color.White;
            this.btnNovoCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoCliente.Image")));
            this.btnNovoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoCliente.Location = new System.Drawing.Point(192, 17);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnNovoCliente.Size = new System.Drawing.Size(43, 43);
            this.btnNovoCliente.TabIndex = 0;
            this.btnNovoCliente.TamanhoBorda = 0;
            this.btnNovoCliente.TamanhoRaio = 10;
            this.btnNovoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoCliente.UseVisualStyleBackColor = false;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
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
            this.btnMinimize.Location = new System.Drawing.Point(906, 17);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 35);
            this.btnMinimize.TabIndex = 14;
            this.btnMinimize.TamanhoBorda = 0;
            this.btnMinimize.TamanhoRaio = 17;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // modernBox1
            // 
            this.modernBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modernBox1.BackColor = System.Drawing.Color.Transparent;
            this.modernBox1.BorderColor = System.Drawing.Color.Transparent;
            this.modernBox1.BorderRadius = 20;
            this.modernBox1.BorderSize = 1;
            this.modernBox1.Controls.Add(this.painelRadius3);
            this.modernBox1.Controls.Add(this.flpMenu);
            this.modernBox1.FillColor = System.Drawing.Color.White;
            this.modernBox1.Location = new System.Drawing.Point(15, 80);
            this.modernBox1.Name = "modernBox1";
            this.modernBox1.Padding = new System.Windows.Forms.Padding(5);
            this.modernBox1.ShadowAngle = 135;
            this.modernBox1.ShadowColor = System.Drawing.Color.Transparent;
            this.modernBox1.ShadowSize = 0;
            this.modernBox1.Size = new System.Drawing.Size(1009, 151);
            this.modernBox1.TabIndex = 162;
            // 
            // painelRadius3
            // 
            this.painelRadius3.BackColor = System.Drawing.Color.White;
            this.painelRadius3.BorderColor = System.Drawing.Color.White;
            this.painelRadius3.Controls.Add(this.rbtPF);
            this.painelRadius3.Controls.Add(this.rbtPJ);
            this.painelRadius3.Controls.Add(this.chkAtivo);
            this.painelRadius3.Location = new System.Drawing.Point(18, 13);
            this.painelRadius3.Name = "painelRadius3";
            this.painelRadius3.Radius = 50;
            this.painelRadius3.Size = new System.Drawing.Size(507, 43);
            this.painelRadius3.TabIndex = 128;
            this.painelRadius3.Thickness = 10F;
            // 
            // flpMenu
            // 
            this.flpMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpMenu.BackColor = System.Drawing.Color.White;
            this.flpMenu.Controls.Add(this.txtIdentidade);
            this.flpMenu.Controls.Add(this.txtCliente);
            this.flpMenu.Controls.Add(this.txtCidade);
            this.flpMenu.Controls.Add(this.txtUf);
            this.flpMenu.Location = new System.Drawing.Point(18, 62);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Padding = new System.Windows.Forms.Padding(10);
            this.flpMenu.Size = new System.Drawing.Size(986, 73);
            this.flpMenu.TabIndex = 103;
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
            this.modernBox2.Controls.Add(this.dgvClientes);
            this.modernBox2.FillColor = System.Drawing.Color.White;
            this.modernBox2.Location = new System.Drawing.Point(16, 237);
            this.modernBox2.Name = "modernBox2";
            this.modernBox2.Padding = new System.Windows.Forms.Padding(13);
            this.modernBox2.ShadowAngle = 135;
            this.modernBox2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.modernBox2.ShadowSize = 8;
            this.modernBox2.Size = new System.Drawing.Size(1018, 376);
            this.modernBox2.TabIndex = 163;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.panel2.Controls.Add(this.cbxQtdRegistros);
            this.panel2.Controls.Add(this.lbRegistros);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 618);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 44);
            this.panel2.TabIndex = 164;
            // 
            // PesquisaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1042, 662);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.modernBox2);
            this.Controls.Add(this.modernBox1);
            this.Controls.Add(this.pnSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PesquisaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PesquisaCliente_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PesquisaCliente_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.pnSuperior.ResumeLayout(false);
            this.pnSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.modernBox1.ResumeLayout(false);
            this.painelRadius3.ResumeLayout(false);
            this.painelRadius3.PerformLayout();
            this.flpMenu.ResumeLayout(false);
            this.modernBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxQtdRegistros;
        private System.Windows.Forms.Label lbRegistros;
        private MaterialSkin.Controls.MaterialTextBox txtCliente;
        private MaterialSkin.Controls.MaterialTextBox txtIdentidade;
        private MaterialSkin.Controls.MaterialTextBox txtCidade;
        private MaterialSkin.Controls.MaterialTextBox txtUf;
        private MaterialSkin.Controls.MaterialCheckbox chkAtivo;
        private Componentes.CustomButton btnSearch;
        private Componentes.CustomButton btnApagar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private MaterialSkin.Controls.MaterialRadioButton rbtPJ;
        private MaterialSkin.Controls.MaterialRadioButton rbtPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdentidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUf;
        private System.Windows.Forms.DataGridViewImageColumn colExcluir;
        private System.Windows.Forms.Panel pnSuperior;
        private Componentes.RoundedPanel pn1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private Componentes.CustomButton btnClose;
        private Componentes.CustomButton btnMaximize;
        private Componentes.CustomButton btnNovoCliente;
        private Componentes.CustomButton btnMinimize;
        private Componentes.ModernBox modernBox1;
        private Componentes.PainelRadius painelRadius3;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private Componentes.ModernBox modernBox2;
        private System.Windows.Forms.Panel panel2;
    }
}