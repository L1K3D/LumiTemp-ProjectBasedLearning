/*RESUMO*/
/*O c�digo define e recria procedures no banco de dados `b_lumitemp_main_db` para gerenciar registros 
da tabela de funcion�rios. As procedures incluem inser��o de novos funcion�rios (`spIncluiFuncionario`), 
atualiza��o de informa��es existentes (`spAlteraFuncionario`), exclus�o de registros (`spExcluiFuncionario`), 
consulta de um funcion�rio espec�fico por ID (`spConsultaFuncionario`), listagem de todos os funcion�rios (`spListagemFuncionario`) 
e obten��o do pr�ximo ID dispon�vel em uma tabela espec�fica (`spProximoId`).*/

---------------------------------------------------------------------

-- Define o banco de dados a ser utilizado
USE b_lumitemp_main_db

GO

---------------------------------------------------------------------

-- Exclui as procedures se j� existirem para recri�-las
DROP PROCEDURE spInsert_cadr_func
DROP PROCEDURE spUpdate_cadr_func

GO

---------------------------------------------------------------------

-- Cria��o da procedure spIncluiFuncionario para inserir um novo funcion�rio
CREATE PROCEDURE spInsert_cadr_func
(
    -- Declara��o dos par�metros que ser�o utilizados
    @ID INT,                               -- ID do funcion�rio
    @LOGIN_FUNC VARCHAR(30),               -- Login do funcion�rio
    @SENHA_FUNC VARCHAR(30),               -- Senha do funcion�rio
    @DT_CADR DATE                          -- Data de cadastro
) 
AS
BEGIN
    -- Insere um novo registro na tabela 'cadr_func' com os dados informados
    INSERT INTO cadr_func
		(ID, LOGIN_FUNC, SENHA_FUNC, DT_CADR)
    VALUES
		(@ID, @LOGIN_FUNC, @SENHA_FUNC, @DT_CADR)
END
GO

---------------------------------------------------------------------

-- Cria��o da procedure spAlteraFuncionario para alterar os dados de um funcion�rio existente
CREATE PROCEDURE spUpdate_cadr_func
(
    -- Declara��o dos par�metros que ser�o utilizados
    @ID INT,                               -- ID do funcion�rio
    @LOGIN_FUNC VARCHAR(30),               -- Login do funcion�rio
    @SENHA_FUNC VARCHAR(30),               -- Senha do funcion�rio
    @DT_CADR DATE                          -- Data de cadastro
) 
AS
BEGIN
    -- Atualiza o registro do funcion�rio na tabela 'cadr_func' com os novos dados
    UPDATE cadr_func SET
        ID = @ID,
        LOGIN_FUNC = @LOGIN_FUNC,
        SENHA_FUNC = @SENHA_FUNC,
        DT_CADR = @DT_CADR
    WHERE ID = @ID                         -- Condi��o para identificar qual funcion�rio ser� atualizado
END
GO