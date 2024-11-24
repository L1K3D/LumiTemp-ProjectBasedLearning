/* 
Breve Descrição:
Este script SQL é utilizado para definir e recriar procedures no banco de dados `b_lumitemp_main_db`.
As procedures são responsáveis por operações como exclusão de registros pelo ID, consulta de registros pelo ID, 
listagem de registros ordenados por um campo específico e obtenção do próximo ID disponível na tabela.
*/

---------------------------------------------------------------------

-- Seleciona o banco de dados a ser utilizado
USE b_lumitemp_main_db

GO

---------------------------------------------------------------------

-- Exclui as procedures se já existirem para recriá-las
DROP PROCEDURE IF EXISTS spDelete
DROP PROCEDURE IF EXISTS spConsulta
DROP PROCEDURE IF EXISTS spListagem
DROP PROCEDURE IF EXISTS spProximoId

GO

---------------------------------------------------------------------

-- Criação da procedure spDelete para deletar um registro baseado no ID
CREATE PROCEDURE spDelete
(
    -- Declaração dos parâmetros que serão utilizados
    @ID INT,                               -- ID do registro a ser deletado
    @tabela VARCHAR(MAX)                   -- Nome da tabela onde o registro será deletado
)
AS
BEGIN
    -- Declarar a variável para armazenar a consulta SQL
    DECLARE @sql VARCHAR(MAX);
    -- Montar a consulta SQL para deletar o registro pelo ID
    SET @sql = 'DELETE FROM ' + @tabela +
               ' WHERE ID = ' + CAST(@ID AS VARCHAR(MAX));
    -- Executar a consulta SQL
    EXEC(@sql)
END

GO

---------------------------------------------------------------------

-- Criação da procedure spConsulta para consultar registros baseados no ID
CREATE PROCEDURE spConsulta
(
    -- Declaração dos parâmetros que serão utilizados
    @id INT,                               -- ID do registro a ser consultado
    @tabela VARCHAR(MAX)                   -- Nome da tabela onde o registro será consultado
)
AS
BEGIN
    -- Declarar a variável para armazenar a consulta SQL
    DECLARE @sql VARCHAR(MAX);
    -- Montar a consulta SQL para selecionar registros pelo ID
    SET @sql = 'SELECT * FROM ' + @tabela +
               ' WHERE id = ' + CAST(@id AS VARCHAR(MAX));
    -- Executar a consulta SQL
    EXEC(@sql)
END

GO

---------------------------------------------------------------------

-- Criação da procedure spListagem para listar registros ordenados por um campo específico
CREATE PROCEDURE spListagem
(
    -- Declaração dos parâmetros que serão utilizados
    @tabela VARCHAR(MAX),                  -- Nome da tabela a ser consultada
    @ordem VARCHAR(MAX)                    -- Nome do campo pelo qual os registros serão ordenados
)
AS
BEGIN
    -- Executar a consulta SQL para listar os registros ordenados
    EXEC('SELECT * FROM ' + @tabela +
         ' ORDER BY ' + @ordem)
END

GO

---------------------------------------------------------------------

-- Criação da procedure spProximoId para obter o próximo ID disponível na tabela
CREATE PROCEDURE spProximoId
(
    -- Declaração dos parâmetros que serão utilizados
    @tabela VARCHAR(MAX)                   -- Nome da tabela para obter o próximo ID
)
AS
BEGIN
    -- Executar a consulta SQL para obter o maior ID e incrementar em 1
    EXEC('SELECT ISNULL(MAX(id) + 1, 1) AS MAIOR FROM ' + @tabela)
END

---------------------------------------------------------------------
