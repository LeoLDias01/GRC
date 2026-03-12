using Business.Session;
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
    public partial class AberturaCaixa : Form
    {
        public AberturaCaixa()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AberturaCaixa_Load(object sender, EventArgs e)
        {
            lbData.Text = $"Data de Abertura: {DateTime.Now.ToString("dd/MM/yyyy - HH:mm")}";
            lbUser.Text = $"Usuário: {Sessao.UsuarioNome}";
        }
    }
}
