namespace GRC.Telas
{
    partial class PesquisaRapidaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaRapidaCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rbtPF = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtPJ = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtIdentidade = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCliente = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSearch = new GRC.Componentes.CustomButton();
            this.btnAddCliente = new GRC.Componentes.CustomButton();
            this.btnApagar = new GRC.Componentes.CustomButton();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.colIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdentidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxQtdRegistros = new System.Windows.Forms.ComboBox();
            this.lbRegistros = new System.Windows.Forms.Label();
            this.roundedPanel1 = new GRC.Componentes.RoundedPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.painelRadius1 = new GRC.Componentes.PainelRadius();
            this.painelRadius2 = new GRC.Componentes.PainelRadius();
            this.painelRadius3 = new GRC.Componentes.PainelRadius();
            this.btnMaximize = new GRC.Componentes.CustomButton();
            this.btnMinimize = new GRC.Componentes.CustomButton();
            this.btnClose = new GRC.Componentes.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.painelRadius1.SuspendLayout();
            this.painelRadius2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtPF
            // 
            this.rbtPF.AutoSize = true;
            this.rbtPF.Depth = 0;
            this.rbtPF.Location = new System.Drawing.Point(6, 9);
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
            // rbtPJ
            // 
            this.rbtPJ.AutoSize = true;
            this.rbtPJ.Depth = 0;
            this.rbtPJ.Location = new System.Drawing.Point(151, 9);
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
            // txtIdentidade
            // 
            this.txtIdentidade.AcceptsTab = true;
            this.txtIdentidade.AnimateReadOnly = false;
            this.txtIdentidade.AutoWordSelection = true;
            this.txtIdentidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentidade.Depth = 0;
            this.txtIdentidade.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdentidade.Hint = "CNPJ/CPF";
            this.txtIdentidade.LeadingIcon = null;
            this.txtIdentidade.LeaveOnEnterKey = true;
            this.txtIdentidade.Location = new System.Drawing.Point(7, 59);
            this.txtIdentidade.MaxLength = 18;
            this.txtIdentidade.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdentidade.Multiline = false;
            this.txtIdentidade.Name = "txtIdentidade";
            this.txtIdentidade.Size = new System.Drawing.Size(219, 50);
            this.txtIdentidade.TabIndex = 8;
            this.txtIdentidade.Text = "";
            this.txtIdentidade.TrailingIcon = null;
            this.txtIdentidade.UseAccent = false;
            this.txtIdentidade.TextChanged += new System.EventHandler(this.txtIdentidade_TextChanged);
            // 
            // txtCliente
            // 
            this.txtCliente.AcceptsTab = true;
            this.txtCliente.AnimateReadOnly = false;
            this.txtCliente.AutoWordSelection = true;
            this.txtCliente.BackColor = System.Drawing.Color.White;
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCliente.Depth = 0;
            this.txtCliente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCliente.Hint = "Cliente";
            this.txtCliente.LeadingIcon = null;
            this.txtCliente.LeaveOnEnterKey = true;
            this.txtCliente.Location = new System.Drawing.Point(232, 59);
            this.txtCliente.MaxLength = 80;
            this.txtCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCliente.Multiline = false;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(370, 50);
            this.txtCliente.TabIndex = 0;
            this.txtCliente.Text = "";
            this.txtCliente.TrailingIcon = null;
            this.txtCliente.UseAccent = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnSearch.Location = new System.Drawing.Point(564, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(43, 43);
            this.btnSearch.TabIndex = 101;
            this.btnSearch.TamanhoBorda = 0;
            this.btnSearch.TamanhoRaio = 10;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnAddCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddCliente.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnAddCliente.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnAddCliente.CorTextoBotao = System.Drawing.Color.White;
            this.btnAddCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCliente.FlatAppearance.BorderSize = 0;
            this.btnAddCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAddCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCliente.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddCliente.ForeColor = System.Drawing.Color.White;
            this.btnAddCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCliente.Image")));
            this.btnAddCliente.Location = new System.Drawing.Point(369, 21);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(43, 43);
            this.btnAddCliente.TabIndex = 16;
            this.btnAddCliente.TamanhoBorda = 0;
            this.btnAddCliente.TamanhoRaio = 10;
            this.btnAddCliente.UseVisualStyleBackColor = false;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
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
            this.btnApagar.Location = new System.Drawing.Point(320, 21);
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
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.AliceBlue;
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
            this.colIdentidade});
            this.dgvClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.GridColor = System.Drawing.Color.DarkGray;
            this.dgvClientes.Location = new System.Drawing.Point(15, 225);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvClientes.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(605, 350);
            this.dgvClientes.TabIndex = 21;
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
            this.cbxQtdRegistros.Location = new System.Drawing.Point(546, 10);
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
            this.lbRegistros.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistros.ForeColor = System.Drawing.Color.White;
            this.lbRegistros.Location = new System.Drawing.Point(3, 3);
            this.lbRegistros.Name = "lbRegistros";
            this.lbRegistros.Padding = new System.Windows.Forms.Padding(5);
            this.lbRegistros.Size = new System.Drawing.Size(211, 31);
            this.lbRegistros.TabIndex = 1;
            this.lbRegistros.Text = "0 Registros Encontrados";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.Color1 = System.Drawing.Color.SkyBlue;
            this.roundedPanel1.Color2 = System.Drawing.Color.Black;
            this.roundedPanel1.CornerRadius = 10;
            this.roundedPanel1.GradientAngle = 180F;
            this.roundedPanel1.Location = new System.Drawing.Point(-16, 56);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(313, 10);
            this.roundedPanel1.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "Pesquisa de Clientes";
            // 
            // painelRadius1
            // 
            this.painelRadius1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelRadius1.BackColor = System.Drawing.Color.AliceBlue;
            this.painelRadius1.BorderColor = System.Drawing.Color.AliceBlue;
            this.painelRadius1.Controls.Add(this.txtCliente);
            this.painelRadius1.Controls.Add(this.rbtPF);
            this.painelRadius1.Controls.Add(this.rbtPJ);
            this.painelRadius1.Controls.Add(this.txtIdentidade);
            this.painelRadius1.Controls.Add(this.btnSearch);
            this.painelRadius1.Location = new System.Drawing.Point(12, 83);
            this.painelRadius1.Name = "painelRadius1";
            this.painelRadius1.Radius = 30;
            this.painelRadius1.Size = new System.Drawing.Size(610, 121);
            this.painelRadius1.TabIndex = 105;
            this.painelRadius1.Thickness = 0F;
            // 
            // painelRadius2
            // 
            this.painelRadius2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelRadius2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.painelRadius2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.painelRadius2.Controls.Add(this.lbRegistros);
            this.painelRadius2.Controls.Add(this.cbxQtdRegistros);
            this.painelRadius2.Location = new System.Drawing.Point(12, 581);
            this.painelRadius2.Name = "painelRadius2";
            this.painelRadius2.Radius = 20;
            this.painelRadius2.Size = new System.Drawing.Size(608, 37);
            this.painelRadius2.TabIndex = 106;
            this.painelRadius2.Thickness = 5F;
            // 
            // painelRadius3
            // 
            this.painelRadius3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelRadius3.AutoSize = true;
            this.painelRadius3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.painelRadius3.BackColor = System.Drawing.Color.AliceBlue;
            this.painelRadius3.BorderColor = System.Drawing.Color.AliceBlue;
            this.painelRadius3.Location = new System.Drawing.Point(12, 225);
            this.painelRadius3.Name = "painelRadius3";
            this.painelRadius3.Radius = 20;
            this.painelRadius3.Size = new System.Drawing.Size(0, 0);
            this.painelRadius3.TabIndex = 107;
            this.painelRadius3.Thickness = 5F;
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
            this.btnMaximize.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(549, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(40, 35);
            this.btnMaximize.TabIndex = 111;
            this.btnMaximize.TamanhoBorda = 0;
            this.btnMaximize.TamanhoRaio = 17;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
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
            this.btnMinimize.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(503, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 35);
            this.btnMinimize.TabIndex = 110;
            this.btnMinimize.TamanhoBorda = 0;
            this.btnMinimize.TamanhoRaio = 17;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
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
            this.btnClose.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(595, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 35);
            this.btnClose.TabIndex = 112;
            this.btnClose.TamanhoBorda = 0;
            this.btnClose.TamanhoRaio = 17;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PesquisaRapidaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(631, 630);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.painelRadius3);
            this.Controls.Add(this.painelRadius2);
            this.Controls.Add(this.painelRadius1);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnAddCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(631, 630);
            this.Name = "PesquisaRapidaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Clientes";
            this.Load += new System.EventHandler(this.PesquisaRapidaCliente_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PesquisaRapidaCliente_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.painelRadius1.ResumeLayout(false);
            this.painelRadius1.PerformLayout();
            this.painelRadius2.ResumeLayout(false);
            this.painelRadius2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtCliente;
        private MaterialSkin.Controls.MaterialTextBox txtIdentidade;
        private MaterialSkin.Controls.MaterialRadioButton rbtPJ;
        private MaterialSkin.Controls.MaterialRadioButton rbtPF;
        private Componentes.CustomButton btnSearch;
        private Componentes.CustomButton btnAddCliente;
        private Componentes.CustomButton btnApagar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.ComboBox cbxQtdRegistros;
        private System.Windows.Forms.Label lbRegistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdentidade;
        private Componentes.RoundedPanel roundedPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Componentes.PainelRadius painelRadius1;
        private Componentes.PainelRadius painelRadius2;
        private Componentes.PainelRadius painelRadius3;
        private Componentes.CustomButton btnMaximize;
        private Componentes.CustomButton btnMinimize;
        private Componentes.CustomButton btnClose;
    }
}