using Business.EmailSender;
using Business.Services;
using Business.Session;
using Data.Models;
using GRC.Properties;
using MaterialSkin.Controls;
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
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace GRC.Telas
{
    public partial class AberturaCaixa : Form
    {
        /// <summary>
        /// 1 - ABERTURA
        /// 2 - FECHAMENTO
        /// 3 - SANGRIA
        /// </summary>
        int _operacao;
        public Caixa _dadosCaixa = new Caixa();
        ServiceVenda _service =  new ServiceVenda();


        

        // Importar as DLLs do Windows para mover o formulário
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Constantes para a mensagem de movimento
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        public AberturaCaixa(int operacao = 0, int idCaixa = 0)
        {
            InitializeComponent();
            _operacao = operacao;
            _dadosCaixa.Id = idCaixa;
        }

   

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AberturaCaixa_Load(object sender, EventArgs e)
        {
            if (_operacao == 1)
            {
                tbcCaixa.SelectedTab = tbpAbertura;
                lbTitulo.Text = "Abertura de Caixa";
                _dadosCaixa.DataAbertura = DateTime.Now;
                lbData.Text = $"Data de Abertura: {_dadosCaixa.DataAbertura.ToString("dd/MM/yyyy - HH:mm")}";
                lbUser.Text = $"{Sessao.UsuarioNome}";
                _dadosCaixa.Id = 0; // ABERTURA NOVA
                _dadosCaixa.Usuario = Sessao.UsuarioId;
                _dadosCaixa.PDV = 1;
            }
            else if(_operacao == 2)
            {
                tbcCaixa.SelectedTab = tbpFechamento;
                lbTitulo.Text = "Fechamento de Caixa";
                _dadosCaixa.DataFechamento = DateTime.Now;
                lbDataFechamento.Text = $"Data de Fechamento: {_dadosCaixa.DataFechamento.ToString("dd/MM/yyyy - HH:mm")}";
                lbUsuarioFe.Text = $"{Sessao.UsuarioNome}";
                //_dadosCaixa.Id = 0; // ABERTURA NOVA
                _dadosCaixa.Usuario = Sessao.UsuarioId;
                _dadosCaixa.PDV = 1;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(_operacao == 1 && !string.IsNullOrWhiteSpace(txtSaldo.Text))
            {
                _dadosCaixa.SaldoAbertura = txtSaldo.Text;
                _dadosCaixa.Observacoes = txtObservacoes.Text;
               _dadosCaixa.Id = _service.AberturaCaixa(_dadosCaixa);

                if(_dadosCaixa.Id > 0)
                {
                    new AlertBox(Color.FromArgb(0, 60, 4), Color.LimeGreen, Color.Green, Resources.Confirm, "ABERTURA DE CAIXA", "A abertura do caixa de hoje foi realizada com sucesso", "Já pode iniciar suas vendas!", false).ShowDialog();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    new AlertBox(Color.FromArgb(64, 0, 0), Color.Red, Color.Crimson, Resources.Error, "Um erro ocorreu:", "Entidade: Abertura de Caixa", "Erro ao abrir o caixa de hoje!", false).ShowDialog();
                    this.DialogResult= DialogResult.Cancel;
                }
            }

            if (_operacao == 2 && !string.IsNullOrWhiteSpace(txtSaldoFe.Text))
            {
               // _dadosCaixa.Sald = txtSaldo.Text;
                _dadosCaixa.Observacoes = txtObservacoes.Text;
                _dadosCaixa.Id = _service.AberturaCaixa(_dadosCaixa);

                if (_dadosCaixa.Id > 0)
                {
                    new AlertBox(Color.FromArgb(0, 60, 4), Color.LimeGreen, Color.Green, Resources.Confirm, "ABERTURA DE CAIXA", "A abertura do caixa de hoje foi realizada com sucesso", "Já pode iniciar suas vendas!", false).ShowDialog();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    new AlertBox(Color.FromArgb(64, 0, 0), Color.Red, Color.Crimson, Resources.Error, "Um erro ocorreu:", "Entidade: Abertura de Caixa", "Erro ao abrir o caixa de hoje!", false).ShowDialog();
                    this.DialogResult = DialogResult.Cancel;
                }
            }

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

        private void txtSaldo_KeyDown(object sender, KeyEventArgs e)
        {
            VerificaKeyV(sender, e);
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            DesativaCaracteres(sender, e);
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

        private void txtSaldo_Enter(object sender, EventArgs e)
        {
            LimpaValorAoFocar("R$ 0,00", txtSaldo);
        }

        private void txtSaldo_Leave(object sender, EventArgs e)
        {
            ZeraValorAoDesfocar("R$ 0,00", txtSaldo);
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
        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {
            FormataMoeda(sender);
        }

        private void AberturaCaixa_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // Libera o mouse para a operação
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); // Envia comando de mover
            }
        }
    }
}
