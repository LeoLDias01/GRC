using Business.Services;
using Data.Models;
using Microsoft.Win32;
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
    public partial class Categoria : Form
    {
        private int _id = 0;
        ServiceTipo _services = new ServiceTipo();

        public Categoria()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(!ValidaCampo())
                return;

            Tipo tipo = new Tipo();
            tipo.Id = _id;
            tipo.Descricao = txtCategoria.Text;
            _id = _services.SalvaCategoriaItem(tipo);
            if (_id > 0)
                txtCategoria.Clear();
            CarregaDados();
        }
        private void CarregaDados()
        {
            dgvTipo.DataSource = null;
            dgvTipo.RowTemplate.Height = 30;
            dgvTipo.AutoGenerateColumns = false;
            dgvTipo.ColumnHeadersVisible = true;
            dgvTipo.ColumnHeadersHeight = 50;
            dgvTipo.DataSource = _services.BuscaCategoriaItem();
            lbRegistros.Text = $"{dgvTipo.Rows.Count} cadastros!";
        }
        private bool ValidaCampo()
        {
            if (!string.IsNullOrWhiteSpace(txtCategoria.Text))
                return true;
            else return false;
        }
        private int? PegaIDCatedoria(DataGridViewCellEventArgs e)
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
            int? idFornecedor = PegaIDCatedoria(e);
            if (idFornecedor.HasValue)
            {
                _id = idFornecedor.Value; // guarda para edição
                txtCategoria.Text = dgvTipo.Rows[e.RowIndex].Cells["colDescricao"].Value?.ToString();
            }
        }

        private void dgvTipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTipo.Columns[e.ColumnIndex].Name == "colExcluir")
            {
                int? id = PegaIDCatedoria(e);
                if (id.HasValue)
                {
                    var result = MessageBox.Show("Deseja realmente inativar esta categoria?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        _services.InativaCategoriaItem(id.Value);
                        CarregaDados();
                    }
                }
            }
        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }
    }
}
