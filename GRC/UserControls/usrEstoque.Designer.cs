namespace GRC.UserControls
{
    partial class usrEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usrEstoque));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label11 = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFiltroAtivos = new GRC.Componentes.CustomButton();
            this.btnFiltroTodos = new GRC.Componentes.CustomButton();
            this.btnFiltroInativos = new GRC.Componentes.CustomButton();
            this.lblStatusLeitor = new System.Windows.Forms.Label();
            this.lbCódigoBarras = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.modernBox1 = new GRC.Componentes.ModernBox();
            this.txtPesquisa = new GRC.Componentes.RoundedTextBox();
            this.cbMarca = new GRC.Componentes.ModernComboBox();
            this.modernBox3 = new GRC.Componentes.ModernBox();
            this.cbRegistros = new System.Windows.Forms.ComboBox();
            this.lbRegistros = new System.Windows.Forms.Label();
            this.modernBox2 = new GRC.Componentes.ModernBox();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.colFavorito = new System.Windows.Forms.DataGridViewImageColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImagem = new System.Windows.Forms.DataGridViewImageColumn();
            this.colProduto = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtdMinima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtivo = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnNovoItem = new GRC.Componentes.CustomButton();
            this.cbCategoria = new GRC.Componentes.ModernComboBox();
            this.chkItemVenda = new MaterialSkin.Controls.MaterialCheckbox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.modernBox1.SuspendLayout();
            this.modernBox3.SuspendLayout();
            this.modernBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(6, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(204, 20);
            this.label11.TabIndex = 174;
            this.label11.Text = "Pesquisa de itens do estoque";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.lbTitulo.Location = new System.Drawing.Point(3, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(232, 37);
            this.lbTitulo.TabIndex = 173;
            this.lbTitulo.Text = "Busca no Estoque";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnFiltroAtivos);
            this.panel1.Controls.Add(this.btnFiltroTodos);
            this.panel1.Controls.Add(this.btnFiltroInativos);
            this.panel1.Location = new System.Drawing.Point(889, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 57);
            this.panel1.TabIndex = 179;
            // 
            // btnFiltroAtivos
            // 
            this.btnFiltroAtivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.btnFiltroAtivos.CorBorda = System.Drawing.Color.White;
            this.btnFiltroAtivos.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.btnFiltroAtivos.CorTextoBotao = System.Drawing.Color.White;
            this.btnFiltroAtivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroAtivos.FlatAppearance.BorderSize = 0;
            this.btnFiltroAtivos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnFiltroAtivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroAtivos.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnFiltroAtivos.ForeColor = System.Drawing.Color.White;
            this.btnFiltroAtivos.Location = new System.Drawing.Point(79, 7);
            this.btnFiltroAtivos.Name = "btnFiltroAtivos";
            this.btnFiltroAtivos.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnFiltroAtivos.Size = new System.Drawing.Size(103, 43);
            this.btnFiltroAtivos.TabIndex = 9;
            this.btnFiltroAtivos.TamanhoBorda = 5;
            this.btnFiltroAtivos.TamanhoRaio = 20;
            this.btnFiltroAtivos.Text = "   Ativo";
            this.btnFiltroAtivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltroAtivos.UseVisualStyleBackColor = false;
            // 
            // btnFiltroTodos
            // 
            this.btnFiltroTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.btnFiltroTodos.CorBorda = System.Drawing.Color.White;
            this.btnFiltroTodos.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.btnFiltroTodos.CorTextoBotao = System.Drawing.Color.White;
            this.btnFiltroTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroTodos.FlatAppearance.BorderSize = 0;
            this.btnFiltroTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnFiltroTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroTodos.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnFiltroTodos.ForeColor = System.Drawing.Color.White;
            this.btnFiltroTodos.Location = new System.Drawing.Point(3, 7);
            this.btnFiltroTodos.Name = "btnFiltroTodos";
            this.btnFiltroTodos.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnFiltroTodos.Size = new System.Drawing.Size(159, 43);
            this.btnFiltroTodos.TabIndex = 6;
            this.btnFiltroTodos.TamanhoBorda = 5;
            this.btnFiltroTodos.TamanhoRaio = 20;
            this.btnFiltroTodos.Text = "Todos";
            this.btnFiltroTodos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltroTodos.UseVisualStyleBackColor = false;
            // 
            // btnFiltroInativos
            // 
            this.btnFiltroInativos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.btnFiltroInativos.CorBorda = System.Drawing.Color.White;
            this.btnFiltroInativos.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.btnFiltroInativos.CorTextoBotao = System.Drawing.Color.White;
            this.btnFiltroInativos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroInativos.FlatAppearance.BorderSize = 0;
            this.btnFiltroInativos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnFiltroInativos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroInativos.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnFiltroInativos.ForeColor = System.Drawing.Color.White;
            this.btnFiltroInativos.Location = new System.Drawing.Point(91, 7);
            this.btnFiltroInativos.Name = "btnFiltroInativos";
            this.btnFiltroInativos.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnFiltroInativos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFiltroInativos.Size = new System.Drawing.Size(168, 43);
            this.btnFiltroInativos.TabIndex = 8;
            this.btnFiltroInativos.TamanhoBorda = 5;
            this.btnFiltroInativos.TamanhoRaio = 20;
            this.btnFiltroInativos.Text = "Inativo";
            this.btnFiltroInativos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltroInativos.UseVisualStyleBackColor = false;
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
            this.lbCódigoBarras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbCódigoBarras.Location = new System.Drawing.Point(190, 70);
            this.lbCódigoBarras.Name = "lbCódigoBarras";
            this.lbCódigoBarras.Size = new System.Drawing.Size(0, 20);
            this.lbCódigoBarras.TabIndex = 183;
            this.lbCódigoBarras.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.modernBox1);
            this.panel2.Controls.Add(this.lblStatusLeitor);
            this.panel2.Location = new System.Drawing.Point(4, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 76);
            this.panel2.TabIndex = 180;
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
            this.txtPesquisa.Size = new System.Drawing.Size(467, 34);
            this.txtPesquisa.TabIndex = 2;
            this.txtPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPesquisa.TextColor = System.Drawing.Color.Black;
            this.txtPesquisa.TextStyle = System.Drawing.FontStyle.Regular;
            this.txtPesquisa.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtPesquisa.UnderlineSize = 5;
            // 
            // cbMarca
            // 
            this.cbMarca.ArrowImage = null;
            this.cbMarca.ArrowSide = GRC.Componentes.ArrowPosition.Right;
            this.cbMarca.BackColor = System.Drawing.Color.White;
            this.cbMarca.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cbMarca.BorderRadius = 16;
            this.cbMarca.BorderSize = 4;
            this.cbMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMarca.DataSource = null;
            this.cbMarca.DisplayMember = "";
            this.cbMarca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMarca.Location = new System.Drawing.Point(493, 93);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.PlaceholderColor = System.Drawing.Color.DimGray;
            this.cbMarca.PlaceholderText = "Selecione a Marca";
            this.cbMarca.SelectedIndex = -1;
            this.cbMarca.SelectedItem = null;
            this.cbMarca.Size = new System.Drawing.Size(241, 50);
            this.cbMarca.TabIndex = 0;
            this.cbMarca.ValueMember = "";
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
            this.modernBox3.Location = new System.Drawing.Point(0, 615);
            this.modernBox3.Name = "modernBox3";
            this.modernBox3.Padding = new System.Windows.Forms.Padding(15);
            this.modernBox3.ShadowAngle = 135;
            this.modernBox3.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.modernBox3.ShadowSize = 8;
            this.modernBox3.Size = new System.Drawing.Size(1154, 64);
            this.modernBox3.TabIndex = 178;
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
            this.modernBox2.Controls.Add(this.dgvItens);
            this.modernBox2.FillColor = System.Drawing.Color.White;
            this.modernBox2.Location = new System.Drawing.Point(3, 149);
            this.modernBox2.Name = "modernBox2";
            this.modernBox2.Padding = new System.Windows.Forms.Padding(13);
            this.modernBox2.ShadowAngle = 135;
            this.modernBox2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.modernBox2.ShadowSize = 8;
            this.modernBox2.Size = new System.Drawing.Size(1148, 460);
            this.modernBox2.TabIndex = 177;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItens.ColumnHeadersHeight = 35;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFavorito,
            this.colId,
            this.colImagem,
            this.colProduto,
            this.colDescricao,
            this.colCodigoBarras,
            this.colFabricante,
            this.colCategoria,
            this.colQtdMinima,
            this.colQtd,
            this.colAtivo});
            this.dgvItens.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItens.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvItens.EnableHeadersVisualStyles = false;
            this.dgvItens.GridColor = System.Drawing.Color.Silver;
            this.dgvItens.Location = new System.Drawing.Point(17, 16);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvItens.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvItens.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(1115, 428);
            this.dgvItens.TabIndex = 4;
            // 
            // colFavorito
            // 
            this.colFavorito.DataPropertyName = "Favorito";
            this.colFavorito.FillWeight = 6.146037F;
            this.colFavorito.HeaderText = "";
            this.colFavorito.Name = "colFavorito";
            this.colFavorito.ReadOnly = true;
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
            this.colCodigoBarras.HeaderText = "Código de Barras";
            this.colCodigoBarras.Name = "colCodigoBarras";
            this.colCodigoBarras.ReadOnly = true;
            this.colCodigoBarras.Visible = false;
            // 
            // colFabricante
            // 
            this.colFabricante.DataPropertyName = "DescricaoFabricante";
            this.colFabricante.FillWeight = 25.27785F;
            this.colFabricante.HeaderText = "Marca";
            this.colFabricante.Name = "colFabricante";
            this.colFabricante.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.DataPropertyName = "DescricaoCategoria";
            this.colCategoria.FillWeight = 16.20491F;
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // colQtdMinima
            // 
            this.colQtdMinima.HeaderText = "Mínima";
            this.colQtdMinima.Name = "colQtdMinima";
            this.colQtdMinima.ReadOnly = true;
            this.colQtdMinima.Visible = false;
            // 
            // colQtd
            // 
            this.colQtd.DataPropertyName = "Quantidade";
            this.colQtd.FillWeight = 10.428F;
            this.colQtd.HeaderText = "Qtd";
            this.colQtd.Name = "colQtd";
            this.colQtd.ReadOnly = true;
            // 
            // colAtivo
            // 
            this.colAtivo.DataPropertyName = "Ativo";
            this.colAtivo.FillWeight = 20.67864F;
            this.colAtivo.HeaderText = "Ativo";
            this.colAtivo.Image = global::GRC.Properties.Resources.Marca_Ativo;
            this.colAtivo.Name = "colAtivo";
            this.colAtivo.ReadOnly = true;
            this.colAtivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "ItemVenda";
            this.dataGridViewImageColumn1.FillWeight = 21.22982F;
            this.dataGridViewImageColumn1.HeaderText = "Item/Venda";
            this.dataGridViewImageColumn1.Image = global::GRC.Properties.Resources.Marca_Venda;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 159;
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
            // btnNovoItem
            // 
            this.btnNovoItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.btnNovoItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovoItem.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnNovoItem.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.btnNovoItem.CorTextoBotao = System.Drawing.Color.White;
            this.btnNovoItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoItem.FlatAppearance.BorderSize = 0;
            this.btnNovoItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnNovoItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoItem.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnNovoItem.ForeColor = System.Drawing.Color.White;
            this.btnNovoItem.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoItem.Image")));
            this.btnNovoItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoItem.Location = new System.Drawing.Point(242, 4);
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnNovoItem.Size = new System.Drawing.Size(179, 34);
            this.btnNovoItem.TabIndex = 1;
            this.btnNovoItem.TamanhoBorda = 0;
            this.btnNovoItem.TamanhoRaio = 8;
            this.btnNovoItem.Text = "Novo Item";
            this.btnNovoItem.UseVisualStyleBackColor = false;
            // 
            // cbCategoria
            // 
            this.cbCategoria.ArrowImage = null;
            this.cbCategoria.ArrowSide = GRC.Componentes.ArrowPosition.Right;
            this.cbCategoria.BackColor = System.Drawing.Color.White;
            this.cbCategoria.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cbCategoria.BorderRadius = 16;
            this.cbCategoria.BorderSize = 4;
            this.cbCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCategoria.DataSource = null;
            this.cbCategoria.DisplayMember = "";
            this.cbCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCategoria.Location = new System.Drawing.Point(740, 93);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.PlaceholderColor = System.Drawing.Color.DimGray;
            this.cbCategoria.PlaceholderText = "Selecione a Categoria";
            this.cbCategoria.SelectedIndex = -1;
            this.cbCategoria.SelectedItem = null;
            this.cbCategoria.Size = new System.Drawing.Size(241, 50);
            this.cbCategoria.TabIndex = 184;
            this.cbCategoria.ValueMember = "";
            // 
            // chkItemVenda
            // 
            this.chkItemVenda.AutoSize = true;
            this.chkItemVenda.Depth = 0;
            this.chkItemVenda.Location = new System.Drawing.Point(984, 101);
            this.chkItemVenda.Margin = new System.Windows.Forms.Padding(0);
            this.chkItemVenda.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkItemVenda.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkItemVenda.Name = "chkItemVenda";
            this.chkItemVenda.ReadOnly = false;
            this.chkItemVenda.Ripple = true;
            this.chkItemVenda.Size = new System.Drawing.Size(136, 37);
            this.chkItemVenda.TabIndex = 185;
            this.chkItemVenda.Text = "Item de Venda";
            this.chkItemVenda.UseVisualStyleBackColor = true;
            // 
            // usrEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.chkItemVenda);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbCódigoBarras);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.modernBox3);
            this.Controls.Add(this.modernBox2);
            this.Controls.Add(this.btnNovoItem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbTitulo);
            this.Name = "usrEstoque";
            this.Size = new System.Drawing.Size(1154, 677);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.modernBox1.ResumeLayout(false);
            this.modernBox3.ResumeLayout(false);
            this.modernBox3.PerformLayout();
            this.modernBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.CustomButton btnNovoItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panel1;
        private Componentes.CustomButton btnFiltroTodos;
        private Componentes.CustomButton btnFiltroInativos;
        private Componentes.ModernBox modernBox3;
        private System.Windows.Forms.ComboBox cbRegistros;
        private System.Windows.Forms.Label lbRegistros;
        private Componentes.ModernBox modernBox2;
        private Componentes.ModernBox modernBox1;
        private Componentes.RoundedTextBox txtPesquisa;
        private System.Windows.Forms.Label lblStatusLeitor;
        private System.Windows.Forms.Label lbCódigoBarras;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewImageColumn colFavorito;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewImageColumn colImagem;
        private System.Windows.Forms.DataGridViewImageColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtdMinima;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtd;
        private System.Windows.Forms.DataGridViewImageColumn colAtivo;
        private Componentes.CustomButton btnFiltroAtivos;
        private Componentes.ModernComboBox cbMarca;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Componentes.ModernComboBox cbCategoria;
        private MaterialSkin.Controls.MaterialCheckbox chkItemVenda;
    }
}
