namespace GRC.UserControls
{
    partial class usrMovimento
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>


        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usrMovimento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.modernBox1 = new GRC.Componentes.ModernBox();
            this.txtPesquisa = new GRC.Componentes.RoundedTextBox();
            this.lblStatusLeitor = new System.Windows.Forms.Label();
            this.lbCódigoBarras = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbTipoMovimento = new GRC.Componentes.ModernComboBox();
            this.modernBox5 = new GRC.Componentes.ModernBox();
            this.txtDataFinal = new GRC.Componentes.RoundedTextBox();
            this.modernBox4 = new GRC.Componentes.ModernBox();
            this.txtDataInicial = new GRC.Componentes.RoundedTextBox();
            this.modernBox3 = new GRC.Componentes.ModernBox();
            this.cbRegistros = new System.Windows.Forms.ComboBox();
            this.lbRegistros = new System.Windows.Forms.Label();
            this.modernBox2 = new GRC.Componentes.ModernBox();
            this.dgvMovimentacoes = new System.Windows.Forms.DataGridView();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnMovimentar = new GRC.Componentes.CustomButton();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2.SuspendLayout();
            this.modernBox1.SuspendLayout();
            this.modernBox5.SuspendLayout();
            this.modernBox4.SuspendLayout();
            this.modernBox3.SuspendLayout();
            this.modernBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.modernBox1);
            this.panel2.Controls.Add(this.lblStatusLeitor);
            this.panel2.Controls.Add(this.lbCódigoBarras);
            this.panel2.Location = new System.Drawing.Point(4, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 76);
            this.panel2.TabIndex = 193;
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
            this.modernBox1.Size = new System.Drawing.Size(483, 50);
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
            this.txtPesquisa.Size = new System.Drawing.Size(467, 34);
            this.txtPesquisa.TabIndex = 2;
            this.txtPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPesquisa.TextColor = System.Drawing.Color.Black;
            this.txtPesquisa.TextStyle = System.Drawing.FontStyle.Regular;
            this.txtPesquisa.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtPesquisa.UnderlineSize = 5;
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
            this.lbCódigoBarras.Location = new System.Drawing.Point(207, 1);
            this.lbCódigoBarras.Name = "lbCódigoBarras";
            this.lbCódigoBarras.Size = new System.Drawing.Size(0, 20);
            this.lbCódigoBarras.TabIndex = 194;
            this.lbCódigoBarras.Visible = false;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.lbTitulo.Location = new System.Drawing.Point(41, -1);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(212, 37);
            this.lbTitulo.TabIndex = 188;
            this.lbTitulo.Text = "Movimentações";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(8, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(279, 20);
            this.label11.TabIndex = 189;
            this.label11.Text = "Pesquisa de movimentações do estoque";
            // 
            // cbTipoMovimento
            // 
            this.cbTipoMovimento.ArrowImage = null;
            this.cbTipoMovimento.ArrowSide = GRC.Componentes.ArrowPosition.Right;
            this.cbTipoMovimento.BackColor = System.Drawing.Color.White;
            this.cbTipoMovimento.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cbTipoMovimento.BorderRadius = 16;
            this.cbTipoMovimento.BorderSize = 2;
            this.cbTipoMovimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTipoMovimento.DataSource = null;
            this.cbTipoMovimento.DisplayMember = "";
            this.cbTipoMovimento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTipoMovimento.Location = new System.Drawing.Point(831, 92);
            this.cbTipoMovimento.Name = "cbTipoMovimento";
            this.cbTipoMovimento.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbTipoMovimento.PlaceholderText = "Selecione o tipo de movimento";
            this.cbTipoMovimento.SelectedIndex = -1;
            this.cbTipoMovimento.SelectedItem = null;
            this.cbTipoMovimento.Size = new System.Drawing.Size(320, 50);
            this.cbTipoMovimento.TabIndex = 185;
            this.cbTipoMovimento.ValueMember = "";
            // 
            // modernBox5
            // 
            this.modernBox5.BackColor = System.Drawing.Color.Transparent;
            this.modernBox5.BorderColor = System.Drawing.Color.Transparent;
            this.modernBox5.BorderRadius = 20;
            this.modernBox5.BorderSize = 1;
            this.modernBox5.Controls.Add(this.txtDataFinal);
            this.modernBox5.FillColor = System.Drawing.Color.White;
            this.modernBox5.Location = new System.Drawing.Point(662, 92);
            this.modernBox5.Name = "modernBox5";
            this.modernBox5.Padding = new System.Windows.Forms.Padding(8);
            this.modernBox5.ShadowAngle = 50;
            this.modernBox5.ShadowColor = System.Drawing.Color.Gainsboro;
            this.modernBox5.ShadowSize = 3;
            this.modernBox5.Size = new System.Drawing.Size(163, 50);
            this.modernBox5.TabIndex = 178;
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.BackColor = System.Drawing.Color.Transparent;
            this.txtDataFinal.BorderColor = System.Drawing.Color.White;
            this.txtDataFinal.BorderRadius = 12;
            this.txtDataFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDataFinal.FillColor = System.Drawing.Color.White;
            this.txtDataFinal.Icon = ((System.Drawing.Image)(resources.GetObject("txtDataFinal.Icon")));
            this.txtDataFinal.IconPosition = GRC.Componentes.RoundedTextBox.IconPositionEnum.Left;
            this.txtDataFinal.Location = new System.Drawing.Point(8, 8);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Padding = new System.Windows.Forms.Padding(10);
            this.txtDataFinal.Placeholder = "Data Final";
            this.txtDataFinal.SelectedText = "";
            this.txtDataFinal.SelectionLength = 0;
            this.txtDataFinal.SelectionStart = 0;
            this.txtDataFinal.Size = new System.Drawing.Size(147, 34);
            this.txtDataFinal.TabIndex = 2;
            this.txtDataFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDataFinal.TextColor = System.Drawing.Color.Black;
            this.txtDataFinal.TextStyle = System.Drawing.FontStyle.Regular;
            this.txtDataFinal.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtDataFinal.UnderlineSize = 5;
            // 
            // modernBox4
            // 
            this.modernBox4.BackColor = System.Drawing.Color.Transparent;
            this.modernBox4.BorderColor = System.Drawing.Color.Transparent;
            this.modernBox4.BorderRadius = 20;
            this.modernBox4.BorderSize = 1;
            this.modernBox4.Controls.Add(this.txtDataInicial);
            this.modernBox4.FillColor = System.Drawing.Color.White;
            this.modernBox4.Location = new System.Drawing.Point(493, 92);
            this.modernBox4.Name = "modernBox4";
            this.modernBox4.Padding = new System.Windows.Forms.Padding(8);
            this.modernBox4.ShadowAngle = 50;
            this.modernBox4.ShadowColor = System.Drawing.Color.Gainsboro;
            this.modernBox4.ShadowSize = 3;
            this.modernBox4.Size = new System.Drawing.Size(163, 50);
            this.modernBox4.TabIndex = 177;
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.BackColor = System.Drawing.Color.Transparent;
            this.txtDataInicial.BorderColor = System.Drawing.Color.White;
            this.txtDataInicial.BorderRadius = 12;
            this.txtDataInicial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDataInicial.FillColor = System.Drawing.Color.White;
            this.txtDataInicial.Icon = ((System.Drawing.Image)(resources.GetObject("txtDataInicial.Icon")));
            this.txtDataInicial.IconPosition = GRC.Componentes.RoundedTextBox.IconPositionEnum.Left;
            this.txtDataInicial.Location = new System.Drawing.Point(8, 8);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Padding = new System.Windows.Forms.Padding(10);
            this.txtDataInicial.Placeholder = "Data Inicial";
            this.txtDataInicial.SelectedText = "";
            this.txtDataInicial.SelectionLength = 0;
            this.txtDataInicial.SelectionStart = 0;
            this.txtDataInicial.Size = new System.Drawing.Size(147, 34);
            this.txtDataInicial.TabIndex = 2;
            this.txtDataInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDataInicial.TextColor = System.Drawing.Color.Black;
            this.txtDataInicial.TextStyle = System.Drawing.FontStyle.Regular;
            this.txtDataInicial.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtDataInicial.UnderlineSize = 5;
            // 
            // modernBox3
            // 
            this.modernBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modernBox3.BackColor = System.Drawing.Color.Transparent;
            this.modernBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.modernBox3.BorderRadius = 10;
            this.modernBox3.BorderSize = 3;
            this.modernBox3.Controls.Add(this.cbRegistros);
            this.modernBox3.Controls.Add(this.lbRegistros);
            this.modernBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.modernBox3.Location = new System.Drawing.Point(0, 614);
            this.modernBox3.Name = "modernBox3";
            this.modernBox3.Padding = new System.Windows.Forms.Padding(15);
            this.modernBox3.ShadowAngle = 135;
            this.modernBox3.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.modernBox3.ShadowSize = 8;
            this.modernBox3.Size = new System.Drawing.Size(1154, 64);
            this.modernBox3.TabIndex = 191;
            // 
            // cbRegistros
            // 
            this.cbRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRegistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbRegistros.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRegistros.FormattingEnabled = true;
            this.cbRegistros.Items.AddRange(new object[] {
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
            this.cbRegistros.Location = new System.Drawing.Point(1056, 18);
            this.cbRegistros.Name = "cbRegistros";
            this.cbRegistros.Size = new System.Drawing.Size(76, 29);
            this.cbRegistros.TabIndex = 9;
            this.cbRegistros.Text = "10";
            // 
            // lbRegistros
            // 
            this.lbRegistros.AutoSize = true;
            this.lbRegistros.BackColor = System.Drawing.Color.Transparent;
            this.lbRegistros.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbRegistros.Font = new System.Drawing.Font("Segoe UI Symbol", 13F, System.Drawing.FontStyle.Bold);
            this.lbRegistros.ForeColor = System.Drawing.Color.White;
            this.lbRegistros.Location = new System.Drawing.Point(15, 15);
            this.lbRegistros.Name = "lbRegistros";
            this.lbRegistros.Padding = new System.Windows.Forms.Padding(5);
            this.lbRegistros.Size = new System.Drawing.Size(238, 35);
            this.lbRegistros.TabIndex = 10;
            this.lbRegistros.Text = "0 Registros Encontrados";
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
            this.modernBox2.Controls.Add(this.dgvMovimentacoes);
            this.modernBox2.FillColor = System.Drawing.Color.White;
            this.modernBox2.Location = new System.Drawing.Point(3, 148);
            this.modernBox2.Name = "modernBox2";
            this.modernBox2.Padding = new System.Windows.Forms.Padding(13);
            this.modernBox2.ShadowAngle = 135;
            this.modernBox2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.modernBox2.ShadowSize = 8;
            this.modernBox2.Size = new System.Drawing.Size(1148, 460);
            this.modernBox2.TabIndex = 190;
            // 
            // dgvMovimentacoes
            // 
            this.dgvMovimentacoes.AllowUserToAddRows = false;
            this.dgvMovimentacoes.AllowUserToDeleteRows = false;
            this.dgvMovimentacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMovimentacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovimentacoes.BackgroundColor = System.Drawing.Color.White;
            this.dgvMovimentacoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMovimentacoes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvMovimentacoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovimentacoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMovimentacoes.ColumnHeadersHeight = 35;
            this.dgvMovimentacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colData,
            this.colId,
            this.colTipo,
            this.colItem,
            this.colQtd,
            this.colMotivo,
            this.colExcluir});
            this.dgvMovimentacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMovimentacoes.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMovimentacoes.EnableHeadersVisualStyles = false;
            this.dgvMovimentacoes.GridColor = System.Drawing.Color.Silver;
            this.dgvMovimentacoes.Location = new System.Drawing.Point(17, 16);
            this.dgvMovimentacoes.MultiSelect = false;
            this.dgvMovimentacoes.Name = "dgvMovimentacoes";
            this.dgvMovimentacoes.ReadOnly = true;
            this.dgvMovimentacoes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMovimentacoes.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvMovimentacoes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMovimentacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovimentacoes.Size = new System.Drawing.Size(1115, 428);
            this.dgvMovimentacoes.TabIndex = 4;
            // 
            // colData
            // 
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // colItem
            // 
            this.colItem.HeaderText = "Item";
            this.colItem.Name = "colItem";
            this.colItem.ReadOnly = true;
            // 
            // colQtd
            // 
            this.colQtd.HeaderText = "Qtd";
            this.colQtd.Name = "colQtd";
            this.colQtd.ReadOnly = true;
            // 
            // colMotivo
            // 
            this.colMotivo.HeaderText = "Motivo";
            this.colMotivo.Name = "colMotivo";
            this.colMotivo.ReadOnly = true;
            // 
            // colExcluir
            // 
            this.colExcluir.HeaderText = "";
            this.colExcluir.Image = global::GRC.Properties.Resources.trash;
            this.colExcluir.Name = "colExcluir";
            this.colExcluir.ReadOnly = true;
            this.colExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colExcluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "ItemVenda";
            this.dataGridViewImageColumn1.FillWeight = 21.22982F;
            this.dataGridViewImageColumn1.HeaderText = "Item/Venda";
            this.dataGridViewImageColumn1.Image = global::GRC.Properties.Resources.Marca_Venda;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 159;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(4, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 196;
            this.pictureBox3.TabStop = false;
            // 
            // btnMovimentar
            // 
            this.btnMovimentar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.btnMovimentar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMovimentar.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnMovimentar.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.btnMovimentar.CorTextoBotao = System.Drawing.Color.White;
            this.btnMovimentar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovimentar.FlatAppearance.BorderSize = 0;
            this.btnMovimentar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnMovimentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovimentar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnMovimentar.ForeColor = System.Drawing.Color.White;
            this.btnMovimentar.Image = ((System.Drawing.Image)(resources.GetObject("btnMovimentar.Image")));
            this.btnMovimentar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMovimentar.Location = new System.Drawing.Point(972, 7);
            this.btnMovimentar.Name = "btnMovimentar";
            this.btnMovimentar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnMovimentar.Size = new System.Drawing.Size(179, 34);
            this.btnMovimentar.TabIndex = 186;
            this.btnMovimentar.TamanhoBorda = 0;
            this.btnMovimentar.TamanhoRaio = 8;
            this.btnMovimentar.Text = "Movimentar";
            this.btnMovimentar.UseVisualStyleBackColor = false;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "Ativo";
            this.dataGridViewImageColumn2.FillWeight = 20.67864F;
            this.dataGridViewImageColumn2.HeaderText = "Ativo";
            this.dataGridViewImageColumn2.Image = global::GRC.Properties.Resources.Marca_Ativo;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 155;
            // 
            // usrMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.cbTipoMovimento);
            this.Controls.Add(this.modernBox5);
            this.Controls.Add(this.modernBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.modernBox3);
            this.Controls.Add(this.modernBox2);
            this.Controls.Add(this.btnMovimentar);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.label11);
            this.Name = "usrMovimento";
            this.Size = new System.Drawing.Size(1154, 677);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.modernBox1.ResumeLayout(false);
            this.modernBox5.ResumeLayout(false);
            this.modernBox4.ResumeLayout(false);
            this.modernBox3.ResumeLayout(false);
            this.modernBox3.PerformLayout();
            this.modernBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Componentes.ModernComboBox cbTipoMovimento;
        private System.Windows.Forms.Panel panel2;
        private Componentes.ModernBox modernBox1;
        private Componentes.RoundedTextBox txtPesquisa;
        private System.Windows.Forms.Label lblStatusLeitor;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Componentes.ModernBox modernBox3;
        private System.Windows.Forms.ComboBox cbRegistros;
        private System.Windows.Forms.Label lbRegistros;
        private System.Windows.Forms.Label lbCódigoBarras;
        private Componentes.ModernBox modernBox2;
        private System.Windows.Forms.DataGridView dgvMovimentacoes;
        private Componentes.CustomButton btnMovimentar;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Componentes.ModernBox modernBox4;
        private Componentes.RoundedTextBox txtDataInicial;
        private Componentes.ModernBox modernBox5;
        private Componentes.RoundedTextBox txtDataFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMotivo;
        private System.Windows.Forms.DataGridViewImageColumn colExcluir;
    }
}
