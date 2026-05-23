namespace GRC.Telas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbAviso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenha = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.btnSair = new GRC.Componentes.CustomButton();
            this.btnEntrar = new GRC.Componentes.CustomButton();
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.pnBaixo = new System.Windows.Forms.Panel();
            this.pcbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAviso
            // 
            this.lbAviso.AutoSize = true;
            this.lbAviso.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbAviso.Location = new System.Drawing.Point(32, 200);
            this.lbAviso.Name = "lbAviso";
            this.lbAviso.Size = new System.Drawing.Size(195, 17);
            this.lbAviso.TabIndex = 10;
            this.lbAviso.Text = "Entre com seu usuário e senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(30, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Login";
            // 
            // txtSenha
            // 
            this.txtSenha.AnimateReadOnly = false;
            this.txtSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSenha.Depth = 0;
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.HideSelection = true;
            this.txtSenha.Hint = "Senha";
            this.txtSenha.LeadingIcon = global::GRC.Properties.Resources.Usuario_Senha;
            this.txtSenha.Location = new System.Drawing.Point(35, 301);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '•';
            this.txtSenha.PrefixSuffixText = null;
            this.txtSenha.ReadOnly = false;
            this.txtSenha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.ShortcutsEnabled = true;
            this.txtSenha.Size = new System.Drawing.Size(273, 48);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.TabStop = false;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSenha.TrailingIcon = null;
            this.txtSenha.UseAccent = false;
            this.txtSenha.UseSystemPasswordChar = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AnimateReadOnly = false;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.Hint = "Usuario";
            this.txtUsuario.LeadingIcon = global::GRC.Properties.Resources.Usuario_Login;
            this.txtUsuario.LeaveOnEnterKey = true;
            this.txtUsuario.Location = new System.Drawing.Point(35, 233);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(273, 50);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.Text = "";
            this.txtUsuario.TrailingIcon = null;
            this.txtUsuario.UseAccent = false;
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = global::GRC.Properties.Resources.RF_LabTech_Logo;
            this.pcbLogo.Location = new System.Drawing.Point(103, 50);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(137, 75);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnSair.CorBorda = System.Drawing.Color.Black;
            this.btnSair.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnSair.CorTextoBotao = System.Drawing.Color.White;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(37, 423);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(272, 48);
            this.btnSair.TabIndex = 7;
            this.btnSair.TamanhoBorda = 0;
            this.btnSair.TamanhoRaio = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnEntrar.CorBorda = System.Drawing.Color.Black;
            this.btnEntrar.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnEntrar.CorTextoBotao = System.Drawing.Color.White;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(36, 369);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(273, 48);
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.TamanhoBorda = 0;
            this.btnEntrar.TamanhoRaio = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // pnSuperior
            // 
            this.pnSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.pnSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(961, 5);
            this.pnSuperior.TabIndex = 11;
            // 
            // pnBaixo
            // 
            this.pnBaixo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.pnBaixo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBaixo.Location = new System.Drawing.Point(0, 512);
            this.pnBaixo.Name = "pnBaixo";
            this.pnBaixo.Size = new System.Drawing.Size(961, 5);
            this.pnBaixo.TabIndex = 12;
            // 
            // pcbImage
            // 
            this.pcbImage.Image = ((System.Drawing.Image)(resources.GetObject("pcbImage.Image")));
            this.pcbImage.Location = new System.Drawing.Point(346, -133);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(784, 781);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImage.TabIndex = 35;
            this.pcbImage.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(961, 517);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lbAviso);
            this.Controls.Add(this.pcbImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnSuperior);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.pnBaixo);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pcbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbLogo;
        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
        private MaterialSkin.Controls.MaterialTextBox2 txtSenha;
        private Componentes.CustomButton btnSair;
        private Componentes.CustomButton btnEntrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAviso;
        private System.Windows.Forms.Panel pnBaixo;
        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.PictureBox pcbImage;
    }
}