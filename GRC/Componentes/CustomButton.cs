using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRC.Componentes
{
    public partial class CustomButton : Button
    {
        #region ..:: Variáveis ::..

        private int _tamanhoBorda = 0;
        private int _tamanhoRadius = 0;
        private Color _corBorda = Color.MediumSlateBlue;

        #endregion ..:: Variáveis ::..

        #region ..:: Propriedades ::..

        [Category("Custom Properties")]
        public int TamanhoBorda
        {
            get { return _tamanhoBorda; }
            set
            {
                _tamanhoBorda = value;
                this.Invalidate();
            }
        }

        [Category("Custom Properties")]
        public int TamanhoRaio
        {
            get { return _tamanhoRadius; }
            set
            {
                _tamanhoRadius = value;
                this.Invalidate();
            }
        }

        [Category("Custom Properties")]
        public Color CorBorda
        {
            get { return _corBorda; }
            set
            {
                _corBorda = value;
                this.Invalidate();
            }
        }

        [Category("Custom Properties")]
        public Color CorBotao
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("Custom Properties")]
        public Color CorTextoBotao
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        #endregion 

        #region ..:: Construtor ::..

        public CustomButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.CornflowerBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }

        #endregion 

        #region ..:: Métodos ::..

        private void Button_Resize(object sender, EventArgs e)
        {
            if (_tamanhoRadius > this.Height)
                _tamanhoRadius = this.Height;
        }

        // Alterado de Rectangle para RectangleF para permitir cálculos decimais (floats)
        private GraphicsPath GetFigurePath(RectangleF retangulo, float raio)
        {
            GraphicsPath raphicsPath = new GraphicsPath();
            float tamanhoCurva = raio * 2F;
            raphicsPath.StartFigure();
            raphicsPath.AddArc(retangulo.X, retangulo.Y, tamanhoCurva, tamanhoCurva, 180, 90);
            raphicsPath.AddArc(retangulo.Right - tamanhoCurva, retangulo.Y, tamanhoCurva, tamanhoCurva, 270, 90);
            raphicsPath.AddArc(retangulo.Right - tamanhoCurva, retangulo.Bottom - tamanhoCurva, tamanhoCurva, tamanhoCurva, 0, 90);
            raphicsPath.AddArc(retangulo.X, retangulo.Bottom - tamanhoCurva, tamanhoCurva, tamanhoCurva, 90, 90);
            raphicsPath.CloseFigure();
            return raphicsPath;
        }

        protected override void OnPaint(PaintEventArgs pEvento)
        {
            base.OnPaint(pEvento);

            pEvento.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Retângulo externo do botão
            RectangleF superficieRetangulo = new RectangleF(0, 0, this.Width, this.Height);

            // O SEGREDO: Recuar exatamente a metade do tamanho da borda.
            // Isso garante que a caneta (que pinta pelo meio) encoste perfeitamente na borda externa.
            float ajusteBorda = _tamanhoBorda / 2f;
            RectangleF bordaRetangulo = new RectangleF(ajusteBorda, ajusteBorda, this.Width - _tamanhoBorda, this.Height - _tamanhoBorda);

            if (_tamanhoRadius > 2)
            {
                // Proteção matemática para a borda não ficar maior que o raio
                float raioBorda = _tamanhoRadius - ajusteBorda;
                if (raioBorda <= 0) raioBorda = 1F;

                using (GraphicsPath gpSuperficie = GetFigurePath(superficieRetangulo, _tamanhoRadius))
                using (GraphicsPath pBorda = GetFigurePath(bordaRetangulo, raioBorda))
                {
                    // Proteção de nulidade caso o Parent ainda não exista no Form Designer
                    Color corParent = this.Parent != null ? this.Parent.BackColor : Color.White;

                    using (Pen penSuperficie = new Pen(corParent, 2))
                    using (Pen penBorda = new Pen(_corBorda, _tamanhoBorda))
                    {
                        this.Region = new Region(gpSuperficie);

                        // Desenha uma falsa linha externa usando a cor de fundo do Form para "esconder" o pixelado do Region
                        pEvento.Graphics.DrawPath(penSuperficie, gpSuperficie);

                        // Desenha a borda de fato, agora sem vazar o BackColor!
                        if (_tamanhoBorda >= 1)
                            pEvento.Graphics.DrawPath(penBorda, pBorda);
                    }
                }
            }
            else
            {
                pEvento.Graphics.SmoothingMode = SmoothingMode.None;
                this.Region = new Region(this.ClientRectangle);

                if (_tamanhoBorda >= 1)
                {
                    using (Pen penBorda = new Pen(_corBorda, _tamanhoBorda))
                    {
                        penBorda.Alignment = PenAlignment.Inset;
                        pEvento.Graphics.DrawRectangle(penBorda, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (this.Parent != null)
            {
                this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
            }
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        #endregion 
    }
}