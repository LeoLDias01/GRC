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
        public List<Caixa> VerificaCaixa()
        {
            try
            {
                return _database.VerificaCaixa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar tipo de serviço: " + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
