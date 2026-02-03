namespace GRC.Telas
{
    partial class CadastroOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroOS));
            this.pn2 = new GRC.Componentes.RoundedPanel();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnExportar = new GRC.Componentes.CustomButton();
            this.pn1 = new GRC.Componentes.RoundedPanel();
            this.lbDataAtual = new System.Windows.Forms.Label();
            this.customPanel1 = new GRC.Componentes.CustomPanel();
            this.pnItens = new GRC.Componentes.CustomPanel();
            this.flpItens = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConsultaItem = new GRC.Componentes.CustomButton();
            this.gpbInfoVenda = new System.Windows.Forms.GroupBox();
            this.pcAjuda = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMaoObra = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTotalPecas = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTotalServico = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDesconto = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAcrescimo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtFimReal = new MaterialSkin.Controls.MaterialTextBox();
            this.txtFimPrevisto = new MaterialSkin.Controls.MaterialTextBox();
            this.cbStatus = new MaterialSkin.Controls.MaterialComboBox();
            this.txtDataEntrada = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCadastraTipoServico = new GRC.Componentes.CustomButton();
            this.txtFimGarantia = new MaterialSkin.Controls.MaterialTextBox();
            this.txtInicioGarantia = new MaterialSkin.Controls.MaterialTextBox();
            this.txtObservacoes = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.cbTipoServico = new MaterialSkin.Controls.MaterialComboBox();
            this.btnBuscaCliente = new GRC.Componentes.CustomButton();
            this.txtDescricao = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtId = new MaterialSkin.Controls.MaterialTextBox();
            this.txtGarantia = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCliente = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovoItem = new GRC.Componentes.CustomButton();
            this.pcbFavorito = new GRC.Componentes.CustomPictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSalvar = new GRC.Componentes.CustomButton();
            this.ttAjuda = new System.Windows.Forms.ToolTip(this.components);
            this.pn2.SuspendLayout();
            this.pn1.SuspendLayout();
            this.customPanel1.SuspendLayout();
            this.pnItens.SuspendLayout();
            this.gpbInfoVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcAjuda)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFavorito)).BeginInit();
            this.SuspendLayout();
            // 
            // pn2
            // 
            this.pn2.BackColor = System.Drawing.Color.Transparent;
            this.pn2.Color1 = System.Drawing.Color.Cyan;
            this.pn2.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.pn2.Controls.Add(this.lbStatus);
            this.pn2.CornerRadius = 10;
            this.pn2.GradientAngle = 90F;
            this.pn2.Location = new System.Drawing.Point(175, 4);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(692, 37);
            this.pn2.TabIndex = 6;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.lbStatus.ForeColor = System.Drawing.Color.Black;
            this.lbStatus.Location = new System.Drawing.Point(18, 9);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(99, 19);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "Não Iniciado";
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExportar.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnExportar.CorBotao = System.Drawing.Color.MediumSeaGreen;
            this.btnExportar.CorTextoBotao = System.Drawing.Color.White;
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(873, 4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExportar.Size = new System.Drawing.Size(144, 37);
            this.btnExportar.TabIndex = 58;
            this.btnExportar.TamanhoBorda = 0;
            this.btnExportar.TamanhoRaio = 5;
            this.btnExportar.Text = "       Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttAjuda.SetToolTip(this.btnExportar, "Gera os arquivos em PDF com os dados desta OS");
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.Color.Transparent;
            this.pn1.Color1 = System.Drawing.Color.Cyan;
            this.pn1.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.pn1.Controls.Add(this.lbDataAtual);
            this.pn1.CornerRadius = 10;
            this.pn1.GradientAngle = 90F;
            this.pn1.Location = new System.Drawing.Point(12, 4);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(157, 37);
            this.pn1.TabIndex = 5;
            // 
            // lbDataAtual
            // 
            this.lbDataAtual.AutoSize = true;
            this.lbDataAtual.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.lbDataAtual.ForeColor = System.Drawing.Color.Black;
            this.lbDataAtual.Location = new System.Drawing.Point(22, 9);
            this.lbDataAtual.Name = "lbDataAtual";
            this.lbDataAtual.Size = new System.Drawing.Size(93, 19);
            this.lbDataAtual.TabIndex = 1;
            this.lbDataAtual.Text = "15/01/2026";
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.customPanel1.Controls.Add(this.pnItens);
            this.customPanel1.Controls.Add(this.btnConsultaItem);
            this.customPanel1.Controls.Add(this.gpbInfoVenda);
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.Controls.Add(this.btnNovoItem);
            this.customPanel1.Controls.Add(this.pcbFavorito);
            this.customPanel1.Controls.Add(this.materialLabel1);
            this.customPanel1.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.customPanel1.CorBotao = System.Drawing.Color.AliceBlue;
            this.customPanel1.CorTextoBotao = System.Drawing.Color.White;
            this.customPanel1.ForeColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(12, 47);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1155, 638);
            this.customPanel1.TabIndex = 3;
            this.customPanel1.TamanhoBorda = 0;
            this.customPanel1.TamanhoRaio = 20;
            // 
            // pnItens
            // 
            this.pnItens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.pnItens.Controls.Add(this.flpItens);
            this.pnItens.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.pnItens.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.pnItens.CorTextoBotao = System.Drawing.Color.White;
            this.pnItens.ForeColor = System.Drawing.Color.White;
            this.pnItens.Location = new System.Drawing.Point(703, 106);
            this.pnItens.Name = "pnItens";
            this.pnItens.Size = new System.Drawing.Size(440, 522);
            this.pnItens.TabIndex = 80;
            this.pnItens.TamanhoBorda = 0;
            this.pnItens.TamanhoRaio = 20;
            // 
            // flpItens
            // 
            this.flpItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpItens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.flpItens.Location = new System.Drawing.Point(0, 12);
            this.flpItens.Name = "flpItens";
            this.flpItens.Size = new System.Drawing.Size(440, 497);
            this.flpItens.TabIndex = 79;
            // 
            // btnConsultaItem
            // 
            this.btnConsultaItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnConsultaItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConsultaItem.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnConsultaItem.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnConsultaItem.CorTextoBotao = System.Drawing.Color.White;
            this.btnConsultaItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaItem.FlatAppearance.BorderSize = 0;
            this.btnConsultaItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnConsultaItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaItem.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultaItem.ForeColor = System.Drawing.Color.White;
            this.btnConsultaItem.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaItem.Image")));
            this.btnConsultaItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaItem.Location = new System.Drawing.Point(703, 63);
            this.btnConsultaItem.Name = "btnConsultaItem";
            this.btnConsultaItem.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnConsultaItem.Size = new System.Drawing.Size(440, 37);
            this.btnConsultaItem.TabIndex = 78;
            this.btnConsultaItem.TamanhoBorda = 0;
            this.btnConsultaItem.TamanhoRaio = 15;
            this.btnConsultaItem.Text = "                                    Adicionar Item";
            this.btnConsultaItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultaItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttAjuda.SetToolTip(this.btnConsultaItem, "Ao adicionar um item ele fica vinculado a OS");
            this.btnConsultaItem.UseVisualStyleBackColor = false;
            this.btnConsultaItem.Click += new System.EventHandler(this.btnConsultaItem_Click);
            // 
            // gpbInfoVenda
            // 
            this.gpbInfoVenda.Controls.Add(this.pcAjuda);
            this.gpbInfoVenda.Controls.Add(this.groupBox1);
            this.gpbInfoVenda.Controls.Add(this.txtFimReal);
            this.gpbInfoVenda.Controls.Add(this.txtFimPrevisto);
            this.gpbInfoVenda.Controls.Add(this.cbStatus);
            this.gpbInfoVenda.Controls.Add(this.txtDataEntrada);
            this.gpbInfoVenda.Controls.Add(this.btnCadastraTipoServico);
            this.gpbInfoVenda.Controls.Add(this.txtFimGarantia);
            this.gpbInfoVenda.Controls.Add(this.txtInicioGarantia);
            this.gpbInfoVenda.Controls.Add(this.txtObservacoes);
            this.gpbInfoVenda.Controls.Add(this.cbTipoServico);
            this.gpbInfoVenda.Controls.Add(this.btnBuscaCliente);
            this.gpbInfoVenda.Controls.Add(this.txtDescricao);
            this.gpbInfoVenda.Controls.Add(this.txtId);
            this.gpbInfoVenda.Controls.Add(this.txtGarantia);
            this.gpbInfoVenda.Controls.Add(this.txtCliente);
            this.gpbInfoVenda.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfoVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.gpbInfoVenda.Location = new System.Drawing.Point(11, 54);
            this.gpbInfoVenda.Name = "gpbInfoVenda";
            this.gpbInfoVenda.Size = new System.Drawing.Size(686, 574);
            this.gpbInfoVenda.TabIndex = 75;
            this.gpbInfoVenda.TabStop = false;
            this.gpbInfoVenda.Text = "Dados da OS";
            // 
            // pcAjuda
            // 
            this.pcAjuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcAjuda.Image = ((System.Drawing.Image)(resources.GetObject("pcAjuda.Image")));
            this.pcAjuda.Location = new System.Drawing.Point(106, 0);
            this.pcAjuda.Name = "pcAjuda";
            this.pcAjuda.Size = new System.Drawing.Size(20, 18);
            this.pcAjuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcAjuda.TabIndex = 81;
            this.pcAjuda.TabStop = false;
            this.ttAjuda.SetToolTip(this.pcAjuda, "Para Salvar a OS é preciso preencher os dados \r\nCaso o Status seja Cancelado ou F" +
        "inalizado \r\nnão será possível adicionar mais itens");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtMaoObra);
            this.groupBox1.Controls.Add(this.txtTotalPecas);
            this.groupBox1.Controls.Add(this.txtTotalServico);
            this.groupBox1.Controls.Add(this.txtDesconto);
            this.groupBox1.Controls.Add(this.txtAcrescimo);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(459, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 403);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orçamento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 275);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            // 
            // txtMaoObra
            // 
            this.txtMaoObra.AcceptsTab = true;
            this.txtMaoObra.AnimateReadOnly = false;
            this.txtMaoObra.AutoWordSelection = true;
            this.txtMaoObra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaoObra.Depth = 0;
            this.txtMaoObra.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMaoObra.Hint = "Valor da mão de obra";
            this.txtMaoObra.LeadingIcon = null;
            this.txtMaoObra.LeaveOnEnterKey = true;
            this.txtMaoObra.Location = new System.Drawing.Point(6, 39);
            this.txtMaoObra.MaxLength = 60;
            this.txtMaoObra.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaoObra.Multiline = false;
            this.txtMaoObra.Name = "txtMaoObra";
            this.txtMaoObra.Size = new System.Drawing.Size(209, 50);
            this.txtMaoObra.TabIndex = 88;
            this.txtMaoObra.Text = "";
            this.txtMaoObra.TrailingIcon = null;
            this.txtMaoObra.UseAccent = false;
            this.txtMaoObra.TextChanged += new System.EventHandler(this.txtMaoObra_TextChanged);
            this.txtMaoObra.Enter += new System.EventHandler(this.txtMaoObra_Enter);
            this.txtMaoObra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaoObra_KeyDown);
            this.txtMaoObra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaoObra_KeyPress);
            this.txtMaoObra.Leave += new System.EventHandler(this.txtMaoObra_Leave);
            // 
            // txtTotalPecas
            // 
            this.txtTotalPecas.AcceptsTab = true;
            this.txtTotalPecas.AnimateReadOnly = false;
            this.txtTotalPecas.AutoWordSelection = true;
            this.txtTotalPecas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalPecas.Depth = 0;
            this.txtTotalPecas.Enabled = false;
            this.txtTotalPecas.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotalPecas.Hint = "Total Peças";
            this.txtTotalPecas.LeadingIcon = null;
            this.txtTotalPecas.LeaveOnEnterKey = true;
            this.txtTotalPecas.Location = new System.Drawing.Point(6, 95);
            this.txtTotalPecas.MaxLength = 60;
            this.txtTotalPecas.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalPecas.Multiline = false;
            this.txtTotalPecas.Name = "txtTotalPecas";
            this.txtTotalPecas.Size = new System.Drawing.Size(209, 50);
            this.txtTotalPecas.TabIndex = 89;
            this.txtTotalPecas.Text = "";
            this.txtTotalPecas.TrailingIcon = null;
            this.txtTotalPecas.UseAccent = false;
            this.txtTotalPecas.TextChanged += new System.EventHandler(this.txtTotalPecas_TextChanged);
            // 
            // txtTotalServico
            // 
            this.txtTotalServico.AcceptsTab = true;
            this.txtTotalServico.AnimateReadOnly = false;
            this.txtTotalServico.AutoWordSelection = true;
            this.txtTotalServico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalServico.Depth = 0;
            this.txtTotalServico.Enabled = false;
            this.txtTotalServico.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotalServico.Hint = "Total Serviço";
            this.txtTotalServico.LeadingIcon = null;
            this.txtTotalServico.LeaveOnEnterKey = true;
            this.txtTotalServico.Location = new System.Drawing.Point(8, 346);
            this.txtTotalServico.MaxLength = 60;
            this.txtTotalServico.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalServico.Multiline = false;
            this.txtTotalServico.Name = "txtTotalServico";
            this.txtTotalServico.Size = new System.Drawing.Size(208, 50);
            this.txtTotalServico.TabIndex = 91;
            this.txtTotalServico.Text = "";
            this.txtTotalServico.TrailingIcon = null;
            this.txtTotalServico.UseAccent = false;
            this.txtTotalServico.TextChanged += new System.EventHandler(this.txtTotalServico_TextChanged);
            // 
            // txtDesconto
            // 
            this.txtDesconto.AcceptsTab = true;
            this.txtDesconto.AnimateReadOnly = false;
            this.txtDesconto.AutoWordSelection = true;
            this.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesconto.Depth = 0;
            this.txtDesconto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDesconto.Hint = "Desconto";
            this.txtDesconto.LeadingIcon = null;
            this.txtDesconto.LeaveOnEnterKey = true;
            this.txtDesconto.Location = new System.Drawing.Point(6, 207);
            this.txtDesconto.MaxLength = 60;
            this.txtDesconto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDesconto.Multiline = false;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(209, 50);
            this.txtDesconto.TabIndex = 92;
            this.txtDesconto.Text = "";
            this.txtDesconto.TrailingIcon = null;
            this.txtDesconto.UseAccent = false;
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            this.txtDesconto.Enter += new System.EventHandler(this.txtDesconto_Enter);
            this.txtDesconto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDesconto_KeyDown);
            this.txtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesconto_KeyPress);
            this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
            // 
            // txtAcrescimo
            // 
            this.txtAcrescimo.AcceptsTab = true;
            this.txtAcrescimo.AnimateReadOnly = false;
            this.txtAcrescimo.AutoWordSelection = true;
            this.txtAcrescimo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAcrescimo.Depth = 0;
            this.txtAcrescimo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAcrescimo.Hint = "Acréscimo";
            this.txtAcrescimo.LeadingIcon = null;
            this.txtAcrescimo.LeaveOnEnterKey = true;
            this.txtAcrescimo.Location = new System.Drawing.Point(6, 151);
            this.txtAcrescimo.MaxLength = 60;
            this.txtAcrescimo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAcrescimo.Multiline = false;
            this.txtAcrescimo.Name = "txtAcrescimo";
            this.txtAcrescimo.Size = new System.Drawing.Size(209, 50);
            this.txtAcrescimo.TabIndex = 90;
            this.txtAcrescimo.Text = "";
            this.txtAcrescimo.TrailingIcon = null;
            this.txtAcrescimo.UseAccent = false;
            this.txtAcrescimo.TextChanged += new System.EventHandler(this.txtAcrescimo_TextChanged);
            this.txtAcrescimo.Enter += new System.EventHandler(this.txtAcrescimo_Enter);
            this.txtAcrescimo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAcrescimo_KeyDown);
            this.txtAcrescimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAcrescimo_KeyPress);
            this.txtAcrescimo.Leave += new System.EventHandler(this.txtAcrescimo_Leave);
            // 
            // txtFimReal
            // 
            this.txtFimReal.AcceptsTab = true;
            this.txtFimReal.AnimateReadOnly = false;
            this.txtFimReal.AutoWordSelection = true;
            this.txtFimReal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFimReal.Depth = 0;
            this.txtFimReal.Enabled = false;
            this.txtFimReal.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFimReal.Hint = "Fim Real";
            this.txtFimReal.LeadingIcon = null;
            this.txtFimReal.LeaveOnEnterKey = true;
            this.txtFimReal.Location = new System.Drawing.Point(303, 275);
            this.txtFimReal.MaxLength = 60;
            this.txtFimReal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFimReal.Multiline = false;
            this.txtFimReal.Name = "txtFimReal";
            this.txtFimReal.Size = new System.Drawing.Size(146, 50);
            this.txtFimReal.TabIndex = 93;
            this.txtFimReal.Text = "";
            this.txtFimReal.TrailingIcon = null;
            this.txtFimReal.UseAccent = false;
            // 
            // txtFimPrevisto
            // 
            this.txtFimPrevisto.AcceptsTab = true;
            this.txtFimPrevisto.AnimateReadOnly = false;
            this.txtFimPrevisto.AutoWordSelection = true;
            this.txtFimPrevisto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFimPrevisto.Depth = 0;
            this.txtFimPrevisto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFimPrevisto.Hint = "Fim Previsto";
            this.txtFimPrevisto.LeadingIcon = null;
            this.txtFimPrevisto.LeaveOnEnterKey = true;
            this.txtFimPrevisto.Location = new System.Drawing.Point(156, 275);
            this.txtFimPrevisto.MaxLength = 60;
            this.txtFimPrevisto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFimPrevisto.Multiline = false;
            this.txtFimPrevisto.Name = "txtFimPrevisto";
            this.txtFimPrevisto.Size = new System.Drawing.Size(141, 50);
            this.txtFimPrevisto.TabIndex = 87;
            this.txtFimPrevisto.Text = "";
            this.txtFimPrevisto.TrailingIcon = null;
            this.txtFimPrevisto.UseAccent = false;
            this.txtFimPrevisto.TextChanged += new System.EventHandler(this.txtFimPrevisto_TextChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.AutoResize = false;
            this.cbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbStatus.Depth = 0;
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbStatus.DropDownHeight = 174;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.DropDownWidth = 121;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Hint = "Status";
            this.cbStatus.IntegralHeight = false;
            this.cbStatus.ItemHeight = 43;
            this.cbStatus.Location = new System.Drawing.Point(11, 220);
            this.cbStatus.MaxDropDownItems = 4;
            this.cbStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(438, 49);
            this.cbStatus.StartIndex = 0;
            this.cbStatus.TabIndex = 86;
            this.cbStatus.UseAccent = false;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.AcceptsTab = true;
            this.txtDataEntrada.AnimateReadOnly = false;
            this.txtDataEntrada.AutoWordSelection = true;
            this.txtDataEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataEntrada.Depth = 0;
            this.txtDataEntrada.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDataEntrada.Hint = "Data Entrada";
            this.txtDataEntrada.LeadingIcon = null;
            this.txtDataEntrada.LeaveOnEnterKey = true;
            this.txtDataEntrada.Location = new System.Drawing.Point(9, 275);
            this.txtDataEntrada.MaxLength = 60;
            this.txtDataEntrada.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDataEntrada.Multiline = false;
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(141, 50);
            this.txtDataEntrada.TabIndex = 85;
            this.txtDataEntrada.Text = "";
            this.txtDataEntrada.TrailingIcon = null;
            this.txtDataEntrada.UseAccent = false;
            this.txtDataEntrada.TextChanged += new System.EventHandler(this.txtDataEntrada_TextChanged);
            // 
            // btnCadastraTipoServico
            // 
            this.btnCadastraTipoServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnCadastraTipoServico.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnCadastraTipoServico.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnCadastraTipoServico.CorTextoBotao = System.Drawing.Color.White;
            this.btnCadastraTipoServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastraTipoServico.FlatAppearance.BorderSize = 0;
            this.btnCadastraTipoServico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnCadastraTipoServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastraTipoServico.ForeColor = System.Drawing.Color.White;
            this.btnCadastraTipoServico.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastraTipoServico.Image")));
            this.btnCadastraTipoServico.Location = new System.Drawing.Point(412, 165);
            this.btnCadastraTipoServico.Name = "btnCadastraTipoServico";
            this.btnCadastraTipoServico.Size = new System.Drawing.Size(39, 41);
            this.btnCadastraTipoServico.TabIndex = 84;
            this.btnCadastraTipoServico.TamanhoBorda = 0;
            this.btnCadastraTipoServico.TamanhoRaio = 15;
            this.ttAjuda.SetToolTip(this.btnCadastraTipoServico, "Permite cadastrar um novo tipo de serviço");
            this.btnCadastraTipoServico.UseVisualStyleBackColor = false;
            this.btnCadastraTipoServico.Click += new System.EventHandler(this.btnCadastraTipoServico_Click);
            // 
            // txtFimGarantia
            // 
            this.txtFimGarantia.AcceptsTab = true;
            this.txtFimGarantia.AnimateReadOnly = false;
            this.txtFimGarantia.AutoWordSelection = true;
            this.txtFimGarantia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFimGarantia.Depth = 0;
            this.txtFimGarantia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFimGarantia.Hint = "Fim da Garantia";
            this.txtFimGarantia.LeadingIcon = null;
            this.txtFimGarantia.LeaveOnEnterKey = true;
            this.txtFimGarantia.Location = new System.Drawing.Point(297, 331);
            this.txtFimGarantia.MaxLength = 60;
            this.txtFimGarantia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFimGarantia.Multiline = false;
            this.txtFimGarantia.Name = "txtFimGarantia";
            this.txtFimGarantia.Size = new System.Drawing.Size(152, 50);
            this.txtFimGarantia.TabIndex = 76;
            this.txtFimGarantia.Text = "";
            this.txtFimGarantia.TrailingIcon = null;
            this.txtFimGarantia.UseAccent = false;
            this.txtFimGarantia.TextChanged += new System.EventHandler(this.txtFimGarantia_TextChanged);
            // 
            // txtInicioGarantia
            // 
            this.txtInicioGarantia.AcceptsTab = true;
            this.txtInicioGarantia.AnimateReadOnly = false;
            this.txtInicioGarantia.AutoWordSelection = true;
            this.txtInicioGarantia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInicioGarantia.Depth = 0;
            this.txtInicioGarantia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtInicioGarantia.Hint = "Início da Garantia";
            this.txtInicioGarantia.LeadingIcon = null;
            this.txtInicioGarantia.LeaveOnEnterKey = true;
            this.txtInicioGarantia.Location = new System.Drawing.Point(132, 331);
            this.txtInicioGarantia.MaxLength = 60;
            this.txtInicioGarantia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtInicioGarantia.Multiline = false;
            this.txtInicioGarantia.Name = "txtInicioGarantia";
            this.txtInicioGarantia.Size = new System.Drawing.Size(158, 50);
            this.txtInicioGarantia.TabIndex = 82;
            this.txtInicioGarantia.Text = "";
            this.txtInicioGarantia.TrailingIcon = null;
            this.txtInicioGarantia.UseAccent = false;
            this.txtInicioGarantia.TextChanged += new System.EventHandler(this.txtInicioGarantia_TextChanged);
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
            this.txtObservacoes.Location = new System.Drawing.Point(11, 387);
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
            this.txtObservacoes.Size = new System.Drawing.Size(440, 181);
            this.txtObservacoes.TabIndex = 83;
            this.txtObservacoes.TabStop = false;
            this.txtObservacoes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtObservacoes.UseAccent = false;
            this.txtObservacoes.UseSystemPasswordChar = false;
            // 
            // cbTipoServico
            // 
            this.cbTipoServico.AutoResize = false;
            this.cbTipoServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbTipoServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTipoServico.Depth = 0;
            this.cbTipoServico.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbTipoServico.DropDownHeight = 174;
            this.cbTipoServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoServico.DropDownWidth = 121;
            this.cbTipoServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbTipoServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTipoServico.FormattingEnabled = true;
            this.cbTipoServico.Hint = "Tipo de Serviço";
            this.cbTipoServico.IntegralHeight = false;
            this.cbTipoServico.ItemHeight = 43;
            this.cbTipoServico.Location = new System.Drawing.Point(13, 165);
            this.cbTipoServico.MaxDropDownItems = 4;
            this.cbTipoServico.MouseState = MaterialSkin.MouseState.OUT;
            this.cbTipoServico.Name = "cbTipoServico";
            this.cbTipoServico.Size = new System.Drawing.Size(393, 49);
            this.cbTipoServico.StartIndex = 0;
            this.cbTipoServico.TabIndex = 80;
            this.cbTipoServico.UseAccent = false;
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnBuscaCliente.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscaCliente.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnBuscaCliente.CorTextoBotao = System.Drawing.Color.White;
            this.btnBuscaCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnBuscaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaCliente.Image")));
            this.btnBuscaCliente.Location = new System.Drawing.Point(629, 26);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(39, 41);
            this.btnBuscaCliente.TabIndex = 81;
            this.btnBuscaCliente.TamanhoBorda = 0;
            this.btnBuscaCliente.TamanhoRaio = 15;
            this.btnBuscaCliente.UseVisualStyleBackColor = false;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.AnimateReadOnly = false;
            this.txtDescricao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescricao.Depth = 0;
            this.txtDescricao.HideSelection = true;
            this.txtDescricao.Hint = "Descrição do Serviço";
            this.txtDescricao.Location = new System.Drawing.Point(13, 82);
            this.txtDescricao.MaxLength = 300;
            this.txtDescricao.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.ReadOnly = false;
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.SelectionLength = 0;
            this.txtDescricao.SelectionStart = 0;
            this.txtDescricao.ShortcutsEnabled = true;
            this.txtDescricao.Size = new System.Drawing.Size(655, 77);
            this.txtDescricao.TabIndex = 79;
            this.txtDescricao.TabStop = false;
            this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescricao.UseAccent = false;
            this.txtDescricao.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            this.txtId.AcceptsTab = true;
            this.txtId.AnimateReadOnly = false;
            this.txtId.AutoWordSelection = true;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Depth = 0;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtId.Hint = "Nº ";
            this.txtId.LeadingIcon = null;
            this.txtId.LeaveOnEnterKey = true;
            this.txtId.Location = new System.Drawing.Point(13, 26);
            this.txtId.MaxLength = 60;
            this.txtId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(155, 50);
            this.txtId.TabIndex = 77;
            this.txtId.Text = "";
            this.txtId.TrailingIcon = null;
            this.txtId.UseAccent = false;
            // 
            // txtGarantia
            // 
            this.txtGarantia.AcceptsTab = true;
            this.txtGarantia.AnimateReadOnly = false;
            this.txtGarantia.AutoWordSelection = true;
            this.txtGarantia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGarantia.Depth = 0;
            this.txtGarantia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGarantia.Hint = "Garantia";
            this.txtGarantia.LeadingIcon = null;
            this.txtGarantia.LeaveOnEnterKey = true;
            this.txtGarantia.Location = new System.Drawing.Point(9, 331);
            this.txtGarantia.MaxLength = 60;
            this.txtGarantia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGarantia.Multiline = false;
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Size = new System.Drawing.Size(117, 50);
            this.txtGarantia.TabIndex = 78;
            this.txtGarantia.Text = "";
            this.txtGarantia.TrailingIcon = null;
            this.txtGarantia.UseAccent = false;
            // 
            // txtCliente
            // 
            this.txtCliente.AcceptsTab = true;
            this.txtCliente.AnimateReadOnly = false;
            this.txtCliente.AutoWordSelection = true;
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCliente.Depth = 0;
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCliente.Hint = "Cliente";
            this.txtCliente.LeadingIcon = null;
            this.txtCliente.LeaveOnEnterKey = true;
            this.txtCliente.Location = new System.Drawing.Point(174, 26);
            this.txtCliente.MaxLength = 60;
            this.txtCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCliente.Multiline = false;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(449, 50);
            this.txtCliente.TabIndex = 75;
            this.txtCliente.Text = "";
            this.txtCliente.TrailingIcon = null;
            this.txtCliente.UseAccent = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(699, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 23);
            this.label1.TabIndex = 53;
            this.label1.Text = "Itens Vinculados a OS";
            // 
            // btnNovoItem
            // 
            this.btnNovoItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnNovoItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovoItem.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.btnNovoItem.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.btnNovoItem.CorTextoBotao = System.Drawing.Color.White;
            this.btnNovoItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoItem.FlatAppearance.BorderSize = 0;
            this.btnNovoItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnNovoItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoItem.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnNovoItem.ForeColor = System.Drawing.Color.White;
            this.btnNovoItem.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoItem.Image")));
            this.btnNovoItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoItem.Location = new System.Drawing.Point(904, 7);
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnNovoItem.Size = new System.Drawing.Size(239, 37);
            this.btnNovoItem.TabIndex = 23;
            this.btnNovoItem.TamanhoBorda = 0;
            this.btnNovoItem.TamanhoRaio = 15;
            this.btnNovoItem.Text = "             Criar Novo Item";
            this.btnNovoItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttAjuda.SetToolTip(this.btnNovoItem, "Permite criar um item do zero");
            this.btnNovoItem.UseVisualStyleBackColor = false;
            this.btnNovoItem.Click += new System.EventHandler(this.btnNovoItem_Click);
            // 
            // pcbFavorito
            // 
            this.pcbFavorito.BackColor = System.Drawing.Color.Transparent;
            this.pcbFavorito.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.pcbFavorito.CorBotao = System.Drawing.Color.Transparent;
            this.pcbFavorito.CorTextoBotao = System.Drawing.Color.White;
            this.pcbFavorito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbFavorito.ForeColor = System.Drawing.Color.White;
            this.pcbFavorito.Image = global::GRC.Properties.Resources.star;
            this.pcbFavorito.Location = new System.Drawing.Point(640, 10);
            this.pcbFavorito.Name = "pcbFavorito";
            this.pcbFavorito.Size = new System.Drawing.Size(39, 38);
            this.pcbFavorito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbFavorito.TabIndex = 42;
            this.pcbFavorito.TabStop = false;
            this.pcbFavorito.TamanhoBorda = 0;
            this.pcbFavorito.TamanhoRaio = 0;
            this.ttAjuda.SetToolTip(this.pcbFavorito, "Favoritar a OS permite que apareça primeiro ao pesquisar ");
            this.pcbFavorito.Click += new System.EventHandler(this.pcbFavorito_Click);
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
            this.materialLabel1.Location = new System.Drawing.Point(22, 16);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(159, 24);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Ordem de Serviço";
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
            this.btnSalvar.Location = new System.Drawing.Point(1023, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSalvar.Size = new System.Drawing.Size(144, 37);
            this.btnSalvar.TabIndex = 22;
            this.btnSalvar.TamanhoBorda = 0;
            this.btnSalvar.TamanhoRaio = 5;
            this.btnSalvar.Text = "   Salvar dados";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttAjuda.SetToolTip(this.btnSalvar, "Salva os dados no banco");
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // ttAjuda
            // 
            this.ttAjuda.AutomaticDelay = 1000;
            this.ttAjuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.ttAjuda.ForeColor = System.Drawing.Color.White;
            this.ttAjuda.ToolTipTitle = "Ajuda";
            // 
            // CadastroOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(1179, 697);
            this.Controls.Add(this.pn2);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.btnSalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroOS";
            this.Load += new System.EventHandler(this.CadastroOS_Load);
            this.pn2.ResumeLayout(false);
            this.pn2.PerformLayout();
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.pnItens.ResumeLayout(false);
            this.gpbInfoVenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcAjuda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFavorito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Componentes.CustomPanel customPanel1;
        private Componentes.CustomPictureBox pcbFavorito;
        private Componentes.CustomButton btnSalvar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Componentes.CustomButton btnNovoItem;
        private System.Windows.Forms.Label label1;
        private Componentes.RoundedPanel pn1;
        private Componentes.CustomButton btnExportar;
        private System.Windows.Forms.GroupBox gpbInfoVenda;
        private MaterialSkin.Controls.MaterialTextBox txtTotalServico;
        private MaterialSkin.Controls.MaterialTextBox txtAcrescimo;
        private MaterialSkin.Controls.MaterialTextBox txtMaoObra;
        private MaterialSkin.Controls.MaterialTextBox txtFimPrevisto;
        private MaterialSkin.Controls.MaterialComboBox cbStatus;
        private MaterialSkin.Controls.MaterialTextBox txtDataEntrada;
        private Componentes.CustomButton btnCadastraTipoServico;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtObservacoes;
        private MaterialSkin.Controls.MaterialTextBox txtInicioGarantia;
        private MaterialSkin.Controls.MaterialComboBox cbTipoServico;
        private Componentes.CustomButton btnBuscaCliente;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDescricao;
        private MaterialSkin.Controls.MaterialTextBox txtId;
        private MaterialSkin.Controls.MaterialTextBox txtGarantia;
        private MaterialSkin.Controls.MaterialTextBox txtCliente;
        private MaterialSkin.Controls.MaterialTextBox txtFimGarantia;
        private MaterialSkin.Controls.MaterialTextBox txtDesconto;
        private Componentes.CustomButton btnConsultaItem;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.FlowLayoutPanel flpItens;
        private MaterialSkin.Controls.MaterialTextBox txtTotalPecas;
        private System.Windows.Forms.Label lbDataAtual;
        private Componentes.RoundedPanel pn2;
        private Componentes.CustomPanel pnItens;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox txtFimReal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pcAjuda;
        private System.Windows.Forms.ToolTip ttAjuda;
    }
}