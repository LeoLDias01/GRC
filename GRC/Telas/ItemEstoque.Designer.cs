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
            this.cbxQtdRegistros = new System.Windows.Forms.ComboBox();
            this.lbRegistros = new System.Windows.Forms.Label();
            this.txtCodigo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCodigoBarras = new MaterialSkin.Controls.MaterialTextBox();
            this.txtItem = new MaterialSkin.Controls.MaterialTextBox();
            this.cbCategoria = new MaterialSkin.Controls.MaterialComboBox();
            this.cbFornecedor = new MaterialSkin.Controls.MaterialComboBox();
            this.cbFabricante = new MaterialSkin.Controls.MaterialComboBox();
            this.chkAtivo = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkFavorito = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkItemVenda = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnApagar = new GRC.Componentes.CustomButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new GRC.Componentes.CustomButton();
            this.btnMaximize = new GRC.Componentes.CustomButton();
            this.btnMinimize = new GRC.Componentes.CustomButton();
            this.btnNovoItem = new GRC.Componentes.CustomButton();
            this.tbnSearch = new GRC.Componentes.CustomButton();
            this.painelRadius3 = new GRC.Componentes.PainelRadius();
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.pn1 = new GRC.Componentes.RoundedPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.modernBox1 = new GRC.Componentes.ModernBox();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.modernBox2 = new GRC.Componentes.ModernBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.painelRadius3.SuspendLayout();
            this.pnSuperior.SuspendLayout();
            this.panel2.SuspendLayout();
            this.modernBox1.SuspendLayout();
            this.flpMenu.SuspendLayout();
            this.modernBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItens.BackgroundColor = System.Drawing.Color.White;
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
            this.dgvItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItens.EnableHeadersVisualStyles = false;
            this.dgvItens.GridColor = System.Drawing.Color.Silver;
            this.dgvItens.Location = new System.Drawing.Point(10, 10);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvItens.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvItens.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(1198, 347);
            this.dgvItens.TabIndex = 10;
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
            this.cbxQtdRegistros.Location = new System.Drawing.Point(1149, 11);
            this.cbxQtdRegistros.Name = "cbxQtdRegistros";
            this.cbxQtdRegistros.Size = new System.Drawing.Size(59, 21);
            this.cbxQtdRegistros.TabIndex = 12;
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
            this.txtCodigo.Location = new System.Drawing.Point(13, 13);
            this.txtCodigo.MaxLength = 60;
            this.txtCodigo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(141, 50);
            this.txtCodigo.TabIndex = 4;
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
            this.txtCodigoBarras.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtCodigoBarras.LeadingIcon")));
            this.txtCodigoBarras.LeaveOnEnterKey = true;
            this.txtCodigoBarras.Location = new System.Drawing.Point(160, 13);
            this.txtCodigoBarras.MaxLength = 60;
            this.txtCodigoBarras.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigoBarras.Multiline = false;
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(300, 50);
            this.txtCodigoBarras.TabIndex = 5;
            this.txtCodigoBarras.Text = "";
            this.txtCodigoBarras.TrailingIcon = null;
            this.txtCodigoBarras.UseAccent = false;
            this.txtCodigoBarras.Enter += new System.EventHandler(this.txtCodigoBarras_Enter);
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
            this.txtItem.Location = new System.Drawing.Point(256, 69);
            this.txtItem.MaxLength = 60;
            this.txtItem.MouseState = MaterialSkin.MouseState.OUT;
            this.txtItem.Multiline = false;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(492, 50);
            this.txtItem.TabIndex = 9;
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
            this.cbCategoria.Location = new System.Drawing.Point(13, 69);
            this.cbCategoria.MaxDropDownItems = 4;
            this.cbCategoria.MouseState = MaterialSkin.MouseState.OUT;
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(237, 49);
            this.cbCategoria.StartIndex = 0;
            this.cbCategoria.TabIndex = 8;
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
            this.cbFornecedor.Location = new System.Drawing.Point(817, 13);
            this.cbFornecedor.MaxDropDownItems = 4;
            this.cbFornecedor.MouseState = MaterialSkin.MouseState.OUT;
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(368, 49);
            this.cbFornecedor.StartIndex = 0;
            this.cbFornecedor.TabIndex = 7;
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
            this.cbFabricante.Location = new System.Drawing.Point(466, 13);
            this.cbFabricante.MaxDropDownItems = 4;
            this.cbFabricante.MouseState = MaterialSkin.MouseState.OUT;
            this.cbFabricante.Name = "cbFabricante";
            this.cbFabricante.Size = new System.Drawing.Size(345, 49);
            this.cbFabricante.StartIndex = 0;
            this.cbFabricante.TabIndex = 6;
            this.cbFabricante.UseAccent = false;
            // 
            // chkAtivo
            // 
            this.chkAtivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.BackColor = System.Drawing.Color.Transparent;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Depth = 0;
            this.chkAtivo.Location = new System.Drawing.Point(13, 10);
            this.chkAtivo.Margin = new System.Windows.Forms.Padding(0);
            this.chkAtivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkAtivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.ReadOnly = false;
            this.chkAtivo.Ripple = true;
            this.chkAtivo.Size = new System.Drawing.Size(71, 37);
            this.chkAtivo.TabIndex = 1;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = false;
            // 
            // chkFavorito
            // 
            this.chkFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFavorito.AutoSize = true;
            this.chkFavorito.BackColor = System.Drawing.Color.Transparent;
            this.chkFavorito.Depth = 0;
            this.chkFavorito.Location = new System.Drawing.Point(105, 10);
            this.chkFavorito.Margin = new System.Windows.Forms.Padding(0);
            this.chkFavorito.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkFavorito.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkFavorito.Name = "chkFavorito";
            this.chkFavorito.ReadOnly = false;
            this.chkFavorito.Ripple = true;
            this.chkFavorito.Size = new System.Drawing.Size(93, 37);
            this.chkFavorito.TabIndex = 2;
            this.chkFavorito.Text = "Favorito";
            this.chkFavorito.UseVisualStyleBackColor = false;
            // 
            // chkItemVenda
            // 
            this.chkItemVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkItemVenda.AutoSize = true;
            this.chkItemVenda.BackColor = System.Drawing.Color.Transparent;
            this.chkItemVenda.Depth = 0;
            this.chkItemVenda.Location = new System.Drawing.Point(208, 10);
            this.chkItemVenda.Margin = new System.Windows.Forms.Padding(0);
            this.chkItemVenda.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkItemVenda.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkItemVenda.Name = "chkItemVenda";
            this.chkItemVenda.ReadOnly = false;
            this.chkItemVenda.Ripple = true;
            this.chkItemVenda.Size = new System.Drawing.Size(136, 37);
            this.chkItemVenda.TabIndex = 3;
            this.chkItemVenda.Text = "Item de Venda";
            this.chkItemVenda.UseVisualStyleBackColor = false;
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
            this.btnApagar.Location = new System.Drawing.Point(352, 18);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(43, 43);
            this.btnApagar.TabIndex = 12;
            this.btnApagar.TamanhoBorda = 0;
            this.btnApagar.TamanhoRaio = 10;
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
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
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 29);
            this.label1.TabIndex = 120;
            this.label1.Text = "Controle de Estoque";
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
            this.btnClose.Location = new System.Drawing.Point(1195, 17);
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
            this.btnMaximize.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(1149, 17);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(40, 35);
            this.btnMaximize.TabIndex = 15;
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
            this.btnMinimize.Location = new System.Drawing.Point(1103, 17);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 35);
            this.btnMinimize.TabIndex = 14;
            this.btnMinimize.TamanhoBorda = 0;
            this.btnMinimize.TamanhoRaio = 17;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
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
            this.btnNovoItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnNovoItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoItem.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnNovoItem.ForeColor = System.Drawing.Color.White;
            this.btnNovoItem.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoItem.Image")));
            this.btnNovoItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoItem.Location = new System.Drawing.Point(303, 17);
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnNovoItem.Size = new System.Drawing.Size(43, 43);
            this.btnNovoItem.TabIndex = 0;
            this.btnNovoItem.TamanhoBorda = 0;
            this.btnNovoItem.TamanhoRaio = 10;
            this.btnNovoItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoItem.UseVisualStyleBackColor = false;
            this.btnNovoItem.Click += new System.EventHandler(this.btnNovoItem_Click);
            // 
            // tbnSearch
            // 
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
            this.tbnSearch.Location = new System.Drawing.Point(401, 18);
            this.tbnSearch.Name = "tbnSearch";
            this.tbnSearch.Size = new System.Drawing.Size(43, 43);
            this.tbnSearch.TabIndex = 13;
            this.tbnSearch.TamanhoBorda = 0;
            this.tbnSearch.TamanhoRaio = 10;
            this.tbnSearch.UseVisualStyleBackColor = false;
            this.tbnSearch.Click += new System.EventHandler(this.tbnSearch_Click);
            // 
            // painelRadius3
            // 
            this.painelRadius3.BackColor = System.Drawing.Color.White;
            this.painelRadius3.BorderColor = System.Drawing.Color.White;
            this.painelRadius3.Controls.Add(this.chkItemVenda);
            this.painelRadius3.Controls.Add(this.chkAtivo);
            this.painelRadius3.Controls.Add(this.chkFavorito);
            this.painelRadius3.Location = new System.Drawing.Point(18, 13);
            this.painelRadius3.Name = "painelRadius3";
            this.painelRadius3.Radius = 50;
            this.painelRadius3.Size = new System.Drawing.Size(365, 58);
            this.painelRadius3.TabIndex = 128;
            this.painelRadius3.Thickness = 10F;
            // 
            // pnSuperior
            // 
            this.pnSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnSuperior.Controls.Add(this.pn1);
            this.pnSuperior.Controls.Add(this.pictureBox3);
            this.pnSuperior.Controls.Add(this.label1);
            this.pnSuperior.Controls.Add(this.btnClose);
            this.pnSuperior.Controls.Add(this.tbnSearch);
            this.pnSuperior.Controls.Add(this.btnMaximize);
            this.pnSuperior.Controls.Add(this.btnNovoItem);
            this.pnSuperior.Controls.Add(this.btnMinimize);
            this.pnSuperior.Controls.Add(this.btnApagar);
            this.pnSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(1239, 70);
            this.pnSuperior.TabIndex = 131;
            this.pnSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnSuperior_MouseDown);
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.Color.Transparent;
            this.pn1.Color1 = System.Drawing.Color.Lime;
            this.pn1.Color2 = System.Drawing.Color.Blue;
            this.pn1.CornerRadius = 8;
            this.pn1.GradientAngle = 280F;
            this.pn1.Location = new System.Drawing.Point(4, 64);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(293, 30);
            this.pn1.TabIndex = 127;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.panel2.Controls.Add(this.cbxQtdRegistros);
            this.panel2.Controls.Add(this.lbRegistros);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 685);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1239, 44);
            this.panel2.TabIndex = 160;
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
            this.modernBox1.Location = new System.Drawing.Point(12, 87);
            this.modernBox1.Name = "modernBox1";
            this.modernBox1.Padding = new System.Windows.Forms.Padding(10);
            this.modernBox1.ShadowColor = System.Drawing.Color.Transparent;
            this.modernBox1.ShadowSize = 0;
            this.modernBox1.Size = new System.Drawing.Size(1219, 207);
            this.modernBox1.TabIndex = 161;
            // 
            // flpMenu
            // 
            this.flpMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpMenu.BackColor = System.Drawing.Color.White;
            this.flpMenu.Controls.Add(this.txtCodigo);
            this.flpMenu.Controls.Add(this.txtCodigoBarras);
            this.flpMenu.Controls.Add(this.cbFabricante);
            this.flpMenu.Controls.Add(this.cbFornecedor);
            this.flpMenu.Controls.Add(this.cbCategoria);
            this.flpMenu.Controls.Add(this.txtItem);
            this.flpMenu.Location = new System.Drawing.Point(6, 77);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Padding = new System.Windows.Forms.Padding(10);
            this.flpMenu.Size = new System.Drawing.Size(1200, 124);
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
            this.modernBox2.Controls.Add(this.dgvItens);
            this.modernBox2.FillColor = System.Drawing.Color.White;
            this.modernBox2.Location = new System.Drawing.Point(13, 315);
            this.modernBox2.Name = "modernBox2";
            this.modernBox2.Padding = new System.Windows.Forms.Padding(10);
            this.modernBox2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.modernBox2.ShadowSize = 8;
            this.modernBox2.Size = new System.Drawing.Size(1218, 367);
            this.modernBox2.TabIndex = 162;
            // 
            // ItemEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1239, 729);
            this.Controls.Add(this.modernBox2);
            this.Controls.Add(this.modernBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1239, 729);
            this.Name = "ItemEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemEstoque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ItemEstoque_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemEstoque_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ItemEstoque_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.painelRadius3.ResumeLayout(false);
            this.painelRadius3.PerformLayout();
            this.pnSuperior.ResumeLayout(false);
            this.pnSuperior.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.modernBox1.ResumeLayout(false);
            this.flpMenu.ResumeLayout(false);
            this.modernBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxQtdRegistros;
        private System.Windows.Forms.Label lbRegistros;
        private Componentes.CustomButton btnApagar;
        private System.Windows.Forms.DataGridView dgvItens;
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
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private Componentes.CustomButton btnClose;
        private Componentes.CustomButton btnMaximize;
        private Componentes.CustomButton btnMinimize;
        private Componentes.CustomButton btnNovoItem;
        private Componentes.CustomButton tbnSearch;
        private Componentes.PainelRadius painelRadius3;
        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.Panel panel2;
        private Componentes.ModernBox modernBox1;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private Componentes.RoundedPanel pn1;
        private Componentes.ModernBox modernBox2;
    }
}