/*RESUMO*/
/*O c�digo define e recria procedures no banco de dados `b_lumitemp_main_db` para gerenciar registros 
da tabela de funcion�rios. As procedures incluem inser��o de novos funcion�rios (`spIncluiFuncionario`), 
atualiza��o de informa��es existentes (`spAlteraFuncionario`), exclus�o de registros (`spExcluiFuncionario`), 
consulta de um funcion�rio espec�fico por ID (`spConsultaFuncionario`), listagem de todos os funcion�rios (`spListagemFuncionario`) 
e obten��o do pr�ximo ID dispon�vel em uma tabela espec�fica (`spProximoId`).*/

---------------------------------------------------------------------

-- Define o banco de dados a ser utilizado
USE b_lumitemp_main_db

---------------------------------------------------------------------

-- Exclui as procedures se j� existirem para recri�-las
DROP PROCEDURE spIncluiFuncionario;
DROP PROCEDURE spAlteraFuncionario;
DROP PROCEDURE spExcluiFuncionario;
DROP PROCEDURE spConsultaFuncionario;
DROP PROCEDURE spListagemFuncionario;
DROP PROCEDURE spProximoId;

---------------------------------------------------------------------

-- Cria��o da procedure spIncluiFuncionario para inserir um novo funcion�rio
CREATE PROCEDURE spIncluiFuncionario
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
CREATE PROCEDURE spAlteraFuncionario
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

---------------------------------------------------------------------

-- Cria��o da procedure spExcluiFuncionario para excluir um funcion�rio
/*CREATE PROCEDURE spExcluiFuncionario
(
    -- Declara��o do par�metro que ser� utilizado
    @ID INT                                -- ID do funcion�rio a ser exclu�do
)
AS
BEGIN
    -- Exclui o registro do funcion�rio com base no ID informado
    DELETE cadr_func WHERE ID = @ID
END
GO

---------------------------------------------------------------------

-- Cria��o da procedure spConsultaFuncionario para consultar os dados de um funcion�rio espec�fico
CREATE PROCEDURE spConsultaFuncionario
(
    -- Declara��o do par�metro que ser� utilizado
    @ID INT                                -- ID do funcion�rio a ser consultado
) 
AS
BEGIN
    -- Seleciona todos os dados do funcion�rio com o ID informado
    SELECT * FROM cadr_func WHERE ID = @ID
END
GO

---------------------------------------------------------------------

-- Cria��o da procedure spListagemFuncionario para listar todos os funcion�rios
CREATE PROCEDURE spListagemFuncionario
AS
BEGIN
    -- Seleciona todos os registros da tabela 'cadr_func'
    SELECT * FROM cadr_func
END
GO

---------------------------------------------------------------------

-- Cria��o da procedure spProximoId para obter o pr�ximo ID dispon�vel em uma tabela
CREATE PROCEDURE spProximoId
(
    -- Declara��o do par�metro que ser� utilizado
    @tabela VARCHAR(MAX)                   -- Nome da tabela onde ser� pesquisado o pr�ximo ID
)
AS
BEGIN
    -- Executa uma consulta din�mica para encontrar o maior ID + 1 na tabela especificada
    EXEC ('SELECT ISNULL(MAX(ID) + 1, 1) AS MAIOR FROM ' + @tabela)
END
GO*/