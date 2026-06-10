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
            this.pnExterno = new GRC.Componentes.ModernBox();
            this.pnInterno = new GRC.Componentes.CustomPanel();
            this.modernBox2 = new GRC.Componentes.ModernBox();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImagem = new System.Windows.Forms.DataGridViewImageColumn();
            this.colProduto = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnStatus = new GRC.Componentes.RoundedPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.modernBox1 = new GRC.Componentes.ModernBox();
            this.txtPesquisa = new GRC.Componentes.RoundedTextBox();
            this.lblStatusLeitor = new System.Windows.Forms.Label();
            this.lbCódigoBarras = new System.Windows.Forms.Label();
            this.chkItemVenda = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnAddItem = new GRC.Componentes.CustomButton();
            this.btnEncerrarJanelas = new GRC.Componentes.CustomButton();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pnExterno.SuspendLayout();
            this.pnInterno.SuspendLayout();
            this.modernBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.panel2.SuspendLayout();
            this.modernBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
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
            this.pnExterno.Location = new System.Drawing.Point(1, -4);
            this.pnExterno.Name = "pnExterno";
            this.pnExterno.Padding = new System.Windows.Forms.Padding(13);
            this.pnExterno.ShadowAngle = 90;
            this.pnExterno.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnExterno.ShadowSize = 8;
            this.pnExterno.Size = new System.Drawing.Size(690, 552);
            this.pnExterno.TabIndex = 179;
            // 
            // pnInterno
            // 
            this.pnInterno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnInterno.BackColor = System.Drawing.Color.White;
            this.pnInterno.Controls.Add(this.modernBox2);
            this.pnInterno.Controls.Add(this.pnStatus);
            this.pnInterno.Controls.Add(this.panel2);
            this.pnInterno.Controls.Add(this.chkItemVenda);
            this.pnInterno.Controls.Add(this.btnAddItem);
            this.pnInterno.Controls.Add(this.btnEncerrarJanelas);
            this.pnInterno.Controls.Add(this.label11);
            this.pnInterno.Controls.Add(this.pictureBox4);
            this.pnInterno.Controls.Add(this.lbTitulo);
            this.pnInterno.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.pnInterno.CorBotao = System.Drawing.Color.White;
            this.pnInterno.CorTextoBotao = System.Drawing.Color.White;
            this.pnInterno.ForeColor = System.Drawing.Color.White;
            this.pnInterno.Location = new System.Drawing.Point(11, 3);
            this.pnInterno.Name = "pnInterno";
            this.pnInterno.Size = new System.Drawing.Size(670, 533);
            this.pnInterno.TabIndex = 161;
            this.pnInterno.TamanhoBorda = 0;
            this.pnInterno.TamanhoRaio = 15;
            this.pnInterno.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PesquisaItem_MouseDown);
            // 
            // modernBox2
            // 
            this.modernBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modernBox2.BackColor = System.Drawing.Color.Transparent;
            this.modernBox2.BorderColor = System.Drawing.Color.White;
            this.modernBox2.BorderRadius = 12;
            this.modernBox2.BorderSize = 1;
            this.modernBox2.Controls.Add(this.dgvItens);
            this.modernBox2.FillColor = System.Drawing.Color.White;
            this.modernBox2.Location = new System.Drawing.Point(3, 186);
            this.modernBox2.Name = "modernBox2";
            this.modernBox2.Padding = new System.Windows.Forms.Padding(13);
            this.modernBox2.ShadowAngle = 135;
            this.modernBox2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.modernBox2.ShadowSize = 8;
            this.modernBox2.Size = new System.Drawing.Size(660, 344);
            this.modernBox2.TabIndex = 188;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colImagem,
            this.colProduto,
            this.colDescricao,
            this.colCodigoBarras});
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
            this.dgvItens.GridColor = System.Drawing.Color.Silver;
            this.dgvItens.Location = new System.Drawing.Point(17, 16);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvItens.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvItens.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(633, 312);
            this.dgvItens.TabIndex = 4;
            this.dgvItens.Visible = false;
            this.dgvItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellDoubleClick);
            this.dgvItens.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvItens_CellFormatting);
            this.dgvItens.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvItens_Paint);
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
            // colImagem
            // 
            this.colImagem.DataPropertyName = "FotoItem";
            this.colImagem.FillWeight = 12.98365F;
            this.colImagem.HeaderText = "Foto";
            this.colImagem.Name = "colImagem";
            this.colImagem.ReadOnly = true;
            // 
            // colProduto
            // 
            this.colProduto.DataPropertyName = "ItemVenda";
            this.colProduto.FillWeight = 21.22982F;
            this.colProduto.HeaderText = "Item/Venda";
            this.colProduto.Image = global::GRC.Properties.Resources.Marca_Venda;
            this.colProduto.Name = "colProduto";
            this.colProduto.ReadOnly = true;
            this.colProduto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.colCodigoBarras.HeaderText = "CodBarras";
            this.colCodigoBarras.Name = "colCodigoBarras";
            this.colCodigoBarras.ReadOnly = true;
            this.colCodigoBarras.Visible = false;
            // 
            // pnStatus
            // 
            this.pnStatus.BackColor = System.Drawing.Color.Transparent;
            this.pnStatus.Color1 = System.Drawing.Color.Aquamarine;
            this.pnStatus.Color2 = System.Drawing.Color.DarkTurquoise;
            this.pnStatus.CornerRadius = 10;
            this.pnStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnStatus.GradientAngle = 90F;
            this.pnStatus.Location = new System.Drawing.Point(0, 0);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(670, 9);
            this.pnStatus.TabIndex = 54;
            this.pnStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PesquisaItem_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.modernBox1);
            this.panel2.Controls.Add(this.lblStatusLeitor);
            this.panel2.Controls.Add(this.lbCódigoBarras);
            this.panel2.Location = new System.Drawing.Point(5, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 76);
            this.panel2.TabIndex = 187;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PesquisaItem_MouseDown);
            // 
            // modernBox1
            // 
            this.modernBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.modernBox1.BackColor = System.Drawing.Color.Transparent;
            this.modernBox1.BorderColor = System.Drawing.Color.Transparent;
            this.modernBox1.BorderRadius = 20;
            this.modernBox1.BorderSize = 1;
            this.modernBox1.Controls.Add(this.txtPesquisa);
            this.modernBox1.FillColor = System.Drawing.Color.White;
            this.modernBox1.Location = new System.Drawing.Point(0, 23);
            this.modernBox1.Name = "modernBox1";
            this.modernBox1.Padding = new System.Windows.Forms.Padding(8);
            this.modernBox1.ShadowAngle = 50;
            this.modernBox1.ShadowColor = System.Drawing.Color.Gainsboro;
            this.modernBox1.ShadowSize = 3;
            this.modernBox1.Size = new System.Drawing.Size(436, 50);
            this.modernBox1.TabIndex = 176;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.txtPesquisa.BorderColor = System.Drawing.Color.White;
            this.txtPesquisa.BorderRadius = 12;
            this.txtPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPesquisa.FillColor = System.Drawing.Color.White;
            this.txtPesquisa.Icon = ((System.Drawing.Image)(resources.GetObject("txtPesquisa.Icon")));
            this.txtPesquisa.IconPosition = GRC.Componentes.RoundedTextBox.IconPositionEnum.Right;
            this.txtPesquisa.Location = new System.Drawing.Point(8, 8);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Padding = new System.Windows.Forms.Padding(10);
            this.txtPesquisa.Placeholder = "Busque por Nome do Item...";
            this.txtPesquisa.SelectedText = "";
            this.txtPesquisa.SelectionLength = 0;
            this.txtPesquisa.SelectionStart = 0;
            this.txtPesquisa.Size = new System.Drawing.Size(420, 34);
            this.txtPesquisa.TabIndex = 2;
            this.txtPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPesquisa.TextColor = System.Drawing.Color.Black;
            this.txtPesquisa.TextStyle = System.Drawing.FontStyle.Regular;
            this.txtPesquisa.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtPesquisa.UnderlineSize = 5;
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // lblStatusLeitor
            // 
            this.lblStatusLeitor.AutoSize = true;
            this.lblStatusLeitor.BackColor = System.Drawing.Color.MediumVioletRed;
            this.lblStatusLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatusLeitor.ForeColor = System.Drawing.Color.White;
            this.lblStatusLeitor.Location = new System.Drawing.Point(5, 4);
            this.lblStatusLeitor.Name = "lblStatusLeitor";
            this.lblStatusLeitor.Size = new System.Drawing.Size(148, 15);
            this.lblStatusLeitor.TabIndex = 180;
            this.lblStatusLeitor.Text = "Leitor não encontrado";
            // 
            // lbCódigoBarras
            // 
            this.lbCódigoBarras.AutoSize = true;
            this.lbCódigoBarras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbCódigoBarras.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lbCódigoBarras.ForeColor = System.Drawing.Color.White;
            this.lbCódigoBarras.Location = new System.Drawing.Point(214, 1);
            this.lbCódigoBarras.Name = "lbCódigoBarras";
            this.lbCódigoBarras.Size = new System.Drawing.Size(0, 20);
            this.lbCódigoBarras.TabIndex = 183;
            this.lbCódigoBarras.Visible = false;
            // 
            // chkItemVenda
            // 
            this.chkItemVenda.AutoSize = true;
            this.chkItemVenda.Depth = 0;
            this.chkItemVenda.Location = new System.Drawing.Point(447, 140);
            this.chkItemVenda.Margin = new System.Windows.Forms.Padding(0);
            this.chkItemVenda.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkItemVenda.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkItemVenda.Name = "chkItemVenda";
            this.chkItemVenda.ReadOnly = false;
            this.chkItemVenda.Ripple = true;
            this.chkItemVenda.Size = new System.Drawing.Size(100, 37);
            this.chkItemVenda.TabIndex = 186;
            this.chkItemVenda.Text = "p/ Venda";
            this.chkItemVenda.UseVisualStyleBackColor = true;
            this.chkItemVenda.CheckedChanged += new System.EventHandler(this.chkItemVenda_CheckedChanged);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddItem.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnAddItem.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnAddItem.CorTextoBotao = System.Drawing.Color.White;
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItem.Image")));
            this.btnAddItem.Location = new System.Drawing.Point(283, 31);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnAddItem.Size = new System.Drawing.Size(48, 37);
            this.btnAddItem.TabIndex = 176;
            this.btnAddItem.TamanhoBorda = 0;
            this.btnAddItem.TamanhoRaio = 5;
            this.btnAddItem.Text = "   Novo Item";
            this.btnAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
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
            this.btnEncerrarJanelas.Location = new System.Drawing.Point(649, 12);
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
            this.label11.Location = new System.Drawing.Point(63, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 20);
            this.label11.TabIndex = 175;
            this.label11.Text = "Pesquisa rápida de itens";
            this.label11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PesquisaItem_MouseDown);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(5, 31);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 52);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 174;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PesquisaItem_MouseDown);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.lbTitulo.Location = new System.Drawing.Point(62, 31);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(215, 29);
            this.lbTitulo.TabIndex = 173;
            this.lbTitulo.Text = "Pesquisa de Item";
            this.lbTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PesquisaItem_MouseDown);
            // 
            // PesquisaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(693, 548);
            this.Controls.Add(this.pnExterno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PesquisaItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Item de Estoque";
            this.Load += new System.EventHandler(this.PesquisaItem_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PesquisaItem_MouseDown);
            this.pnExterno.ResumeLayout(false);
            this.pnInterno.ResumeLayout(false);
            this.pnInterno.PerformLayout();
            this.modernBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.modernBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.RoundedPanel pnStatus;
        private Componentes.ModernBox pnExterno;
        private Componentes.CustomPanel pnInterno;
        private Componentes.CustomButton btnEncerrarJanelas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbTitulo;
        private Componentes.CustomButton btnAddItem;
        private MaterialSkin.Controls.MaterialCheckbox chkItemVenda;
        private System.Windows.Forms.Panel panel2;
        private Componentes.ModernBox modernBox1;
        private Componentes.RoundedTextBox txtPesquisa;
        private System.Windows.Forms.Label lblStatusLeitor;
        private System.Windows.Forms.Label lbCódigoBarras;
        private Componentes.ModernBox modernBox2;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewImageColumn colImagem;
        private System.Windows.Forms.DataGridViewImageColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoBarras;
    }
}