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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRC.Telas
{
    public partial class CadastroMovimentacao : Form
    {
        private int _IdMovimentacao = 0;
        private int _idItem = 0;
        private int _operacao = 0;
        private bool _bloqueado = false;
        Item _dadosItem = new Item();
        ServiceMovimentacao _service = new ServiceMovimentacao();
        public CadastroMovimentacao(int id = 0)
        {
            InitializeComponent();
            _IdMovimentacao = id;
        }

        private void CadastroMovimentacao_Load(object sender, EventArgs e)
        {
            PreencherCombo(cbTipoMovimento, _service.BuscaTipoMovimentacao(), "Descricao", "Id");

            if (_IdMovimentacao == 0)
                txtData.Text = DateTime.Today.ToString("dd/MM/yyyy");

            swItemAtivo.Checked = true;

            if (_IdMovimentacao > 0)
                CarregaDados();

            txtMotivo.Focus();
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

        private void btnSelecaoItem_Click(object sender, EventArgs e)
        {
            using (var frm = new PesquisaItem())
            {
                frm.ShowDialog();

                if (frm._item != null && frm._item.Count > 0)
                {
                    foreach (var comp in frm._item)
                    {
                        _dadosItem.Id = comp.Id;
                        _dadosItem.Descricao = comp.Descricao;
                        _dadosItem.Quatidade = comp.Quatidade;
                        _dadosItem.CustoUnitario = comp.CustoUnitario;
                        _dadosItem.VendaUnitario = comp.VendaUnitario;
                        _dadosItem.ItemVenda = comp.ItemVenda;
                    }
                    txtItem.Text = _dadosItem.Descricao;
                    _idItem = Convert.ToInt32(_dadosItem.Id);

                }
            }
        }
        private void HabilitaCampos()
        {
            _operacao = Convert.ToInt32(cbTipoMovimento.SelectedValue) > 0 ? Convert.ToInt32(cbTipoMovimento.SelectedValue) : 0;
            if (_operacao == 1) // Referente a entrada no estoque
            {
                txtCustoUnitario.Visible = true;
                txtCustoTotal.Visible = true;
            }
            else if(_operacao == 2) // Referente a Saída
            {
                txtCustoUnitario.Visible = false;
                txtCustoTotal.Visible = false;
            }
            else if (_operacao == 3) // Referente a Desperdício
            {
                txtCustoUnitario.Visible = false;
                txtCustoTotal.Visible = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_bloqueado == false)
            {
                if (!ValidaCampos())
                {
                    MudaCorPainel(Color.Red, Color.Crimson);
                    return;
                }
                var movimento = new Movimentacao
                {
                    Id = _IdMovimentacao,
                    IdItem = _idItem,
                    IdTipoMovimentacao = Convert.ToInt32(cbTipoMovimento.SelectedValue),
                    Motivo = txtMotivo.Text,
                    Quantidade = Convert.ToInt32(txtQuantidade.Text),
                    CustoUnitario = txtCustoUnitario.Text,
                    Observacoes = txtObservacoes.Text,
                    DataMovimentacao = txtData.Text,
                    Ativo = swItemAtivo.Checked ? true : false
                };

                int? retorno = _service.SalvaMovimentacao(movimento);
                // Chama a services sem identificar se é criação ou alteração pois o processo de validação é feito lá
                if (retorno > 0)
                    new AlertBox(Color.FromArgb(0, 60, 4), Color.LimeGreen, Color.Green, Resources.Confirm, "Movimentação", $"Movimento de {cbTipoMovimento.Text.ToString()}", "Foi cadastrado com sucesso!", false).ShowDialog();
                else if (retorno == 0)
                    new AlertBox(Color.FromArgb(0, 60, 4), Color.LimeGreen, Color.Green, Resources.Confirm, "Movimentação", $"Movimento de {cbTipoMovimento.Text.ToString()}", "Foi alterado com sucesso!", false).ShowDialog();
                else if (retorno == -1)
                    new AlertBox(Color.FromArgb(0, 60, 4), Color.LimeGreen, Color.Green, Resources.Confirm, "Movimentação", $"Movimento de {cbTipoMovimento.Text.ToString()}", "Foi inativado e não pode mais ser recuperado!", false).ShowDialog();

                this.Close();
            }
            else
            {
                new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Movimentação", "Valores não podem ser salvos", "Movimentação bloqueada", false).ShowDialog();
            }
        }
        private void LimpaCampos()
        {
            _idItem = 0;
            _IdMovimentacao = 0;
            _operacao = 0;
            txtData.Clear();
            txtItem.Clear();
            txtMotivo.Clear();
            txtCustoUnitario.Clear();
            txtCustoTotal.Clear();
            txtObservacoes.Clear();
        }

        private void cbTipoMovimento_SelectedValueChanged(object sender, EventArgs e)
        {
            HabilitaCampos();
        }
        private bool ValidaCampos()
        {
            if (!string.IsNullOrWhiteSpace(txtData.Text)
                && _idItem > 0
                && Convert.ToInt32(cbTipoMovimento.SelectedValue) > 0
                && !string.IsNullOrWhiteSpace(txtMotivo.Text)
                && !string.IsNullOrWhiteSpace(txtQuantidade.Text))
            {
                if (_operacao == 1)
                {
                    if(!string.IsNullOrWhiteSpace(txtCustoUnitario.Text))
                        return true;
                    else 
                        return false;
                }
                else 
                    return true;
            }
            else return false;
        }

        private void txtCustoUnitario_TextChanged(object sender, EventArgs e)
        {
            FormataMoeda(sender);
            CalculaCustoTotal();
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
        private void CalculaCustoTotal()
        {
            bool qtdOk = decimal.TryParse(txtQuantidade.Text, out decimal qtd);
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
        private void ZeraValorAoDesfocar(string valor, MaterialTextBox txtBox)
        {
            if (string.IsNullOrWhiteSpace(txtBox.Text))
                txtBox.Text = valor;
        }

        private void txtCustoUnitario_Enter(object sender, EventArgs e)
        {
            LimpaValorAoFocar("R$ 0,00", txtCustoUnitario);
        }

        private void txtCustoUnitario_Leave(object sender, EventArgs e)
        {
            ZeraValorAoDesfocar("R$ 0,00", txtCustoUnitario);
        }
        private void LimpaValorAoFocar(string valor, MaterialTextBox txtBox)
        {
            if (txtBox.Text == valor)
                txtBox.Clear();
        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {
            // Remove tudo que não é número
            string apenasNumeros = new string(txtData.Text.Where(char.IsDigit).ToArray());

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

            txtData.Text = formatado;
            txtData.SelectionStart = txtData.Text.Length;
        }

        private void txtData_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtData.Text))
            {
                if (DateTime.TryParseExact(txtData.Text, "dd/MM/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None,
                    out _))
                {

                }
                else
                {
                    new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Movimentação", "Data Inválida", " Use o formato dd/mm/aaaa!", false).ShowDialog();
                    txtData.Focus();
                }
            }
        }

        private void swItemAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (swItemAtivo.Checked == true)
            {
                pcAtivo.Visible = true;
                pnStatus.Color1 = Color.Ivory;
                pnStatus.Color2 = Color.Lime;
                pnStatus2.Color1 = Color.Ivory;
                pnStatus2.Color2 = Color.Lime;
                if (_IdMovimentacao > 0)
                    MudaCorPainel(Color.LimeGreen, Color.Yellow);
                else
                    MudaCorPainel(Color.SpringGreen, Color.Cyan);

            }
            else
            {
                // Esta é a parte de DESATIVAR (o switch está sendo desligado)

                if (new AlertBox(Color.Goldenrod, Color.Lime, Color.Yellow, Resources.Warning, "Movimentação", "Ao desativar você perde para sempre essa movimentação", "Deseja mesmo excluir esse movimento?", true).ShowDialog() == DialogResult.Yes)
                {
                    // O usuário CONFIRMOU a desativação
                    swItemAtivo.Checked = false; // Mantém desativado (já está false, mas para garantir)
                    pcAtivo.Visible = false;
                    MudaCorPainel(Color.Gray, Color.DarkGray);

                    // *** ESSA É A CHAVE: DESABILITAR O CONTROLE ***
                    // Uma vez que foi desativado/excluído, ele não pode ser clicado/ativado novamente.
                    swItemAtivo.Enabled = false;
                }
                else
                {
                    // O usuário CANCELOU a desativação. O switch precisa voltar ao estado ATIVO.
                    // A linha abaixo já está correta no seu código.
                    swItemAtivo.Checked = true;
                }
            }
        }
        private void MudaCorPainel(Color cor1, Color cor2)
        {
            pnStatus.Color1 = cor1;
            pnStatus.Color2 = cor2;
            pnStatus2.Color1 = cor1;
            pnStatus2.Color2 = cor2;
        }
        private void CarregaDados()
        {
            try
            {
                var dadosMov = _service.BuscaCompleta(_IdMovimentacao).FirstOrDefault();
                if (dadosMov == null)
                    return;

                _idItem = dadosMov.IdItem;
                swItemAtivo.Checked = true;
                btnSelecaoItem.Enabled = false;
                txtQuantidade.Enabled = false;
                txtData.Text = dadosMov.DataMovimentacao;
                cbTipoMovimento.SelectedValue = dadosMov.IdTipoMovimentacao;
                cbTipoMovimento.Enabled = false;
                txtMotivo.Text = dadosMov.Motivo;
                txtItem.Text = dadosMov.DescricaoItem;
                txtQuantidade.Text = dadosMov.Quantidade.ToString();
                txtObservacoes.Text = dadosMov.Observacoes;

                if (dadosMov.IdTipoMovimentacao == 1)
                {
                    txtCustoUnitario.Enabled = false;
                    txtCustoUnitario.Text = dadosMov.CustoUnitario;
                    CalculaCustoTotal();
                }
            }
            catch (Exception ex)
            {
                EmailError.EnviarEmailErro(ex.ToString());
                new AlertBox(Color.FromArgb(64, 0, 0), Color.Red, Color.Crimson, Resources.Error, "Um erro ocorreu:", "Entidade: Movimentação", "Erro ao Carregar!", false).ShowDialog();
            }
        }
    }
}
