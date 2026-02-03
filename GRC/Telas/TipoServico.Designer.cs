namespace GRC.Telas
{
    partial class TipoServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoServico));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalvar = new GRC.Componentes.CustomButton();
            this.customPanel1 = new GRC.Componentes.CustomPanel();
            this.lbRegistros = new System.Windows.Forms.Label();
            this.dgvTipo = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.customPanel2 = new GRC.Componentes.CustomPanel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCategoria = new MaterialSkin.Controls.MaterialTextBox();
            this.roundedPanel1 = new GRC.Componentes.RoundedPanel();
            this.roundedPanel2 = new GRC.Componentes.RoundedPanel();
            this.roundedPanel3 = new GRC.Componentes.RoundedPanel();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipo)).BeginInit();
            this.customPanel2.SuspendLayout();
            this.SuspendLayout();
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
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(376, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSalvar.Size = new System.Drawing.Size(87, 37);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.TamanhoBorda = 0;
            this.btnSalvar.TamanhoRaio = 5;
            this.btnSalvar.Text = " Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.customPanel1.Controls.Add(this.lbRegistros);
            this.customPanel1.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.customPanel1.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.customPanel1.CorTextoBotao = System.Drawing.Color.White;
            this.customPanel1.ForeColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(12, 484);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(451, 37);
            this.customPanel1.TabIndex = 25;
            this.customPanel1.TamanhoBorda = 0;
            this.customPanel1.TamanhoRaio = 10;
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
            // dgvTipo
            // 
            this.dgvTipo.AllowUserToAddRows = false;
            this.dgvTipo.AllowUserToDeleteRows = false;
            this.dgvTipo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipo.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvTipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTipo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTipo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvTipo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTipo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTipo.ColumnHeadersHeight = 35;
            this.dgvTipo.ColumnHeadersVisible = false;
            this.dgvTipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colDescricao,
            this.colExcluir});
            this.dgvTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTipo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTipo.EnableHeadersVisualStyles = false;
            this.dgvTipo.GridColor = System.Drawing.Color.Black;
            this.dgvTipo.Location = new System.Drawing.Point(12, 173);
            this.dgvTipo.MultiSelect = false;
            this.dgvTipo.Name = "dgvTipo";
            this.dgvTipo.ReadOnly = true;
            this.dgvTipo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTipo.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTipo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipo.Size = new System.Drawing.Size(451, 304);
            this.dgvTipo.TabIndex = 23;
            this.dgvTipo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipo_CellContentClick);
            this.dgvTipo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipo_CellDoubleClick);
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
            // colDescricao
            // 
            this.colDescricao.DataPropertyName = "Descricao";
            this.colDescricao.FillWeight = 250F;
            this.colDescricao.HeaderText = "Categorias";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            // 
            // colExcluir
            // 
            this.colExcluir.FillWeight = 45F;
            this.colExcluir.HeaderText = "";
            this.colExcluir.Image = ((System.Drawing.Image)(resources.GetObject("colExcluir.Image")));
            this.colExcluir.Name = "colExcluir";
            this.colExcluir.ReadOnly = true;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.AliceBlue;
            this.customPanel2.Controls.Add(this.materialLabel2);
            this.customPanel2.Controls.Add(this.txtCategoria);
            this.customPanel2.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.customPanel2.CorBotao = System.Drawing.Color.AliceBlue;
            this.customPanel2.CorTextoBotao = System.Drawing.Color.White;
            this.customPanel2.ForeColor = System.Drawing.Color.White;
            this.customPanel2.Location = new System.Drawing.Point(12, 55);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(451, 112);
            this.customPanel2.TabIndex = 22;
            this.customPanel2.TamanhoBorda = 0;
            this.customPanel2.TamanhoRaio = 20;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.SlateGray;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.ForeColor = System.Drawing.Color.Black;
            this.materialLabel2.Location = new System.Drawing.Point(22, 16);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(138, 24);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Tipo de Serviço";
            // 
            // txtCategoria
            // 
            this.txtCategoria.AcceptsTab = true;
            this.txtCategoria.AnimateReadOnly = false;
            this.txtCategoria.AutoWordSelection = true;
            this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategoria.Depth = 0;
            this.txtCategoria.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCategoria.Hint = "Informe o serviço";
            this.txtCategoria.LeadingIcon = null;
            this.txtCategoria.LeaveOnEnterKey = true;
            this.txtCategoria.Location = new System.Drawing.Point(16, 59);
            this.txtCategoria.MaxLength = 80;
            this.txtCategoria.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCategoria.Multiline = false;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(420, 50);
            this.txtCategoria.TabIndex = 10;
            this.txtCategoria.Text = "";
            this.txtCategoria.TrailingIcon = null;
            this.txtCategoria.UseAccent = false;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.Color1 = System.Drawing.Color.DarkGoldenrod;
            this.roundedPanel1.Color2 = System.Drawing.Color.White;
            this.roundedPanel1.CornerRadius = 10;
            this.roundedPanel1.GradientAngle = 45F;
            this.roundedPanel1.Location = new System.Drawing.Point(12, 12);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(114, 37);
            this.roundedPanel1.TabIndex = 21;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel2.Color1 = System.Drawing.Color.DarkGoldenrod;
            this.roundedPanel2.Color2 = System.Drawing.Color.White;
            this.roundedPanel2.CornerRadius = 10;
            this.roundedPanel2.GradientAngle = 45F;
            this.roundedPanel2.Location = new System.Drawing.Point(132, 12);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(114, 37);
            this.roundedPanel2.TabIndex = 22;
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel3.Color1 = System.Drawing.Color.DarkGoldenrod;
            this.roundedPanel3.Color2 = System.Drawing.Color.White;
            this.roundedPanel3.CornerRadius = 10;
            this.roundedPanel3.GradientAngle = 45F;
            this.roundedPanel3.Location = new System.Drawing.Point(252, 12);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(114, 37);
            this.roundedPanel3.TabIndex = 22;
            // 
            // TipoServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(475, 533);
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.dgvTipo);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TipoServico";
            this.Text = "Tipo de Serviço";
            this.Load += new System.EventHandler(this.TipoServico_Load);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipo)).EndInit();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.CustomButton btnSalvar;
        private Componentes.CustomPanel customPanel1;
        private System.Windows.Forms.Label lbRegistros;
        private System.Windows.Forms.DataGridView dgvTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewImageColumn colExcluir;
        private Componentes.CustomPanel customPanel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtCategoria;
        private Componentes.RoundedPanel roundedPanel1;
        private Componentes.RoundedPanel roundedPanel2;
        private Componentes.RoundedPanel roundedPanel3;
    }
}