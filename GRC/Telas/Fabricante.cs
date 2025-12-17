using Business.Services;
using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRC.Telas
{
    public partial class Fabricante : Form
    {
        private int _id = 0;
        ServiceTipo _services = new ServiceTipo();
        public Fabricante()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidaCampo())
                return;

            Tipo tipo = new Tipo();
            tipo.Id = _id;
            tipo.Descricao = txtDescricao.Text;
            _id = _services.SalvaFabricante(tipo);
            if (_id > 0)
                txtDescricao.Clear();
            CarregaDados();
        }
        private void CarregaDados()
        {
            dgvTipo.DataSource = null;
            dgvTipo.RowTemplate.Height = 30;
            dgvTipo.AutoGenerateColumns = false;
            dgvTipo.ColumnHeadersVisible = true;
            dgvTipo.ColumnHeadersHeight = 50;
            dgvTipo.DataSource = _services.BuscaFabricante();
            lbRegistros.Text = $"{dgvTipo.Rows.Count} cadastros!";
        }
        private bool ValidaCampo()
        {
            if (!string.IsNullOrWhiteSpace(txtDescricao.Text))
                return true;
            else return false;
        }
        private int? PegaIDFabricante(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvTipo.Rows[e.RowIndex];
                return Convert.ToInt32(row.Cells["colId"].Value);
            }
            return null;
        }

        private void dgvTipo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int? idFornecedor = PegaIDFabricante(e);
            if (idFornecedor.HasValue)
            {
                _id = idFornecedor.Value; // guarda para edição
                txtDescricao.Text = dgvTipo.Rows[e.RowIndex].Cells["colDescricao"].Value?.ToString();
            }
        }

        private void dgvTipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTipo.Columns[e.ColumnIndex].Name == "colExcluir")
            {
                int? id = PegaIDFabricante(e);
                if (id.HasValue)
                {
                    var result = MessageBox.Show("Deseja realmente inativar esta categoria?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        _services.InativaFabricante(id.Value);
                        CarregaDados();
                    }
                }
            }
        }

        private void Fabricante_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }
    }
}
