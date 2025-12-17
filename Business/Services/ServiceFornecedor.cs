using Business.EmailSender;
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
    public class ServiceFornecedor
    {
        private readonly Database_Fornecedor _database = new Database_Fornecedor();

        public int? SalvaFornecedor(Fornecedores fornecedor)
        {
            try
            {
                if (fornecedor.Id == 0)
                    return _database.InsereFornecedor(fornecedor);
                else
                {
                    if (fornecedor.Ativo == true)
                    {
                        _database.AlteraFornecedor(fornecedor);
                        return 0;
                    }
                    else
                    {
                        _database.InativaFornecedor(fornecedor.Id);
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                EmailError.EnviarEmailErro(ex.ToString());
                return null;
            }
        }

        public List<Fornecedores> BuscaLimitada(Fornecedores fornecedor, int registros)
        {
            try
            {
                    return _database.BuscaLimitada(fornecedor, registros);
            }
            catch (Exception ex)
            {
                EmailError.EnviarEmailErro(ex.ToString());
                return null;
            }
        }
        public List<Fornecedores> BuscaCompleta(int idFornecedor)
        {
            try
            {
                return _database.BuscaCompleta(idFornecedor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar fornecedor: " + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public void InativaFornecedor(int id)
        {
            try
            {
                _database.InativaFornecedor(id);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao inativar o erro é: \n" + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
