namespace GRC.Telas
{
    partial class Loading
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.tlpLoading = new System.Windows.Forms.TableLayoutPanel();
            this.pcbGif = new System.Windows.Forms.PictureBox();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customPictureBox1 = new GRC.Componentes.CustomPictureBox();
            this.lblVersao = new System.Windows.Forms.Label();
            this.LoadTimer = new System.Windows.Forms.Timer(this.components);
            this.tlpLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpLoading
            // 
            this.tlpLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLoading.BackColor = System.Drawing.Color.White;
            this.tlpLoading.ColumnCount = 1;
            this.tlpLoading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLoading.Controls.Add(this.pcbGif, 0, 1);
            this.tlpLoading.Controls.Add(this.panel1, 0, 2);
            this.tlpLoading.Controls.Add(this.pcbLogo, 0, 0);
            this.tlpLoading.Location = new System.Drawing.Point(12, 12);
            this.tlpLoading.Name = "tlpLoading";
            this.tlpLoading.RowCount = 3;
            this.tlpLoading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.4251F));
            this.tlpLoading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.31984F));
            this.tlpLoading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tlpLoading.Size = new System.Drawing.Size(339, 503);
            this.tlpLoading.TabIndex = 0;
            // 
            // pcbGif
            // 
            this.pcbGif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbGif.Image = global::GRC.Properties.Resources.Loading_Gif_GRC;
            this.pcbGif.Location = new System.Drawing.Point(3, 181);
            this.pcbGif.Name = "pcbGif";
            this.pcbGif.Size = new System.Drawing.Size(333, 212);
            this.pcbGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGif.TabIndex = 1;
            this.pcbGif.TabStop = false;
            // 
            // pcbLogo
            // 
            this.pcbLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pcbLogo.Image = global::GRC.Properties.Resources.RF_LabTech_Logo;
            this.pcbLogo.Location = new System.Drawing.Point(3, 38);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(333, 137);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.customPictureBox1);
            this.panel1.Controls.Add(this.lblVersao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 399);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 101);
            this.panel1.TabIndex = 2;
            // 
            // customPictureBox1
            // 
            this.customPictureBox1.BackColor = System.Drawing.Color.White;
            this.customPictureBox1.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.customPictureBox1.CorBotao = System.Drawing.Color.White;
            this.customPictureBox1.CorTextoBotao = System.Drawing.SystemColors.ControlText;
            this.customPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.customPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("customPictureBox1.Image")));
            this.customPictureBox1.Location = new System.Drawing.Point(3, 45);
            this.customPictureBox1.Name = "customPictureBox1";
            this.customPictureBox1.Size = new System.Drawing.Size(327, 51);
            this.customPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customPictureBox1.TabIndex = 1;
            this.customPictureBox1.TabStop = false;
            this.customPictureBox1.TamanhoBorda = 0;
            this.customPictureBox1.TamanhoRaio = 0;
            // 
            // lblVersao
            // 
            this.lblVersao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersao.AutoSize = true;
            this.lblVersao.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.lblVersao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(90)))));
            this.lblVersao.Location = new System.Drawing.Point(109, 10);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(115, 19);
            this.lblVersao.TabIndex = 0;
            this.lblVersao.Text = "Versão 1.0.0.0";
            // 
            // LoadTimer
            // 
            this.LoadTimer.Tick += new System.EventHandler(this.LoadTimer_Tick);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(363, 527);
            this.ControlBox = false;
            this.Controls.Add(this.tlpLoading);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loading";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Loading_Load);
            this.tlpLoading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpLoading;
        private System.Windows.Forms.PictureBox pcbGif;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Timer LoadTimer;
        private Componentes.CustomPictureBox customPictureBox1;
    }
}