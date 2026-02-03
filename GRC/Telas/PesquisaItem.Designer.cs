namespace GRC.Telas
{
    partial class PesquisaItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaItem));
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.colImagem = new System.Windows.Forms.DataGridViewImageColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPanel2 = new GRC.Componentes.CustomPanel();
            this.cbxQtdRegistros = new System.Windows.Forms.ComboBox();
            this.lbRegistros = new System.Windows.Forms.Label();
            this.pnPesquisa = new GRC.Componentes.CustomPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtItem = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCodigo = new MaterialSkin.Controls.MaterialTextBox();
            this.btnApagar = new GRC.Componentes.CustomButton();
            this.btnSearch = new GRC.Componentes.CustomButton();
            this.roundedPanel1 = new GRC.Componentes.RoundedPanel();
            this.roundedPanel2 = new GRC.Componentes.RoundedPanel();
            this.customPanel1 = new GRC.Componentes.CustomPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.customPanel2.SuspendLayout();
            this.pnPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.customPanel1.SuspendLayout();
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
            this.colImagem,
            this.colId,
            this.colDescricao,
            this.colQtd,
            this.colPreco});
            this.dgvItens.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItens.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItens.EnableHeadersVisualStyles = false;
            this.dgvItens.GridColor = System.Drawing.Color.DarkGray;
            this.dgvItens.Location = new System.Drawing.Point(3, 17);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvItens.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvItens.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(602, 449);
            this.dgvItens.TabIndex = 23;
            this.dgvItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellDoubleClick);
            this.dgvItens.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellValueChanged);
            // 
            // colImagem
            // 
            this.colImagem.DataPropertyName = "FotoItem";
            this.colImagem.FillWeight = 48.93206F;
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
            this.colDescricao.FillWeight = 135.3932F;
            this.colDescricao.HeaderText = "Item";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            // 
            // colQtd
            // 
            this.colQtd.FillWeight = 33.71765F;
            this.colQtd.HeaderText = "Qtd";
            this.colQtd.Name = "colQtd";
            this.colQtd.ReadOnly = true;
            // 
            // colPreco
            // 
            this.colPreco.FillWeight = 47.65223F;
            this.colPreco.HeaderText = "Preço";
            this.colPreco.Name = "colPreco";
            this.colPreco.ReadOnly = true;
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
            this.customPanel2.Location = new System.Drawing.Point(12, 648);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(600, 37);
            this.customPanel2.TabIndex = 21;
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
            this.cbxQtdRegistros.Location = new System.Drawing.Point(522, 10);
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
            this.pnPesquisa.Controls.Add(this.pictureBox1);
            this.pnPesquisa.Controls.Add(this.materialLabel1);
            this.pnPesquisa.Controls.Add(this.txtItem);
            this.pnPesquisa.Controls.Add(this.txtCodigo);
            this.pnPesquisa.Controls.Add(this.btnApagar);
            this.pnPesquisa.Controls.Add(this.btnSearch);
            this.pnPesquisa.CorBorda = System.Drawing.Color.Black;
            this.pnPesquisa.CorBotao = System.Drawing.Color.AliceBlue;
            this.pnPesquisa.CorTextoBotao = System.Drawing.Color.White;
            this.pnPesquisa.ForeColor = System.Drawing.Color.White;
            this.pnPesquisa.Location = new System.Drawing.Point(12, 34);
            this.pnPesquisa.Name = "pnPesquisa";
            this.pnPesquisa.Size = new System.Drawing.Size(608, 119);
            this.pnPesquisa.TabIndex = 22;
            this.pnPesquisa.TamanhoBorda = 0;
            this.pnPesquisa.TamanhoRaio = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
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
            this.materialLabel1.Location = new System.Drawing.Point(68, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(133, 24);
            this.materialLabel1.TabIndex = 100;
            this.materialLabel1.Text = "Busca de Itens";
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
            this.txtItem.Location = new System.Drawing.Point(155, 56);
            this.txtItem.MaxLength = 60;
            this.txtItem.MouseState = MaterialSkin.MouseState.OUT;
            this.txtItem.Multiline = false;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(436, 50);
            this.txtItem.TabIndex = 33;
            this.txtItem.Text = "";
            this.txtItem.TrailingIcon = null;
            this.txtItem.UseAccent = false;
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
            this.txtCodigo.Location = new System.Drawing.Point(8, 56);
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
            this.btnApagar.Location = new System.Drawing.Point(499, 7);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(43, 43);
            this.btnApagar.TabIndex = 14;
            this.btnApagar.TamanhoBorda = 0;
            this.btnApagar.TamanhoRaio = 10;
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
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
            this.btnSearch.Location = new System.Drawing.Point(548, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(43, 43);
            this.btnSearch.TabIndex = 99;
            this.btnSearch.TamanhoBorda = 0;
            this.btnSearch.TamanhoRaio = 10;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.Color1 = System.Drawing.Color.PaleTurquoise;
            this.roundedPanel1.Color2 = System.Drawing.Color.Black;
            this.roundedPanel1.CornerRadius = 10;
            this.roundedPanel1.GradientAngle = 45F;
            this.roundedPanel1.Location = new System.Drawing.Point(76, 3);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(543, 25);
            this.roundedPanel1.TabIndex = 100;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel2.Color1 = System.Drawing.Color.PaleTurquoise;
            this.roundedPanel2.Color2 = System.Drawing.Color.PaleTurquoise;
            this.roundedPanel2.CornerRadius = 10;
            this.roundedPanel2.GradientAngle = 45F;
            this.roundedPanel2.Location = new System.Drawing.Point(12, 3);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(58, 25);
            this.roundedPanel2.TabIndex = 101;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.customPanel1.Controls.Add(this.dgvItens);
            this.customPanel1.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.customPanel1.CorBotao = System.Drawing.Color.AliceBlue;
            this.customPanel1.CorTextoBotao = System.Drawing.Color.White;
            this.customPanel1.ForeColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(12, 159);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(608, 481);
            this.customPanel1.TabIndex = 102;
            this.customPanel1.TamanhoBorda = 0;
            this.customPanel1.TamanhoRaio = 20;
            // 
            // PesquisaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(632, 697);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.pnPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PesquisaItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Item de Estoque";
            this.Load += new System.EventHandler(this.PesquisaItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.pnPesquisa.ResumeLayout(false);
            this.pnPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.CustomPanel customPanel2;
        private System.Windows.Forms.ComboBox cbxQtdRegistros;
        private System.Windows.Forms.Label lbRegistros;
        private Componentes.CustomPanel pnPesquisa;
        private MaterialSkin.Controls.MaterialTextBox txtCodigo;
        private MaterialSkin.Controls.MaterialTextBox txtItem;
        private Componentes.CustomButton btnApagar;
        private Componentes.CustomButton btnSearch;
        private System.Windows.Forms.DataGridView dgvItens;
        private Componentes.RoundedPanel roundedPanel1;
        private Componentes.RoundedPanel roundedPanel2;
        private Componentes.CustomPanel customPanel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewImageColumn colImagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPreco;
    }
}