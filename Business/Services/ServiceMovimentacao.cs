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
    public class ServiceMovimentacao
    {
        private readonly Database_MovimentoEstoque _database = new Database_MovimentoEstoque();
        public List<Tipo> BuscaTipoMovimentacao()
        {
            try
            {

                return _database.BuscaTipoMovimentacao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar categoria: " + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        #region ..:: SALVA ITEM NO ESTOQUE ::..


        public int? SalvaMovimentacao(Movimentacao movimento)
        {
            try
            {
                if (movimento.Id == 0)
                    return _database.CadastraMovimento(movimento);
                else
                {
                    if (movimento.Ativo == true)
                    {
                        _database.AlteraMovimento(movimento);
                        return 0;
                    }
                    else
                    {
                        _database.InativaMovimento(movimento);
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


        #region ..:: PESQUISAS ::..

        public List<Movimentacao> BuscaLimitada(Movimentacao mov, int registros, string dataInicial, string dataFinal)
        {
            try
            {
                return _database.BuscaLimitada(mov, registros, dataInicial, dataFinal);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar itens Método service: " + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public List<Movimentacao> BuscaCompleta(int id)
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
    }
}
