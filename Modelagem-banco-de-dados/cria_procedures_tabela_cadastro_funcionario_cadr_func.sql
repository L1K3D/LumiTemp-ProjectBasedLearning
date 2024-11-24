/* 
Breve Descri��o:
Este script SQL � utilizado para definir e recriar procedures no banco de dados `b_lumitemp_main_db`. 
As procedures s�o respons�veis por opera��es como inser��o, atualiza��o e consulta avan�ada de registros 
na tabela de funcion�rios.
*/

---------------------------------------------------------------------

-- Define o banco de dados a ser utilizado
USE b_lumitemp_main_db

GO

---------------------------------------------------------------------

-- Exclui as procedures se j� existirem para recri�-las
DROP PROCEDURE IF EXISTS spInsert_cadr_func
DROP PROCEDURE IF EXISTS spUpdate_cadr_func
DROP PROCEDURE IF EXISTS spConsultaAvancadaFuncionarios

GO

---------------------------------------------------------------------

-- Cria��o da procedure spInsert_cadr_func para inserir um novo funcion�rio
CREATE PROCEDURE spInsert_cadr_func
(
    -- Declara��o dos par�metros que ser�o utilizados na inser��o
    @ID int,
    @LOGIN_FUNC varchar(30),
    @SENHA_FUNC varchar(30),
    @DT_CADR DATE,
    @IMAGEM VARBINARY(MAX)
) 
AS
BEGIN
    -- Insere um novo registro na tabela cadr_func
    INSERT INTO cadr_func (ID, LOGIN_FUNC, SENHA_FUNC, DT_CADR, IMAGEM)
    VALUES (@ID, @LOGIN_FUNC, @SENHA_FUNC, @DT_CADR, @IMAGEM)
END
GO

---------------------------------------------------------------------

-- Cria��o da procedure spUpdate_cadr_func para alterar os dados de um funcion�rio existente
CREATE PROCEDURE spUpdate_cadr_func
(
    -- Declara��o dos par�metros que ser�o utilizados na atualiza��o
    @ID int,
    @LOGIN_FUNC varchar(30),
    @SENHA_FUNC varchar(30),
    @DT_CADR DATE,
    @IMAGEM VARBINARY(MAX)
) 
AS
BEGIN
    -- Atualiza o registro existente na tabela cadr_func
    UPDATE cadr_func
    SET LOGIN_FUNC = @LOGIN_FUNC, SENHA_FUNC = @SENHA_FUNC, DT_CADR = @DT_CADR, IMAGEM = @IMAGEM
    WHERE ID = @ID
END
GO

---------------------------------------------------------------------

-- Cria��o da procedure spConsultaAvancadaFuncionarios para consultar funcion�rios
CREATE PROCEDURE spConsultaAvancadaFuncionarios
(
    -- Declara��o dos par�metros para a consulta avan�ada
    @descricao varchar(max),
    @dataInicial datetime,
    @dataFinal datetime
)
AS
BEGIN
    -- Seleciona registros na tabela cadr_func com base em crit�rios fornecidos
    SELECT * FROM cadr_func
    WHERE cadr_func.DT_CADR BETWEEN @dataInicial AND @dataFinal
    AND cadr_func.LOGIN_FUNC LIKE '%' + @descricao + '%'
END
GO