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
    public class ServiceCliente
    {
        private readonly Database_Cliente _database = new Database_Cliente();

        public int? SalvaFornecedor(Cliente cliente)
        {
            try
            {
                if (cliente.Id == 0)
                    return _database.InsereFornecedor(cliente);
                else
                {
                    if (cliente.Ativo == true)
                    {
                        _database.AlteraFornecedor(cliente);
                        return 0;
                    }
                    else
                    {
                        _database.InativaFornecedor(cliente.Id);
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

        public List<Cliente> BuscaLimitada(Cliente cliente, int registros)
        {
            try
            {
                return _database.BuscaLimitada(cliente, registros);
            }
            catch (Exception ex)
            {
                EmailError.EnviarEmailErro(ex.ToString());
                return null;
            }
        }
        public List<Cliente> BuscaCompleta(int id)
        {
            try
            {
                return _database.BuscaCompleta(id);
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
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inativar o erro é: \n" + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
