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

        #region ..:: SALVA OS ::..


        public int? SalvaOS(OrdemServico os)
        {
            try
            {
                if (os.Id == 0)
                    return _database.InsereOS(os);
                else
                {
                    
                        _database.AlteraOS(os);
                        return 0;
                    
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar OS: " + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        #endregion

        public List<OrdemServico> BuscaCompleta(int id)
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


    }
}
