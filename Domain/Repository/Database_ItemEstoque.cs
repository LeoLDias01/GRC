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
    public class Database_ItemEstoque
    {
        ConexaoSQlite _conn = new ConexaoSQlite();

        #region ..:: COMBOS: CATEGORIA - FORNECEDOR - UNIDADE DE MEDIDA E MARCA ::..

        public List<Tipo> BuscaCategoriaItem()
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                return conn.Query($@"SELECT IDGRC_TIPO, DESCRICAO
                                     FROM GRC_TIPO 
                                     WHERE IDGRC_SUBTIPO = 1 
                                     AND ATIVO = 1 
                                     ORDER BY DESCRICAO ASC")
                .Select(x => new Tipo
                {
                    Id = (int)x.IDGRC_TIPO,
                    Descricao = x.DESCRICAO
                }).ToList();
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
                                     AND ATIVO = 1 
                                     ORDER BY DESCRICAO ASC")
                .Select(x => new Tipo
                {
                    Id = (int)x.IDGRC_TIPO,
                    Descricao = x.DESCRICAO
                }).ToList();
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
                                     AND ATIVO = 1 
                                     ORDER BY DESCRICAO ASC")
                .Select(x => new Tipo
                {
                    Id = (int)x.IDGRC_TIPO,
                    Descricao = x.DESCRICAO
                }).ToList();
            }
        }
        public List<Tipo> BuscaFornecedor()
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                return conn.Query($@"SELECT IDGRC_FORNECEDOR, DESCRICAO
                                     FROM GRC_FORNECEDOR 
                                     WHERE ATIVO = 1 
                                     ORDER BY DESCRICAO ASC")
                .Select(x => new Tipo
                {
                    Id = (int)x.IDGRC_FORNECEDOR,
                    Descricao = x.DESCRICAO
                }).ToList();
            }
        }
        #endregion

        #region ..:: SALVA ITEM ::..

        #region .....::::: INSERÇÃO :::::.....


        public long InsereItem(Item item)
        {
            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        string sqlFornecedor = @"INSERT INTO GRC_ITEM_ESTOQUE
                                                            (DESCRICAO, 
                                                             CODIGO_BARRAS, 
                                                             GARANTIA, 
                                                             VALIDADE, 
                                                             IDGRC_UNIDADE_MEDIDA, 
                                                             QUANTIDADE_MINIMA, 
                                                             QUANTIDADE, 
                                                             CUSTO_UNITARIO, 
                                                             IDGRC_FABRICANTE, 
                                                             IDGRC_CATEGORIA, 
                                                             IDGRC_FORNECEDOR, 
                                                             OBSERVACOES, 
                                                             FAVORITO, 
                                                             FOTO, 
                                                             ITEM_VENDA, 
                                                             DESCRICAO_VENDA, 
                                                             VALOR_UNITARIO_VENDA)
                                VALUES (@Descricao, 
                                        @CodBarras,
                                        @Garantia, 
                                        @Validade, 
                                        @IdUnidadeMedida, 
                                        @QtdMinima, 
                                        @Qtd, 
                                        @CustoUnitario, 
                                        @IdFabricante, 
                                        @IdCategoria, 
                                        @IdFornecedor, 
                                        @Observacoes, 
                                        @Favorito, 
                                        @Foto, 
                                        @ItemVenda, 
                                        @DescricaoVenda, 
                                        @VendaUnitario);
                                SELECT last_insert_rowid();";

                        item.Id = conn.ExecuteScalar<long>(sqlFornecedor, new
                        {
                            Descricao = item.Descricao, // Nome é obrigatório, não precisa de tratamento
                            CodBarras = string.IsNullOrWhiteSpace(item.CodBarras) ? (object)DBNull.Value : item.CodBarras,
                            Garantia = string.IsNullOrWhiteSpace(item.Garantia) ? (object)DBNull.Value : item.Garantia,
                            Validade = string.IsNullOrWhiteSpace(item.Validade) ? (object)DBNull.Value : item.Validade,
                            IdUnidadeMedida = item.UnidadeMedida, // Unidade de medida é obrigatório
                            QtdMinima = item.QuatidadeMinima > 0 ? item.QuatidadeMinima : (object)DBNull.Value,
                            Qtd = item.Quatidade > 0 ? item.Quatidade : (object)DBNull.Value,
                            CustoUnitario = string.IsNullOrWhiteSpace(item.CustoUnitario) ? (object)DBNull.Value : item.CustoUnitario,
                            IdFabricante = item.Fabricante > 0 ? item.Fabricante : (object)DBNull.Value,
                            IdCategoria = item.Categoria > 0 ? item.Categoria : (object)DBNull.Value,
                            IdFornecedor = item.Fornecedor > 0 ? item.Fornecedor : (object)DBNull.Value,
                            Observacoes = string.IsNullOrWhiteSpace(item.Observacoes) ? (object)DBNull.Value : item.Observacoes,
                            Favorito = item.Favorito == true ? true : false,
                            Foto = string.IsNullOrWhiteSpace(item.FotoItem) ? (object)DBNull.Value : item.FotoItem,
                            ItemVenda = item.ItemVenda == true ? true : false,
                            DescricaoVenda = string.IsNullOrWhiteSpace(item.DescricaoVenda) ? (object)DBNull.Value : item.DescricaoVenda,
                            VendaUnitario = string.IsNullOrWhiteSpace(item.VendaUnitario) ? (object)DBNull.Value : item.VendaUnitario
                        }, tran);

                        foreach (var comp in item.ComposicaoItem)
                        {
                            if (comp.Id == 0 && comp.IdItemComposicao > 0)
                            {
                                string sqlComp = @"
                                                    INSERT INTO GRC_COMPOSICAO
                                                    (IDGRC_ITEM_COMPOSTO, IDGRC_ITEM_COMPOSICAO)
                                                    VALUES (@IdItemComposto, @IdItemComposicao);";

                                conn.Execute(sqlComp, new
                                {
                                    IdItemComposto = item.Id,
                                    IdItemComposicao = comp.Id
                                }, tran);
                            }
                        }

                        tran.Commit();
                        return item.Id;

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

        public long AlteraItem(Item item)
        {
            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {

                        // Atualiza dados do item
                        var sqlUpdateFornecedor = @"
                                                    UPDATE GRC_ITEM_ESTOQUE
                                                    SET 
                                                    DESCRICAO = @Descricao,
                                                    CODIGO_BARRAS = @CodBarras, 
                                                    GARANTIA = @Garantia, 
                                                    VALIDADE = @Validade,
                                                    IDGRC_UNIDADE_MEDIDA = @IdUnidadeMedida,
                                                    QUANTIDADE_MINIMA = @QtdMinima,
                                                    QUANTIDADE = @Qtd,
                                                    CUSTO_UNITARIO = @CustoUnitario,
                                                    IDGRC_FABRICANTE = @IdFabricante, 
                                                    IDGRC_CATEGORIA = @IdCategoria,
                                                    IDGRC_FORNECEDOR = @IdFornecedor,
                                                    OBSERVACOES = @Observacoes, 
                                                    FAVORITO = @Favorito, 
                                                    FOTO = @Foto, 
                                                    ITEM_VENDA = @ItemVenda, 
                                                    DESCRICAO_VENDA = @DescricaoVenda, 
                                                    VALOR_UNITARIO_VENDA = @VendaUnitario, 
                                                    ATIVO = 1
                                                    WHERE IDGRC_ITEM_ESTOQUE = @Id";

                        conn.Execute(sqlUpdateFornecedor, new
                        {
                            Id = item.Id,
                            Descricao = item.Descricao, // Nome é obrigatório, não precisa de tratamento
                            CodBarras = string.IsNullOrWhiteSpace(item.CodBarras) ? (object)DBNull.Value : item.CodBarras,
                            Garantia = string.IsNullOrWhiteSpace(item.Garantia) ? (object)DBNull.Value : item.Garantia,
                            Validade = string.IsNullOrWhiteSpace(item.Validade) ? (object)DBNull.Value : item.Validade,
                            IdUnidadeMedida = item.UnidadeMedida, // Unidade de medida é obrigatório
                            QtdMinima = item.QuatidadeMinima > 0 ? item.QuatidadeMinima : (object)DBNull.Value,
                            Qtd = item.Quatidade > 0 ? item.Quatidade : (object)DBNull.Value,
                            CustoUnitario = string.IsNullOrWhiteSpace(item.CustoUnitario) ? (object)DBNull.Value : item.CustoUnitario,
                            IdFabricante = item.Fabricante > 0 ? item.Fabricante : (object)DBNull.Value,
                            IdCategoria = item.Categoria > 0 ? item.Categoria : (object)DBNull.Value,
                            IdFornecedor = item.Fornecedor > 0 ? item.Fornecedor : (object)DBNull.Value,
                            Observacoes = string.IsNullOrWhiteSpace(item.Observacoes) ? (object)DBNull.Value : item.Observacoes,
                            Favorito = item.Favorito == true ? true : false,
                            Foto = string.IsNullOrWhiteSpace(item.FotoItem) ? (object)DBNull.Value : item.FotoItem,
                            ItemVenda = item.ItemVenda == true ? true : false,
                            DescricaoVenda = string.IsNullOrWhiteSpace(item.DescricaoVenda) ? (object)DBNull.Value : item.DescricaoVenda,
                            VendaUnitario = string.IsNullOrWhiteSpace(item.VendaUnitario) ? (object)DBNull.Value : item.VendaUnitario
                        }, tran);

                        #region ... Composicao ...

                        // Telefones atuais no banco
                        var composicaoAtual = conn.Query<Composicao>(@"SELECT IDGRC_COMPOSICAO AS Id, 
                                                                              IDGRC_ITEM_COMPOSICAO AS ItemComposicao
                                                                     FROM GRC_COMPOSICAO 
                                                                     WHERE IDGRC_ITEM_COMPOSTO = @IdItemComposto AND ATIVO = 1",
                            new
                            {
                                IdItemComposto = item.Id
                            }, tran).ToList();

                        var composicaoForm = item.ComposicaoItem ?? new List<Composicao>();


                        // novos = os que vieram do grid e têm ID nulo ou zero
                        var novos = composicaoForm.Where(x => x.IdItemComposicao > 0 && x.Id == 0).ToList();

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
                                            INSERT INTO GRC_COMPOSICAO
                                            (IDGRC_ITEM_COMPOSTO, IDGRC_ITEM_COMPOSICAO)
                                            VALUES
                                            (@ItemComposto, @ItemComposicao)",
                                new
                                {
                                    ItemComposto = item.Id,
                                    ItemComposicao = comp.IdItemComposicao // cuidado: precisa existir no objeto
                                }, tran);
                        }

                        // ===========================================
                        // 2.2 INATIVAR COMPOSIÇÕES REMOVIDAS
                        // ===========================================
                        foreach (var comp in excluir)
                        {
                            conn.Execute(@"
                                            UPDATE GRC_COMPOSICAO
                                            SET ATIVO = 0
                                            WHERE IDGRC_COMPOSICAO = @Id",
                                new { Id = comp.Id }, tran);
                        }



                        #endregion
                        tran.Commit();
                        return item.Id;

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

        #region ..:: INATIVAÇÃO ::..
        public void InativaItem(long id)
        {
            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {

                        // Inativa fornecedor
                        conn.Execute(@"UPDATE GRC_ITEM_ESTOQUE
                               SET ATIVO = 0
                               WHERE IDGRC_ITEM_ESTOQUE = @Id",
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

        #endregion

        #region .....::::: PESQUISA :::::.....


        public List<Composicao> BuscaItemParaComposicao(Item item, int registros)
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                try
                {
                    var sql = new StringBuilder();
                    sql.Append(@"
                                    SELECT 
                                    CAST(IDGRC_ITEM_ESTOQUE AS INT) AS Id,
                                    DESCRICAO AS Descricao,
                                    CUSTO_UNITARIO AS CustoUnitario
                                    FROM GRC_ITEM_ESTOQUE
                                    WHERE 1 = 1 AND ATIVO = 1");

                    // Filtros dinâmicos
                    if (item.Id > 0)
                        sql.Append(" AND CAST(IDGRC_ITEM_ESTOQUE AS TEXT) LIKE @Id ");

                    if (!string.IsNullOrWhiteSpace(item.Descricao))
                        sql.Append(" AND DESCRICAO LIKE @Descricao ");

                    if (item.Categoria > 0)
                        sql.Append(" AND IDGRC_CATEGORIA = @Categoria ");

                    if (item.Fabricante > 0)
                        sql.Append(" AND IDGRC_FABRICANTE = @Fabricante ");

                    if (item.Fornecedor > 0)
                        sql.Append(" AND IDGRC_FORNECEDOR = @Fornecedor ");




                    sql.Append(" ORDER BY FAVORITO, DESCRICAO ASC LIMIT @Registros; ");

                    var lista = conn.Query(sql.ToString(), new
                    {
                        Id = $"%{item.Id}%",
                        Descricao = $"%{item.Descricao}%",
                        Categoria = item.Categoria > 0 ? item.Categoria : (object)DBNull.Value,
                        Fabricante = item.Fabricante > 0 ? item.Fabricante : (object)DBNull.Value,
                        Fornecedor = item.Fornecedor > 0 ? item.Fornecedor : (object)DBNull.Value,
                        Registros = registros
                    })
                    .Select(x => new Composicao
                    {
                        Id = (long)x.Id,
                        Descricao = x.Descricao,
                        Preco = x.CustoUnitario
                    }).ToList();

                    return lista;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao buscar fornecedores: " + ex.Message);
                }
            }
        }


        /// <summary>
        /// Busca os dados de fornecedor no banco apenas para exibir, sendo uma busca limitada
        /// </summary>
        /// <param name="fornecedor"> dados do fornecedor para busca</param>
        /// <param name="registros"> quantidade de registros a serem buscados</param>
        /// <returns>Retorna uma lista com dados do banco para preencher o datagrid</returns>
        public List<Item> BuscaLimitada(Item item, int registros)
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                try
                {
                    var sql = new StringBuilder();
                    sql.Append(@"SELECT 
                                        ITM.IDGRC_ITEM_ESTOQUE AS Id,
                                        ITM.DESCRICAO AS Descricao,
                                        ITM.CODIGO_BARRAS AS CodigoBarras,
                                        ITM.QUANTIDADE AS Quantidade,
                                        FCT.DESCRICAO AS Fabricante,
                                        FORN.DESCRICAO AS Fornecedor,
                                        CAT.DESCRICAO AS Categoria,
                                        ITM.FAVORITO AS Favorito,
                                        ITM.FOTO  AS Foto,
                                        ITM.ITEM_VENDA AS ItemVenda,
                                        ITM.ATIVO AS Ativo
                                FROM GRC_ITEM_ESTOQUE ITM
                                INNER JOIN GRC_TIPO FCT ON FCT.IDGRC_TIPO = ITM.IDGRC_FABRICANTE
                                                          AND FCT.IDGRC_SUBTIPO = 4
                                                          AND FCT.ATIVO = 1
                                INNER JOIN GRC_TIPO CAT ON CAT.IDGRC_TIPO = ITM.IDGRC_CATEGORIA
                                                          AND CAT.IDGRC_SUBTIPO = 1
                                                          AND CAT.ATIVO = 1
                                INNER JOIN GRC_FORNECEDOR FORN ON FORN.IDGRC_FORNECEDOR = ITM.IDGRC_FORNECEDOR
                                                                    AND FORN.ATIVO = 1
                                
    
                                WHERE 1 = 1 ");

                    // Filtros dinâmicos
                    if (item.Id > 0)
                        sql.Append(" AND ITM.IDGRC_ITEM_ESTOQUE = @Id ");

                    if (!string.IsNullOrWhiteSpace(item.CodBarras))
                        sql.Append(" AND ITM.CODIGO_BARRAS LIKE @CodBarras ");

                    if (!string.IsNullOrWhiteSpace(item.Descricao))
                        sql.Append(" AND ITM.DESCRICAO LIKE @Descricao ");

                    if (item.Categoria > 0)
                        sql.Append(" AND ITM.IDGRC_CATEGORIA = @Categoria ");

                    if (item.Fabricante > 0)
                        sql.Append(" AND ITM.IDGRC_FABRICANTE = @Fabricante ");

                    if (item.Fornecedor > 0)
                        sql.Append(" AND ITM.IDGRC_FORNECEDOR = @Fornecedor ");

                    if (item.Favorito)
                        sql.Append(" AND ITM.FAVORITO = @Favorito ");

                    if (item.ItemVenda)
                        sql.Append(" AND ITM.ITEM_VENDA = @ItemVenda ");

                    //if (!item.Ativo)
                    sql.Append(" AND ITM.ATIVO = @Ativo "); // se você permitir filtrar inativos

                    sql.Append(" ORDER BY ITM.FAVORITO, ITM.DESCRICAO ASC LIMIT @Registros; ");

                    var lista = conn.Query(sql.ToString(), new
                    {
                        Id = (int)item.Id,
                        CodBarras = $"%{item.CodBarras.ToString()}%",
                        Descricao = $"%{item.Descricao.ToString()}%",
                        Categoria = item.Categoria > 0 ? item.Categoria : 0,
                        Fabricante = item.Fabricante > 0 ? item.Fabricante : 0,
                        Fornecedor = item.Fornecedor > 0 ? item.Fornecedor : 0,
                        Favorito = item.Favorito == true ? 1 : 0,
                        ItemVenda = item.ItemVenda == true ? 1 : 0,
                        Ativo = item.Ativo == true ? 1 : 0,
                        Registros = registros
                    })
                    .Select(x => new Item
                    {
                        Id = Convert.ToInt64(x.Id),
                        Descricao = x.Descricao,
                        CodBarras = x.CodigoBarras,
                        Quatidade = (int)x.Quantidade,
                        DescricaoFabricante = x.Fabricante,
                        DescricaoFornecedor = x.Fornecedor,
                        DescricaoCategoria = x.Categoria,
                        Favorito = x.Favorito == 1 ? true : false,
                        FotoItem = x.Foto,
                        ItemVenda = x.ItemVenda == 1 ? true : false,
                        Ativo = x.Ativo == 1 ? true : false
                    }).ToList();

                    return lista;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao buscar itens do database: " + ex.Message);
                }
            }
        }
        public List<Item> BuscaCompleta(long id)
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                try
                {
                    // Query principal com LEFT JOIN para trazer endereço e email
                    var itens = conn.Query($@"
                                                        SELECT 
                                                        IDGRC_ITEM_ESTOQUE AS Id,
                                                        DESCRICAO AS Descricao,
                                                        CODIGO_BARRAS AS CodigoBarras,
                                                        GARANTIA AS Garantia,
                                                        VALIDADE AS Validade,
                                                        IDGRC_UNIDADE_MEDIDA AS UnidadeMedida,
                                                        QUANTIDADE_MINIMA AS QuantidadeMinima,
                                                        QUANTIDADE AS Quantidade,
                                                        CUSTO_UNITARIO AS CustoUnitario,
                                                        IDGRC_FABRICANTE  AS  Fabricante,
                                                        IDGRC_CATEGORIA AS Categoria,
                                                        IDGRC_FORNECEDOR  AS  Fornecedor,
                                                        OBSERVACOES AS Observacoes,
                                                        FAVORITO   AS Favorito,
                                                        FOTO   AS Foto,
                                                        ITEM_VENDA  AS ItemVenda,
                                                        DESCRICAO_VENDA AS DescricaoVenda,
                                                        VALOR_UNITARIO_VENDA   AS ValorVendaUnitario,
                                                        ATIVO AS Ativo 
                                                        FROM GRC_ITEM_ESTOQUE 
                                                        WHERE IDGRC_ITEM_ESTOQUE = @Id",
                                                        new { Id = id })
                    .Select(x => new Item
                    {
                        Id = (long)x.Id,
                        Descricao = x.Descricao,
                        CodBarras = x.CodigoBarras,
                        Garantia = x.Garantia,
                        Validade = x.Validade,
                        UnidadeMedida = (int)x.UnidadeMedida,
                        QuatidadeMinima = (int)x.QuantidadeMinima,
                        Quatidade = (int)x.Quantidade,
                        CustoUnitario = x.CustoUnitario,
                        Fabricante = (int)x.Fabricante,
                        Categoria = (int)x.Categoria,
                        Fornecedor = (int)x.Fornecedor,
                        Observacoes = x.Observacoes,
                        Favorito = Convert.ToBoolean(x.Favorito),
                        FotoItem = x.Foto,
                        ItemVenda = Convert.ToBoolean(x.ItemVenda),
                        DescricaoVenda = x.DescricaoVenda,
                        VendaUnitario = x.ValorVendaUnitario,
                        Ativo = Convert.ToBoolean(x.Ativo),

                        // Itens de composição podem ser preenchidos depois com outra query
                        ComposicaoItem = new List<Composicao>()
                    }).ToList();

                    if (itens.Count > 0)
                    {
                        foreach (var item in itens)
                        {
                            var composicoes = conn.Query($@"
                                                                SELECT 
                                                                        COMP.IDGRC_COMPOSICAO AS Id,
                                                                        COMP.IDGRC_ITEM_COMPOSICAO AS IdItemComposicao,
                                                                        ITM.DESCRICAO AS Descricao,
                                                                        ITM.CUSTO_UNITARIO AS CustoUnitario
                                                                FROM GRC_COMPOSICAO COMP
                                                                INNER JOIN GRC_ITEM_ESTOQUE ITM ON ITM.IDGRC_ITEM_ESTOQUE = COMP.IDGRC_ITEM_COMPOSICAO
                                                                WHERE COMP.ATIVO = 1 AND COMP.IDGRC_ITEM_COMPOSTO = @ItemCompostoId",
                                                new { ItemCompostoId = id }).ToList();

                            item.ComposicaoItem = composicoes.Select(c => new Composicao
                            {
                                Id = (long)c.Id,
                                IdItemComposicao = (long)c.IdItemComposicao,
                                Descricao = c.Descricao,
                                Preco = c.CustoUnitario
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
        public List<Item> BuscaTelaPesquisaBasica(Item item, int registros)
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                try
                {
                    var sql = new StringBuilder();
                    sql.Append(@"SELECT 
                                        ITM.IDGRC_ITEM_ESTOQUE AS Id,
                                        ITM.DESCRICAO AS Descricao,
                                        ITM.FOTO  AS Foto, 
                                        ITM.QUANTIDADE AS Qtd,
                                        ITM.CUSTO_UNITARIO AS Custo
                                FROM GRC_ITEM_ESTOQUE ITM                                
                                WHERE 1 = 1 AND ITM.ATIVO = 1");

                    // Filtros dinâmicos
                    if (item.Id > 0)
                        sql.Append(" AND ITM.IDGRC_ITEM_ESTOQUE = @Id ");

                    if (!string.IsNullOrWhiteSpace(item.Descricao))
                        sql.Append(" AND ITM.DESCRICAO LIKE @Descricao ");

                    sql.Append(" ORDER BY ITM.FAVORITO, ITM.DESCRICAO ASC LIMIT @Registros; ");

                    var lista = conn.Query(sql.ToString(), new
                    {
                        Id = (int)item.Id,
                        Descricao = $"%{item.Descricao.ToString()}%",
                        Registros = registros
                    })
                    .Select(x => new Item
                    {
                        Id = Convert.ToInt32(x.Id),
                        Descricao = x.Descricao,
                        FotoItem = x.Foto,
                        Quatidade = Convert.ToInt32(x.Qtd),
                        CustoUnitario = x.Custo
                    }).ToList();

                    return lista;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao buscar itens do database: " + ex.Message);
                }
            }
        }

        public List<Item> BuscaTelaPesquisaCompleta(int id)
        {

            using (var conn = new SQLiteConnection(_conn.GetConnections()))
            {
                conn.Open();
                try
                {
                    var sql = new StringBuilder();
                    sql.Append(@"SELECT 
                                        IDGRC_ITEM_ESTOQUE AS Id,
                                        DESCRICAO AS Descricao,
                                        QUANTIDADE  AS Quantidade,
                                        CUSTO_UNITARIO AS CustoUnitario,
                                        ITEM_VENDA AS ItemVenda,
                                        VALOR_UNITARIO_VENDA AS PrecoUnitario,
                                        FOTO AS Foto
                                FROM GRC_ITEM_ESTOQUE                               
                                WHERE ATIVO = 1 AND IDGRC_ITEM_ESTOQUE = @Id");
                    var lista = conn.Query(sql.ToString(), new
                    {
                        Id = id
                    })
                    .Select(x => new Item
                    {
                        Id = (int)x.Id,
                        Descricao = x.Descricao,
                        Quatidade = (int)x.Quantidade,
                        CustoUnitario = x.CustoUnitario,
                        ItemVenda = Convert.ToBoolean(x.ItemVenda),
                        VendaUnitario = x.PrecoUnitario,
                        FotoItem = x.Foto
                    }).ToList();

                    return lista;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao buscar itens do database: " + ex.Message);
                }
            }
            #endregion
        }
    }
}
