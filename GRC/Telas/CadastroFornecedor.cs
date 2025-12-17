using Business.API;
using Business.EmailSender;
using Business.Services;
using Data.Models;
using GRC.Componentes;
using GRC.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRC.Telas
{
    public partial class CadastroFornecedor : Form
    {
        #region ..:: Instâncias ::..

        private readonly Viacep _viaCep = new Viacep();
        private ServiceFornecedor _serviceFornecedor = new ServiceFornecedor();

        #endregion

        #region ..:: Variáveis ::..

        private int _idFornecedor;
        private int _idEmail;
        private int _idEndereco;
        private bool _ativo;

        #endregion

        public CadastroFornecedor(int idFornecedor = 0)
        {
            InitializeComponent();
            _idFornecedor = idFornecedor;
            _idEmail = 0;
            _idEndereco = 0;
        }


        private void CadastroFornecedor_Load(object sender, EventArgs e)
        {
            swAtivo.Checked = true;
            if (_idFornecedor > 0)
                CarregaDados();
            txtFornecedor.Focus();
        }

        private async void txtCep_Leave(object sender, EventArgs e)
        {
            string cep = txtCep.Text.Trim().Replace("-", "").Replace(".", "");

            if (cep.Length != 8)
                return; // evita consulta se CEP for inválido

            try
            {
                // Busca o endereço
                var endereco = await _viaCep.BuscarEnderecoAsync(cep);

                // Preenche os campos do form
                txtLogradouro.Text = endereco.Logradouro;
                txtBairro.Text = endereco.Bairro;
                txtCidade.Text = endereco.Localidade;
                txtUf.Text = endereco.Uf;
                txtComplemento.Text = endereco.Complemento ?? "";
            }
            catch (Exception ex)
            {
                EmailError.EnviarEmailErro(ex.ToString());
                new AlertBox(Color.FromArgb(64, 0, 0), Color.Red, Color.Crimson, Resources.Error, "Um erro ocorreu:", "Entidade: Fornecedor", "Erro ao Consultar CEP (API OFFLINE)!", false).ShowDialog();
            }
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            string texto = txtCep.Text.Replace("-", "").Trim();

            if (texto.Length > 5)
                txtCep.Text = texto.Insert(5, "-");

            txtCep.SelectionStart = txtCep.Text.Length; // mantém o cursor no fim
        }

        private void txtCnpj_TextChanged(object sender, EventArgs e)
        {
            string texto = new string(txtCnpj.Text.Where(char.IsDigit).ToArray());

            if (texto.Length <= 2)
                txtCnpj.Text = texto;
            else if (texto.Length <= 5)
                txtCnpj.Text = texto.Insert(2, ".");
            else if (texto.Length <= 8)
                txtCnpj.Text = texto.Insert(2, ".").Insert(6, ".");
            else if (texto.Length <= 12)
                txtCnpj.Text = texto.Insert(2, ".").Insert(6, ".").Insert(10, "/");
            else
                txtCnpj.Text = texto.Insert(2, ".").Insert(6, ".").Insert(10, "/").Insert(15, "-");

            txtCnpj.SelectionStart = txtCnpj.Text.Length; // mantém o cursor no final
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            string texto = new string(txtTelefone.Text.Where(char.IsDigit).ToArray());

            if (texto.Length > 11) // máximo 11 dígitos (DDD + 9 números)
                texto = texto.Substring(0, 11);

            // Cancela formatação se estiver limpando
            if (texto.Length == 0)
                return;

            // Salva a posição do cursor
            int posicao = txtTelefone.SelectionStart;

            // Formata de acordo com o tamanho
            if (texto.Length <= 2)
                txtTelefone.Text = $"({texto}";
            else if (texto.Length <= 6)
                txtTelefone.Text = $"({texto.Substring(0, 2)}) {texto.Substring(2)}";
            else if (texto.Length <= 10)
                txtTelefone.Text = $"({texto.Substring(0, 2)}) {texto.Substring(2, 4)}-{texto.Substring(6)}";
            else
                txtTelefone.Text = $"({texto.Substring(0, 2)}) {texto.Substring(2, 5)}-{texto.Substring(7, 4)}";

            txtTelefone.SelectionStart = txtTelefone.Text.Length; // mantém cursor no final
        }
        private void LimpaCampos()
        {
            _idFornecedor = 0;
            txtFornecedor.Text = string.Empty;
            txtRazaoSocial.Text = string.Empty;
            txtCnpj.Text = null;
            txtIE.Text = string.Empty;
            txtObservacoesFornecedor.Text = string.Empty;
            dgvTelefones.DataSource = null;
            dgvTelefones.Rows.Clear();
            LimpaEmail();
            LimpaEndereco();
            txtFornecedor.Focus();
        }
        private void LimpaEmail()
        {
            chkHabilitaEmail.Checked = false;
            _idEmail = 0;
            txtEmail.Text = string.Empty;
            txtObservacoesEmail.Text = string.Empty;
        }
        private void LimpaEndereco()
        {
            chkHabilitaEndereco.Checked = false;
            _idEndereco = 0;
            txtCep.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtUf.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtObservacoesEndereco.Text = string.Empty;
        }

        private void dgvTelefones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se clicou na coluna de excluir
            if (dgvTelefones.Columns[e.ColumnIndex].Name == "colExcluir" && e.RowIndex >= 0)
            {
                // Opcional: confirmação
                var result = new AlertBox(Color.Goldenrod, Color.LimeGreen, Color.Yellow, Resources.Warning, "Aviso de Exclusão", string.Empty, "Deseja realmente excluir o telefone?", true).ShowDialog();
                if (result == DialogResult.Yes)
                {
                    // Remove a linha
                    dgvTelefones.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void chkHabilitaEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHabilitaEmail.Checked)
            {
                HabilitaEmail(true);
            }
            else
            {
                HabilitaEmail();
                LimpaEmail();
            }
        }
        private void HabilitaEmail(bool habilita = false)
        {
            txtEmail.Enabled = habilita;
            txtObservacoesEmail.Enabled = habilita;
        }
        private void HabilitaEndereco(bool habilita = false)
        {
            txtCep.Enabled = habilita;
            txtLogradouro.Enabled = habilita;
            txtNumero.Enabled = habilita;
            txtBairro.Enabled = habilita;
            txtCidade.Enabled = habilita;
            txtUf.Enabled = habilita;
            txtComplemento.Enabled = habilita;
            txtObservacoesEndereco.Enabled = habilita;
        }

        private void chkHabilitaEndereco_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHabilitaEndereco.Checked)
            {
                HabilitaEndereco(true);
            }
            else
            {
                HabilitaEndereco();
                LimpaEndereco();
            }
        }
        private bool ValidaCampos()
        {
            // Nome obrigatório
            if (string.IsNullOrWhiteSpace(txtFornecedor.Text))
            {
                new AlertBox(Color.Goldenrod, Color.LimeGreen, Color.Yellow, Resources.Warning, "Entidade: Fornecedor", string.Empty, "Nome do fornecedor é obrigatório", false).ShowDialog();
                txtFornecedor.Focus();
                return false;
            }

            // Validação do e-mail, se habilitado
            if (chkHabilitaEmail.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    !System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    new AlertBox(Color.Goldenrod, Color.LimeGreen, Color.Yellow, Resources.Warning, "Entidade: Fornecedor/e-mail", string.Empty, "Informe um e-mail válido", false).ShowDialog();
                    txtEmail.Focus();
                    return false;
                }
            }

            // Validação do endereço, se habilitado
            if (chkHabilitaEndereco.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtLogradouro.Text)
                    || string.IsNullOrWhiteSpace(txtBairro.Text)
                    || string.IsNullOrWhiteSpace(txtCidade.Text)
                    || string.IsNullOrWhiteSpace(txtUf.Text))
                {
                    new AlertBox(Color.Goldenrod, Color.LimeGreen, Color.Yellow, Resources.Warning, "Entidade: Fornecedor/Endereço", string.Empty, "O endereço é obrigatório!", false).ShowDialog();
                    txtLogradouro.Focus();
                    return false;
                }
            }

            return true;
        }
        private void CarregaDados()
        {
            try
            {
                dgvTelefones.Rows.Clear();
                var fornecedorDados = _serviceFornecedor.BuscaCompleta(_idFornecedor).FirstOrDefault();
                if (fornecedorDados == null)
                    return;

                // Preenche os campos do fornecedor
                _idFornecedor = fornecedorDados.Id;
                txtFornecedor.Text = fornecedorDados.Nome;
                txtRazaoSocial.Text = fornecedorDados.RazaoSocial;
                txtIE.Text = fornecedorDados.IE;
                txtCnpj.Text = fornecedorDados.Cnpj;
                txtObservacoesFornecedor.Text = fornecedorDados.Observacoes;
                swAtivo.Checked = fornecedorDados.Ativo;

                // Preenche o endereço se existir
                if (fornecedorDados.Endereco != null)
                {
                    chkHabilitaEndereco.Checked = true;
                    _idEndereco = fornecedorDados.Endereco.Id == null ? 0 : (int)fornecedorDados.Endereco.Id;
                    txtCep.Text = fornecedorDados.Endereco.Cep;
                    txtLogradouro.Text = fornecedorDados.Endereco.Logradouro;
                    txtNumero.Text = fornecedorDados.Endereco.Numero;
                    txtBairro.Text = fornecedorDados.Endereco.Bairro;
                    txtCidade.Text = fornecedorDados.Endereco.Cidade;
                    txtUf.Text = fornecedorDados.Endereco.Uf;
                    txtComplemento.Text = fornecedorDados.Endereco.Complemento;
                    txtObservacoesEndereco.Text = fornecedorDados.Endereco.Observacoes;
                }
                else
                {
                    LimpaEndereco();
                }

                // Preenche o email se existir
                if (fornecedorDados.Email != null)
                {
                    _idEmail = fornecedorDados.Email.Id == null ? 0 : (int)fornecedorDados.Email.Id;
                    chkHabilitaEmail.Checked = true;
                    txtEmail.Text = fornecedorDados.Email.Descricao;
                    txtObservacoesEmail.Text = fornecedorDados.Email.Observacoes;
                }
                else
                {
                    LimpaEmail();
                }
                
                
                if (fornecedorDados.Telefones != null && fornecedorDados.Telefones.Count > 0)
                {
                    foreach (var tel in fornecedorDados.Telefones)
                    {
                        PreencheGridTelefone(tel.Id, tel.Whatsapp, tel.Descricao, tel.Observacoes);
                    }
                }
            }
            catch(Exception ex)
            {
                EmailError.EnviarEmailErro(ex.ToString());
                new AlertBox(Color.FromArgb(64, 0, 0), Color.Red, Color.Crimson, Resources.Error, "Um erro ocorreu:", "Entidade: Fornecedor", "Erro ao carregar fornecedor!", false).ShowDialog();
            }
        }
  
        private void btnAddTelefone_Click(object sender, EventArgs e)
        {
            bool whatsapp = chkWhatsapp.Checked;
            string observacoes = txtObservacoesTelefone.Text;

            // Remove tudo que não é número
            string telefoneNumerico = txtTelefone.Text.Trim();//new string(txtTelefone.Text.Trim().Where(char.IsDigit).ToArray());

            // Validação simples por quantidade de caracteres
            if (telefoneNumerico.Length < 14 || telefoneNumerico.Length > 15)
            {
                new AlertBox(Color.Goldenrod, Color.LimeGreen, Color.Yellow, Resources.Warning, "Entidade: Fornecedor/Telefone", string.Empty, "Informe um telefone válido!", false).ShowDialog();
                txtTelefone.Focus();
                return;
            }


            PreencheGridTelefone(0, whatsapp, telefoneNumerico, observacoes);

            // Limpa campos para próxima entrada
            txtTelefone.Clear();
            chkWhatsapp.Checked = false;
            txtObservacoesTelefone.Clear();
            txtTelefone.Focus();
        }
        private void PreencheGridTelefone(int id, bool whatsapp, string telefone, string observacoes)
        {
            // Evita que apareça o "X" quando não houver imagem
            dgvTelefones.Columns["colWhatsApp"].DefaultCellStyle.NullValue = null;
            dgvTelefones.RowTemplate.Height = 30;

                // Adiciona uma nova linha ao DataGridView
                dgvTelefones.Rows.Add(
                        id,                          // colIdTelefone = 0 (novo registro)
                        whatsapp == true ? Resources.whatsapp : null, // colWhatsapp
                        telefone,                   // colTelefone
                        observacoes,                // colObservacoes
                        Resources.remove
                    );
        }
        private void MudaCorPainel(Color cor1, Color cor2)
        {
            pn1.Color1 = cor1;
            pn1.Color2 = cor2;
            pn2.Color1 = cor1;
            pn2.Color2 = cor2;
            pn3.Color1 = cor1;
            pn3.Color2 = cor2;
            pn4.Color1 = cor1;
            pn4.Color2 = cor2;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Chama a validação antes de montar o objeto
                if (!ValidaCampos())
                {
                    MudaCorPainel(Color.Red, Color.Crimson);
                    return;
                }
                // Monta o objeto fornecedor com os dados do form
                var fornecedor = new Fornecedores
                {
                    Id = _idFornecedor,
                    Nome = txtFornecedor.Text,
                    RazaoSocial = txtRazaoSocial.Text,
                    IE = txtIE.Text.Trim(),
                    Cnpj = txtCnpj.Text.Trim(),
                    Observacoes = txtObservacoesFornecedor.Text,
                    Ativo = _ativo,
                     Endereco = chkHabilitaEndereco.Checked ? new Endereco
                     {
                         Id = _idEndereco,
                         Cep = txtCep.Text.Trim(),
                         Logradouro = txtLogradouro.Text,
                         Numero = txtNumero.Text.Trim(),
                         Bairro = txtBairro.Text,
                         Cidade = txtCidade.Text,
                         Uf = txtUf.Text.Trim(),
                         Complemento = txtComplemento.Text,
                         Observacoes = txtObservacoesEndereco.Text
                     } : null,
                    Email = chkHabilitaEmail.Checked ? new Email
                    {
                        Id = _idEmail,
                        Descricao = txtEmail.Text.Trim(),
                        Observacoes = txtObservacoesEmail.Text.Trim()
                    } : null,
                    Telefones = dgvTelefones.Rows.Cast<DataGridViewRow>()
    .Where(r => !r.IsNewRow)
    .Select(r =>
    {
        var cellId = r.Cells["colIdTelefone"].Value;
        var cellTelefone = r.Cells["colTelefone"].Value;
        var cellObs = r.Cells["colObservacoes"].Value;
        var cellWhatsapp = r.Cells["colWhatsapp"].Value;

        return new Telefone
        {
            Id = cellId == null || cellId == DBNull.Value ? 0 : Convert.ToInt32(cellId),
            Descricao = cellTelefone?.ToString() ?? string.Empty,
            // se houver imagem de WhatsApp, considera true
            Whatsapp = cellWhatsapp != null && cellWhatsapp is Bitmap,
            Observacoes = cellObs?.ToString() ?? string.Empty
        };
    }).ToList() };

                 int? retorno = _serviceFornecedor.SalvaFornecedor(fornecedor);
                 
                 if (retorno > 0)
                     new AlertBox(Color.FromArgb(0, 60, 4), Color.LimeGreen, Color.Green, Resources.Confirm, "Fornecedor", fornecedor.Nome.ToString(), "Foi cadastrado com sucesso!", false).ShowDialog();
                 else if (retorno == 0)
                    new AlertBox(Color.FromArgb(0, 60, 4), Color.LimeGreen, Color.Green, Resources.Confirm, "Fornecedor", fornecedor.Nome.ToString(), "Foi alterado com sucesso!", false).ShowDialog();
                else if (retorno == -1)
                    new AlertBox(Color.FromArgb(0, 60, 4), Color.LimeGreen, Color.Green, Resources.Confirm, "Fornecedor", fornecedor.Nome.ToString(), "Foi inativado!", false).ShowDialog();
                else
                    new AlertBox(Color.FromArgb(64, 0, 0), Color.Red, Color.Crimson, Resources.Error, "Um erro ocorreu:", "Entidade: Fornecedor", "Se o erro persistir chame o suporte!", false).ShowDialog();

                LimpaCampos();
            }
            catch (Exception ex)
            {
                EmailError.EnviarEmailErro(ex.ToString());
                new AlertBox(Color.FromArgb(64, 0, 0), Color.Red, Color.Crimson, Resources.Error, "Um erro ocorreu:", "Entidade: Fornecedor", "Erro ao salvar fornecedor!", false).ShowDialog();
            }
        }

        private void swAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if(swAtivo.Checked == true)
            {
                _ativo = true;
                pcAtivo.Visible = true;
                if (_idFornecedor > 0)
                    MudaCorPainel(Color.LimeGreen, Color.Yellow);
                
                else
                    MudaCorPainel(Color.SpringGreen, Color.Cyan);
            }
            else
            {
                _ativo = false;
                pcAtivo.Visible = false;
                MudaCorPainel(Color.Gray, Color.DarkGray);
            }
        }
    }
}
