/*RESUMO*/
/*Este c�digo define um conjunto de procedures para gerenciar registros 
de sensores em uma tabela de banco de dados. Ele permite inserir novos sensores, 
atualizar informa��es de sensores existentes, excluir registros com base no ID, 
consultar um sensor espec�fico, listar todos os sensores e obter o pr�ximo ID 
dispon�vel na tabela. As procedures manipulam dados como tipo de sensor, data de venda, 
temperatura alvo, c�digo do motor e IDs de funcion�rio e empresa associados, 
facilitando o gerenciamento eficiente dos sensores no sistema.*/

---------------------------------------------------------------------

-- Define o banco de dados a ser utilizado
USE b_lumitemp_main_db

GO

---------------------------------------------------------------------

-- Exclui as procedures se j� existirem para recri�-las
DROP PROCEDURE spInsert_cadr_sens
DROP PROCEDURE spUpdate_cadr_sens

GO

---------------------------------------------------------------------

-- Cria��o da procedure spIncluiFuncionario para inserir um novo funcion�rio
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

-- Cria��o da procedure spAlteraSensor para alterar os dados de um sensor existente
CREATE PROCEDURE spUpdate_cadr_sens
(
    -- Declara��o dos par�metros que ser�o utilizados
    @ID INT,                               -- ID do sensor
    @DS_TIPO_SENS VARCHAR(30),             -- Descri��o do tipo de sensor
    @DT_VEND DATE,            -- Data de venda do sensor
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