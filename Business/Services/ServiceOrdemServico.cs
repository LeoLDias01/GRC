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
    
    public class ServiceOrdemServico
    {
        private readonly Database_OrdemServico _database = new Database_OrdemServico();

        public List<Tipo> BuscaTipoServico()
        {
            try
            {
                return _database.BuscaTipoServico();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar tipo de serviço: " + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public List<Tipo> BuscaStatus()
        {
            try
            {
                return _database.BuscaStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar status: " + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }




    }
}
