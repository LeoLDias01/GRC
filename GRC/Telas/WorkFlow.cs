using Business.EmailSender;
using Business.Helper;
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
    public partial class WorkFlow : Form
    {
        CriacaoBanco _inicializacao = new CriacaoBanco();
        public WorkFlow()
        {
            InitializeComponent();
        }

        private void WorkFlow_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            _inicializacao.VerificaBanco();
            new Login().ShowDialog();
            this.Visible = true;
            tdbMenuUsuario.Text = Sessao.UsuarioNome;
        }

        private void tsmEncerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    
        }

        private void tsmDesconectar_Click(object sender, EventArgs e)
        {
            int identificador = 1;
            this.Visible = false;
            new Login(identificador).ShowDialog();
            this.Visible = true;
        }

        private void tdbMenuUsuario_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void tdbMenuUsuario_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            new Fornecedor().ShowDialog();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            new ItemEstoque().ShowDialog();
        }

        private void btnOrdemServiço_Click(object sender, EventArgs e)
        {
            new CadastroOS().ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            new PesquisaCliente().ShowDialog();
        }

        private void btnMovimentacoes_Click(object sender, EventArgs e)
        {
            new Movimentacoes().ShowDialog();
        }
    }
}
