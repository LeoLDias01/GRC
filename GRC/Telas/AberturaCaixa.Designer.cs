namespace GRC.Telas
{
    partial class AberturaCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AberturaCaixa));
            this.roundedPanel1 = new GRC.Componentes.RoundedPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new GRC.Componentes.CustomButton();
            this.lbData = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.painelRadius3 = new GRC.Componentes.PainelRadius();
            this.txtObservacoes = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtSaldoInicial = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSalvar = new GRC.Componentes.CustomButton();
            this.painelRadius1 = new GRC.Componentes.PainelRadius();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.painelRadius3.SuspendLayout();
            this.painelRadius1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.Color1 = System.Drawing.Color.PaleTurquoise;
            this.roundedPanel1.Color2 = System.Drawing.Color.Black;
            this.roundedPanel1.CornerRadius = 10;
            this.roundedPanel1.GradientAngle = 180F;
            this.roundedPanel1.Location = new System.Drawing.Point(-16, 60);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(295, 10);
            this.roundedPanel1.TabIndex = 35;
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
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Abertura de Caixa";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnClose.CorBotao = System.Drawing.Color.Transparent;
            this.btnClose.CorTextoBotao = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(346, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 35);
            this.btnClose.TabIndex = 126;
            this.btnClose.TamanhoBorda = 0;
            this.btnClose.TamanhoRaio = 17;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold);
            this.lbData.ForeColor = System.Drawing.Color.White;
            this.lbData.Location = new System.Drawing.Point(18, 127);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(283, 23);
            this.lbData.TabIndex = 9;
            this.lbData.Text = "Abertura:  26/02/2026 12:00:00";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold);
            this.lbUser.ForeColor = System.Drawing.Color.White;
            this.lbUser.Location = new System.Drawing.Point(18, 166);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(202, 23);
            this.lbUser.TabIndex = 9;
            this.lbUser.Text = "Usuário: Rayner Bryan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "PDV: 001 (Único)";
            // 
            // painelRadius3
            // 
            this.painelRadius3.BackColor = System.Drawing.Color.White;
            this.painelRadius3.BorderColor = System.Drawing.Color.White;
            this.painelRadius3.Controls.Add(this.txtSaldoInicial);
            this.painelRadius3.Location = new System.Drawing.Point(73, 210);
            this.painelRadius3.Name = "painelRadius3";
            this.painelRadius3.Radius = 40;
            this.painelRadius3.Size = new System.Drawing.Size(279, 51);
            this.painelRadius3.TabIndex = 134;
            this.painelRadius3.Thickness = 5F;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.AnimateReadOnly = false;
            this.txtObservacoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtObservacoes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtObservacoes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObservacoes.Depth = 0;
            this.txtObservacoes.HideSelection = true;
            this.txtObservacoes.Hint = "Observações";
            this.txtObservacoes.Location = new System.Drawing.Point(3, 3);
            this.txtObservacoes.MaxLength = 32767;
            this.txtObservacoes.MouseState = MaterialSkin.MouseState.OUT;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.PasswordChar = '\0';
            this.txtObservacoes.ReadOnly = false;
            this.txtObservacoes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObservacoes.SelectedText = "";
            this.txtObservacoes.SelectionLength = 0;
            this.txtObservacoes.SelectionStart = 0;
            this.txtObservacoes.ShortcutsEnabled = true;
            this.txtObservacoes.Size = new System.Drawing.Size(324, 131);
            this.txtObservacoes.TabIndex = 10;
            this.txtObservacoes.TabStop = false;
            this.txtObservacoes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtObservacoes.UseSystemPasswordChar = false;
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.AnimateReadOnly = false;
            this.txtSaldoInicial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSaldoInicial.Depth = 0;
            this.txtSaldoInicial.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSaldoInicial.Hint = "Saldo Inicial";
            this.txtSaldoInicial.LeadingIcon = null;
            this.txtSaldoInicial.Location = new System.Drawing.Point(3, 0);
            this.txtSaldoInicial.MaxLength = 50;
            this.txtSaldoInicial.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSaldoInicial.Multiline = false;
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.Size = new System.Drawing.Size(273, 50);
            this.txtSaldoInicial.TabIndex = 0;
            this.txtSaldoInicial.Text = "";
            this.txtSaldoInicial.TrailingIcon = null;
            this.txtSaldoInicial.UseAccent = false;
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
            this.btnSalvar.Location = new System.Drawing.Point(285, 27);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSalvar.Size = new System.Drawing.Size(53, 43);
            this.btnSalvar.TabIndex = 135;
            this.btnSalvar.TamanhoBorda = 0;
            this.btnSalvar.TamanhoRaio = 10;
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // painelRadius1
            // 
            this.painelRadius1.BackColor = System.Drawing.Color.White;
            this.painelRadius1.BorderColor = System.Drawing.Color.White;
            this.painelRadius1.Controls.Add(this.txtObservacoes);
            this.painelRadius1.Location = new System.Drawing.Point(22, 280);
            this.painelRadius1.Name = "painelRadius1";
            this.painelRadius1.Radius = 40;
            this.painelRadius1.Size = new System.Drawing.Size(330, 138);
            this.painelRadius1.TabIndex = 135;
            this.painelRadius1.Thickness = 5F;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 210);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 136;
            this.pictureBox2.TabStop = false;
            // 
            // AberturaCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(381, 440);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.painelRadius1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.painelRadius3);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AberturaCaixa";
            this.Text = "AberturaCaixa";
            this.Load += new System.EventHandler(this.AberturaCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.painelRadius3.ResumeLayout(false);
            this.painelRadius1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.RoundedPanel roundedPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Componentes.CustomButton btnClose;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label label4;
        private Componentes.PainelRadius painelRadius3;
        private MaterialSkin.Controls.MaterialTextBox txtSaldoInicial;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtObservacoes;
        private Componentes.CustomButton btnSalvar;
        private Componentes.PainelRadius painelRadius1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}