namespace GRC.Telas
{
    partial class ItemEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemEstoque));
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.colFavorito = new System.Windows.Forms.DataGridViewImageColumn();
            this.colImagem = new System.Windows.Forms.DataGridViewImageColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox4 = new MaterialSkin.Controls.MaterialCheckbox();
            this.roundedPanel1 = new GRC.Componentes.RoundedPanel();
            this.customPanel2 = new GRC.Componentes.CustomPanel();
            this.cbxQtdRegistros = new System.Windows.Forms.ComboBox();
            this.lbRegistros = new System.Windows.Forms.Label();
            this.pnPesquisa = new GRC.Componentes.CustomPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtCodigo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCodigoBarras = new MaterialSkin.Controls.MaterialTextBox();
            this.txtItem = new MaterialSkin.Controls.MaterialTextBox();
            this.cbCategoria = new MaterialSkin.Controls.MaterialComboBox();
            this.cbFornecedor = new MaterialSkin.Controls.MaterialComboBox();
            this.cbFabricante = new MaterialSkin.Controls.MaterialComboBox();
            this.chkAtivo = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkFavorito = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkItemVenda = new MaterialSkin.Controls.MaterialCheckbox();
            this.tbnSearch = new GRC.Componentes.CustomButton();
            this.btnNovoItem = new GRC.Componentes.CustomButton();
            this.btnApagar = new GRC.Componentes.CustomButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.customPanel2.SuspendLayout();
            this.pnPesquisa.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItens.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvItens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItens.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvItens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItens.ColumnHeadersHeight = 35;
            this.dgvItens.ColumnHeadersVisible = false;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFavorito,
            this.colImagem,
            this.colId,
            this.colDescricao,
            this.colCodigoBarras,
            this.colQtd,
            this.colCategoria,
            this.colFabricante,
            this.colFornecedor,
            this.colProduto,
            this.colAtivo});
            this.dgvItens.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItens.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItens.EnableHeadersVisualStyles = false;
            this.dgvItens.GridColor = System.Drawing.Color.Silver;
            this.dgvItens.Location = new System.Drawing.Point(16, 228);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvItens.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvItens.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(1206, 446);
            this.dgvItens.TabIndex = 16;
            this.dgvItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellDoubleClick);
            this.dgvItens.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellValueChanged);
            // 
            // colFavorito
            // 
            this.colFavorito.DataPropertyName = "Favorito";
            this.colFavorito.FillWeight = 6.146037F;
            this.colFavorito.HeaderText = "";
            this.colFavorito.Name = "colFavorito";
            this.colFavorito.ReadOnly = true;
            // 
            // colImagem
            // 
            this.colImagem.DataPropertyName = "FotoItem";
            this.colImagem.FillWeight = 12.98365F;
            this.colImagem.HeaderText = "Foto";
            this.colImagem.Name = "colImagem";
            this.colImagem.ReadOnly = true;
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
            this.colDescricao.DataPropertyName = "Descricao";
            this.colDescricao.FillWeight = 35.69515F;
            this.colDescricao.HeaderText = "Item";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            // 
            // colCodigoBarras
            // 
            this.colCodigoBarras.DataPropertyName = "CodBarras";
            this.colCodigoBarras.FillWeight = 35.01702F;
            this.colCodigoBarras.HeaderText = "Código de Barras";
            this.colCodigoBarras.Name = "colCodigoBarras";
            this.colCodigoBarras.ReadOnly = true;
            this.colCodigoBarras.Visible = false;
            // 
            // colQtd
            // 
            this.colQtd.DataPropertyName = "Quantidade";
            this.colQtd.FillWeight = 10.428F;
            this.colQtd.HeaderText = "Qtd";
            this.colQtd.Name = "colQtd";
            this.colQtd.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.DataPropertyName = "DescricaoCategoria";
            this.colCategoria.FillWeight = 16.20491F;
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // colFabricante
            // 
            this.colFabricante.DataPropertyName = "DescricaoFabricante";
            this.colFabricante.FillWeight = 25.27785F;
            this.colFabricante.HeaderText = "Marca";
            this.colFabricante.Name = "colFabricante";
            this.colFabricante.ReadOnly = true;
            // 
            // colFornecedor
            // 
            this.colFornecedor.DataPropertyName = "Fornecedor";
            this.colFornecedor.FillWeight = 21.87452F;
            this.colFornecedor.HeaderText = "Fornecedor";
            this.colFornecedor.Name = "colFornecedor";
            this.colFornecedor.ReadOnly = true;
            // 
            // colProduto
            // 
            this.colProduto.DataPropertyName = "ItemVenda";
            this.colProduto.FillWeight = 21.22982F;
            this.colProduto.HeaderText = "Produto";
            this.colProduto.Name = "colProduto";
            this.colProduto.ReadOnly = true;
            // 
            // colAtivo
            // 
            this.colAtivo.DataPropertyName = "Ativo";
            this.colAtivo.FillWeight = 20.67864F;
            this.colAtivo.HeaderText = "Ativo";
            this.colAtivo.Name = "colAtivo";
            this.colAtivo.ReadOnly = true;
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox1.TabIndex = 0;
            this.materialCheckbox1.Text = "Ativo";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox2
            // 
            this.materialCheckbox2.Depth = 0;
            this.materialCheckbox2.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox2.Name = "materialCheckbox2";
            this.materialCheckbox2.ReadOnly = false;
            this.materialCheckbox2.Ripple = true;
            this.materialCheckbox2.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox2.TabIndex = 0;
            this.materialCheckbox2.Text = "materialCheckbox2";
            this.materialCheckbox2.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox3
            // 
            this.materialCheckbox3.Depth = 0;
            this.materialCheckbox3.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox3.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox3.Name = "materialCheckbox3";
            this.materialCheckbox3.ReadOnly = false;
            this.materialCheckbox3.Ripple = true;
            this.materialCheckbox3.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox3.TabIndex = 0;
            this.materialCheckbox3.Text = "materialCheckbox3";
            this.materialCheckbox3.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox4
            // 
            this.materialCheckbox4.Depth = 0;
            this.materialCheckbox4.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox4.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox4.Name = "materialCheckbox4";
            this.materialCheckbox4.ReadOnly = false;
            this.materialCheckbox4.Ripple = true;
            this.materialCheckbox4.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox4.TabIndex = 0;
            this.materialCheckbox4.Text = "materialCheckbox4";
            this.materialCheckbox4.UseVisualStyleBackColor = true;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.roundedPanel1.Color2 = System.Drawing.Color.Aqua;
            this.roundedPanel1.CornerRadius = 10;
            this.roundedPanel1.GradientAngle = 180F;
            this.roundedPanel1.Location = new System.Drawing.Point(16, 194);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(1206, 28);
            this.roundedPanel1.TabIndex = 20;
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
            this.customPanel2.Size = new System.Drawing.Size(1210, 37);
            this.customPanel2.TabIndex = 18;
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
            this.cbxQtdRegistros.Location = new System.Drawing.Point(1132, 10);
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
            this.pnPesquisa.Controls.Add(this.tbnSearch);
            this.pnPesquisa.Controls.Add(this.btnNovoItem);
            this.pnPesquisa.Controls.Add(this.btnApagar);
            this.pnPesquisa.Controls.Add(this.materialLabel1);
            this.pnPesquisa.CorBorda = System.Drawing.Color.Black;
            this.pnPesquisa.CorBotao = System.Drawing.Color.AliceBlue;
            this.pnPesquisa.CorTextoBotao = System.Drawing.Color.White;
            this.pnPesquisa.ForeColor = System.Drawing.Color.White;
            this.pnPesquisa.Location = new System.Drawing.Point(16, 10);
            this.pnPesquisa.Name = "pnPesquisa";
            this.pnPesquisa.Size = new System.Drawing.Size(1210, 178);
            this.pnPesquisa.TabIndex = 19;
            this.pnPesquisa.TamanhoBorda = 0;
            this.pnPesquisa.TamanhoRaio = 20;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.txtCodigo);
            this.flowLayoutPanel1.Controls.Add(this.txtCodigoBarras);
            this.flowLayoutPanel1.Controls.Add(this.txtItem);
            this.flowLayoutPanel1.Controls.Add(this.cbCategoria);
            this.flowLayoutPanel1.Controls.Add(this.cbFornecedor);
            this.flowLayoutPanel1.Controls.Add(this.cbFabricante);
            this.flowLayoutPanel1.Controls.Add(this.chkAtivo);
            this.flowLayoutPanel1.Controls.Add(this.chkFavorito);
            this.flowLayoutPanel1.Controls.Add(this.chkItemVenda);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1198, 112);
            this.flowLayoutPanel1.TabIndex = 104;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AcceptsTab = true;
            this.txtCodigo.AnimateReadOnly = false;
            this.txtCodigo.AutoWordSelection = true;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo.Hint = "Código do item";
            this.txtCodigo.LeadingIcon = null;
            this.txtCodigo.LeaveOnEnterKey = true;
            this.txtCodigo.Location = new System.Drawing.Point(3, 3);
            this.txtCodigo.MaxLength = 60;
            this.txtCodigo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(141, 50);
            this.txtCodigo.TabIndex = 37;
            this.txtCodigo.Text = "";
            this.txtCodigo.TrailingIcon = null;
            this.txtCodigo.UseAccent = false;
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
            this.txtCodigoBarras.Location = new System.Drawing.Point(150, 3);
            this.txtCodigoBarras.MaxLength = 60;
            this.txtCodigoBarras.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigoBarras.Multiline = false;
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(368, 50);
            this.txtCodigoBarras.TabIndex = 44;
            this.txtCodigoBarras.Text = "";
            this.txtCodigoBarras.TrailingIcon = null;
            this.txtCodigoBarras.UseAccent = false;
            // 
            // txtItem
            // 
            this.txtItem.AcceptsTab = true;
            this.txtItem.AnimateReadOnly = false;
            this.txtItem.AutoWordSelection = true;
            this.txtItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItem.Depth = 0;
            this.txtItem.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtItem.Hint = "Nome do Item";
            this.txtItem.LeadingIcon = null;
            this.txtItem.LeaveOnEnterKey = true;
            this.txtItem.Location = new System.Drawing.Point(524, 3);
            this.txtItem.MaxLength = 60;
            this.txtItem.MouseState = MaterialSkin.MouseState.OUT;
            this.txtItem.Multiline = false;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(424, 50);
            this.txtItem.TabIndex = 33;
            this.txtItem.Text = "";
            this.txtItem.TrailingIcon = null;
            this.txtItem.UseAccent = false;
            // 
            // cbCategoria
            // 
            this.cbCategoria.AutoResize = false;
            this.cbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.cbCategoria.Location = new System.Drawing.Point(954, 3);
            this.cbCategoria.MaxDropDownItems = 4;
            this.cbCategoria.MouseState = MaterialSkin.MouseState.OUT;
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(237, 49);
            this.cbCategoria.StartIndex = 0;
            this.cbCategoria.TabIndex = 35;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.AutoResize = false;
            this.cbFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.cbFornecedor.Location = new System.Drawing.Point(3, 59);
            this.cbFornecedor.MaxDropDownItems = 4;
            this.cbFornecedor.MouseState = MaterialSkin.MouseState.OUT;
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(322, 49);
            this.cbFornecedor.StartIndex = 0;
            this.cbFornecedor.TabIndex = 36;
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
            this.cbFabricante.Location = new System.Drawing.Point(331, 59);
            this.cbFabricante.MaxDropDownItems = 4;
            this.cbFabricante.MouseState = MaterialSkin.MouseState.OUT;
            this.cbFabricante.Name = "cbFabricante";
            this.cbFabricante.Size = new System.Drawing.Size(307, 49);
            this.cbFabricante.StartIndex = 0;
            this.cbFabricante.TabIndex = 40;
            this.cbFabricante.UseAccent = false;
            // 
            // chkAtivo
            // 
            this.chkAtivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Depth = 0;
            this.chkAtivo.Location = new System.Drawing.Point(641, 74);
            this.chkAtivo.Margin = new System.Windows.Forms.Padding(0);
            this.chkAtivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkAtivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.ReadOnly = false;
            this.chkAtivo.Ripple = true;
            this.chkAtivo.Size = new System.Drawing.Size(71, 37);
            this.chkAtivo.TabIndex = 41;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // chkFavorito
            // 
            this.chkFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFavorito.AutoSize = true;
            this.chkFavorito.Depth = 0;
            this.chkFavorito.Location = new System.Drawing.Point(712, 74);
            this.chkFavorito.Margin = new System.Windows.Forms.Padding(0);
            this.chkFavorito.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkFavorito.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkFavorito.Name = "chkFavorito";
            this.chkFavorito.ReadOnly = false;
            this.chkFavorito.Ripple = true;
            this.chkFavorito.Size = new System.Drawing.Size(93, 37);
            this.chkFavorito.TabIndex = 42;
            this.chkFavorito.Text = "Favorito";
            this.chkFavorito.UseVisualStyleBackColor = true;
            // 
            // chkItemVenda
            // 
            this.chkItemVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkItemVenda.AutoSize = true;
            this.chkItemVenda.Depth = 0;
            this.chkItemVenda.Location = new System.Drawing.Point(805, 74);
            this.chkItemVenda.Margin = new System.Windows.Forms.Padding(0);
            this.chkItemVenda.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkItemVenda.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkItemVenda.Name = "chkItemVenda";
            this.chkItemVenda.ReadOnly = false;
            this.chkItemVenda.Ripple = true;
            this.chkItemVenda.Size = new System.Drawing.Size(136, 37);
            this.chkItemVenda.TabIndex = 43;
            this.chkItemVenda.Text = "Item de Venda";
            this.chkItemVenda.UseVisualStyleBackColor = true;
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
            this.tbnSearch.Location = new System.Drawing.Point(1160, 7);
            this.tbnSearch.Name = "tbnSearch";
            this.tbnSearch.Size = new System.Drawing.Size(43, 43);
            this.tbnSearch.TabIndex = 99;
            this.tbnSearch.TamanhoBorda = 0;
            this.tbnSearch.TamanhoRaio = 10;
            this.tbnSearch.UseVisualStyleBackColor = false;
            this.tbnSearch.Click += new System.EventHandler(this.tbnSearch_Click);
            // 
            // btnNovoItem
            // 
            this.btnNovoItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnNovoItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovoItem.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnNovoItem.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnNovoItem.CorTextoBotao = System.Drawing.Color.White;
            this.btnNovoItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoItem.FlatAppearance.BorderSize = 0;
            this.btnNovoItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNovoItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoItem.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnNovoItem.ForeColor = System.Drawing.Color.White;
            this.btnNovoItem.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoItem.Image")));
            this.btnNovoItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoItem.Location = new System.Drawing.Point(196, 20);
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Size = new System.Drawing.Size(118, 37);
            this.btnNovoItem.TabIndex = 16;
            this.btnNovoItem.TamanhoBorda = 0;
            this.btnNovoItem.TamanhoRaio = 5;
            this.btnNovoItem.Text = " Novo Item";
            this.btnNovoItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovoItem.UseVisualStyleBackColor = false;
            this.btnNovoItem.Click += new System.EventHandler(this.btnNovoItem_Click);
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
            this.btnApagar.Location = new System.Drawing.Point(1111, 7);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(43, 43);
            this.btnApagar.TabIndex = 14;
            this.btnApagar.TamanhoBorda = 0;
            this.btnApagar.TamanhoRaio = 10;
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
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
            this.materialLabel1.Size = new System.Drawing.Size(160, 24);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Pesquisa de Itens";
            // 
            // ItemEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(1239, 729);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.pnPesquisa);
            this.Controls.Add(this.dgvItens);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemEstoque";
            this.Load += new System.EventHandler(this.ItemEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.pnPesquisa.ResumeLayout(false);
            this.pnPesquisa.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.CustomPanel customPanel2;
        private System.Windows.Forms.ComboBox cbxQtdRegistros;
        private System.Windows.Forms.Label lbRegistros;
        private Componentes.CustomPanel pnPesquisa;
        private Componentes.CustomButton btnNovoItem;
        private Componentes.CustomButton btnApagar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dgvItens;
        private Componentes.RoundedPanel roundedPanel1;
        private MaterialSkin.Controls.MaterialComboBox cbFornecedor;
        private MaterialSkin.Controls.MaterialComboBox cbCategoria;
        private MaterialSkin.Controls.MaterialTextBox txtItem;
        private MaterialSkin.Controls.MaterialTextBox txtCodigo;
        private MaterialSkin.Controls.MaterialComboBox cbFabricante;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialCheckbox chkItemVenda;
        private MaterialSkin.Controls.MaterialCheckbox chkFavorito;
        private MaterialSkin.Controls.MaterialCheckbox chkAtivo;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox3;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox4;
        private MaterialSkin.Controls.MaterialTextBox txtCodigoBarras;
        private System.Windows.Forms.DataGridViewImageColumn colFavorito;
        private System.Windows.Forms.DataGridViewImageColumn colImagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFornecedor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colProduto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAtivo;
        private Componentes.CustomButton tbnSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}