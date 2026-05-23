namespace GRC.Telas
{
    partial class WorkFlow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkFlow));
            this.totLegendaMenu = new System.Windows.Forms.ToolTip(this.components);
            this.pnWorkflow = new System.Windows.Forms.Panel();
            this.sidebar1 = new GRC.UserControls.Sidebar();
            this.btnEncerrarJanelas = new GRC.Componentes.CustomButton();
            this.btnMinimize = new GRC.Componentes.CustomButton();
            this.btnMaximize = new GRC.Componentes.CustomButton();
            this.SuspendLayout();
            // 
            // pnWorkflow
            // 
            this.pnWorkflow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnWorkflow.AutoScroll = true;
            this.pnWorkflow.Location = new System.Drawing.Point(76, 27);
            this.pnWorkflow.Name = "pnWorkflow";
            this.pnWorkflow.Size = new System.Drawing.Size(1271, 702);
            this.pnWorkflow.TabIndex = 43;
            this.pnWorkflow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnWorkflow_MouseDown);
            // 
            // sidebar1
            // 
            this.sidebar1.BackColor = System.Drawing.Color.Transparent;
            this.sidebar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar1.Location = new System.Drawing.Point(0, 0);
            this.sidebar1.Name = "sidebar1";
            this.sidebar1.Size = new System.Drawing.Size(70, 729);
            this.sidebar1.TabIndex = 42;
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
            this.btnEncerrarJanelas.Location = new System.Drawing.Point(1316, 3);
            this.btnEncerrarJanelas.Name = "btnEncerrarJanelas";
            this.btnEncerrarJanelas.Size = new System.Drawing.Size(18, 18);
            this.btnEncerrarJanelas.TabIndex = 38;
            this.btnEncerrarJanelas.TamanhoBorda = 0;
            this.btnEncerrarJanelas.TamanhoRaio = 5;
            this.btnEncerrarJanelas.UseVisualStyleBackColor = false;
            this.btnEncerrarJanelas.Click += new System.EventHandler(this.btnEncerrarJanelas_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnMinimize.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnMinimize.CorTextoBotao = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1268, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(18, 18);
            this.btnMinimize.TabIndex = 12;
            this.btnMinimize.TamanhoBorda = 0;
            this.btnMinimize.TamanhoRaio = 5;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaximize.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnMaximize.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnMaximize.CorTextoBotao = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(1292, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(18, 18);
            this.btnMaximize.TabIndex = 13;
            this.btnMaximize.TamanhoBorda = 0;
            this.btnMaximize.TamanhoRaio = 5;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // WorkFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pnWorkflow);
            this.Controls.Add(this.sidebar1);
            this.Controls.Add(this.btnEncerrarJanelas);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMaximize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkFlow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkFlow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WorkFlow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WorkFlow_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion
        private Componentes.CustomButton btnMinimize;
        private Componentes.CustomButton btnMaximize;
        private System.Windows.Forms.ToolTip totLegendaMenu;
        private Componentes.CustomButton btnEncerrarJanelas;
        private UserControls.Sidebar sidebar1;
        private System.Windows.Forms.Panel pnWorkflow;
    }
}