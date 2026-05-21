using GRC.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRC.UserControls
{
    public partial class Sidebar : UserControl
    {
        public Sidebar()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            PopUpUsuario card = new PopUpUsuario();

            card.StartPosition = FormStartPosition.Manual;

            // define qual sidebar está ativa
            int sidebarWidth = tlpMenu.Visible ? tlpMenu.Width : tlpMenuRedux.Width;

            // colado na lateral direita da sidebar
            int x = this.Left + sidebarWidth;

            // alinhado ao topo da sidebar (ou centralizado, se quiser)
            int y = this.Top;

            card.Location = new Point(x, y);

            card.Show();

        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            ExpandirMenu(true);
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            ExpandirMenu(false);
        }

        private void ExpandirMenu(bool expandido)
        {
            tlpMenu.Visible = expandido;
            tlpMenuRedux.Visible = !expandido;

            this.Width = expandido ? tlpMenu.Width : tlpMenuRedux.Width;
        }
    }
}
