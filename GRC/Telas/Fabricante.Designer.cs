namespace GRC.Telas
{
    partial class Fabricante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fabricante));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.painelRadius1 = new GRC.Componentes.PainelRadius();
            this.dgvTipo = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnClose = new GRC.Componentes.CustomButton();
            this.roundedPanel1 = new GRC.Componentes.RoundedPanel();
            this.customPanel1 = new GRC.Componentes.CustomPanel();
            this.lbRegistros = new System.Windows.Forms.Label();
            this.customPanel2 = new GRC.Componentes.CustomPanel();
            this.txtDescricao = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.painelRadius1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipo)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 45F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Fabricante";
            // 
            // painelRadius1
            // 
            this.painelRadius1.BackColor = System.Drawing.Color.AliceBlue;
            this.painelRadius1.BorderColor = System.Drawing.Color.White;
            this.painelRadius1.Controls.Add(this.dgvTipo);
            this.painelRadius1.Location = new System.Drawing.Point(16, 142);
            this.painelRadius1.Name = "painelRadius1";
            this.painelRadius1.Radius = 30;
            this.painelRadius1.Size = new System.Drawing.Size(378, 368);
            this.painelRadius1.TabIndex = 37;
            this.painelRadius1.Thickness = 5F;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
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
            this.dgvTipo.Location = new System.Drawing.Point(3, 3);
            this.dgvTipo.MultiSelect = false;
            this.dgvTipo.Name = "dgvTipo";
            this.dgvTipo.ReadOnly = true;
            this.dgvTipo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTipo.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTipo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipo.Size = new System.Drawing.Size(372, 362);
            this.dgvTipo.TabIndex = 27;
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
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnClose.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnClose.CorTextoBotao = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(369, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 36;
            this.btnClose.TamanhoBorda = 0;
            this.btnClose.TamanhoRaio = 5;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.Color1 = System.Drawing.Color.SkyBlue;
            this.roundedPanel1.Color2 = System.Drawing.Color.Black;
            this.roundedPanel1.CornerRadius = 10;
            this.roundedPanel1.GradientAngle = 180F;
            this.roundedPanel1.Location = new System.Drawing.Point(-16, 60);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(205, 10);
            this.roundedPanel1.TabIndex = 35;
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
            this.customPanel1.Location = new System.Drawing.Point(12, 516);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(382, 37);
            this.customPanel1.TabIndex = 28;
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
            this.lbRegistros.Size = new System.Drawing.Size(109, 31);
            this.lbRegistros.TabIndex = 1;
            this.lbRegistros.Text = "0 Registros";
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.AliceBlue;
            this.customPanel2.Controls.Add(this.txtDescricao);
            this.customPanel2.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.customPanel2.CorBotao = System.Drawing.Color.AliceBlue;
            this.customPanel2.CorTextoBotao = System.Drawing.Color.White;
            this.customPanel2.ForeColor = System.Drawing.Color.White;
            this.customPanel2.Location = new System.Drawing.Point(12, 86);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(382, 51);
            this.customPanel2.TabIndex = 26;
            this.customPanel2.TamanhoBorda = 0;
            this.customPanel2.TamanhoRaio = 20;
            // 
            // txtDescricao
            // 
            this.txtDescricao.AcceptsTab = true;
            this.txtDescricao.AnimateReadOnly = false;
            this.txtDescricao.AutoWordSelection = true;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Depth = 0;
            this.txtDescricao.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescricao.Hint = "Fabricante";
            this.txtDescricao.LeadingIcon = null;
            this.txtDescricao.LeaveOnEnterKey = true;
            this.txtDescricao.Location = new System.Drawing.Point(4, 0);
            this.txtDescricao.MaxLength = 80;
            this.txtDescricao.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescricao.Multiline = false;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(378, 50);
            this.txtDescricao.TabIndex = 10;
            this.txtDescricao.Text = "";
            this.txtDescricao.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtDescricao.TrailingIcon")));
            this.txtDescricao.UseAccent = false;
            this.txtDescricao.TrailingIconClick += new System.EventHandler(this.txtDescricao_TrailingIconClick);
            // 
            // Fabricante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(406, 565);
            this.Controls.Add(this.painelRadius1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.customPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fabricante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fabricante";
            this.Load += new System.EventHandler(this.Fabricante_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Fabricante_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.painelRadius1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipo)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.customPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.CustomPanel customPanel1;
        private System.Windows.Forms.Label lbRegistros;
        private System.Windows.Forms.DataGridView dgvTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewImageColumn colExcluir;
        private Componentes.CustomPanel customPanel2;
        private MaterialSkin.Controls.MaterialTextBox txtDescricao;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Componentes.RoundedPanel roundedPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Componentes.CustomButton btnClose;
        private Componentes.PainelRadius painelRadius1;
    }
}