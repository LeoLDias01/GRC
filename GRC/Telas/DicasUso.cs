using iText.StyledXmlParser.Util;
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
    public partial class DicasUso : Form
    {
        private string _dicas;
        public DicasUso(string dicas)
        {
            InitializeComponent();
            _dicas = dicas;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DicasUso_Load(object sender, EventArgs e)
        {
            lbDicas.Text = _dicas;
        }
    }
}
