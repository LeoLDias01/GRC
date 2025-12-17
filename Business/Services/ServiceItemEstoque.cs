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
    public class ServiceItemEstoque
    {
        private readonly Database_ItemEstoque _database = new Database_ItemEstoque();

        #region ..:: COMBOS: CATEGORIA - FORNECEDOR - UNIDADE DE MEDIDA E MARCA ::..

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
        public List<Tipo> BuscaUnidadeMedida()
        {
            try
            {
                return _database.BuscaUnidadeMedida();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar unidade de medida: " + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public List<Tipo> BuscaFornecedor()
        {
            try
            {
                return _database.BuscaFornecedor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar fornecedor: " + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        #endregion

        #region ..:: SALVA ITEM NO ESTOQUE ::..

        
        public long? SalvaItem(Item item)
        {
            try
            {
                if (item.Id == 0)
                    return _database.InsereItem(item);
                else
                {
                    if (item.Ativo == true)
                    {
                        _database.AlteraItem(item);
                        return 0;
                    }
                    else
                    {
                        _database.InativaItem(item.Id);
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar fornecedor: " + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        #endregion

        #region ..:: COMPOSIÇÃO ::.. 

        public List<Composicao> BuscaItemParaComposicao(Item item, int registros)
        {
            try
            {
                return _database.BuscaItemParaComposicao(item, registros);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar fornecedor: " + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        #endregion

        #region ..:: PESQUISAS ::..

        public List<Item> BuscaLimitada(Item item, int registros)
        {
            try
            {
                return _database.BuscaLimitada(item, registros);
               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar itens Método service: " + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public List<Item> BuscaCompleta(long id) 
        {
            try
            {
                return _database.BuscaCompleta(id);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar: " + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        #endregion

        #region ..:: MOVIMENTAÇÃO ::..

        public List<Item> BuscaTelaPesquisaBasica(Item item, int registros)
        {
            try
            {
                return _database.BuscaTelaPesquisaBasica(item, registros);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar itens Método service: " + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public List<Item> BuscaTelaPesquisaCompleta(int id)
        {
            try
            {
                return _database.BuscaTelaPesquisaCompleta(id);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar itens Método service: " + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        #endregion
    }
}
