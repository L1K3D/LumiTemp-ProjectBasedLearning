/*RESUMO*/
/*Esse c�digo cria uma s�rie de procedures para gerenciar uma tabela de 
empresas parceiras (cadr_empr_parc). Ele inclui fun��es para inserir 
novos registros de empresas, atualizar dados existentes, excluir registros, 
consultar empresas espec�ficas por ID e listar todas as empresas cadastradas. 
Al�m disso, h� uma procedure para obter o pr�ximo ID dispon�vel em uma tabela 
especificada, garantindo a gera��o de identificadores �nicos para novos registros.*/

---------------------------------------------------------------------

-- Define o banco de dados a ser utilizado
USE b_lumitemp_main_db

GO

---------------------------------------------------------------------

-- Exclui as procedures se j� existirem para recri�-las
DROP PROCEDURE spInsert_cadr_empr_parc
DROP PROCEDURE spUpdate_cadr_empr_parc

GO

---------------------------------------------------------------------

-- Cria��o da procedure spIncluiFuncionario para inserir um novo funcion�rio
CREATE PROCEDURE spInsert_cadr_empr_parc
(
    -- Declara��o dos par�metros que ser�o utilizados
    @ID INT,                               -- ID da empresa
    @NM_EMPR VARCHAR(30),                  -- Nome da empresa
    @CEP_EMPR VARCHAR(30),                 -- CEP da empresa
	@LOG_EMPR VARCHAR(30),                 -- LOGRADOURO da empresa 
	@NUM_EMPR VARCHAR(4),				   -- N�MERO da empresa
	@COMPL_EMPR VARCHAR (30),              -- COMPLEMENTO da empresa
	@BAIRRO_EMPR VARCHAR (20),             -- BAIRRO da empresa
	@CIDADE_EMPR VARCHAR (20),             -- CIDADE da empresa 
	@ESTADO_EMPR VARCHAR (2),			   -- ESTADO da empresa
    @CNPJ_EMPR VARCHAR(15),                -- CNPJ da empresa
    @TELF_CONT_EMPR VARCHAR(10),           -- Telefone de contato da empresa
    @ID_FUNC INT                           -- ID do funcion�rio respons�vel pela empresa (chave estrangeira)
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

-- Cria��o da procedure spAlteraEmpresa para alterar os dados de uma empresa existente
CREATE PROCEDURE spUpdate_cadr_empr_parc
(
    -- Declara��o dos par�metros que ser�o utilizados
    @ID INT,                               -- ID da empresa
    @NM_EMPR VARCHAR(30),                  -- Nome da empresa
    @CEP_EMPR VARCHAR(30),                 -- CEP da empresa
	@LOG_EMPR VARCHAR(30),                 -- LOGRADOURO da empresa 
	@NUM_EMPR VARCHAR(4),				   -- N�MERO da empresa
	@COMPL_EMPR VARCHAR (30),              -- COMPLEMENTO da empresa
	@BAIRRO_EMPR VARCHAR (20),             -- BAIRRO da empresa
	@CIDADE_EMPR VARCHAR (20),             -- CIDADE da empresa 
	@ESTADO_EMPR VARCHAR (2),			   -- ESTADO da empresa
    @CNPJ_EMPR VARCHAR(15),                -- CNPJ da empresa
    @TELF_CONT_EMPR VARCHAR(11),           -- Telefone de contato da empresa
    @ID_FUNC INT                           -- ID do funcion�rio respons�vel pela empresa
) 
AS
BEGIN
    -- Atualiza o registro da empresa na tabela 'cadr_empr_parc' com os novos dados
    UPDATE cadr_empr_parc SET
		NM_EMPR = @NM_EMPR,                    -- Nome da empresa
		CEP_EMPR = @CEP_EMPR,                  -- CEP da empresa
		LOG_EMPR = @LOG_EMPR,                  -- LOGRADOURO da empresa 
		NUM_EMPR = @NUM_EMPR,				   -- N�MERO da empresa
		COMPL_EMPR = @COMPL_EMPR,              -- COMPLEMENTO da empresa
		BAIRRO_EMPR = @BAIRRO_EMPR,            -- BAIRRO da empresa
		CIDADE_EMPR = @CIDADE_EMPR,            -- CIDADE da empresa 
		ESTADO_EMPR = @ESTADO_EMPR,			   -- ESTADO da empresa
		CNPJ_EMPR = @CNPJ_EMPR,                -- CNPJ da empresa
		TELF_CONT_EMPR = @TELF_CONT_EMPR,      -- Telefone de contato da empresa
		ID_FUNC = @ID_FUNC                     -- ID do funcion�rio respons�vel pela empresa
		WHERE ID = @ID                         -- Condi��o para identificar qual empresa ser� atualizada
END
GO