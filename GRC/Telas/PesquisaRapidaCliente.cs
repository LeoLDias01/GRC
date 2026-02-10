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
    public partial class PesquisaRapidaCliente : Form
    {
        public Cliente _cliente = new Cliente();
        private ServiceCliente _service = new ServiceCliente();
        public PesquisaRapidaCliente()
        {
            InitializeComponent();
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            new CadastroCliente().ShowDialog();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
        private void LimpaCampos()
        {
            txtCliente.Clear();
            txtIdentidade.Clear();
            rbtPF.Checked = true;
            rbtPJ.Checked = false;
            dgvClientes.Rows.Clear();
            dgvClientes.ColumnHeadersVisible = false;
            dgvClientes.DataSource = null;
            cbxQtdRegistros.Text = "10";
        }

        private void cbxQtdRegistros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite dígitos e a tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignora o caractere digitado
            }
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RealizaPesquisa();
        }

        private void dgvClientes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lbRegistros.Text = $"{dgvClientes.Rows.Count} registros encontrados!";
        }
        private void RealizaPesquisa()
        {
            /// Monta o objeto com base na pesquisa
            var cliente = new Cliente
            {
                Nome = txtCliente.Text,
                TipoPessoa = rbtPF.Checked == true ? 1 : 2,
                Identidade = txtIdentidade.Text.Trim(),
                Ativo = true //Pegar sempre os clientes ativos nesse caso
            };
            int registros = Convert.ToInt32(cbxQtdRegistros.Text);

            dgvClientes.Visible = true;
            dgvClientes.Rows.Clear();
            dgvClientes.RowTemplate.Height = 30;
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.ColumnHeadersVisible = true;
            dgvClientes.ColumnHeadersHeight = 50;

            _cliente = _service.BuscaLimitada(cliente, registros);
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
                            estoque.Identidade
                        );
                    }
                }
            }

            lbRegistros.Text = $"{dgvClientes.Rows.Count} registros encontrados!";
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignora clique no cabeçalho
            if (e.RowIndex < 0)
                return;

            var linha = dgvClientes.Rows[e.RowIndex];

           _cliente.Id = Convert.ToInt32(linha.Cells["colIdCliente"].Value);
           _cliente.Nome = linha.Cells["colNome"].Value?.ToString();
           this.DialogResult = DialogResult.OK;
        }

        private void PesquisaRapidaCliente_Load(object sender, EventArgs e)
        {
            rbtPF.Checked = true;
        }

        private void txtIdentidade_TextChanged(object sender, EventArgs e)
        {
            if (rbtPF.Checked)
                FormatarCpf(txtIdentidade);
            else if (rbtPJ.Checked)
                FormatarCnpj(txtIdentidade);
        }
        private void FormatarCpf(MaterialTextBox txtCpf)
        {
            string texto = new string(txtCpf.Text.Where(char.IsDigit).ToArray());

            if (texto.Length <= 3)
                txtCpf.Text = texto;
            else if (texto.Length <= 6)
                txtCpf.Text = texto.Insert(3, ".");
            else if (texto.Length <= 9)
                txtCpf.Text = texto.Insert(3, ".").Insert(7, ".");
            else
                txtCpf.Text = texto.Insert(3, ".").Insert(7, ".").Insert(11, "-");

            txtCpf.SelectionStart = txtCpf.Text.Length;
        }
        private void FormatarCnpj(MaterialTextBox txtCnpj)
        {
            string texto = new string(txtCnpj.Text.Where(char.IsDigit).ToArray());

            if (texto.Length <= 2)
                txtCnpj.Text = texto;
            else if (texto.Length <= 5)
                txtCnpj.Text = texto.Insert(2, ".");
            else if (texto.Length <= 8)
                txtCnpj.Text = texto.Insert(2, ".").Insert(6, ".");
            else if (texto.Length <= 12)
                txtCnpj.Text = texto.Insert(2, ".").Insert(6, ".").Insert(10, "/");
            else
                txtCnpj.Text = texto.Insert(2, ".").Insert(6, ".").Insert(10, "/").Insert(15, "-");

            txtCnpj.SelectionStart = txtCnpj.Text.Length; // mantém o cursor no final
        }
    }
}
