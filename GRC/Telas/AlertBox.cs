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


            // Aplica os cantos arredondados (ajuste os dois últimos números para mudar o raio)
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
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
