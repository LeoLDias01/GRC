using Business.Helper;
using Business.Services;
using Data.Models;
using GRC.Properties;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace GRC.Telas
{
    public partial class PesquisaOS : Form
    {
        ServiceOrdemServico _service = new ServiceOrdemServico();
        private int _idCliente = 0;
        public PesquisaOS()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RealizaPesquisa();
        }

        private void btnAddOs_Click(object sender, EventArgs e)
        {
            new CadastroOS().ShowDialog();
        }

        private void PesquisaOS_Load(object sender, EventArgs e)
        {
            CarregaCombos();
        }
        private void CarregaCombos()
        {
            PreencherCombo(cbTipoServico, _service.BuscaTipoServico(), "Descricao", "Id");
            PreencherCombo(cbStatus, _service.BuscaStatus(), "Descricao", "Id");
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

        private void btnApagar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void cbxQtdRegistros_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbxQtdRegistros.Text))
            {
                if (Convert.ToInt32(cbxQtdRegistros.Text) > 100)
                    cbxQtdRegistros.Text = "100";
            }
            else cbxQtdRegistros.Text = "10";

            RealizaPesquisa();
        }

        private void cbxQtdRegistros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite dígitos e a tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignora o caractere digitado
            }
        }

        private void dgvOs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lbRegistros.Text = $"{dgvOs.Rows.Count} registros encontrados!";
        }
        private void RealizaPesquisa()
        {
            int status = cbStatus.SelectedValue != null ? Convert.ToInt32(cbStatus.SelectedValue) : 0;
            int tipo = cbTipoServico.SelectedValue != null ? Convert.ToInt32(cbTipoServico.SelectedValue) : 0;

            /// Monta o objeto com base na pesquisa
            var os = new OrdemServico
            {
                Id = string.IsNullOrWhiteSpace(txtId.Text) ? 0 : Convert.ToInt32(txtId.Text),
                DataEntrada = string.IsNullOrWhiteSpace(txtDataEntrada.Text) ? string.Empty : txtDataEntrada.Text,
                IdCliente = _idCliente > 0 ? _idCliente : 0,
                Status = status > 0 ? status : 0,
                TipoServico = tipo > 0 ? tipo : 0,
                Favorito = chkFavorito.Checked ? true : false
            };

            int registros = Convert.ToInt32(cbxQtdRegistros.Text);

            dgvOs.Visible = true;
            dgvOs.Rows.Clear();
            dgvOs.RowTemplate.Height = 75;
            dgvOs.AutoGenerateColumns = false;
            dgvOs.ColumnHeadersVisible = true;
            dgvOs.ColumnHeadersHeight = 40;
            var lista = _service.BuscaLimitada(os, registros);
            if (lista != null)
            {
                foreach (var dadosOrdem in lista)
                {
                    if (dadosOrdem.Id > 0)
                    {
                        dgvOs.Rows.Add(

                        dadosOrdem.Favorito == true ? Resources.star : Resources.starOff,
                        dadosOrdem.Id.ToString(),
                        dadosOrdem.NomeCliente,
                        dadosOrdem.DataEntrada,
                        dadosOrdem.DescricaoStatus.ToString(),
                        dadosOrdem.DescricaoTipo.ToString()
                        );
                    }
                }
            }

            lbRegistros.Text = $"{dgvOs.Rows.Count} registros encontrados!";
        }
        private void LimpaCampos()
        {
            _idCliente = 0;
            txtId.Clear();
            txtCliente.Clear();
            txtDataEntrada.Clear();
            CarregaCombos();
            chkFavorito.Checked = false;
            dgvOs.Rows.Clear();
            dgvOs.ColumnHeadersVisible = false;
            cbxQtdRegistros.Text = "10";
        }
        private int? PegaId(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvOs.Rows[e.RowIndex];
                return Convert.ToInt32(row.Cells["colId"].Value);
            }
            return null;
        }

        private void dgvOs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int? id = PegaId(e);
            if (id.HasValue)
            {
                new CadastroOS(id.Value).ShowDialog();
            }
        }

        private void txtDataEntrada_TextChanged(object sender, EventArgs e)
        {
            FormataData(txtDataEntrada);
        }
        private void FormataData(MaterialTextBox txt)
        {
            // Remove tudo que não é número
            string apenasNumeros = new string(txt.Text.Where(char.IsDigit).ToArray());

            if (apenasNumeros.Length > 8)
                apenasNumeros = apenasNumeros.Substring(0, 8);

            string formatado = "";

            if (apenasNumeros.Length <= 2)
            {
                formatado = apenasNumeros;
            }
            else if (apenasNumeros.Length <= 4)
            {
                formatado = apenasNumeros.Insert(2, "/");
            }
            else
            {
                formatado = apenasNumeros.Insert(2, "/").Insert(5, "/");
            }

            txt.Text = formatado;
            txt.SelectionStart = txt.Text.Length;
        }
    }
}
