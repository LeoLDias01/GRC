namespace GRC.Telas
{
    partial class CadastroMovimentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroMovimentacao));
            this.pcAtivo = new System.Windows.Forms.PictureBox();
            this.swItemAtivo = new MaterialSkin.Controls.MaterialSwitch();
            this.pnStatus2 = new GRC.Componentes.RoundedPanel();
            this.pnStatus = new GRC.Componentes.RoundedPanel();
            this.White = new GRC.Componentes.CustomPanel();
            this.txtData = new MaterialSkin.Controls.MaterialTextBox();
            this.cbTipoMovimento = new MaterialSkin.Controls.MaterialComboBox();
            this.txtItem = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCustoUnitario = new MaterialSkin.Controls.MaterialTextBox();
            this.txtObservacoes = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtMotivo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtQuantidade = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCustoTotal = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSalvar = new GRC.Componentes.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new GRC.Componentes.CustomButton();
            this.btnClose = new GRC.Componentes.CustomButton();
            this.btnApagar = new GRC.Componentes.CustomButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcAtivo)).BeginInit();
            this.White.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pcAtivo
            // 
            this.pcAtivo.Image = ((System.Drawing.Image)(resources.GetObject("pcAtivo.Image")));
            this.pcAtivo.Location = new System.Drawing.Point(243, 20);
            this.pcAtivo.Name = "pcAtivo";
            this.pcAtivo.Size = new System.Drawing.Size(35, 36);
            this.pcAtivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcAtivo.TabIndex = 77;
            this.pcAtivo.TabStop = false;
            this.pcAtivo.Visible = false;
            // 
            // swItemAtivo
            // 
            this.swItemAtivo.AutoSize = true;
            this.swItemAtivo.Depth = 0;
            this.swItemAtivo.ForeColor = System.Drawing.Color.White;
            this.swItemAtivo.Location = new System.Drawing.Point(285, 20);
            this.swItemAtivo.Margin = new System.Windows.Forms.Padding(0);
            this.swItemAtivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swItemAtivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.swItemAtivo.Name = "swItemAtivo";
            this.swItemAtivo.Ripple = true;
            this.swItemAtivo.Size = new System.Drawing.Size(58, 37);
            this.swItemAtivo.TabIndex = 76;
            this.swItemAtivo.UseVisualStyleBackColor = true;
            this.swItemAtivo.CheckedChanged += new System.EventHandler(this.swItemAtivo_CheckedChanged);
            // 
            // pnStatus2
            // 
            this.pnStatus2.BackColor = System.Drawing.Color.Transparent;
            this.pnStatus2.Color1 = System.Drawing.Color.Aquamarine;
            this.pnStatus2.Color2 = System.Drawing.Color.DarkTurquoise;
            this.pnStatus2.CornerRadius = 10;
            this.pnStatus2.GradientAngle = 90F;
            this.pnStatus2.Location = new System.Drawing.Point(3, 61);
            this.pnStatus2.Name = "pnStatus2";
            this.pnStatus2.Size = new System.Drawing.Size(54, 77);
            this.pnStatus2.TabIndex = 54;
            // 
            // pnStatus
            // 
            this.pnStatus.BackColor = System.Drawing.Color.Transparent;
            this.pnStatus.Color1 = System.Drawing.Color.Aquamarine;
            this.pnStatus.Color2 = System.Drawing.Color.DarkTurquoise;
            this.pnStatus.CornerRadius = 10;
            this.pnStatus.GradientAngle = 90F;
            this.pnStatus.Location = new System.Drawing.Point(68, 61);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(321, 54);
            this.pnStatus.TabIndex = 53;
            // 
            // White
            // 
            this.White.BackColor = System.Drawing.Color.AliceBlue;
            this.White.Controls.Add(this.txtData);
            this.White.Controls.Add(this.cbTipoMovimento);
            this.White.Controls.Add(this.txtItem);
            this.White.Controls.Add(this.txtCustoUnitario);
            this.White.Controls.Add(this.txtObservacoes);
            this.White.Controls.Add(this.txtMotivo);
            this.White.Controls.Add(this.txtQuantidade);
            this.White.Controls.Add(this.txtCustoTotal);
            this.White.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.White.CorBotao = System.Drawing.Color.AliceBlue;
            this.White.CorTextoBotao = System.Drawing.Color.White;
            this.White.ForeColor = System.Drawing.Color.White;
            this.White.Location = new System.Drawing.Point(18, 89);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(734, 244);
            this.White.TabIndex = 52;
            this.White.TamanhoBorda = 0;
            this.White.TamanhoRaio = 20;
            // 
            // txtData
            // 
            this.txtData.AcceptsTab = true;
            this.txtData.AnimateReadOnly = false;
            this.txtData.AutoWordSelection = true;
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtData.Depth = 0;
            this.txtData.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtData.Hint = "Data";
            this.txtData.LeadingIcon = null;
            this.txtData.LeaveOnEnterKey = true;
            this.txtData.Location = new System.Drawing.Point(16, 15);
            this.txtData.MaxLength = 60;
            this.txtData.MouseState = MaterialSkin.MouseState.OUT;
            this.txtData.Multiline = false;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(150, 50);
            this.txtData.TabIndex = 101;
            this.txtData.Text = "";
            this.txtData.TrailingIcon = null;
            this.txtData.UseAccent = false;
            this.txtData.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            this.txtData.Leave += new System.EventHandler(this.txtData_Leave);
            // 
            // cbTipoMovimento
            // 
            this.cbTipoMovimento.AutoResize = false;
            this.cbTipoMovimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbTipoMovimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTipoMovimento.Depth = 0;
            this.cbTipoMovimento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbTipoMovimento.DropDownHeight = 174;
            this.cbTipoMovimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoMovimento.DropDownWidth = 121;
            this.cbTipoMovimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbTipoMovimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTipoMovimento.FormattingEnabled = true;
            this.cbTipoMovimento.Hint = "Tipo de Movimentação";
            this.cbTipoMovimento.IntegralHeight = false;
            this.cbTipoMovimento.ItemHeight = 43;
            this.cbTipoMovimento.Location = new System.Drawing.Point(172, 15);
            this.cbTipoMovimento.MaxDropDownItems = 4;
            this.cbTipoMovimento.MouseState = MaterialSkin.MouseState.OUT;
            this.cbTipoMovimento.Name = "cbTipoMovimento";
            this.cbTipoMovimento.Size = new System.Drawing.Size(231, 49);
            this.cbTipoMovimento.StartIndex = 0;
            this.cbTipoMovimento.TabIndex = 80;
            this.cbTipoMovimento.UseAccent = false;
            this.cbTipoMovimento.SelectedValueChanged += new System.EventHandler(this.cbTipoMovimento_SelectedValueChanged);
            // 
            // txtItem
            // 
            this.txtItem.AcceptsTab = true;
            this.txtItem.AnimateReadOnly = true;
            this.txtItem.AutoWordSelection = true;
            this.txtItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItem.Depth = 0;
            this.txtItem.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtItem.Hint = "Item";
            this.txtItem.LeadingIcon = null;
            this.txtItem.LeaveOnEnterKey = true;
            this.txtItem.Location = new System.Drawing.Point(409, 15);
            this.txtItem.MaxLength = 60;
            this.txtItem.MouseState = MaterialSkin.MouseState.OUT;
            this.txtItem.Multiline = false;
            this.txtItem.Name = "txtItem";
            this.txtItem.ReadOnly = true;
            this.txtItem.Size = new System.Drawing.Size(317, 50);
            this.txtItem.TabIndex = 46;
            this.txtItem.Text = "";
            this.txtItem.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtItem.TrailingIcon")));
            this.txtItem.UseAccent = false;
            this.txtItem.TrailingIconClick += new System.EventHandler(this.txtItem_TrailingIconClick);
            // 
            // txtCustoUnitario
            // 
            this.txtCustoUnitario.AcceptsTab = true;
            this.txtCustoUnitario.AnimateReadOnly = false;
            this.txtCustoUnitario.AutoWordSelection = true;
            this.txtCustoUnitario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustoUnitario.Depth = 0;
            this.txtCustoUnitario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustoUnitario.Hint = "Custo unitário";
            this.txtCustoUnitario.LeadingIcon = null;
            this.txtCustoUnitario.LeaveOnEnterKey = true;
            this.txtCustoUnitario.Location = new System.Drawing.Point(576, 126);
            this.txtCustoUnitario.MaxLength = 60;
            this.txtCustoUnitario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCustoUnitario.Multiline = false;
            this.txtCustoUnitario.Name = "txtCustoUnitario";
            this.txtCustoUnitario.Size = new System.Drawing.Size(150, 50);
            this.txtCustoUnitario.TabIndex = 102;
            this.txtCustoUnitario.Text = "";
            this.txtCustoUnitario.TrailingIcon = null;
            this.txtCustoUnitario.UseAccent = false;
            this.txtCustoUnitario.Visible = false;
            this.txtCustoUnitario.TextChanged += new System.EventHandler(this.txtCustoUnitario_TextChanged);
            this.txtCustoUnitario.Enter += new System.EventHandler(this.txtCustoUnitario_Enter);
            this.txtCustoUnitario.Leave += new System.EventHandler(this.txtCustoUnitario_Leave);
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObservacoes.AnimateReadOnly = false;
            this.txtObservacoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtObservacoes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtObservacoes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObservacoes.Depth = 0;
            this.txtObservacoes.HideSelection = true;
            this.txtObservacoes.Hint = "Observações";
            this.txtObservacoes.Location = new System.Drawing.Point(16, 126);
            this.txtObservacoes.MaxLength = 300;
            this.txtObservacoes.MouseState = MaterialSkin.MouseState.OUT;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.PasswordChar = '\0';
            this.txtObservacoes.ReadOnly = false;
            this.txtObservacoes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObservacoes.SelectedText = "";
            this.txtObservacoes.SelectionLength = 0;
            this.txtObservacoes.SelectionStart = 0;
            this.txtObservacoes.ShortcutsEnabled = true;
            this.txtObservacoes.Size = new System.Drawing.Size(554, 106);
            this.txtObservacoes.TabIndex = 83;
            this.txtObservacoes.TabStop = false;
            this.txtObservacoes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtObservacoes.UseAccent = false;
            this.txtObservacoes.UseSystemPasswordChar = false;
            // 
            // txtMotivo
            // 
            this.txtMotivo.AcceptsTab = true;
            this.txtMotivo.AnimateReadOnly = false;
            this.txtMotivo.AutoWordSelection = true;
            this.txtMotivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMotivo.Depth = 0;
            this.txtMotivo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMotivo.Hint = "Motivo da Transação";
            this.txtMotivo.LeadingIcon = null;
            this.txtMotivo.LeaveOnEnterKey = true;
            this.txtMotivo.Location = new System.Drawing.Point(172, 70);
            this.txtMotivo.MaxLength = 60;
            this.txtMotivo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMotivo.Multiline = false;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(554, 50);
            this.txtMotivo.TabIndex = 104;
            this.txtMotivo.Text = "";
            this.txtMotivo.TrailingIcon = null;
            this.txtMotivo.UseAccent = false;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.AcceptsTab = true;
            this.txtQuantidade.AnimateReadOnly = false;
            this.txtQuantidade.AutoWordSelection = true;
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantidade.Depth = 0;
            this.txtQuantidade.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuantidade.Hint = "Qtd";
            this.txtQuantidade.LeadingIcon = null;
            this.txtQuantidade.LeaveOnEnterKey = true;
            this.txtQuantidade.Location = new System.Drawing.Point(16, 70);
            this.txtQuantidade.MaxLength = 60;
            this.txtQuantidade.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQuantidade.Multiline = false;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(150, 50);
            this.txtQuantidade.TabIndex = 93;
            this.txtQuantidade.Text = "";
            this.txtQuantidade.TrailingIcon = null;
            this.txtQuantidade.UseAccent = false;
            // 
            // txtCustoTotal
            // 
            this.txtCustoTotal.AcceptsTab = true;
            this.txtCustoTotal.AnimateReadOnly = false;
            this.txtCustoTotal.AutoWordSelection = true;
            this.txtCustoTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustoTotal.Depth = 0;
            this.txtCustoTotal.Enabled = false;
            this.txtCustoTotal.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustoTotal.Hint = "Custo Total";
            this.txtCustoTotal.LeadingIcon = null;
            this.txtCustoTotal.LeaveOnEnterKey = true;
            this.txtCustoTotal.Location = new System.Drawing.Point(576, 182);
            this.txtCustoTotal.MaxLength = 60;
            this.txtCustoTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCustoTotal.Multiline = false;
            this.txtCustoTotal.Name = "txtCustoTotal";
            this.txtCustoTotal.Size = new System.Drawing.Size(150, 50);
            this.txtCustoTotal.TabIndex = 103;
            this.txtCustoTotal.Text = "";
            this.txtCustoTotal.TrailingIcon = null;
            this.txtCustoTotal.UseAccent = false;
            this.txtCustoTotal.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnSalvar.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnSalvar.CorTextoBotao = System.Drawing.Color.White;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(346, 16);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(43, 43);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.TamanhoBorda = 0;
            this.btnSalvar.TamanhoRaio = 10;
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.pnStatus2);
            this.panel1.Controls.Add(this.pcAtivo);
            this.panel1.Controls.Add(this.swItemAtivo);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnApagar);
            this.panel1.Controls.Add(this.pnStatus);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 74);
            this.panel1.TabIndex = 158;
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
            this.btnSearch.Location = new System.Drawing.Point(-272, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(43, 43);
            this.btnSearch.TabIndex = 101;
            this.btnSearch.TamanhoBorda = 0;
            this.btnSearch.TamanhoRaio = 10;
            this.btnSearch.UseVisualStyleBackColor = false;
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
            this.btnClose.Location = new System.Drawing.Point(716, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 35);
            this.btnClose.TabIndex = 159;
            this.btnClose.TamanhoBorda = 0;
            this.btnClose.TamanhoRaio = 17;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnApagar.Location = new System.Drawing.Point(-321, 11);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(43, 43);
            this.btnApagar.TabIndex = 14;
            this.btnApagar.TamanhoBorda = 0;
            this.btnApagar.TamanhoRaio = 10;
            this.btnApagar.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel4.Location = new System.Drawing.Point(759, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 20);
            this.panel4.TabIndex = 148;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 20);
            this.panel9.TabIndex = 154;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Location = new System.Drawing.Point(744, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 5);
            this.panel3.TabIndex = 147;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(20, 5);
            this.panel10.TabIndex = 153;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 140;
            this.pictureBox4.TabStop = false;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(63, 20);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(174, 29);
            this.lbTitulo.TabIndex = 139;
            this.lbTitulo.Text = "Movimentação";
            // 
            // CadastroMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(764, 351);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.White);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroMovimentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroMovimentacao";
            this.Load += new System.EventHandler(this.CadastroMovimentacao_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CadastroMovimentacao_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcAtivo)).EndInit();
            this.White.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.CustomPanel White;
        private MaterialSkin.Controls.MaterialTextBox txtData;
        private MaterialSkin.Controls.MaterialTextBox txtQuantidade;
        private MaterialSkin.Controls.MaterialTextBox txtItem;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtObservacoes;
        private MaterialSkin.Controls.MaterialComboBox cbTipoMovimento;
        private Componentes.CustomButton btnSalvar;
        private MaterialSkin.Controls.MaterialTextBox txtCustoTotal;
        private MaterialSkin.Controls.MaterialTextBox txtCustoUnitario;
        private MaterialSkin.Controls.MaterialTextBox txtMotivo;
        private Componentes.RoundedPanel pnStatus2;
        private MaterialSkin.Controls.MaterialSwitch swItemAtivo;
        private System.Windows.Forms.PictureBox pcAtivo;
        private Componentes.RoundedPanel pnStatus;
        private System.Windows.Forms.Panel panel1;
        private Componentes.CustomButton btnSearch;
        private Componentes.CustomButton btnClose;
        private Componentes.CustomButton btnApagar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbTitulo;
    }
}