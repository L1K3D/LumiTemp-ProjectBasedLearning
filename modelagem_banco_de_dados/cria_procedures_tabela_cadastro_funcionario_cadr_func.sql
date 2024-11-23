/* 
Breve Descrição:
Este script SQL é utilizado para definir e recriar procedures no banco de dados `b_lumitemp_main_db`. 
As procedures são responsáveis por operações como inserção, atualização e consulta avançada de registros 
na tabela de funcionários.
*/

---------------------------------------------------------------------

-- Define o banco de dados a ser utilizado
USE b_lumitemp_main_db

GO

---------------------------------------------------------------------

-- Exclui as procedures se já existirem para recriá-las
DROP PROCEDURE IF EXISTS spInsert_cadr_func
DROP PROCEDURE IF EXISTS spUpdate_cadr_func
DROP PROCEDURE IF EXISTS spConsultaAvancadaFuncionarios

GO

---------------------------------------------------------------------

-- Criação da procedure spInsert_cadr_func para inserir um novo funcionário
CREATE PROCEDURE spInsert_cadr_func
(
    -- Declaração dos parâmetros que serão utilizados na inserção
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

-- Criação da procedure spUpdate_cadr_func para alterar os dados de um funcionário existente
CREATE PROCEDURE spUpdate_cadr_func
(
    -- Declaração dos parâmetros que serão utilizados na atualização
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

-- Criação da procedure spConsultaAvancadaFuncionarios para consultar funcionários
CREATE PROCEDURE spConsultaAvancadaFuncionarios
(
    -- Declaração dos parâmetros para a consulta avançada
    @descricao varchar(max),
    @dataInicial datetime,
    @dataFinal datetime
)
AS
BEGIN
    -- Seleciona registros na tabela cadr_func com base em critérios fornecidos
    SELECT * FROM cadr_func
    WHERE cadr_func.DT_CADR BETWEEN @dataInicial AND @dataFinal
    AND cadr_func.LOGIN_FUNC LIKE '%' + @descricao + '%'
END
GO