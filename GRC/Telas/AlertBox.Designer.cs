namespace GRC.Telas
{
    partial class AlertBox
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
            this.lbGrupo = new System.Windows.Forms.Label();
            this.lbMsg = new System.Windows.Forms.Label();
            this.lbItem = new System.Windows.Forms.Label();
            this.pcImagem = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnStatus = new GRC.Componentes.RoundedPanel();
            this.btnNo = new GRC.Componentes.CustomButton();
            this.btnYes = new GRC.Componentes.CustomButton();
            this.btnOk = new GRC.Componentes.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcImagem)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbGrupo
            // 
            this.lbGrupo.AutoSize = true;
            this.lbGrupo.Font = new System.Drawing.Font("Roboto", 14F);
            this.lbGrupo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbGrupo.Location = new System.Drawing.Point(13, 39);
            this.lbGrupo.Name = "lbGrupo";
            this.lbGrupo.Size = new System.Drawing.Size(0, 23);
            this.lbGrupo.TabIndex = 0;
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Font = new System.Drawing.Font("Roboto", 18F);
            this.lbMsg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMsg.Location = new System.Drawing.Point(3, 0);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(0, 29);
            this.lbMsg.TabIndex = 28;
            // 
            // lbItem
            // 
            this.lbItem.AutoSize = true;
            this.lbItem.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbItem.Location = new System.Drawing.Point(3, 0);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(0, 19);
            this.lbItem.TabIndex = 29;
            // 
            // pcImagem
            // 
            this.pcImagem.Image = global::GRC.Properties.Resources.Confirm;
            this.pcImagem.Location = new System.Drawing.Point(314, 12);
            this.pcImagem.Name = "pcImagem";
            this.pcImagem.Size = new System.Drawing.Size(109, 102);
            this.pcImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcImagem.TabIndex = 30;
            this.pcImagem.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbMsg);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 120);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(406, 89);
            this.flowLayoutPanel1.TabIndex = 31;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lbItem);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(17, 68);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(291, 46);
            this.flowLayoutPanel2.TabIndex = 32;
            // 
            // pnStatus
            // 
            this.pnStatus.BackColor = System.Drawing.Color.Transparent;
            this.pnStatus.Color1 = System.Drawing.Color.Ivory;
            this.pnStatus.Color2 = System.Drawing.Color.Lime;
            this.pnStatus.CornerRadius = 10;
            this.pnStatus.GradientAngle = 90F;
            this.pnStatus.Location = new System.Drawing.Point(16, 12);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(239, 10);
            this.pnStatus.TabIndex = 27;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNo.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnNo.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNo.CorTextoBotao = System.Drawing.Color.White;
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNo.Location = new System.Drawing.Point(277, 215);
            this.btnNo.Name = "btnNo";
            this.btnNo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnNo.Size = new System.Drawing.Size(114, 37);
            this.btnNo.TabIndex = 25;
            this.btnNo.TamanhoBorda = 0;
            this.btnNo.TamanhoRaio = 10;
            this.btnNo.Text = "Não";
            this.btnNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Visible = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnYes.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnYes.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnYes.CorTextoBotao = System.Drawing.Color.White;
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.FlatAppearance.BorderSize = 0;
            this.btnYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYes.Location = new System.Drawing.Point(46, 215);
            this.btnYes.Name = "btnYes";
            this.btnYes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnYes.Size = new System.Drawing.Size(114, 37);
            this.btnYes.TabIndex = 24;
            this.btnYes.TamanhoBorda = 0;
            this.btnYes.TamanhoRaio = 10;
            this.btnYes.Text = "Sim";
            this.btnYes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Visible = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOk.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnOk.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnOk.CorTextoBotao = System.Drawing.Color.White;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(136, 215);
            this.btnOk.Name = "btnOk";
            this.btnOk.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnOk.Size = new System.Drawing.Size(153, 37);
            this.btnOk.TabIndex = 23;
            this.btnOk.TamanhoBorda = 0;
            this.btnOk.TamanhoRaio = 10;
            this.btnOk.Text = "OK!";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // AlertBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(4)))));
            this.ClientSize = new System.Drawing.Size(435, 277);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pcImagem);
            this.Controls.Add(this.lbGrupo);
            this.Controls.Add(this.pnStatus);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlertBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlertBox";
            this.Load += new System.EventHandler(this.AlertBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcImagem)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.CustomButton btnOk;
        private Componentes.CustomButton btnYes;
        private Componentes.CustomButton btnNo;
        private System.Windows.Forms.Label lbGrupo;
        private Componentes.RoundedPanel pnStatus;
        private System.Windows.Forms.Label lbMsg;
        private System.Windows.Forms.Label lbItem;
        private System.Windows.Forms.PictureBox pcImagem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}