/* 
Breve Descri��o:
Este script SQL � utilizado para definir um conjunto de procedures no banco de dados `b_lumitemp_main_db`.
As procedures s�o respons�veis por opera��es como inser��o, atualiza��o, exclus�o e consulta de registros
na tabela de sensores (`cadr_sens`).
*/

---------------------------------------------------------------------

-- Define o banco de dados a ser utilizado
USE b_lumitemp_main_db

GO

---------------------------------------------------------------------

-- Exclui as procedures se j� existirem para recri�-las
DROP PROCEDURE IF EXISTS spInsert_cadr_sens
DROP PROCEDURE IF EXISTS spUpdate_cadr_sens

GO

---------------------------------------------------------------------

-- Cria��o da procedure spInsert_cadr_sens para inserir um novo sensor
CREATE PROCEDURE spInsert_cadr_sens
(
    -- Declara��o dos par�metros que ser�o utilizados
    @ID INT,                               -- ID do sensor
    @DS_TIPO_SENS VARCHAR(30),             -- Descri��o do tipo de sensor
    @DT_VEND DATE,                         -- Data de venda do sensor
    @VL_TEMP_ALVO DECIMAL(5, 2),           -- Valor da temperatura alvo
    @CD_MOTOR INT,                         -- C�digo do motor associado ao sensor
    @ID_FUNC INT,                          -- ID do funcion�rio respons�vel (chave estrangeira)
    @ID_EMPR INT                           -- ID da empresa respons�vel (chave estrangeira)
) 
AS
BEGIN
    -- Insere um novo registro na tabela 'cadr_sens' com os dados informados
    INSERT INTO cadr_sens
    (ID, DS_TIPO_SENS, DT_VEND, VL_TEMP_ALVO, CD_MOTOR, ID_FUNC, ID_EMPR)
    VALUES
    (@ID, @DS_TIPO_SENS, @DT_VEND, @VL_TEMP_ALVO, @CD_MOTOR, @ID_FUNC, @ID_EMPR)
END
GO

---------------------------------------------------------------------

-- Cria��o da procedure spUpdate_cadr_sens para alterar os dados de um sensor existente
CREATE PROCEDURE spUpdate_cadr_sens
(
    -- Declara��o dos par�metros que ser�o utilizados
    @ID INT,                               -- ID do sensor
    @DS_TIPO_SENS VARCHAR(30),             -- Descri��o do tipo de sensor
    @DT_VEND DATE,                         -- Data de venda do sensor
    @VL_TEMP_ALVO DECIMAL(5, 2),           -- Valor da temperatura alvo
    @CD_MOTOR INT,                         -- C�digo do motor associado ao sensor
    @ID_FUNC INT,                          -- ID do funcion�rio respons�vel (chave estrangeira)
    @ID_EMPR INT                           -- ID da empresa respons�vel (chave estrangeira)
) 
AS
BEGIN
    -- Atualiza o registro do sensor na tabela 'cadr_sens' com os novos dados
    UPDATE cadr_sens SET
        DS_TIPO_SENS = @DS_TIPO_SENS,
        DT_VEND = @DT_VEND,
        VL_TEMP_ALVO = @VL_TEMP_ALVO,
        CD_MOTOR = @CD_MOTOR,
        ID_FUNC = @ID_FUNC,
        ID_EMPR = @ID_EMPR
    WHERE ID = @ID                       -- Condi��o para identificar o sensor a ser atualizado
END
GO