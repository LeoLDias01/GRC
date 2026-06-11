namespace GRC.UserControls
{
    partial class usrOrdemServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usrOrdemServico));
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.modernBox2 = new GRC.Componentes.ModernBox();
            this.dgvOs = new System.Windows.Forms.DataGridView();
            this.colFavorito = new System.Windows.Forms.DataGridViewImageColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNovaOS = new GRC.Componentes.CustomButton();
            this.cbRegistros = new System.Windows.Forms.ComboBox();
            this.lbRegistros = new System.Windows.Forms.Label();
            this.cbStatus = new GRC.Componentes.ModernComboBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPesquisa = new GRC.Componentes.RoundedTextBox();
            this.modernBox1 = new GRC.Componentes.ModernBox();
            this.modernBox3 = new GRC.Componentes.ModernBox();
            this.modernBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOs)).BeginInit();
            this.modernBox1.SuspendLayout();
            this.modernBox3.SuspendLayout();
            this.SuspendLayout();
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
            // modernBox2
            // 
            this.modernBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modernBox2.BackColor = System.Drawing.Color.Transparent;
            this.modernBox2.BorderColor = System.Drawing.Color.White;
            this.modernBox2.BorderRadius = 12;
            this.modernBox2.BorderSize = 1;
            this.modernBox2.Controls.Add(this.dgvOs);
            this.modernBox2.FillColor = System.Drawing.Color.White;
            this.modernBox2.Location = new System.Drawing.Point(5, 127);
            this.modernBox2.Name = "modernBox2";
            this.modernBox2.Padding = new System.Windows.Forms.Padding(13);
            this.modernBox2.ShadowAngle = 135;
            this.modernBox2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.modernBox2.ShadowSize = 8;
            this.modernBox2.Size = new System.Drawing.Size(980, 469);
            this.modernBox2.TabIndex = 203;
            // 
            // dgvOs
            // 
            this.dgvOs.AllowUserToAddRows = false;
            this.dgvOs.AllowUserToDeleteRows = false;
            this.dgvOs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOs.BackgroundColor = System.Drawing.Color.White;
            this.dgvOs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOs.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvOs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOs.ColumnHeadersHeight = 35;
            this.dgvOs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFavorito,
            this.colId,
            this.colNome,
            this.colStatus,
            this.colData});
            this.dgvOs.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOs.EnableHeadersVisualStyles = false;
            this.dgvOs.GridColor = System.Drawing.Color.DarkGray;
            this.dgvOs.Location = new System.Drawing.Point(17, 13);
            this.dgvOs.MultiSelect = false;
            this.dgvOs.Name = "dgvOs";
            this.dgvOs.ReadOnly = true;
            this.dgvOs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvOs.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvOs.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOs.Size = new System.Drawing.Size(947, 440);
            this.dgvOs.TabIndex = 23;
            // 
            // colFavorito
            // 
            this.colFavorito.DataPropertyName = "Favorito";
            this.colFavorito.FillWeight = 30F;
            this.colFavorito.HeaderText = "";
            this.colFavorito.Image = global::GRC.Properties.Resources.remove;
            this.colFavorito.Name = "colFavorito";
            this.colFavorito.ReadOnly = true;
            this.colFavorito.Visible = false;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.FillWeight = 20.35533F;
            this.colId.HeaderText = "OS";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "NomeCliente";
            this.colNome.FillWeight = 95.16117F;
            this.colNome.HeaderText = "Cliente";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "DescricaoStatus";
            this.colStatus.FillWeight = 95.16117F;
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colData
            // 
            this.colData.DataPropertyName = "DataEntrada";
            this.colData.FillWeight = 95.16117F;
            this.colData.HeaderText = "Entrada";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            // 
            // btnNovaOS
            // 
            this.btnNovaOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.btnNovaOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovaOS.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnNovaOS.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.btnNovaOS.CorTextoBotao = System.Drawing.Color.White;
            this.btnNovaOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovaOS.FlatAppearance.BorderSize = 0;
            this.btnNovaOS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnNovaOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaOS.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnNovaOS.ForeColor = System.Drawing.Color.White;
            this.btnNovaOS.Image = ((System.Drawing.Image)(resources.GetObject("btnNovaOS.Image")));
            this.btnNovaOS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovaOS.Location = new System.Drawing.Point(856, 9);
            this.btnNovaOS.Name = "btnNovaOS";
            this.btnNovaOS.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnNovaOS.Size = new System.Drawing.Size(141, 34);
            this.btnNovaOS.TabIndex = 200;
            this.btnNovaOS.TamanhoBorda = 0;
            this.btnNovaOS.TamanhoRaio = 8;
            this.btnNovaOS.Text = "Nova OS";
            this.btnNovaOS.UseVisualStyleBackColor = false;
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
            this.cbRegistros.Location = new System.Drawing.Point(888, 18);
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
            // cbStatus
            // 
            this.cbStatus.ArrowImage = null;
            this.cbStatus.ArrowSide = GRC.Componentes.ArrowPosition.Right;
            this.cbStatus.BackColor = System.Drawing.Color.White;
            this.cbStatus.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cbStatus.BorderRadius = 16;
            this.cbStatus.BorderSize = 2;
            this.cbStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbStatus.DataSource = null;
            this.cbStatus.DisplayMember = "";
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatus.Location = new System.Drawing.Point(738, 71);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbStatus.PlaceholderText = "Status";
            this.cbStatus.SelectedIndex = -1;
            this.cbStatus.SelectedItem = null;
            this.cbStatus.Size = new System.Drawing.Size(255, 50);
            this.cbStatus.TabIndex = 199;
            this.cbStatus.ValueMember = "";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.lbTitulo.Location = new System.Drawing.Point(7, 1);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(235, 37);
            this.lbTitulo.TabIndex = 201;
            this.lbTitulo.Text = "Ordem de Serviço";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(10, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(215, 20);
            this.label11.TabIndex = 202;
            this.label11.Text = "Pesquisa de Ordem de Serviço";
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
            this.txtPesquisa.Placeholder = "Busque por Nome ou Nº da OS";
            this.txtPesquisa.SelectedText = "";
            this.txtPesquisa.SelectionLength = 0;
            this.txtPesquisa.SelectionStart = 0;
            this.txtPesquisa.Size = new System.Drawing.Size(702, 34);
            this.txtPesquisa.TabIndex = 2;
            this.txtPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPesquisa.TextColor = System.Drawing.Color.Black;
            this.txtPesquisa.TextStyle = System.Drawing.FontStyle.Regular;
            this.txtPesquisa.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtPesquisa.UnderlineSize = 5;
            // 
            // modernBox1
            // 
            this.modernBox1.BackColor = System.Drawing.Color.Transparent;
            this.modernBox1.BorderColor = System.Drawing.Color.Transparent;
            this.modernBox1.BorderRadius = 20;
            this.modernBox1.BorderSize = 1;
            this.modernBox1.Controls.Add(this.txtPesquisa);
            this.modernBox1.FillColor = System.Drawing.Color.White;
            this.modernBox1.Location = new System.Drawing.Point(14, 71);
            this.modernBox1.Name = "modernBox1";
            this.modernBox1.Padding = new System.Windows.Forms.Padding(8);
            this.modernBox1.ShadowAngle = 50;
            this.modernBox1.ShadowColor = System.Drawing.Color.Gainsboro;
            this.modernBox1.ShadowSize = 3;
            this.modernBox1.Size = new System.Drawing.Size(718, 50);
            this.modernBox1.TabIndex = 176;
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
            this.modernBox3.Location = new System.Drawing.Point(3, 602);
            this.modernBox3.Name = "modernBox3";
            this.modernBox3.Padding = new System.Windows.Forms.Padding(15);
            this.modernBox3.ShadowAngle = 135;
            this.modernBox3.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.modernBox3.ShadowSize = 8;
            this.modernBox3.Size = new System.Drawing.Size(986, 64);
            this.modernBox3.TabIndex = 204;
            // 
            // usrOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.modernBox1);
            this.Controls.Add(this.modernBox2);
            this.Controls.Add(this.btnNovaOS);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.modernBox3);
            this.Name = "usrOrdemServico";
            this.Size = new System.Drawing.Size(1000, 669);
            this.modernBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOs)).EndInit();
            this.modernBox1.ResumeLayout(false);
            this.modernBox3.ResumeLayout(false);
            this.modernBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Componentes.ModernBox modernBox2;
        private Componentes.CustomButton btnNovaOS;
        private System.Windows.Forms.ComboBox cbRegistros;
        private System.Windows.Forms.Label lbRegistros;
        private Componentes.ModernComboBox cbStatus;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label label11;
        private Componentes.RoundedTextBox txtPesquisa;
        private Componentes.ModernBox modernBox1;
        private Componentes.ModernBox modernBox3;
        private System.Windows.Forms.DataGridView dgvOs;
        private System.Windows.Forms.DataGridViewImageColumn colFavorito;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewImageColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
    }
}
