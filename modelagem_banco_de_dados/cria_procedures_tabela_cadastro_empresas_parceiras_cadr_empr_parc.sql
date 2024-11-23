/* 
Breve Descrição:
Este script SQL é utilizado para definir um conjunto de procedures no banco de dados `b_lumitemp_main_db`.
As procedures são responsáveis por operações como inserção, atualização, exclusão e consulta de registros
na tabela de empresas parceiras (`cadr_empr_parc`).
*/

---------------------------------------------------------------------

-- Define o banco de dados a ser utilizado
USE b_lumitemp_main_db

GO

---------------------------------------------------------------------

-- Exclui as procedures se já existirem para recriá-las
DROP PROCEDURE IF EXISTS spInsert_cadr_empr_parc
DROP PROCEDURE IF EXISTS spUpdate_cadr_empr_parc

GO

---------------------------------------------------------------------

-- Criação da procedure spInsert_cadr_empr_parc para inserir uma nova empresa parceira
CREATE PROCEDURE spInsert_cadr_empr_parc
(
    -- Declaração dos parâmetros que serão utilizados
    @ID INT,                               -- ID da empresa
    @NM_EMPR VARCHAR(30),                  -- Nome da empresa
    @CEP_EMPR VARCHAR(30),                 -- CEP da empresa
    @LOG_EMPR VARCHAR(30),                 -- Logradouro da empresa
    @NUM_EMPR VARCHAR(4),                  -- Número da empresa
    @COMPL_EMPR VARCHAR(30),               -- Complemento do endereço da empresa
    @BAIRRO_EMPR VARCHAR(20),              -- Bairro da empresa
    @CIDADE_EMPR VARCHAR(20),              -- Cidade da empresa
    @ESTADO_EMPR VARCHAR(2),               -- Estado da empresa
    @CNPJ_EMPR VARCHAR(15),                -- CNPJ da empresa
    @TELF_CONT_EMPR VARCHAR(10),           -- Telefone de contato da empresa
    @ID_FUNC INT                           -- ID do funcionário responsável pela empresa (chave estrangeira)
) 
AS
BEGIN
    -- Insere um novo registro na tabela 'cadr_empr_parc' com os dados informados
    INSERT INTO cadr_empr_parc
    (ID, NM_EMPR, CEP_EMPR, LOG_EMPR, NUM_EMPR, COMPL_EMPR, BAIRRO_EMPR, CIDADE_EMPR, ESTADO_EMPR, CNPJ_EMPR, TELF_CONT_EMPR, ID_FUNC)
    VALUES
    (@ID, @NM_EMPR, @CEP_EMPR, @LOG_EMPR, @NUM_EMPR, @COMPL_EMPR, @BAIRRO_EMPR, @CIDADE_EMPR, @ESTADO_EMPR, @CNPJ_EMPR, @TELF_CONT_EMPR, @ID_FUNC)
END

GO

---------------------------------------------------------------------

-- Criação da procedure spUpdate_cadr_empr_parc para alterar os dados de uma empresa existente
CREATE PROCEDURE spUpdate_cadr_empr_parc
(
    -- Declaração dos parâmetros que serão utilizados
    @ID INT,                               -- ID da empresa
    @NM_EMPR VARCHAR(30),                  -- Nome da empresa
    @CEP_EMPR VARCHAR(30),                 -- CEP da empresa
    @LOG_EMPR VARCHAR(30),                 -- Logradouro da empresa
    @NUM_EMPR VARCHAR(4),                  -- Número da empresa
    @COMPL_EMPR VARCHAR(30),               -- Complemento do endereço da empresa
    @BAIRRO_EMPR VARCHAR(20),              -- Bairro da empresa
    @CIDADE_EMPR VARCHAR(20),              -- Cidade da empresa
    @ESTADO_EMPR VARCHAR(2),               -- Estado da empresa
    @CNPJ_EMPR VARCHAR(15),                -- CNPJ da empresa
    @TELF_CONT_EMPR VARCHAR(11),           -- Telefone de contato da empresa
    @ID_FUNC INT                           -- ID do funcionário responsável pela empresa (chave estrangeira)
) 
AS
BEGIN
    -- Atualiza o registro da empresa na tabela 'cadr_empr_parc' com os novos dados
    UPDATE cadr_empr_parc SET
        NM_EMPR = @NM_EMPR,                -- Nome da empresa
        CEP_EMPR = @CEP_EMPR,              -- CEP da empresa
        LOG_EMPR = @LOG_EMPR,              -- Logradouro da empresa
        NUM_EMPR = @NUM_EMPR,              -- Número da empresa
        COMPL_EMPR = @COMPL_EMPR,          -- Complemento do endereço da empresa
        BAIRRO_EMPR = @BAIRRO_EMPR,        -- Bairro da empresa
        CIDADE_EMPR = @CIDADE_EMPR,        -- Cidade da empresa
        ESTADO_EMPR = @ESTADO_EMPR,        -- Estado da empresa
        CNPJ_EMPR = @CNPJ_EMPR,            -- CNPJ da empresa
        TELF_CONT_EMPR = @TELF_CONT_EMPR,  -- Telefone de contato da empresa
        ID_FUNC = @ID_FUNC                 -- ID do funcionário responsável pela empresa
    WHERE ID = @ID                         -- Condição para identificar a empresa a ser atualizada
END
GO
