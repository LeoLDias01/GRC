namespace Business_Manager.Screens
{
    partial class Corporation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Corporation));
            this.customButton1 = new Business_Manager.Components.CustomButton();
            this.lblTituloPagina = new System.Windows.Forms.Label();
            this.customPanel1 = new Business_Manager.Components.CustomPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customButton2 = new Business_Manager.Components.CustomButton();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.White;
            this.customButton1.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.customButton1.CorBotao = System.Drawing.Color.White;
            this.customButton1.CorTextoBotao = System.Drawing.Color.White;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Image = global::Business_Manager.Properties.Resources.voltar;
            this.customButton1.Location = new System.Drawing.Point(706, 6);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(37, 34);
            this.customButton1.TabIndex = 0;
            this.customButton1.TamanhoBorda = 0;
            this.customButton1.TamanhoRaio = 10;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // lblTituloPagina
            // 
            this.lblTituloPagina.AutoSize = true;
            this.lblTituloPagina.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloPagina.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPagina.ForeColor = System.Drawing.Color.White;
            this.lblTituloPagina.Location = new System.Drawing.Point(58, 9);
            this.lblTituloPagina.Name = "lblTituloPagina";
            this.lblTituloPagina.Size = new System.Drawing.Size(198, 25);
            this.lblTituloPagina.TabIndex = 190;
            this.lblTituloPagina.Text = "Cadastro de Empresa";
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.customPanel1.Controls.Add(this.customButton2);
            this.customPanel1.Controls.Add(this.pictureBox1);
            this.customPanel1.Controls.Add(this.customButton1);
            this.customPanel1.Controls.Add(this.lblTituloPagina);
            this.customPanel1.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.customPanel1.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.customPanel1.CorTextoBotao = System.Drawing.Color.White;
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.customPanel1.ForeColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(800, 43);
            this.customPanel1.TabIndex = 191;
            this.customPanel1.TamanhoBorda = 0;
            this.customPanel1.TamanhoRaio = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 191;
            this.pictureBox1.TabStop = false;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.White;
            this.customButton2.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.customButton2.CorBotao = System.Drawing.Color.White;
            this.customButton2.CorTextoBotao = System.Drawing.Color.White;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Image = ((System.Drawing.Image)(resources.GetObject("customButton2.Image")));
            this.customButton2.Location = new System.Drawing.Point(749, 6);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(37, 34);
            this.customButton2.TabIndex = 192;
            this.customButton2.TamanhoBorda = 0;
            this.customButton2.TamanhoRaio = 10;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // Corporation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customPanel1);
            this.Name = "Corporation";
            this.Text = "Corporation";
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.CustomButton customButton1;
        private System.Windows.Forms.Label lblTituloPagina;
        private Components.CustomPanel customPanel1;
        private Components.CustomButton customButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}