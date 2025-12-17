using Dapper;
using Data.Models;
using Domain.Conections;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public class Database_Fornecedor
    {

        ConexaoSQlite _conn = new ConexaoSQlite();

        #region .....::::: INSERÇÃO :::::.....


        /// <summary>
        /// Faz a inserção no banco ignorando se email e endereço são nulos
        /// </summary>
        /// <param name="fornecedor"> objeto com os dados do fornecedor</param>
        /// <returns>retorna o Id do fornecedor inserido</returns>
        public int InsereFornecedor(Fornecedores fornecedor)
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        // -------------------------------------------------------
                        // Endereço (somente se habilitado)
                        // -------------------------------------------------------
                        if (fornecedor.Endereco != null)
                        {
                            string sqlEndereco = @"INSERT INTO GRC_ENDERECO
                                (CEP, LOGRADOURO, NUMERO, BAIRRO, CIDADE, UF, COMPLEMENTO, OBSERVACOES)
                                VALUES
                                (@Cep, @Logradouro, @Numero, @Bairro, @Cidade, @Uf, @Complemento, @Observacoes);
                                SELECT last_insert_rowid();";

                            fornecedor.Endereco.Id = conn.ExecuteScalar<int>(sqlEndereco, fornecedor.Endereco, tran);
                        }

                        // -------------------------------------------------------
                        // E-mail (somente se habilitado)
                        // -------------------------------------------------------
                        if (fornecedor.Email != null)
                        {
                            string sqlEmail = @"INSERT INTO GRC_EMAIL
                                (EMAIL, OBSERVACOES)
                                VALUES (@Descricao, @Observacoes);
                                SELECT last_insert_rowid();";

                            fornecedor.Email.Id = conn.ExecuteScalar<int>(sqlEmail, fornecedor.Email, tran);
                        }


                        // -------------------------------------------------------
                        // INSERE FORNECEDOR
                        // -------------------------------------------------------
                        string sqlFornecedor = @"INSERT INTO GRC_FORNECEDOR
                                (DESCRICAO, RAZAO_SOCIAL, INSCRICAO_ESTADUAL, CNPJ, IDGRC_EMAIL, IDGRC_ENDERECO, OBSERVACOES)
                                VALUES (@Nome, @RazaoSocial, @InscricaoEstadual, @Cnpj, @EmailId, @EnderecoId, @Observacoes);
                                SELECT last_insert_rowid();";

                        fornecedor.Id = conn.ExecuteScalar<int>(sqlFornecedor, new
                        {
                            Nome = fornecedor.Nome, // Nome é obrigatório, não precisa de tratamento
                            RazaoSocial = string.IsNullOrWhiteSpace(fornecedor.RazaoSocial) ? (object)DBNull.Value : fornecedor.RazaoSocial,
                            InscricaoEstadual = string.IsNullOrWhiteSpace(fornecedor.IE) ? (object)DBNull.Value : fornecedor.IE,
                            Cnpj = string.IsNullOrWhiteSpace(fornecedor.Cnpj) ? (object)DBNull.Value : fornecedor.Cnpj,
                            EmailId = fornecedor.Email != null && fornecedor.Email.Id > 0 ? fornecedor.Email.Id : (object)DBNull.Value,
                            EnderecoId = fornecedor.Endereco != null && fornecedor.Endereco.Id > 0 ? fornecedor.Endereco.Id : (object)DBNull.Value,
                            Observacoes = string.IsNullOrWhiteSpace(fornecedor.Observacoes) ? (object)DBNull.Value : fornecedor.Observacoes
                        }, tran);


                        // -------------------------------------------------------
                        // INSERE TELEFONES
                        // -------------------------------------------------------
                        foreach (var tel in fornecedor.Telefones)
                        {
                            if (tel.Id == 0)
                            {
                                string sqlTel = @"
                                    INSERT INTO GRC_TELEFONE_FORNECEDOR
                                    (IDGRC_FORNECEDOR, DESCRICAO, WHATSAPP, OBSERVACOES)
                                    VALUES (@FornecedorId, @Descricao, @Whatsapp, @Observacoes);";

                                conn.Execute(sqlTel, new
                                {
                                    FornecedorId = fornecedor.Id,
                                    Descricao = tel.Descricao,
                                    Whatsapp = tel.Whatsapp ? 1 : 0,
                                    Observacoes = string.IsNullOrWhiteSpace(tel.Observacoes) ? (object)DBNull.Value : tel.Observacoes
                                }, tran);
                            }
                        }

                        tran.Commit();
                        return fornecedor.Id;
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }
        #endregion

        #region .....::::: ALTERAÇÃO :::::.....

        public int AlteraFornecedor(Fornecedores fornecedor)
        {
            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (string.IsNullOrWhiteSpace(fornecedor.Nome))
                            throw new Exception("O nome do fornecedor não pode estar vazio.");

                       
                        // Atualiza dados básicos do fornecedor
                        var sqlUpdateFornecedor = @"
                                                    UPDATE GRC_FORNECEDOR
                                                    SET 
                                                    DESCRICAO = @Nome,
                                                    RAZAO_SOCIAL = @RazaoSocial,
                                                    INSCRICAO_ESTADUAL = @IE,
                                                    CNPJ = @Cnpj,
                                                    OBSERVACOES = @Observacoes,
                                                    ATIVO = 1
                                                    WHERE IDGRC_FORNECEDOR = @Id";

                        conn.Execute(sqlUpdateFornecedor, new
                        {
                            fornecedor.Nome,
                            fornecedor.RazaoSocial,
                            fornecedor.IE,
                            fornecedor.Cnpj,
                            fornecedor.Observacoes,
                            fornecedor.Id
                        }, tran);


                        #region ... ENDEREÇO ...


                        if (fornecedor.Endereco != null)
                        {
                            if (fornecedor.Endereco.Id == 0)
                            {
                                // Inserção de endereço
                                string sqlEndereco = @"
                                                        INSERT INTO GRC_ENDERECO (CEP, LOGRADOURO, NUMERO, BAIRRO, CIDADE, UF, COMPLEMENTO, OBSERVACOES)
                                                                          VALUES (@Cep, @Logradouro, @Numero, @Bairro, @Cidade, @Uf, @Complemento, @Observacoes);
                                                        SELECT last_insert_rowid();";

                                fornecedor.Endereco.Id = conn.ExecuteScalar<int>(sqlEndereco, 
                                new 
                                {
                                    Cep = fornecedor.Endereco.Cep,
                                    Logradouro = fornecedor.Endereco.Logradouro,
                                    Numero = fornecedor.Endereco.Numero,
                                    Bairro = fornecedor.Endereco.Bairro,
                                    Cidade = fornecedor.Endereco.Cidade,
                                    Uf = fornecedor.Endereco.Uf,
                                    Complemento = fornecedor.Endereco.Complemento,
                                    Observacoes = fornecedor.Endereco.Observacoes
                                }, tran);

                                conn.Execute(@"
                                                UPDATE GRC_FORNECEDOR 
                                                SET IDGRC_ENDERECO = @IdEndereco
                                                WHERE IDGRC_FORNECEDOR = @IdFornecedor", new
                                {
                                    IdEndereco = fornecedor.Endereco.Id,
                                    IdFornecedor = fornecedor.Id
                                }, tran);
                            }
                            else
                            {
                                // Atualiza endereço existente
                                var sqlUpdateEndereco = @"
                                                                UPDATE GRC_ENDERECO
                                                                SET CEP = @Cep,
                                                                    LOGRADOURO = @Logradouro,
                                                                    NUMERO = @Numero,
                                                                    BAIRRO = @Bairro,
                                                                    CIDADE = @Cidade,
                                                                    UF = @Uf,
                                                                    COMPLEMENTO = @Complemento,
                                                                    OBSERVACOES = @Observacoes
                                                                WHERE IDGRC_ENDERECO = @Id";
                                conn.Execute(sqlUpdateEndereco, 
                                new
                                {
                                    Cep = fornecedor.Endereco.Cep,
                                    Logradouro = fornecedor.Endereco.Logradouro,
                                    Numero = fornecedor.Endereco.Numero,
                                    Bairro = fornecedor.Endereco.Bairro,
                                    Cidade = fornecedor.Endereco.Cidade,
                                    Uf = fornecedor.Endereco.Uf,
                                    Complemento = fornecedor.Endereco.Complemento,
                                    Observacoes = fornecedor.Endereco.Observacoes,
                                    Id = fornecedor.Endereco.Id
                                }, tran);
                            }
                        }
                        else 
                        {

                            // Se o endereço foi desmarcado no form, desativa
                            var sqlRemoveEndereco = @"
                                                        UPDATE GRC_FORNECEDOR
                                                        SET IDGRC_ENDERECO = NULL
                                                        WHERE IDGRC_FORNECEDOR = @IdFornecedor;

                                                        

                                                        UPDATE GRC_ENDERECO
                                                        SET ATIVO = 0
                                                        WHERE IDGRC_ENDERECO IN (SELECT IDGRC_ENDERECO FROM GRC_FORNECEDOR WHERE IDGRC_FORNECEDOR = @IdFornecedor);";
                            conn.Execute(sqlRemoveEndereco, new
                            {
                                IdFornecedor = fornecedor.Id
                            }, tran);
                        }
                        #endregion

                        #region ... EMAIL ...
                        if (fornecedor.Email != null)
                        {
                            if (fornecedor.Email.Id == 0)
                            {
                                string sqlEmail = @"
                                                    INSERT INTO GRC_EMAIL (EMAIL, OBSERVACOES) VALUES (@Descricao, @Observacoes);
                                                    SELECT last_insert_rowid();";

                                fornecedor.Email.Id = conn.ExecuteScalar<int>(sqlEmail, fornecedor.Email, tran);

                                conn.Execute(@"
                                                UPDATE GRC_FORNECEDOR 
                                                SET IDGRC_EMAIL = @IdEmail
                                                 WHERE IDGRC_FORNECEDOR = @IdFornecedor", new
                                {
                                    IdEmail = fornecedor.Email.Id,
                                    IdFornecedor = fornecedor.Id
                                }, tran);
                            }
                            else
                            {
                                var sqlUpdateEmail = @"
                                                        UPDATE GRC_EMAIL
                                                        SET EMAIL = @Descricao,
                                                        OBSERVACOES = @Observacoes
                                                        WHERE IDGRC_EMAIL = @Id";
                                conn.Execute(sqlUpdateEmail,
                                    new
                                    {
                                        Descricao = fornecedor.Email.Descricao,
                                        Observacoes = fornecedor.Email.Observacoes,
                                        Id = fornecedor.Email.Id,
                                    }, tran);
                            }
                        }
                        else
                        {
                            // Se email foi desmarcado no form, desativa
                            var sqlRemoveEmail = @"
                                                   UPDATE GRC_FORNECEDOR
                                                    SET IDGRC_EMAIL = NULL
                                                    WHERE IDGRC_FORNECEDOR = @IdFornecedor;

                                                    UPDATE GRC_EMAIL
                                                    SET ATIVO = 0
                                                    WHERE IDGRC_EMAIL IN (SELECT IDGRC_EMAIL FROM GRC_FORNECEDOR WHERE IDGRC_FORNECEDOR = @IdFornecedor);";
                            conn.Execute(sqlRemoveEmail, new
                            {
                                IdFornecedor = fornecedor.Id
                            }, tran);
                        }
                        #endregion

                        #region ... TELEFONES ...

                        // Telefones atuais no banco
                        var telefonesAtuais = conn.Query<Telefone>(@"SELECT IDGRC_TELEFONE_FORNECEDOR AS Id, 
                                                                            DESCRICAO, 
                                                                            WHATSAPP, 
                                                                            OBSERVACOES 
                                                                     FROM GRC_TELEFONE_FORNECEDOR 
                                                                     WHERE IDGRC_FORNECEDOR = @IdFornecedor",
                            new
                            {
                                IdFornecedor = fornecedor.Id
                            }, tran).ToList();

                        // Telefones a inserir (novos)
                        var novos = fornecedor.Telefones.Where(t => t.Id == 0).ToList();

                        // Telefones a atualizar (já existem no banco)
                        var atualizar = fornecedor.Telefones.Where(t => t.Id > 0).ToList();

                        // Telefones a excluir (estão no banco, mas não vieram do form)
                        var excluir = telefonesAtuais
                            .Where(t => !fornecedor.Telefones.Any(x => x.Id == t.Id))
                            .ToList();

                        // INSERIR novos telefones
                        foreach (var tel in novos)
                        {
                            conn.Execute(@" INSERT INTO GRC_TELEFONE_FORNECEDOR
                                    (IDGRC_FORNECEDOR, DESCRICAO, WHATSAPP, OBSERVACOES)
                                    VALUES (@FornecedorId, @Descricao, @Whatsapp, @Observacoes);",
                                new
                                {
                                    FornecedorId = fornecedor.Id,
                                    Descricao = tel.Descricao,
                                    Whatsapp = tel.Whatsapp,
                                    Observacoes = tel.Observacoes
                                }, tran);
                        }

                        // ATUALIZAR existentes
                        foreach (var tel in atualizar)
                        {
                            conn.Execute(@"
                                            UPDATE GRC_TELEFONE_FORNECEDOR
                                            SET DESCRICAO = @Descricao,
                                                WHATSAPP = @Whatsapp,
                                                OBSERVACOES = @Observacoes
                                                WHERE IDGRC_TELEFONE_FORNECEDOR = @Id AND IDGRC_FORNECEDOR = @IdFornecedor",
                                new
                                {
                                    Descricao = tel.Descricao,
                                    Whatsapp = tel.Whatsapp,
                                    Observacoes = tel.Observacoes,
                                    Id = tel.Id,
                                    IdFornecedor = fornecedor.Id
                                }, tran);
                        }

                        // EXCLUIR telefones removidos
                        foreach (var tel in excluir)
                        {
                            conn.Execute(@"UPDATE GRC_TELEFONE_FORNECEDOR
                                             SET ATIVO = 0
                                           WHERE IDGRC_TELEFONE_FORNECEDOR = @Id",
                            new
                            {
                                Id = tel.Id
                            }, tran);
                        }

                        
                        #endregion
                     
                        tran.Commit();
                        return fornecedor.Id;
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        throw new Exception("Erro ao atualizar fornecedor: " + ex.Message);
                    }
                }
            }
        }

        #endregion



        #region .....::::: PESQUISA :::::.....


        /// <summary>
        /// Busca os dados de fornecedor no banco apenas para exibir, sendo uma busca limitada
        /// </summary>
        /// <param name="fornecedor"> dados do fornecedor para busca</param>
        /// <param name="registros"> quantidade de registros a serem buscados</param>
        /// <returns>Retorna uma lista com dados do banco para preencher o datagrid</returns>
        public List<Fornecedores> BuscaLimitada(Fornecedores fornecedor, int registros)
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                try
                {
                    var sql = new StringBuilder();
                    sql.Append(@"
                SELECT 
                    CAST(FORN.IDGRC_FORNECEDOR AS INT) AS Id,
                    FORN.DESCRICAO AS Nome,
                    FORN.RAZAO_SOCIAL AS RazaoSocial,
                    FORN.CNPJ AS Cnpj,
                    ENDE.CIDADE AS Cidade,
                    ENDE.UF AS Uf
                FROM GRC_FORNECEDOR FORN
                LEFT JOIN GRC_ENDERECO ENDE ON FORN.IDGRC_ENDERECO = ENDE.IDGRC_ENDERECO 
                                                    AND ENDE.ATIVO = 1
    
                WHERE 1 = 1 ");

                    // Filtros dinâmicos
                    if (!string.IsNullOrWhiteSpace(fornecedor.Nome))
                        sql.Append(" AND FORN.DESCRICAO LIKE @Nome ");

                    if (!string.IsNullOrWhiteSpace(fornecedor.RazaoSocial))
                        sql.Append(" AND FORN.RAZAO_SOCIAL LIKE @RazaoSocial ");

                    if (!string.IsNullOrWhiteSpace(fornecedor.Cnpj))
                        sql.Append(" AND FORN.CNPJ LIKE @Cnpj ");

                    sql.Append(" AND FORN.ATIVO = @Ativo ");

                    if (fornecedor.Endereco != null)
                    {
                        if (!string.IsNullOrWhiteSpace(fornecedor.Endereco.Cidade))
                            sql.Append(" AND ENDE.CIDADE LIKE @Cidade ");

                        if (!string.IsNullOrWhiteSpace(fornecedor.Endereco.Uf))
                            sql.Append(" AND ENDE.UF LIKE @Uf ");
                    }

                    sql.Append(" ORDER BY FORN.DESCRICAO ASC LIMIT @Registros; ");

                    var lista = conn.Query(sql.ToString(), new
                    {
                        Nome = $"%{fornecedor.Nome}%",
                        RazaoSocial = $"%{fornecedor.RazaoSocial}%",
                        Cnpj = $"%{fornecedor.Cnpj}%",
                        Ativo = fornecedor.Ativo,
                        Cidade = fornecedor.Endereco != null ? $"%{fornecedor.Endereco.Cidade}%" : null,
                        Uf = fornecedor.Endereco != null ? $"%{fornecedor.Endereco.Uf}%" : null,
                        Registros = registros
                    })
                    .Select(x => new Fornecedores
                    {
                        Id = (int)x.Id,
                        Nome = x.Nome,
                        RazaoSocial = x.RazaoSocial,
                        Cnpj = x.Cnpj,
                        //Observacoes = x.Observacoes,
                        Endereco = new Endereco
                        {
                            Cidade = x.Cidade,
                            Uf = x.Uf
                        }
                    }).ToList();

                    return lista;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao buscar fornecedores: " + ex.Message);
                }
            }
        }
        public List<Fornecedores> BuscaCompleta(int idFornecedor)
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                try
                {
                    // Query principal com LEFT JOIN para trazer endereço e email
                    var fornecedores = conn.Query($@"
            SELECT 
                CAST(FORN.IDGRC_FORNECEDOR AS INT) AS Id,
                FORN.DESCRICAO AS Nome,
                FORN.RAZAO_SOCIAL AS RazaoSocial,
                FORN.INSCRICAO_ESTADUAL AS IE,
                FORN.CNPJ AS Cnpj,
                FORN.OBSERVACOES AS Observacoes,
                ENDE.IDGRC_ENDERECO AS EnderecoId,
                ENDE.CEP AS Cep,
                ENDE.LOGRADOURO AS Logradouro,
                ENDE.NUMERO AS Numero,
                ENDE.BAIRRO AS Bairro,
                ENDE.CIDADE AS Cidade,
                ENDE.UF AS Uf,
                ENDE.COMPLEMENTO AS Complemento,
                ENDE.OBSERVACOES AS ObservacoesEndereco,
                EM.IDGRC_EMAIL AS EmailId,
                EM.EMAIL AS DescricaoEmail,
                EM.OBSERVACOES AS ObservacoesEmail,
                FORN.ATIVO AS Ativo
            FROM GRC_FORNECEDOR FORN
            LEFT JOIN GRC_ENDERECO ENDE ON FORN.IDGRC_ENDERECO = ENDE.IDGRC_ENDERECO AND ENDE.ATIVO = 1
            LEFT JOIN GRC_EMAIL EM ON FORN.IDGRC_EMAIL = EM.IDGRC_EMAIL AND EM.ATIVO = 1
            WHERE FORN.IDGRC_FORNECEDOR = @Id", new { Id = idFornecedor })
                    .Select(x => new Fornecedores
                    {
                        Id = (int)x.Id,
                        Nome = x.Nome,
                        RazaoSocial = x.RazaoSocial,
                        IE = x.IE,
                        Cnpj = x.Cnpj,
                        Observacoes = x.Observacoes,
                        Ativo = Convert.ToBoolean(x.Ativo),
                        Endereco = x.EnderecoId != null ? new Endereco
                        {
                            Id = (int)x.EnderecoId,
                            Cep = x.Cep,
                            Logradouro = x.Logradouro,
                            Numero = x.Numero,
                            Bairro = x.Bairro,
                            Cidade = x.Cidade,
                            Uf = x.Uf,
                            Complemento = x.Complemento,
                            Observacoes = x.ObservacoesEndereco
                        } : null,
                        Email = x.EmailId != null ? new Email
                        {
                            Id = (int)x.EmailId,
                            Descricao = x.DescricaoEmail,
                            Observacoes = x.ObservacoesEmail
                        } : null,
                        // Telefones podem ser preenchidos depois com outra query
                        Telefones = new List<Telefone>()
                    }).ToList();

                    if (fornecedores.Count > 0)
                    {
                        var telefones = conn.Query($@"
            SELECT 
                IDGRC_TELEFONE_FORNECEDOR AS Id,
                IDGRC_FORNECEDOR AS FornecedorId,
                DESCRICAO AS Descricao,
                WHATSAPP AS Whatsapp,
                OBSERVACOES AS Observacoes
            FROM GRC_TELEFONE_FORNECEDOR
            WHERE IDGRC_FORNECEDOR = @Id AND ATIVO = 1",
            new { Id = idFornecedor })
        .ToList();

                        foreach (var f in fornecedores)
                        {
                            f.Telefones = telefones
                                .Where(t => (int)(t.FornecedorId) == f.Id)
                                .Select(t => new Telefone
                                {
                                    Id = (int)(t.Id),
                                    Descricao = t.Descricao?.ToString(),
                                    // Conversão manual de long → bool
                                    Whatsapp = Convert.ToBoolean(t.Whatsapp),
                                    Observacoes = t.Observacoes?.ToString()
                                }).ToList();
                        }
                    }

                    return fornecedores;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao buscar fornecedores: " + ex.Message);
                }
            }
        }

        #endregion

        #region .....::::: EXCLUSÃO :::::.....

        public void InativaFornecedor(int id)
        {
            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        // Inativa telefones
                        conn.Execute(@"UPDATE GRC_TELEFONE_FORNECEDOR
                               SET ATIVO = 0
                               WHERE IDGRC_FORNECEDOR = @Id",
                                     new { Id = id }, tran);

                        // Inativa email
                        conn.Execute(@"UPDATE GRC_EMAIL
                               SET ATIVO = 0
                               WHERE IDGRC_EMAIL IN (
                                   SELECT IDGRC_EMAIL
                                   FROM GRC_FORNECEDOR
                                   WHERE IDGRC_FORNECEDOR = @Id
                               )", new { Id = id }, tran);

                        // Inativa endereço
                        conn.Execute(@"UPDATE GRC_ENDERECO
                               SET ATIVO = 0
                               WHERE IDGRC_ENDERECO IN (
                                   SELECT IDGRC_ENDERECO
                                   FROM GRC_FORNECEDOR
                                   WHERE IDGRC_FORNECEDOR = @Id
                               )", new { Id = id }, tran);

                        // Inativa fornecedor
                        conn.Execute(@"UPDATE GRC_FORNECEDOR
                               SET ATIVO = 0
                               WHERE IDGRC_FORNECEDOR = @Id",
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
