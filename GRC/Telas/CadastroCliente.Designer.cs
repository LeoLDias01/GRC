namespace GRC.Telas
{
    partial class CadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rbtPJ = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtPF = new MaterialSkin.Controls.MaterialRadioButton();
            this.pcAtivo = new System.Windows.Forms.PictureBox();
            this.swAtivo = new MaterialSkin.Controls.MaterialSwitch();
            this.txtObservacoes = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtNome = new MaterialSkin.Controls.MaterialTextBox();
            this.txtIdentificador = new MaterialSkin.Controls.MaterialTextBox();
            this.pn1 = new GRC.Componentes.RoundedPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkWhatsapp = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtTelefone = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.chkHabilitaEmail = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chkHabilitaEndereco = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtObservacoesEndereco = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtUf = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCidade = new MaterialSkin.Controls.MaterialTextBox();
            this.txtComplemento = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBairro = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNumero = new MaterialSkin.Controls.MaterialTextBox();
            this.txtLogradouro = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCep = new MaterialSkin.Controls.MaterialTextBox();
            this.dgvTelefones = new System.Windows.Forms.DataGridView();
            this.colIdTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWhatsApp = new System.Windows.Forms.DataGridViewImageColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnSalvar = new GRC.Componentes.CustomButton();
            this.pnExterno = new GRC.Componentes.ModernBox();
            this.pnInterno = new GRC.Componentes.CustomPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEncerrarJanelas = new GRC.Componentes.CustomButton();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pcAtivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefones)).BeginInit();
            this.pnExterno.SuspendLayout();
            this.pnInterno.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtPJ
            // 
            this.rbtPJ.AutoSize = true;
            this.rbtPJ.Depth = 0;
            this.rbtPJ.Location = new System.Drawing.Point(163, 26);
            this.rbtPJ.Margin = new System.Windows.Forms.Padding(0);
            this.rbtPJ.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtPJ.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtPJ.Name = "rbtPJ";
            this.rbtPJ.Ripple = true;
            this.rbtPJ.Size = new System.Drawing.Size(148, 37);
            this.rbtPJ.TabIndex = 41;
            this.rbtPJ.TabStop = true;
            this.rbtPJ.Text = "Pessoa Jurídica";
            this.rbtPJ.UseVisualStyleBackColor = true;
            this.rbtPJ.CheckedChanged += new System.EventHandler(this.rbtPJ_CheckedChanged);
            // 
            // rbtPF
            // 
            this.rbtPF.AutoSize = true;
            this.rbtPF.Depth = 0;
            this.rbtPF.Location = new System.Drawing.Point(13, 28);
            this.rbtPF.Margin = new System.Windows.Forms.Padding(0);
            this.rbtPF.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtPF.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtPF.Name = "rbtPF";
            this.rbtPF.Ripple = true;
            this.rbtPF.Size = new System.Drawing.Size(133, 37);
            this.rbtPF.TabIndex = 40;
            this.rbtPF.TabStop = true;
            this.rbtPF.Text = "Pessoa Física";
            this.rbtPF.UseVisualStyleBackColor = true;
            this.rbtPF.CheckedChanged += new System.EventHandler(this.rbtPF_CheckedChanged);
            // 
            // pcAtivo
            // 
            this.pcAtivo.Image = ((System.Drawing.Image)(resources.GetObject("pcAtivo.Image")));
            this.pcAtivo.Location = new System.Drawing.Point(370, 17);
            this.pcAtivo.Name = "pcAtivo";
            this.pcAtivo.Size = new System.Drawing.Size(26, 24);
            this.pcAtivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcAtivo.TabIndex = 38;
            this.pcAtivo.TabStop = false;
            this.pcAtivo.Visible = false;
            // 
            // swAtivo
            // 
            this.swAtivo.AutoSize = true;
            this.swAtivo.Depth = 0;
            this.swAtivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.swAtivo.Location = new System.Drawing.Point(306, 36);
            this.swAtivo.Margin = new System.Windows.Forms.Padding(0);
            this.swAtivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swAtivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.swAtivo.Name = "swAtivo";
            this.swAtivo.Ripple = true;
            this.swAtivo.Size = new System.Drawing.Size(58, 37);
            this.swAtivo.TabIndex = 39;
            this.swAtivo.UseVisualStyleBackColor = true;
            this.swAtivo.CheckedChanged += new System.EventHandler(this.swAtivo_CheckedChanged);
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
            this.txtObservacoes.Location = new System.Drawing.Point(12, 122);
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
            this.txtObservacoes.Size = new System.Drawing.Size(640, 84);
            this.txtObservacoes.TabIndex = 5;
            this.txtObservacoes.TabStop = false;
            this.txtObservacoes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtObservacoes.UseAccent = false;
            this.txtObservacoes.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            this.txtNome.AcceptsTab = true;
            this.txtNome.AnimateReadOnly = false;
            this.txtNome.AutoWordSelection = true;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Depth = 0;
            this.txtNome.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.Hint = "Nome";
            this.txtNome.LeadingIcon = null;
            this.txtNome.LeaveOnEnterKey = true;
            this.txtNome.Location = new System.Drawing.Point(204, 66);
            this.txtNome.MaxLength = 60;
            this.txtNome.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(448, 50);
            this.txtNome.TabIndex = 1;
            this.txtNome.Text = "";
            this.txtNome.TrailingIcon = null;
            this.txtNome.UseAccent = false;
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.AcceptsTab = true;
            this.txtIdentificador.AnimateReadOnly = false;
            this.txtIdentificador.AutoWordSelection = true;
            this.txtIdentificador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentificador.Depth = 0;
            this.txtIdentificador.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdentificador.Hint = "CPF";
            this.txtIdentificador.LeadingIcon = null;
            this.txtIdentificador.LeaveOnEnterKey = true;
            this.txtIdentificador.Location = new System.Drawing.Point(12, 66);
            this.txtIdentificador.MaxLength = 18;
            this.txtIdentificador.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdentificador.Multiline = false;
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(186, 50);
            this.txtIdentificador.TabIndex = 3;
            this.txtIdentificador.Text = "";
            this.txtIdentificador.TrailingIcon = null;
            this.txtIdentificador.UseAccent = false;
            this.txtIdentificador.TextChanged += new System.EventHandler(this.txtIdentificador_TextChanged);
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.Color.Transparent;
            this.pn1.Color1 = System.Drawing.Color.SpringGreen;
            this.pn1.Color2 = System.Drawing.Color.Aqua;
            this.pn1.CornerRadius = 8;
            this.pn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn1.GradientAngle = 300F;
            this.pn1.Location = new System.Drawing.Point(13, 13);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(1179, 8);
            this.pn1.TabIndex = 20;
            this.pn1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CadastroCliente_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // chkWhatsapp
            // 
            this.chkWhatsapp.AutoSize = true;
            this.chkWhatsapp.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkWhatsapp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkWhatsapp.Depth = 0;
            this.chkWhatsapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkWhatsapp.Location = new System.Drawing.Point(12, 56);
            this.chkWhatsapp.Margin = new System.Windows.Forms.Padding(0);
            this.chkWhatsapp.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkWhatsapp.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkWhatsapp.Name = "chkWhatsapp";
            this.chkWhatsapp.ReadOnly = false;
            this.chkWhatsapp.Ripple = true;
            this.chkWhatsapp.Size = new System.Drawing.Size(35, 37);
            this.chkWhatsapp.TabIndex = 11;
            this.chkWhatsapp.UseVisualStyleBackColor = true;
            // 
            // txtTelefone
            // 
            this.txtTelefone.AcceptsTab = true;
            this.txtTelefone.AnimateReadOnly = false;
            this.txtTelefone.AutoWordSelection = true;
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.Depth = 0;
            this.txtTelefone.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefone.Hint = "Telefone";
            this.txtTelefone.LeadingIcon = null;
            this.txtTelefone.LeaveOnEnterKey = true;
            this.txtTelefone.Location = new System.Drawing.Point(97, 43);
            this.txtTelefone.MaxLength = 15;
            this.txtTelefone.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefone.Multiline = false;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(214, 50);
            this.txtTelefone.TabIndex = 10;
            this.txtTelefone.Text = "";
            this.txtTelefone.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtTelefone.TrailingIcon")));
            this.txtTelefone.UseAccent = false;
            this.txtTelefone.TrailingIconClick += new System.EventHandler(this.txtTelefone_TrailingIconClick);
            this.txtTelefone.TextChanged += new System.EventHandler(this.txtTelefone_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(50, 99);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // chkHabilitaEmail
            // 
            this.chkHabilitaEmail.AutoSize = true;
            this.chkHabilitaEmail.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkHabilitaEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHabilitaEmail.Depth = 0;
            this.chkHabilitaEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkHabilitaEmail.Location = new System.Drawing.Point(12, 112);
            this.chkHabilitaEmail.Margin = new System.Windows.Forms.Padding(0);
            this.chkHabilitaEmail.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkHabilitaEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkHabilitaEmail.Name = "chkHabilitaEmail";
            this.chkHabilitaEmail.ReadOnly = false;
            this.chkHabilitaEmail.Ripple = true;
            this.chkHabilitaEmail.Size = new System.Drawing.Size(35, 37);
            this.chkHabilitaEmail.TabIndex = 6;
            this.chkHabilitaEmail.UseVisualStyleBackColor = true;
            this.chkHabilitaEmail.CheckedChanged += new System.EventHandler(this.chkHabilitaEmail_CheckedChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.AcceptsTab = true;
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.AutoWordSelection = true;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Hint = "E-Mail";
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.LeaveOnEnterKey = true;
            this.txtEmail.Location = new System.Drawing.Point(97, 99);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 50);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseAccent = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(442, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // chkHabilitaEndereco
            // 
            this.chkHabilitaEndereco.AutoSize = true;
            this.chkHabilitaEndereco.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkHabilitaEndereco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHabilitaEndereco.Depth = 0;
            this.chkHabilitaEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkHabilitaEndereco.Location = new System.Drawing.Point(404, 38);
            this.chkHabilitaEndereco.Margin = new System.Windows.Forms.Padding(0);
            this.chkHabilitaEndereco.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkHabilitaEndereco.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkHabilitaEndereco.Name = "chkHabilitaEndereco";
            this.chkHabilitaEndereco.ReadOnly = false;
            this.chkHabilitaEndereco.Ripple = true;
            this.chkHabilitaEndereco.Size = new System.Drawing.Size(35, 37);
            this.chkHabilitaEndereco.TabIndex = 16;
            this.chkHabilitaEndereco.UseVisualStyleBackColor = true;
            this.chkHabilitaEndereco.CheckedChanged += new System.EventHandler(this.chkHabilitaEndereco_CheckedChanged);
            // 
            // txtObservacoesEndereco
            // 
            this.txtObservacoesEndereco.AnimateReadOnly = false;
            this.txtObservacoesEndereco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtObservacoesEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtObservacoesEndereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObservacoesEndereco.Depth = 0;
            this.txtObservacoesEndereco.Enabled = false;
            this.txtObservacoesEndereco.HideSelection = true;
            this.txtObservacoesEndereco.Hint = "Observações";
            this.txtObservacoesEndereco.Location = new System.Drawing.Point(15, 317);
            this.txtObservacoesEndereco.MaxLength = 300;
            this.txtObservacoesEndereco.MouseState = MaterialSkin.MouseState.OUT;
            this.txtObservacoesEndereco.Name = "txtObservacoesEndereco";
            this.txtObservacoesEndereco.PasswordChar = '\0';
            this.txtObservacoesEndereco.ReadOnly = false;
            this.txtObservacoesEndereco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObservacoesEndereco.SelectedText = "";
            this.txtObservacoesEndereco.SelectionLength = 0;
            this.txtObservacoesEndereco.SelectionStart = 0;
            this.txtObservacoesEndereco.ShortcutsEnabled = true;
            this.txtObservacoesEndereco.Size = new System.Drawing.Size(471, 147);
            this.txtObservacoesEndereco.TabIndex = 24;
            this.txtObservacoesEndereco.TabStop = false;
            this.txtObservacoesEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtObservacoesEndereco.UseAccent = false;
            this.txtObservacoesEndereco.UseSystemPasswordChar = false;
            // 
            // txtUf
            // 
            this.txtUf.AcceptsTab = true;
            this.txtUf.AnimateReadOnly = false;
            this.txtUf.AutoWordSelection = true;
            this.txtUf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUf.Depth = 0;
            this.txtUf.Enabled = false;
            this.txtUf.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUf.Hint = "UF";
            this.txtUf.LeadingIcon = null;
            this.txtUf.LeaveOnEnterKey = true;
            this.txtUf.Location = new System.Drawing.Point(404, 205);
            this.txtUf.MaxLength = 2;
            this.txtUf.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUf.Multiline = false;
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(82, 50);
            this.txtUf.TabIndex = 23;
            this.txtUf.Text = "";
            this.txtUf.TrailingIcon = null;
            this.txtUf.UseAccent = false;
            // 
            // txtCidade
            // 
            this.txtCidade.AcceptsTab = true;
            this.txtCidade.AnimateReadOnly = false;
            this.txtCidade.AutoWordSelection = true;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCidade.Depth = 0;
            this.txtCidade.Enabled = false;
            this.txtCidade.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCidade.Hint = "Cidade";
            this.txtCidade.LeadingIcon = null;
            this.txtCidade.LeaveOnEnterKey = true;
            this.txtCidade.Location = new System.Drawing.Point(15, 205);
            this.txtCidade.MaxLength = 250;
            this.txtCidade.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCidade.Multiline = false;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(383, 50);
            this.txtCidade.TabIndex = 22;
            this.txtCidade.Text = "";
            this.txtCidade.TrailingIcon = null;
            this.txtCidade.UseAccent = false;
            // 
            // txtComplemento
            // 
            this.txtComplemento.AcceptsTab = true;
            this.txtComplemento.AnimateReadOnly = false;
            this.txtComplemento.AutoWordSelection = true;
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComplemento.Depth = 0;
            this.txtComplemento.Enabled = false;
            this.txtComplemento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtComplemento.Hint = "Complemento";
            this.txtComplemento.LeadingIcon = null;
            this.txtComplemento.LeaveOnEnterKey = true;
            this.txtComplemento.Location = new System.Drawing.Point(15, 261);
            this.txtComplemento.MaxLength = 100;
            this.txtComplemento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtComplemento.Multiline = false;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(471, 50);
            this.txtComplemento.TabIndex = 20;
            this.txtComplemento.Text = "";
            this.txtComplemento.TrailingIcon = null;
            this.txtComplemento.UseAccent = false;
            // 
            // txtBairro
            // 
            this.txtBairro.AcceptsTab = true;
            this.txtBairro.AnimateReadOnly = false;
            this.txtBairro.AutoWordSelection = true;
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBairro.Depth = 0;
            this.txtBairro.Enabled = false;
            this.txtBairro.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBairro.Hint = "Bairro";
            this.txtBairro.LeadingIcon = null;
            this.txtBairro.LeaveOnEnterKey = true;
            this.txtBairro.Location = new System.Drawing.Point(15, 150);
            this.txtBairro.MaxLength = 100;
            this.txtBairro.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBairro.Multiline = false;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(471, 50);
            this.txtBairro.TabIndex = 21;
            this.txtBairro.Text = "";
            this.txtBairro.TrailingIcon = null;
            this.txtBairro.UseAccent = false;
            // 
            // txtNumero
            // 
            this.txtNumero.AcceptsTab = true;
            this.txtNumero.AnimateReadOnly = false;
            this.txtNumero.AutoWordSelection = true;
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.Depth = 0;
            this.txtNumero.Enabled = false;
            this.txtNumero.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumero.Hint = "Nº";
            this.txtNumero.LeadingIcon = null;
            this.txtNumero.LeaveOnEnterKey = true;
            this.txtNumero.Location = new System.Drawing.Point(404, 94);
            this.txtNumero.MaxLength = 8;
            this.txtNumero.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumero.Multiline = false;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(82, 50);
            this.txtNumero.TabIndex = 19;
            this.txtNumero.Text = "";
            this.txtNumero.TrailingIcon = null;
            this.txtNumero.UseAccent = false;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.AcceptsTab = true;
            this.txtLogradouro.AnimateReadOnly = false;
            this.txtLogradouro.AutoWordSelection = true;
            this.txtLogradouro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogradouro.Depth = 0;
            this.txtLogradouro.Enabled = false;
            this.txtLogradouro.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLogradouro.Hint = "Logradouro";
            this.txtLogradouro.LeadingIcon = null;
            this.txtLogradouro.LeaveOnEnterKey = true;
            this.txtLogradouro.Location = new System.Drawing.Point(15, 94);
            this.txtLogradouro.MaxLength = 200;
            this.txtLogradouro.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLogradouro.Multiline = false;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(383, 50);
            this.txtLogradouro.TabIndex = 18;
            this.txtLogradouro.Text = "";
            this.txtLogradouro.TrailingIcon = null;
            this.txtLogradouro.UseAccent = false;
            // 
            // txtCep
            // 
            this.txtCep.AcceptsTab = true;
            this.txtCep.AnimateReadOnly = false;
            this.txtCep.AutoWordSelection = true;
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCep.Depth = 0;
            this.txtCep.Enabled = false;
            this.txtCep.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCep.Hint = "CEP";
            this.txtCep.LeadingIcon = null;
            this.txtCep.LeaveOnEnterKey = true;
            this.txtCep.Location = new System.Drawing.Point(15, 38);
            this.txtCep.MaxLength = 9;
            this.txtCep.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCep.Multiline = false;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(179, 50);
            this.txtCep.TabIndex = 17;
            this.txtCep.Text = "";
            this.txtCep.TrailingIcon = null;
            this.txtCep.UseAccent = false;
            this.txtCep.TextChanged += new System.EventHandler(this.txtCep_TextChanged);
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // dgvTelefones
            // 
            this.dgvTelefones.AllowUserToAddRows = false;
            this.dgvTelefones.AllowUserToDeleteRows = false;
            this.dgvTelefones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTelefones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTelefones.BackgroundColor = System.Drawing.Color.White;
            this.dgvTelefones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTelefones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTelefones.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvTelefones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTelefones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTelefones.ColumnHeadersHeight = 35;
            this.dgvTelefones.ColumnHeadersVisible = false;
            this.dgvTelefones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdTelefone,
            this.colWhatsApp,
            this.colTelefone,
            this.colExcluir});
            this.dgvTelefones.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTelefones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTelefones.EnableHeadersVisualStyles = false;
            this.dgvTelefones.GridColor = System.Drawing.Color.Black;
            this.dgvTelefones.Location = new System.Drawing.Point(317, 37);
            this.dgvTelefones.MultiSelect = false;
            this.dgvTelefones.Name = "dgvTelefones";
            this.dgvTelefones.ReadOnly = true;
            this.dgvTelefones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTelefones.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTelefones.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTelefones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelefones.Size = new System.Drawing.Size(336, 209);
            this.dgvTelefones.TabIndex = 25;
            this.dgvTelefones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTelefones_CellClick);
            this.dgvTelefones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTelefones_CellDoubleClick);
            // 
            // colIdTelefone
            // 
            this.colIdTelefone.FillWeight = 1F;
            this.colIdTelefone.HeaderText = "Id";
            this.colIdTelefone.Name = "colIdTelefone";
            this.colIdTelefone.ReadOnly = true;
            this.colIdTelefone.Visible = false;
            // 
            // colWhatsApp
            // 
            this.colWhatsApp.FillWeight = 45F;
            this.colWhatsApp.HeaderText = "";
            this.colWhatsApp.Name = "colWhatsApp";
            this.colWhatsApp.ReadOnly = true;
            // 
            // colTelefone
            // 
            this.colTelefone.FillWeight = 250F;
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;
            // 
            // colExcluir
            // 
            this.colExcluir.FillWeight = 45F;
            this.colExcluir.HeaderText = "";
            this.colExcluir.Name = "colExcluir";
            this.colExcluir.ReadOnly = true;
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
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(1040, 50);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSalvar.Size = new System.Drawing.Size(127, 37);
            this.btnSalvar.TabIndex = 160;
            this.btnSalvar.TamanhoBorda = 0;
            this.btnSalvar.TamanhoRaio = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pnExterno
            // 
            this.pnExterno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnExterno.BackColor = System.Drawing.Color.Transparent;
            this.pnExterno.BorderColor = System.Drawing.Color.White;
            this.pnExterno.BorderRadius = 12;
            this.pnExterno.BorderSize = 1;
            this.pnExterno.Controls.Add(this.pnInterno);
            this.pnExterno.Controls.Add(this.pn1);
            this.pnExterno.FillColor = System.Drawing.Color.White;
            this.pnExterno.Location = new System.Drawing.Point(-2, -11);
            this.pnExterno.Name = "pnExterno";
            this.pnExterno.Padding = new System.Windows.Forms.Padding(13);
            this.pnExterno.ShadowAngle = 90;
            this.pnExterno.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnExterno.ShadowSize = 8;
            this.pnExterno.Size = new System.Drawing.Size(1205, 631);
            this.pnExterno.TabIndex = 165;
            this.pnExterno.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CadastroCliente_MouseDown);
            // 
            // pnInterno
            // 
            this.pnInterno.BackColor = System.Drawing.Color.White;
            this.pnInterno.Controls.Add(this.btnSalvar);
            this.pnInterno.Controls.Add(this.groupBox3);
            this.pnInterno.Controls.Add(this.pcAtivo);
            this.pnInterno.Controls.Add(this.swAtivo);
            this.pnInterno.Controls.Add(this.groupBox1);
            this.pnInterno.Controls.Add(this.groupBox2);
            this.pnInterno.Controls.Add(this.label11);
            this.pnInterno.Controls.Add(this.btnEncerrarJanelas);
            this.pnInterno.Controls.Add(this.pictureBox7);
            this.pnInterno.Controls.Add(this.lbTitulo);
            this.pnInterno.Controls.Add(this.panel1);
            this.pnInterno.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.pnInterno.CorBotao = System.Drawing.Color.White;
            this.pnInterno.CorTextoBotao = System.Drawing.Color.White;
            this.pnInterno.ForeColor = System.Drawing.Color.White;
            this.pnInterno.Location = new System.Drawing.Point(16, 23);
            this.pnInterno.Name = "pnInterno";
            this.pnInterno.Size = new System.Drawing.Size(1170, 579);
            this.pnInterno.TabIndex = 0;
            this.pnInterno.TamanhoBorda = 0;
            this.pnInterno.TamanhoRaio = 15;
            this.pnInterno.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CadastroCliente_MouseDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtUf);
            this.groupBox3.Controls.Add(this.txtObservacoesEndereco);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.txtComplemento);
            this.groupBox3.Controls.Add(this.txtCidade);
            this.groupBox3.Controls.Add(this.chkHabilitaEndereco);
            this.groupBox3.Controls.Add(this.txtNumero);
            this.groupBox3.Controls.Add(this.txtBairro);
            this.groupBox3.Controls.Add(this.txtCep);
            this.groupBox3.Controls.Add(this.txtLogradouro);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.groupBox3.Location = new System.Drawing.Point(676, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(490, 477);
            this.groupBox3.TabIndex = 180;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Endereço";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.dgvTelefones);
            this.groupBox1.Controls.Add(this.chkHabilitaEmail);
            this.groupBox1.Controls.Add(this.chkWhatsapp);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 259);
            this.groupBox1.TabIndex = 180;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contatos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtPJ);
            this.groupBox2.Controls.Add(this.rbtPF);
            this.groupBox2.Controls.Add(this.txtObservacoes);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.txtIdentificador);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.groupBox2.Location = new System.Drawing.Point(3, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 212);
            this.groupBox2.TabIndex = 179;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados de Cliente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(74, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 20);
            this.label11.TabIndex = 172;
            this.label11.Text = "Informe os dados do cliente";
            this.label11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CadastroCliente_MouseDown);
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
            this.btnEncerrarJanelas.Location = new System.Drawing.Point(1146, 3);
            this.btnEncerrarJanelas.Name = "btnEncerrarJanelas";
            this.btnEncerrarJanelas.Size = new System.Drawing.Size(18, 18);
            this.btnEncerrarJanelas.TabIndex = 163;
            this.btnEncerrarJanelas.TamanhoBorda = 0;
            this.btnEncerrarJanelas.TamanhoRaio = 5;
            this.btnEncerrarJanelas.UseVisualStyleBackColor = false;
            this.btnEncerrarJanelas.Click += new System.EventHandler(this.btnEncerrarJanelas_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(16, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(52, 52);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 140;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CadastroCliente_MouseDown);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.lbTitulo.Location = new System.Drawing.Point(74, 12);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(245, 29);
            this.lbTitulo.TabIndex = 139;
            this.lbTitulo.Text = "Cadastro de Cliente";
            this.lbTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CadastroCliente_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(668, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 455);
            this.panel1.TabIndex = 26;
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 622);
            this.Controls.Add(this.pnExterno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cadastro de Cliente";
            this.Load += new System.EventHandler(this.CadastroCliente_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CadastroCliente_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcAtivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefones)).EndInit();
            this.pnExterno.ResumeLayout(false);
            this.pnInterno.ResumeLayout(false);
            this.pnInterno.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtObservacoes;
        private MaterialSkin.Controls.MaterialTextBox txtIdentificador;
        private MaterialSkin.Controls.MaterialTextBox txtNome;
        private Componentes.RoundedPanel pn1;
        private System.Windows.Forms.PictureBox pcAtivo;
        private MaterialSkin.Controls.MaterialSwitch swAtivo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCheckbox chkWhatsapp;
        private MaterialSkin.Controls.MaterialTextBox txtTelefone;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialCheckbox chkHabilitaEmail;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialCheckbox chkHabilitaEndereco;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtObservacoesEndereco;
        private MaterialSkin.Controls.MaterialTextBox txtUf;
        private MaterialSkin.Controls.MaterialTextBox txtCidade;
        private MaterialSkin.Controls.MaterialTextBox txtComplemento;
        private MaterialSkin.Controls.MaterialTextBox txtBairro;
        private MaterialSkin.Controls.MaterialTextBox txtNumero;
        private MaterialSkin.Controls.MaterialTextBox txtLogradouro;
        private MaterialSkin.Controls.MaterialTextBox txtCep;
        private System.Windows.Forms.DataGridView dgvTelefones;
        private MaterialSkin.Controls.MaterialRadioButton rbtPF;
        private MaterialSkin.Controls.MaterialRadioButton rbtPJ;
        private Componentes.CustomButton btnSalvar;
        private Componentes.ModernBox pnExterno;
        private Componentes.CustomPanel pnInterno;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private Componentes.CustomButton btnEncerrarJanelas;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdTelefone;
        private System.Windows.Forms.DataGridViewImageColumn colWhatsApp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewImageColumn colExcluir;
    }
}