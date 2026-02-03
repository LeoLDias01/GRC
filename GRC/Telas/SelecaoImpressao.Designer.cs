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
            this.btnSalvar = new GRC.Componentes.CustomButton();
            this.btnExportar = new GRC.Componentes.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.customPanel1 = new GRC.Componentes.CustomPanel();
            this.chkLoja = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkCliente = new MaterialSkin.Controls.MaterialCheckbox();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnSalvar.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSalvar.CorTextoBotao = System.Drawing.Color.White;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(12, 188);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSalvar.Size = new System.Drawing.Size(183, 37);
            this.btnSalvar.TabIndex = 23;
            this.btnSalvar.TamanhoBorda = 0;
            this.btnSalvar.TamanhoRaio = 5;
            this.btnSalvar.Text = "            Voltar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExportar.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnExportar.CorBotao = System.Drawing.Color.DeepSkyBlue;
            this.btnExportar.CorTextoBotao = System.Drawing.Color.White;
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(12, 145);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExportar.Size = new System.Drawing.Size(183, 37);
            this.btnExportar.TabIndex = 59;
            this.btnExportar.TamanhoBorda = 0;
            this.btnExportar.TamanhoRaio = 5;
            this.btnExportar.Text = "         Gerar PDF";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 23);
            this.label1.TabIndex = 60;
            this.label1.Text = "Tipos de Exportação";
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.customPanel1.Controls.Add(this.chkCliente);
            this.customPanel1.Controls.Add(this.chkLoja);
            this.customPanel1.CorBorda = System.Drawing.Color.AliceBlue;
            this.customPanel1.CorBotao = System.Drawing.Color.AliceBlue;
            this.customPanel1.CorTextoBotao = System.Drawing.Color.White;
            this.customPanel1.ForeColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(12, 38);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(183, 101);
            this.customPanel1.TabIndex = 61;
            this.customPanel1.TamanhoBorda = 0;
            this.customPanel1.TamanhoRaio = 20;
            // 
            // chkLoja
            // 
            this.chkLoja.AutoSize = true;
            this.chkLoja.Depth = 0;
            this.chkLoja.Location = new System.Drawing.Point(9, 14);
            this.chkLoja.Margin = new System.Windows.Forms.Padding(0);
            this.chkLoja.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkLoja.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkLoja.Name = "chkLoja";
            this.chkLoja.ReadOnly = false;
            this.chkLoja.Ripple = true;
            this.chkLoja.Size = new System.Drawing.Size(115, 37);
            this.chkLoja.TabIndex = 49;
            this.chkLoja.Text = "Via da Loja";
            this.chkLoja.UseVisualStyleBackColor = true;
            // 
            // chkCliente
            // 
            this.chkCliente.AutoSize = true;
            this.chkCliente.Depth = 0;
            this.chkCliente.Location = new System.Drawing.Point(9, 51);
            this.chkCliente.Margin = new System.Windows.Forms.Padding(0);
            this.chkCliente.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkCliente.Name = "chkCliente";
            this.chkCliente.ReadOnly = false;
            this.chkCliente.Ripple = true;
            this.chkCliente.Size = new System.Drawing.Size(132, 37);
            this.chkCliente.TabIndex = 50;
            this.chkCliente.Text = "Via do Cliente";
            this.chkCliente.UseVisualStyleBackColor = true;
            // 
            // SelecaoImpressao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(212, 238);
            this.ControlBox = false;
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
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Componentes.CustomButton btnSalvar;
        private Componentes.CustomButton btnExportar;
        private System.Windows.Forms.Label label1;
        private Componentes.CustomPanel customPanel1;
        private MaterialSkin.Controls.MaterialCheckbox chkCliente;
        private MaterialSkin.Controls.MaterialCheckbox chkLoja;
    }
}