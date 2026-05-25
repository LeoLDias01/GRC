using Business.Services;
using GRC.Componentes;
using GRC.Telas;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRC.UserControls
{
    public partial class usrEstoque : UserControl
    {
        private ServiceItemEstoque _service = new ServiceItemEstoque();
        private SerialPort _serialPort;

        public usrEstoque()
        {
            InitializeComponent();

            // Registra os eventos dos novos componentes via código
            this.Load += usrEstoque_Load;
            btnApagar.Click += btnApagar_Click;
            cbRegistros.TextChanged += cbRegistros_TextChanged;
            cbRegistros.KeyPress += cbRegistros_KeyPress;
            dgvItens.CellValueChanged += dgvItens_CellValueChanged;
            dgvItens.CellDoubleClick += dgvItens_CellDoubleClick;
            btnNovoItem.Click += btnNovoItem_Click;
        }
        private void usrEstoque_Load(object sender, EventArgs e)
        {
            CarregaCombos();
            cbRegistros.Text = "10";
            _statusSelecionado = null; // Começa exibindo Todos
            AtualizarVisualFiltros();
            RealizaPesquisa();
        }
        private void CarregaCombos()
        {
            PreencherCombo(cbCategoria, _service.BuscaCategoriaItem(), "Descricao", "Id");
            PreencherCombo(cbMarca, _service.BuscaFabricante(), "Descricao", "Id");
        }
        private void PreencherCombo<T>(RoundedComboBox cb, List<T> lista, string display, string value)
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
        private void btnApagar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void cbxQtdRegistros_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbRegistros.Text))
            {
                if (Convert.ToInt32(cbRegistros.Text) > 100)
                    cbRegistros.Text = "100";
            }
            else
            {
                cbRegistros.Text = "10";
            }

            RealizaPesquisa();
        }

        private void cbxQtdRegistros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas dígitos e a tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvItens_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lbRegistros.Text = $"{dgvItens.Rows.Count} registros encontrados!";
        }
    }
}
