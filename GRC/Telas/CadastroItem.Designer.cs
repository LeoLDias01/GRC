namespace GRC.Telas
{
    partial class CadastroItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroItem));
            this.dgvItemComposicao = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdComposicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.swItemAtivo = new MaterialSkin.Controls.MaterialSwitch();
            this.pnStatus = new GRC.Componentes.RoundedPanel();
            this.chkItemComposto = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tbcItem = new MaterialSkin.Controls.MaterialTabControl();
            this.tbpDadosItem = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpbInfoVenda = new System.Windows.Forms.GroupBox();
            this.txtLucroTotal = new MaterialSkin.Controls.MaterialTextBox();
            this.txtLucroItem = new MaterialSkin.Controls.MaterialTextBox();
            this.txtValorVenda = new MaterialSkin.Controls.MaterialTextBox();
            this.txtObservacoes = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.lbAvisoBloqueio = new System.Windows.Forms.Label();
            this.btnAddFabricante = new GRC.Componentes.CustomButton();
            this.cbFabricante = new MaterialSkin.Controls.MaterialComboBox();
            this.cbUnidadeMedida = new MaterialSkin.Controls.MaterialComboBox();
            this.txtQtd = new MaterialSkin.Controls.MaterialTextBox();
            this.txtQtdMinima = new MaterialSkin.Controls.MaterialTextBox();
            this.txtGarantia = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAddFornecedor = new GRC.Componentes.CustomButton();
            this.btnAddCategoria = new GRC.Componentes.CustomButton();
            this.txtValidade = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCustoTotal = new MaterialSkin.Controls.MaterialTextBox();
            this.cbFornecedor = new MaterialSkin.Controls.MaterialComboBox();
            this.cbCategoria = new MaterialSkin.Controls.MaterialComboBox();
            this.txtCustoUnitario = new MaterialSkin.Controls.MaterialTextBox();
            this.tbpComposicao = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddComposicao = new GRC.Componentes.CustomButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStatusLeitor = new System.Windows.Forms.Label();
            this.txtId = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDescricao = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCodigoBarras = new MaterialSkin.Controls.MaterialTextBox();
            this.swItemVenda = new MaterialSkin.Controls.MaterialSwitch();
            this.label11 = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pnExterno = new GRC.Componentes.ModernBox();
            this.pnInterno = new GRC.Componentes.CustomPanel();
            this.pcAtivo = new System.Windows.Forms.PictureBox();
            this.pcFavorito = new GRC.Componentes.CustomPictureBox();
            this.btnExcluiImagem = new GRC.Componentes.CustomButton();
            this.btnEncerrarJanelas = new GRC.Componentes.CustomButton();
            this.pcbImagemItem = new GRC.Componentes.CustomPictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new GRC.Componentes.CustomButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemComposicao)).BeginInit();
            this.tbcItem.SuspendLayout();
            this.tbpDadosItem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbInfoVenda.SuspendLayout();
            this.tbpComposicao.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnExterno.SuspendLayout();
            this.pnInterno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcAtivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFavorito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagemItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItemComposicao
            // 
            this.dgvItemComposicao.AllowUserToAddRows = false;
            this.dgvItemComposicao.AllowUserToDeleteRows = false;
            this.dgvItemComposicao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemComposicao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.dgvItemComposicao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItemComposicao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvItemComposicao.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvItemComposicao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemComposicao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItemComposicao.ColumnHeadersHeight = 35;
            this.dgvItemComposicao.ColumnHeadersVisible = false;
            this.dgvItemComposicao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colIdComposicao,
            this.colDescricao,
            this.colPreco,
            this.colExcluir});
            this.dgvItemComposicao.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItemComposicao.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvItemComposicao.EnableHeadersVisualStyles = false;
            this.dgvItemComposicao.GridColor = System.Drawing.Color.Black;
            this.dgvItemComposicao.Location = new System.Drawing.Point(6, 55);
            this.dgvItemComposicao.MultiSelect = false;
            this.dgvItemComposicao.Name = "dgvItemComposicao";
            this.dgvItemComposicao.ReadOnly = true;
            this.dgvItemComposicao.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvItemComposicao.RowHeadersVisible = false;
            this.dgvItemComposicao.RowHeadersWidth = 62;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvItemComposicao.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvItemComposicao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemComposicao.Size = new System.Drawing.Size(928, 280);
            this.dgvItemComposicao.TabIndex = 44;
            this.dgvItemComposicao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemComposicao_CellContentClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.FillWeight = 1F;
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 8;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colIdComposicao
            // 
            this.colIdComposicao.DataPropertyName = "IdComposicao";
            this.colIdComposicao.HeaderText = "Id Composicao";
            this.colIdComposicao.Name = "colIdComposicao";
            this.colIdComposicao.ReadOnly = true;
            this.colIdComposicao.Visible = false;
            // 
            // colDescricao
            // 
            this.colDescricao.DataPropertyName = "Descricao";
            this.colDescricao.FillWeight = 250F;
            this.colDescricao.HeaderText = "Descricao";
            this.colDescricao.MinimumWidth = 8;
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            // 
            // colPreco
            // 
            this.colPreco.DataPropertyName = "Preco";
            this.colPreco.FillWeight = 230F;
            this.colPreco.HeaderText = "Valor";
            this.colPreco.MinimumWidth = 8;
            this.colPreco.Name = "colPreco";
            this.colPreco.ReadOnly = true;
            // 
            // colExcluir
            // 
            this.colExcluir.FillWeight = 45F;
            this.colExcluir.HeaderText = "";
            this.colExcluir.Image = global::GRC.Properties.Resources.remove;
            this.colExcluir.MinimumWidth = 8;
            this.colExcluir.Name = "colExcluir";
            this.colExcluir.ReadOnly = true;
            // 
            // swItemAtivo
            // 
            this.swItemAtivo.AutoSize = true;
            this.swItemAtivo.BackColor = System.Drawing.Color.Transparent;
            this.swItemAtivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swItemAtivo.Depth = 0;
            this.swItemAtivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.swItemAtivo.ForeColor = System.Drawing.Color.White;
            this.swItemAtivo.Location = new System.Drawing.Point(284, 9);
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
            // pnStatus
            // 
            this.pnStatus.BackColor = System.Drawing.Color.Transparent;
            this.pnStatus.Color1 = System.Drawing.Color.Lime;
            this.pnStatus.Color2 = System.Drawing.Color.DarkRed;
            this.pnStatus.CornerRadius = 8;
            this.pnStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnStatus.GradientAngle = 180F;
            this.pnStatus.Location = new System.Drawing.Point(0, 0);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(963, 8);
            this.pnStatus.TabIndex = 28;
            // 
            // chkItemComposto
            // 
            this.chkItemComposto.AutoSize = true;
            this.chkItemComposto.BackColor = System.Drawing.Color.Transparent;
            this.chkItemComposto.Depth = 0;
            this.chkItemComposto.Location = new System.Drawing.Point(6, 10);
            this.chkItemComposto.Margin = new System.Windows.Forms.Padding(0);
            this.chkItemComposto.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkItemComposto.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkItemComposto.Name = "chkItemComposto";
            this.chkItemComposto.ReadOnly = false;
            this.chkItemComposto.Ripple = true;
            this.chkItemComposto.Size = new System.Drawing.Size(35, 37);
            this.chkItemComposto.TabIndex = 23;
            this.chkItemComposto.UseVisualStyleBackColor = false;
            this.chkItemComposto.CheckedChanged += new System.EventHandler(this.chkItemComposto_CheckedChanged);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.tbcItem;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 186);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(963, 41);
            this.materialTabSelector1.TabIndex = 162;
            this.materialTabSelector1.TabIndicatorHeight = 3;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tbcItem
            // 
            this.tbcItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcItem.Controls.Add(this.tbpDadosItem);
            this.tbcItem.Controls.Add(this.tbpComposicao);
            this.tbcItem.Depth = 0;
            this.tbcItem.Location = new System.Drawing.Point(12, 233);
            this.tbcItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbcItem.Multiline = true;
            this.tbcItem.Name = "tbcItem";
            this.tbcItem.SelectedIndex = 0;
            this.tbcItem.ShowToolTips = true;
            this.tbcItem.Size = new System.Drawing.Size(948, 430);
            this.tbcItem.TabIndex = 163;
            // 
            // tbpDadosItem
            // 
            this.tbpDadosItem.BackColor = System.Drawing.Color.White;
            this.tbpDadosItem.Controls.Add(this.groupBox1);
            this.tbpDadosItem.Location = new System.Drawing.Point(4, 22);
            this.tbpDadosItem.Name = "tbpDadosItem";
            this.tbpDadosItem.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDadosItem.Size = new System.Drawing.Size(940, 404);
            this.tbpDadosItem.TabIndex = 0;
            this.tbpDadosItem.Text = "Dados do Item";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gpbInfoVenda);
            this.groupBox1.Controls.Add(this.txtObservacoes);
            this.groupBox1.Controls.Add(this.lbAvisoBloqueio);
            this.groupBox1.Controls.Add(this.btnAddFabricante);
            this.groupBox1.Controls.Add(this.cbFabricante);
            this.groupBox1.Controls.Add(this.cbUnidadeMedida);
            this.groupBox1.Controls.Add(this.txtQtd);
            this.groupBox1.Controls.Add(this.txtQtdMinima);
            this.groupBox1.Controls.Add(this.txtGarantia);
            this.groupBox1.Controls.Add(this.btnAddFornecedor);
            this.groupBox1.Controls.Add(this.btnAddCategoria);
            this.groupBox1.Controls.Add(this.txtValidade);
            this.groupBox1.Controls.Add(this.txtCustoTotal);
            this.groupBox1.Controls.Add(this.cbFornecedor);
            this.groupBox1.Controls.Add(this.cbCategoria);
            this.groupBox1.Controls.Add(this.txtCustoUnitario);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(929, 342);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Item";
            // 
            // gpbInfoVenda
            // 
            this.gpbInfoVenda.Controls.Add(this.txtLucroTotal);
            this.gpbInfoVenda.Controls.Add(this.txtLucroItem);
            this.gpbInfoVenda.Controls.Add(this.txtValorVenda);
            this.gpbInfoVenda.Enabled = false;
            this.gpbInfoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfoVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.gpbInfoVenda.Location = new System.Drawing.Point(642, 24);
            this.gpbInfoVenda.Name = "gpbInfoVenda";
            this.gpbInfoVenda.Size = new System.Drawing.Size(241, 221);
            this.gpbInfoVenda.TabIndex = 28;
            this.gpbInfoVenda.TabStop = false;
            this.gpbInfoVenda.Text = "Informações de Venda";
            // 
            // txtLucroTotal
            // 
            this.txtLucroTotal.AcceptsTab = true;
            this.txtLucroTotal.AnimateReadOnly = false;
            this.txtLucroTotal.AutoWordSelection = true;
            this.txtLucroTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLucroTotal.Depth = 0;
            this.txtLucroTotal.Enabled = false;
            this.txtLucroTotal.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLucroTotal.Hint = "Lucro Total";
            this.txtLucroTotal.LeadingIcon = null;
            this.txtLucroTotal.LeaveOnEnterKey = true;
            this.txtLucroTotal.Location = new System.Drawing.Point(12, 165);
            this.txtLucroTotal.MaxLength = 60;
            this.txtLucroTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLucroTotal.Multiline = false;
            this.txtLucroTotal.Name = "txtLucroTotal";
            this.txtLucroTotal.Size = new System.Drawing.Size(223, 50);
            this.txtLucroTotal.TabIndex = 22;
            this.txtLucroTotal.Text = "";
            this.txtLucroTotal.TrailingIcon = null;
            this.txtLucroTotal.UseAccent = false;
            // 
            // txtLucroItem
            // 
            this.txtLucroItem.AcceptsTab = true;
            this.txtLucroItem.AnimateReadOnly = false;
            this.txtLucroItem.AutoWordSelection = true;
            this.txtLucroItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLucroItem.Depth = 0;
            this.txtLucroItem.Enabled = false;
            this.txtLucroItem.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLucroItem.Hint = "Lucro p/ Produto";
            this.txtLucroItem.LeadingIcon = null;
            this.txtLucroItem.LeaveOnEnterKey = true;
            this.txtLucroItem.Location = new System.Drawing.Point(11, 93);
            this.txtLucroItem.MaxLength = 60;
            this.txtLucroItem.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLucroItem.Multiline = false;
            this.txtLucroItem.Name = "txtLucroItem";
            this.txtLucroItem.Size = new System.Drawing.Size(224, 50);
            this.txtLucroItem.TabIndex = 21;
            this.txtLucroItem.Text = "";
            this.txtLucroItem.TrailingIcon = null;
            this.txtLucroItem.UseAccent = false;
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.AcceptsTab = true;
            this.txtValorVenda.AnimateReadOnly = false;
            this.txtValorVenda.AutoWordSelection = true;
            this.txtValorVenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorVenda.Depth = 0;
            this.txtValorVenda.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtValorVenda.Hint = "Preço";
            this.txtValorVenda.LeadingIcon = null;
            this.txtValorVenda.LeaveOnEnterKey = true;
            this.txtValorVenda.Location = new System.Drawing.Point(11, 25);
            this.txtValorVenda.MaxLength = 60;
            this.txtValorVenda.MouseState = MaterialSkin.MouseState.OUT;
            this.txtValorVenda.Multiline = false;
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(224, 50);
            this.txtValorVenda.TabIndex = 20;
            this.txtValorVenda.Text = "";
            this.txtValorVenda.TrailingIcon = null;
            this.txtValorVenda.UseAccent = false;
            this.txtValorVenda.TextChanged += new System.EventHandler(this.txtValorVenda_TextChanged);
            this.txtValorVenda.Enter += new System.EventHandler(this.txtValorVenda_Enter);
            this.txtValorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVenda_KeyPress);
            this.txtValorVenda.Leave += new System.EventHandler(this.txtValorVenda_Leave);
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
            this.txtObservacoes.Location = new System.Drawing.Point(27, 252);
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
            this.txtObservacoes.Size = new System.Drawing.Size(856, 77);
            this.txtObservacoes.TabIndex = 15;
            this.txtObservacoes.TabStop = false;
            this.txtObservacoes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtObservacoes.UseAccent = false;
            this.txtObservacoes.UseSystemPasswordChar = false;
            // 
            // lbAvisoBloqueio
            // 
            this.lbAvisoBloqueio.AutoSize = true;
            this.lbAvisoBloqueio.BackColor = System.Drawing.Color.OrangeRed;
            this.lbAvisoBloqueio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbAvisoBloqueio.ForeColor = System.Drawing.Color.White;
            this.lbAvisoBloqueio.Location = new System.Drawing.Point(158, 5);
            this.lbAvisoBloqueio.Name = "lbAvisoBloqueio";
            this.lbAvisoBloqueio.Size = new System.Drawing.Size(355, 15);
            this.lbAvisoBloqueio.TabIndex = 28;
            this.lbAvisoBloqueio.Text = "O campo de \"Quantidade\" está bloqueado para edição";
            this.lbAvisoBloqueio.Visible = false;
            // 
            // btnAddFabricante
            // 
            this.btnAddFabricante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnAddFabricante.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnAddFabricante.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnAddFabricante.CorTextoBotao = System.Drawing.Color.White;
            this.btnAddFabricante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFabricante.FlatAppearance.BorderSize = 0;
            this.btnAddFabricante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.btnAddFabricante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFabricante.ForeColor = System.Drawing.Color.White;
            this.btnAddFabricante.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFabricante.Image")));
            this.btnAddFabricante.Location = new System.Drawing.Point(258, 126);
            this.btnAddFabricante.Name = "btnAddFabricante";
            this.btnAddFabricante.Size = new System.Drawing.Size(30, 30);
            this.btnAddFabricante.TabIndex = 8;
            this.btnAddFabricante.TamanhoBorda = 0;
            this.btnAddFabricante.TamanhoRaio = 10;
            this.btnAddFabricante.UseVisualStyleBackColor = false;
            this.btnAddFabricante.Click += new System.EventHandler(this.btnAddFabricante_Click);
            // 
            // cbFabricante
            // 
            this.cbFabricante.AutoResize = false;
            this.cbFabricante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbFabricante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFabricante.Depth = 0;
            this.cbFabricante.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbFabricante.DropDownHeight = 174;
            this.cbFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFabricante.DropDownWidth = 121;
            this.cbFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbFabricante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbFabricante.FormattingEnabled = true;
            this.cbFabricante.Hint = "Marca";
            this.cbFabricante.IntegralHeight = false;
            this.cbFabricante.ItemHeight = 43;
            this.cbFabricante.Location = new System.Drawing.Point(27, 117);
            this.cbFabricante.MaxDropDownItems = 4;
            this.cbFabricante.MouseState = MaterialSkin.MouseState.OUT;
            this.cbFabricante.Name = "cbFabricante";
            this.cbFabricante.Size = new System.Drawing.Size(225, 49);
            this.cbFabricante.StartIndex = 0;
            this.cbFabricante.TabIndex = 7;
            this.cbFabricante.UseAccent = false;
            // 
            // cbUnidadeMedida
            // 
            this.cbUnidadeMedida.AutoResize = false;
            this.cbUnidadeMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbUnidadeMedida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbUnidadeMedida.Depth = 0;
            this.cbUnidadeMedida.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbUnidadeMedida.DropDownHeight = 174;
            this.cbUnidadeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidadeMedida.DropDownWidth = 121;
            this.cbUnidadeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbUnidadeMedida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbUnidadeMedida.FormattingEnabled = true;
            this.cbUnidadeMedida.Hint = "Unidade";
            this.cbUnidadeMedida.IntegralHeight = false;
            this.cbUnidadeMedida.ItemHeight = 43;
            this.cbUnidadeMedida.Location = new System.Drawing.Point(326, 32);
            this.cbUnidadeMedida.MaxDropDownItems = 4;
            this.cbUnidadeMedida.MouseState = MaterialSkin.MouseState.OUT;
            this.cbUnidadeMedida.Name = "cbUnidadeMedida";
            this.cbUnidadeMedida.Size = new System.Drawing.Size(276, 49);
            this.cbUnidadeMedida.StartIndex = 0;
            this.cbUnidadeMedida.TabIndex = 5;
            this.cbUnidadeMedida.UseAccent = false;
            // 
            // txtQtd
            // 
            this.txtQtd.AcceptsTab = true;
            this.txtQtd.AnimateReadOnly = false;
            this.txtQtd.AutoWordSelection = true;
            this.txtQtd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQtd.Depth = 0;
            this.txtQtd.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtQtd.Hint = "Quantidade";
            this.txtQtd.LeadingIcon = null;
            this.txtQtd.LeaveOnEnterKey = true;
            this.txtQtd.Location = new System.Drawing.Point(467, 86);
            this.txtQtd.MaxLength = 60;
            this.txtQtd.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQtd.Multiline = false;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(135, 50);
            this.txtQtd.TabIndex = 10;
            this.txtQtd.Text = "";
            this.txtQtd.TrailingIcon = null;
            this.txtQtd.UseAccent = false;
            this.txtQtd.TextChanged += new System.EventHandler(this.txtQtd_TextChanged);
            this.txtQtd.Enter += new System.EventHandler(this.txtQtd_Enter);
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtd_KeyPress);
            this.txtQtd.Leave += new System.EventHandler(this.txtQtd_Leave);
            // 
            // txtQtdMinima
            // 
            this.txtQtdMinima.AcceptsTab = true;
            this.txtQtdMinima.AnimateReadOnly = false;
            this.txtQtdMinima.AutoWordSelection = true;
            this.txtQtdMinima.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQtdMinima.Depth = 0;
            this.txtQtdMinima.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtQtdMinima.Hint = "Qtd Mínima";
            this.txtQtdMinima.LeadingIcon = null;
            this.txtQtdMinima.LeaveOnEnterKey = true;
            this.txtQtdMinima.Location = new System.Drawing.Point(326, 86);
            this.txtQtdMinima.MaxLength = 60;
            this.txtQtdMinima.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQtdMinima.Multiline = false;
            this.txtQtdMinima.Name = "txtQtdMinima";
            this.txtQtdMinima.Size = new System.Drawing.Size(135, 50);
            this.txtQtdMinima.TabIndex = 9;
            this.txtQtdMinima.Text = "";
            this.txtQtdMinima.TrailingIcon = null;
            this.txtQtdMinima.UseAccent = false;
            this.txtQtdMinima.Enter += new System.EventHandler(this.txtQtdMinima_Enter);
            this.txtQtdMinima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdMinima_KeyPress);
            this.txtQtdMinima.Leave += new System.EventHandler(this.txtQtdMinima_Leave);
            // 
            // txtGarantia
            // 
            this.txtGarantia.AcceptsTab = true;
            this.txtGarantia.AnimateReadOnly = false;
            this.txtGarantia.AutoWordSelection = true;
            this.txtGarantia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGarantia.Depth = 0;
            this.txtGarantia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGarantia.Hint = "Garantia";
            this.txtGarantia.LeadingIcon = null;
            this.txtGarantia.LeaveOnEnterKey = true;
            this.txtGarantia.Location = new System.Drawing.Point(467, 195);
            this.txtGarantia.MaxLength = 60;
            this.txtGarantia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGarantia.Multiline = false;
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Size = new System.Drawing.Size(135, 50);
            this.txtGarantia.TabIndex = 17;
            this.txtGarantia.Text = "";
            this.txtGarantia.TrailingIcon = null;
            this.txtGarantia.UseAccent = false;
            this.txtGarantia.TextChanged += new System.EventHandler(this.txtGarantia_TextChanged);
            this.txtGarantia.Enter += new System.EventHandler(this.txtGarantia_Enter);
            this.txtGarantia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGarantia_KeyPress);
            this.txtGarantia.Leave += new System.EventHandler(this.txtGarantia_Leave);
            // 
            // btnAddFornecedor
            // 
            this.btnAddFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnAddFornecedor.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnAddFornecedor.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnAddFornecedor.CorTextoBotao = System.Drawing.Color.White;
            this.btnAddFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFornecedor.FlatAppearance.BorderSize = 0;
            this.btnAddFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.btnAddFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnAddFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFornecedor.Image")));
            this.btnAddFornecedor.Location = new System.Drawing.Point(258, 195);
            this.btnAddFornecedor.Name = "btnAddFornecedor";
            this.btnAddFornecedor.Size = new System.Drawing.Size(30, 30);
            this.btnAddFornecedor.TabIndex = 12;
            this.btnAddFornecedor.TamanhoBorda = 0;
            this.btnAddFornecedor.TamanhoRaio = 10;
            this.btnAddFornecedor.UseVisualStyleBackColor = false;
            this.btnAddFornecedor.Click += new System.EventHandler(this.btnAddFornecedor_Click);
            // 
            // btnAddCategoria
            // 
            this.btnAddCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnAddCategoria.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnAddCategoria.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnAddCategoria.CorTextoBotao = System.Drawing.Color.White;
            this.btnAddCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategoria.FlatAppearance.BorderSize = 0;
            this.btnAddCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.btnAddCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategoria.ForeColor = System.Drawing.Color.White;
            this.btnAddCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategoria.Image")));
            this.btnAddCategoria.Location = new System.Drawing.Point(258, 55);
            this.btnAddCategoria.Name = "btnAddCategoria";
            this.btnAddCategoria.Size = new System.Drawing.Size(30, 30);
            this.btnAddCategoria.TabIndex = 4;
            this.btnAddCategoria.TamanhoBorda = 0;
            this.btnAddCategoria.TamanhoRaio = 10;
            this.btnAddCategoria.Text = " ";
            this.btnAddCategoria.UseVisualStyleBackColor = false;
            this.btnAddCategoria.Click += new System.EventHandler(this.btnAddCategoria_Click);
            // 
            // txtValidade
            // 
            this.txtValidade.AcceptsTab = true;
            this.txtValidade.AnimateReadOnly = false;
            this.txtValidade.AutoWordSelection = true;
            this.txtValidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValidade.Depth = 0;
            this.txtValidade.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtValidade.Hint = "Validade";
            this.txtValidade.LeadingIcon = null;
            this.txtValidade.LeaveOnEnterKey = true;
            this.txtValidade.Location = new System.Drawing.Point(326, 196);
            this.txtValidade.MaxLength = 60;
            this.txtValidade.MouseState = MaterialSkin.MouseState.OUT;
            this.txtValidade.Multiline = false;
            this.txtValidade.Name = "txtValidade";
            this.txtValidade.Size = new System.Drawing.Size(135, 50);
            this.txtValidade.TabIndex = 16;
            this.txtValidade.Text = "";
            this.txtValidade.TrailingIcon = null;
            this.txtValidade.UseAccent = false;
            this.txtValidade.TextChanged += new System.EventHandler(this.txtValidade_TextChanged);
            this.txtValidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidade_KeyPress);
            this.txtValidade.Leave += new System.EventHandler(this.txtValidade_Leave);
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
            this.txtCustoTotal.Location = new System.Drawing.Point(467, 143);
            this.txtCustoTotal.MaxLength = 60;
            this.txtCustoTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCustoTotal.Multiline = false;
            this.txtCustoTotal.Name = "txtCustoTotal";
            this.txtCustoTotal.Size = new System.Drawing.Size(135, 50);
            this.txtCustoTotal.TabIndex = 14;
            this.txtCustoTotal.Text = "";
            this.txtCustoTotal.TrailingIcon = null;
            this.txtCustoTotal.UseAccent = false;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.AutoResize = false;
            this.cbFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFornecedor.Depth = 0;
            this.cbFornecedor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbFornecedor.DropDownHeight = 174;
            this.cbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFornecedor.DropDownWidth = 121;
            this.cbFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Hint = "Fornecedor";
            this.cbFornecedor.IntegralHeight = false;
            this.cbFornecedor.ItemHeight = 43;
            this.cbFornecedor.Location = new System.Drawing.Point(27, 187);
            this.cbFornecedor.MaxDropDownItems = 4;
            this.cbFornecedor.MouseState = MaterialSkin.MouseState.OUT;
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(225, 49);
            this.cbFornecedor.StartIndex = 0;
            this.cbFornecedor.TabIndex = 11;
            this.cbFornecedor.UseAccent = false;
            // 
            // cbCategoria
            // 
            this.cbCategoria.AutoResize = false;
            this.cbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCategoria.Depth = 0;
            this.cbCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbCategoria.DropDownHeight = 174;
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.DropDownWidth = 121;
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Hint = "Categoria";
            this.cbCategoria.IntegralHeight = false;
            this.cbCategoria.ItemHeight = 43;
            this.cbCategoria.Location = new System.Drawing.Point(27, 47);
            this.cbCategoria.MaxDropDownItems = 4;
            this.cbCategoria.MouseState = MaterialSkin.MouseState.OUT;
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(225, 49);
            this.cbCategoria.StartIndex = 0;
            this.cbCategoria.TabIndex = 3;
            this.cbCategoria.UseAccent = false;
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
            this.txtCustoUnitario.Location = new System.Drawing.Point(325, 143);
            this.txtCustoUnitario.MaxLength = 60;
            this.txtCustoUnitario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCustoUnitario.Multiline = false;
            this.txtCustoUnitario.Name = "txtCustoUnitario";
            this.txtCustoUnitario.Size = new System.Drawing.Size(135, 50);
            this.txtCustoUnitario.TabIndex = 13;
            this.txtCustoUnitario.Text = "";
            this.txtCustoUnitario.TrailingIcon = null;
            this.txtCustoUnitario.UseAccent = false;
            this.txtCustoUnitario.TextChanged += new System.EventHandler(this.txtCustoUnitario_TextChanged);
            this.txtCustoUnitario.Enter += new System.EventHandler(this.txtCustoUnitario_Enter);
            this.txtCustoUnitario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustoUnitario_KeyDown);
            this.txtCustoUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustoUnitario_KeyPress);
            this.txtCustoUnitario.Leave += new System.EventHandler(this.txtCustoUnitario_Leave);
            // 
            // tbpComposicao
            // 
            this.tbpComposicao.BackColor = System.Drawing.Color.White;
            this.tbpComposicao.Controls.Add(this.label4);
            this.tbpComposicao.Controls.Add(this.chkItemComposto);
            this.tbpComposicao.Controls.Add(this.dgvItemComposicao);
            this.tbpComposicao.Controls.Add(this.btnAddComposicao);
            this.tbpComposicao.Location = new System.Drawing.Point(4, 22);
            this.tbpComposicao.Name = "tbpComposicao";
            this.tbpComposicao.Padding = new System.Windows.Forms.Padding(3);
            this.tbpComposicao.Size = new System.Drawing.Size(940, 404);
            this.tbpComposicao.TabIndex = 1;
            this.tbpComposicao.Text = "Composição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.label4.Location = new System.Drawing.Point(44, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 24);
            this.label4.TabIndex = 45;
            this.label4.Text = "Composição de Item";
            // 
            // btnAddComposicao
            // 
            this.btnAddComposicao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddComposicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnAddComposicao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddComposicao.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnAddComposicao.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnAddComposicao.CorTextoBotao = System.Drawing.Color.White;
            this.btnAddComposicao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddComposicao.FlatAppearance.BorderSize = 0;
            this.btnAddComposicao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddComposicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddComposicao.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddComposicao.ForeColor = System.Drawing.Color.White;
            this.btnAddComposicao.Image = ((System.Drawing.Image)(resources.GetObject("btnAddComposicao.Image")));
            this.btnAddComposicao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddComposicao.Location = new System.Drawing.Point(881, 6);
            this.btnAddComposicao.Name = "btnAddComposicao";
            this.btnAddComposicao.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAddComposicao.Size = new System.Drawing.Size(53, 43);
            this.btnAddComposicao.TabIndex = 24;
            this.btnAddComposicao.TamanhoBorda = 0;
            this.btnAddComposicao.TamanhoRaio = 10;
            this.btnAddComposicao.UseVisualStyleBackColor = false;
            this.btnAddComposicao.Click += new System.EventHandler(this.btnAddComposicao_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStatusLeitor);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.txtDescricao);
            this.groupBox2.Controls.Add(this.txtCodigoBarras);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.groupBox2.Location = new System.Drawing.Point(123, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(833, 100);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item";
            // 
            // lblStatusLeitor
            // 
            this.lblStatusLeitor.AutoSize = true;
            this.lblStatusLeitor.BackColor = System.Drawing.Color.Green;
            this.lblStatusLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblStatusLeitor.ForeColor = System.Drawing.Color.White;
            this.lblStatusLeitor.Location = new System.Drawing.Point(111, 19);
            this.lblStatusLeitor.Name = "lblStatusLeitor";
            this.lblStatusLeitor.Size = new System.Drawing.Size(19, 13);
            this.lblStatusLeitor.TabIndex = 29;
            this.lblStatusLeitor.Text = "...";
            // 
            // txtId
            // 
            this.txtId.AcceptsTab = true;
            this.txtId.AnimateReadOnly = false;
            this.txtId.AutoWordSelection = true;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Depth = 0;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtId.Hint = "ID";
            this.txtId.LeadingIcon = null;
            this.txtId.LeaveOnEnterKey = true;
            this.txtId.Location = new System.Drawing.Point(6, 35);
            this.txtId.MaxLength = 60;
            this.txtId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(98, 50);
            this.txtId.TabIndex = 27;
            this.txtId.Text = "";
            this.txtId.TrailingIcon = null;
            this.txtId.UseAccent = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.AcceptsTab = true;
            this.txtDescricao.AnimateReadOnly = false;
            this.txtDescricao.AutoWordSelection = true;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Depth = 0;
            this.txtDescricao.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescricao.Hint = "Nome do Item";
            this.txtDescricao.LeadingIcon = null;
            this.txtDescricao.LeaveOnEnterKey = true;
            this.txtDescricao.Location = new System.Drawing.Point(381, 35);
            this.txtDescricao.MaxLength = 60;
            this.txtDescricao.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescricao.Multiline = false;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(446, 50);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.Text = "";
            this.txtDescricao.TrailingIcon = null;
            this.txtDescricao.UseAccent = false;
            this.txtDescricao.Leave += new System.EventHandler(this.txtDescricao_Leave);
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.AcceptsTab = true;
            this.txtCodigoBarras.AnimateReadOnly = false;
            this.txtCodigoBarras.AutoWordSelection = true;
            this.txtCodigoBarras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoBarras.Depth = 0;
            this.txtCodigoBarras.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigoBarras.Hint = "Código de Barras";
            this.txtCodigoBarras.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtCodigoBarras.LeadingIcon")));
            this.txtCodigoBarras.LeaveOnEnterKey = true;
            this.txtCodigoBarras.Location = new System.Drawing.Point(110, 35);
            this.txtCodigoBarras.MaxLength = 60;
            this.txtCodigoBarras.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigoBarras.Multiline = false;
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(266, 50);
            this.txtCodigoBarras.TabIndex = 1;
            this.txtCodigoBarras.Text = "";
            this.txtCodigoBarras.TrailingIcon = null;
            this.txtCodigoBarras.UseAccent = false;
            // 
            // swItemVenda
            // 
            this.swItemVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.swItemVenda.AutoSize = true;
            this.swItemVenda.BackColor = System.Drawing.Color.Transparent;
            this.swItemVenda.Depth = 0;
            this.swItemVenda.Location = new System.Drawing.Point(776, 72);
            this.swItemVenda.Margin = new System.Windows.Forms.Padding(0);
            this.swItemVenda.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swItemVenda.MouseState = MaterialSkin.MouseState.HOVER;
            this.swItemVenda.Name = "swItemVenda";
            this.swItemVenda.Ripple = true;
            this.swItemVenda.Size = new System.Drawing.Size(174, 37);
            this.swItemVenda.TabIndex = 18;
            this.swItemVenda.Text = "Item para Venda";
            this.swItemVenda.UseVisualStyleBackColor = false;
            this.swItemVenda.CheckedChanged += new System.EventHandler(this.swItemVenda_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(70, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 20);
            this.label11.TabIndex = 175;
            this.label11.Text = "Informe os dados do item";
            this.label11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CadastroItem_MouseDown);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.lbTitulo.Location = new System.Drawing.Point(69, 12);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(212, 29);
            this.lbTitulo.TabIndex = 173;
            this.lbTitulo.Text = "Cadastro de Item";
            this.lbTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CadastroItem_MouseDown);
            // 
            // pnExterno
            // 
            this.pnExterno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnExterno.BackColor = System.Drawing.Color.Transparent;
            this.pnExterno.BorderColor = System.Drawing.Color.White;
            this.pnExterno.BorderRadius = 12;
            this.pnExterno.BorderSize = 1;
            this.pnExterno.Controls.Add(this.pnInterno);
            this.pnExterno.FillColor = System.Drawing.Color.White;
            this.pnExterno.Location = new System.Drawing.Point(-7, 12);
            this.pnExterno.Name = "pnExterno";
            this.pnExterno.Padding = new System.Windows.Forms.Padding(13);
            this.pnExterno.ShadowAngle = 90;
            this.pnExterno.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnExterno.ShadowSize = 8;
            this.pnExterno.Size = new System.Drawing.Size(979, 623);
            this.pnExterno.TabIndex = 177;
            this.pnExterno.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CadastroItem_MouseDown);
            // 
            // pnInterno
            // 
            this.pnInterno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnInterno.BackColor = System.Drawing.Color.White;
            this.pnInterno.Controls.Add(this.pcAtivo);
            this.pnInterno.Controls.Add(this.swItemVenda);
            this.pnInterno.Controls.Add(this.pcFavorito);
            this.pnInterno.Controls.Add(this.btnExcluiImagem);
            this.pnInterno.Controls.Add(this.groupBox2);
            this.pnInterno.Controls.Add(this.btnEncerrarJanelas);
            this.pnInterno.Controls.Add(this.tbcItem);
            this.pnInterno.Controls.Add(this.label11);
            this.pnInterno.Controls.Add(this.pcbImagemItem);
            this.pnInterno.Controls.Add(this.materialTabSelector1);
            this.pnInterno.Controls.Add(this.pictureBox4);
            this.pnInterno.Controls.Add(this.btnSalvar);
            this.pnInterno.Controls.Add(this.lbTitulo);
            this.pnInterno.Controls.Add(this.swItemAtivo);
            this.pnInterno.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.pnInterno.CorBotao = System.Drawing.Color.White;
            this.pnInterno.CorTextoBotao = System.Drawing.Color.White;
            this.pnInterno.ForeColor = System.Drawing.Color.White;
            this.pnInterno.Location = new System.Drawing.Point(7, 4);
            this.pnInterno.Name = "pnInterno";
            this.pnInterno.Size = new System.Drawing.Size(963, 603);
            this.pnInterno.TabIndex = 0;
            this.pnInterno.TamanhoBorda = 0;
            this.pnInterno.TamanhoRaio = 15;
            this.pnInterno.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CadastroItem_MouseDown);
            // 
            // pcAtivo
            // 
            this.pcAtivo.Image = ((System.Drawing.Image)(resources.GetObject("pcAtivo.Image")));
            this.pcAtivo.Location = new System.Drawing.Point(257, 38);
            this.pcAtivo.Name = "pcAtivo";
            this.pcAtivo.Size = new System.Drawing.Size(24, 26);
            this.pcAtivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcAtivo.TabIndex = 177;
            this.pcAtivo.TabStop = false;
            this.pcAtivo.Visible = false;
            // 
            // pcFavorito
            // 
            this.pcFavorito.BackColor = System.Drawing.Color.Transparent;
            this.pcFavorito.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.pcFavorito.CorBotao = System.Drawing.Color.Transparent;
            this.pcFavorito.CorTextoBotao = System.Drawing.Color.White;
            this.pcFavorito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcFavorito.ForeColor = System.Drawing.Color.White;
            this.pcFavorito.Image = global::GRC.Properties.Resources.star;
            this.pcFavorito.Location = new System.Drawing.Point(183, 73);
            this.pcFavorito.Name = "pcFavorito";
            this.pcFavorito.Size = new System.Drawing.Size(26, 26);
            this.pcFavorito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcFavorito.TabIndex = 176;
            this.pcFavorito.TabStop = false;
            this.pcFavorito.TamanhoBorda = 0;
            this.pcFavorito.TamanhoRaio = 0;
            this.pcFavorito.Click += new System.EventHandler(this.pcFavorito_Click);
            // 
            // btnExcluiImagem
            // 
            this.btnExcluiImagem.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluiImagem.CorBorda = System.Drawing.Color.Transparent;
            this.btnExcluiImagem.CorBotao = System.Drawing.Color.Transparent;
            this.btnExcluiImagem.CorTextoBotao = System.Drawing.Color.White;
            this.btnExcluiImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluiImagem.FlatAppearance.BorderSize = 0;
            this.btnExcluiImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluiImagem.ForeColor = System.Drawing.Color.White;
            this.btnExcluiImagem.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluiImagem.Image")));
            this.btnExcluiImagem.Location = new System.Drawing.Point(92, 79);
            this.btnExcluiImagem.Name = "btnExcluiImagem";
            this.btnExcluiImagem.Size = new System.Drawing.Size(20, 20);
            this.btnExcluiImagem.TabIndex = 19;
            this.btnExcluiImagem.TamanhoBorda = 0;
            this.btnExcluiImagem.TamanhoRaio = 5;
            this.btnExcluiImagem.UseVisualStyleBackColor = false;
            this.btnExcluiImagem.Visible = false;
            this.btnExcluiImagem.Click += new System.EventHandler(this.btnExcluiImagem_Click);
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
            this.btnEncerrarJanelas.Location = new System.Drawing.Point(933, 0);
            this.btnEncerrarJanelas.Name = "btnEncerrarJanelas";
            this.btnEncerrarJanelas.Size = new System.Drawing.Size(18, 18);
            this.btnEncerrarJanelas.TabIndex = 163;
            this.btnEncerrarJanelas.TamanhoBorda = 0;
            this.btnEncerrarJanelas.TamanhoRaio = 5;
            this.btnEncerrarJanelas.UseVisualStyleBackColor = false;
            this.btnEncerrarJanelas.Click += new System.EventHandler(this.btnEncerrarJanelas_Click);
            // 
            // pcbImagemItem
            // 
            this.pcbImagemItem.BackColor = System.Drawing.Color.White;
            this.pcbImagemItem.CorBorda = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.pcbImagemItem.CorBotao = System.Drawing.Color.White;
            this.pcbImagemItem.CorTextoBotao = System.Drawing.Color.White;
            this.pcbImagemItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbImagemItem.ForeColor = System.Drawing.Color.White;
            this.pcbImagemItem.Image = global::GRC.Properties.Resources.no_image;
            this.pcbImagemItem.Location = new System.Drawing.Point(12, 79);
            this.pcbImagemItem.Name = "pcbImagemItem";
            this.pcbImagemItem.Size = new System.Drawing.Size(100, 100);
            this.pcbImagemItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImagemItem.TabIndex = 37;
            this.pcbImagemItem.TabStop = false;
            this.pcbImagemItem.TamanhoBorda = 1;
            this.pcbImagemItem.TamanhoRaio = 5;
            this.pcbImagemItem.Click += new System.EventHandler(this.pcbImagemItem_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 52);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 174;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CadastroItem_MouseDown);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
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
            this.btnSalvar.Location = new System.Drawing.Point(345, 9);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSalvar.Size = new System.Drawing.Size(127, 37);
            this.btnSalvar.TabIndex = 26;
            this.btnSalvar.TamanhoBorda = 0;
            this.btnSalvar.TamanhoRaio = 5;
            this.btnSalvar.Text = "   Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 45F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::GRC.Properties.Resources.remove;
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 22;
            // 
            // CadastroItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(963, 636);
            this.Controls.Add(this.pnExterno);
            this.Controls.Add(this.pnStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CadastroItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroItem";
            this.Load += new System.EventHandler(this.CadastroItem_Load);
            this.Leave += new System.EventHandler(this.CadastroItem_Leave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CadastroItem_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemComposicao)).EndInit();
            this.tbcItem.ResumeLayout(false);
            this.tbpDadosItem.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbInfoVenda.ResumeLayout(false);
            this.tbpComposicao.ResumeLayout(false);
            this.tbpComposicao.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnExterno.ResumeLayout(false);
            this.pnInterno.ResumeLayout(false);
            this.pnInterno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcAtivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFavorito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagemItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtCustoUnitario;
        private MaterialSkin.Controls.MaterialTextBox txtQtd;
        private MaterialSkin.Controls.MaterialTextBox txtDescricao;
        private MaterialSkin.Controls.MaterialTextBox txtValorVenda;
        private MaterialSkin.Controls.MaterialTextBox txtCodigoBarras;
        private MaterialSkin.Controls.MaterialTextBox txtQtdMinima;
        private MaterialSkin.Controls.MaterialTextBox txtId;
        private MaterialSkin.Controls.MaterialComboBox cbCategoria;
        private System.Windows.Forms.GroupBox gpbInfoVenda;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialComboBox cbFornecedor;
        private MaterialSkin.Controls.MaterialTextBox txtCustoTotal;
        private MaterialSkin.Controls.MaterialTextBox txtValidade;
        private Componentes.CustomButton btnAddFornecedor;
        private Componentes.CustomButton btnAddCategoria;
        private MaterialSkin.Controls.MaterialSwitch swItemAtivo;
        private MaterialSkin.Controls.MaterialSwitch swItemVenda;
        private Componentes.CustomButton btnExcluiImagem;
        private Componentes.CustomPictureBox pcbImagemItem;
        private MaterialSkin.Controls.MaterialTextBox txtGarantia;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtObservacoes;
        private Componentes.CustomButton btnAddFabricante;
        private MaterialSkin.Controls.MaterialComboBox cbFabricante;
        private MaterialSkin.Controls.MaterialComboBox cbUnidadeMedida;
        private MaterialSkin.Controls.MaterialTextBox txtLucroItem;
        private System.Windows.Forms.DataGridView dgvItemComposicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdComposicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPreco;
        private System.Windows.Forms.DataGridViewImageColumn colExcluir;
        private MaterialSkin.Controls.MaterialTextBox txtLucroTotal;
        private MaterialSkin.Controls.MaterialCheckbox chkItemComposto;
        private Componentes.CustomButton btnSalvar;
        private Componentes.CustomButton btnAddComposicao;
        private System.Windows.Forms.GroupBox groupBox2;
        private Componentes.RoundedPanel pnStatus;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label lbAvisoBloqueio;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl tbcItem;
        private System.Windows.Forms.TabPage tbpDadosItem;
        private System.Windows.Forms.TabPage tbpComposicao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatusLeitor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbTitulo;
        private Componentes.CustomPictureBox pcFavorito;
        private Componentes.ModernBox pnExterno;
        private Componentes.CustomPanel pnInterno;
        private Componentes.CustomButton btnEncerrarJanelas;
        private System.Windows.Forms.PictureBox pcAtivo;
    }
}