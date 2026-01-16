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
    public class Database_OrdemServico
    {
        ConexaoSQlite _conn = new ConexaoSQlite();

        #region ..:: COMBOS  ::..

        public List<Tipo> BuscaTipoServico()
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                return conn.Query($@"SELECT IDGRC_TIPO, DESCRICAO
                                     FROM GRC_TIPO 
                                     WHERE IDGRC_SUBTIPO = 6 
                                     AND ATIVO = 1 
                                     ORDER BY DESCRICAO ASC")
                .Select(x => new Tipo
                {
                    Id = (int)x.IDGRC_TIPO,
                    Descricao = x.DESCRICAO
                }).ToList();
            }
        }
        public List<Tipo> BuscaStatus()
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                return conn.Query($@"SELECT IDGRC_TIPO, DESCRICAO
                                     FROM GRC_TIPO 
                                     WHERE IDGRC_SUBTIPO = 7 
                                     AND ATIVO = 1 
                                     ORDER BY DESCRICAO ASC")
                .Select(x => new Tipo
                {
                    Id = (int)x.IDGRC_TIPO,
                    Descricao = x.DESCRICAO
                }).ToList();
            }
        }
        #endregion
    }
}
