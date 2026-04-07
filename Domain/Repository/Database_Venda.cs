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
                                OBSERVACOES) 
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
    }
}

