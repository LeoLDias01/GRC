using Business.Services;
using Data.Models;
using GRC.Properties;
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
    public partial class PesquisaCliente : Form
    {
        private ServiceCliente _service = new ServiceCliente();
        public PesquisaCliente()
        {
            InitializeComponent();
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            new CadastroCliente().ShowDialog();
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

        private void dgvClientes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lbRegistros.Text = $"{dgvClientes.Rows.Count} registros encontrados!";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
        private void RealizaPesquisa()
        {
            /// Monta o objeto com base na pesquisa
            var cliente = new Cliente
            {
                Nome = txtCliente.Text,
                TipoPessoa = rbtPF.Checked == true ? 1 : 2,
                Identidade = txtIdentidade.Text.Trim(),
                Ativo = chkAtivo.Checked ? true : false,
                Endereco = new Endereco
                {
                    Cidade = txtCidade.Text,
                    Uf = txtUf.Text.Trim(),
                }
            };
            int registros = Convert.ToInt32(cbxQtdRegistros.Text);

            dgvClientes.Visible = true;
            dgvClientes.Rows.Clear();
            dgvClientes.RowTemplate.Height = 30;
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.ColumnHeadersVisible = true;
            dgvClientes.ColumnHeadersHeight = 50;

            var lista = _service.BuscaLimitada(cliente, registros);

            if (lista != null)
            {
                foreach (var estoque in lista)
                {
                    if (estoque.Id > 0)
                    {
                        dgvClientes.Rows.Add(
                            estoque.Id,
                            estoque.Nome,
                            estoque.TipoPessoa == 1 ? "Pessoa Física" : "Pessoa Jurídica",
                            estoque.Identidade,
                            estoque.Endereco.Cidade,
                            estoque.Endereco.Uf,
                            Resources.remove
                        );
                    }
                }
            }

            lbRegistros.Text = $"{dgvClientes.Rows.Count} registros encontrados!";
        }

        private void LimpaCampos()
        {
            txtCliente.Clear();
            txtIdentidade.Clear();
            rbtPF.Checked = true;
            rbtPJ.Checked = false;
            txtCidade.Clear();
            txtUf.Clear();
            chkAtivo.Checked = true;
            dgvClientes.Rows.Clear();
            dgvClientes.ColumnHeadersVisible = false;
            cbxQtdRegistros.Text = "10";
        }
        private int? PegaIdCliente(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvClientes.Rows[e.RowIndex];
                return Convert.ToInt32(row.Cells["colIdCliente"].Value);
            }
            return null;
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int? idCliente = PegaIdCliente(e);
            if (idCliente.HasValue)
            {
                new CadastroCliente(idCliente.Value).ShowDialog();
                RealizaPesquisa();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RealizaPesquisa();
        }

        private void PesquisaCliente_Load(object sender, EventArgs e)
        {
            chkAtivo.Checked = true;
            rbtPF.Checked = true;   
        }
    }
}
