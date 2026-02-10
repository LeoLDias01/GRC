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

        #region ..:: SALVA ITEM ::..

        #region .....::::: INSERÇÃO :::::.....


        public int InsereOS(OrdemServico os)
        {
            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        string sqlOrdemServico = @"INSERT INTO GRC_ORDEM_SERVICO
                                                            (IDGRC_CLIENTE, 
                                                             DESCRICAO_PROBLEMA, 
                                                             DESCRICAO_SOLUCAO, 
                                                             IDGRC_TIPO_SERVICO, 
                                                             IDGRC_STATUS, 
                                                             DATA_ENTRADA, 
                                                             FIM_PREVISTO,
                                                             GARANTIA,
                                                             INICIO_GARANTIA, 
                                                             FIM_GARANTIA, 
                                                             VALOR_MAO_OBRA, 
                                                             CUSTO_MANUAL,
                                                             ACRESCIMO, 
                                                             DESCONTO,
                                                             OBSERVACOES_LOJA, 
                                                             OBSERVACOES_CLIENTE,
                                                             FAVORITO)
                                VALUES (@IdCliente, 
                                        @DescricaoProblema,
                                        @DescricaoSolucao, 
                                        @IdTipo, 
                                        @Status, 
                                        @DataEntrada, 
                                        @FimPrevisto, 
                                        @Garantia, 
                                        @InicioGarantia, 
                                        @FimGarantia, 
                                        @ValorMaoObra,
                                        @CustoManual, 
                                        @Acrescimo, 
                                        @Desconto, 
                                        @ObservacoesLoja,
                                        @ObservacoesCliente,
                                        @Favorito);
                                SELECT last_insert_rowid();";

                        os.Id = conn.ExecuteScalar<int>(sqlOrdemServico, new
                        {
                            IdCliente = os.DadosCliente.Id > 0 ? os.DadosCliente.Id : (object)DBNull.Value,
                            DescricaoProblema = os.DescricaoProblema, // Nome é obrigatório, não precisa de tratamento
                            DescricaoSolucao = os.DescricaoSolucao,
                            IdTipo = os.TipoServico > 0 ? os.TipoServico : (object)DBNull.Value,
                            Status = os.Status > 0 ? os.Status : (object)DBNull.Value,
                            DataEntrada = string.IsNullOrWhiteSpace(os.DataEntrada) ? (object)DBNull.Value : os.DataEntrada,
                            FimPrevisto = string.IsNullOrWhiteSpace(os.FimPrevisto) ? (object)DBNull.Value : os.FimPrevisto,
                            Garantia = string.IsNullOrWhiteSpace(os.Garantia) ? (object)DBNull.Value : os.Garantia,
                            InicioGarantia = string.IsNullOrWhiteSpace(os.InicioGarantia) ? (object)DBNull.Value : os.InicioGarantia,
                            FimGarantia = string.IsNullOrWhiteSpace(os.FimGarantia) ? (object)DBNull.Value : os.FimGarantia,
                            ValorMaoObra = string.IsNullOrWhiteSpace(os.MaoObra) ? (object)DBNull.Value : os.MaoObra,
                            CustoManual = string.IsNullOrWhiteSpace(os.CustoManual) ? (object)DBNull.Value : os.CustoManual,
                            Acrescimo = string.IsNullOrWhiteSpace(os.Acrescimo) ? (object)DBNull.Value : os.Acrescimo,
                            Desconto = string.IsNullOrWhiteSpace(os.Desconto) ? (object)DBNull.Value : os.Desconto,
                            ObservacoesLoja = string.IsNullOrWhiteSpace(os.Observacoes) ? (object)DBNull.Value : os.Observacoes,
                            ObservacoesCliente = string.IsNullOrWhiteSpace(os.ObservacoesCliente) ? (object)DBNull.Value : os.ObservacoesCliente,
                            Favorito = os.Favorito == true ? 1 : 0

                        }, tran);
                        


                        if (os.ItensOrdemServico != null)
                        {

                            foreach (var comp in os.ItensOrdemServico)
                            {
                                if (comp.Id == 0 && comp.IdItem > 0)
                                {
                                    string sqlComp = @"
                                                    INSERT INTO GRC_ITEM_OS
                                                    (IDGRC_ITEM_ESTOQUE, IDGRC_ORDEM_SERVICO, QUANTIDADE)
                                                    VALUES (@IdItem, @Id, @Qtd);";

                                    conn.Execute(sqlComp, new
                                    {
                                        IdItem = comp.IdItem,
                                        Id = os.Id,
                                        Qtd = comp.Quantidade
                                    }, tran);
                                }
                            }
                        }

                        foreach (var esp in os.ItensEsporadicos)
                        {
                            if (esp.Id == 0)
                            {
                                string sqlEsp = @"
                                    INSERT INTO GRC_ITEM_OS_ESPORADICO
                                    (IDGRC_ORDEM_SERVICO, DESCRICAO)
                                    VALUES (@Id, @Descricao);";

                                conn.Execute(sqlEsp, new
                                {
                                    Id = os.Id,
                                    Descricao = esp.Descricao 
                                }, tran);
                            }
                        }

                        tran.Commit();
                        return os.Id;

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

        public int AlteraOS(OrdemServico os)
        {
            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {

                        // Atualiza dados do item
                        var sqlUpdateOS = @"
                                                    UPDATE GRC_ORDEM_SERVICO
                                                    SET 
                                                    IDGRC_CLIENTE = @IdCliente,
                                                    NOME_CLIENTE = @NomeCliente, 
                                                    DESCRICAO = @Descricao, 
                                                    IDGRC_TIPO_SERVICO = @IdTipo,
                                                    GARANTIA = @Garantia,
                                                    DATA_ENTRADA = @DataEntrada,
                                                    FIM_PREVISTO = @FimPrevisto,
                                                    FIM_REAL = @FimReal,
                                                    INICIO_GARANTIA = @InicioGarantia,
                                                    FIM_GARANTIA = @FimGarantia, 
                                                    VALOR_MAO_OBRA = @ValorMaoObra,
                                                    ACRESCIMO = @Acrescimo,
                                                    DESCONTO = @Desconto, 
                                                    OBSERVACOES = @Observacoes, 
                                                    FAVORITO = @Favorito
                                                    WHERE IDGRC_ORDEM_SERVICO = @Id";
                        conn.Execute(sqlUpdateOS, new
                        {
                            Id = os.Id,
                            IdCliente = os.IdCliente > 0 ? os.IdCliente : (object)DBNull.Value,
                            NomeCliente = os.NomeCliente, // Nome é obrigatório, não precisa de tratamento
                            Descricao = os.DescricaoSolucao,
                            IdTipo = os.TipoServico > 0 ? os.TipoServico : (object)DBNull.Value,
                            DataEntrada = string.IsNullOrWhiteSpace(os.DataEntrada) ? (object)DBNull.Value : os.DataEntrada,
                            FimPrevisto = string.IsNullOrWhiteSpace(os.FimPrevisto) ? (object)DBNull.Value : os.FimPrevisto,
                            FimReal = string.IsNullOrWhiteSpace(os.FimReal) ? (object)DBNull.Value : os.FimReal,
                            Garantia = string.IsNullOrWhiteSpace(os.Garantia) ? (object)DBNull.Value : os.Garantia,
                            InicioGarantia = string.IsNullOrWhiteSpace(os.InicioGarantia) ? (object)DBNull.Value : os.InicioGarantia,
                            FimGarantia = string.IsNullOrWhiteSpace(os.FimGarantia) ? (object)DBNull.Value : os.FimGarantia,
                            ValorMaoObra = string.IsNullOrWhiteSpace(os.MaoObra) ? (object)DBNull.Value : os.MaoObra,
                            Acrescimo = string.IsNullOrWhiteSpace(os.Acrescimo) ? (object)DBNull.Value : os.Acrescimo,
                            Desconto = string.IsNullOrWhiteSpace(os.Desconto) ? (object)DBNull.Value : os.Desconto,
                            Observacoes = string.IsNullOrWhiteSpace(os.Observacoes) ? (object)DBNull.Value : os.Observacoes,
                            Favorito = os.Favorito == true ? true : false
                        }, tran);

                        #region ... Itens Da OS ...


                        var composicaoAtual = conn.Query(@"         SELECT IDGRC_ITEM_OS AS Id, 
                                                                            IDGRC_ITEM_ESTOQUE AS IdItem,
                                                                            QUANTIDADE AS Qtd
                                                                     FROM GRC_ITEM_OS 
                                                                     WHERE IDGRC_ORDEM_SERVICO = @IdOs",
                            new
                            {
                                IdOs = os.Id
                            }, tran).Select(x => new ItemCard
                            {
                                Id = (int)x.Id,
                                IdItem = (int)x.IdItem,
                                Quantidade = (int)x.Qtd
                            }).ToList();

                        var composicaoForm = os.ItensOrdemServico ?? new List<ItemCard>();
                        //var composicaoForm = item.ComposicaoItem ?? new List<ItemCard>();


                        // novos = os que vieram do grid e têm ID nulo ou zero
                        var novos = composicaoForm.Where(x => x.IdItem > 0 && x.Id == 0).ToList();

                        // editar = itens que existem no banco e no form, mas com quantidade diferente
                        var editar = composicaoForm
                            .Where(form => form.Id > 0)
                            .Join(
                                composicaoAtual,
                                form => form.Id,
                                db => db.Id,
                                (form, db) => new
                                {
                                    IdItemOS = form.Id,
                                    QuantidadeAntiga = db.Quantidade,
                                    QuantidadeNova = form.Quantidade
                                }
                            )
                            .Where(x => x.QuantidadeAntiga != x.QuantidadeNova)
                            .ToList();

                        // excluir = os que estão no banco mas não estão mais no grid
                        var excluir = composicaoAtual
                            .Where(db => !composicaoForm.Any(form => form.Id == db.Id))
                            .ToList();

                        // ===========================================
                        // 2.1 INSERIR NOVAS COMPOSIÇÕES
                        // ===========================================
                        foreach (var comp in novos)
                        {
                            conn.Execute(@"
                                            INSERT INTO GRC_ITEM_OS
                                                    (IDGRC_ITEM_ESTOQUE, IDGRC_ORDEM_SERVICO, QUANTIDADE)
                                                    VALUES (@IdItem, @Id, @Qtd);",
                                new
                                {
                                    IdItem = comp.IdItem,
                                    Id = os.Id,
                                    Qtd = comp.Quantidade
                                }, tran);
                        }

                        // ===========================================
                        // 2.2 INATIVAR COMPOSIÇÕES REMOVIDAS
                        // ===========================================
                        foreach (var comp in excluir)
                        {
                            conn.Execute(@"
                                            UPDATE GRC_ITEM_OS
                                            SET ATIVO = 0
                                            WHERE IDGRC_ITEM_OS = @Id",
                                new { Id = comp.Id }, tran);
                        }

                        foreach (var item in editar)
                        {
                            conn.Execute( @"    UPDATE GRC_ITEM_OS 
                                                SET QUANTIDADE = @QtdNova
                                                WHERE IDGRC_ITEM_OS = @Id",
                                new
                                {
                                    QtdNova = item.QuantidadeNova,
                                    Id = item.IdItemOS
                                },
                                tran
                            );
                        }

                        //------------------------------------------------------------------------------------------------------------------------------------------------------
                        // VERIFICANDO SE É PRECISO DAR BAIXA NO ESTOQUE CASO O STATUS SEJA ALTERADO PARA FINALIZADO, E É PRECISO DEVOLVER NO ESTOQUE CASO SEJA CANCELADO
                        //------------------------------------------------------------------------------------------------------------------------------------------------------
                        if (os.StatusAntigo != os.Status && os.StatusAntigo > 0)
                        {
                            if (os.Status == 10)
                            {
                                RealizaBaixaEstoque(os);
                            }
                            else
                            {
                                EstornaEstoque(os);
                            }

                            var sqlUpdateStatus = @"
                                                    UPDATE GRC_ORDEM_SERVICO
                                                    SET 
                                                    STATUS = @Status
                                                    WHERE IDGRC_ORDEM_SERVICO = @Id";
                            conn.Execute(sqlUpdateStatus, new
                            {
                                Id = os.Id,
                                Status = os.Status > 0 ? os.Status : (object)DBNull.Value,
                            }, tran);

                        }

                        #endregion
                        tran.Commit();
                        return os.Id;

                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        throw new Exception("Erro ao atualizar Ordem de Serviço: " + ex.Message);
                    }
                }
            }
        }
        private void RealizaBaixaEstoque(OrdemServico os)
        {
            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {

                        foreach (var comp in os.ItensOrdemServico)
                        {
                            if (comp.IdItem > 0 && os.Id > 0)
                            {
                                string sqlMov = @"INSERT INTO GRC_ITEM_MOVIMENTACAO
                                                            (IDGRC_ITEM_ESTOQUE, 
                                                             IDGRC_TIPO_MOVIMENTACAO, 
                                                             MOTIVO, 
                                                             QUANTIDADE, 
                                                             OBSERVACOES)
                                VALUES (@IdItem, 5,'Baixa Automática OS', @Qtd, 'Status da ordem de serviço foi alterado para FINALIZADO');
                                SELECT last_insert_rowid();";

                                int mov = conn.ExecuteScalar<int>(sqlMov, new
                                {
                                    IdItem = comp.Id,
                                    Qtd = comp.Quantidade
                                }, tran);

                                string sqlRegistro = @"INSERT INTO GRC_MOVIMENTACAO_OS
                                                            (IDGRC_ITEM_MOVIMENTACAO, 
                                                             IDGRC_ORDEM_SERVICO)
                                                        VALUES (@IdItem, @Os);";

                                conn.Execute(sqlRegistro, new
                                {
                                    IdItem = comp.Id,
                                    Os = os.Id
                                }, tran);
                            }
                        }

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
        private void EstornaEstoque(OrdemServico os)
        {
            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        string sqlEstorno = @"UPDATE GRC_ITEM_MOVIMENTACAO
                                           SET ATIVO = 0
                                           WHERE IDGRC_ITEM_MOVIMENTACAO IN (SELECT IDGRC_ITEM_MOVIMENTACAO FROM GRC_MOVIMENTACAO_OS WHERE IDGRC_ORDEM_SERVICO = @Id AND ATIVO = 1)";

                        conn.Execute(sqlEstorno, new
                        {
                            Id = os.Id
                        }, tran);

                        string sqlRegistro = @"UPDATE GRC_MOVIMENTACAO_OS
                                           SET ATIVO = 0
                                           WHERE IDGRC_ORDEM_SERVICO = @Id";

                        conn.Execute(sqlRegistro, new
                        {
                            Id = os.Id
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

        #endregion



        #endregion

        public List<OrdemServico> BuscaCompleta(int id)
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                try
                {
                    // Query principal com LEFT JOIN para trazer endereço e email
                    var itens = conn.Query($@"
                                                        SELECT 
                                                        IDGRC_ORDEM_SERVICO AS Id,
                                                        IDGRC_CLIENTE AS Idcliente,
                                                        NOME_CLIENTE AS NomeCliente,
                                                        DESCRICAO AS Descricao,
                                                        IDGRC_TIPO_SERVICO AS Tipo,
                                                        IDGRC_STATUS AS Status,
                                                        GARANTIA AS Garantia,
                                                        DATA_ENTRADA AS DataEntrada,
                                                        FIM_PREVISTO AS FimPrevisto,
                                                        FIM_REAL  AS  FimReal,
                                                        INICIO_GARANTIA AS InicioGarantia,
                                                        FIM_GARANTIA  AS  FimGarantia,
                                                        VALOR_MAO_OBRA AS MaoObra,
                                                        ACRESCIMO   AS Acrescimo,
                                                        DESCONTO   AS Desconto,
                                                        OBSERVACOES  AS Observacoes,
                                                        FAVORITO AS Favorito
                                                        FROM GRC_ORDEM_SERVICO 
                                                        WHERE IDGRC_ORDEM_SERVICO = @Id",
                                                        new { Id = id })
                    .Select(x => new OrdemServico
                    {
                        Id = (int)x.Id,
                        IdCliente = (int)x.Idcliente,
                        NomeCliente = x.NomeCliente,
                        DescricaoSolucao = x.Descricao,
                        TipoServico = (int)x.Tipo,
                        Status = (int)x.Status,
                        Garantia = x.Garantia,
                        DataEntrada = x.DataEntrada,
                        FimPrevisto = x.FimPrevisto,
                        FimReal = x.FimReal,
                        InicioGarantia = x.InicioGarantia,
                        FimGarantia = x.FimGarantia,
                        MaoObra = x.MaoObra,
                        Acrescimo = x.Acrescimo,
                        Desconto = x.Desconto,
                        Observacoes = x.Observacoes,
                        Favorito = Convert.ToBoolean(x.Favorito),

                        // Itens de composição podem ser preenchidos depois com outra query
                        ItensOrdemServico = new List<ItemCard>()
                    }).ToList();

                    if (itens.Count > 0)
                    {
                        foreach (var item in itens)
                        {
                            var composicoes = conn.Query($@"
                                                                SELECT 
                                                                        ITS.IDGRC_ITEM_OS AS Id,
                                                                        ITS.IDGRC_ITEM_ESTOQUE AS IdItem,
                                                                        ITS.QUANTIDADE AS Qtd,
                                                                        ITM.DESCRICAO AS Descricao,
                                                                        ITM.FOTO AS Foto,
                                                                        ITM.QUANTIDADE AS QuantidadeMaxima,
                                                                        ITM.CUSTO_UNITARIO AS CustoUnitario
                                                                FROM GRC_ITEM_OS ITS
                                                                INNER JOIN GRC_ITEM_ESTOQUE ITM ON ITM.IDGRC_ITEM_ESTOQUE = ITS.IDGRC_ITEM_ESTOQUE
                                                                WHERE ITS.IDGRC_ORDEM_SERVICO = @IdOS AND ITS.ATIVO = 1",
                                                new { IdOS = id }).ToList();

                            item.ItensOrdemServico = composicoes.Select(c => new ItemCard
                            {
                                Id = (int)c.Id,
                                IdItem = (int)c.IdItem,
                                Quantidade = (int)c.Qtd,
                                Descricao = c.Descricao,
                                FotoItem = c.Foto,
                                QuantidadeMaxima = (int)c.QuantidadeMaxima,
                                Custo = c.CustoUnitario
                            }).ToList();
                        }
                    }

                    return itens;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao buscar fornecedores: " + ex.Message);
                }
            }
        }
        public List<OrdemServico> BuscaLimitada(OrdemServico os, int registros)
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                try
                {
                    var sql = new StringBuilder();
                    sql.Append(@"SELECT 
                                        OS.IDGRC_ORDEM_SERVICO AS Id,
                                        OS.NOME_CLIENTE AS Nome,
                                        OS.DATA_ENTRADA AS DataEntrada,
                                        OS.FAVORITO AS Favorito,
                                        ST.DESCRICAO AS Status, 
                                        TP.DESCRICAO AS Tipo
                                FROM GRC_ORDEM_SERVICO OS
                                INNER JOIN GRC_TIPO ST ON ST.IDGRC_TIPO = OS.IDGRC_STATUS
                                                          AND ST.IDGRC_SUBTIPO = 7
                                                          AND ST.ATIVO = 1
                                INNER JOIN GRC_TIPO TP ON TP.IDGRC_TIPO = OS.IDGRC_TIPO_SERVICO
                                                          AND TP.IDGRC_SUBTIPO = 6
                                                          AND TP.ATIVO = 1
                                WHERE 1 = 1 ");

                    // Filtros dinâmicos
                    if (os.Id > 0)
                        sql.Append(" AND OS.IDGRC_ORDEM_SERVICO = @Id ");

                    if (os.IdCliente > 0)
                        sql.Append(" AND OS.IDGRC_CLIENTE = @IdCliente ");

                    if (os.TipoServico > 0)
                        sql.Append(" AND OS.IDGRC_TIPO_SERVICO = @Tipo ");

                    if (os.Status > 0)
                        sql.Append(" AND OS.IDGRC_STATUS = @Status ");

                    if (os.Favorito)
                        sql.Append(" AND OS.FAVORITO = @Favorito ");

                    if (!string.IsNullOrWhiteSpace(os.DataEntrada))
                        sql.Append(" AND OS.DATA_ENTRADA = @Data ");

                    sql.Append(" ORDER BY OS.FAVORITO, OS.NOME_CLIENTE ASC LIMIT @Registros; ");

                    var lista = conn.Query(sql.ToString(), new
                    {
                        Id = (int)os.Id,
                        IdCliente = os.IdCliente > 0 ? os.IdCliente : 0,
                        Tipo = os.TipoServico > 0 ? os.TipoServico : 0,
                        Status = os.Status > 0 ? os.Status : 0,
                        Favorito = os.Favorito == true ? 1 : 0,
                        Data = os.DataEntrada.ToString(),
                        Registros = registros
                    })
                    .Select(x => new OrdemServico
                    {
                        Id = (int)x.Id,
                        NomeCliente = x.Nome,
                        DataEntrada = x.DataEntrada,
                        Favorito = x.Favorito == 1 ? true : false,
                        DescricaoStatus = x.Status,
                        DescricaoTipo = x.Tipo
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
