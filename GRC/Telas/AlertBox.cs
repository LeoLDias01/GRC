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
    public partial class AlertBox : Form
    {
        Color _background;
        Color _pnColor1;
        Color _pnColor2;
        Image _img;
        string _grupo;
        string _item;
        string _mensagem;
        bool _yesNo;
        public AlertBox(Color background, Color pnColor1, Color pnColor2, Image img, string grupo, string item, string msg, bool yesNo)
        {
            InitializeComponent();
            _background = background;
            _pnColor1 = pnColor1;
            _pnColor2 = pnColor2;
            _img = img;
            _grupo = grupo;
            _item = item;
            _mensagem = msg;
            _yesNo = yesNo;
        }

        private void AlertBox_Load(object sender, EventArgs e)
        {
            this.BackColor = _background;
            pnStatus.Color1 = _pnColor1;
            pnStatus.Color2 = _pnColor2;
            pcImagem.Image = _img;
            lbGrupo.Text = _grupo;
            lbItem.Text = _item;
            lbMsg.Text = _mensagem;
            if(_yesNo == true)
            {
                btnOk.Visible = false;
                btnYes.Visible = true;
                btnNo.Visible = true;
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;
        }
    }
}
