-- Seleciona o banco de dados b_lumitemp_main_db
USE b_lumitemp_main_db

GO

DROP PROCEDURE spDelete
DROP PROCEDURE spConsulta
DROP PROCEDURE spListagem
DROP PROCEDURE spProximoId

GO

-- Procedimento para deletar um registro baseado no ID
CREATE PROCEDURE spDelete
(
 @ID INT,
 @tabela VARCHAR(MAX)
)
AS
BEGIN
 -- Declarar a variável para armazenar a consulta SQL
 DECLARE @sql VARCHAR(MAX);
 -- Montar a consulta SQL para deletar o registro pelo ID
 SET @sql = ' DELETE ' + @tabela +
 ' WHERE ID = ' + CAST(@ID AS VARCHAR(MAX))
 -- Executar a consulta SQL
 EXEC(@sql)
END

GO

-- Procedimento para consultar registros baseados no ID
CREATE PROCEDURE spConsulta
(
 @id INT,
 @tabela VARCHAR(MAX)
)
AS
BEGIN
 -- Declarar a variável para armazenar a consulta SQL
 DECLARE @sql VARCHAR(MAX);
 -- Montar a consulta SQL para selecionar registros pelo ID
 SET @sql = 'SELECT * FROM ' + @tabela +
 ' WHERE id = ' + CAST(@id AS VARCHAR(MAX))
 -- Executar a consulta SQL
 EXEC(@sql)
END

GO

-- Procedimento para listar registros ordenados por um campo específico
CREATE PROCEDURE spListagem
(
 @tabela VARCHAR(MAX),
 @ordem VARCHAR(MAX)
)
AS
BEGIN
 -- Executar a consulta SQL para listar os registros ordenados
 EXEC('SELECT * FROM ' + @tabela +
 ' ORDER BY ' + @ordem)
END

GO

-- Procedimento para obter o próximo ID disponível na tabela
CREATE PROCEDURE spProximoId
(@tabela VARCHAR(MAX))
AS
BEGIN
 -- Executar a consulta SQL para obter o maior ID e incrementar em 1
 EXEC('SELECT ISNULL(MAX(id) + 1, 1) AS MAIOR FROM ' + @tabela)
END

-- Procedimento para selecionar os dados com base no filtros de tela 
-- CONSULTA AVANÇADA DE FUNCIONÁRIOS

create procedure [dbo].[spConsultaAvancadaFuncionarios] 
(
	@descricao varchar(max),
	@dataInicial datetime,
	@dataFinal datetime)
as
begin
	select * from cadr_func
	where cadr_func.DT_CADR between @dataInicial and @dataFinal and 
	cadr_func.LOGIN_FUNC like '%' + @descricao + '%'  

end

