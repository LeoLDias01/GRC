namespace GRC.Telas
{
    partial class SelecaoImpressao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelecaoImpressao));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customPanel1 = new GRC.Componentes.CustomPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbPdf = new System.Windows.Forms.RadioButton();
            this.rbPdfImp = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEntrada = new System.Windows.Forms.RadioButton();
            this.rbSaida = new System.Windows.Forms.RadioButton();
            this.btnExportar = new GRC.Componentes.CustomButton();
            this.roundedPanel2 = new GRC.Componentes.RoundedPanel();
            this.pnExterno = new GRC.Componentes.ModernBox();
            this.pnInterno = new GRC.Componentes.CustomPanel();
            this.btnEncerrarJanelas = new GRC.Componentes.CustomButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnExterno.SuspendLayout();
            this.pnInterno.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.Controls.Add(this.groupBox2);
            this.customPanel1.Controls.Add(this.groupBox1);
            this.customPanel1.CorBorda = System.Drawing.Color.White;
            this.customPanel1.CorBotao = System.Drawing.Color.White;
            this.customPanel1.CorTextoBotao = System.Drawing.Color.White;
            this.customPanel1.ForeColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(3, 81);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(326, 249);
            this.customPanel1.TabIndex = 61;
            this.customPanel1.TamanhoBorda = 0;
            this.customPanel1.TamanhoRaio = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbPdf);
            this.groupBox2.Controls.Add(this.rbPdfImp);
            this.groupBox2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.groupBox2.Location = new System.Drawing.Point(14, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 116);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de saída";
            // 
            // rbPdf
            // 
            this.rbPdf.AutoSize = true;
            this.rbPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPdf.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPdf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.rbPdf.Location = new System.Drawing.Point(20, 38);
            this.rbPdf.Name = "rbPdf";
            this.rbPdf.Size = new System.Drawing.Size(48, 19);
            this.rbPdf.TabIndex = 0;
            this.rbPdf.TabStop = true;
            this.rbPdf.Text = "PDF";
            this.rbPdf.UseVisualStyleBackColor = true;
            // 
            // rbPdfImp
            // 
            this.rbPdfImp.AutoSize = true;
            this.rbPdfImp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPdfImp.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPdfImp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.rbPdfImp.Location = new System.Drawing.Point(20, 72);
            this.rbPdfImp.Name = "rbPdfImp";
            this.rbPdfImp.Size = new System.Drawing.Size(123, 19);
            this.rbPdfImp.TabIndex = 1;
            this.rbPdfImp.TabStop = true;
            this.rbPdfImp.Text = "PDF + Impressão";
            this.rbPdfImp.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEntrada);
            this.groupBox1.Controls.Add(this.rbSaida);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 105);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Impressão";
            // 
            // rbEntrada
            // 
            this.rbEntrada.AutoSize = true;
            this.rbEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEntrada.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.rbEntrada.Location = new System.Drawing.Point(20, 29);
            this.rbEntrada.Name = "rbEntrada";
            this.rbEntrada.Size = new System.Drawing.Size(69, 19);
            this.rbEntrada.TabIndex = 0;
            this.rbEntrada.TabStop = true;
            this.rbEntrada.Text = "Entrada";
            this.rbEntrada.UseVisualStyleBackColor = true;
            // 
            // rbSaida
            // 
            this.rbSaida.AutoSize = true;
            this.rbSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSaida.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSaida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.rbSaida.Location = new System.Drawing.Point(20, 64);
            this.rbSaida.Name = "rbSaida";
            this.rbSaida.Size = new System.Drawing.Size(58, 19);
            this.rbSaida.TabIndex = 1;
            this.rbSaida.TabStop = true;
            this.rbSaida.Text = "Saída";
            this.rbSaida.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportar.BackColor = System.Drawing.Color.Green;
            this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExportar.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnExportar.CorBotao = System.Drawing.Color.Green;
            this.btnExportar.CorTextoBotao = System.Drawing.Color.White;
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.Location = new System.Drawing.Point(95, 336);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnExportar.Size = new System.Drawing.Size(149, 41);
            this.btnExportar.TabIndex = 59;
            this.btnExportar.TamanhoBorda = 0;
            this.btnExportar.TamanhoRaio = 10;
            this.btnExportar.Text = "Gerar PDF";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel2.Color1 = System.Drawing.Color.Aquamarine;
            this.roundedPanel2.Color2 = System.Drawing.Color.Black;
            this.roundedPanel2.CornerRadius = 10;
            this.roundedPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedPanel2.GradientAngle = 180F;
            this.roundedPanel2.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(338, 10);
            this.roundedPanel2.TabIndex = 122;
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
            this.pnExterno.Location = new System.Drawing.Point(-2, 1);
            this.pnExterno.Name = "pnExterno";
            this.pnExterno.Padding = new System.Windows.Forms.Padding(13);
            this.pnExterno.ShadowAngle = 90;
            this.pnExterno.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnExterno.ShadowSize = 8;
            this.pnExterno.Size = new System.Drawing.Size(363, 411);
            this.pnExterno.TabIndex = 179;
            // 
            // pnInterno
            // 
            this.pnInterno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnInterno.BackColor = System.Drawing.Color.White;
            this.pnInterno.Controls.Add(this.pictureBox1);
            this.pnInterno.Controls.Add(this.customPanel1);
            this.pnInterno.Controls.Add(this.btnExportar);
            this.pnInterno.Controls.Add(this.roundedPanel2);
            this.pnInterno.Controls.Add(this.btnEncerrarJanelas);
            this.pnInterno.Controls.Add(this.label6);
            this.pnInterno.Controls.Add(this.lbTitulo);
            this.pnInterno.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.pnInterno.CorBotao = System.Drawing.Color.White;
            this.pnInterno.CorTextoBotao = System.Drawing.Color.White;
            this.pnInterno.ForeColor = System.Drawing.Color.White;
            this.pnInterno.Location = new System.Drawing.Point(16, 4);
            this.pnInterno.Name = "pnInterno";
            this.pnInterno.Size = new System.Drawing.Size(338, 391);
            this.pnInterno.TabIndex = 0;
            this.pnInterno.TamanhoBorda = 0;
            this.pnInterno.TamanhoRaio = 15;
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
            this.btnEncerrarJanelas.Location = new System.Drawing.Point(311, 16);
            this.btnEncerrarJanelas.Name = "btnEncerrarJanelas";
            this.btnEncerrarJanelas.Size = new System.Drawing.Size(18, 18);
            this.btnEncerrarJanelas.TabIndex = 163;
            this.btnEncerrarJanelas.TamanhoBorda = 0;
            this.btnEncerrarJanelas.TamanhoRaio = 5;
            this.btnEncerrarJanelas.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(64, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 20);
            this.label6.TabIndex = 175;
            this.label6.Text = "Escolha como imprimir";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.lbTitulo.Location = new System.Drawing.Point(63, 23);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(216, 29);
            this.lbTitulo.TabIndex = 173;
            this.lbTitulo.Text = "Impressão de OS";
            // 
            // SelecaoImpressao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(366, 412);
            this.ControlBox = false;
            this.Controls.Add(this.pnExterno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelecaoImpressao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelecaoImpressao";
            this.Load += new System.EventHandler(this.SelecaoImpressao_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelecaoImpressao_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnExterno.ResumeLayout(false);
            this.pnInterno.ResumeLayout(false);
            this.pnInterno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Componentes.CustomButton btnExportar;
        private Componentes.CustomPanel customPanel1;
        private System.Windows.Forms.RadioButton rbEntrada;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbPdf;
        private System.Windows.Forms.RadioButton rbPdfImp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSaida;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Componentes.RoundedPanel roundedPanel2;
        private Componentes.ModernBox pnExterno;
        private Componentes.CustomPanel pnInterno;
        private Componentes.CustomButton btnEncerrarJanelas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTitulo;
    }
}