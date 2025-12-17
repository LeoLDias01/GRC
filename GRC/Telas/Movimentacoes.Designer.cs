namespace GRC.Telas
{
    partial class Movimentacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movimentacoes));
            this.dgvMov = new System.Windows.Forms.DataGridView();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoMovimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPanel2 = new GRC.Componentes.CustomPanel();
            this.cbxQtdRegistros = new System.Windows.Forms.ComboBox();
            this.lbRegistros = new System.Windows.Forms.Label();
            this.pnPesquisa = new GRC.Componentes.CustomPanel();
            this.tbnSearch = new GRC.Componentes.CustomButton();
            this.btnApagar = new GRC.Componentes.CustomButton();
            this.txtItem = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSelecaoItem = new GRC.Componentes.CustomButton();
            this.cbTipoMovimento = new MaterialSkin.Controls.MaterialComboBox();
            this.btnNovaMovimentacao = new GRC.Componentes.CustomButton();
            this.txtDataFinal = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDataInicial = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.pnStatus = new GRC.Componentes.RoundedPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMov)).BeginInit();
            this.customPanel2.SuspendLayout();
            this.pnPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMov
            // 
            this.dgvMov.AllowUserToAddRows = false;
            this.dgvMov.AllowUserToDeleteRows = false;
            this.dgvMov.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMov.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMov.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvMov.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMov.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvMov.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMov.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMov.ColumnHeadersHeight = 35;
            this.dgvMov.ColumnHeadersVisible = false;
            this.dgvMov.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colData,
            this.colId,
            this.colDescricao,
            this.colTipoMovimento,
            this.colMotivo});
            this.dgvMov.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMov.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMov.EnableHeadersVisualStyles = false;
            this.dgvMov.GridColor = System.Drawing.Color.Silver;
            this.dgvMov.Location = new System.Drawing.Point(12, 189);
            this.dgvMov.MultiSelect = false;
            this.dgvMov.Name = "dgvMov";
            this.dgvMov.ReadOnly = true;
            this.dgvMov.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMov.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvMov.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMov.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMov.Size = new System.Drawing.Size(1163, 485);
            this.dgvMov.TabIndex = 52;
            this.dgvMov.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMov_CellDoubleClick);
            this.dgvMov.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMov_CellValueChanged);
            // 
            // colData
            // 
            this.colData.FillWeight = 25.27785F;
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.FillWeight = 0.6504041F;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colDescricao
            // 
            this.colDescricao.FillWeight = 35.69515F;
            this.colDescricao.HeaderText = "Item";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            // 
            // colTipoMovimento
            // 
            this.colTipoMovimento.FillWeight = 16.20491F;
            this.colTipoMovimento.HeaderText = "Tipo de Movimento";
            this.colTipoMovimento.Name = "colTipoMovimento";
            this.colTipoMovimento.ReadOnly = true;
            // 
            // colMotivo
            // 
            this.colMotivo.FillWeight = 21.87452F;
            this.colMotivo.HeaderText = "Motivo";
            this.colMotivo.Name = "colMotivo";
            this.colMotivo.ReadOnly = true;
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
            this.customPanel2.Location = new System.Drawing.Point(12, 680);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(1163, 37);
            this.customPanel2.TabIndex = 53;
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
            this.cbxQtdRegistros.Location = new System.Drawing.Point(1100, 10);
            this.cbxQtdRegistros.Name = "cbxQtdRegistros";
            this.cbxQtdRegistros.Size = new System.Drawing.Size(59, 21);
            this.cbxQtdRegistros.TabIndex = 2;
            this.cbxQtdRegistros.Text = "10";
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
            this.pnPesquisa.Controls.Add(this.tbnSearch);
            this.pnPesquisa.Controls.Add(this.btnApagar);
            this.pnPesquisa.Controls.Add(this.txtItem);
            this.pnPesquisa.Controls.Add(this.btnSelecaoItem);
            this.pnPesquisa.Controls.Add(this.cbTipoMovimento);
            this.pnPesquisa.Controls.Add(this.btnNovaMovimentacao);
            this.pnPesquisa.Controls.Add(this.txtDataFinal);
            this.pnPesquisa.Controls.Add(this.txtDataInicial);
            this.pnPesquisa.Controls.Add(this.materialLabel2);
            this.pnPesquisa.CorBorda = System.Drawing.Color.Black;
            this.pnPesquisa.CorBotao = System.Drawing.Color.AliceBlue;
            this.pnPesquisa.CorTextoBotao = System.Drawing.Color.White;
            this.pnPesquisa.ForeColor = System.Drawing.Color.White;
            this.pnPesquisa.Location = new System.Drawing.Point(12, 15);
            this.pnPesquisa.Name = "pnPesquisa";
            this.pnPesquisa.Size = new System.Drawing.Size(1159, 135);
            this.pnPesquisa.TabIndex = 54;
            this.pnPesquisa.TamanhoBorda = 0;
            this.pnPesquisa.TamanhoRaio = 20;
            // 
            // tbnSearch
            // 
            this.tbnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.tbnSearch.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.tbnSearch.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.tbnSearch.CorTextoBotao = System.Drawing.Color.White;
            this.tbnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbnSearch.FlatAppearance.BorderSize = 0;
            this.tbnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbnSearch.ForeColor = System.Drawing.Color.White;
            this.tbnSearch.Image = ((System.Drawing.Image)(resources.GetObject("tbnSearch.Image")));
            this.tbnSearch.Location = new System.Drawing.Point(1107, 10);
            this.tbnSearch.Name = "tbnSearch";
            this.tbnSearch.Size = new System.Drawing.Size(43, 43);
            this.tbnSearch.TabIndex = 106;
            this.tbnSearch.TamanhoBorda = 0;
            this.tbnSearch.TamanhoRaio = 10;
            this.tbnSearch.UseVisualStyleBackColor = false;
            this.tbnSearch.Click += new System.EventHandler(this.tbnSearch_Click);
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
            this.btnApagar.Location = new System.Drawing.Point(1058, 10);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(43, 43);
            this.btnApagar.TabIndex = 105;
            this.btnApagar.TamanhoBorda = 0;
            this.btnApagar.TamanhoRaio = 10;
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click_1);
            // 
            // txtItem
            // 
            this.txtItem.AcceptsTab = true;
            this.txtItem.AnimateReadOnly = false;
            this.txtItem.AutoWordSelection = true;
            this.txtItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItem.Depth = 0;
            this.txtItem.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtItem.Hint = "Item";
            this.txtItem.LeadingIcon = null;
            this.txtItem.LeaveOnEnterKey = true;
            this.txtItem.Location = new System.Drawing.Point(572, 66);
            this.txtItem.MaxLength = 60;
            this.txtItem.MouseState = MaterialSkin.MouseState.OUT;
            this.txtItem.Multiline = false;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(525, 50);
            this.txtItem.TabIndex = 103;
            this.txtItem.Text = "";
            this.txtItem.TrailingIcon = null;
            this.txtItem.UseAccent = false;
            // 
            // btnSelecaoItem
            // 
            this.btnSelecaoItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnSelecaoItem.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnSelecaoItem.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnSelecaoItem.CorTextoBotao = System.Drawing.Color.White;
            this.btnSelecaoItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecaoItem.FlatAppearance.BorderSize = 0;
            this.btnSelecaoItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnSelecaoItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecaoItem.ForeColor = System.Drawing.Color.White;
            this.btnSelecaoItem.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecaoItem.Image")));
            this.btnSelecaoItem.Location = new System.Drawing.Point(1107, 67);
            this.btnSelecaoItem.Name = "btnSelecaoItem";
            this.btnSelecaoItem.Size = new System.Drawing.Size(39, 39);
            this.btnSelecaoItem.TabIndex = 104;
            this.btnSelecaoItem.TamanhoBorda = 0;
            this.btnSelecaoItem.TamanhoRaio = 16;
            this.btnSelecaoItem.UseVisualStyleBackColor = false;
            this.btnSelecaoItem.Click += new System.EventHandler(this.btnSelecaoItem_Click);
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
            this.cbTipoMovimento.Location = new System.Drawing.Point(335, 67);
            this.cbTipoMovimento.MaxDropDownItems = 4;
            this.cbTipoMovimento.MouseState = MaterialSkin.MouseState.OUT;
            this.cbTipoMovimento.Name = "cbTipoMovimento";
            this.cbTipoMovimento.Size = new System.Drawing.Size(231, 49);
            this.cbTipoMovimento.StartIndex = 0;
            this.cbTipoMovimento.TabIndex = 102;
            this.cbTipoMovimento.UseAccent = false;
            // 
            // btnNovaMovimentacao
            // 
            this.btnNovaMovimentacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnNovaMovimentacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovaMovimentacao.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnNovaMovimentacao.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnNovaMovimentacao.CorTextoBotao = System.Drawing.Color.White;
            this.btnNovaMovimentacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovaMovimentacao.FlatAppearance.BorderSize = 0;
            this.btnNovaMovimentacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNovaMovimentacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaMovimentacao.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnNovaMovimentacao.ForeColor = System.Drawing.Color.White;
            this.btnNovaMovimentacao.Image = ((System.Drawing.Image)(resources.GetObject("btnNovaMovimentacao.Image")));
            this.btnNovaMovimentacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovaMovimentacao.Location = new System.Drawing.Point(174, 16);
            this.btnNovaMovimentacao.Name = "btnNovaMovimentacao";
            this.btnNovaMovimentacao.Size = new System.Drawing.Size(185, 37);
            this.btnNovaMovimentacao.TabIndex = 101;
            this.btnNovaMovimentacao.TamanhoBorda = 0;
            this.btnNovaMovimentacao.TamanhoRaio = 5;
            this.btnNovaMovimentacao.Text = "   Nova Movimentação";
            this.btnNovaMovimentacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovaMovimentacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovaMovimentacao.UseVisualStyleBackColor = false;
            this.btnNovaMovimentacao.Click += new System.EventHandler(this.btnNovaMovimentacao_Click);
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.AcceptsTab = true;
            this.txtDataFinal.AnimateReadOnly = false;
            this.txtDataFinal.AutoWordSelection = true;
            this.txtDataFinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataFinal.Depth = 0;
            this.txtDataFinal.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDataFinal.Hint = "Data Final";
            this.txtDataFinal.LeadingIcon = null;
            this.txtDataFinal.LeaveOnEnterKey = true;
            this.txtDataFinal.Location = new System.Drawing.Point(174, 67);
            this.txtDataFinal.MaxLength = 60;
            this.txtDataFinal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDataFinal.Multiline = false;
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(155, 50);
            this.txtDataFinal.TabIndex = 97;
            this.txtDataFinal.Text = "";
            this.txtDataFinal.TrailingIcon = null;
            this.txtDataFinal.UseAccent = false;
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.AcceptsTab = true;
            this.txtDataInicial.AnimateReadOnly = false;
            this.txtDataInicial.AutoWordSelection = true;
            this.txtDataInicial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataInicial.Depth = 0;
            this.txtDataInicial.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDataInicial.Hint = "Data Inicial";
            this.txtDataInicial.LeadingIcon = null;
            this.txtDataInicial.LeaveOnEnterKey = true;
            this.txtDataInicial.Location = new System.Drawing.Point(13, 67);
            this.txtDataInicial.MaxLength = 60;
            this.txtDataInicial.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDataInicial.Multiline = false;
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(155, 50);
            this.txtDataInicial.TabIndex = 94;
            this.txtDataInicial.Text = "";
            this.txtDataInicial.TrailingIcon = null;
            this.txtDataInicial.UseAccent = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.SlateGray;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.ForeColor = System.Drawing.Color.Black;
            this.materialLabel2.Location = new System.Drawing.Point(18, 24);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(144, 24);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Movimentações";
            // 
            // pnStatus
            // 
            this.pnStatus.BackColor = System.Drawing.Color.Transparent;
            this.pnStatus.Color1 = System.Drawing.Color.Ivory;
            this.pnStatus.Color2 = System.Drawing.Color.Aqua;
            this.pnStatus.CornerRadius = 10;
            this.pnStatus.GradientAngle = 90F;
            this.pnStatus.Location = new System.Drawing.Point(16, 156);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(1155, 27);
            this.pnStatus.TabIndex = 23;
            // 
            // Movimentacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(1183, 729);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.pnPesquisa);
            this.Controls.Add(this.dgvMov);
            this.Controls.Add(this.pnStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Movimentacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentações";
            this.Load += new System.EventHandler(this.Movimentacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMov)).EndInit();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.pnPesquisa.ResumeLayout(false);
            this.pnPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.RoundedPanel pnStatus;
        private Componentes.CustomPanel customPanel2;
        private System.Windows.Forms.ComboBox cbxQtdRegistros;
        private System.Windows.Forms.Label lbRegistros;
        private Componentes.CustomPanel pnPesquisa;
        private MaterialSkin.Controls.MaterialTextBox txtDataInicial;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridView dgvMov;
        private MaterialSkin.Controls.MaterialTextBox txtDataFinal;
        private Componentes.CustomButton btnNovaMovimentacao;
        private MaterialSkin.Controls.MaterialComboBox cbTipoMovimento;
        private MaterialSkin.Controls.MaterialTextBox txtItem;
        private Componentes.CustomButton btnSelecaoItem;
        private Componentes.CustomButton tbnSearch;
        private Componentes.CustomButton btnApagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoMovimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMotivo;
    }
}