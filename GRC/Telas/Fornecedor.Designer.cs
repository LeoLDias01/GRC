namespace GRC.Telas
{
    partial class Fornecedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fornecedor));
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            this.colIdFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRazaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcluirFornecedor = new System.Windows.Forms.DataGridViewImageColumn();
            this.customPanel2 = new GRC.Componentes.CustomPanel();
            this.cbxQtdRegistros = new System.Windows.Forms.ComboBox();
            this.lbRegistros = new System.Windows.Forms.Label();
            this.pnPesquisa = new GRC.Componentes.CustomPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtFornecedor = new MaterialSkin.Controls.MaterialTextBox();
            this.txtRazaoSocial = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCnpj = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCidade = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUf = new MaterialSkin.Controls.MaterialTextBox();
            this.chkAtivo = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnSearch = new GRC.Componentes.CustomButton();
            this.btnAddFornecedor = new GRC.Componentes.CustomButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnApagar = new GRC.Componentes.CustomButton();
            this.roundedPanel1 = new GRC.Componentes.RoundedPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            this.customPanel2.SuspendLayout();
            this.pnPesquisa.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.AllowUserToAddRows = false;
            this.dgvFornecedores.AllowUserToDeleteRows = false;
            this.dgvFornecedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFornecedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFornecedores.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvFornecedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFornecedores.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvFornecedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFornecedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFornecedores.ColumnHeadersHeight = 35;
            this.dgvFornecedores.ColumnHeadersVisible = false;
            this.dgvFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdFornecedor,
            this.colNomeFornecedor,
            this.colRazaoSocial,
            this.colCnpj,
            this.colCidade,
            this.colUf,
            this.colExcluirFornecedor});
            this.dgvFornecedores.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFornecedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFornecedores.EnableHeadersVisualStyles = false;
            this.dgvFornecedores.GridColor = System.Drawing.Color.DarkGray;
            this.dgvFornecedores.Location = new System.Drawing.Point(12, 233);
            this.dgvFornecedores.MultiSelect = false;
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.ReadOnly = true;
            this.dgvFornecedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFornecedores.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvFornecedores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedores.Size = new System.Drawing.Size(1099, 379);
            this.dgvFornecedores.TabIndex = 11;
            this.dgvFornecedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedores_CellDoubleClick);
            this.dgvFornecedores.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedores_CellValueChanged);
            // 
            // colIdFornecedor
            // 
            this.colIdFornecedor.DataPropertyName = "Id";
            this.colIdFornecedor.FillWeight = 1F;
            this.colIdFornecedor.HeaderText = "Id";
            this.colIdFornecedor.Name = "colIdFornecedor";
            this.colIdFornecedor.ReadOnly = true;
            this.colIdFornecedor.Visible = false;
            // 
            // colNomeFornecedor
            // 
            this.colNomeFornecedor.DataPropertyName = "Nome";
            this.colNomeFornecedor.HeaderText = "Fornecedor";
            this.colNomeFornecedor.Name = "colNomeFornecedor";
            this.colNomeFornecedor.ReadOnly = true;
            // 
            // colRazaoSocial
            // 
            this.colRazaoSocial.DataPropertyName = "RazaoSocial";
            this.colRazaoSocial.HeaderText = "Razão Social";
            this.colRazaoSocial.Name = "colRazaoSocial";
            this.colRazaoSocial.ReadOnly = true;
            // 
            // colCnpj
            // 
            this.colCnpj.DataPropertyName = "Cnpj";
            this.colCnpj.HeaderText = "CNPJ";
            this.colCnpj.Name = "colCnpj";
            this.colCnpj.ReadOnly = true;
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
            // colExcluirFornecedor
            // 
            this.colExcluirFornecedor.FillWeight = 30F;
            this.colExcluirFornecedor.HeaderText = "";
            this.colExcluirFornecedor.Image = global::GRC.Properties.Resources.remove;
            this.colExcluirFornecedor.Name = "colExcluirFornecedor";
            this.colExcluirFornecedor.ReadOnly = true;
            this.colExcluirFornecedor.Visible = false;
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
            this.customPanel2.Location = new System.Drawing.Point(12, 618);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(1099, 37);
            this.customPanel2.TabIndex = 15;
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
            this.pnPesquisa.Controls.Add(this.btnAddFornecedor);
            this.pnPesquisa.Controls.Add(this.materialLabel1);
            this.pnPesquisa.Controls.Add(this.btnApagar);
            this.pnPesquisa.CorBorda = System.Drawing.Color.Black;
            this.pnPesquisa.CorBotao = System.Drawing.Color.AliceBlue;
            this.pnPesquisa.CorTextoBotao = System.Drawing.Color.White;
            this.pnPesquisa.ForeColor = System.Drawing.Color.White;
            this.pnPesquisa.Location = new System.Drawing.Point(12, 12);
            this.pnPesquisa.Name = "pnPesquisa";
            this.pnPesquisa.Size = new System.Drawing.Size(1099, 189);
            this.pnPesquisa.TabIndex = 15;
            this.pnPesquisa.TamanhoBorda = 0;
            this.pnPesquisa.TamanhoRaio = 20;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.txtFornecedor);
            this.flowLayoutPanel1.Controls.Add(this.txtRazaoSocial);
            this.flowLayoutPanel1.Controls.Add(this.txtCnpj);
            this.flowLayoutPanel1.Controls.Add(this.txtCidade);
            this.flowLayoutPanel1.Controls.Add(this.txtUf);
            this.flowLayoutPanel1.Controls.Add(this.chkAtivo);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1068, 119);
            this.flowLayoutPanel1.TabIndex = 103;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.AcceptsTab = true;
            this.txtFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFornecedor.AnimateReadOnly = false;
            this.txtFornecedor.AutoWordSelection = true;
            this.txtFornecedor.BackColor = System.Drawing.Color.White;
            this.txtFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFornecedor.Depth = 0;
            this.txtFornecedor.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFornecedor.Hint = "Fornecedor";
            this.txtFornecedor.LeadingIcon = null;
            this.txtFornecedor.LeaveOnEnterKey = true;
            this.txtFornecedor.Location = new System.Drawing.Point(3, 3);
            this.txtFornecedor.MaxLength = 80;
            this.txtFornecedor.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFornecedor.Multiline = false;
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(388, 50);
            this.txtFornecedor.TabIndex = 0;
            this.txtFornecedor.Text = "";
            this.txtFornecedor.TrailingIcon = null;
            this.txtFornecedor.UseAccent = false;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.AcceptsTab = true;
            this.txtRazaoSocial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRazaoSocial.AnimateReadOnly = false;
            this.txtRazaoSocial.AutoWordSelection = true;
            this.txtRazaoSocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRazaoSocial.Depth = 0;
            this.txtRazaoSocial.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRazaoSocial.Hint = "Razão Social";
            this.txtRazaoSocial.LeadingIcon = null;
            this.txtRazaoSocial.LeaveOnEnterKey = true;
            this.txtRazaoSocial.Location = new System.Drawing.Point(397, 3);
            this.txtRazaoSocial.MaxLength = 18;
            this.txtRazaoSocial.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRazaoSocial.Multiline = false;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(421, 50);
            this.txtRazaoSocial.TabIndex = 9;
            this.txtRazaoSocial.Text = "";
            this.txtRazaoSocial.TrailingIcon = null;
            this.txtRazaoSocial.UseAccent = false;
            // 
            // txtCnpj
            // 
            this.txtCnpj.AcceptsTab = true;
            this.txtCnpj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCnpj.AnimateReadOnly = false;
            this.txtCnpj.AutoWordSelection = true;
            this.txtCnpj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCnpj.Depth = 0;
            this.txtCnpj.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCnpj.Hint = "CNPJ";
            this.txtCnpj.LeadingIcon = null;
            this.txtCnpj.LeaveOnEnterKey = true;
            this.txtCnpj.Location = new System.Drawing.Point(3, 59);
            this.txtCnpj.MaxLength = 18;
            this.txtCnpj.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCnpj.Multiline = false;
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(247, 50);
            this.txtCnpj.TabIndex = 8;
            this.txtCnpj.Text = "";
            this.txtCnpj.TrailingIcon = null;
            this.txtCnpj.UseAccent = false;
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
            this.txtCidade.Location = new System.Drawing.Point(256, 59);
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
            this.txtUf.Location = new System.Drawing.Point(498, 59);
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
            this.chkAtivo.Location = new System.Drawing.Point(571, 56);
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
            // btnAddFornecedor
            // 
            this.btnAddFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnAddFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddFornecedor.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnAddFornecedor.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnAddFornecedor.CorTextoBotao = System.Drawing.Color.White;
            this.btnAddFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFornecedor.FlatAppearance.BorderSize = 0;
            this.btnAddFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAddFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFornecedor.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnAddFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFornecedor.Image")));
            this.btnAddFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFornecedor.Location = new System.Drawing.Point(250, 17);
            this.btnAddFornecedor.Name = "btnAddFornecedor";
            this.btnAddFornecedor.Size = new System.Drawing.Size(150, 37);
            this.btnAddFornecedor.TabIndex = 16;
            this.btnAddFornecedor.TamanhoBorda = 0;
            this.btnAddFornecedor.TamanhoRaio = 5;
            this.btnAddFornecedor.Text = " Novo Fornecedor";
            this.btnAddFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddFornecedor.UseVisualStyleBackColor = false;
            this.btnAddFornecedor.Click += new System.EventHandler(this.btnAddFornecedor_Click);
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
            this.materialLabel1.Size = new System.Drawing.Size(216, 24);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Pesquisa de Fornecedor";
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
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.Color1 = System.Drawing.Color.Aqua;
            this.roundedPanel1.Color2 = System.Drawing.Color.Purple;
            this.roundedPanel1.CornerRadius = 10;
            this.roundedPanel1.GradientAngle = 45F;
            this.roundedPanel1.Location = new System.Drawing.Point(16, 207);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(1095, 20);
            this.roundedPanel1.TabIndex = 17;
            // 
            // Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(1123, 662);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.pnPesquisa);
            this.Controls.Add(this.dgvFornecedores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedor";
            this.Load += new System.EventHandler(this.Fornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.pnPesquisa.ResumeLayout(false);
            this.pnPesquisa.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFornecedores;
        private MaterialSkin.Controls.MaterialTextBox txtFornecedor;
        private System.Windows.Forms.Label lbRegistros;
        private MaterialSkin.Controls.MaterialTextBox txtRazaoSocial;
        private MaterialSkin.Controls.MaterialTextBox txtCnpj;
        private Componentes.CustomPanel pnPesquisa;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtUf;
        private MaterialSkin.Controls.MaterialTextBox txtCidade;
        private Componentes.CustomPanel customPanel2;
        private System.Windows.Forms.ComboBox cbxQtdRegistros;
        private Componentes.CustomButton btnAddFornecedor;
        private Componentes.CustomButton btnApagar;
        private Componentes.CustomButton btnSearch;
        private MaterialSkin.Controls.MaterialCheckbox chkAtivo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Componentes.RoundedPanel roundedPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRazaoSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUf;
        private System.Windows.Forms.DataGridViewImageColumn colExcluirFornecedor;
    }
}