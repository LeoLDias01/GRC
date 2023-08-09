using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_Manager.Screens
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void tsbNotepad_Click(object sender, EventArgs e)
        {
            new Notepad().ShowDialog();
        }

        private void ChangeMouseCursor(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }
    }
}
