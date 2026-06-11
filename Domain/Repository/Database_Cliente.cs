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
    public class Database_Cliente
    {
        ConexaoSQlite _conn = new ConexaoSQlite();

        #region .....::::: INSERÇÃO :::::.....


        /// <summary>
        /// Faz a inserção no banco ignorando se email e endereço são nulos
        /// </summary>
        /// <param name="fornecedor"> objeto com os dados do fornecedor</param>
        /// <returns>retorna o Id do fornecedor inserido</returns>
        public int InsereFornecedor(Cliente cliente)
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
                        if (cliente.Endereco != null)
                        {
                            string sqlEndereco = @"INSERT INTO GRC_ENDERECO
                                (CEP, LOGRADOURO, NUMERO, BAIRRO, CIDADE, UF, COMPLEMENTO, OBSERVACOES)
                                VALUES
                                (@Cep, @Logradouro, @Numero, @Bairro, @Cidade, @Uf, @Complemento, @Observacoes);
                                SELECT last_insert_rowid();";

                            cliente.Endereco.Id = conn.ExecuteScalar<int>(sqlEndereco, cliente.Endereco, tran);
                        }

                        // -------------------------------------------------------
                        // E-mail (somente se habilitado)
                        // -------------------------------------------------------
                        if (cliente.Email != null)
                        {
                            cliente.Email.Id = conn.ExecuteScalar<int>(@"INSERT INTO GRC_EMAIL (EMAIL) VALUES (@Descricao);
                                SELECT last_insert_rowid();",
                                param: new { Descricao = cliente.Email.Descricao }, tran);
                        }



                        // -------------------------------------------------------
                        // INSERE FORNECEDOR
                        // -------------------------------------------------------
                        string sqlCliente = @"INSERT INTO GRC_CLIENTE
                                (NOME, IDGRC_TIPO_PESSOA, IDENTIFICACAO, IDGRC_EMAIL, IDGRC_ENDERECO, OBSERVACOES)
                                VALUES (@Nome, @Tipo, @Identificacao, @EmailId, @EnderecoId, @Observacoes);
                                SELECT last_insert_rowid();";

                        cliente.Id = conn.ExecuteScalar<int>(sqlCliente, new
                        {
                            Nome = cliente.Nome, // Nome é obrigatório, não precisa de tratamento
                            Tipo = cliente.TipoPessoa > 0 ? cliente.TipoPessoa : (object)DBNull.Value,
                            Identificacao = string.IsNullOrWhiteSpace(cliente.Identidade) ? (object)DBNull.Value : cliente.Identidade,
                            EmailId = cliente.Email != null && cliente.Email.Id > 0 ? cliente.Email.Id : (object)DBNull.Value,
                            EnderecoId = cliente.Endereco != null && cliente.Endereco.Id > 0 ? cliente.Endereco.Id : (object)DBNull.Value,
                            Observacoes = string.IsNullOrWhiteSpace(cliente.Observacoes) ? (object)DBNull.Value : cliente.Observacoes
                        }, tran);


                        // -------------------------------------------------------
                        // INSERE TELEFONES
                        // -------------------------------------------------------
                        foreach (var tel in cliente.Telefones)
                        {
                            if (tel.Id == 0)
                            {
                                string sqlTel = @"
                                    INSERT INTO GRC_TELEFONE_CLIENTE
                                    (IDGRC_CLIENTE, DESCRICAO, WHATSAPP)
                                    VALUES (@ClienteId, @Descricao, @Whatsapp);";

                                conn.Execute(sqlTel, new
                                {
                                    ClienteId = cliente.Id,
                                    Descricao = tel.Descricao,
                                    Whatsapp = tel.Whatsapp ? 1 : 0,
                                }, tran);
                            }
                        }



                        tran.Commit();
                        return cliente.Id;
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

        public int AlteraFornecedor(Cliente Cliente)
        {
            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (string.IsNullOrWhiteSpace(Cliente.Nome))
                            throw new Exception("O nome do cliente não pode estar vazio.");


                        // Atualiza dados básicos do fornecedor
                        var sqlUpdateCliente = @"
                                                    UPDATE GRC_CLIENTE
                                                    SET 
                                                    NOME = @Nome,
                                                    IDGRC_TIPO_PESSOA = @Tipo,
                                                    IDENTIFICACAO = @Identificacao,
                                                    OBSERVACOES = @Observacoes,
                                                    ATIVO = 1
                                                    WHERE IDGRC_CLIENTE = @Id";

                        conn.Execute(sqlUpdateCliente, new
                        {
                            Nome = Cliente.Nome,
                            Tipo = Cliente.TipoPessoa,
                            Identificacao = Cliente.Identidade,
                            Observacoes = Cliente.Observacoes,
                            Id = Cliente.Id
                        }, tran);


                        #region ... ENDEREÇO ...


                        if (Cliente.Endereco != null)
                        {
                            if (Cliente.Endereco.Id == 0)
                            {
                                // Inserção de endereço
                                string sqlEndereco = @"
                                                        INSERT INTO GRC_ENDERECO (CEP, LOGRADOURO, NUMERO, BAIRRO, CIDADE, UF, COMPLEMENTO, OBSERVACOES)
                                                                          VALUES (@Cep, @Logradouro, @Numero, @Bairro, @Cidade, @Uf, @Complemento, @Observacoes);
                                                        SELECT last_insert_rowid();";

                                Cliente.Endereco.Id = conn.ExecuteScalar<int>(sqlEndereco,
                                new
                                {
                                    Cep = Cliente.Endereco.Cep,
                                    Logradouro = Cliente.Endereco.Logradouro,
                                    Numero = Cliente.Endereco.Numero,
                                    Bairro = Cliente.Endereco.Bairro,
                                    Cidade = Cliente.Endereco.Cidade,
                                    Uf = Cliente.Endereco.Uf,
                                    Complemento = Cliente.Endereco.Complemento,
                                    Observacoes = Cliente.Endereco.Observacoes
                                }, tran);

                                conn.Execute(@"
                                                UPDATE GRC_CLIENTE 
                                                SET IDGRC_ENDERECO = @IdEndereco
                                                WHERE IDGRC_CLIENTE = @IdCliente", new
                                {
                                    IdEndereco = Cliente.Endereco.Id,
                                    IdCliente = Cliente.Id
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
                                    Cep = Cliente.Endereco.Cep,
                                    Logradouro = Cliente.Endereco.Logradouro,
                                    Numero = Cliente.Endereco.Numero,
                                    Bairro = Cliente.Endereco.Bairro,
                                    Cidade = Cliente.Endereco.Cidade,
                                    Uf = Cliente.Endereco.Uf,
                                    Complemento = Cliente.Endereco.Complemento,
                                    Observacoes = Cliente.Endereco.Observacoes,
                                    Id = Cliente.Endereco.Id
                                }, tran);
                            }
                        }
                        else
                        {

                            // Se o endereço foi desmarcado no form, desativa
                            var sqlRemoveEndereco = @"
                                                        UPDATE GRC_CLIENTE
                                                        SET IDGRC_ENDERECO = NULL
                                                        WHERE IDGRC_CLIENTE = @IdCliente;

                                                        

                                                        UPDATE GRC_ENDERECO
                                                        SET ATIVO = 0
                                                        WHERE IDGRC_ENDERECO IN (SELECT IDGRC_ENDERECO FROM GRC_CLIENTE WHERE IDGRC_CLIENTE = @IdCliente);";
                            conn.Execute(sqlRemoveEndereco, new
                            {
                                IdCliente = Cliente.Id
                            }, tran);
                        }
                        #endregion

                        #region ... EMAIL ...
                        if (Cliente.Email != null)
                        {
                            if (Cliente.Email.Id == 0)
                            {
                                string sqlEmail = @"
                                                    INSERT INTO GRC_EMAIL (EMAIL) VALUES (@Descricao);
                                                    SELECT last_insert_rowid();";

                                Cliente.Email.Id = conn.ExecuteScalar<int>(sqlEmail, Cliente.Email, tran);

                                conn.Execute(@"
                                                UPDATE GRC_FORNECEDOR 
                                                SET IDGRC_EMAIL = @IdEmail
                                                 WHERE IDGRC_CLIENTE = @IdCliente", new
                                {
                                    IdEmail = Cliente.Email.Id,
                                    IdCliente = Cliente.Id
                                }, tran);
                            }
                            else
                            {
                                var sqlUpdateEmail = @"
                                                        UPDATE GRC_EMAIL
                                                        SET EMAIL = @Descricao
                                                        WHERE IDGRC_EMAIL = @Id";
                                conn.Execute(sqlUpdateEmail,
                                    new
                                    {
                                        Descricao = Cliente.Email.Descricao,
                                        Id = Cliente.Email.Id,
                                    }, tran);
                            }
                        }
                        else
                        {
                            // Se email foi desmarcado no form, desativa
                            var sqlRemoveEmail = @"
                                                   UPDATE GRC_CLIENTE
                                                    SET IDGRC_EMAIL = NULL
                                                    WHERE IDGRC_CLIENTE = @IdCliente;

                                                    UPDATE GRC_EMAIL
                                                    SET ATIVO = 0
                                                    WHERE IDGRC_EMAIL IN (SELECT IDGRC_EMAIL FROM GRC_CLIENTE WHERE IDGRC_CLIENTE = @IdCliente);";
                            conn.Execute(sqlRemoveEmail, new
                            {
                                IdCliente = Cliente.Id
                            }, tran);
                        }
                        #endregion

                        #region ... TELEFONES ...

                        // Telefones atuais no banco
                        var telefonesAtuais = conn.Query<Telefone>(@"SELECT IDGRC_TELEFONE_CLIENTE AS Id, 
                                                                            DESCRICAO, 
                                                                            WHATSAPP
                                                                     FROM GRC_TELEFONE_CLIENTE 
                                                                     WHERE IDGRC_CLIENTE = @IdCliente",
                            new
                            {
                                IdCliente = Cliente.Id
                            }, tran).ToList();

                        // Telefones a inserir (novos)
                        var novos = Cliente.Telefones.Where(t => t.Id == 0).ToList();

                        // Telefones a atualizar (já existem no banco)
                        var atualizar = Cliente.Telefones.Where(t => t.Id > 0).ToList();

                        // Telefones a excluir (estão no banco, mas não vieram do form)
                        var excluir = telefonesAtuais
                            .Where(t => !Cliente.Telefones.Any(x => x.Id == t.Id))
                            .ToList();

                        // INSERIR novos telefones
                        foreach (var tel in novos)
                        {
                            conn.Execute(@" INSERT INTO GRC_TELEFONE_CLIENTE
                                    (IDGRC_CLIENTE, DESCRICAO, WHATSAPP)
                                    VALUES (@IdCliente, @Descricao, @Whatsapp);",
                                new
                                {
                                    IdCliente = Cliente.Id,
                                    Descricao = tel.Descricao,
                                    Whatsapp = tel.Whatsapp
                                }, tran);
                        }

                        // ATUALIZAR existentes
                        foreach (var tel in atualizar)
                        {
                            conn.Execute(@"
                                            UPDATE GRC_TELEFONE_CLIENTE
                                            SET DESCRICAO = @Descricao,
                                                WHATSAPP = @Whatsapp
                                                WHERE IDGRC_TELEFONE_CLIENTE = @Id AND IDGRC_CLIENTE = @IdCliente",
                                new
                                {
                                    Descricao = tel.Descricao,
                                    Whatsapp = tel.Whatsapp,
                                    Id = tel.Id,
                                    IdCliente = Cliente.Id
                                }, tran);
                        }

                        // EXCLUIR telefones removidos
                        foreach (var tel in excluir)
                        {
                            conn.Execute(@"UPDATE GRC_TELEFONE_CLIENTE
                                             SET ATIVO = 0
                                           WHERE IDGRC_TELEFONE_CLIENTE = @Id",
                            new
                            {
                                Id = tel.Id
                            }, tran);
                        }


                        #endregion

                        tran.Commit();
                        return Cliente.Id;
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        throw new Exception("Erro ao atualizar cliente: " + ex.Message);
                    }
                }
            }
        }

        #endregion

        #region .....::::: PESQUISA :::::.....


        /// <summary>
        /// Busca os dados de fornecedor no banco apenas para exibir, sendo uma busca limitada
        /// </summary>
        /// <param name="cliente"> dados do fornecedor para busca</param>
        /// <param name="registros"> quantidade de registros a serem buscados</param>
        /// <returns>Retorna uma lista com dados do banco para preencher o datagrid</returns>
        public List<Cliente> BuscaLimitada(Cliente cliente, int registros)
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                try
                {
                    var sql = new StringBuilder();
                    sql.Append(@"
                SELECT 
                    CAST(CLI.IDGRC_CLIENTE AS INT) AS Id,
                    CLI.NOME AS Nome,
                    CLI.IDGRC_TIPO_PESSOA AS Tipo,
                    CLI.IDENTIFICACAO AS Identificacao,
                    ENDE.CIDADE AS Cidade,
                    ENDE.UF AS Uf,
                    CLI.ATIVO AS Ativo
                FROM GRC_CLIENTE CLI
                LEFT JOIN GRC_ENDERECO ENDE ON CLI.IDGRC_ENDERECO = ENDE.IDGRC_ENDERECO 
                                                    AND ENDE.ATIVO = 1
    
                WHERE 1 = 1 ");

                    // 1. Filtro de Status (Ativo/Inativo) - Se for nulo (filtro "Todos"), não aplica o WHERE do ativo
                    if (cliente.Ativo.HasValue)
                    {
                        sql.Append(" AND CLI.ATIVO = @Ativo ");
                    }

                    if (!string.IsNullOrWhiteSpace(cliente.Nome))
                    {
                        sql.Append(@" AND (
                    CLI.NOME LIKE @Termo 
                    OR CLI.IDENTIFICACAO LIKE @Termo 
                    OR ENDE.CIDADE LIKE @Termo 
                    OR ENDE.UF LIKE @Termo
                ) ");

                    }
                    sql.Append(" ORDER BY CLI.NOME ASC LIMIT @Registros; ");

                    string termoFormatado = $"%{cliente.Nome?.Trim()}%";
                    var lista = conn.Query(sql.ToString(), new
                    {
                        Termo = termoFormatado,
                        Ativo = cliente.Ativo,
                        Registros = registros
                    })
                .Select(x => new Cliente
                {
                    Id = (int)x.Id,
                    Nome = x.Nome,
                    TipoPessoa = (int)x.Tipo,
                    Identidade = x.Identificacao,
                    Endereco = new Endereco
                    {
                        Cidade = x.Cidade,
                        Uf = x.Uf
                    },
                    Ativo = x.Ativo == 1 ? true : false
                }).ToList();

                    return lista;

                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao buscar Clientes: " + ex.Message);

                }
            }
        }
        public List<Cliente> BuscaCompleta(int idCliente)
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                try
                {
                    // Query principal com LEFT JOIN para trazer endereço e email
                    var clientes = conn.Query($@"
            SELECT 
                CAST(CLI.IDGRC_CLIENTE AS INT) AS Id,
                CLI.NOME AS Nome,
                CLI.IDGRC_TIPO_PESSOA AS TipoPessoa,
                CLI.IDENTIFICACAO AS Identidade,
                CLI.OBSERVACOES AS Observacoes,
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
                CLI.ATIVO AS Ativo
            FROM GRC_CLIENTE CLI
            LEFT JOIN GRC_ENDERECO ENDE ON CLI.IDGRC_ENDERECO = ENDE.IDGRC_ENDERECO AND ENDE.ATIVO = 1
            LEFT JOIN GRC_EMAIL EM ON CLI.IDGRC_EMAIL = EM.IDGRC_EMAIL AND EM.ATIVO = 1
            WHERE CLI.IDGRC_CLIENTE = @Id", new { Id = idCliente })
                    .Select(x => new Cliente
                    {
                        Id = (int)x.Id,
                        Nome = x.Nome,
                        TipoPessoa = (int)x.TipoPessoa,
                        Identidade = x.Identidade,
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
                            Descricao = x.DescricaoEmail
                        } : null,
                        // Telefones podem ser preenchidos depois com outra query
                        Telefones = new List<Telefone>()
                    }).ToList();

                    if (clientes.Count > 0)
                    {
                        var telefones = conn.Query($@"
            SELECT 
                IDGRC_TELEFONE_CLIENTE AS Id,
                IDGRC_CLIENTE AS ClienteId,
                DESCRICAO AS Descricao,
                WHATSAPP AS Whatsapp
            FROM GRC_TELEFONE_CLIENTE
            WHERE IDGRC_CLIENTE = @Id AND ATIVO = 1",
            new { Id = idCliente })
        .ToList();

                        foreach (var f in clientes)
                        {
                            f.Telefones = telefones
                                .Where(t => (int)(t.ClienteId) == f.Id)
                                .Select(t => new Telefone
                                {
                                    Id = (int)(t.Id),
                                    Descricao = t.Descricao?.ToString(),
                                    // Conversão manual de long → bool
                                    Whatsapp = Convert.ToBoolean(t.Whatsapp)
                                }).ToList();
                        }
                    }

                    return clientes;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao buscar Cliente: " + ex.Message);
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
                        conn.Execute(@"UPDATE GRC_TELEFONE_CLIENTE
                               SET ATIVO = 0
                               WHERE IDGRC_CLIENTE = @Id",
                                     new { Id = id }, tran);

                        // Inativa email
                        conn.Execute(@"UPDATE GRC_EMAIL
                               SET ATIVO = 0
                               WHERE IDGRC_EMAIL IN (
                                   SELECT IDGRC_EMAIL
                                   FROM GRC_CLIENTE
                                   WHERE IDGRC_CLIENTE = @Id
                               )", new { Id = id }, tran);

                        // Inativa endereço
                        conn.Execute(@"UPDATE GRC_ENDERECO
                               SET ATIVO = 0
                               WHERE IDGRC_ENDERECO IN (
                                   SELECT IDGRC_ENDERECO
                                   FROM GRC_CLIENTE
                                   WHERE IDGRC_CLIENTE = @Id
                               )", new { Id = id }, tran);

                        // Inativa fornecedor
                        conn.Execute(@"UPDATE GRC_CLIENTE
                               SET ATIVO = 0
                               WHERE IDGRC_CLIENTE = @Id",
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
