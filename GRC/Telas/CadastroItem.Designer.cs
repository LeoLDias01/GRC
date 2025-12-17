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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroItem));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnStatus = new GRC.Componentes.RoundedPanel();
            this.customPanel1 = new GRC.Componentes.CustomPanel();
            this.pcAtivo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvItemComposicao = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdComposicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.pcbFavorito = new GRC.Componentes.CustomPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscaImagem = new GRC.Componentes.CustomButton();
            this.btnExcluiImagem = new GRC.Componentes.CustomButton();
            this.swItemVenda = new MaterialSkin.Controls.MaterialSwitch();
            this.pcbImagemItem = new GRC.Componentes.CustomPictureBox();
            this.swItemAtivo = new MaterialSkin.Controls.MaterialSwitch();
            this.gpbInfoVenda = new System.Windows.Forms.GroupBox();
            this.btnAddComposicao = new GRC.Componentes.CustomButton();
            this.txtDescricaoItemVenda = new MaterialSkin.Controls.MaterialTextBox();
            this.txtLucroItem = new MaterialSkin.Controls.MaterialTextBox();
            this.txtValorVenda = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddUnidadeMedida = new GRC.Componentes.CustomButton();
            this.cbUnidadeMedida = new MaterialSkin.Controls.MaterialComboBox();
            this.btnAddFabricante = new GRC.Componentes.CustomButton();
            this.cbFabricante = new MaterialSkin.Controls.MaterialComboBox();
            this.txtObservacoes = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtGarantia = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCodigoBarras = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAddFornecedor = new GRC.Componentes.CustomButton();
            this.btnAddCategoria = new GRC.Componentes.CustomButton();
            this.txtValidade = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCustoTotal = new MaterialSkin.Controls.MaterialTextBox();
            this.txtId = new MaterialSkin.Controls.MaterialTextBox();
            this.cbFornecedor = new MaterialSkin.Controls.MaterialComboBox();
            this.txtDescricao = new MaterialSkin.Controls.MaterialTextBox();
            this.cbCategoria = new MaterialSkin.Controls.MaterialComboBox();
            this.txtQtdMinima = new MaterialSkin.Controls.MaterialTextBox();
            this.txtQtd = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCustoUnitario = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSalvar = new GRC.Componentes.CustomButton();
            this.txtLucroTotal = new MaterialSkin.Controls.MaterialTextBox();
            this.chkItemComposto = new MaterialSkin.Controls.MaterialCheckbox();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcAtivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemComposicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFavorito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagemItem)).BeginInit();
            this.gpbInfoVenda.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnStatus
            // 
            this.pnStatus.BackColor = System.Drawing.Color.Transparent;
            this.pnStatus.Color1 = System.Drawing.Color.Ivory;
            this.pnStatus.Color2 = System.Drawing.Color.Lime;
            this.pnStatus.CornerRadius = 10;
            this.pnStatus.GradientAngle = 90F;
            this.pnStatus.Location = new System.Drawing.Point(12, 10);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(905, 30);
            this.pnStatus.TabIndex = 2;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.customPanel1.Controls.Add(this.pcAtivo);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.btnAddComposicao);
            this.customPanel1.Controls.Add(this.dgvItemComposicao);
            this.customPanel1.Controls.Add(this.pcbFavorito);
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.Controls.Add(this.btnBuscaImagem);
            this.customPanel1.Controls.Add(this.btnExcluiImagem);
            this.customPanel1.Controls.Add(this.swItemVenda);
            this.customPanel1.Controls.Add(this.pcbImagemItem);
            this.customPanel1.Controls.Add(this.swItemAtivo);
            this.customPanel1.Controls.Add(this.gpbInfoVenda);
            this.customPanel1.Controls.Add(this.groupBox1);
            this.customPanel1.Controls.Add(this.materialLabel1);
            this.customPanel1.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.customPanel1.CorBotao = System.Drawing.Color.AliceBlue;
            this.customPanel1.CorTextoBotao = System.Drawing.Color.White;
            this.customPanel1.ForeColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(11, 48);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1061, 586);
            this.customPanel1.TabIndex = 1;
            this.customPanel1.TamanhoBorda = 0;
            this.customPanel1.TamanhoRaio = 20;
            // 
            // pcAtivo
            // 
            this.pcAtivo.Image = ((System.Drawing.Image)(resources.GetObject("pcAtivo.Image")));
            this.pcAtivo.Location = new System.Drawing.Point(183, 12);
            this.pcAtivo.Name = "pcAtivo";
            this.pcAtivo.Size = new System.Drawing.Size(35, 36);
            this.pcAtivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcAtivo.TabIndex = 46;
            this.pcAtivo.TabStop = false;
            this.pcAtivo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(888, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "800 x 800";
            // 
            // dgvItemComposicao
            // 
            this.dgvItemComposicao.AllowUserToAddRows = false;
            this.dgvItemComposicao.AllowUserToDeleteRows = false;
            this.dgvItemComposicao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemComposicao.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dgvItemComposicao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItemComposicao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvItemComposicao.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvItemComposicao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItemComposicao.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvItemComposicao.EnableHeadersVisualStyles = false;
            this.dgvItemComposicao.GridColor = System.Drawing.Color.Black;
            this.dgvItemComposicao.Location = new System.Drawing.Point(800, 350);
            this.dgvItemComposicao.MultiSelect = false;
            this.dgvItemComposicao.Name = "dgvItemComposicao";
            this.dgvItemComposicao.ReadOnly = true;
            this.dgvItemComposicao.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvItemComposicao.RowHeadersVisible = false;
            this.dgvItemComposicao.RowHeadersWidth = 62;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvItemComposicao.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvItemComposicao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemComposicao.Size = new System.Drawing.Size(248, 222);
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
            // pcbFavorito
            // 
            this.pcbFavorito.BackColor = System.Drawing.Color.Transparent;
            this.pcbFavorito.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.pcbFavorito.CorBotao = System.Drawing.Color.Transparent;
            this.pcbFavorito.CorTextoBotao = System.Drawing.Color.White;
            this.pcbFavorito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbFavorito.ForeColor = System.Drawing.Color.White;
            this.pcbFavorito.Image = global::GRC.Properties.Resources.star;
            this.pcbFavorito.Location = new System.Drawing.Point(744, 12);
            this.pcbFavorito.Name = "pcbFavorito";
            this.pcbFavorito.Size = new System.Drawing.Size(39, 38);
            this.pcbFavorito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbFavorito.TabIndex = 42;
            this.pcbFavorito.TabStop = false;
            this.pcbFavorito.TamanhoBorda = 0;
            this.pcbFavorito.TamanhoRaio = 0;
            this.pcbFavorito.Click += new System.EventHandler(this.pcbFavorito_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(856, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Foto do Item";
            // 
            // btnBuscaImagem
            // 
            this.btnBuscaImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnBuscaImagem.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscaImagem.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnBuscaImagem.CorTextoBotao = System.Drawing.Color.White;
            this.btnBuscaImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaImagem.FlatAppearance.BorderSize = 0;
            this.btnBuscaImagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.btnBuscaImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaImagem.ForeColor = System.Drawing.Color.White;
            this.btnBuscaImagem.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaImagem.Image")));
            this.btnBuscaImagem.Location = new System.Drawing.Point(818, 247);
            this.btnBuscaImagem.Name = "btnBuscaImagem";
            this.btnBuscaImagem.Size = new System.Drawing.Size(43, 43);
            this.btnBuscaImagem.TabIndex = 39;
            this.btnBuscaImagem.TamanhoBorda = 0;
            this.btnBuscaImagem.TamanhoRaio = 8;
            this.btnBuscaImagem.UseVisualStyleBackColor = false;
            this.btnBuscaImagem.Click += new System.EventHandler(this.btnBuscaImagem_Click);
            // 
            // btnExcluiImagem
            // 
            this.btnExcluiImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnExcluiImagem.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnExcluiImagem.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnExcluiImagem.CorTextoBotao = System.Drawing.Color.White;
            this.btnExcluiImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluiImagem.FlatAppearance.BorderSize = 0;
            this.btnExcluiImagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.btnExcluiImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluiImagem.ForeColor = System.Drawing.Color.White;
            this.btnExcluiImagem.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluiImagem.Image")));
            this.btnExcluiImagem.Location = new System.Drawing.Point(985, 248);
            this.btnExcluiImagem.Name = "btnExcluiImagem";
            this.btnExcluiImagem.Size = new System.Drawing.Size(43, 43);
            this.btnExcluiImagem.TabIndex = 35;
            this.btnExcluiImagem.TamanhoBorda = 0;
            this.btnExcluiImagem.TamanhoRaio = 8;
            this.btnExcluiImagem.UseVisualStyleBackColor = false;
            this.btnExcluiImagem.Click += new System.EventHandler(this.btnExcluiImagem_Click);
            // 
            // swItemVenda
            // 
            this.swItemVenda.AutoSize = true;
            this.swItemVenda.Depth = 0;
            this.swItemVenda.Location = new System.Drawing.Point(221, 417);
            this.swItemVenda.Margin = new System.Windows.Forms.Padding(0);
            this.swItemVenda.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swItemVenda.MouseState = MaterialSkin.MouseState.HOVER;
            this.swItemVenda.Name = "swItemVenda";
            this.swItemVenda.Ripple = true;
            this.swItemVenda.Size = new System.Drawing.Size(159, 37);
            this.swItemVenda.TabIndex = 36;
            this.swItemVenda.Text = "Item de Venda";
            this.swItemVenda.UseVisualStyleBackColor = true;
            this.swItemVenda.CheckedChanged += new System.EventHandler(this.swItemVenda_CheckedChanged);
            // 
            // pcbImagemItem
            // 
            this.pcbImagemItem.BackColor = System.Drawing.Color.White;
            this.pcbImagemItem.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.pcbImagemItem.CorBotao = System.Drawing.Color.White;
            this.pcbImagemItem.CorTextoBotao = System.Drawing.Color.White;
            this.pcbImagemItem.ForeColor = System.Drawing.Color.White;
            this.pcbImagemItem.Location = new System.Drawing.Point(818, 35);
            this.pcbImagemItem.Name = "pcbImagemItem";
            this.pcbImagemItem.Size = new System.Drawing.Size(210, 210);
            this.pcbImagemItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImagemItem.TabIndex = 37;
            this.pcbImagemItem.TabStop = false;
            this.pcbImagemItem.TamanhoBorda = 0;
            this.pcbImagemItem.TamanhoRaio = 0;
            // 
            // swItemAtivo
            // 
            this.swItemAtivo.AutoSize = true;
            this.swItemAtivo.Depth = 0;
            this.swItemAtivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.swItemAtivo.Location = new System.Drawing.Point(221, 12);
            this.swItemAtivo.Margin = new System.Windows.Forms.Padding(0);
            this.swItemAtivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swItemAtivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.swItemAtivo.Name = "swItemAtivo";
            this.swItemAtivo.Ripple = true;
            this.swItemAtivo.Size = new System.Drawing.Size(94, 37);
            this.swItemAtivo.TabIndex = 35;
            this.swItemAtivo.Text = "Ativo";
            this.swItemAtivo.UseVisualStyleBackColor = true;
            this.swItemAtivo.CheckedChanged += new System.EventHandler(this.swItemAtivo_CheckedChanged);
            // 
            // gpbInfoVenda
            // 
            this.gpbInfoVenda.Controls.Add(this.chkItemComposto);
            this.gpbInfoVenda.Controls.Add(this.txtLucroTotal);
            this.gpbInfoVenda.Controls.Add(this.txtDescricaoItemVenda);
            this.gpbInfoVenda.Controls.Add(this.txtLucroItem);
            this.gpbInfoVenda.Controls.Add(this.txtValorVenda);
            this.gpbInfoVenda.Enabled = false;
            this.gpbInfoVenda.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfoVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.gpbInfoVenda.Location = new System.Drawing.Point(20, 430);
            this.gpbInfoVenda.Name = "gpbInfoVenda";
            this.gpbInfoVenda.Size = new System.Drawing.Size(763, 142);
            this.gpbInfoVenda.TabIndex = 34;
            this.gpbInfoVenda.TabStop = false;
            this.gpbInfoVenda.Text = "Informações de Venda";
            // 
            // btnAddComposicao
            // 
            this.btnAddComposicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnAddComposicao.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnAddComposicao.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnAddComposicao.CorTextoBotao = System.Drawing.Color.White;
            this.btnAddComposicao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddComposicao.FlatAppearance.BorderSize = 0;
            this.btnAddComposicao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.btnAddComposicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddComposicao.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddComposicao.ForeColor = System.Drawing.Color.White;
            this.btnAddComposicao.Image = ((System.Drawing.Image)(resources.GetObject("btnAddComposicao.Image")));
            this.btnAddComposicao.Location = new System.Drawing.Point(800, 303);
            this.btnAddComposicao.Name = "btnAddComposicao";
            this.btnAddComposicao.Size = new System.Drawing.Size(248, 41);
            this.btnAddComposicao.TabIndex = 46;
            this.btnAddComposicao.TamanhoBorda = 0;
            this.btnAddComposicao.TamanhoRaio = 15;
            this.btnAddComposicao.Text = "        Add Composição";
            this.btnAddComposicao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddComposicao.UseVisualStyleBackColor = false;
            this.btnAddComposicao.Click += new System.EventHandler(this.btnAddComposicao_Click);
            // 
            // txtDescricaoItemVenda
            // 
            this.txtDescricaoItemVenda.AcceptsTab = true;
            this.txtDescricaoItemVenda.AnimateReadOnly = false;
            this.txtDescricaoItemVenda.AutoWordSelection = true;
            this.txtDescricaoItemVenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricaoItemVenda.Depth = 0;
            this.txtDescricaoItemVenda.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescricaoItemVenda.Hint = "Descricao do item para venda";
            this.txtDescricaoItemVenda.LeadingIcon = null;
            this.txtDescricaoItemVenda.LeaveOnEnterKey = true;
            this.txtDescricaoItemVenda.Location = new System.Drawing.Point(7, 27);
            this.txtDescricaoItemVenda.MaxLength = 60;
            this.txtDescricaoItemVenda.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescricaoItemVenda.Multiline = false;
            this.txtDescricaoItemVenda.Name = "txtDescricaoItemVenda";
            this.txtDescricaoItemVenda.Size = new System.Drawing.Size(566, 50);
            this.txtDescricaoItemVenda.TabIndex = 43;
            this.txtDescricaoItemVenda.Text = "";
            this.txtDescricaoItemVenda.TrailingIcon = null;
            this.txtDescricaoItemVenda.UseAccent = false;
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
            this.txtLucroItem.Hint = "Lucro por Produto";
            this.txtLucroItem.LeadingIcon = null;
            this.txtLucroItem.LeaveOnEnterKey = true;
            this.txtLucroItem.Location = new System.Drawing.Point(7, 83);
            this.txtLucroItem.MaxLength = 60;
            this.txtLucroItem.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLucroItem.Multiline = false;
            this.txtLucroItem.Name = "txtLucroItem";
            this.txtLucroItem.Size = new System.Drawing.Size(168, 50);
            this.txtLucroItem.TabIndex = 25;
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
            this.txtValorVenda.Location = new System.Drawing.Point(579, 27);
            this.txtValorVenda.MaxLength = 60;
            this.txtValorVenda.MouseState = MaterialSkin.MouseState.OUT;
            this.txtValorVenda.Multiline = false;
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(168, 50);
            this.txtValorVenda.TabIndex = 23;
            this.txtValorVenda.Text = "";
            this.txtValorVenda.TrailingIcon = null;
            this.txtValorVenda.UseAccent = false;
            this.txtValorVenda.TextChanged += new System.EventHandler(this.txtValorVenda_TextChanged);
            this.txtValorVenda.Enter += new System.EventHandler(this.txtValorVenda_Enter);
            this.txtValorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVenda_KeyPress);
            this.txtValorVenda.Leave += new System.EventHandler(this.txtValorVenda_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddUnidadeMedida);
            this.groupBox1.Controls.Add(this.cbUnidadeMedida);
            this.groupBox1.Controls.Add(this.btnAddFabricante);
            this.groupBox1.Controls.Add(this.cbFabricante);
            this.groupBox1.Controls.Add(this.txtObservacoes);
            this.groupBox1.Controls.Add(this.txtGarantia);
            this.groupBox1.Controls.Add(this.txtCodigoBarras);
            this.groupBox1.Controls.Add(this.btnAddFornecedor);
            this.groupBox1.Controls.Add(this.btnAddCategoria);
            this.groupBox1.Controls.Add(this.txtValidade);
            this.groupBox1.Controls.Add(this.txtCustoTotal);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.cbFornecedor);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.cbCategoria);
            this.groupBox1.Controls.Add(this.txtQtdMinima);
            this.groupBox1.Controls.Add(this.txtQtd);
            this.groupBox1.Controls.Add(this.txtCustoUnitario);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.groupBox1.Location = new System.Drawing.Point(20, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 359);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Item";
            // 
            // btnAddUnidadeMedida
            // 
            this.btnAddUnidadeMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnAddUnidadeMedida.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnAddUnidadeMedida.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnAddUnidadeMedida.CorTextoBotao = System.Drawing.Color.White;
            this.btnAddUnidadeMedida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUnidadeMedida.FlatAppearance.BorderSize = 0;
            this.btnAddUnidadeMedida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.btnAddUnidadeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUnidadeMedida.ForeColor = System.Drawing.Color.White;
            this.btnAddUnidadeMedida.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUnidadeMedida.Image")));
            this.btnAddUnidadeMedida.Location = new System.Drawing.Point(172, 139);
            this.btnAddUnidadeMedida.Name = "btnAddUnidadeMedida";
            this.btnAddUnidadeMedida.Size = new System.Drawing.Size(39, 39);
            this.btnAddUnidadeMedida.TabIndex = 42;
            this.btnAddUnidadeMedida.TamanhoBorda = 0;
            this.btnAddUnidadeMedida.TamanhoRaio = 16;
            this.btnAddUnidadeMedida.UseVisualStyleBackColor = false;
            this.btnAddUnidadeMedida.Click += new System.EventHandler(this.btnAddUnidadeMedida_Click);
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
            this.cbUnidadeMedida.Location = new System.Drawing.Point(7, 137);
            this.cbUnidadeMedida.MaxDropDownItems = 4;
            this.cbUnidadeMedida.MouseState = MaterialSkin.MouseState.OUT;
            this.cbUnidadeMedida.Name = "cbUnidadeMedida";
            this.cbUnidadeMedida.Size = new System.Drawing.Size(160, 49);
            this.cbUnidadeMedida.StartIndex = 0;
            this.cbUnidadeMedida.TabIndex = 41;
            this.cbUnidadeMedida.UseAccent = false;
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
            this.btnAddFabricante.Location = new System.Drawing.Point(435, 197);
            this.btnAddFabricante.Name = "btnAddFabricante";
            this.btnAddFabricante.Size = new System.Drawing.Size(39, 39);
            this.btnAddFabricante.TabIndex = 40;
            this.btnAddFabricante.TamanhoBorda = 0;
            this.btnAddFabricante.TamanhoRaio = 16;
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
            this.cbFabricante.Hint = "Fabricante";
            this.cbFabricante.IntegralHeight = false;
            this.cbFabricante.ItemHeight = 43;
            this.cbFabricante.Location = new System.Drawing.Point(231, 193);
            this.cbFabricante.MaxDropDownItems = 4;
            this.cbFabricante.MouseState = MaterialSkin.MouseState.OUT;
            this.cbFabricante.Name = "cbFabricante";
            this.cbFabricante.Size = new System.Drawing.Size(198, 49);
            this.cbFabricante.StartIndex = 0;
            this.cbFabricante.TabIndex = 39;
            this.cbFabricante.UseAccent = false;
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
            this.txtObservacoes.Location = new System.Drawing.Point(6, 248);
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
            this.txtObservacoes.Size = new System.Drawing.Size(744, 96);
            this.txtObservacoes.TabIndex = 37;
            this.txtObservacoes.TabStop = false;
            this.txtObservacoes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtObservacoes.UseAccent = false;
            this.txtObservacoes.UseSystemPasswordChar = false;
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
            this.txtGarantia.Location = new System.Drawing.Point(470, 82);
            this.txtGarantia.MaxLength = 60;
            this.txtGarantia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGarantia.Multiline = false;
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Size = new System.Drawing.Size(138, 50);
            this.txtGarantia.TabIndex = 36;
            this.txtGarantia.Text = "";
            this.txtGarantia.TrailingIcon = null;
            this.txtGarantia.UseAccent = false;
            this.txtGarantia.TextChanged += new System.EventHandler(this.txtGarantia_TextChanged);
            this.txtGarantia.Enter += new System.EventHandler(this.txtGarantia_Enter);
            this.txtGarantia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGarantia_KeyPress);
            this.txtGarantia.Leave += new System.EventHandler(this.txtGarantia_Leave);
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
            this.txtCodigoBarras.LeadingIcon = null;
            this.txtCodigoBarras.LeaveOnEnterKey = true;
            this.txtCodigoBarras.Location = new System.Drawing.Point(154, 26);
            this.txtCodigoBarras.MaxLength = 60;
            this.txtCodigoBarras.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigoBarras.Multiline = false;
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(593, 50);
            this.txtCodigoBarras.TabIndex = 24;
            this.txtCodigoBarras.Text = "";
            this.txtCodigoBarras.TrailingIcon = null;
            this.txtCodigoBarras.UseAccent = false;
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
            this.btnAddFornecedor.Location = new System.Drawing.Point(711, 197);
            this.btnAddFornecedor.Name = "btnAddFornecedor";
            this.btnAddFornecedor.Size = new System.Drawing.Size(39, 39);
            this.btnAddFornecedor.TabIndex = 34;
            this.btnAddFornecedor.TamanhoBorda = 0;
            this.btnAddFornecedor.TamanhoRaio = 16;
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
            this.btnAddCategoria.Location = new System.Drawing.Point(173, 197);
            this.btnAddCategoria.Name = "btnAddCategoria";
            this.btnAddCategoria.Size = new System.Drawing.Size(39, 39);
            this.btnAddCategoria.TabIndex = 33;
            this.btnAddCategoria.TamanhoBorda = 0;
            this.btnAddCategoria.TamanhoRaio = 16;
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
            this.txtValidade.Location = new System.Drawing.Point(619, 82);
            this.txtValidade.MaxLength = 60;
            this.txtValidade.MouseState = MaterialSkin.MouseState.OUT;
            this.txtValidade.Multiline = false;
            this.txtValidade.Name = "txtValidade";
            this.txtValidade.Size = new System.Drawing.Size(128, 50);
            this.txtValidade.TabIndex = 25;
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
            this.txtCustoTotal.Location = new System.Drawing.Point(614, 136);
            this.txtCustoTotal.MaxLength = 60;
            this.txtCustoTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCustoTotal.Multiline = false;
            this.txtCustoTotal.Name = "txtCustoTotal";
            this.txtCustoTotal.Size = new System.Drawing.Size(135, 50);
            this.txtCustoTotal.TabIndex = 25;
            this.txtCustoTotal.Text = "";
            this.txtCustoTotal.TrailingIcon = null;
            this.txtCustoTotal.UseAccent = false;
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
            this.txtId.Hint = "Código do item";
            this.txtId.LeadingIcon = null;
            this.txtId.LeaveOnEnterKey = true;
            this.txtId.Location = new System.Drawing.Point(6, 26);
            this.txtId.MaxLength = 60;
            this.txtId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(142, 50);
            this.txtId.TabIndex = 27;
            this.txtId.Text = "";
            this.txtId.TrailingIcon = null;
            this.txtId.UseAccent = false;
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
            this.cbFornecedor.Location = new System.Drawing.Point(480, 193);
            this.cbFornecedor.MaxDropDownItems = 4;
            this.cbFornecedor.MouseState = MaterialSkin.MouseState.OUT;
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(225, 49);
            this.cbFornecedor.StartIndex = 0;
            this.cbFornecedor.TabIndex = 32;
            this.cbFornecedor.UseAccent = false;
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
            this.txtDescricao.Location = new System.Drawing.Point(7, 82);
            this.txtDescricao.MaxLength = 60;
            this.txtDescricao.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescricao.Multiline = false;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(457, 50);
            this.txtDescricao.TabIndex = 1;
            this.txtDescricao.Text = "";
            this.txtDescricao.TrailingIcon = null;
            this.txtDescricao.UseAccent = false;
            this.txtDescricao.Leave += new System.EventHandler(this.txtDescricao_Leave);
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
            this.cbCategoria.Location = new System.Drawing.Point(7, 192);
            this.cbCategoria.MaxDropDownItems = 4;
            this.cbCategoria.MouseState = MaterialSkin.MouseState.OUT;
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(160, 49);
            this.cbCategoria.StartIndex = 0;
            this.cbCategoria.TabIndex = 28;
            this.cbCategoria.UseAccent = false;
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
            this.txtQtdMinima.Location = new System.Drawing.Point(231, 137);
            this.txtQtdMinima.MaxLength = 60;
            this.txtQtdMinima.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQtdMinima.Multiline = false;
            this.txtQtdMinima.Name = "txtQtdMinima";
            this.txtQtdMinima.Size = new System.Drawing.Size(116, 50);
            this.txtQtdMinima.TabIndex = 25;
            this.txtQtdMinima.Text = "";
            this.txtQtdMinima.TrailingIcon = null;
            this.txtQtdMinima.UseAccent = false;
            this.txtQtdMinima.Enter += new System.EventHandler(this.txtQtdMinima_Enter);
            this.txtQtdMinima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdMinima_KeyPress);
            this.txtQtdMinima.Leave += new System.EventHandler(this.txtQtdMinima_Leave);
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
            this.txtQtd.Location = new System.Drawing.Point(353, 136);
            this.txtQtd.MaxLength = 60;
            this.txtQtd.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQtd.Multiline = false;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(114, 50);
            this.txtQtd.TabIndex = 6;
            this.txtQtd.Text = "";
            this.txtQtd.TrailingIcon = null;
            this.txtQtd.UseAccent = false;
            this.txtQtd.TextChanged += new System.EventHandler(this.txtQtd_TextChanged);
            this.txtQtd.Enter += new System.EventHandler(this.txtQtd_Enter);
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtd_KeyPress);
            this.txtQtd.Leave += new System.EventHandler(this.txtQtd_Leave);
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
            this.txtCustoUnitario.Location = new System.Drawing.Point(473, 136);
            this.txtCustoUnitario.MaxLength = 60;
            this.txtCustoUnitario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCustoUnitario.Multiline = false;
            this.txtCustoUnitario.Name = "txtCustoUnitario";
            this.txtCustoUnitario.Size = new System.Drawing.Size(135, 50);
            this.txtCustoUnitario.TabIndex = 7;
            this.txtCustoUnitario.Text = "";
            this.txtCustoUnitario.TrailingIcon = null;
            this.txtCustoUnitario.UseAccent = false;
            this.txtCustoUnitario.TextChanged += new System.EventHandler(this.txtCustoUnitario_TextChanged);
            this.txtCustoUnitario.Enter += new System.EventHandler(this.txtCustoUnitario_Enter);
            this.txtCustoUnitario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustoUnitario_KeyDown);
            this.txtCustoUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustoUnitario_KeyPress);
            this.txtCustoUnitario.Leave += new System.EventHandler(this.txtCustoUnitario_Leave);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.SlateGray;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.materialLabel1.Location = new System.Drawing.Point(22, 16);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(155, 24);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Cadastro de Item";
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
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(923, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSalvar.Size = new System.Drawing.Size(149, 37);
            this.btnSalvar.TabIndex = 22;
            this.btnSalvar.TamanhoBorda = 0;
            this.btnSalvar.TamanhoRaio = 5;
            this.btnSalvar.Text = "    Salvar dados";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            this.txtLucroTotal.Location = new System.Drawing.Point(181, 83);
            this.txtLucroTotal.MaxLength = 60;
            this.txtLucroTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLucroTotal.Multiline = false;
            this.txtLucroTotal.Name = "txtLucroTotal";
            this.txtLucroTotal.Size = new System.Drawing.Size(168, 50);
            this.txtLucroTotal.TabIndex = 47;
            this.txtLucroTotal.Text = "";
            this.txtLucroTotal.TrailingIcon = null;
            this.txtLucroTotal.UseAccent = false;
            // 
            // chkItemComposto
            // 
            this.chkItemComposto.AutoSize = true;
            this.chkItemComposto.Depth = 0;
            this.chkItemComposto.Location = new System.Drawing.Point(362, 96);
            this.chkItemComposto.Margin = new System.Windows.Forms.Padding(0);
            this.chkItemComposto.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkItemComposto.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkItemComposto.Name = "chkItemComposto";
            this.chkItemComposto.ReadOnly = false;
            this.chkItemComposto.Ripple = true;
            this.chkItemComposto.Size = new System.Drawing.Size(143, 37);
            this.chkItemComposto.TabIndex = 48;
            this.chkItemComposto.Text = "Item Composto";
            this.chkItemComposto.UseVisualStyleBackColor = true;
            this.chkItemComposto.CheckedChanged += new System.EventHandler(this.chkItemComposto_CheckedChanged);
            // 
            // CadastroItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(1084, 646);
            this.Controls.Add(this.pnStatus);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.btnSalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroItem";
            this.Load += new System.EventHandler(this.CadastroItem_Load);
            this.Leave += new System.EventHandler(this.CadastroItem_Leave);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcAtivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemComposicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFavorito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagemItem)).EndInit();
            this.gpbInfoVenda.ResumeLayout(false);
            this.gpbInfoVenda.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.CustomPanel customPanel1;
        private MaterialSkin.Controls.MaterialTextBox txtCustoUnitario;
        private MaterialSkin.Controls.MaterialTextBox txtQtd;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtDescricao;
        private MaterialSkin.Controls.MaterialTextBox txtValorVenda;
        private Componentes.CustomButton btnSalvar;
        private MaterialSkin.Controls.MaterialTextBox txtCodigoBarras;
        private MaterialSkin.Controls.MaterialTextBox txtQtdMinima;
        private Componentes.RoundedPanel pnStatus;
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
        private System.Windows.Forms.Label label1;
        private Componentes.CustomButton btnBuscaImagem;
        private Componentes.CustomButton btnExcluiImagem;
        private Componentes.CustomPictureBox pcbImagemItem;
        private MaterialSkin.Controls.MaterialTextBox txtGarantia;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtObservacoes;
        private Componentes.CustomPictureBox pcbFavorito;
        private Componentes.CustomButton btnAddFabricante;
        private MaterialSkin.Controls.MaterialComboBox cbFabricante;
        private Componentes.CustomButton btnAddUnidadeMedida;
        private MaterialSkin.Controls.MaterialComboBox cbUnidadeMedida;
        private MaterialSkin.Controls.MaterialTextBox txtLucroItem;
        private MaterialSkin.Controls.MaterialTextBox txtDescricaoItemVenda;
        private System.Windows.Forms.DataGridView dgvItemComposicao;
        private Componentes.CustomButton btnAddComposicao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdComposicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPreco;
        private System.Windows.Forms.DataGridViewImageColumn colExcluir;
        private System.Windows.Forms.PictureBox pcAtivo;
        private MaterialSkin.Controls.MaterialTextBox txtLucroTotal;
        private MaterialSkin.Controls.MaterialCheckbox chkItemComposto;
    }
}