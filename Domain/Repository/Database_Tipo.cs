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
    public class Database_Tipo
    {
        ConexaoSQlite _conn = new ConexaoSQlite();

        #region ..:: CATEGORIA DE ITEM DE ESTOQUE ::..
        public int SalvaCategoriaItem(Tipo tipo)
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        // -------------------------------------------------------
                        // INSERE CATEGORIA
                        // -------------------------------------------------------
                        string sqlFornecedor = @"INSERT INTO GRC_TIPO
                                (DESCRICAO, IDGRC_SUBTIPO)
                                VALUES (@Descricao, 1);
                                SELECT last_insert_rowid();";

                        tipo.Id = conn.ExecuteScalar<int>(sqlFornecedor, new
                        {
                            Descricao = tipo.Descricao, // Nome é obrigatório, não precisa de tratamento
                        }, tran);


                        tran.Commit();
                        return tipo.Id;
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }
        public int AlteraCategoriaItem(Tipo tipo)
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {



                        // Atualiza dados básicos do fornecedor
                        var sqlUpdateFornecedor = @"
                                        UPDATE GRC_TIPO
                                        SET DESCRICAO = @Descricao
                                        WHERE IDGRC_TIPO = @Id";

                        conn.Execute(sqlUpdateFornecedor, new
                        {
                            Id = tipo.Id,
                            Descricao = tipo.Descricao
                        }, tran);


                        tran.Commit();
                        return tipo.Id;
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }
        public List<Tipo> BuscaCategoriaItem()
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                return conn.Query($@"SELECT IDGRC_TIPO, DESCRICAO
                                     FROM GRC_TIPO 
                                     WHERE IDGRC_SUBTIPO = 1 
                                     AND ATIVO = 1 ")
                .Select(x => new Tipo
                {
                    Id = (int)x.IDGRC_TIPO,
                    Descricao = x.DESCRICAO
                }).ToList();
            }
        }
        public void InativaCategoriaItem(int id)
        {
            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        // Inativa telefones
                        conn.Execute(@"UPDATE GRC_TIPO
                               SET ATIVO = 0
                               WHERE IDGRC_TIPO = @Id",
                                     new { Id = id }, tran);
                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }
        #endregion

        #region ..:: UNIDADE DE MEDIDA ::..

        public int SalvaUnidadeMedida(Tipo tipo)
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        // -------------------------------------------------------
                        // INSERE UNIDADE DE MEDIDA
                        // -------------------------------------------------------
                        string sqlFornecedor = @"INSERT INTO GRC_TIPO
                                (DESCRICAO, IDGRC_SUBTIPO)
                                VALUES (@Descricao, 3);
                                SELECT last_insert_rowid();";

                        tipo.Id = conn.ExecuteScalar<int>(sqlFornecedor, new
                        {
                            Descricao = tipo.Descricao, // Nome é obrigatório, não precisa de tratamento
                        }, tran);


                        tran.Commit();
                        return tipo.Id;
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }
        
        public List<Tipo> BuscaUnidadeMedida()
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                return conn.Query($@"SELECT IDGRC_TIPO, DESCRICAO
                                     FROM GRC_TIPO 
                                     WHERE IDGRC_SUBTIPO = 3 
                                     AND ATIVO = 1 ")
                .Select(x => new Tipo
                {
                    Id = (int)x.IDGRC_TIPO,
                    Descricao = x.DESCRICAO
                }).ToList();
            }
        }
        public void InativaUnidadeMedida(int id)
        {
            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        // Inativa telefones
                        conn.Execute(@"UPDATE GRC_TIPO
                               SET ATIVO = 0
                               WHERE IDGRC_TIPO = @Id",
                                     new { Id = id }, tran);
                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        #endregion

        #region ..:: MARCA ::..
        public int SalvaFabricante(Tipo tipo)
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        // -------------------------------------------------------
                        // INSERE CATEGORIA
                        // -------------------------------------------------------
                        string sqlFornecedor = @"INSERT INTO GRC_TIPO
                                (DESCRICAO, IDGRC_SUBTIPO)
                                VALUES (@Descricao, 4);
                                SELECT last_insert_rowid();";

                        tipo.Id = conn.ExecuteScalar<int>(sqlFornecedor, new
                        {
                            Descricao = tipo.Descricao, // Nome é obrigatório, não precisa de tratamento
                        }, tran);


                        tran.Commit();
                        return tipo.Id;
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }
        public int AlteraFabricante(Tipo tipo)
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {



                        // Atualiza dados básicos do fornecedor
                        var sqlUpdateFornecedor = @"
                                        UPDATE GRC_TIPO
                                        SET DESCRICAO = @Descricao
                                        WHERE IDGRC_TIPO = @Id";

                        conn.Execute(sqlUpdateFornecedor, new
                        {
                            Id = tipo.Id,
                            Descricao = tipo.Descricao
                        }, tran);


                        tran.Commit();
                        return tipo.Id;
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }
        public List<Tipo> BuscaFabricante()
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                return conn.Query($@"SELECT IDGRC_TIPO, DESCRICAO
                                     FROM GRC_TIPO 
                                     WHERE IDGRC_SUBTIPO = 4 
                                     AND ATIVO = 1 ")
                .Select(x => new Tipo
                {
                    Id = (int)x.IDGRC_TIPO,
                    Descricao = x.DESCRICAO
                }).ToList();
            }
        }
        public void InativaFabricante(int id)
        {
            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        // Inativa telefones
                        conn.Execute(@"UPDATE GRC_TIPO
                               SET ATIVO = 0
                               WHERE IDGRC_TIPO = @Id",
                                     new { Id = id }, tran);
                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }
        #endregion

        #region ..:: MARCA ::..
        public int SalvaTipoServico(Tipo tipo)
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        // -------------------------------------------------------
                        // INSERE CATEGORIA
                        // -------------------------------------------------------
                        string sqlFornecedor = @"INSERT INTO GRC_TIPO
                                (DESCRICAO, IDGRC_SUBTIPO)
                                VALUES (@Descricao, 6);
                                SELECT last_insert_rowid();";

                        tipo.Id = conn.ExecuteScalar<int>(sqlFornecedor, new
                        {
                            Descricao = tipo.Descricao, // Nome é obrigatório, não precisa de tratamento
                        }, tran);


                        tran.Commit();
                        return tipo.Id;
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }
        public int AlteraTipoServico(Tipo tipo)
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {



                        // Atualiza dados básicos do fornecedor
                        var sqlUpdateFornecedor = @"
                                        UPDATE GRC_TIPO
                                        SET DESCRICAO = @Descricao
                                        WHERE IDGRC_TIPO = @Id";

                        conn.Execute(sqlUpdateFornecedor, new
                        {
                            Id = tipo.Id,
                            Descricao = tipo.Descricao
                        }, tran);


                        tran.Commit();
                        return tipo.Id;
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }
        public List<Tipo> BuscaTipoServico()
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                return conn.Query($@"SELECT IDGRC_TIPO, DESCRICAO
                                     FROM GRC_TIPO 
                                     WHERE IDGRC_SUBTIPO = 6 
                                     AND ATIVO = 1 ")
                .Select(x => new Tipo
                {
                    Id = (int)x.IDGRC_TIPO,
                    Descricao = x.DESCRICAO
                }).ToList();
            }
        }
        public void InativaTipoServico(int id)
        {
            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        // Inativa telefones
                        conn.Execute(@"UPDATE GRC_TIPO
                               SET ATIVO = 0
                               WHERE IDGRC_TIPO = @Id",
                                     new { Id = id }, tran);
                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }
        #endregion
    }
}
