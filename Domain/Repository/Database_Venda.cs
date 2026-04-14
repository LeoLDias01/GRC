using Dapper;
using Data.Models;
using Domain.Conections;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public class Database_Venda
    {
        ConexaoSQlite _conn = new ConexaoSQlite();


        #region ..:: CAIXA  ::..

        public List<Caixa> VerificaCaixa()
        {
            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                try
                {
                    var dadosAbertura = conn.Query($@" SELECT  CAST(IDGRC_CAIXA AS INTEGER) AS Id,
                                                        DATA_ABERTURA AS Data
                                               FROM GRC_CAIXA
                                               WHERE ABERTO = 1
                                               LIMIT 1")
 .Select(x => new Caixa
 {
     Id = (int)x.Id,
     DataAbertura = x.Data
 }).ToList();

                    return dadosAbertura;

                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao verificar status do caixa: " + ex.Message);
                }
            }
        }
        public int AberturaCaixa(Caixa caixa)
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                try
                {
                    // Query para inserir e retornar o ID gerado na mesma operação
                    var sql = @"
                                INSERT INTO GRC_CAIXA 
                                (IDGRC_USUARIO, 
                                PDV, 
                                SALDO_INICIAL,
                                DATA_ABERTURA, 
                                OBSERVACOES_ABERTURA) 
                VALUES (
                    @Usuario, 
                    @Pdv, 
                    @SaldoAbertura, 
                    @DataAbertura, 
                    @obs
                );
                SELECT last_insert_rowid();";

                    // Executa a query passando o objeto mapeado
                    var idGerado = conn.QuerySingle<int>(sql, new
                    {
                        Usuario = caixa.Usuario,
                        Pdv = caixa.PDV,
                        SaldoAbertura = caixa.SaldoAbertura,
                        DataAbertura = caixa.DataAbertura,
                        obs = string.IsNullOrWhiteSpace(caixa.Observacoes) ? "" : caixa.Observacoes
                    });

                    return idGerado;
                }
                catch (Exception ex)
                {
                    // Mensagem mais específica para a ação de abertura
                    throw new Exception("Erro ao abrir o caixa no banco de dados: " + ex.Message);
                }
            }
        }

        public List<Caixa> CarregaDadosCaixa(int id)
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                try
                {
                    var clientes = conn.Query($@"
                                                 SELECT 
    USR.IDGRC_USUARIO AS IdUsuario,
    USR.NOME AS Nome,
    CXA.PDV AS Pdv,
    CXA.DATA_ABERTURA AS DataAbertura,
    -- CÁLCULO DO SALDO ATUALIZADO (Inicial + Vendas - Sangrias)
    (
        -- 1. Converte Saldo Inicial
        CAST(REPLACE(REPLACE(SUBSTR(CXA.SALDO_INICIAL, 4), '.', ''), ',', '.') AS DECIMAL) +
        
        -- 2. Soma Vendas (Limpando R$)
        (SELECT COALESCE(SUM(CAST(REPLACE(REPLACE(SUBSTR(V.VALOR_TOTAL, 4), '.', ''), ',', '.') AS DECIMAL)), 0) 
         FROM GRC_VENDA V 
         WHERE V.IDGRC_CAIXA = CXA.IDGRC_CAIXA) -
         
        -- 3. Soma Sangrias (Limpando R$)
        (SELECT COALESCE(SUM(CAST(REPLACE(REPLACE(SUBSTR(S.VALOR, 4), '.', ''), ',', '.') AS DECIMAL)), 0) 
         FROM GRC_SANGRIA S 
         WHERE S.IDGRC_CAIXA = CXA.IDGRC_CAIXA)
         
    ) AS SaldoCalculado
FROM GRC_CAIXA CXA
INNER JOIN GRC_USUARIO USR ON USR.IDGRC_USUARIO = CXA.IDGRC_USUARIO
WHERE CXA.IDGRC_CAIXA = @Id;",
                        new { Id = id })
                    .Select(x => new Caixa
                    {
                        Usuario = (int)x.IdUsuario,
                        NomeUsuario = x.Nome,
                        PDV = (int)x.Pdv,
                        DataAbertura = x.DataAbertura,
                        SaldoCaixa = Convert.ToDecimal(x.SaldoCalculado)
                    }).ToList();

                    return clientes;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao buscar Clientes: " + ex.Message);
                }
            }
        }
        #endregion

        public List<Tipo> BuscaGruposItens()
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                try
                {
                    var itens = conn.Query($@"SELECT DISTINCT 
                                                                TIP.IDGRC_TIPO AS Id,
                                                                TIP.DESCRICAO AS Descricao
                                              FROM GRC_TIPO TIP
                                              INNER JOIN GRC_ITEM_ESTOQUE ITM ON ITM.IDGRC_CATEGORIA = TIP.IDGRC_TIPO
                                                                                        AND TIP.IDGRC_SUBTIPO = 1
                                              WHERE ITM.ITEM_VENDA = 1")
                    .Select(x => new Tipo
                    {
                        Id = (int)x.Id,
                        Descricao = x.Descricao
                    }).ToList();

                    return itens;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao buscar Clientes: " + ex.Message);
                }
            }
        }


        #region ..:: Finalizadores ::..

        #region .....::::: INSERÇÃO :::::.....


        public int InsereFinalizador(Finalizador finalizador)
        {
            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        string sqlInsercaoFinalizador = @"INSERT INTO GRC_FINALIZADOR
                                                            (IDGRC_CATEGORIA, 
                                                             DESCRICAO, 
                                                             ID_IMAGEM,
                                                             PARCELAMENTO,
                                                             NUMERO_PARCELAS)
                                VALUES (@Categoria, 
                                        @Descricao,
                                        @IdImagem, 
                                        @Parcelamento,
                                        @Parcelas);
                                SELECT last_insert_rowid();";

                        finalizador.Id = conn.ExecuteScalar<int>(sqlInsercaoFinalizador, new
                        {
                            Categoria = finalizador.Categoria > 0 ? finalizador.Categoria : (object)DBNull.Value,
                            Descricao = finalizador.Descricao, // Nome é obrigatório, não precisa de tratamento
                            IdImagem = finalizador.IdImagem > 0 ? finalizador.IdImagem : (object)DBNull.Value,
                            Parcelamento = finalizador.Parcelamento == true ? 1 : 0,
                            Parcelas = finalizador.Parcelamento == true ? finalizador.Parcelas : (object)DBNull.Value
                        }, tran);

                        tran.Commit();
                        return finalizador.Id;

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

        public int AlteraFinalizador(Finalizador finalizador)
        {
            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {

                        // Atualiza dados do item
                        var sqlUpdateFinalizador = @"
                                                    UPDATE GRC_FINALIZADOR
                                                    SET 
                                                    DESCRICAO = @Descricao,
                                                    IDGRC_CATEGORIA = @Categoria, 
                                                    ID_IMAGEM = @IdImagem,
                                                    PARCELAMENTO = @Parcelamento,
                                                    NUMERO_PARCELAS = @Parcelas
                                                    WHERE IDGRC_FINALIZADOR = @Id";

                        conn.Execute(sqlUpdateFinalizador, new
                        {
                            Id = finalizador.Id,
                            Categoria = finalizador.Categoria > 0 ? finalizador.Categoria : (object)DBNull.Value,
                            Descricao = finalizador.Descricao, // Nome é obrigatório, não precisa de tratamento
                            IdImagem = finalizador.IdImagem > 0 ? finalizador.IdImagem : (object)DBNull.Value,
                            Parcelamento = finalizador.Parcelamento == true ? 1 : 0,
                            Parcelas = finalizador.Parcelamento == true ? finalizador.Parcelas : (object)DBNull.Value
                        }, tran);

                        tran.Commit();
                        return finalizador.Id;

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

        #region .....::::: INATIVAÇÃO :::::.....
        public void InativaFinalizador(int id)
        {
            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {

                        // Inativa fornecedor
                        conn.Execute(@"UPDATE GRC_FINALIZADOR
                               SET ATIVO = 0
                               WHERE IDGRC_FINALIZADOR = @Id",
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

        public List<Tipo> BuscaCategoriasFinalizadores()
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                return conn.Query($@"SELECT IDGRC_TIPO, DESCRICAO
                                     FROM GRC_TIPO 
                                     WHERE IDGRC_SUBTIPO = 9 
                                     AND ATIVO = 1 
                                     ORDER BY DESCRICAO ASC")
                .Select(x => new Tipo
                {
                    Id = (int)x.IDGRC_TIPO,
                    Descricao = x.DESCRICAO
                }).ToList();
            }
        }

        public List<Finalizador> BuscaDadosFinalizador()
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                return conn.Query($@"SELECT 
    F.IDGRC_FINALIZADOR, 
    F.IDGRC_CATEGORIA,
    T.DESCRICAO AS DescricaoTipo,
    F.DESCRICAO, 
    F.ID_IMAGEM,
    F.PARCELAMENTO,
    F.NUMERO_PARCELAS,
    F.ATIVO
FROM GRC_FINALIZADOR F
INNER JOIN GRC_TIPO T ON T.IDGRC_TIPO = F.IDGRC_CATEGORIA 
WHERE F.ATIVO = 1 
  AND T.IDGRC_SUBTIPO = 9 
ORDER BY F.DESCRICAO ASC;")
                .Select(x => new Finalizador
                {
                    Id = (int)x.IDGRC_FINALIZADOR,
                    Categoria = (int)x.IDGRC_CATEGORIA,
                    DescricaoCategoria = x.DescricaoTipo,
                    Descricao = x.DESCRICAO,
                    IdImagem = (int)x.ID_IMAGEM,
                    Parcelamento = x.PARCELAMENTO == 1 ? true : false,
                    Parcelas = (int)x.NUMERO_PARCELAS,
                    Ativo = x.ATIVO == 1 ? true : false,
                }).ToList();
            }
        }

        #endregion
    }
}

