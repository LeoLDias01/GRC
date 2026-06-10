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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnStatus2 = new GRC.Componentes.RoundedPanel();
            this.pnStatus = new GRC.Componentes.RoundedPanel();
            this.pnExterno = new GRC.Componentes.ModernBox();
            this.pnInterno = new GRC.Componentes.CustomPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtObservacoes = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtData = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMotivo = new MaterialSkin.Controls.MaterialTextBox();
            this.cbTipoMovimento = new MaterialSkin.Controls.MaterialComboBox();
            this.txtCustoUnitario = new MaterialSkin.Controls.MaterialTextBox();
            this.txtQuantidade = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCustoTotal = new MaterialSkin.Controls.MaterialTextBox();
            this.txtItem = new MaterialSkin.Controls.MaterialTextBox();
            this.pcAtivo = new System.Windows.Forms.PictureBox();
            this.btnEncerrarJanelas = new GRC.Componentes.CustomButton();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnMovimentar = new GRC.Componentes.CustomButton();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.swItemAtivo = new MaterialSkin.Controls.MaterialSwitch();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnExterno.SuspendLayout();
            this.pnInterno.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcAtivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.022845F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.97716F));
            this.tableLayoutPanel1.Controls.Add(this.pnStatus2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnStatus, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(612, 15);
            this.tableLayoutPanel1.TabIndex = 160;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CadastroMovimentacao_MouseDown);
            // 
            // pnStatus2
            // 
            this.pnStatus2.BackColor = System.Drawing.Color.Transparent;
            this.pnStatus2.Color1 = System.Drawing.Color.Aquamarine;
            this.pnStatus2.Color2 = System.Drawing.Color.DarkTurquoise;
            this.pnStatus2.CornerRadius = 10;
            this.pnStatus2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnStatus2.GradientAngle = 90F;
            this.pnStatus2.Location = new System.Drawing.Point(3, 3);
            this.pnStatus2.Name = "pnStatus2";
            this.pnStatus2.Size = new System.Drawing.Size(30, 9);
            this.pnStatus2.TabIndex = 54;
            // 
            // pnStatus
            // 
            this.pnStatus.BackColor = System.Drawing.Color.Transparent;
            this.pnStatus.Color1 = System.Drawing.Color.Aquamarine;
            this.pnStatus.Color2 = System.Drawing.Color.DarkTurquoise;
            this.pnStatus.CornerRadius = 10;
            this.pnStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnStatus.GradientAngle = 90F;
            this.pnStatus.Location = new System.Drawing.Point(39, 3);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(570, 9);
            this.pnStatus.TabIndex = 53;
            // 
            // pnExterno
            // 
            this.pnExterno.BackColor = System.Drawing.Color.Transparent;
            this.pnExterno.BorderColor = System.Drawing.Color.White;
            this.pnExterno.BorderRadius = 12;
            this.pnExterno.BorderSize = 1;
            this.pnExterno.Controls.Add(this.pnInterno);
            this.pnExterno.FillColor = System.Drawing.Color.White;
            this.pnExterno.Location = new System.Drawing.Point(0, -2);
            this.pnExterno.Name = "pnExterno";
            this.pnExterno.Padding = new System.Windows.Forms.Padding(13);
            this.pnExterno.ShadowAngle = 90;
            this.pnExterno.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnExterno.ShadowSize = 8;
            this.pnExterno.Size = new System.Drawing.Size(632, 517);
            this.pnExterno.TabIndex = 178;
            this.pnExterno.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CadastroMovimentacao_MouseDown);
            // 
            // pnInterno
            // 
            this.pnInterno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnInterno.BackColor = System.Drawing.Color.White;
            this.pnInterno.Controls.Add(this.groupBox2);
            this.pnInterno.Controls.Add(this.tableLayoutPanel1);
            this.pnInterno.Controls.Add(this.pcAtivo);
            this.pnInterno.Controls.Add(this.btnEncerrarJanelas);
            this.pnInterno.Controls.Add(this.label11);
            this.pnInterno.Controls.Add(this.pictureBox4);
            this.pnInterno.Controls.Add(this.btnMovimentar);
            this.pnInterno.Controls.Add(this.lbTitulo);
            this.pnInterno.Controls.Add(this.swItemAtivo);
            this.pnInterno.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.pnInterno.CorBotao = System.Drawing.Color.White;
            this.pnInterno.CorTextoBotao = System.Drawing.Color.White;
            this.pnInterno.ForeColor = System.Drawing.Color.White;
            this.pnInterno.Location = new System.Drawing.Point(11, 0);
            this.pnInterno.Name = "pnInterno";
            this.pnInterno.Size = new System.Drawing.Size(612, 501);
            this.pnInterno.TabIndex = 161;
            this.pnInterno.TamanhoBorda = 0;
            this.pnInterno.TamanhoRaio = 15;
            this.pnInterno.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CadastroMovimentacao_MouseDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtObservacoes);
            this.groupBox2.Controls.Add(this.txtData);
            this.groupBox2.Controls.Add(this.txtMotivo);
            this.groupBox2.Controls.Add(this.cbTipoMovimento);
            this.groupBox2.Controls.Add(this.txtCustoUnitario);
            this.groupBox2.Controls.Add(this.txtQuantidade);
            this.groupBox2.Controls.Add(this.txtCustoTotal);
            this.groupBox2.Controls.Add(this.txtItem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.groupBox2.Location = new System.Drawing.Point(5, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 371);
            this.groupBox2.TabIndex = 178;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da Movimentação";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.AnimateReadOnly = false;
            this.txtObservacoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtObservacoes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtObservacoes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObservacoes.Depth = 0;
            this.txtObservacoes.HideSelection = true;
            this.txtObservacoes.Hint = "Observações";
            this.txtObservacoes.Location = new System.Drawing.Point(6, 203);
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
            this.txtObservacoes.Size = new System.Drawing.Size(415, 146);
            this.txtObservacoes.TabIndex = 83;
            this.txtObservacoes.TabStop = false;
            this.txtObservacoes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtObservacoes.UseAccent = false;
            this.txtObservacoes.UseSystemPasswordChar = false;
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
            this.txtData.Location = new System.Drawing.Point(6, 35);
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
            this.txtMotivo.Location = new System.Drawing.Point(6, 91);
            this.txtMotivo.MaxLength = 60;
            this.txtMotivo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMotivo.Multiline = false;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(575, 50);
            this.txtMotivo.TabIndex = 104;
            this.txtMotivo.Text = "";
            this.txtMotivo.TrailingIcon = null;
            this.txtMotivo.UseAccent = false;
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
            this.cbTipoMovimento.Location = new System.Drawing.Point(162, 36);
            this.cbTipoMovimento.MaxDropDownItems = 4;
            this.cbTipoMovimento.MouseState = MaterialSkin.MouseState.OUT;
            this.cbTipoMovimento.Name = "cbTipoMovimento";
            this.cbTipoMovimento.Size = new System.Drawing.Size(419, 49);
            this.cbTipoMovimento.StartIndex = 0;
            this.cbTipoMovimento.TabIndex = 80;
            this.cbTipoMovimento.UseAccent = false;
            this.cbTipoMovimento.SelectedValueChanged += new System.EventHandler(this.cbTipoMovimento_SelectedValueChanged);
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
            this.txtCustoUnitario.Location = new System.Drawing.Point(433, 221);
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
            this.txtQuantidade.Location = new System.Drawing.Point(431, 147);
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
            this.txtCustoTotal.Location = new System.Drawing.Point(433, 299);
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
            // txtItem
            // 
            this.txtItem.AcceptsTab = true;
            this.txtItem.AnimateReadOnly = true;
            this.txtItem.AutoWordSelection = true;
            this.txtItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtItem.Depth = 0;
            this.txtItem.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtItem.Hint = "Item";
            this.txtItem.LeadingIcon = null;
            this.txtItem.LeaveOnEnterKey = true;
            this.txtItem.Location = new System.Drawing.Point(3, 147);
            this.txtItem.MaxLength = 60;
            this.txtItem.MouseState = MaterialSkin.MouseState.OUT;
            this.txtItem.Multiline = false;
            this.txtItem.Name = "txtItem";
            this.txtItem.ReadOnly = true;
            this.txtItem.Size = new System.Drawing.Size(418, 50);
            this.txtItem.TabIndex = 46;
            this.txtItem.Text = "";
            this.txtItem.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtItem.TrailingIcon")));
            this.txtItem.UseAccent = false;
            this.txtItem.TrailingIconClick += new System.EventHandler(this.txtItem_TrailingIconClick);
            this.txtItem.Click += new System.EventHandler(this.txtItem_TrailingIconClick);
            // 
            // pcAtivo
            // 
            this.pcAtivo.Image = ((System.Drawing.Image)(resources.GetObject("pcAtivo.Image")));
            this.pcAtivo.Location = new System.Drawing.Point(255, 38);
            this.pcAtivo.Name = "pcAtivo";
            this.pcAtivo.Size = new System.Drawing.Size(24, 26);
            this.pcAtivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcAtivo.TabIndex = 177;
            this.pcAtivo.TabStop = false;
            this.pcAtivo.Visible = false;
            this.pcAtivo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CadastroMovimentacao_MouseDown);
            // 
            // btnEncerrarJanelas
            // 
            this.btnEncerrarJanelas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncerrarJanelas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnEncerrarJanelas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEncerrarJanelas.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnEncerrarJanelas.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnEncerrarJanelas.CorTextoBotao = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.btnEncerrarJanelas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncerrarJanelas.FlatAppearance.BorderSize = 0;
            this.btnEncerrarJanelas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnEncerrarJanelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncerrarJanelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrarJanelas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.btnEncerrarJanelas.Image = ((System.Drawing.Image)(resources.GetObject("btnEncerrarJanelas.Image")));
            this.btnEncerrarJanelas.Location = new System.Drawing.Point(584, 26);
            this.btnEncerrarJanelas.Name = "btnEncerrarJanelas";
            this.btnEncerrarJanelas.Size = new System.Drawing.Size(18, 18);
            this.btnEncerrarJanelas.TabIndex = 163;
            this.btnEncerrarJanelas.TamanhoBorda = 0;
            this.btnEncerrarJanelas.TamanhoRaio = 5;
            this.btnEncerrarJanelas.UseVisualStyleBackColor = false;
            this.btnEncerrarJanelas.Click += new System.EventHandler(this.btnEncerrarJanelas_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(69, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 20);
            this.label11.TabIndex = 175;
            this.label11.Text = "Movimentação de Item";
            this.label11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CadastroMovimentacao_MouseDown);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(11, 38);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 52);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 174;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CadastroMovimentacao_MouseDown);
            // 
            // btnMovimentar
            // 
            this.btnMovimentar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnMovimentar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMovimentar.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnMovimentar.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnMovimentar.CorTextoBotao = System.Drawing.Color.White;
            this.btnMovimentar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovimentar.FlatAppearance.BorderSize = 0;
            this.btnMovimentar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnMovimentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovimentar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnMovimentar.ForeColor = System.Drawing.Color.White;
            this.btnMovimentar.Image = ((System.Drawing.Image)(resources.GetObject("btnMovimentar.Image")));
            this.btnMovimentar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovimentar.Location = new System.Drawing.Point(456, 63);
            this.btnMovimentar.Name = "btnMovimentar";
            this.btnMovimentar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnMovimentar.Size = new System.Drawing.Size(141, 37);
            this.btnMovimentar.TabIndex = 26;
            this.btnMovimentar.TamanhoBorda = 0;
            this.btnMovimentar.TamanhoRaio = 5;
            this.btnMovimentar.Text = "   Movimentar";
            this.btnMovimentar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMovimentar.UseVisualStyleBackColor = false;
            this.btnMovimentar.Click += new System.EventHandler(this.btnMovimentar_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.lbTitulo.Location = new System.Drawing.Point(68, 38);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(181, 29);
            this.lbTitulo.TabIndex = 173;
            this.lbTitulo.Text = "Movimentação";
            this.lbTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CadastroMovimentacao_MouseDown);
            // 
            // swItemAtivo
            // 
            this.swItemAtivo.AutoSize = true;
            this.swItemAtivo.BackColor = System.Drawing.Color.Transparent;
            this.swItemAtivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swItemAtivo.Depth = 0;
            this.swItemAtivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.swItemAtivo.ForeColor = System.Drawing.Color.White;
            this.swItemAtivo.Location = new System.Drawing.Point(238, 63);
            this.swItemAtivo.Margin = new System.Windows.Forms.Padding(0);
            this.swItemAtivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swItemAtivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.swItemAtivo.Name = "swItemAtivo";
            this.swItemAtivo.Ripple = true;
            this.swItemAtivo.Size = new System.Drawing.Size(58, 37);
            this.swItemAtivo.TabIndex = 25;
            this.swItemAtivo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.swItemAtivo.UseVisualStyleBackColor = false;
            this.swItemAtivo.CheckedChanged += new System.EventHandler(this.swItemAtivo_CheckedChanged);
            // 
            // CadastroMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(630, 517);
            this.Controls.Add(this.pnExterno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroMovimentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroMovimentacao";
            this.Load += new System.EventHandler(this.CadastroMovimentacao_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CadastroMovimentacao_MouseDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnExterno.ResumeLayout(false);
            this.pnInterno.ResumeLayout(false);
            this.pnInterno.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcAtivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtData;
        private MaterialSkin.Controls.MaterialTextBox txtQuantidade;
        private MaterialSkin.Controls.MaterialTextBox txtItem;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtObservacoes;
        private MaterialSkin.Controls.MaterialComboBox cbTipoMovimento;
        private MaterialSkin.Controls.MaterialTextBox txtCustoTotal;
        private MaterialSkin.Controls.MaterialTextBox txtCustoUnitario;
        private MaterialSkin.Controls.MaterialTextBox txtMotivo;
        private Componentes.RoundedPanel pnStatus2;
        private Componentes.RoundedPanel pnStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Componentes.CustomPanel pnInterno;
        private System.Windows.Forms.PictureBox pcAtivo;
        private Componentes.CustomButton btnEncerrarJanelas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Componentes.CustomButton btnMovimentar;
        private System.Windows.Forms.Label lbTitulo;
        private MaterialSkin.Controls.MaterialSwitch swItemAtivo;
        private Componentes.ModernBox pnExterno;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}