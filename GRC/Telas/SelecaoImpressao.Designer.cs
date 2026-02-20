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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roundedPanel1 = new GRC.Componentes.RoundedPanel();
            this.customPanel1 = new GRC.Componentes.CustomPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbPdf = new System.Windows.Forms.RadioButton();
            this.rbPdfImp = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEntrada = new System.Windows.Forms.RadioButton();
            this.rbSaida = new System.Windows.Forms.RadioButton();
            this.btnExportar = new GRC.Componentes.CustomButton();
            this.btnSalvar = new GRC.Componentes.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 60;
            this.label1.Text = "Exportação da OS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.Color1 = System.Drawing.Color.Aquamarine;
            this.roundedPanel1.Color2 = System.Drawing.Color.Black;
            this.roundedPanel1.CornerRadius = 10;
            this.roundedPanel1.GradientAngle = 180F;
            this.roundedPanel1.Location = new System.Drawing.Point(-48, 56);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(284, 10);
            this.roundedPanel1.TabIndex = 63;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.customPanel1.Controls.Add(this.groupBox2);
            this.customPanel1.Controls.Add(this.groupBox1);
            this.customPanel1.CorBorda = System.Drawing.Color.AliceBlue;
            this.customPanel1.CorBotao = System.Drawing.Color.AliceBlue;
            this.customPanel1.CorTextoBotao = System.Drawing.Color.White;
            this.customPanel1.ForeColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(12, 83);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(257, 182);
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
            this.groupBox2.Location = new System.Drawing.Point(14, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 85);
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
            this.rbPdf.Location = new System.Drawing.Point(20, 29);
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
            this.rbPdfImp.Location = new System.Drawing.Point(20, 54);
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
            this.groupBox1.Size = new System.Drawing.Size(228, 63);
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
            this.rbSaida.Location = new System.Drawing.Point(128, 29);
            this.rbSaida.Name = "rbSaida";
            this.rbSaida.Size = new System.Drawing.Size(58, 19);
            this.rbSaida.TabIndex = 1;
            this.rbSaida.TabStop = true;
            this.rbSaida.Text = "Saída";
            this.rbSaida.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
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
            this.btnExportar.Location = new System.Drawing.Point(13, 282);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExportar.Size = new System.Drawing.Size(256, 41);
            this.btnExportar.TabIndex = 59;
            this.btnExportar.TamanhoBorda = 0;
            this.btnExportar.TamanhoRaio = 20;
            this.btnExportar.Text = "    Gerar PDF";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.CorBorda = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnSalvar.CorBotao = System.Drawing.Color.Transparent;
            this.btnSalvar.CorTextoBotao = System.Drawing.Color.White;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(13, 329);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSalvar.Size = new System.Drawing.Size(256, 42);
            this.btnSalvar.TabIndex = 23;
            this.btnSalvar.TamanhoBorda = 3;
            this.btnSalvar.TamanhoRaio = 20;
            this.btnSalvar.Text = "  Voltar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // SelecaoImpressao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(281, 391);
            this.ControlBox = false;
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnSalvar);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Componentes.CustomButton btnSalvar;
        private Componentes.CustomButton btnExportar;
        private System.Windows.Forms.Label label1;
        private Componentes.CustomPanel customPanel1;
        private System.Windows.Forms.RadioButton rbEntrada;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbPdf;
        private System.Windows.Forms.RadioButton rbPdfImp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSaida;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Componentes.RoundedPanel roundedPanel1;
    }
}