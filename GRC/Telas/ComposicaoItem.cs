using Business.Services;
using Data.Models;
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
    public partial class ComposicaoItem : Form
    {
        private ServiceItemEstoque _service = new ServiceItemEstoque();
        public List<Composicao> ItensSelecionados { get; private set; } = new List<Composicao>();
        public ComposicaoItem()
        {
            InitializeComponent();
        }

        private void ComposicaoItem_Load(object sender, EventArgs e)
        {
            dgvItem.AllowDrop = true;
            dgvItemComposicao.AllowDrop = true;
            CarregaCombos();
            CarregaGridComposicao();
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

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            RealizaPesquisa();
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            RealizaPesquisa();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
        private void LimpaCampos()
        {
            txtId.Clear();
            txtDescricao.Clear();
            CarregaCombos();
            dgvItem.DataSource = null;
            dgvItem.ColumnHeadersVisible = false;
            cbxQtdRegistros.Text = "10";
            lbRegistros.Text = $"{dgvItem.Rows.Count} registros!";
        }

        private void ConfiguraGrid(DataGridView grid)
        {
            grid.Visible = true;
            grid.DataSource = null;
            grid.RowTemplate.Height = 30;
            grid.AutoGenerateColumns = false;
            grid.ColumnHeadersVisible = true;
            grid.ColumnHeadersHeight = 50;
        }

        private void cbFornecedor_SelectedValueChanged(object sender, EventArgs e)
        {
            RealizaPesquisa();
        }

        private void cbFabricante_SelectedValueChanged(object sender, EventArgs e)
        {
            RealizaPesquisa();
        }

        private void cbCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            RealizaPesquisa();
        }
        private void RealizaPesquisa()
        {
            if (!string.IsNullOrWhiteSpace(txtId.Text)
                || !string.IsNullOrWhiteSpace(txtDescricao.Text)
                || Convert.ToInt32(cbCategoria.SelectedValue) > 0
                || Convert.ToInt32(cbFabricante.SelectedValue) > 0
                || Convert.ToInt32(cbFornecedor.SelectedValue) > 0)
            {

                /// Monta o objeto com base na pesquisa
                var item = new Item
                {
                    Id = string.IsNullOrWhiteSpace(txtId.Text) ? 0 : Convert.ToInt32(txtId.Text),
                    Descricao = txtDescricao.Text,
                    Categoria = Convert.ToInt32(cbCategoria.SelectedValue),
                    Fabricante = Convert.ToInt32(cbFabricante.SelectedValue),
                    Fornecedor = Convert.ToInt32(cbFornecedor.SelectedValue)
                };
                ConfiguraGrid(dgvItem);
                int registros = Convert.ToInt32(cbxQtdRegistros.Text);
                dgvItem.DataSource = _service.BuscaItemParaComposicao(item, registros);
                
            }
            else
            {
                LimpaCampos();
            }
            lbRegistros.Text = $"{dgvItem.Rows.Count} registros encontrados!";

        }

        private void dgvItemComposicao_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Composicao)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void dgvItemComposicao_DragDrop(object sender, DragEventArgs e)
        {
            var compOrigem = e.Data.GetData(typeof(Composicao)) as Composicao;
            if (compOrigem == null) return;

            var novo = new Composicao
            {
                Id = 0,
                IdItemComposicao = compOrigem.IdItemComposicao,
                Descricao = compOrigem.Descricao,
                Preco = compOrigem.Preco
            };

            // Evita duplicados
            if (!ItensSelecionados.Any(x => x.IdItemComposicao == novo.IdItemComposicao))
                ItensSelecionados.Add(novo);

            CarregaGridComposicao();

        }
        private void CarregaGridComposicao()
        {
            ConfiguraGrid(dgvItemComposicao);
            dgvItemComposicao.DataSource = ItensSelecionados;
        }

        private void dgvItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvItem.CurrentRow == null) return;

            var composicao = dgvItem.CurrentRow.DataBoundItem as Composicao;
            if (composicao == null) return;

            dgvItem.DoDragDrop(composicao, DragDropEffects.Copy);
        }

        private void dgvItemComposicao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvItemComposicao.Columns[e.ColumnIndex].Name == "colExcluir")
            {
                dgvItemComposicao.Rows.RemoveAt(e.RowIndex);
            }
            CarregaGridComposicao();
        }

        private void dgvItem_DragLeave(object sender, EventArgs e)
        {
           
        }
    }
}
