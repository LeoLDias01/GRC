namespace GRC.UserControls
{
    partial class usrClientes
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usrClientes));
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdentidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtivo = new System.Windows.Forms.DataGridViewImageColumn();
            this.cbRegistros = new System.Windows.Forms.ComboBox();
            this.modernBox2 = new GRC.Componentes.ModernBox();
            this.lbRegistros = new System.Windows.Forms.Label();
            this.modernBox3 = new GRC.Componentes.ModernBox();
            this.btnFiltroAtivos = new GRC.Componentes.CustomButton();
            this.btnFiltroTodos = new GRC.Componentes.CustomButton();
            this.btnFiltroInativos = new GRC.Componentes.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.modernBox1 = new GRC.Componentes.ModernBox();
            this.txtPesquisa = new GRC.Componentes.RoundedTextBox();
            this.btnNovoFornecedor = new GRC.Componentes.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.modernBox2.SuspendLayout();
            this.modernBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.modernBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.ColumnHeadersHeight = 35;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNome,
            this.colIdentidade,
            this.colCidade,
            this.colUf,
            this.colAtivo});
            this.dgvClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.GridColor = System.Drawing.Color.DarkGray;
            this.dgvClientes.Location = new System.Drawing.Point(17, 16);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvClientes.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(965, 435);
            this.dgvClientes.TabIndex = 11;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.FillWeight = 1F;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "Nome";
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colIdentidade
            // 
            this.colIdentidade.DataPropertyName = "Cnpj";
            this.colIdentidade.HeaderText = "CPF/CNPJ";
            this.colIdentidade.Name = "colIdentidade";
            this.colIdentidade.ReadOnly = true;
            // 
            // colCidade
            // 
            this.colCidade.DataPropertyName = "Cidade";
            this.colCidade.HeaderText = "Cidade";
            this.colCidade.Name = "colCidade";
            this.colCidade.ReadOnly = true;
            // 
            // colUf
            // 
            this.colUf.DataPropertyName = "Uf";
            this.colUf.FillWeight = 40F;
            this.colUf.HeaderText = "UF";
            this.colUf.Name = "colUf";
            this.colUf.ReadOnly = true;
            // 
            // colAtivo
            // 
            this.colAtivo.HeaderText = "Ativo";
            this.colAtivo.Name = "colAtivo";
            this.colAtivo.ReadOnly = true;
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
            this.cbRegistros.Location = new System.Drawing.Point(902, 18);
            this.cbRegistros.Name = "cbRegistros";
            this.cbRegistros.Size = new System.Drawing.Size(76, 29);
            this.cbRegistros.TabIndex = 2;
            this.cbRegistros.Text = "10";
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
            this.modernBox2.Controls.Add(this.dgvClientes);
            this.modernBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.modernBox2.Location = new System.Drawing.Point(3, 132);
            this.modernBox2.Name = "modernBox2";
            this.modernBox2.Padding = new System.Windows.Forms.Padding(13);
            this.modernBox2.ShadowAngle = 135;
            this.modernBox2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.modernBox2.ShadowSize = 8;
            this.modernBox2.Size = new System.Drawing.Size(994, 467);
            this.modernBox2.TabIndex = 182;
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
            this.lbRegistros.TabIndex = 1;
            this.lbRegistros.Text = "0 Registros Encontrados";
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
            this.modernBox3.Location = new System.Drawing.Point(0, 605);
            this.modernBox3.Name = "modernBox3";
            this.modernBox3.Padding = new System.Windows.Forms.Padding(15);
            this.modernBox3.ShadowAngle = 135;
            this.modernBox3.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.modernBox3.ShadowSize = 8;
            this.modernBox3.Size = new System.Drawing.Size(1000, 64);
            this.modernBox3.TabIndex = 183;
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnFiltroAtivos);
            this.panel1.Controls.Add(this.btnFiltroTodos);
            this.panel1.Controls.Add(this.btnFiltroInativos);
            this.panel1.Location = new System.Drawing.Point(729, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 57);
            this.panel1.TabIndex = 187;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(6, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(232, 20);
            this.label11.TabIndex = 185;
            this.label11.Text = "Pesquisa de cadastros de clientes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 37);
            this.label10.TabIndex = 184;
            this.label10.Text = "Busca de Clientes";
            // 
            // modernBox1
            // 
            this.modernBox1.BackColor = System.Drawing.Color.Transparent;
            this.modernBox1.BorderColor = System.Drawing.Color.Transparent;
            this.modernBox1.BorderRadius = 20;
            this.modernBox1.BorderSize = 1;
            this.modernBox1.Controls.Add(this.txtPesquisa);
            this.modernBox1.FillColor = System.Drawing.Color.White;
            this.modernBox1.Location = new System.Drawing.Point(10, 76);
            this.modernBox1.Name = "modernBox1";
            this.modernBox1.Padding = new System.Windows.Forms.Padding(8);
            this.modernBox1.ShadowAngle = 50;
            this.modernBox1.ShadowColor = System.Drawing.Color.Gainsboro;
            this.modernBox1.ShadowSize = 3;
            this.modernBox1.Size = new System.Drawing.Size(713, 50);
            this.modernBox1.TabIndex = 181;
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
            this.txtPesquisa.Placeholder = "Busque por Nome ou CPF ou CNPJ...";
            this.txtPesquisa.SelectedText = "";
            this.txtPesquisa.SelectionLength = 0;
            this.txtPesquisa.SelectionStart = 0;
            this.txtPesquisa.Size = new System.Drawing.Size(697, 34);
            this.txtPesquisa.TabIndex = 104;
            this.txtPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPesquisa.TextColor = System.Drawing.Color.Black;
            this.txtPesquisa.TextStyle = System.Drawing.FontStyle.Regular;
            this.txtPesquisa.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtPesquisa.UnderlineSize = 5;
            // 
            // btnNovoFornecedor
            // 
            this.btnNovoFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.btnNovoFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovoFornecedor.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnNovoFornecedor.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.btnNovoFornecedor.CorTextoBotao = System.Drawing.Color.White;
            this.btnNovoFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoFornecedor.FlatAppearance.BorderSize = 0;
            this.btnNovoFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnNovoFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoFornecedor.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnNovoFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnNovoFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoFornecedor.Image")));
            this.btnNovoFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoFornecedor.Location = new System.Drawing.Point(848, 3);
            this.btnNovoFornecedor.Name = "btnNovoFornecedor";
            this.btnNovoFornecedor.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnNovoFornecedor.Size = new System.Drawing.Size(149, 34);
            this.btnNovoFornecedor.TabIndex = 186;
            this.btnNovoFornecedor.TamanhoBorda = 0;
            this.btnNovoFornecedor.TamanhoRaio = 8;
            this.btnNovoFornecedor.Text = "Novo Cliente   ";
            this.btnNovoFornecedor.UseVisualStyleBackColor = false;
            // 
            // usrClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.modernBox2);
            this.Controls.Add(this.btnNovoFornecedor);
            this.Controls.Add(this.modernBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.modernBox1);
            this.Name = "usrClientes";
            this.Size = new System.Drawing.Size(1000, 669);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.modernBox2.ResumeLayout(false);
            this.modernBox3.ResumeLayout(false);
            this.modernBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.modernBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.RoundedTextBox txtPesquisa;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.ComboBox cbRegistros;
        private Componentes.ModernBox modernBox2;
        private System.Windows.Forms.Label lbRegistros;
        private Componentes.CustomButton btnNovoFornecedor;
        private Componentes.ModernBox modernBox3;
        private Componentes.CustomButton btnFiltroAtivos;
        private Componentes.CustomButton btnFiltroTodos;
        private Componentes.CustomButton btnFiltroInativos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private Componentes.ModernBox modernBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdentidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUf;
        private System.Windows.Forms.DataGridViewImageColumn colAtivo;
    }
}
