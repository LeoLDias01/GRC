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

namespace GRC.Telas
{
    public partial class ItemEstoque : Form
    {
        private ServiceItemEstoque _service = new ServiceItemEstoque();

        public ItemEstoque()
        {
            InitializeComponent();
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            new CadastroItem().ShowDialog();
        }

        private void ItemEstoque_Load(object sender, EventArgs e)
        {

            CarregaCombos();
            chkAtivo.Checked = true;
        }
        private void CarregaCombos()
        {
            PreencherCombo(cbCategoria, _service.BuscaCategoriaItem(), "Descricao", "Id");
            PreencherCombo(cbFabricante, _service.BuscaFabricante(), "Descricao", "Id");
            PreencherCombo(cbFornecedor, _service.BuscaFornecedor(), "Descricao", "Id");
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

        private void dgvItens_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lbRegistros.Text = $"{dgvItens.Rows.Count} registros encontrados!";
        }
        private void RealizaPesquisa()
        {
            int categoria = cbCategoria.SelectedValue != null ? Convert.ToInt32(cbCategoria.SelectedValue) : 0;
            int fabricante = cbFabricante.SelectedValue != null ? Convert.ToInt32(cbFabricante.SelectedValue) : 0;
            int fornecedor = cbFornecedor.SelectedValue != null ? Convert.ToInt32(cbFornecedor.SelectedValue) : 0;
            /// Monta o objeto com base na pesquisa
            var item = new Item
            {
                Id = string.IsNullOrWhiteSpace(txtCodigo.Text) ? 0 : Convert.ToInt32(txtCodigo.Text),
                CodBarras = string.IsNullOrWhiteSpace(txtCodigoBarras.Text) ? string.Empty : txtCodigoBarras.Text,
                Descricao = string.IsNullOrWhiteSpace(txtItem.Text) ? string.Empty : txtItem.Text,
                Categoria = categoria > 0 ? (int)cbCategoria.SelectedValue : 0,
                Fabricante = fabricante > 0 ? (int)cbFabricante.SelectedValue : 0,
                Fornecedor = fornecedor > 0 ? (int)cbFornecedor.SelectedValue : 0,
                ItemVenda = chkItemVenda.Checked ? true : false,
                Favorito = chkFavorito.Checked ? true : false,
                Ativo = chkAtivo.Checked ? true : false,


            };

            int registros = Convert.ToInt32(cbxQtdRegistros.Text);

            dgvItens.Visible = true;
            dgvItens.Rows.Clear();
            dgvItens.RowTemplate.Height = 75;
            dgvItens.AutoGenerateColumns = false;
            dgvItens.ColumnHeadersVisible = true;
            dgvItens.ColumnHeadersHeight = 40;
            var lista = _service.BuscaLimitada(item, registros);
            if (lista != null)
            {
                foreach (var estoque in lista)
                {
                    if (estoque.Id > 0)
                    {
                        dgvItens.Rows.Add(

                        estoque.Favorito == true ? Resources.star : Resources.starOff,
                        !string.IsNullOrWhiteSpace(estoque.FotoItem) ? new Bitmap(CriptoImagem.Base64ToImage(estoque.FotoItem), new Size(100, 100)) : null,
                        estoque.Id.ToString(),
                        estoque.Descricao,
                        estoque.CodBarras,
                        estoque.Quatidade.ToString(),
                        estoque.DescricaoCategoria,
                        estoque.DescricaoFabricante,
                        estoque.DescricaoFornecedor,
                        Convert.ToBoolean(estoque.ItemVenda),
                        Convert.ToBoolean(estoque.Ativo)
                        );
                    }
                }
            }

            lbRegistros.Text = $"{dgvItens.Rows.Count} registros encontrados!";
        }
        private void LimpaCampos()
        {
            txtCodigo.Clear();
            txtCodigoBarras.Clear();
            txtItem.Clear();
            CarregaCombos();
            chkAtivo.Checked = true;
            chkFavorito.Checked = false;
            chkItemVenda.Checked = false;
            dgvItens.Rows.Clear();
            dgvItens.ColumnHeadersVisible = false;
            cbxQtdRegistros.Text = "10";
        }
        private long? PegaId(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvItens.Rows[e.RowIndex];
                return Convert.ToInt32(row.Cells["colId"].Value);
            }
            return null;
        }

        private void dgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            long? id = PegaId(e);
            if (id.HasValue)
            {
                new CadastroItem(id.Value).ShowDialog();
            }
        }

        private void tbnSearch_Click(object sender, EventArgs e)
        {
            RealizaPesquisa();
        }
    }
}
