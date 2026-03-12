using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Data.Models;
using Domain.Conections;

namespace Domain.Repository
{
    public class Database_Venda
    {
        ConexaoSQlite _conn = new ConexaoSQlite();


        #region ..:: BUSCA DADOS ::..

        public List<Caixa> VerificaCaixa()
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                try
                {
                    var sql =  conn.Query($@"
                                                


                    ", 
                    new
                    {
                        
                    })
                    .Select(x => new Caixa
                    {
                    });

                    return sql.ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao buscar itens do database: " + ex.Message);
                }
            }
        }
        #endregion
    }
}

