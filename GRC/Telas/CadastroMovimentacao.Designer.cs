namespace GRC.Telas
{
    partial class CadastroMovimentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroMovimentacao));
            this.customPanel1 = new GRC.Componentes.CustomPanel();
            this.pcAtivo = new System.Windows.Forms.PictureBox();
            this.swItemAtivo = new MaterialSkin.Controls.MaterialSwitch();
            this.gpbInfoVenda = new System.Windows.Forms.GroupBox();
            this.txtData = new MaterialSkin.Controls.MaterialTextBox();
            this.cbTipoMovimento = new MaterialSkin.Controls.MaterialComboBox();
            this.txtItem = new MaterialSkin.Controls.MaterialTextBox();
            this.txtQuantidade = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMotivo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCustoUnitario = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCustoTotal = new MaterialSkin.Controls.MaterialTextBox();
            this.txtObservacoes = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pnStatus = new GRC.Componentes.RoundedPanel();
            this.pnStatus2 = new GRC.Componentes.RoundedPanel();
            this.btnSalvar = new GRC.Componentes.CustomButton();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcAtivo)).BeginInit();
            this.gpbInfoVenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.customPanel1.Controls.Add(this.pcAtivo);
            this.customPanel1.Controls.Add(this.swItemAtivo);
            this.customPanel1.Controls.Add(this.gpbInfoVenda);
            this.customPanel1.Controls.Add(this.materialLabel1);
            this.customPanel1.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.customPanel1.CorBotao = System.Drawing.Color.AliceBlue;
            this.customPanel1.CorTextoBotao = System.Drawing.Color.White;
            this.customPanel1.ForeColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(12, 48);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(768, 313);
            this.customPanel1.TabIndex = 52;
            this.customPanel1.TamanhoBorda = 0;
            this.customPanel1.TamanhoRaio = 20;
            // 
            // pcAtivo
            // 
            this.pcAtivo.Image = ((System.Drawing.Image)(resources.GetObject("pcAtivo.Image")));
            this.pcAtivo.Location = new System.Drawing.Point(269, 10);
            this.pcAtivo.Name = "pcAtivo";
            this.pcAtivo.Size = new System.Drawing.Size(35, 36);
            this.pcAtivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcAtivo.TabIndex = 77;
            this.pcAtivo.TabStop = false;
            this.pcAtivo.Visible = false;
            // 
            // swItemAtivo
            // 
            this.swItemAtivo.AutoSize = true;
            this.swItemAtivo.Depth = 0;
            this.swItemAtivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.swItemAtivo.Location = new System.Drawing.Point(313, 9);
            this.swItemAtivo.Margin = new System.Windows.Forms.Padding(0);
            this.swItemAtivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swItemAtivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.swItemAtivo.Name = "swItemAtivo";
            this.swItemAtivo.Ripple = true;
            this.swItemAtivo.Size = new System.Drawing.Size(94, 37);
            this.swItemAtivo.TabIndex = 76;
            this.swItemAtivo.Text = "Ativo";
            this.swItemAtivo.UseVisualStyleBackColor = true;
            this.swItemAtivo.CheckedChanged += new System.EventHandler(this.swItemAtivo_CheckedChanged);
            // 
            // gpbInfoVenda
            // 
            this.gpbInfoVenda.Controls.Add(this.txtData);
            this.gpbInfoVenda.Controls.Add(this.cbTipoMovimento);
            this.gpbInfoVenda.Controls.Add(this.txtItem);
            this.gpbInfoVenda.Controls.Add(this.txtObservacoes);
            this.gpbInfoVenda.Controls.Add(this.txtQuantidade);
            this.gpbInfoVenda.Controls.Add(this.txtCustoTotal);
            this.gpbInfoVenda.Controls.Add(this.txtMotivo);
            this.gpbInfoVenda.Controls.Add(this.txtCustoUnitario);
            this.gpbInfoVenda.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfoVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.gpbInfoVenda.Location = new System.Drawing.Point(11, 52);
            this.gpbInfoVenda.Name = "gpbInfoVenda";
            this.gpbInfoVenda.Size = new System.Drawing.Size(739, 247);
            this.gpbInfoVenda.TabIndex = 75;
            this.gpbInfoVenda.TabStop = false;
            this.gpbInfoVenda.Text = " Dados da Movimentação";
            // 
            // txtData
            // 
            this.txtData.AcceptsTab = true;
            this.txtData.AnimateReadOnly = false;
            this.txtData.AutoWordSelection = true;
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtData.Depth = 0;
            this.txtData.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtData.Hint = "Data";
            this.txtData.LeadingIcon = null;
            this.txtData.LeaveOnEnterKey = true;
            this.txtData.Location = new System.Drawing.Point(9, 26);
            this.txtData.MaxLength = 60;
            this.txtData.MouseState = MaterialSkin.MouseState.OUT;
            this.txtData.Multiline = false;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(150, 50);
            this.txtData.TabIndex = 101;
            this.txtData.Text = "";
            this.txtData.TrailingIcon = null;
            this.txtData.UseAccent = false;
            this.txtData.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            this.txtData.Leave += new System.EventHandler(this.txtData_Leave);
            // 
            // cbTipoMovimento
            // 
            this.cbTipoMovimento.AutoResize = false;
            this.cbTipoMovimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbTipoMovimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTipoMovimento.Depth = 0;
            this.cbTipoMovimento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbTipoMovimento.DropDownHeight = 174;
            this.cbTipoMovimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoMovimento.DropDownWidth = 121;
            this.cbTipoMovimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbTipoMovimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTipoMovimento.FormattingEnabled = true;
            this.cbTipoMovimento.Hint = "Tipo de Movimentação";
            this.cbTipoMovimento.IntegralHeight = false;
            this.cbTipoMovimento.ItemHeight = 43;
            this.cbTipoMovimento.Location = new System.Drawing.Point(165, 26);
            this.cbTipoMovimento.MaxDropDownItems = 4;
            this.cbTipoMovimento.MouseState = MaterialSkin.MouseState.OUT;
            this.cbTipoMovimento.Name = "cbTipoMovimento";
            this.cbTipoMovimento.Size = new System.Drawing.Size(231, 49);
            this.cbTipoMovimento.StartIndex = 0;
            this.cbTipoMovimento.TabIndex = 80;
            this.cbTipoMovimento.UseAccent = false;
            this.cbTipoMovimento.SelectedValueChanged += new System.EventHandler(this.cbTipoMovimento_SelectedValueChanged);
            // 
            // txtItem
            // 
            this.txtItem.AcceptsTab = true;
            this.txtItem.AnimateReadOnly = true;
            this.txtItem.AutoWordSelection = true;
            this.txtItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItem.Depth = 0;
            this.txtItem.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtItem.Hint = "Item";
            this.txtItem.LeadingIcon = null;
            this.txtItem.LeaveOnEnterKey = true;
            this.txtItem.Location = new System.Drawing.Point(402, 26);
            this.txtItem.MaxLength = 60;
            this.txtItem.MouseState = MaterialSkin.MouseState.OUT;
            this.txtItem.Multiline = false;
            this.txtItem.Name = "txtItem";
            this.txtItem.ReadOnly = true;
            this.txtItem.Size = new System.Drawing.Size(317, 50);
            this.txtItem.TabIndex = 46;
            this.txtItem.Text = "";
            this.txtItem.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtItem.TrailingIcon")));
            this.txtItem.UseAccent = false;
            this.txtItem.TrailingIconClick += new System.EventHandler(this.txtItem_TrailingIconClick);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.AcceptsTab = true;
            this.txtQuantidade.AnimateReadOnly = false;
            this.txtQuantidade.AutoWordSelection = true;
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantidade.Depth = 0;
            this.txtQuantidade.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuantidade.Hint = "Qtd";
            this.txtQuantidade.LeadingIcon = null;
            this.txtQuantidade.LeaveOnEnterKey = true;
            this.txtQuantidade.Location = new System.Drawing.Point(9, 81);
            this.txtQuantidade.MaxLength = 60;
            this.txtQuantidade.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQuantidade.Multiline = false;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(150, 50);
            this.txtQuantidade.TabIndex = 93;
            this.txtQuantidade.Text = "";
            this.txtQuantidade.TrailingIcon = null;
            this.txtQuantidade.UseAccent = false;
            // 
            // txtMotivo
            // 
            this.txtMotivo.AcceptsTab = true;
            this.txtMotivo.AnimateReadOnly = false;
            this.txtMotivo.AutoWordSelection = true;
            this.txtMotivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMotivo.Depth = 0;
            this.txtMotivo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMotivo.Hint = "Motivo da Transação";
            this.txtMotivo.LeadingIcon = null;
            this.txtMotivo.LeaveOnEnterKey = true;
            this.txtMotivo.Location = new System.Drawing.Point(165, 81);
            this.txtMotivo.MaxLength = 60;
            this.txtMotivo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMotivo.Multiline = false;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(554, 50);
            this.txtMotivo.TabIndex = 104;
            this.txtMotivo.Text = "";
            this.txtMotivo.TrailingIcon = null;
            this.txtMotivo.UseAccent = false;
            // 
            // txtCustoUnitario
            // 
            this.txtCustoUnitario.AcceptsTab = true;
            this.txtCustoUnitario.AnimateReadOnly = false;
            this.txtCustoUnitario.AutoWordSelection = true;
            this.txtCustoUnitario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustoUnitario.Depth = 0;
            this.txtCustoUnitario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustoUnitario.Hint = "Custo unitário";
            this.txtCustoUnitario.LeadingIcon = null;
            this.txtCustoUnitario.LeaveOnEnterKey = true;
            this.txtCustoUnitario.Location = new System.Drawing.Point(9, 137);
            this.txtCustoUnitario.MaxLength = 60;
            this.txtCustoUnitario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCustoUnitario.Multiline = false;
            this.txtCustoUnitario.Name = "txtCustoUnitario";
            this.txtCustoUnitario.Size = new System.Drawing.Size(150, 50);
            this.txtCustoUnitario.TabIndex = 102;
            this.txtCustoUnitario.Text = "";
            this.txtCustoUnitario.TrailingIcon = null;
            this.txtCustoUnitario.UseAccent = false;
            this.txtCustoUnitario.Visible = false;
            this.txtCustoUnitario.TextChanged += new System.EventHandler(this.txtCustoUnitario_TextChanged);
            this.txtCustoUnitario.Enter += new System.EventHandler(this.txtCustoUnitario_Enter);
            this.txtCustoUnitario.Leave += new System.EventHandler(this.txtCustoUnitario_Leave);
            // 
            // txtCustoTotal
            // 
            this.txtCustoTotal.AcceptsTab = true;
            this.txtCustoTotal.AnimateReadOnly = false;
            this.txtCustoTotal.AutoWordSelection = true;
            this.txtCustoTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustoTotal.Depth = 0;
            this.txtCustoTotal.Enabled = false;
            this.txtCustoTotal.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustoTotal.Hint = "Custo Total";
            this.txtCustoTotal.LeadingIcon = null;
            this.txtCustoTotal.LeaveOnEnterKey = true;
            this.txtCustoTotal.Location = new System.Drawing.Point(9, 193);
            this.txtCustoTotal.MaxLength = 60;
            this.txtCustoTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCustoTotal.Multiline = false;
            this.txtCustoTotal.Name = "txtCustoTotal";
            this.txtCustoTotal.Size = new System.Drawing.Size(150, 50);
            this.txtCustoTotal.TabIndex = 103;
            this.txtCustoTotal.Text = "";
            this.txtCustoTotal.TrailingIcon = null;
            this.txtCustoTotal.UseAccent = false;
            this.txtCustoTotal.Visible = false;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObservacoes.AnimateReadOnly = false;
            this.txtObservacoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtObservacoes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtObservacoes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObservacoes.Depth = 0;
            this.txtObservacoes.HideSelection = true;
            this.txtObservacoes.Hint = "Observações";
            this.txtObservacoes.Location = new System.Drawing.Point(165, 137);
            this.txtObservacoes.MaxLength = 300;
            this.txtObservacoes.MouseState = MaterialSkin.MouseState.OUT;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.PasswordChar = '\0';
            this.txtObservacoes.ReadOnly = false;
            this.txtObservacoes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObservacoes.SelectedText = "";
            this.txtObservacoes.SelectionLength = 0;
            this.txtObservacoes.SelectionStart = 0;
            this.txtObservacoes.ShortcutsEnabled = true;
            this.txtObservacoes.Size = new System.Drawing.Size(554, 106);
            this.txtObservacoes.TabIndex = 83;
            this.txtObservacoes.TabStop = false;
            this.txtObservacoes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtObservacoes.UseAccent = false;
            this.txtObservacoes.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.SlateGray;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.materialLabel1.Location = new System.Drawing.Point(25, 15);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(238, 24);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Movimentação de Estoque";
            // 
            // pnStatus
            // 
            this.pnStatus.BackColor = System.Drawing.Color.Transparent;
            this.pnStatus.Color1 = System.Drawing.Color.Aquamarine;
            this.pnStatus.Color2 = System.Drawing.Color.DarkTurquoise;
            this.pnStatus.CornerRadius = 10;
            this.pnStatus.GradientAngle = 90F;
            this.pnStatus.Location = new System.Drawing.Point(89, 5);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(540, 37);
            this.pnStatus.TabIndex = 53;
            // 
            // pnStatus2
            // 
            this.pnStatus2.BackColor = System.Drawing.Color.Transparent;
            this.pnStatus2.Color1 = System.Drawing.Color.Aquamarine;
            this.pnStatus2.Color2 = System.Drawing.Color.DarkTurquoise;
            this.pnStatus2.CornerRadius = 10;
            this.pnStatus2.GradientAngle = 90F;
            this.pnStatus2.Location = new System.Drawing.Point(12, 5);
            this.pnStatus2.Name = "pnStatus2";
            this.pnStatus2.Size = new System.Drawing.Size(71, 37);
            this.pnStatus2.TabIndex = 54;
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
            this.btnSalvar.Location = new System.Drawing.Point(635, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSalvar.Size = new System.Drawing.Size(145, 37);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.TamanhoBorda = 0;
            this.btnSalvar.TamanhoRaio = 5;
            this.btnSalvar.Text = "    Salvar Dados";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // CadastroMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(792, 370);
            this.Controls.Add(this.pnStatus2);
            this.Controls.Add(this.pnStatus);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.btnSalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroMovimentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroMovimentacao";
            this.Load += new System.EventHandler(this.CadastroMovimentacao_Load);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcAtivo)).EndInit();
            this.gpbInfoVenda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.CustomPanel customPanel1;
        private System.Windows.Forms.GroupBox gpbInfoVenda;
        private MaterialSkin.Controls.MaterialTextBox txtData;
        private MaterialSkin.Controls.MaterialTextBox txtQuantidade;
        private MaterialSkin.Controls.MaterialTextBox txtItem;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtObservacoes;
        private MaterialSkin.Controls.MaterialComboBox cbTipoMovimento;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Componentes.CustomButton btnSalvar;
        private Componentes.RoundedPanel pnStatus;
        private MaterialSkin.Controls.MaterialTextBox txtCustoTotal;
        private MaterialSkin.Controls.MaterialTextBox txtCustoUnitario;
        private MaterialSkin.Controls.MaterialTextBox txtMotivo;
        private Componentes.RoundedPanel pnStatus2;
        private MaterialSkin.Controls.MaterialSwitch swItemAtivo;
        private System.Windows.Forms.PictureBox pcAtivo;
    }
}