using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Services;

namespace GRC.Telas
{
    public partial class Login : Form
    {
        public int _identificador;
        ServiceLogin _service = new ServiceLogin();
        private string _usuario, _senha;
        public Login(int identificador = 0)
        {
            InitializeComponent();
            _identificador = identificador;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (_identificador == 0)
            {
                this.Visible = false;
                new Loading().ShowDialog();
                this.Visible = true;
            }
            txtUsuario.Text = "raynerb";
            txtSenha.Text = "1234";
        }
        private bool ValidaCampos()
        {
            if (string.IsNullOrWhiteSpace(_usuario) || string.IsNullOrWhiteSpace(_senha))
                return false;
            else return true;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            _usuario = txtUsuario.Text.Trim().ToLower();
            _senha = txtSenha.Text.Trim();
            if (ValidaCampos() == true)
            {
                if (_service.VerificaLogin(_usuario, _senha) != false)
                {
                    this.Close();
                }
                else
                {
                    lbAviso.Text = "Usuário ou Senha Inválidos";
                    lbAviso.ForeColor = Color.Crimson;
                    pnSuperior.BackColor = Color.Crimson;
                    pnBaixo.Color1 = Color.Crimson;
                    pnBaixo.Color2 = Color.Red;
                    MessageBox.Show("Usuário ou Senha inválidos!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Insira um Usuário ou Senha válidos!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
