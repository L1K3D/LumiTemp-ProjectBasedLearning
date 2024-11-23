/* 
Breve Descri��o:
Este script SQL � utilizado para definir e recriar procedures no banco de dados `b_lumitemp_main_db`.
As procedures s�o respons�veis por opera��es como exclus�o de registros pelo ID, consulta de registros pelo ID, 
listagem de registros ordenados por um campo espec�fico e obten��o do pr�ximo ID dispon�vel na tabela.
*/

---------------------------------------------------------------------

-- Seleciona o banco de dados a ser utilizado
USE b_lumitemp_main_db

GO

---------------------------------------------------------------------

-- Exclui as procedures se j� existirem para recri�-las
DROP PROCEDURE IF EXISTS spDelete
DROP PROCEDURE IF EXISTS spConsulta
DROP PROCEDURE IF EXISTS spListagem
DROP PROCEDURE IF EXISTS spProximoId

GO

---------------------------------------------------------------------

-- Cria��o da procedure spDelete para deletar um registro baseado no ID
CREATE PROCEDURE spDelete
(
    -- Declara��o dos par�metros que ser�o utilizados
    @ID INT,                               -- ID do registro a ser deletado
    @tabela VARCHAR(MAX)                   -- Nome da tabela onde o registro ser� deletado
)
AS
BEGIN
    -- Declarar a vari�vel para armazenar a consulta SQL
    DECLARE @sql VARCHAR(MAX);
    -- Montar a consulta SQL para deletar o registro pelo ID
    SET @sql = 'DELETE FROM ' + @tabela +
               ' WHERE ID = ' + CAST(@ID AS VARCHAR(MAX));
    -- Executar a consulta SQL
    EXEC(@sql)
END

GO

---------------------------------------------------------------------

-- Cria��o da procedure spConsulta para consultar registros baseados no ID
CREATE PROCEDURE spConsulta
(
    -- Declara��o dos par�metros que ser�o utilizados
    @id INT,                               -- ID do registro a ser consultado
    @tabela VARCHAR(MAX)                   -- Nome da tabela onde o registro ser� consultado
)
AS
BEGIN
    -- Declarar a vari�vel para armazenar a consulta SQL
    DECLARE @sql VARCHAR(MAX);
    -- Montar a consulta SQL para selecionar registros pelo ID
    SET @sql = 'SELECT * FROM ' + @tabela +
               ' WHERE id = ' + CAST(@id AS VARCHAR(MAX));
    -- Executar a consulta SQL
    EXEC(@sql)
END

GO

---------------------------------------------------------------------

-- Cria��o da procedure spListagem para listar registros ordenados por um campo espec�fico
CREATE PROCEDURE spListagem
(
    -- Declara��o dos par�metros que ser�o utilizados
    @tabela VARCHAR(MAX),                  -- Nome da tabela a ser consultada
    @ordem VARCHAR(MAX)                    -- Nome do campo pelo qual os registros ser�o ordenados
)
AS
BEGIN
    -- Executar a consulta SQL para listar os registros ordenados
    EXEC('SELECT * FROM ' + @tabela +
         ' ORDER BY ' + @ordem)
END

GO

---------------------------------------------------------------------

-- Cria��o da procedure spProximoId para obter o pr�ximo ID dispon�vel na tabela
CREATE PROCEDURE spProximoId
(
    -- Declara��o dos par�metros que ser�o utilizados
    @tabela VARCHAR(MAX)                   -- Nome da tabela para obter o pr�ximo ID
)
AS
BEGIN
    -- Executar a consulta SQL para obter o maior ID e incrementar em 1
    EXEC('SELECT ISNULL(MAX(id) + 1, 1) AS MAIOR FROM ' + @tabela)
END

---------------------------------------------------------------------
