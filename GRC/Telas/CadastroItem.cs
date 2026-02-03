using Business.EmailSender;
using Business.Helper;
using Business.Services;
using Data.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GRC.Telas
{
    public partial class CadastroItem : Form
    {
        private long _idItem = 0;
        private bool _itemVenda = false;
        private bool _favorito = false;
        private string _base64Imagem;
        private string _projecaoVenda;
        private ServiceItemEstoque _service = new ServiceItemEstoque();

        public CadastroItem(long id = 0)
        {
            InitializeComponent();
            _idItem = id;

        }


        private void swItemVenda_CheckedChanged(object sender, EventArgs e)
        {
            if (swItemVenda.Checked)
            {
                _itemVenda = true;
                gpbInfoVenda.Enabled = true;
            }
            else
            {
                LimpaCamposVenda();
            }
        }

        private void pcbFavorito_Click(object sender, EventArgs e)
        {
            Favorito();
        }

        private void CadastroItem_Load(object sender, EventArgs e)
        {
            _favorito = false;
            swItemAtivo.Checked = true;
            chkItemComposto.Checked = false;
            btnAddComposicao.Enabled = false;
            dgvItemComposicao.Enabled = false;
            ZeraValorAoDesfocar("R$ 0,00", txtCustoUnitario);
            ZeraValorAoDesfocar("0", txtQtd);
            ZeraValorAoDesfocar("0", txtQtdMinima);
            Favorito();
            CarregaCombos();

            if (_idItem > 0)
                CarregaDados();

            txtDescricao.Focus();
        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            new Categoria().ShowDialog();
            PreencherCombo(cbCategoria, _service.BuscaCategoriaItem(), "Descricao", "Id");
        }

        private void btnAddUnidadeMedida_Click(object sender, EventArgs e)
        {
            new UnidadeMedida().ShowDialog();
            PreencherCombo(cbUnidadeMedida, _service.BuscaUnidadeMedida(), "Descricao", "Id");
        }

        private void btnAddFabricante_Click(object sender, EventArgs e)
        {
            new Fabricante().ShowDialog();
            PreencherCombo(cbFabricante, _service.BuscaFabricante(), "Descricao", "Id");
        }

        private void btnAddFornecedor_Click(object sender, EventArgs e)
        {
            new CadastroFornecedor().ShowDialog();
            PreencherCombo(cbFornecedor, _service.BuscaFornecedor(), "Descricao", "Id");
        }
        private void CarregaCombos()
        {
            PreencherCombo(cbCategoria, _service.BuscaCategoriaItem(), "Descricao", "Id");
            PreencherCombo(cbFabricante, _service.BuscaFabricante(), "Descricao", "Id");
            PreencherCombo(cbUnidadeMedida, _service.BuscaUnidadeMedida(), "Descricao", "Id");
            PreencherCombo(cbFornecedor, _service.BuscaFornecedor(), "Descricao", "Id");
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

        private void txtCustoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            DesativaCaracteres(sender, e);
        }


        private void txtCustoUnitario_KeyDown(object sender, KeyEventArgs e)
        {
            VerificaKeyV(sender, e);
        }
        private void CalculaCustoTotal()
        {
            bool qtdOk = decimal.TryParse(txtQtd.Text, out decimal qtd);
            bool unitOk = decimal.TryParse(txtCustoUnitario.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal unit);

            if (qtdOk && unitOk)
            {
                decimal total = qtd * unit;
                txtCustoTotal.Text = total.ToString("C2", CultureInfo.CurrentCulture);
            }
            else
            {
                txtCustoTotal.Clear();
                ZeraValorAoDesfocar("R$ 0,00", txtCustoTotal);
            }
        }

        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            DesativaCaracteres(sender, e);
        }

        private void txtCustoUnitario_TextChanged(object sender, EventArgs e)
        {
            FormataMoeda(sender);
            CalculaCustoTotal();
            if (swItemVenda.Checked)
            {
                CalculaLucroPorItem();
                CalculaLucroTotal();
            }
        }

        private void txtCustoUnitario_Leave(object sender, EventArgs e)
        {
            ZeraValorAoDesfocar("R$ 0,00", txtCustoUnitario);
        }

        private void txtCustoUnitario_Enter(object sender, EventArgs e)
        {
            LimpaValorAoFocar("R$ 0,00", txtCustoUnitario);
        }

        private void txtQtd_Enter(object sender, EventArgs e)
        {
            LimpaValorAoFocar("0", txtQtd);
        }

        private void txtQtd_Leave(object sender, EventArgs e)
        {
            ZeraValorAoDesfocar("0", txtQtd);
        }
        private void DesativaCaracteres(object sender, KeyPressEventArgs e)
        {
            // Só permite números e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
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

        private void txtQtdMinima_Enter(object sender, EventArgs e)
        {
            LimpaValorAoFocar("0", txtQtdMinima);
        }

        private void txtQtdMinima_Leave(object sender, EventArgs e)
        {
            ZeraValorAoDesfocar("0", txtQtdMinima);
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

        private void txtQtdMinima_KeyPress(object sender, KeyPressEventArgs e)
        {
            DesativaCaracteres(sender, e);
        }

        private void txtValidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            DesativaCaracteres(sender, e);

        }

        private void txtValidade_TextChanged(object sender, EventArgs e)
        {
            // Remove tudo que não é número
            string apenasNumeros = new string(txtValidade.Text.Where(char.IsDigit).ToArray());

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

            txtValidade.Text = formatado;
            txtValidade.SelectionStart = txtValidade.Text.Length;
        }

        private void txtValidade_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtValidade.Text))
            {
                if (DateTime.TryParseExact(txtValidade.Text, "dd/MM/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None,
                    out _))
                {

                }
                else
                {
                    new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Item de Estoque", "Data Inválida", " Use o formato dd/mm/aaaa!", false).ShowDialog();
                    txtValidade.Focus();
                }
            }
        }

        private void txtValorVenda_Enter(object sender, EventArgs e)
        {
            LimpaValorAoFocar("R$ 0,00", txtValorVenda);
        }

        private void txtValorVenda_Leave(object sender, EventArgs e)
        {
            ZeraValorAoDesfocar("R$ 0,00", txtValorVenda);
        }

        private void txtValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            DesativaCaracteres(sender, e);
        }

        private void txtValorVenda_TextChanged(object sender, EventArgs e)
        {
            FormataMoeda(sender);
            CalculaVendaTotal();
            CalculaLucroPorItem();
            CalculaLucroTotal();
        }
        private void CalculaVendaTotal()
        {
            bool qtdOk = decimal.TryParse(txtQtd.Text, out decimal qtd);
            bool VendaOk = decimal.TryParse(txtValorVenda.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal venda);

            if (qtdOk && VendaOk)
            {
                decimal total = qtd * venda;
                _projecaoVenda = total.ToString("C2", CultureInfo.CurrentCulture);
            }
            else
            {
                _projecaoVenda = string.Empty;
            }
        }
        private void CalculaLucroPorItem()
        {
            bool unitOk = decimal.TryParse(txtCustoUnitario.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal unit);
            bool VendaOk = decimal.TryParse(txtValorVenda.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal venda);

            if (unitOk && VendaOk)
            {
                decimal total = venda - unit;
                txtLucroItem.Text = total.ToString("C2", CultureInfo.CurrentCulture);
            }
            else
            {
                txtLucroItem.Clear();
                ZeraValorAoDesfocar("R$ 0,00", txtLucroItem);
            }
        }
        private void CalculaLucroTotal()
        {
            bool VendaTotalOk = decimal.TryParse(_projecaoVenda, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal vendaTotal);
            bool custoTotalOk = decimal.TryParse(txtCustoTotal.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal custototal);

            if (VendaTotalOk && custoTotalOk)
            {
                decimal total = vendaTotal - custototal;
                txtLucroTotal.Text = total.ToString("C2", CultureInfo.CurrentCulture);
            }
            else
            {
                txtLucroTotal.Clear();
                ZeraValorAoDesfocar("R$ 0,00", txtLucroTotal);
            }
        }

        private void txtQtd_TextChanged(object sender, EventArgs e)
        {
            CalculaCustoTotal();
            if (swItemVenda.Checked)
            {
                CalculaLucroPorItem();
                CalculaLucroTotal();
            }
        }

        private void txtGarantia_KeyPress(object sender, KeyPressEventArgs e)
        {
            DesativaCaracteres(sender, e);
        }

        private void txtGarantia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGarantia_Enter(object sender, EventArgs e)
        {
            LimpaValorAoFocar("0", txtGarantia);
        }

        private void txtGarantia_Leave(object sender, EventArgs e)
        {
            ZeraValorAoDesfocar(string.Empty, txtGarantia);
        }

        private void btnBuscaImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png;";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _base64Imagem = CriptoImagem.ImagemParaBase64(ofd.FileName).ToString();
                        pcbImagemItem.Image = CriptoImagem.Base64ToImage(_base64Imagem);
                    }
                    catch (Exception ex)
                    {
                        EmailError.EnviarEmailErro(ex.ToString());
                        new AlertBox(Color.FromArgb(64, 0, 0), Color.Red, Color.Crimson, Resources.Error, "Um erro ocorreu:", "Entidade: Item de Estoque", "Erro ao subir imagem!", false).ShowDialog();
                    }
                }
                else
                    pcbImagemItem.Image = null;
            }
        }

        private void btnExcluiImagem_Click(object sender, EventArgs e)
        {
            pcbImagemItem.Image = null;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidaCampos())
                {
                    MudaCorPainel(Color.Red, Color.Crimson);
                    return;
                }
                var item = new Item
                {
                    Id = _idItem,
                    Descricao = txtDescricao.Text,
                    CodBarras = txtCodigoBarras.Text.Trim(),
                    Garantia = !string.IsNullOrWhiteSpace(txtGarantia.Text) ? txtGarantia.Text.Trim() : string.Empty,
                    Validade = !string.IsNullOrWhiteSpace(txtValidade.Text) ? txtValidade.Text.Trim() : string.Empty,
                    UnidadeMedida = Convert.ToInt32(cbUnidadeMedida.SelectedValue),
                    QuatidadeMinima = Convert.ToInt32(txtQtdMinima.Text),
                    Quatidade = Convert.ToInt32(txtQtd.Text),
                    CustoUnitario = !string.IsNullOrWhiteSpace(txtCustoUnitario.Text) ? txtCustoUnitario.Text : string.Empty,
                    Categoria = Convert.ToInt32(cbCategoria.SelectedValue),
                    Fabricante = Convert.ToInt32(cbFabricante.SelectedValue),
                    Fornecedor = Convert.ToInt32(cbFornecedor.SelectedValue),
                    Observacoes = txtObservacoes.Text,
                    ItemVenda = swItemVenda.Checked == true ? true : false,
                    DescricaoVenda = txtDescricaoItemVenda.Text,
                    VendaUnitario = _itemVenda == true && !string.IsNullOrWhiteSpace(txtValorVenda.Text) ? txtValorVenda.Text : string.Empty,
                    FotoItem = string.IsNullOrEmpty(_base64Imagem) ? string.Empty : _base64Imagem,
                    Favorito = _favorito == true ? false : true,
                    Ativo = swItemAtivo.Checked ? true : false,


                    ComposicaoItem = dgvItemComposicao.Rows.Cast<DataGridViewRow>()
                    .Where(r => !r.IsNewRow)
                    .Select(r =>
                    {
                        var idComposicao = r.Cells["colId"].Value;            // ID da tabela GRC_COMPOSICAO
                        var idItemComposicao = r.Cells["IdComposicao"].Value; // ID do item que compõe

                        return new Composicao
                        {
                            Id = idComposicao == null || idComposicao == DBNull.Value ? (int?)null : Convert.ToInt32(idComposicao),
                            IdItemComposicao = idItemComposicao != null ? Convert.ToInt32(idItemComposicao) : 0
                        };
                    }).ToList()
                };

                long? retorno = _service.SalvaItem(item);
                // Chama a services sem identificar se é criação ou alteração pois o processo de validação é feito lá
                if (retorno > 0)
                    new AlertBox(Color.FromArgb(0, 60, 4), Color.LimeGreen, Color.Green, Resources.Confirm, "Item de Estoque", item.Descricao.ToString(), "Foi cadastrado com sucesso!", false).ShowDialog();
                else if (retorno == 0)
                    new AlertBox(Color.FromArgb(0, 60, 4), Color.LimeGreen, Color.Green, Resources.Confirm, "Item de Estoque", item.Descricao.ToString(), "Foi alterado com sucesso!", false).ShowDialog();
                else if (retorno == -1)
                    new AlertBox(Color.FromArgb(0, 60, 4), Color.LimeGreen, Color.Green, Resources.Confirm, "Item de Estoque", item.Descricao.ToString(), "Foi inativado com sucesso!", false).ShowDialog();
                LimpaCampos();
            }
            catch (Exception ex)
            {
                EmailError.EnviarEmailErro(ex.ToString());
                new AlertBox(Color.FromArgb(64, 0, 0), Color.Red, Color.Crimson, Resources.Error, "Um erro ocorreu:", "Entidade: Item de Estoque", "Erro ao salvar item!", false).ShowDialog();
            }

        }
        private bool ValidaCampos()
        {
            // Nome obrigatório
            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Item de Estoque", "Item sem nome válido", "O nome do item é obrigatório", false).ShowDialog();
                txtDescricao.Focus();
                return false;
            }
            else if ((int)cbUnidadeMedida.SelectedValue < 1)
            {
                new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Item de Estoque", "Unidade de medida inválida", "Selecione uma das opções", false).ShowDialog();
                cbUnidadeMedida.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtQtdMinima.Text))
            {
                new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Item de Estoque", "Item sem quantidade mínima", "A quantidade mínima é obrigatória", false).ShowDialog();
                txtQtdMinima.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtQtd.Text))
            {
                new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Item de Estoque", "Item sem quantidade", "A quantidade é obrigatória", false).ShowDialog();
                txtQtd.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtCustoUnitario.Text))
            {
                new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Item de Estoque", "Item sem Custo Unitário", "O preenchimento é obrigatório", false).ShowDialog();
                txtQtd.Focus();
                return false;
            }
            else if ((int)cbCategoria.SelectedValue < 1)
            {
                new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Item de Estoque", "Categoria inválida", "Selecione uma das opções", false).ShowDialog();
                cbCategoria.Focus();
                return false;
            }
            else if ((int)cbFabricante.SelectedValue < 1)
            {
                new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Item de Estoque", "Fabricante inválido", "Selecione uma das opções", false).ShowDialog();
                cbFabricante.Focus();
                return false;
            }
            else if ((int)cbFornecedor.SelectedValue < 1)
            {
                new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Item de Estoque", "Fornecedor inválido", "Selecione uma das opções", false).ShowDialog();
                cbFornecedor.Focus();
                return false;
            }
            else if (_itemVenda == true)
            {
                if (string.IsNullOrWhiteSpace(txtValorVenda.Text))
                {
                    new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Item de Estoque", "Valor de venda inválido", "Campo é obrigatório", false).ShowDialog();
                    txtValorVenda.Focus();
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(txtDescricaoItemVenda.Text))
                {
                    new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Item de Estoque", "Nome do produto inválido", "Campo é obrigatório", false).ShowDialog();
                    txtDescricaoItemVenda.Focus();
                    return false;
                }
                else return true;
            }
            else return true;

        }
        private void LimpaCampos()
        {
            _idItem = 0;
            _favorito = false;
            _base64Imagem = null;
            swItemAtivo.Checked = true;
            pcbImagemItem.Image = null;
            Favorito();
            CarregaCombos();
            txtCustoUnitario.Clear();
            txtCustoTotal.Clear();
            txtQtd.Clear();
            txtQtdMinima.Clear();
            LimpaCamposVenda();
        }
        private void LimpaCamposVenda()
        {

            _itemVenda = false;
            swItemVenda.Checked = false;
            gpbInfoVenda.Enabled = false;
            txtValorVenda.Clear();
            txtLucroItem.Clear();
            txtLucroTotal.Clear();
            txtId.Clear();
            txtDescricao.Clear();
            txtCodigoBarras.Clear();
            txtGarantia.Clear();
            txtValidade.Clear();
            txtObservacoes.Clear();
            txtDescricaoItemVenda.Clear();
            dgvItemComposicao.DataSource = null;
        }

        private void CadastroItem_Leave(object sender, EventArgs e)
        {
            if (txtGarantia.Text == "0")
                txtGarantia.Clear();
        }

        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescricaoItemVenda.Text) && !string.IsNullOrWhiteSpace(txtDescricao.Text))
                txtDescricaoItemVenda.Text = txtDescricao.Text;
        }

        public List<Composicao> ItensSelecionados { get; private set; } = new List<Composicao>();
        private void btnAddComposicao_Click(object sender, EventArgs e)
        {
            using (var frm = new ComposicaoItem())
            {
                frm.ShowDialog();

                if (frm.ItensSelecionados != null && frm.ItensSelecionados.Count > 0)
                {
                    foreach (var comp in frm.ItensSelecionados)
                    {
                        // evita duplicidade
                        if (!ItensSelecionados.Any(x => x.IdItemComposicao == comp.IdItemComposicao))
                        {
                            ItensSelecionados.Add(comp);
                        }
                    }
                }
            }

            AtualizarGridComposicao();
        }


        private void AtualizarGridComposicao()
        {
            dgvItemComposicao.DataSource = null;
            dgvItemComposicao.RowTemplate.Height = 30;
            dgvItemComposicao.AutoGenerateColumns = false;
            dgvItemComposicao.ColumnHeadersVisible = true;
            dgvItemComposicao.ColumnHeadersHeight = 50;
            dgvItemComposicao.DataSource = ItensSelecionados;
        }

        private void dgvItemComposicao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvItemComposicao.Columns[e.ColumnIndex].Name == "colExcluir")
            {
                var item = (Composicao)dgvItemComposicao.Rows[e.RowIndex].DataBoundItem;
                ItensSelecionados.Remove(item);
                AtualizarGridComposicao();
            }
        }
        private void CarregaDados()
        {
            try
            {
                dgvItemComposicao.Rows.Clear();
                var dadosItem = _service.BuscaCompleta(_idItem).FirstOrDefault();
                if (dadosItem == null)
                    return;

                swItemAtivo.Checked = dadosItem.Ativo;
                txtId.Text = dadosItem.Id.ToString();
                txtCodigoBarras.Text = dadosItem.CodBarras != null ? dadosItem.CodBarras.ToString() : string.Empty;
                txtDescricao.Text = dadosItem.Descricao.ToString();
                txtGarantia.Text = dadosItem.Garantia != null ? dadosItem.Garantia.ToString() : string.Empty;
                txtValidade.Text = dadosItem.Validade != null ? dadosItem.Validade.ToString() : string.Empty;
                cbUnidadeMedida.SelectedValue = dadosItem.UnidadeMedida;
                cbCategoria.SelectedValue = dadosItem.Categoria;
                cbFabricante.SelectedValue = dadosItem.Fabricante;
                cbFornecedor.SelectedValue = dadosItem.Fornecedor;
                txtQtdMinima.Text = dadosItem.QuatidadeMinima.ToString();
                txtQtd.Text = dadosItem.Quatidade.ToString();
                txtCustoUnitario.Text = dadosItem.CustoUnitario.ToString();
                CalculaCustoTotal();
                _favorito = dadosItem.Favorito;
                Favorito();
                _base64Imagem = dadosItem.FotoItem;
                pcbImagemItem.Image = string.IsNullOrEmpty(_base64Imagem) ? null : CriptoImagem.Base64ToImage(_base64Imagem);
                txtObservacoes.Text = dadosItem.Observacoes != null ? dadosItem.Observacoes.ToString() : string.Empty;

                if (dadosItem.ItemVenda == true)
                {
                    swItemVenda.Checked = dadosItem.ItemVenda;
                    txtDescricaoItemVenda.Text = dadosItem.DescricaoVenda.ToString();
                    txtValorVenda.Text = dadosItem.VendaUnitario.ToString();
                    CalculaVendaTotal();
                    CalculaLucroPorItem();
                    CalculaLucroTotal();
                    if (dadosItem.ComposicaoItem != null && dadosItem.ComposicaoItem.Count > 0)
                    {
                        btnAddComposicao.Enabled = true;
                        dgvItemComposicao.Enabled = true;
                        ItensSelecionados = dadosItem.ComposicaoItem;
                        AtualizarGridComposicao();
                    }
                    else
                    {
                        btnAddComposicao.Enabled = false;
                        dgvItemComposicao.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                EmailError.EnviarEmailErro(ex.ToString());
                new AlertBox(Color.FromArgb(64, 0, 0), Color.Red, Color.Crimson, Resources.Error, "Um erro ocorreu:", "Entidade: Item de Estoque", "Erro ao Carregar o item!", false).ShowDialog();
            }
        }

        private void swItemAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (swItemAtivo.Checked == true)
            {
                pcAtivo.Visible = true;
                pnStatus.Color1 = Color.Ivory;
                pnStatus.Color2 = Color.Lime;
                if (_idItem > 0)
                    MudaCorPainel(Color.LimeGreen, Color.Yellow);
                else
                    MudaCorPainel(Color.SpringGreen, Color.Blue);

            }
            else
            {
                pcAtivo.Visible = false;
                MudaCorPainel(Color.Gray, Color.DarkGray);
            }
        }

        private void MudaCorPainel(Color cor1, Color cor2)
        {
            pnStatus.Color1 = cor1;
            pnStatus.Color2 = cor2;
        }

        private void chkItemComposto_CheckedChanged(object sender, EventArgs e)
        {
            if(chkItemComposto.Checked)
            {
                btnAddComposicao.Enabled = true;
                dgvItemComposicao.Enabled = true;
            }
            else
            {
                btnAddComposicao.Enabled = false;
                dgvItemComposicao.Enabled = false;
            }
        }
    }
}