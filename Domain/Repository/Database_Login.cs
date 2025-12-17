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
    public class DatabaseLogin
    {
        ConexaoSQlite _conn = new ConexaoSQlite();
        public List<Login> VerificaLogin(string usuario, string senha)
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                return conn.Query($@"SELECT IDGRC_USUARIO, NOME, USUARIO
                                     FROM GRC_USUARIO 
                                     WHERE USUARIO = @usuario 
                                     AND SENHA = @senha
                                     AND ATIVO = 1 ", param: new { @usuario = usuario, @senha = senha })
                .Select(x => new Login
                {
                    Id = (int)x.IDGRC_USUARIO,
                    Nome = x.NOME,
                    Usuario = x.USUARIO
                }).ToList();
            }
        }
    }
}
