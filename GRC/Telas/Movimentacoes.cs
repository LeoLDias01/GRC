using Business.Helper;
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
    public partial class Movimentacoes : Form
    {
        private int _IdMovimentacao = 0;
        private int _idItem = 0;
        ServiceMovimentacao _service = new ServiceMovimentacao();
        Item _dadosItem = new Item();
        public Movimentacoes()
        {
            InitializeComponent();
        }

        private void Movimentacoes_Load(object sender, EventArgs e)
        {
            PreencherCombo(cbTipoMovimento, _service.BuscaTipoMovimentacao(), "Descricao", "Id");
        }

        private void btnNovaMovimentacao_Click(object sender, EventArgs e)
        {
            new CadastroMovimentacao().ShowDialog();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {

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

        private void btnSelecaoItem_Click(object sender, EventArgs e)
        {
            using (var frm = new PesquisaItem())
            {
                frm.ShowDialog();

                if (frm._item != null && frm._item.Count > 0)
                {
                    foreach (var comp in frm._item)
                    {
                        _dadosItem.Id = comp.Id;
                        _dadosItem.Descricao = comp.Descricao;
                        _dadosItem.Quatidade = comp.Quatidade;
                        _dadosItem.CustoUnitario = comp.CustoUnitario;
                        _dadosItem.VendaUnitario = comp.VendaUnitario;
                        _dadosItem.ItemVenda = comp.ItemVenda;
                    }
                    txtItem.Text = _dadosItem.Descricao;
                    _idItem = Convert.ToInt32(_dadosItem.Id);

                }
            }
        }

        private void tbnSearch_Click(object sender, EventArgs e)
        {
            RealizaPesquisa();
        }

        private void dgvMov_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lbRegistros.Text = $"{dgvMov.Rows.Count} registros encontrados!";
        }
        private void RealizaPesquisa()
        {
            int categoria = cbTipoMovimento.SelectedValue != null ? Convert.ToInt32(cbTipoMovimento.SelectedValue) : 0;
            /// Monta o objeto com base na pesquisa
            var mov = new Movimentacao
            {
                IdTipoMovimentacao = categoria,
                IdItem = _idItem
            };

            int registros = Convert.ToInt32(cbxQtdRegistros.Text);

            dgvMov.Visible = true;
            dgvMov.Rows.Clear();
            dgvMov.RowTemplate.Height = 40;
            dgvMov.AutoGenerateColumns = false;
            dgvMov.ColumnHeadersVisible = true;
            dgvMov.ColumnHeadersHeight = 40;
            var lista = _service.BuscaLimitada(mov, registros, txtDataInicial.Text, txtDataFinal.Text);
            if (lista != null)
            {
                foreach (var movimento in lista)
                {
                    if (movimento.Id > 0)
                    {
                        dgvMov.Rows.Add(

                        movimento.DataMovimentacao,
                        movimento.Id.ToString(),
                        movimento.DescricaoItem,
                        movimento.DescricaoTipoMovimentacao,
                        movimento.Motivo.ToString()
                        );
                    }
                }
            }
     

            lbRegistros.Text = $"{dgvMov.Rows.Count} registros encontrados!";
        }
        private void LimpaCampos()
        {
            txtDataInicial.Clear();
            txtDataFinal.Clear();
            txtItem.Clear();
            _idItem = 0;
            _IdMovimentacao = 0;
            dgvMov.Rows.Clear();
            PreencherCombo(cbTipoMovimento, _service.BuscaTipoMovimentacao(), "Descricao", "Id");
            dgvMov.ColumnHeadersVisible = false;
            cbxQtdRegistros.Text = "10";
        }
        private int? PegaId(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvMov.Rows[e.RowIndex];
                return Convert.ToInt32(row.Cells["colId"].Value);
            }
            return null;
        }

        private void btnApagar_Click_1(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void dgvMov_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int? id = PegaId(e);
            if (id.HasValue)
            {
                new CadastroMovimentacao(id.Value).ShowDialog();
            }
        }
    }
}
