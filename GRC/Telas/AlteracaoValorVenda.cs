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
    public partial class AlteracaoValorVenda : Form
    {
        private decimal _valorBase;
        private int _operacao;
        public AlteracaoValorVenda(decimal valorBase = 0, int op = 0)
        {
            InitializeComponent();
            _valorBase = valorBase;
            _operacao = op;
        }

        private void AlteracaoValorVenda_Load(object sender, EventArgs e)
        {
            chkValor.Checked = true;
            chkPercent.Checked = false;

            if (_operacao == 1)
            {
                lbTitulo.Text = "Desconto";
                txtValor.Hint = "Valor do Desconto";
                txtPorcentagem.Hint = "Porcentagem de Desconto";
            }
            else
            {
                lbTitulo.Text = "Acréscimo";
                txtValor.Hint = "Valor do Acréscimo";
                txtPorcentagem.Hint = "Porcentagem de Acréscimo";
            }


            if(_valorBase > 0)
            {
                lbBase.Text = _valorBase.ToString("C2", CultureInfo.CurrentCulture);
                txtValor.Enabled = true;
                txtPorcentagem.Enabled = true;
                chkValor.Enabled = true;
                chkPercent.Enabled = true;
            }
            else
            {
                lbBase.Text = " * Sem valor base *";
                txtValor.Enabled = true;
                txtPorcentagem.Enabled = false;
                chkValor.Enabled = true;
                chkPercent.Enabled = false;
            }


        }

        private void chkValor_CheckedChanged(object sender, EventArgs e)
        {
            VerificaItem();
        }

        private void chkPercent_CheckedChanged(object sender, EventArgs e)
        {
            VerificaItem();
        }
        private void VerificaItem()
        {
            if (chkValor.Checked == true)
            {
                txtValor.Enabled = true;
                chkPercent.Checked = false;
                txtPorcentagem.Enabled = false;

            }
            else
            {
                txtValor.Enabled = false;
                chkValor.Checked = false;
                txtPorcentagem.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;
        }
    }
}
