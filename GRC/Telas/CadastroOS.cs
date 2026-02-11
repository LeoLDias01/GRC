using Business.EmailSender;
using Business.Helper;
using Business.Services;
using Data.Models;
using GRC.Componentes;
using GRC.Properties;
using iText.Signatures.Validation;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace GRC.Telas
{
    public partial class CadastroOS : Form
    {
        private int _idOS = 0;
        private bool _favorito = false;
        private int _StatusAntigo = 0;
        private Cliente _cliente = new Cliente();
     
        private List<ItemCard> _itensOS = new List<ItemCard>();
        ServiceOrdemServico _service = new ServiceOrdemServico();

        public CadastroOS(int id = 0)
        {
            InitializeComponent();
            _idOS = id;
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            new CadastroItem().ShowDialog();
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            
        }

        private void CadastroOS_Load(object sender, EventArgs e)
        {
            _favorito = false;
            Favorito();
            lbDataAtual.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txtDataEntrada.Text = DateTime.Today.ToString("dd/MM/yyyy");
            CarregaCombos();

            if (_idOS > 0)
                CarregaDados();
            
            else btnExportar.Enabled = false;

            txtDescricao.Focus();
        }
        private void CarregaDados()
        {
            try
            {
                
                // Limpa cards e lista
                flpItens.Controls.Clear();
                _itensOS.Clear();

                var dadosOs = _service.BuscaCompleta(_idOS).FirstOrDefault();
                if (dadosOs == null)
                    return;


                _cliente = dadosOs.DadosCliente;
                txtCliente.Text = _cliente.Nome;
                txtIdentidade.Text = _cliente.Identidade;

                txtId.Text = _idOS.ToString();
                txtProblema.Text = dadosOs.DescricaoProblema;
                txtDescricao.Text = dadosOs.DescricaoSolucao.ToString();
                cbTipoServico.SelectedValue = dadosOs.TipoServico;
                _StatusAntigo = dadosOs.Status;
                cbStatus.SelectedValue = _StatusAntigo;
                txtDataEntrada.Text = dadosOs.DataEntrada;
                txtFimPrevisto.Text = dadosOs.FimPrevisto;
                txtFimReal.Text = dadosOs.FimReal;
                txtGarantia.Text = dadosOs.Garantia;
                txtInicioGarantia.Text = dadosOs.InicioGarantia;
                txtFimGarantia.Text = dadosOs.FimGarantia;
                txtObservacoes.Text = dadosOs.Observacoes;
                txtObservacoesCliente.Text = dadosOs.ObservacoesCliente;

                // ORÇAMENTO

                txtCustoManual.Text = dadosOs.CustoManual;
                txtMaoObra.Text = dadosOs.MaoObra;
                txtAcrescimo.Text = dadosOs.Acrescimo;
                txtDesconto.Text = dadosOs.Desconto;
                _favorito = dadosOs.Favorito;
                Favorito();


                // ITENS VINCULADOS A OS (Com baixa estoque)

                if (dadosOs.ItensOrdemServico != null && dadosOs.ItensOrdemServico.Count > 0)
                {
                    ConfiguraCard();
                    flpItens.Controls.Clear();
                    _itensOS.Clear();

                    foreach (var item in dadosOs.ItensOrdemServico)
                    {
                        CriaCard(item, false);
                    }
                }
                if (dadosOs.ItensEsporadicos != null && dadosOs.ItensEsporadicos.Count > 0)
                {
                    foreach (var itm in dadosOs.ItensEsporadicos)
                    {
                        PreencheGridItemEsporadico(itm.Id, itm.Descricao);
                    }
                }

                btnExportar.Enabled = true;
            }
            catch (Exception ex)
            {
                EmailError.EnviarEmailErro(ex.ToString());
                new AlertBox(Color.FromArgb(64, 0, 0), Color.Red, Color.Crimson, Resources.Error, "Um erro ocorreu:", "Entidade: OS", "Erro ao Carregar o dados da OS!", false).ShowDialog();
            }
        }

        private void pcbFavorito_Click(object sender, EventArgs e)
        {
            Favorito();
        }
        private void Favorito()
        {
            if (_favorito == true)
            {
                pcbFavorito.Image = Resources.star;
                _favorito = false;
            }
            else
            {
                pcbFavorito.Image = Resources.starOff;
                _favorito = true;
            }
        }

        private void btnCadastraTipoServico_Click(object sender, EventArgs e)
        {
            new TipoServico().ShowDialog();
            PreencherCombo(cbTipoServico, _service.BuscaTipoServico(), "Descricao", "Id");
        }
        private void PreencherCombo<T>(MaterialComboBox cb, List<T> lista, string display, string value)
        {
            // Cria dinamicamente o item "Selecione..."
            var itemSelecione = Activator.CreateInstance<T>();

            var propId = typeof(T).GetProperty(value);
            var propDesc = typeof(T).GetProperty(display);

            propId?.SetValue(itemSelecione, 0);
            propDesc?.SetValue(itemSelecione, "Selecione...");

            // Adiciona como primeiro item da lista
            lista.Insert(0, itemSelecione);

            // Configura o ComboBox
            cb.DisplayMember = display;
            cb.ValueMember = value;
            cb.DataSource = lista;
            cb.SelectedIndex = 0;
        }
        private void CarregaCombos()
        {
            PreencherCombo(cbTipoServico, _service.BuscaTipoServico(), "Descricao", "Id");
            PreencherCombo(cbStatus, _service.BuscaStatus(), "Descricao", "Id");
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbStatus.Text = cbStatus.Text;

            if (Convert.ToInt32(cbStatus.SelectedValue) == 6)
            {
                PermiteAddItens(true);
                MudaCorPainel(Color.Gray, Color.DarkGray);
            }
            else if (Convert.ToInt32(cbStatus.SelectedValue) == 7)
            {
                PermiteAddItens(true);
                MudaCorPainel(Color.Yellow, Color.Goldenrod);
            }
            else if (Convert.ToInt32(cbStatus.SelectedValue) == 8)
            {
                PermiteAddItens(true);
                MudaCorPainel(Color.Orange, Color.DarkOrange);
            }
            else if (Convert.ToInt32(cbStatus.SelectedValue) == 9)
            {
                PermiteAddItens(true);
                MudaCorPainel(Color.Cyan, Color.DeepSkyBlue);
            }
            else if (Convert.ToInt32(cbStatus.SelectedValue) == 10)
            {
                PermiteAddItens(false);
                MudaCorPainel(Color.Lime, Color.Green);
            }
            else if (Convert.ToInt32(cbStatus.SelectedValue) == 11)
            {
                PermiteAddItens(false);
                MudaCorPainel(Color.DarkSalmon, Color.Crimson);
            }
        }
        private void PermiteAddItens(bool ativo)
        {
            btnConsultaItem.Enabled = ativo;
            flpItens.Enabled = ativo;

            if (ativo)
            {
                flpItens.BackColor = Color.FromArgb(43, 69, 98);
                pnItens.BackColor = Color.FromArgb(43, 69, 98);
            }
            else
            {
                flpItens.BackColor = Color.FromArgb(52, 57, 66);
                pnItens.BackColor = Color.FromArgb(52, 57, 66);
            }
        }

        private void txtDataEntrada_TextChanged(object sender, EventArgs e)
        {
            FormataData(txtDataEntrada);
        }
        private void FormataData(MaterialTextBox txt)
        {
            // Remove tudo que não é número
            string apenasNumeros = new string(txt.Text.Where(char.IsDigit).ToArray());

            if (apenasNumeros.Length > 8)
                apenasNumeros = apenasNumeros.Substring(0, 8);

            string formatado = "";

            if (apenasNumeros.Length <= 2)
            {
                formatado = apenasNumeros;
            }
            else if (apenasNumeros.Length <= 4)
            {
                formatado = apenasNumeros.Insert(2, "/");
            }
            else
            {
                formatado = apenasNumeros.Insert(2, "/").Insert(5, "/");
            }

            txt.Text = formatado;
            txt.SelectionStart = txt.Text.Length;
        }

        private void txtFimPrevisto_TextChanged(object sender, EventArgs e)
        {
            FormataData(txtFimPrevisto);
        }

        private void txtInicioGarantia_TextChanged(object sender, EventArgs e)
        {
            FormataData(txtInicioGarantia);
            AtualizarFimGarantia();

        }

        private void txtFimGarantia_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtMaoObra_KeyDown(object sender, KeyEventArgs e)
        {
            VerificaKeyV(sender, e);
        }
        private void VerificaKeyV(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Pega o que está no clipboard
                string texto = Clipboard.GetText();

                // Se tiver algo que não seja número => cancela
                if (!texto.All(char.IsDigit))
                    e.SuppressKeyPress = true;
            }
        }

        private void txtMaoObra_KeyPress(object sender, KeyPressEventArgs e)
        {
            DesativaCaracteres(sender, e);
        }
        private void DesativaCaracteres(object sender, KeyPressEventArgs e)
        {
            // Só permite números e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txtMaoObra_Enter(object sender, EventArgs e)
        {
            LimpaValorAoFocar("R$ 0,00", txtMaoObra);
        }

        private void txtMaoObra_Leave(object sender, EventArgs e)
        {
            ZeraValorAoDesfocar("R$ 0,00", txtMaoObra);
        }

        private void txtMaoObra_TextChanged(object sender, EventArgs e)
        {
            FormataMoeda(sender);
            CalculaTotal();
        }
        private void FormataMoeda(object sender)
        {
            MaterialTextBox txt = (MaterialTextBox)sender;
            // Remove tudo que não é número
            string apenasNumeros = new string(txt.Text.Where(char.IsDigit).ToArray());

            if (string.IsNullOrEmpty(apenasNumeros))
            {
                txt.Text = "";
                return;
            }

            // Remove zeros à esquerda
            apenasNumeros = apenasNumeros.TrimStart('0');

            // Garante pelo menos 3 dígitos
            if (apenasNumeros.Length < 3)
                apenasNumeros = apenasNumeros.PadLeft(3, '0');

            // Formata com vírgula nas duas últimas casas
            string valorFormatado = apenasNumeros.Insert(apenasNumeros.Length - 2, ",");

            // Aplica ao campo
            txt.Text = "R$ " + valorFormatado;

            // Move cursor para o final
            txt.SelectionStart = txt.Text.Length;
        }
        private void ZeraValorAoDesfocar(string valor, MaterialTextBox txtBox)
        {
            if (string.IsNullOrWhiteSpace(txtBox.Text))
                txtBox.Text = valor;
        }
        private void LimpaValorAoFocar(string valor, MaterialTextBox txtBox)
        {
            if (txtBox.Text == valor)
                txtBox.Clear();
        }

        private void btnConsultaItem_Click(object sender, EventArgs e)
        {
            using (var frm = new PesquisaItem())
            {
                frm.ShowDialog();

                if (frm._item != null && frm._item.Count > 0)
                {
                    ConfiguraCard();
                    foreach (var comp in frm._item)
                    {
                        

                        if (comp.Quatidade > 0)
                        {
                            CriaCard(new ItemCard
                            {
                                Id = 0,
                                IdItem = (int)comp.Id > 0 ? (int)comp.Id : 0,
                                Descricao = comp.Descricao,
                                Quantidade = 1,
                                QuantidadeMaxima = comp.Quatidade,
                                FotoItem = comp.FotoItem,
                                Custo = comp.CustoUnitario
                            }, true);
                        }
                        else
                        {
                            new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Item de Estoque", comp.Descricao.ToString(), "Não pode ser adicionado pois estoque está zerado!", false).ShowDialog();
                        }
                    }

                }
            }
        }
        private void ConfiguraCard()
        {
            flpItens.AutoScroll = true;
            flpItens.FlowDirection = FlowDirection.TopDown;
            flpItens.WrapContents = false;

        }

        private void CriaCard(ItemCard item, bool validarDuplicado)
        {
            decimal.TryParse(item.Custo.ToString(), NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal unit);

            // Entra no IF se a validação for habilitada (Apenas ao adicionar item novo)

            if (validarDuplicado)
            {
                bool jaExiste = _itensOS.Any(i => i.IdItem == item.IdItem);
                if (jaExiste)
                {
                    var cardExistente = flpItens.Controls
                        .OfType<CustomPanel>()
                        .FirstOrDefault(c => c.Tag is ItemCard os && os.IdItem == item.IdItem);

                    if (cardExistente != null)
                    {
                        flpItens.ScrollControlIntoView(cardExistente);
                        PiscarCard(cardExistente);
                    }

                    new AlertBox(
                        Color.Goldenrod,
                        Color.Black,
                        Color.Yellow,
                        Resources.Warning,
                        "Item já adicionado",
                        item.Descricao,
                        "Este item já está na ordem de serviço.",
                        false
                    ).ShowDialog();

                    return;
                }
            }

                // 🔹 cria o item da OS
                ItemCard itemOS = new ItemCard
                {
                    Id = item.Id,
                    IdItem = (int)item.IdItem,
                    Descricao = item.Descricao,
                    ValorUnitario = unit,
                    Quantidade = item.Quantidade,
                    QuantidadeMaxima = item.QuantidadeMaxima,
                    FotoItem = item.FotoItem,
                };

            CustomPanel card = new CustomPanel
                {
                    Width = flpItens.Width - 8,
                    Height = 90,
                    TamanhoRaio = 15,
                    BackColor = Color.Azure,
                    Tag = itemOS
                };

                PictureBox foto = new PictureBox
                {
                    Width = 68,
                    Height = 68,
                    Location = new Point(10, 10),
                    BackColor = Color.Azure,
                    SizeMode = PictureBoxSizeMode.Zoom
                };

                foto.Image = string.IsNullOrEmpty(item.FotoItem) ? null : CriptoImagem.Base64ToImage(item.FotoItem);

                Label lblNome = new Label
                {
                    Text = item.Descricao,
                    Width = 250,
                    Height = 30,
                    AutoEllipsis = true,
                    Font = new Font("Roboto", 12, FontStyle.Bold),
                    ForeColor = Color.FromArgb(43, 69, 98),
                    BackColor = Color.Transparent,
                    Location = new Point(90, 10),
                    AutoSize = false
                };


                CustomButton btnMenos = new CustomButton
                {
                    Text = "➖",
                    Width = 30,
                    Height = 30,
                    TamanhoRaio = 5,
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand,
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.FromArgb(0, 136, 184),
                    Location = new Point(90, 40)
                };

                // TEXTBOX QUANTIDADE
                MaterialTextBox txtQuantidade = new MaterialTextBox
                {
                    Text = item.Quantidade.ToString(),
                    Width = 60,
                    Height = 25,
                    Location = new Point(130, 40),
                    //TextAlign = HorizontalAlignment.Center
                    UseTallSize = false,
                    Cursor = Cursors.Default
                };

                CustomButton btnMais = new CustomButton
                {
                    Text = "➕",
                    Width = 30,
                    Height = 30,
                    TamanhoRaio = 5,
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand,
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.FromArgb(0, 136, 184),
                    Location = new Point(200, 40)
                };

                Label lblPreco = new Label
                {
                    Text = $"Valor: {item.Custo}",
                    Location = new Point(240, 47),
                    Font = new Font("Roboto", 10, FontStyle.Bold),
                    ForeColor = Color.FromArgb(43, 69, 98),
                    BackColor = Color.Transparent,
                    AutoSize = true
                };


                CustomButton btnExcluir = new CustomButton
                {
                    Text = " ❌",
                    Width = 40,
                    Height = 30,
                    TamanhoRaio = 5,
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand,
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.DarkRed,
                    Location = new Point(card.Width - 50, 30)
                };
                btnExcluir.FlatAppearance.BorderSize = 0;
                btnExcluir.FlatAppearance.MouseOverBackColor = Color.FromArgb(43, 69, 98);

            void AtualizarSubtotal()
            {
                txtQuantidade.Text = itemOS.Quantidade.ToString();
                lblPreco.Text = $"Valor: {itemOS.Subtotal:C2}";
                AtualizarTotalOS();
            }
            btnExcluir.Click += (s, e) =>
                {
                    _itensOS.Remove(itemOS);
                    flpItens.Controls.Remove(card);
                    card.Dispose();
                    AtualizarSubtotal();
                    AtualizarTotalOS();
                };

                btnMenos.Click += (s, e) =>
                {
                    if (itemOS.Quantidade > 1)
                    {
                        itemOS.Quantidade--;
                        AtualizarSubtotal();
                        AtualizarTotalOS();
                    }
                };
                btnMais.Click += (s, e) =>
                {
                    if (itemOS.Quantidade < item.QuantidadeMaxima)
                    {
                        itemOS.Quantidade++;
                        AtualizarSubtotal();
                        AtualizarTotalOS();
                    }
                    else
                        new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Item de Estoque", item.Descricao.ToString(), "Não existe quantidade suficiente no estoque!", false).ShowDialog();


                };

                txtQuantidade.KeyPress += (s, e) =>
                {
                    // permite apenas números
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                        e.Handled = true;
                };
                txtQuantidade.Leave += (s, e) =>
                {
                    if (!int.TryParse(txtQuantidade.Text, out int qtd) || qtd < 1)
                        qtd = 1;

                    if (qtd > item.QuantidadeMaxima)
                        qtd = item.QuantidadeMaxima;

                    itemOS.Quantidade = qtd;
                };

                txtQuantidade.Enter += (s, e) =>
                {
                    LimpaValorAoFocar("1", txtQuantidade);
                };
                txtQuantidade.TextChanged += (s, e) =>
                {
                    if (int.TryParse(txtQuantidade.Text, out int qtd))
                    {
                        if (qtd < 1) 
                            qtd = 1;
                        if (qtd > item.QuantidadeMaxima) 
                            qtd = item.QuantidadeMaxima;

                        itemOS.Quantidade = qtd;
                        AtualizarSubtotal();
                        // Move cursor para o final
                        txtQuantidade.SelectionStart = txtQuantidade.Text.Length;
                    }
                };
                _itensOS.Add(itemOS);
                card.Controls.Add(foto);
                card.Controls.Add(lblNome);
                card.Controls.Add(btnMenos);
                card.Controls.Add(txtQuantidade);
                card.Controls.Add(btnMais);
                card.Controls.Add(lblPreco);
                card.Controls.Add(btnExcluir);
                flpItens.Controls.Add(card);
                AtualizarSubtotal();


                
            
        }
        private void AtualizarTotalOS()
        {
            decimal total = _itensOS.Sum(i => i.Subtotal);
            txtTotalPecas.Text = $"{total:C2}";
        }
        private void AdicionarItemOS(ItemCard item)
        {
            
        }
        private async void PiscarCard(Control card)
        {
            Color corOriginal = card.BackColor;
            Color corDestaque = Color.FromArgb(255, 220, 180); // destaque suave

            for (int i = 0; i < 3; i++)
            {
                card.BackColor = corDestaque;
                await Task.Delay(180);

                card.BackColor = corOriginal;
                await Task.Delay(180);
            }
        }

        private void txtAcrescimo_KeyDown(object sender, KeyEventArgs e)
        {
            VerificaKeyV(sender, e);
        }

        private void txtAcrescimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            DesativaCaracteres(sender, e);
        }

        private void txtAcrescimo_Enter(object sender, EventArgs e)
        {
            LimpaValorAoFocar("R$ 0,00", txtMaoObra);
        }

        private void txtAcrescimo_Leave(object sender, EventArgs e)
        {
            ZeraValorAoDesfocar("R$ 0,00", txtMaoObra);
        }

        private void txtAcrescimo_TextChanged(object sender, EventArgs e)
        {
            FormataMoeda(sender);
            CalculaTotal();
        }

        private void txtDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            VerificaKeyV(sender, e);
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            DesativaCaracteres(sender, e);
        }

        private void txtDesconto_Enter(object sender, EventArgs e)
        {
            LimpaValorAoFocar("R$ 0,00", txtMaoObra);
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            ZeraValorAoDesfocar("R$ 0,00", txtMaoObra);
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            FormataMoeda(sender);
            CalculaTotal();
        }
        private void CalculaTotal()
        {
            bool MaoObraOk = decimal.TryParse(txtMaoObra.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal mo);
            bool PecasOk = decimal.TryParse(txtTotalPecas.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal pc);
            bool AcrescimoOk = decimal.TryParse(txtAcrescimo.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal ac);
            bool DescontoOk = decimal.TryParse(txtDesconto.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal dc);
            bool CustoManualOk = decimal.TryParse(txtCustoManual.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal cm);
            decimal total = 0;

            if (MaoObraOk)
                total += mo;

            if (PecasOk)
                total += pc;

            if (AcrescimoOk)
                total += ac;

            if(CustoManualOk)
                total += cm;

            if (DescontoOk)
                total -= dc;

            txtTotalServico.Text = total.ToString("C2", CultureInfo.CurrentCulture);
        }

        private void txtTotalPecas_TextChanged(object sender, EventArgs e)
        {
            CalculaTotal();
        }

        private void txtTotalServico_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTotalServico.Text))
            {
                txtTotalServico.Text = "R$ 0,00";
            }
        }
        private void MudaCorPainel(Color cor1, Color cor2)
        {
            pn1.Color1 = cor1;
            pn2.Color1 = cor1;
            pn1.Color2 = cor2;
            pn2.Color2 = cor2;
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
        private void Salvar() 
        {
            try
            {
                if (!ValidaCampos())
                    return;

                bool fim = false;

                if (_StatusAntigo != Convert.ToInt32(cbStatus.SelectedValue))
                {
                    if (Convert.ToInt32(cbStatus.SelectedValue) == 10 || Convert.ToInt32(cbStatus.SelectedValue) == 11)
                    {
                        fim = true;
                    }
                }

                var os = new OrdemServico
                {
                    Id = _idOS,
                    DadosCliente = _cliente,
                    DescricaoProblema = !string.IsNullOrWhiteSpace(txtProblema.Text) ? txtProblema.Text : string.Empty,
                    DescricaoSolucao = !string.IsNullOrWhiteSpace(txtDescricao.Text) ? txtDescricao.Text : string.Empty,
                    TipoServico = Convert.ToInt32(cbTipoServico.SelectedValue),
                    StatusAntigo = _StatusAntigo,
                    Status = Convert.ToInt32(cbStatus.SelectedValue),
                    Garantia = !string.IsNullOrWhiteSpace(txtGarantia.Text) ? txtGarantia.Text.Trim() : string.Empty,
                    DataEntrada = !string.IsNullOrWhiteSpace(txtDataEntrada.Text) ? txtDataEntrada.Text : string.Empty,
                    FimPrevisto = !string.IsNullOrWhiteSpace(txtFimPrevisto.Text) ? txtFimPrevisto.Text : string.Empty,
                    FimReal = fim == true ? DateTime.Today.ToString("dd/MM/yyyy") : string.Empty,
                    InicioGarantia = !string.IsNullOrWhiteSpace(txtInicioGarantia.Text) ? txtInicioGarantia.Text : string.Empty,
                    FimGarantia = !string.IsNullOrWhiteSpace(txtFimGarantia.Text) ? txtFimGarantia.Text : string.Empty,
                    MaoObra = !string.IsNullOrWhiteSpace(txtMaoObra.Text) ? txtMaoObra.Text : string.Empty,
                    CustoManual = !string.IsNullOrWhiteSpace(txtCustoManual.Text) ? txtCustoManual.Text : string.Empty,
                    Acrescimo = !string.IsNullOrWhiteSpace(txtAcrescimo.Text) ? txtAcrescimo.Text : string.Empty,
                    Desconto = !string.IsNullOrWhiteSpace(txtDesconto.Text) ? txtDesconto.Text : string.Empty,
                    Observacoes = txtObservacoes.Text,
                    ObservacoesCliente = txtObservacoesCliente.Text,
                    Favorito = _favorito == true ? false : true,
                    ItensOrdemServico = _itensOS.ToList(),
                    ItensEsporadicos = dgvItens.Rows.Cast<DataGridViewRow>()
                    .Where(r => !r.IsNewRow)
                    .Select(r =>
                    {
                        var iditem = r.Cells["colId"].Value;
                        var nome = r.Cells["colDescricao"].Value;

                        return new ItemCard
                        {
                            Id = Convert.ToInt32(iditem),
                            Descricao = nome.ToString()
                        };
                    }).ToList()
                };

                int? retorno = _service.SalvaOS(os);
                // Chama a services sem identificar se é criação ou alteração pois o processo de validação é feito lá
                if (retorno > 0)
                    new AlertBox(Color.FromArgb(0, 60, 4), Color.LimeGreen, Color.Green, Resources.Confirm, "Ordem de Serviço", $"Do cliente: {os.DadosCliente.Nome}", "Foi cadastrado com sucesso!", false).ShowDialog();
                else if (retorno == 0)
                    new AlertBox(Color.FromArgb(0, 60, 4), Color.LimeGreen, Color.Green, Resources.Confirm, "Ordem de Serviço", $"Do cliente: {os.DadosCliente.Nome}", "Foi alterado com sucesso!", false).ShowDialog();

                LimpaCampos();
            }
            catch (Exception ex)
            {
                EmailError.EnviarEmailErro(ex.ToString());
                new AlertBox(Color.FromArgb(64, 0, 0), Color.Red, Color.Crimson, Resources.Error, "Um erro ocorreu:", "Entidade: OS", "Erro ao salvar OS!", false).ShowDialog();
            }

        }
        
        private void LimpaCampos()
        {
            _idOS = 0;
            _cliente = null;
            _favorito = false;


            Favorito();
            CarregaCombos();

            txtId.Clear();
            txtCliente.Clear();
            txtDescricao.Clear();
            txtGarantia.Clear();
            txtDataEntrada.Clear();
            txtFimPrevisto.Clear();
            txtInicioGarantia.Clear();
            txtFimGarantia.Clear();
            txtMaoObra.Clear();
            txtTotalPecas.Clear();
            txtAcrescimo.Clear();
            txtDesconto.Clear();
            txtObservacoes.Clear();
            txtTotalServico.Clear();
            dgvItens.Rows.Clear();

            // 🔹 REMOVE E DESCARTA OS CARDS
            foreach (Control ctrl in flpItens.Controls)
            {
                ctrl.Dispose();
            }

            flpItens.Controls.Clear();

            // 🔹 ZERA A LISTA LÓGICA
            _itensOS.Clear();
        }
        private bool ValidaCampos()
        {
            // Nome obrigatório
            if (string.IsNullOrWhiteSpace(txtProblema.Text))
            {
                new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Ordem de Serviço", "Item sem nome válido", "O nome do item é obrigatório", false).ShowDialog();
                txtDescricao.Focus();
                return false;
            }
            else if (_cliente.Id < 1 && _cliente.Nome != string.Empty)
            {
                new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Ordem de Serviço", "Cliente não foi selecioando", "Selecione o cliente", false).ShowDialog();
                txtCliente.Focus();
                return false;
            }
            else if ((int)cbTipoServico.SelectedValue < 1)
            {
                new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Ordem de Serviço", "Unidade de medida inválida", "Selecione uma das opções", false).ShowDialog();
                cbTipoServico.Focus();
                return false;
            }
            else if ((int)cbStatus.SelectedValue < 1)
            {
                new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Item de Estoque", "Categoria inválida", "Selecione uma das opções", false).ShowDialog();
                cbStatus.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtDataEntrada.Text))
            {
                new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Item de Estoque", "Item sem quantidade mínima", "A quantidade mínima é obrigatória", false).ShowDialog();
                txtDataEntrada.Focus();
                return false;
            }
            else if (_idOS == 0 && (Convert.ToInt32(cbStatus.SelectedValue) == 11 || Convert.ToInt32(cbStatus.SelectedValue) == 10)) // Impede a OS de ser cadastrada como Finalizada ou Cancelada
            {
                new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Ordem de Serviço", "Status Inválido para Inserção", "O Status da OS deve seguir o fluxo, não pode iniciar como Finalizado ou Cancelado", false).ShowDialog();
                cbStatus.Focus();
                return false;
            }

            else return true;

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Exportar();
        }
        private void Exportar ()
        {
            List<OrdemServico> os = new List<OrdemServico>();
            os = _service.BuscaCompleta(_idOS);
            new SelecaoImpressao(os).ShowDialog();
        }

        private void txtCliente_TrailingIconClick(object sender, EventArgs e)
        {
            PesquisaRapidaCliente frm = new PesquisaRapidaCliente();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _cliente = frm.ClienteSelecionado;
                txtCliente.Text = _cliente.Nome;
                txtIdentidade.Text = _cliente.Identidade;
            }
        }
        private void AtualizarFimGarantia()
        {
            if (!string.IsNullOrWhiteSpace(txtInicioGarantia.Text) && !string.IsNullOrWhiteSpace(txtGarantia.Text))
            {
                if (!DateTime.TryParse(txtInicioGarantia.Text, out DateTime dataInicio))
                    return;

                if (!int.TryParse(txtGarantia.Text, out int diasGarantia))
                    return;

                var dataFim = dataInicio.AddDays(diasGarantia);
                txtFimGarantia.Text = dataFim.ToString("dd/MM/yyyy");
            }
            else txtFimGarantia.Clear();
        }

        private void txtGarantia_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtInicioGarantia_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtGarantia_TextChanged(object sender, EventArgs e)
        {
            AtualizarFimGarantia();
        }

        private void txtCustoManual_TextChanged(object sender, EventArgs e)
        {
            FormataMoeda(sender);
            CalculaTotal();
        }

        private void txtNomeItemEsporadico_TrailingIconClick(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtNomeItemEsporadico.Text))
            {
                PreencheGridItemEsporadico(0, txtNomeItemEsporadico.Text);

                // Limpa campos para próxima entrada
                txtNomeItemEsporadico.Clear();
            }
            else
            {
                new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Ordem de Serviço", "Campo de nome do item vazio", "O nome do item é obrigatório", false).ShowDialog();
            }

                txtNomeItemEsporadico.Focus();
        }
        private void PreencheGridItemEsporadico(int id, string item)
        {
            dgvItens.RowTemplate.Height = 35;
            // Adiciona uma nova linha ao DataGridView
            dgvItens.Rows.Add(
                    id,                          // colIdTelefone = 0 (novo registro)
                    item,                   // colTelefone
                    Resources.remove
                );
        }

        private void dgvItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se clicou na coluna de excluir
            if (dgvItens.Columns[e.ColumnIndex].Name == "colExcluir" && e.RowIndex >= 0)
            {
                // Opcional: confirmação
                var result = new AlertBox(Color.Goldenrod, Color.LimeGreen, Color.Yellow, Resources.Warning, "Aviso de Exclusão", string.Empty, "Deseja realmente excluir o item?", true).ShowDialog();
                if (result == DialogResult.Yes)
                {
                    // Remove a linha
                    dgvItens.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void CadastroOS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Salvar();
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Control && e.KeyCode == Keys.P && btnExportar.Enabled == true)
            {
                Exportar();
                e.Handled = true;
            }
        }
    }
}
