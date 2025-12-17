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
    public partial class CadastroCliente : Form
    {
        private int _idCliente;
        private int _idEmail;
        private int _idEndereco;
        public CadastroCliente(int id = 0)
        {
            InitializeComponent();
            _idCliente = id;
            _idEmail = 0;
            _idEndereco = 0;
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
        private void LimpaEmail()
        {
            _idEmail = 0;
            chkHabilitaEmail.Checked = false;
            txtEmail.Text = string.Empty;
            txtObservacoesEmail.Text = string.Empty;
        }
        private void HabilitaEmail(bool habilita = false)
        {
            txtEmail.Enabled = habilita;
            txtObservacoesEmail.Enabled = habilita;
        }

        private void chkHabilitaEndereco_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHabilitaEndereco.Checked)
            {
                //HabilitaEndereco(true);
            }
            else
            {
                //HabilitaEndereco();
                LimpaEndereco();
            }
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
    }
}
