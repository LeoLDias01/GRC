using Business.Session;
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
    public partial class PopUpUsuario : Form
    {
        // Importa a função nativa do Windows responsável por criar regiões arredondadas
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
        public PopUpUsuario()
        {
            InitializeComponent();
            // Aplica os cantos arredondados (ajuste os dois últimos números para mudar o raio)
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void PopUpUsuario_Load(object sender, EventArgs e)
        {
            lbNome.Text = Sessao.UsuarioNome;
        }

        private void btnFecharJanela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            // fecha o card
            this.Hide();

            // pega o menu principal
            WorkFlow menu = (WorkFlow)Application.OpenForms["WorkFlow"];

            if (menu != null)
            {
                menu.Hide();

                Login login = new Login(1);

                if (login.ShowDialog() == DialogResult.OK)
                {
                    menu.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
            this.Close();
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
