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
    public class Database_MovimentoEstoque
    {
        ConexaoSQlite _conn = new ConexaoSQlite();

        #region ..:: COMBOS: TIPO MOVIMENTACAO ::..

        public List<Tipo> BuscaTipoMovimentacao()
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                return conn.Query($@"SELECT IDGRC_TIPO, DESCRICAO
                                     FROM GRC_TIPO 
                                     WHERE IDGRC_SUBTIPO = 2 
                                     AND ATIVO = 1 AND IDGRC_TIPO IN (1,2,3)")
                .Select(x => new Tipo
                {
                    Id = (int)x.IDGRC_TIPO,
                    Descricao = x.DESCRICAO
                }).ToList();
            }
        }

        #endregion

        public int CadastraMovimento(Movimentacao mov)
        {
            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        string sqlFornecedor = @"INSERT INTO GRC_ITEM_MOVIMENTACAO
                                                            (IDGRC_ITEM_ESTOQUE, 
                                                             IDGRC_TIPO_MOVIMENTACAO, 
                                                             MOTIVO, 
                                                             QUANTIDADE, 
                                                             CUSTO_UNITARIO, 
                                                             OBSERVACOES, 
                                                             DATA_MOVIMENTACAO)
                                VALUES (@IdItem, 
                                        @TipoMov,
                                        @Motivo, 
                                        @Qtd, 
                                        @Custo, 
                                        @Observacoes, 
                                        @DataMov);
                                SELECT last_insert_rowid();";

                        mov.Id = conn.ExecuteScalar<int>(sqlFornecedor, new
                        {
                            IdItem = mov.DadosItem.Id,
                            TipoMov = mov.TipoMovimentacao,
                            Motivo = mov.Motivo,
                            Qtd = mov.DadosItem.Quatidade,
                            Custo = mov.TipoMovimentacao == 1 ? mov.DadosItem.CustoUnitario : null,
                            Observacoes = mov.Observacoes,
                            DataMov = mov.DataMovimentacao
                        }, tran);

                        tran.Commit();
                        return mov.Id;

                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }
        public int AlteraMovimento(Movimentacao mov)
        {
            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        string sqlFornecedor = @"UPDATE GRC_ITEM_MOVIMENTACAO
                                                 SET MOTIVO         = @Motivo,
                                                     OBSERVACOES    = @Observacoes,
                                                     DATA_MOVIMENTACAO = @DataMov
                                                 WHERE IDGRC_ITEM_MOVIMENTACAO = @Id";

                        mov.Id = conn.ExecuteScalar<int>(sqlFornecedor, new
                        {
                            Id = mov.Id,
                            Motivo = mov.Motivo,
                            Observacoes = mov.Observacoes,
                            DataMov = mov.DataMovimentacao
                        }, tran);

                        tran.Commit();
                        return mov.Id;

                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }
        public void InativaMovimento(Movimentacao mov)
        {
            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        string sqlFornecedor = @"UPDATE GRC_ITEM_MOVIMENTACAO
                                                 SET ATIVO = 0
                                                 WHERE IDGRC_ITEM_MOVIMENTACAO = @Id";

                        conn.Execute(sqlFornecedor, new
                        {
                            Id = mov.Id,
                        }, tran);

                        tran.Commit();

                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }
        public List<Movimentacao> BuscaLimitada(Movimentacao mov, int registros, string dataInicial, string dataFinal)
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                try
                {
                    DateTime? dtInicial = null;
                    DateTime? dtFinal = null;

                    if (!string.IsNullOrWhiteSpace(dataInicial) &&
                        !string.IsNullOrWhiteSpace(dataFinal))
                    {
                        dtInicial = DateTime.ParseExact(
                            dataInicial, "dd/MM/yyyy", CultureInfo.GetCultureInfo("pt-BR")
                        );

                        dtFinal = DateTime.ParseExact(
                            dataFinal, "dd/MM/yyyy", CultureInfo.GetCultureInfo("pt-BR")
                        );
                    }

                    var sql = new StringBuilder();
                    sql.Append(@"SELECT 
                                        MOV.DATA_MOVIMENTACAO AS Data,
                                        MOV.IDGRC_ITEM_MOVIMENTACAO AS Id,
                                        ITM.DESCRICAO AS DescricaoItem,
                                        TIP.DESCRICAO AS TipoMov,
                                        MOV.QUANTIDADE AS Qtd,
                                        MOV.MOTIVO AS Motivo
                                FROM GRC_ITEM_MOVIMENTACAO MOV
                                INNER JOIN GRC_ITEM_ESTOQUE ITM ON ITM.IDGRC_ITEM_ESTOQUE = MOV.IDGRC_ITEM_ESTOQUE
                                INNER JOIN GRC_TIPO TIP ON TIP.IDGRC_TIPO = MOV.IDGRC_TIPO_MOVIMENTACAO
                                                          AND TIP.IDGRC_SUBTIPO = 2
                                                          AND TIP.ATIVO = 1
    
                                WHERE MOV.ATIVO = 1 ");
  

                    // 2. Filtros Combo Estruturais (Se selecionados, filtram especificamente)
                    if (mov.TipoMovimentacao > 0)
                        sql.Append(" AND MOV.IDGRC_TIPO_MOVIMENTACAO = @IdTipo ");

                    if (mov.DadosItem.CodBarras != string.Empty)
                        sql.Append(" AND ITM.CODIGO_BARRAS = @CodBarras ");

                    // 3. Filtro Unificado (Valida o termo em qualquer uma das colunas textuais importantes)
                    // Usamos o campo 'Descricao' do objeto para carregar o termo que veio do txtPesquisa
                    if (!string.IsNullOrWhiteSpace(mov.Descricao))
                    {
                        sql.Append(@" AND (ITM.DESCRICAO LIKE @Termo) ");
                    }

                    // Formata o termo colocando as porcentagens para o LIKE do SQLite
                    string termoFormatado = $"%{mov.Descricao?.Trim()}%";


                    if (!string.IsNullOrWhiteSpace(dataInicial) && !string.IsNullOrWhiteSpace(dataFinal))
                        sql.Append(@" AND MOV.DATA_MOVIMENTACAO 
                                        BETWEEN @DataInicial || ' 00:00:00'
                                        AND @DataFinal   || ' 23:59:59' ");


                    sql.Append(" ORDER BY MOV.DATA_MOVIMENTACAO ASC LIMIT @Registros; ");

                    var lista = conn.Query(sql.ToString(), new
                    {
                        IdTipo = mov.TipoMovimentacao,
                        CodBarras = mov.DadosItem.CodBarras != null? mov.DadosItem.CodBarras : null,
                        Termo = termoFormatado,
                        DataInicial = dtInicial?.ToString("yyyy-MM-dd"),
                        DataFinal = dtFinal?.ToString("yyyy-MM-dd"),
                        Registros = registros
                    })
                    .Select(x => new Movimentacao
                    {
                        DataMovimentacao = x.Data,
                        Id = Convert.ToInt32(x.Id),
                        Descricao = x.TipoMov,
                        Motivo = x.Motivo,
                        DadosItem = new Item
                        {
                            Descricao = x.DescricaoItem,
                            Quatidade = (int)x.Qtd
                        }
                    }).ToList();

                    return lista;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao buscar movimentos do db: " + ex.Message);
                }
            }
        }
        public List<Movimentacao> BuscaCompleta(int id)
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                try
                {
                    var sql = new StringBuilder();
                    sql.Append(@"SELECT 
                                        MOV.IDGRC_ITEM_MOVIMENTACAO AS IdMov,
                                        MOV.IDGRC_ITEM_ESTOQUE AS IdItem,
                                        ITM.DESCRICAO AS Item,  
                                        MOV.IDGRC_TIPO_MOVIMENTACAO AS IdTipo,
                                        MOV.MOTIVO AS Motivo,
                                        MOV.QUANTIDADE AS Qtd,
                                        MOV.CUSTO_UNITARIO AS Custo,
                                        MOV.OBSERVACOES AS Observacoes,
                                        MOV.DATA_MOVIMENTACAO AS Data
                                FROM GRC_ITEM_MOVIMENTACAO MOV
                                INNER JOIN GRC_ITEM_ESTOQUE ITM ON ITM.IDGRC_ITEM_ESTOQUE = MOV.IDGRC_ITEM_ESTOQUE
                                WHERE MOV.ATIVO = 1 AND MOV.IDGRC_ITEM_MOVIMENTACAO = @Id");

                    var lista = conn.Query(sql.ToString(), new
                    {
                        Id = id
                    })
                    .Select(x => new Movimentacao
                    {
                        Id = Convert.ToInt32(x.IdMov),
                        DadosItem = new Item
                        {
                            Id = Convert.ToInt32(x.IdItem),
                            Descricao = x.Item,
                            Quatidade = Convert.ToInt32(x.Qtd),
                            CustoUnitario = x.Custo
                        },
  
                        TipoMovimentacao = Convert.ToInt32(x.IdTipo),
                        Motivo = x.Motivo,
                        Observacoes = x.Observacoes,
                        DataMovimentacao = x.Data,
                    }).ToList();

                    return lista;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao buscar itens do database: " + ex.Message);
                }
            }
        }
    }
}
