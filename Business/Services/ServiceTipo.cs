using Data.Models;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business.Services
{
    public class ServiceTipo
    {
        private readonly Database_Tipo _database = new Database_Tipo();

        #region ..:: CATEGORIA DE ITEM DE ESTOQUE ::..
        public int SalvaCategoriaItem(Tipo tipo)
        {
            try
            {
                if (tipo.Id == 0)
                    return _database.SalvaCategoriaItem(tipo);
                else
                    return _database.AlteraCategoriaItem(tipo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar categoria: " + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public List<Tipo> BuscaCategoriaItem()
        {
            try
            {
                return _database.BuscaCategoriaItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar categoria: " + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public void InativaCategoriaItem(int id)
        {
            try
            {
                _database.InativaCategoriaItem(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inativar categoria: \n" + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region ..:: UNIDADE DE MEDIDA ::..
        public void SalvaUnidadeMedida(Tipo tipo)
        {
            try
            {
                _database.SalvaUnidadeMedida(tipo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar a unidade de medida: " + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<Tipo> BuscaUnidadeMedida()
        {
            try
            {
                return _database.BuscaUnidadeMedida();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar a unidade de medida: " + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public void InativaUnidadeMedida(int id)
        {
            try
            {
                _database.InativaUnidadeMedida(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inativar a unidade de medida: \n" + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region ..:: MARCA ::..
        public int SalvaFabricante(Tipo tipo)
        {
            try
            {
                if (tipo.Id == 0)
                    return _database.SalvaFabricante(tipo);
                else
                    return _database.AlteraFabricante(tipo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar fabricante: " + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public List<Tipo> BuscaFabricante()
        {
            try
            {
                return _database.BuscaFabricante();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar fabricante: " + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public void InativaFabricante(int id)
        {
            try
            {
                _database.InativaFabricante(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inativar fabricante: \n" + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
