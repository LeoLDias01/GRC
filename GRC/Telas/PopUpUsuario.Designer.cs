namespace GRC.Telas
{
    partial class PopUpUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUpUsuario));
            this.lbNome = new System.Windows.Forms.Label();
            this.btnFecharJanela = new GRC.Componentes.CustomButton();
            this.btnEncerrar = new GRC.Componentes.CustomButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTrocar = new GRC.Componentes.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(92)))));
            this.lbNome.Location = new System.Drawing.Point(78, 43);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(112, 21);
            this.lbNome.TabIndex = 42;
            this.lbNome.Text = "Rayner Bryan";
            // 
            // btnFecharJanela
            // 
            this.btnFecharJanela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFecharJanela.BackColor = System.Drawing.SystemColors.Control;
            this.btnFecharJanela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFecharJanela.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnFecharJanela.CorBotao = System.Drawing.SystemColors.Control;
            this.btnFecharJanela.CorTextoBotao = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.btnFecharJanela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFecharJanela.FlatAppearance.BorderSize = 0;
            this.btnFecharJanela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnFecharJanela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharJanela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharJanela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.btnFecharJanela.Image = ((System.Drawing.Image)(resources.GetObject("btnFecharJanela.Image")));
            this.btnFecharJanela.Location = new System.Drawing.Point(214, 12);
            this.btnFecharJanela.Name = "btnFecharJanela";
            this.btnFecharJanela.Size = new System.Drawing.Size(18, 18);
            this.btnFecharJanela.TabIndex = 45;
            this.btnFecharJanela.TamanhoBorda = 0;
            this.btnFecharJanela.TamanhoRaio = 5;
            this.btnFecharJanela.UseVisualStyleBackColor = false;
            this.btnFecharJanela.Click += new System.EventHandler(this.btnFecharJanela_Click);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnEncerrar.CorBorda = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(92)))));
            this.btnEncerrar.CorBotao = System.Drawing.Color.Transparent;
            this.btnEncerrar.CorTextoBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(92)))));
            this.btnEncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncerrar.FlatAppearance.BorderSize = 0;
            this.btnEncerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnEncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnEncerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(92)))));
            this.btnEncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnEncerrar.Image")));
            this.btnEncerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncerrar.Location = new System.Drawing.Point(27, 143);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEncerrar.Size = new System.Drawing.Size(186, 41);
            this.btnEncerrar.TabIndex = 44;
            this.btnEncerrar.TamanhoBorda = 2;
            this.btnEncerrar.TamanhoRaio = 15;
            this.btnEncerrar.Text = "Encerrar";
            this.btnEncerrar.UseVisualStyleBackColor = false;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // btnTrocar
            // 
            this.btnTrocar.BackColor = System.Drawing.Color.Transparent;
            this.btnTrocar.CorBorda = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(92)))));
            this.btnTrocar.CorBotao = System.Drawing.Color.Transparent;
            this.btnTrocar.CorTextoBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(92)))));
            this.btnTrocar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrocar.FlatAppearance.BorderSize = 0;
            this.btnTrocar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnTrocar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrocar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnTrocar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(92)))));
            this.btnTrocar.Image = ((System.Drawing.Image)(resources.GetObject("btnTrocar.Image")));
            this.btnTrocar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrocar.Location = new System.Drawing.Point(27, 95);
            this.btnTrocar.Name = "btnTrocar";
            this.btnTrocar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTrocar.Size = new System.Drawing.Size(186, 42);
            this.btnTrocar.TabIndex = 43;
            this.btnTrocar.TamanhoBorda = 2;
            this.btnTrocar.TamanhoRaio = 15;
            this.btnTrocar.Text = "Trocar";
            this.btnTrocar.UseMnemonic = false;
            this.btnTrocar.UseVisualStyleBackColor = false;
            this.btnTrocar.Click += new System.EventHandler(this.btnTrocar_Click);
            // 
            // PopUpUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 231);
            this.Controls.Add(this.btnFecharJanela);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTrocar);
            this.Controls.Add(this.lbNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(20, 200);
            this.Name = "PopUpUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PopUpUsuario";
            this.Load += new System.EventHandler(this.PopUpUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.CustomButton btnFecharJanela;
        private Componentes.CustomButton btnEncerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Componentes.CustomButton btnTrocar;
        private System.Windows.Forms.Label lbNome;
    }
}