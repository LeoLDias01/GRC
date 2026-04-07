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
    public class ServiceVenda
    {
        private Database_Venda _database = new Database_Venda();

        #region ..:: Dados do Caixa ::..
        public List<Caixa> VerificaCaixa()
        {
            try
            {
                return _database.VerificaCaixa();
            }
            catch
            {
                return null;
            }
        }
        public int AberturaCaixa(Caixa caixa)
        {
            try
            {
                return _database.AberturaCaixa(caixa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir caixa: " + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        public List<Caixa> CarregaDadosCaixa(int id)
        {
            try
            {
                return _database.CarregaDadosCaixa(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir caixa: " + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
                
            }
        }
        #endregion

        #region ..:: ItensCaixa ::..

        public List<Tipo> BuscaGruposItens()
        {
            try
            {
                return _database.BuscaGruposItens();
            }
            catch
            {
                return null;
            }
        }

        #endregion
    }
}
