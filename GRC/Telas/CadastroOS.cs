using Business.Helper;
using Business.Services;
using Data.Models;
using GRC.Componentes;
using GRC.Properties;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace GRC.Telas
{
    public partial class CadastroOS : Form
    {
        private int _idCliente = 0;
        private bool _favorito = false;

        private List<ItemCard> _itensOS = new List<ItemCard>();
        public Item _dadosItem = new Item();
        ServiceOrdemServico _service = new ServiceOrdemServico();

        public CadastroOS()
        {
            InitializeComponent();
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            new CadastroItem().ShowDialog();
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            PesquisaRapidaCliente frm = new PesquisaRapidaCliente();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _idCliente = frm._cliente.Id;
                txtCliente.Text = frm._cliente.Nome;
            }
        }

        private void CadastroOS_Load(object sender, EventArgs e)
        {
            swAtivo.Checked = true;
            lbDataAtual.Text = DateTime.Today.ToString("dd/MM/yyyy");
            CarregaCombos();
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
        }

        private void txtFimGarantia_TextChanged(object sender, EventArgs e)
        {
            FormataData(txtFimGarantia);
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
                        _dadosItem = new Item();

                        if (comp.Quatidade > 0)
                        {
                            _dadosItem.Id = comp.Id;
                            _dadosItem.Descricao = comp.Descricao;
                            _dadosItem.Quatidade = comp.Quatidade;
                            _dadosItem.CustoUnitario = comp.CustoUnitario;
                            _dadosItem.FotoItem = comp.FotoItem;
                            AdicionarItemOS(_dadosItem);
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

        private void AdicionarItemOS(Item item)
        {
            decimal.TryParse(item.CustoUnitario.ToString(), NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal unit);

            // Verifica se o item já está na OS
            bool jaExiste = _itensOS.Any(i => i.IdItem == item.Id);

            if (jaExiste)
            {
                // Localiza o card já existente
                var cardExistente = flpItens.Controls
                    .OfType<CustomPanel>()
                    .FirstOrDefault(c =>
                        c.Tag is ItemCard os && os.IdItem == item.Id
                    );

                if (cardExistente != null)
                {
                    // Leva o foco até o card
                    flpItens.ScrollControlIntoView(cardExistente);

                    // Destaca visualmente
                    PiscarCard(cardExistente);

                }

                new AlertBox(
                    Color.Goldenrod,
                    Color.Black,
                    Color.Yellow,
                    Resources.Warning,
                    "Item já adicionado",
                    item.Descricao,
                    "Este item já está na ordem de serviço. Ajuste a quantidade no card existente.",
                    false
                ).ShowDialog();

                return; // BLOQUEIA completamente
            }
            else
            {

                // 🔹 cria o item da OS
                ItemCard itemOS = new ItemCard
                {
                    IdItem = Convert.ToInt32(item.Id),
                    Descricao = item.Descricao,
                    ValorUnitario = unit,
                    Quantidade = 1
                };
                _itensOS.Add(itemOS);
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
                    Text = " ➖",
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
                    Text = "0",
                    Width = 60,
                    Height = 25,
                    Location = new Point(130, 40),
                    //TextAlign = HorizontalAlignment.Center
                    UseTallSize = false,
                    Cursor = Cursors.Default,
                };

                CustomButton btnMais = new CustomButton
                {
                    Text = " ➕",
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
                    Text = $"Valor: {item.CustoUnitario}",
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
                    if (itemOS.Quantidade < item.Quatidade)
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
                    /*ZeraValorAoDesfocar("1", txtQuantidade);
                    if(Convert.ToInt32(txtQuantidade.Text) < 1)
                        txtQuantidade.Text = "1";*/


                    if (!int.TryParse(txtQuantidade.Text, out int qtd) || qtd < 1)
                        qtd = 1;

                    if (qtd > item.Quatidade)
                        qtd = item.Quatidade;

                    itemOS.Quantidade = qtd;
                };

                txtQuantidade.Enter += (s, e) =>
                {
                    LimpaValorAoFocar("1", txtQuantidade);
                };
                txtQuantidade.TextChanged += (s, e) =>
                {
                    AtualizarSubtotal();
                };

                card.Controls.Add(foto);
                card.Controls.Add(lblNome);
                card.Controls.Add(btnMenos);
                card.Controls.Add(txtQuantidade);
                card.Controls.Add(btnMais);
                card.Controls.Add(lblPreco);
                card.Controls.Add(btnExcluir);
                flpItens.Controls.Add(card);
                AtualizarSubtotal();


                void AtualizarSubtotal()
                {
                    txtQuantidade.Text = itemOS.Quantidade.ToString();
                    lblPreco.Text = $"Valor: {itemOS.Subtotal:C2}";
                    AtualizarTotalOS();
                }
            }
        }
        private void AtualizarTotalOS()
        {
            decimal total = _itensOS.Sum(i => i.Subtotal);
            txtTotalPecas.Text = $"{total:C2}";
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



    }
}
