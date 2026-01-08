using System;
using System.IO;
using Dapper;
using Microsoft.Data.Sqlite;
using SQLitePCL;

namespace Business.Helper
{
    public class CriacaoBanco
    {
        public void VerificaBanco()
        {
             string SQL_CRIACAO =
@"

CREATE TABLE GRC_USUARIO (
    IDGRC_USUARIO INTEGER PRIMARY KEY AUTOINCREMENT,
    NOME TEXT NOT NULL,
    USUARIO TEXT NOT NULL, -- número
    SENHA TEXT NOT NULL,
    ATIVO INTEGER DEFAULT 1
);


INSERT INTO GRC_USUARIO (
                            NOME,
                            USUARIO,
                            SENHA
                        )
                        VALUES (
                            'Rayner Bryan',
                            'raynerb',
                            '1234'
                        ),
                         (
                            'Dev',
                            'dev',
                            '123'
                        );

-- ===========================================================
-- 🧱 GRC_EMAIL
-- ===========================================================
CREATE TABLE GRC_EMAIL (
    IDGRC_EMAIL INTEGER PRIMARY KEY AUTOINCREMENT,
    EMAIL TEXT NOT NULL,
    OBSERVACOES TEXT NULL,
    ATIVO INTEGER DEFAULT 1
);


-- ===========================================================
-- 🧱 GRC_ENDERECO
-- ===========================================================
CREATE TABLE GRC_ENDERECO (
    IDGRC_ENDERECO INTEGER PRIMARY KEY AUTOINCREMENT,
    CEP TEXT,
    LOGRADOURO TEXT NOT NULL,
    NUMERO TEXT NULL,
    BAIRRO TEXT NULL,
    CIDADE TEXT NULL,
    UF TEXT NULL,
    COMPLEMENTO TEXT NULL,
    OBSERVACOES TEXT NULL,
    ATIVO INTEGER DEFAULT 1
);

-- ===========================================================
-- 🧱 GRC_FORNECEDOR
-- ===========================================================
CREATE TABLE GRC_FORNECEDOR (
    IDGRC_FORNECEDOR INTEGER PRIMARY KEY AUTOINCREMENT,
    DESCRICAO TEXT NOT NULL,
    RAZAO_SOCIAL TEXT NULL,
    INSCRICAO_ESTADUAL TEXT NULL,
    CNPJ TEXT NULL,
    IDGRC_EMAIL INTEGER NULL,
    IDGRC_ENDERECO INTEGER NULL,
    OBSERVACOES TEXT NULL,
    ATIVO INTEGER DEFAULT 1,
    FOREIGN KEY (IDGRC_EMAIL) REFERENCES GRC_EMAIL(IDGRC_EMAIL),
    FOREIGN KEY (IDGRC_ENDERECO) REFERENCES GRC_ENDERECO(IDGRC_ENDERECO)
);

-- ===========================================================
-- 🧱 GRC_TELEFONE_FORNECEDOR
-- ===========================================================
CREATE TABLE GRC_TELEFONE_FORNECEDOR (
    IDGRC_TELEFONE_FORNECEDOR INTEGER PRIMARY KEY AUTOINCREMENT,
    IDGRC_FORNECEDOR INTEGER NOT NULL,
    DESCRICAO TEXT NOT NULL, -- número
    WHATSAPP INTEGER DEFAULT 0,
    OBSERVACOES TEXT NULL,
    ATIVO INTEGER DEFAULT 1,
    FOREIGN KEY (IDGRC_FORNECEDOR) REFERENCES GRC_FORNECEDOR (IDGRC_FORNECEDOR)
);

-- ===========================================================
-- 🧱 GRC_SUBTIPO
-- ===========================================================
CREATE TABLE GRC_SUBTIPO (
    IDGRC_SUBTIPO INTEGER PRIMARY KEY AUTOINCREMENT,
    DESCRICAO TEXT NOT NULL,
    ATIVO INTEGER DEFAULT 1
);

INSERT INTO GRC_SUBTIPO (DESCRICAO) VALUES ('Categoria de Item'), ('Tipo de Movimentação'), ('Unidade de Medida'), ('Fabricante'), ('Tipo de Cliente'), ('Tipo de Relatório');


-- ===========================================================
-- 🧱 GRC_TIPO
-- ===========================================================
CREATE TABLE GRC_TIPO (
    IDGRC_TIPO INTEGER PRIMARY KEY AUTOINCREMENT,
    DESCRICAO TEXT NOT NULL,
    IDGRC_SUBTIPO INTEGER NOT NULL,
    ATIVO INTEGER DEFAULT 1,
    FOREIGN KEY (IDGRC_SUBTIPO) REFERENCES GRC_SUBTIPO (IDGRC_SUBTIPO)
);

INSERT INTO GRC_TIPO (DESCRICAO, IDGRC_SUBTIPO) VALUES ('Entrada', 2), ('Saída', 2), ('Desperdício', 2), ('Venda', 2);

                                     
CREATE TABLE GRC_ITEM_ESTOQUE 
(
    IDGRC_ITEM_ESTOQUE INTEGER PRIMARY KEY AUTOINCREMENT,
    DESCRICAO TEXT NOT NULL,
    CODIGO_BARRAS TEXT NULL,
    GARANTIA TEXT NULL,
    VALIDADE TEXT NULL,
    IDGRC_UNIDADE_MEDIDA INTEGER NOT NULL,
    QUANTIDADE_MINIMA INTEGER,
    QUANTIDADE INTEGER,
    CUSTO_UNITARIO TEXT,
    IDGRC_FABRICANTE INTEGER NOT NULL,
    IDGRC_CATEGORIA  INTEGER NOT NULL,
    IDGRC_FORNECEDOR INTEGER NOT NULL,
    OBSERVACOES TEXT NULL,
    FAVORITO INTEGER NOT NULL,
    FOTO TEXT NULL,
    ITEM_VENDA INTEGER NOT NULL,
    DESCRICAO_VENDA TEXT NULL,
    VALOR_UNITARIO_VENDA TEXT NULL,
    ATIVO INTEGER NOT NULL DEFAULT(1),
    DATA_CRIACAO TEXT DEFAULT(DATE('now')),
    FOREIGN KEY(IDGRC_UNIDADE_MEDIDA) REFERENCES GRC_TIPO(IDGRC_TIPO)
    FOREIGN KEY(IDGRC_FABRICANTE) REFERENCES GRC_TIPO(IDGRC_TIPO)
    FOREIGN KEY(IDGRC_CATEGORIA) REFERENCES GRC_TIPO(IDGRC_TIPO)
    FOREIGN KEY(IDGRC_FORNECEDOR) REFERENCES GRC_FORNECEDOR(IDGRC_FORNECEDOR)
); 
CREATE TABLE GRC_COMPOSICAO
(
    IDGRC_COMPOSICAO INTEGER PRIMARY KEY AUTOINCREMENT,
    IDGRC_ITEM_COMPOSTO INTEGER,
    IDGRC_ITEM_COMPOSICAO INTEGER,
    ATIVO INTEGER NOT NULL DEFAULT(1),
    FOREIGN KEY(IDGRC_ITEM_COMPOSTO) REFERENCES GRC_ITEM_ESTOQUE(IDGRC_ITEM_ESTOQUE)
    FOREIGN KEY(IDGRC_ITEM_COMPOSICAO) REFERENCES GRC_ITEM_ESTOQUE(IDGRC_ITEM_ESTOQUE)
);
-- ===========================================================
-- 🧱 GRC_ITEM_MOVIMENTACAO  
-- ===========================================================
CREATE TABLE GRC_ITEM_MOVIMENTACAO (

    IDGRC_ITEM_MOVIMENTACAO INTEGER PRIMARY KEY AUTOINCREMENT,
    IDGRC_ITEM_ESTOQUE INTEGER NOT NULL,
    IDGRC_TIPO_MOVIMENTACAO INTEGER NOT NULL,
    MOTIVO TEXT,
    QUANTIDADE INTEGER NOT NULL,
    CUSTO_UNITARIO TEXT NULL,
    OBSERVACOES TEXT NULL,
    DATA_MOVIMENTACAO TEXT NOT NULL DEFAULT (datetime('now')),
    DATA_REAL TEXT NOT NULL DEFAULT (datetime('now')),
    BLOQUEADA INTEGER NOT NULL DEFAULT 0, 
    ATIVO INTEGER NOT NULL DEFAULT 1,  
    FOREIGN KEY (IDGRC_ITEM_ESTOQUE) REFERENCES GRC_ITEM_ESTOQUE(IDGRC_ITEM_ESTOQUE),
    FOREIGN KEY (IDGRC_TIPO_MOVIMENTACAO) REFERENCES GRC_TIPO(IDGRC_TIPO)
);

-- ===========================================================
-- 🧱 GRC_CLIENTE
-- ===========================================================
CREATE TABLE GRC_CLIENTE (
    IDGRC_CLIENTE INTEGER PRIMARY KEY AUTOINCREMENT,
    NOME TEXT NOT NULL,
    IDGRC_TIPO_PESSOA INTEGER,
    IDENTIFICACAO TEXT NULL,
    IDGRC_EMAIL INTEGER NULL,
    IDGRC_ENDERECO INTEGER NULL,
    OBSERVACOES TEXT NULL,
    ATIVO INTEGER DEFAULT 1,
    FOREIGN KEY (IDGRC_EMAIL) REFERENCES GRC_EMAIL(IDGRC_EMAIL),
    FOREIGN KEY (IDGRC_ENDERECO) REFERENCES GRC_ENDERECO(IDGRC_ENDERECO)
);

-- ===========================================================
-- 🧱 GRC_TELEFONE_CLIENTE
-- ===========================================================
CREATE TABLE GRC_TELEFONE_CLIENTE (
    IDGRC_TELEFONE_CLIENTE INTEGER PRIMARY KEY AUTOINCREMENT,
    IDGRC_CLIENTE INTEGER NOT NULL,
    DESCRICAO TEXT NOT NULL, -- número
    WHATSAPP INTEGER DEFAULT 0,
    OBSERVACOES TEXT NULL,
    ATIVO INTEGER DEFAULT 1,
    FOREIGN KEY (IDGRC_CLIENTE) REFERENCES GRC_CLIENTE (IDGRC_CLIENTE)
);




-- ===========================================================
--  GRC_ITEM_MOVIMENTACAO   - TRIGGERS 
-- ===========================================================

-- Entradas

CREATE TRIGGER IF NOT EXISTS TRG_MOV_ENTRADA_INSERT
AFTER INSERT ON GRC_ITEM_MOVIMENTACAO
WHEN NEW.IDGRC_TIPO_MOVIMENTACAO = 1  
     AND NEW.ATIVO = 1
BEGIN
    UPDATE GRC_ITEM_ESTOQUE
    SET
        CUSTO_UNITARIO = 
        REPLACE(
            printf(
                'R$ %.2f',
                (
                    (
                        -- (quantidade atual * custo atual)
                        (QUANTIDADE * CAST(
                            REPLACE(REPLACE(CUSTO_UNITARIO, 'R$', ''), ',', '.') AS REAL
                        ))
                        +
                        -- (quantidade nova * custo novo)
                        (NEW.QUANTIDADE * CAST(
                            REPLACE(REPLACE(NEW.CUSTO_UNITARIO, 'R$', ''), ',', '.') AS REAL
                        ))
                    )
                    /
                    (QUANTIDADE + NEW.QUANTIDADE)
                )
            ),
            '.', ','
        ),
        QUANTIDADE = QUANTIDADE + NEW.QUANTIDADE
    WHERE IDGRC_ITEM_ESTOQUE = NEW.IDGRC_ITEM_ESTOQUE;
END;


-- Demais saídas

CREATE TRIGGER TRG_MOV_SAIDA_INSERT
AFTER INSERT ON GRC_ITEM_MOVIMENTACAO
WHEN NEW.IDGRC_TIPO_MOVIMENTACAO IN (2, 3, 4)
 AND NEW.ATIVO = 1
BEGIN
    UPDATE GRC_ITEM_ESTOQUE
    SET
        QUANTIDADE = QUANTIDADE - NEW.QUANTIDADE
    WHERE IDGRC_ITEM_ESTOQUE = NEW.IDGRC_ITEM_ESTOQUE;
END;


-- Ao excluir a entrada 

CREATE TRIGGER TRG_MOV_ENTRADA_DELETE
AFTER UPDATE ON GRC_ITEM_MOVIMENTACAO
WHEN OLD.IDGRC_TIPO_MOVIMENTACAO = 1
 AND OLD.ATIVO = 1
 AND NEW.ATIVO = 0
BEGIN
    UPDATE GRC_ITEM_ESTOQUE
    SET
        QUANTIDADE = QUANTIDADE - OLD.QUANTIDADE,

        CUSTO_UNITARIO =
        CASE 
            WHEN (QUANTIDADE - OLD.QUANTIDADE) <= 0 THEN 'R$ 0,00'
            ELSE
                'R$ ' || 
                REPLACE(
                    printf('%.2f',
                        (
                            (
                                (CAST(REPLACE(REPLACE(CUSTO_UNITARIO, 'R$', ''), ',', '.') AS REAL) * QUANTIDADE)
                                -
                                (CAST(REPLACE(REPLACE(OLD.CUSTO_UNITARIO, 'R$', ''), ',', '.') AS REAL) * OLD.QUANTIDADE)
                            )
                            /
                            (QUANTIDADE - OLD.QUANTIDADE)
                        )
                    ),
                '.', ',')
        END
    WHERE IDGRC_ITEM_ESTOQUE = OLD.IDGRC_ITEM_ESTOQUE
      AND ATIVO = 1;
END;

-- Ao excluir a saída

CREATE TRIGGER TRG_MOV_SAIDA_DELETE
AFTER UPDATE ON GRC_ITEM_MOVIMENTACAO
WHEN OLD.IDGRC_TIPO_MOVIMENTACAO IN (2, 3, 4)
 AND OLD.ATIVO = 1
 AND NEW.ATIVO = 0
BEGIN
    UPDATE GRC_ITEM_ESTOQUE
    SET
        QUANTIDADE = QUANTIDADE + OLD.QUANTIDADE
    WHERE IDGRC_ITEM_ESTOQUE = OLD.IDGRC_ITEM_ESTOQUE;
END;


-- trigger de validação - aborta caso seja notado que o insert vai deixar o estoque negativo

CREATE TRIGGER TRG_VALIDA_SAIDA
BEFORE INSERT ON GRC_ITEM_MOVIMENTACAO
WHEN NEW.IDGRC_TIPO_MOVIMENTACAO IN (2,3,4) -- Saída, Desperdício, Venda
BEGIN
    SELECT
        CASE
            WHEN (
                SELECT QUANTIDADE
                FROM GRC_ITEM_ESTOQUE
                WHERE IDGRC_ITEM_ESTOQUE = NEW.IDGRC_ITEM_ESTOQUE
                  AND ATIVO = 1
            ) < NEW.QUANTIDADE
            THEN RAISE(ABORT, 'Estoque insuficiente')
        END;
END;";
        Batteries.Init();

            string caminhoBanco = Path.Combine("C:\\GRC\\Databases", "rf_db.db");
            var pasta = Path.GetDirectoryName(caminhoBanco);

            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            bool bancoNovo = !File.Exists(caminhoBanco);

            using (var conn = new SqliteConnection($"Data Source={caminhoBanco}"))
            {
                conn.Open();

                if (bancoNovo)
                {
                    conn.Execute("PRAGMA foreign_keys = ON;");
                    conn.Execute(SQL_CRIACAO);
                }
            }
        }
    }
}
