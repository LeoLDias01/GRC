using Business.EmailSender;
using Business.Helper;
using Business.Services;
using Data.Models;
using GRC.Properties;
using MaterialSkin.Controls;
using Microsoft.Win32;
using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class Finalizadores : Form
    {
        // Constantes para a mensagem de movimento
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        // Importar as DLLs do Windows para mover o formulário
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        ServiceVenda _service = new ServiceVenda();


        // 1. Criar uma lista de tuplas para associar ID (int) à Imagem
        private List<(int Id, Image Logo)> listaLogos;
        private int imagemId = 0;

        private int _idFinalizador = 0;
        private Finalizador _dadosFinalizador = new Finalizador();
        private List<Finalizador> _listaFinalizadores = new List<Finalizador>();

        public Finalizadores()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Finalizadores_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // Libera o mouse para a operação
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); // Envia comando de mover
            }
        }

        private void Finalizadores_Load(object sender, EventArgs e)
        {
            CarregarLogos();
            CarregaCombos();
            CarregaDados();
        }

        private void CarregarLogos()
        {
            listaLogos = new List<(int, Image)>
            {
                (1, Resources.logoPix),
                (2, Resources.logoDinheiro),
                (3, Resources.logoCredito),
                (4, Resources.logoDebito),
            };

            // CORREÇÃO: Reseta o ID para o primeiro item sempre que recarregar a lista
            imagemId = 0;

            if (listaLogos.Count > 0)
            {
                pcbImagem.Image = listaLogos[0].Logo;
                _dadosFinalizador.IdImagem = listaLogos[0].Id; // Garante que o objeto tenha um ID inicial
                MudaTextoImagem(listaLogos[0].Id);
            }
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            if (listaLogos == null || listaLogos.Count == 0) return;

            // 3. Incrementa o índice
            imagemId++;

            // 4. Reinicia se chegar ao fim (cria o ciclo)
            if (imagemId >= listaLogos.Count)
            {
                imagemId = 0;
            }

            // 5. Atribui a nova imagem e o ID
            var logoSelecionada = listaLogos[imagemId];
            pcbImagem.Image = logoSelecionada.Logo;
            _dadosFinalizador.IdImagem = logoSelecionada.Id;
            MudaTextoImagem(logoSelecionada.Id);
        }
        private void MudaTextoImagem(int id)
        {
            switch (id)
            {
                case 1:
                    lbImg.Text = "Pix";
                    break;
                case 2:
                    lbImg.Text = "Dinheiro";
                    break;
                case 3:
                    lbImg.Text = "Crédito";
                    break;
                case 4:
                    lbImg.Text = "Débito";
                    break;
            }
        }

        private bool ValidacaoCampos()
        {
            if (_dadosFinalizador.IdImagem < 1)
                return false;
            else if (string.IsNullOrWhiteSpace(txtDescricao.Text))
                return false;
            else if ((int)cbCategoria.SelectedValue < 1)
                return false;
            else if (chkParcelamento.Checked == true && string.IsNullOrWhiteSpace(txtParcelas.Text))
                return false;

            else return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidacaoCampos())
                    return;


                _dadosFinalizador.Id = _idFinalizador;
                _dadosFinalizador.Descricao = txtDescricao.Text;
                _dadosFinalizador.Categoria = Convert.ToInt32(cbCategoria.SelectedValue);
                _dadosFinalizador.IdImagem = listaLogos[imagemId].Id;
                _dadosFinalizador.Parcelamento = chkParcelamento.Checked ? true : false;
                _dadosFinalizador.Parcelas = Convert.ToInt32(txtParcelas.Text);
                _dadosFinalizador.Ativo = swItemAtivo.Checked ? true : false;



                int? retorno = _service.SalvaFinalizador(_dadosFinalizador);
                // Chama a services sem identificar se é criação ou alteração pois o processo de validação é feito lá
                if (retorno > 0)
                    new AlertBox(Color.FromArgb(0, 60, 4), Color.LimeGreen, Color.Green, Resources.Confirm, "Item de Estoque", _dadosFinalizador.Descricao.ToString(), "Foi cadastrado com sucesso!", false).ShowDialog();
                else if (retorno == 0)
                    new AlertBox(Color.FromArgb(0, 60, 4), Color.LimeGreen, Color.Green, Resources.Confirm, "Item de Estoque", _dadosFinalizador.Descricao.ToString(), "Foi alterado com sucesso!", false).ShowDialog();
                else if (retorno == -1)
                    new AlertBox(Color.FromArgb(0, 60, 4), Color.LimeGreen, Color.Green, Resources.Confirm, "Item de Estoque", _dadosFinalizador.Descricao.ToString(), "Foi inativado com sucesso!", false).ShowDialog();

                LimpaCampos();
            }
            catch (Exception ex)
            {
                EmailError.EnviarEmailErro(ex.ToString());
                new AlertBox(Color.FromArgb(64, 0, 0), Color.Red, Color.Crimson, Resources.Error, "Um erro ocorreu:", "Entidade: Item de Estoque", "Erro ao salvar item!", false).ShowDialog();
            }


        }
        private void LimpaCampos()
        {
            _idFinalizador = 0;
            _dadosFinalizador = new Finalizador(); // CORREÇÃO: Instancie novo em vez de null para evitar erros
            _listaFinalizadores = new List<Finalizador>();

            txtParcelas.Clear();
            txtDescricao.Clear();
            chkParcelamento.Checked = false;
            swItemAtivo.Checked = true;

            CarregaCombos();
            CarregarLogos(); // Isso agora vai resetar o imagemId para 0 corretamente
            CarregaDados();
        }
        private void CarregaCombos()
        {
            PreencherCombo(cbCategoria, _service.BuscaCategoriasFinalizadores(), "Descricao", "Id");

        }
        private void PreencherCombo<T>(MaterialComboBox cb, List<T> lista, string display, string value)
        {
            // Cria dinamicamente o item "Selecione..."
            var itemSelecione = Activator.CreateInstance<T>();

            var propId = typeof(T).GetProperty(value);
            var propDesc = typeof(T).GetProperty(display);

            propId?.SetValue(itemSelecione, 0);
            propDesc?.SetValue(itemSelecione, "Selecione...");

            // Adiciona como primeiro item da lista
            lista.Insert(0, itemSelecione);

            // Configura o ComboBox
            cb.DisplayMember = display;
            cb.ValueMember = value;
            cb.DataSource = lista;
            cb.SelectedIndex = 0;
        }
        private void CarregaDados()
        {
            dgvFinalizadores.Visible = true;
            dgvFinalizadores.Rows.Clear();
            dgvFinalizadores.RowTemplate.Height = 50;
            dgvFinalizadores.AutoGenerateColumns = false;
            dgvFinalizadores.ColumnHeadersVisible = true;
            dgvFinalizadores.ColumnHeadersHeight = 50;
            dgvFinalizadores.DefaultCellStyle.ForeColor = Color.Black;

            _listaFinalizadores = new List<Finalizador>();
            _listaFinalizadores = _service.BuscaDadosFinalizador();


            if (_listaFinalizadores != null)
            {
                foreach (var fin in _listaFinalizadores)
                {
                    if (fin.Id > 0)
                    {
                        var logoEncontrada = listaLogos.FirstOrDefault(x => x.Id == fin.IdImagem).Logo;

                        dgvFinalizadores.Rows.Add(
                            RedimensionarImagem(logoEncontrada, 40, 40),      // A imagem vinda da tupla
                            fin.Descricao,
                            fin.DescricaoCategoria, // A descrição da categoria (vinda do JOIN com GRC_TIPO)
                            fin.Parcelamento == true ? "Sim" : "Não",
                            fin.Parcelamento == true ? fin.Parcelas.ToString() : "Á VISTA",
                            fin.Id
                        );
                    }
                }
            }
        }
        public Image RedimensionarImagem(Image imagem, int largura, int altura)
        {
            var novoBitmap = new Bitmap(largura, altura);
            using (var g = Graphics.FromImage(novoBitmap))
            {
                // Garante a qualidade da redução
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(imagem, 0, 0, largura, altura);
            }
            return novoBitmap;
        }

        private void chkParcelamento_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParcelamento.Checked)
            {
                txtParcelas.Enabled = true;
            }
            else
            {
                txtParcelas.Enabled = false;
                txtParcelas.Clear();
            }
        }

        private void swItemAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (swItemAtivo.Checked)
                pcAtivo.Visible = true;
            else pcAtivo.Visible = false;
        }

        private void txtParcelas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Só permite números e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
        private int? PegaId(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvFinalizadores.Rows[e.RowIndex];
                return Convert.ToInt32(row.Cells["colId"].Value);
            }
            return null;
        }

        private void dgvFinalizadores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int? id = PegaId(e);
            if (id.HasValue)
            {
                var finalizadorSelecionado = _listaFinalizadores.Find(x => x.Id == id);
                if (finalizadorSelecionado == null) return;

                _idFinalizador = finalizadorSelecionado.Id;
                _dadosFinalizador = finalizadorSelecionado; // Sincroniza o objeto de trabalho

                // Busca a logo na lista
                var logoEncontrada = listaLogos.FirstOrDefault(x => x.Id == finalizadorSelecionado.IdImagem);

                if (logoEncontrada.Logo != null)
                {
                    pcbImagem.Image = logoEncontrada.Logo;

                    // CORREÇÃO CRITICAL: Sincroniza o índice global 'imagemId' com a posição real na lista
                    // Isso evita que o botão "Trocar" ou "Salvar" usem a imagem errada
                    imagemId = listaLogos.FindIndex(x => x.Id == finalizadorSelecionado.IdImagem);

                    _dadosFinalizador.IdImagem = logoEncontrada.Id;
                    MudaTextoImagem(finalizadorSelecionado.IdImagem);
                }

                // Preenchimento dos campos de texto
                txtDescricao.Text = finalizadorSelecionado.Descricao;
                cbCategoria.SelectedValue = finalizadorSelecionado.Categoria;
                swItemAtivo.Checked = finalizadorSelecionado.Ativo;

                if (finalizadorSelecionado.Parcelamento)
                {
                    chkParcelamento.Checked = true;
                    txtParcelas.Text = finalizadorSelecionado.Parcelas.ToString();
                }
                else
                {
                    chkParcelamento.Checked = false;
                    txtParcelas.Clear();
                }
            }

        }
    }
}

