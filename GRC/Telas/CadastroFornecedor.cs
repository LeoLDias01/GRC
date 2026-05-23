using Business.API;
using Business.EmailSender;
using Business.Helper;
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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRC.Telas
{
    public partial class CadastroFornecedor : Form
    {
        #region ..:: Instâncias e Variáveis ::..

        // Serviços utilizados para chamadas de API externa e banco de dados
        private readonly Viacep _viaCep = new Viacep();
        private ServiceFornecedor _serviceFornecedor = new ServiceFornecedor();

        // Variáveis globais de controle para edição/inserção de dados
        private int _idFornecedor;
        private int _idEmail;
        private int _idEndereco;
        private bool _ativo;

        #endregion

        #region ..:: Importação de APIs do Windows (Estética e Movimentação) ::..

        // Importa a função nativa do Windows responsável por criar regiões arredondadas no formulário
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coord do canto superior esquerdo
            int nTopRect,      // y-coord do canto superior esquerdo
            int nRightRect,    // x-coord do canto inferior direito
            int nBottomRect,   // y-coord do canto inferior direito
            int nWidthEllipse, // largura da elipse (quanto maior, mais arredondado)
            int nHeightEllipse // altura da elipse (quanto maior, mais arredondado)
        );

        // Importa as funções nativas para permitir o arrasto da tela sem usar a barra de título padrão
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Constantes numéricas exigidas pela API do Windows para capturar o movimento do mouse
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        #endregion

        #region ..:: Construtor e Eventos de Inicialização ::..

        /// <summary>
        /// Construtor principal da tela. Recebe um ID (0 para novo, maior que 0 para edição).
        /// </summary>
        public CadastroFornecedor(int idFornecedor = 0)
        {
            InitializeComponent();

            // Inicializa as variáveis de controle com os IDs correspondentes
            _idFornecedor = idFornecedor;
            _idEmail = 0;
            _idEndereco = 0;

            // Aplica os cantos arredondados na janela do formulário (raio de 30px)
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        /// <summary>
        /// Evento disparado quando a tela termina de carregar.
        /// </summary>
        private void CadastroFornecedor_Load(object sender, EventArgs e)
        {
            // Define o fornecedor como ativo por padrão
            swAtivo.Checked = true;

            // Se foi passado um ID na abertura da tela, busca os dados no banco
            if (_idFornecedor > 0)
                CarregaDados();

            // Coloca o cursor piscando no primeiro campo
            txtFornecedor.Focus();
        }

        #endregion

        #region ..:: Carregamento de Dados ::..

        /// <summary>
        /// Busca as informações do fornecedor no banco de dados e preenche os componentes da tela.
        /// </summary>
        private void CarregaDados()
        {
            try
            {
                // Limpa o grid antes de carregar para evitar duplicidades
                dgvTelefones.Rows.Clear();

                // Busca o objeto completo do fornecedor no serviço
                var fornecedorDados = _serviceFornecedor.BuscaCompleta(_idFornecedor).FirstOrDefault();
                if (fornecedorDados == null)
                    return;

                // Preenche os dados cadastrais básicos
                _idFornecedor = fornecedorDados.Id;
                txtFornecedor.Text = fornecedorDados.Nome;
                txtRazaoSocial.Text = fornecedorDados.RazaoSocial;
                txtIE.Text = fornecedorDados.IE;
                // Chama o helper para aplicar a máscara visual caso o dado venha "limpo" do banco
                txtCnpj.Text = Identidade.FormataIdentidade(fornecedorDados.Cnpj);
                txtObservacoesFornecedor.Text = fornecedorDados.Observacoes;
                swAtivo.Checked = (bool)fornecedorDados.Ativo;

                // Verifica se o fornecedor possui um endereço vinculado e o preenche
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

                // Verifica se o fornecedor possui um email vinculado e o preenche
                if (fornecedorDados.Email != null)
                {
                    _idEmail = fornecedorDados.Email.Id == null ? 0 : (int)fornecedorDados.Email.Id;
                    chkHabilitaEmail.Checked = true;
                    txtEmail.Text = fornecedorDados.Email.Descricao;
                }
                else
                {
                    LimpaEmail();
                }

                // Percorre a lista de telefones do fornecedor e adiciona no Grid
                if (fornecedorDados.Telefones != null && fornecedorDados.Telefones.Count > 0)
                {
                    foreach (var tel in fornecedorDados.Telefones)
                    {
                        PreencheGridTelefone(tel.Id, tel.Whatsapp, tel.Descricao);
                    }
                }
            }
            catch (Exception ex)
            {
                // Em caso de erro, notifica o desenvolvedor e exibe mensagem amigável ao usuário
                EmailError.EnviarEmailErro(ex.ToString());
                new AlertBox(Color.FromArgb(64, 0, 0), Color.Red, Color.Crimson, Resources.Error, "Um erro ocorreu:", "Entidade: Fornecedor", "Erro ao carregar fornecedor!", false).ShowDialog();
            }
        }

        #endregion

        #region ..:: Salvamento de Dados ::..

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        /// <summary>
        /// Reúne os dados da tela, monta a entidade Fornecedor e envia para salvar no banco.
        /// </summary>
        private void Salvar()
        {
            try
            {
                // 1. Valida se os campos obrigatórios foram preenchidos
                if (!ValidaCampos())
                {
                    MudaCorPainel(Color.Red, Color.Crimson);
                    return;
                }

                // 2. Monta o objeto Fornecedor principal
                var fornecedor = new Fornecedores
                {
                    Id = _idFornecedor,
                    Nome = txtFornecedor.Text,
                    RazaoSocial = txtRazaoSocial.Text,

                    // Chama o helper para remover a formatação antes de salvar no banco
                    IE = Identidade.RetiraFormatacao(txtIE.Text).Trim(),
                    Cnpj = Identidade.RetiraFormatacao(txtCnpj.Text).Trim(),

                    Observacoes = txtObservacoesFornecedor.Text,
                    Ativo = _ativo,

                    // Monta o objeto Endereço (somente se a checkbox estiver marcada)
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

                    // Monta o objeto Email (somente se a checkbox estiver marcada)
                    Email = chkHabilitaEmail.Checked ? new Email
                    {
                        Id = _idEmail,
                        Descricao = txtEmail.Text.Trim()
                    } : null,

                    // 3. Varre o GridView para montar a lista de Telefones
                    Telefones = dgvTelefones.Rows.Cast<DataGridViewRow>()
                    .Where(r => !r.IsNewRow) // Ignora a linha em branco padrão do fim do grid
                    .Select(r =>
                    {
                        var cellId = r.Cells["colIdTelefone"].Value;
                        var cellTelefone = r.Cells["colTelefone"].Value;
                        var cellWhatsapp = r.Cells["colWhatsapp"].Value;

                        return new Telefone
                        {
                            Id = cellId == null || cellId == DBNull.Value ? 0 : Convert.ToInt32(cellId),
                            Descricao = cellTelefone?.ToString() ?? string.Empty,
                            // Transforma a presença do ícone (Bitmap) em boolean (True/False)
                            Whatsapp = cellWhatsapp != null && cellWhatsapp is Bitmap
                        };
                    }).ToList()
                };

                // 4. Envia o objeto montado para o serviço salvar/atualizar
                int? retorno = _serviceFornecedor.SalvaFornecedor(fornecedor);

                // 5. Verifica o retorno numérico e exibe o alerta correto
                if (retorno > 0)
                    new AlertBox(Color.FromArgb(0, 60, 4), Color.LimeGreen, Color.Green, Resources.Confirm, "Fornecedor", fornecedor.Nome.ToString(), "Foi cadastrado com sucesso!", false).ShowDialog();
                else if (retorno == 0)
                    new AlertBox(Color.FromArgb(0, 60, 4), Color.LimeGreen, Color.Green, Resources.Confirm, "Fornecedor", fornecedor.Nome.ToString(), "Foi alterado com sucesso!", false).ShowDialog();
                else if (retorno == -1)
                    new AlertBox(Color.FromArgb(0, 60, 4), Color.LimeGreen, Color.Green, Resources.Confirm, "Fornecedor", fornecedor.Nome.ToString(), "Foi inativado!", false).ShowDialog();
                else
                    new AlertBox(Color.FromArgb(64, 0, 0), Color.Red, Color.Crimson, Resources.Error, "Um erro ocorreu:", "Entidade: Fornecedor", "Se o erro persistir chame o suporte!", false).ShowDialog();

                // 6. Limpa a tela após salvar com sucesso
                LimpaCampos();
            }
            catch (Exception ex)
            {
                EmailError.EnviarEmailErro(ex.ToString());
                new AlertBox(Color.FromArgb(64, 0, 0), Color.Red, Color.Crimson, Resources.Error, "Um erro ocorreu:", "Entidade: Fornecedor", "Erro ao salvar fornecedor!", false).ShowDialog();
            }
        }

        #endregion

        #region ..:: Métodos Auxiliares e Validações ::..

        /// <summary>
        /// Valida as regras de negócio antes de permitir o salvamento.
        /// </summary>
        private bool ValidaCampos()
        {
            // Valida se o Nome foi preenchido (obrigatório)
            if (string.IsNullOrWhiteSpace(txtFornecedor.Text))
            {
                new AlertBox(Color.Goldenrod, Color.LimeGreen, Color.Yellow, Resources.Warning, "Entidade: Fornecedor", string.Empty, "Nome do fornecedor é obrigatório", false).ShowDialog();
                txtFornecedor.Focus();
                return false;
            }

            // Valida o Email apenas se o checkbox estiver marcado, usando expressão regular (Regex)
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

            // Valida o Endereço verificando se rua, bairro, cidade e estado foram preenchidos
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

            // Se passar por todas as validações, retorna verdadeiro
            return true;
        }

        /// <summary>
        /// Reseta o formulário inteiro para o estado original (inclusão de novo registro).
        /// </summary>
        private void LimpaCampos()
        {
            _idFornecedor = 0;
            txtFornecedor.Text = string.Empty;
            txtRazaoSocial.Text = string.Empty;
            txtCnpj.Text = null;
            txtIE.Text = string.Empty;
            txtObservacoesFornecedor.Text = string.Empty;

            // Limpeza do Grid de Telefones
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

        private void HabilitaEmail(bool habilita = false)
        {
            txtEmail.Enabled = habilita;
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

        /// <summary>
        /// Troca o gradiente/cor de um painel visual da tela.
        /// </summary>
        private void MudaCorPainel(Color cor1, Color cor2)
        {
            pn1.Color1 = cor1;
            pn1.Color2 = cor2;
        }

        #endregion

        #region ..:: Formatações, Máscaras e Eventos de Input ::..

        /// <summary>
        /// Quando o usuário sai do campo CEP, aciona a API do ViaCEP para buscar os dados.
        /// </summary>
        private async void txtCep_Leave(object sender, EventArgs e)
        {
            // Limpa traços e pontos
            string cep = txtCep.Text.Trim().Replace("-", "").Replace(".", "");

            // Aborta se não tiver 8 dígitos exatos
            if (cep.Length != 8)
                return;

            try
            {
                // Busca o endereço de forma assíncrona para não travar a tela
                var endereco = await _viaCep.BuscarEnderecoAsync(cep);

                // Preenche os campos de logradouro
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

        /// <summary>
        /// Máscara dinâmica para o campo CEP (Adiciona o traço no formato 00000-000).
        /// </summary>
        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            string texto = txtCep.Text.Replace("-", "").Trim();

            if (texto.Length > 5)
                txtCep.Text = texto.Insert(5, "-");

            txtCep.SelectionStart = txtCep.Text.Length; // mantém o cursor no fim
        }

        /// <summary>
        /// Máscara dinâmica para o campo CNPJ (Formata enquanto digita: 00.000.000/0000-00).
        /// </summary>
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

        /// <summary>
        /// Máscara dinâmica para o campo Telefone (DDD + Número).
        /// </summary>
        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            string texto = new string(txtTelefone.Text.Where(char.IsDigit).ToArray());

            if (texto.Length > 11) // máximo 11 dígitos (DDD + 9 números)
                texto = texto.Substring(0, 11);

            // Cancela formatação se o campo for apagado
            if (texto.Length == 0)
                return;

            // Salva a posição do cursor para não pular enquanto formata
            int posicao = txtTelefone.SelectionStart;

            // Formata de acordo com a quantidade digitada
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

        #endregion

        #region ..:: Controle de Componentes (CheckBox / Switch) ::..

        private void chkHabilitaEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHabilitaEmail.Checked)
            {
                HabilitaEmail(true);
            }
            else
            {
                HabilitaEmail(); // Desabilita (false é padrão)
                LimpaEmail();    // Apaga caso o usuário tenha desistido de inserir
            }
        }

        private void chkHabilitaEndereco_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHabilitaEndereco.Checked)
            {
                HabilitaEndereco(true);
            }
            else
            {
                HabilitaEndereco(); // Desabilita (false é padrão)
                LimpaEndereco();    // Apaga o endereço digitado
            }
        }

        private void swAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (swAtivo.Checked == true)
            {
                _ativo = true;
                pcAtivo.Visible = true;

                // Retorno visual indicando situação (Verde para novo/ativo, ou variação dependendo da edição)
                if (_idFornecedor > 0)
                    MudaCorPainel(Color.LimeGreen, Color.Yellow);
                else
                    MudaCorPainel(Color.SpringGreen, Color.Cyan);
            }
            else
            {
                _ativo = false;
                pcAtivo.Visible = false;
                MudaCorPainel(Color.Gray, Color.DarkGray); // Cor acinzentada indicando que está Inativo
            }
        }

        #endregion

        #region ..:: Configuração e Ações do Grid de Telefones ::..

        /// <summary>
        /// Estiliza o DataGridView de telefones via código (cores, remoção de headers, responsividade).
        /// </summary>
        private void ConfigurarEstiloGridTelefones()
        {
            dgvTelefones.BackgroundColor = Color.FromArgb(244, 246, 249);
            dgvTelefones.BorderStyle = BorderStyle.None;
            dgvTelefones.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTelefones.GridColor = Color.FromArgb(235, 240, 245);

            dgvTelefones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTelefones.MultiSelect = false;
            dgvTelefones.RowHeadersVisible = false;
            dgvTelefones.AllowUserToResizeRows = false;
            dgvTelefones.AllowUserToAddRows = false;
            dgvTelefones.ColumnHeadersVisible = false;

            DataGridViewCellStyle estiloLinha = new DataGridViewCellStyle();
            estiloLinha.BackColor = Color.White;
            estiloLinha.ForeColor = Color.FromArgb(45, 52, 54);
            estiloLinha.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            estiloLinha.SelectionBackColor = Color.FromArgb(235, 243, 250);
            estiloLinha.SelectionForeColor = Color.FromArgb(45, 52, 54);
            estiloLinha.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvTelefones.DefaultCellStyle = estiloLinha;

            dgvTelefones.RowTemplate.Height = 38;

            if (dgvTelefones.Columns.Contains("colIdTelefone"))
                dgvTelefones.Columns["colIdTelefone"].Visible = false;

            if (dgvTelefones.Columns.Contains("colWhatsApp"))
            {
                dgvTelefones.Columns["colWhatsApp"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvTelefones.Columns["colWhatsApp"].Width = 45;
            }

            if (dgvTelefones.Columns.Contains("colTelefone"))
            {
                dgvTelefones.Columns["colTelefone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvTelefones.Columns["colTelefone"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);
            }

            if (dgvTelefones.Columns.Contains("colExcluir"))
            {
                DataGridViewCellStyle estiloExcluir = new DataGridViewCellStyle();
                estiloExcluir.ForeColor = Color.FromArgb(214, 48, 49);
                estiloExcluir.SelectionForeColor = Color.FromArgb(214, 48, 49);
                estiloExcluir.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                estiloExcluir.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvTelefones.Columns["colExcluir"].DefaultCellStyle = estiloExcluir;
                dgvTelefones.Columns["colExcluir"].Width = 80;
            }
        }

        /// <summary>
        /// Insere uma nova linha visual no DataGridView representando o telefone.
        /// </summary>
        private void PreencheGridTelefone(int id, bool whatsapp, string telefone)
        {
            ConfigurarEstiloGridTelefones();
            // Evita que apareça o clássico "X" (erro de imagem) quando a célula for nula
            dgvTelefones.Columns["colWhatsApp"].DefaultCellStyle.NullValue = null;
            dgvTelefones.RowTemplate.Height = 30;

            // Adiciona a linha enviando o Ícone do WhatsApp se for true
            dgvTelefones.Rows.Add(
                    id,                                          // colIdTelefone = 0 se for novo
                    whatsapp == true ? Resources.whatsapp : null,// colWhatsapp (imagem no Resources)
                    telefone,                                    // colTelefone
                    Resources.remove                             // colExcluir (provavelmente uma imagem/texto)
                );
        }

        /// <summary>
        /// Adiciona o telefone digitado na TextBox diretamente para o Grid.
        /// Disparado pelo clique de um ícone dentro do próprio TextBox.
        /// </summary>
        private void txtTelefone_TrailingIconClick(object sender, EventArgs e)
        {

            bool whatsapp = chkWhatsapp.Checked;

            // Remove os espaços do telefone (mantido original do seu código comentado abaixo)
            // string telefoneNumerico = new string(txtTelefone.Text.Trim().Where(char.IsDigit).ToArray());
            string telefoneNumerico = txtTelefone.Text.Trim();

            // Verifica se a quantidade de caracteres é o padrão de telefone formatado ex: (16) 99999-9999
            if (telefoneNumerico.Length < 14 || telefoneNumerico.Length > 15)
            {
                new AlertBox(Color.Goldenrod, Color.LimeGreen, Color.Yellow, Resources.Warning, "Entidade: Fornecedor/Telefone", string.Empty, "Informe um telefone válido!", false).ShowDialog();
                txtTelefone.Focus();
                return;
            }

            // Joga as informações na tabela (0 indica que é um registro novo e não veio do banco)
            PreencheGridTelefone(0, whatsapp, telefoneNumerico);

            // Limpa o campo de entrada e a checkbox para o próximo telefone
            txtTelefone.Clear();
            chkWhatsapp.Checked = false;
            txtTelefone.Focus();
        }

        /// <summary>
        /// Identifica o clique na célula de Excluir do grid.
        /// </summary>
        private void dgvTelefones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a coluna clicada foi a colExcluir e se não é o header (-1)
            if (dgvTelefones.Columns[e.ColumnIndex].Name == "colExcluir" && e.RowIndex >= 0)
            {
                // Pede confirmação visual antes de deletar a linha do componente
                var result = new AlertBox(Color.Goldenrod, Color.LimeGreen, Color.Yellow, Resources.Warning, "Aviso de Exclusão", string.Empty, "Deseja realmente excluir o telefone?", true).ShowDialog();
                if (result == DialogResult.Yes)
                {
                    dgvTelefones.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        /// <summary>
        /// Evento de duplo clique em uma linha do grid para abrir o WhatsApp Web/Desktop.
        /// </summary>
        private void dgvTelefones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Evita quebrar ao dar duplo clique no cabeçalho
            {
                try
                {
                    // Pega o número diretamente da célula da linha clicada
                    var telefone = dgvTelefones.Rows[e.RowIndex].Cells["colTelefone"].Value.ToString();

                    // Limpa a formatação deixando só números
                    telefone = new string(telefone.Where(char.IsDigit).ToArray());

                    // Adiciona o código do Brasil (55) caso falte para o link da API do WhatsApp funcionar
                    if (!telefone.StartsWith("55"))
                        telefone = "55" + telefone;

                    // Transforma o texto em um formato compatível para URLs (substitui espaços por %20, etc)
                    string mensagem = Uri.EscapeDataString("Olá, tudo bem? Gostaria de fazer um pedido...");

                    // Monta a URL oficial do WhatsApp
                    string url = $"https://wa.me/{telefone}?text={mensagem}";

                    // Dá a ordem pro Windows abrir o link (isso abre o navegador padrão ou o app do Whats)
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao abrir WhatsApp: " + ex.Message);
                }
            }
        }

        #endregion

        #region ..:: Atalhos de Teclado ::..

        /// <summary>
        /// Intercepta as teclas digitadas no nível do formulário para criar atalhos globais.
        /// </summary>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Atalho universal: Ctrl + S aciona a função de Salvar
            if (keyData == (Keys.Control | Keys.S))
            {
                Salvar();
                return true; // Retorna true para informar ao Windows que o comando já foi tratado (evita o Bip sonoro)
            }

            // Se não for o atalho configurado, deixa o Windows processar normalmente (permitir digitação)
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        #region ..:: Controle de Janelas e Arrasto da Tela ::..

        // Os botões que encerram (fecham) o Form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEncerrarJanelas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --- MÉTODOS DE ARRASTO ---
        // Como o formulário não tem as bordas padrão do Windows, usamos o clique do mouse em vários painéis 
        // para acionar a API do Windows que permite o "arrasto" da janela.

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // Libera o mouse do componente atual
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); // Informa ao Windows que a janela está sendo movida
            }
        }

        private void CadastroFornecedor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pnInterno_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pnExterno_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lbTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion
    }
}