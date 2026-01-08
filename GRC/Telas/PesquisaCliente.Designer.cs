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
            this.roundedPanel1 = new GRC.Componentes.RoundedPanel();
            this.customPanel2 = new GRC.Componentes.CustomPanel();
            this.cbxQtdRegistros = new System.Windows.Forms.ComboBox();
            this.lbRegistros = new System.Windows.Forms.Label();
            this.pnPesquisa = new GRC.Componentes.CustomPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtCliente = new MaterialSkin.Controls.MaterialTextBox();
            this.txtIdentidade = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCidade = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUf = new MaterialSkin.Controls.MaterialTextBox();
            this.chkAtivo = new MaterialSkin.Controls.MaterialCheckbox();
            this.rbtPJ = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtPF = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnSearch = new GRC.Componentes.CustomButton();
            this.btnAddCliente = new GRC.Componentes.CustomButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnApagar = new GRC.Componentes.CustomButton();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.colIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdentidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.customPanel2.SuspendLayout();
            this.pnPesquisa.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.Color1 = System.Drawing.Color.Aqua;
            this.roundedPanel1.Color2 = System.Drawing.Color.Purple;
            this.roundedPanel1.CornerRadius = 10;
            this.roundedPanel1.GradientAngle = 45F;
            this.roundedPanel1.Location = new System.Drawing.Point(16, 205);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(1095, 20);
            this.roundedPanel1.TabIndex = 21;
            // 
            // customPanel2
            // 
            this.customPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.customPanel2.Controls.Add(this.cbxQtdRegistros);
            this.customPanel2.Controls.Add(this.lbRegistros);
            this.customPanel2.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.customPanel2.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.customPanel2.CorTextoBotao = System.Drawing.Color.White;
            this.customPanel2.ForeColor = System.Drawing.Color.White;
            this.customPanel2.Location = new System.Drawing.Point(12, 616);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(1099, 37);
            this.customPanel2.TabIndex = 19;
            this.customPanel2.TamanhoBorda = 0;
            this.customPanel2.TamanhoRaio = 10;
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
            this.cbxQtdRegistros.Location = new System.Drawing.Point(1021, 10);
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
            this.lbRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRegistros.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistros.ForeColor = System.Drawing.Color.White;
            this.lbRegistros.Location = new System.Drawing.Point(0, 0);
            this.lbRegistros.Name = "lbRegistros";
            this.lbRegistros.Padding = new System.Windows.Forms.Padding(5);
            this.lbRegistros.Size = new System.Drawing.Size(211, 31);
            this.lbRegistros.TabIndex = 1;
            this.lbRegistros.Text = "0 Registros Encontrados";
            // 
            // pnPesquisa
            // 
            this.pnPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnPesquisa.BackColor = System.Drawing.Color.AliceBlue;
            this.pnPesquisa.Controls.Add(this.flowLayoutPanel1);
            this.pnPesquisa.Controls.Add(this.btnSearch);
            this.pnPesquisa.Controls.Add(this.btnAddCliente);
            this.pnPesquisa.Controls.Add(this.materialLabel1);
            this.pnPesquisa.Controls.Add(this.btnApagar);
            this.pnPesquisa.CorBorda = System.Drawing.Color.Black;
            this.pnPesquisa.CorBotao = System.Drawing.Color.AliceBlue;
            this.pnPesquisa.CorTextoBotao = System.Drawing.Color.White;
            this.pnPesquisa.ForeColor = System.Drawing.Color.White;
            this.pnPesquisa.Location = new System.Drawing.Point(12, 10);
            this.pnPesquisa.Name = "pnPesquisa";
            this.pnPesquisa.Size = new System.Drawing.Size(1099, 189);
            this.pnPesquisa.TabIndex = 20;
            this.pnPesquisa.TamanhoBorda = 0;
            this.pnPesquisa.TamanhoRaio = 20;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.txtCliente);
            this.flowLayoutPanel1.Controls.Add(this.txtIdentidade);
            this.flowLayoutPanel1.Controls.Add(this.txtCidade);
            this.flowLayoutPanel1.Controls.Add(this.txtUf);
            this.flowLayoutPanel1.Controls.Add(this.chkAtivo);
            this.flowLayoutPanel1.Controls.Add(this.rbtPJ);
            this.flowLayoutPanel1.Controls.Add(this.rbtPF);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1068, 119);
            this.flowLayoutPanel1.TabIndex = 103;
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
            this.txtCliente.Location = new System.Drawing.Point(3, 3);
            this.txtCliente.MaxLength = 80;
            this.txtCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCliente.Multiline = false;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(388, 50);
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
            this.txtIdentidade.Location = new System.Drawing.Point(397, 3);
            this.txtIdentidade.MaxLength = 18;
            this.txtIdentidade.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdentidade.Multiline = false;
            this.txtIdentidade.Name = "txtIdentidade";
            this.txtIdentidade.Size = new System.Drawing.Size(247, 50);
            this.txtIdentidade.TabIndex = 8;
            this.txtIdentidade.Text = "";
            this.txtIdentidade.TrailingIcon = null;
            this.txtIdentidade.UseAccent = false;
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
            this.txtCidade.Location = new System.Drawing.Point(650, 3);
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
            this.txtUf.Location = new System.Drawing.Point(892, 3);
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
            this.chkAtivo.Location = new System.Drawing.Point(965, 0);
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
            this.rbtPJ.Location = new System.Drawing.Point(0, 56);
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
            this.rbtPF.Location = new System.Drawing.Point(148, 56);
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
            this.btnSearch.Location = new System.Drawing.Point(1039, 5);
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
            this.btnAddCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCliente.Location = new System.Drawing.Point(250, 17);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(150, 37);
            this.btnAddCliente.TabIndex = 16;
            this.btnAddCliente.TamanhoBorda = 0;
            this.btnAddCliente.TamanhoRaio = 5;
            this.btnAddCliente.Text = "     Novo Cliente";
            this.btnAddCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCliente.UseVisualStyleBackColor = false;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.SlateGray;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.ForeColor = System.Drawing.Color.Black;
            this.materialLabel1.Location = new System.Drawing.Point(18, 24);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(188, 24);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Pesquisa de Clientes";
            // 
            // btnApagar
            // 
            this.btnApagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnApagar.Location = new System.Drawing.Point(990, 5);
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
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.GridColor = System.Drawing.Color.DarkGray;
            this.dgvClientes.Location = new System.Drawing.Point(12, 231);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvClientes.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(1099, 379);
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
            // PesquisaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(1123, 662);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.pnPesquisa);
            this.Controls.Add(this.dgvClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PesquisaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Clientes";
            this.Load += new System.EventHandler(this.PesquisaCliente_Load);
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.pnPesquisa.ResumeLayout(false);
            this.pnPesquisa.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.RoundedPanel roundedPanel1;
        private Componentes.CustomPanel customPanel2;
        private System.Windows.Forms.ComboBox cbxQtdRegistros;
        private System.Windows.Forms.Label lbRegistros;
        private Componentes.CustomPanel pnPesquisa;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialTextBox txtCliente;
        private MaterialSkin.Controls.MaterialTextBox txtIdentidade;
        private MaterialSkin.Controls.MaterialTextBox txtCidade;
        private MaterialSkin.Controls.MaterialTextBox txtUf;
        private MaterialSkin.Controls.MaterialCheckbox chkAtivo;
        private Componentes.CustomButton btnSearch;
        private Componentes.CustomButton btnAddCliente;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
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
    }
}