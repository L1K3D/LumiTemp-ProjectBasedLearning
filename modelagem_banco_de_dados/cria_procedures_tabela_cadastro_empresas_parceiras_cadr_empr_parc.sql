/*RESUMO*/
/*Esse código cria uma série de procedures para gerenciar uma tabela de 
empresas parceiras (cadr_empr_parc). Ele inclui funções para inserir 
novos registros de empresas, atualizar dados existentes, excluir registros, 
consultar empresas específicas por ID e listar todas as empresas cadastradas. 
Além disso, há uma procedure para obter o próximo ID disponível em uma tabela 
especificada, garantindo a geração de identificadores únicos para novos registros.*/

---------------------------------------------------------------------

-- Define o banco de dados a ser utilizado
USE b_lumitemp_main_db

GO

---------------------------------------------------------------------

-- Exclui as procedures se já existirem para recriá-las
DROP PROCEDURE spInsert_cadr_empr_parc
DROP PROCEDURE spUpdate_cadr_empr_parc

GO

---------------------------------------------------------------------

-- Criação da procedure spIncluiFuncionario para inserir um novo funcionário
CREATE PROCEDURE spInsert_cadr_empr_parc
(
    -- Declaração dos parâmetros que serão utilizados
    @ID INT,                               -- ID da empresa
    @NM_EMPR VARCHAR(30),                  -- Nome da empresa
    @CEP_EMPR VARCHAR(30),                 -- CEP da empresa
    @CNPJ_EMPR VARCHAR(15),                -- CNPJ da empresa
    @TELF_CONT_EMPR VARCHAR(10),           -- Telefone de contato da empresa
    @ID_FUNC INT                           -- ID do funcionário responsável pela empresa (chave estrangeira)
) 
AS
BEGIN
    -- Insere um novo registro na tabela 'cadr_empr_parc' com os dados informados
    INSERT INTO cadr_empr_parc
    (ID, NM_EMPR, CEP_EMPR, CNPJ_EMPR, TELF_CONT_EMPR, ID_FUNC)
    VALUES
    (@ID, @NM_EMPR, @CEP_EMPR, @CNPJ_EMPR, @TELF_CONT_EMPR, @ID_FUNC)
END

GO

---------------------------------------------------------------------

-- Criação da procedure spAlteraEmpresa para alterar os dados de uma empresa existente
CREATE PROCEDURE spUpdate_cadr_empr_parc
(
    -- Declaração dos parâmetros que serão utilizados
    @ID INT,                               -- ID da empresa
    @NM_EMPR VARCHAR(30),                  -- Nome da empresa
    @CEP_EMPR VARCHAR(30),                 -- CEP da empresa
    @CNPJ_EMPR VARCHAR(15),                -- CNPJ da empresa
    @TELF_CONT_EMPR VARCHAR(11),           -- Telefone de contato da empresa
    @ID_FUNC INT                           -- ID do funcionário responsável pela empresa
) 
AS
BEGIN
    -- Atualiza o registro da empresa na tabela 'cadr_empr_parc' com os novos dados
    UPDATE cadr_empr_parc SET
		NM_EMPR = @NM_EMPR,                    -- Nome da empresa
		CEP_EMPR = @CEP_EMPR,                  -- CEP da empresa
		CNPJ_EMPR = @CNPJ_EMPR,                -- CNPJ da empresa
		TELF_CONT_EMPR = @TELF_CONT_EMPR,      -- Telefone de contato da empresa
		ID_FUNC = @ID_FUNC                     -- ID do funcionário responsável pela empresa
		WHERE ID = @ID                         -- Condição para identificar qual empresa será atualizada
END
GO