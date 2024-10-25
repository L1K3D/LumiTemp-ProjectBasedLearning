/*RESUMO*/
/*Este código define um conjunto de procedures para gerenciar registros 
de sensores em uma tabela de banco de dados. Ele permite inserir novos sensores, 
atualizar informações de sensores existentes, excluir registros com base no ID, 
consultar um sensor específico, listar todos os sensores e obter o próximo ID 
disponível na tabela. As procedures manipulam dados como tipo de sensor, data de venda, 
temperatura alvo, código do motor e IDs de funcionário e empresa associados, 
facilitando o gerenciamento eficiente dos sensores no sistema.*/

---------------------------------------------------------------------

-- Define o banco de dados a ser utilizado
USE b_lumitemp_main_db

---------------------------------------------------------------------

-- Exclui as procedures se já existirem para recriá-las
DROP PROCEDURE spIncluiSensor;
DROP PROCEDURE spAlteraSensor;
DROP PROCEDURE spExcluiSensor;
DROP PROCEDURE spConsultaSensor;
DROP PROCEDURE spListagemSensor;
DROP PROCEDURE spProximoId;

---------------------------------------------------------------------

-- Criação da procedure spIncluiFuncionario para inserir um novo funcionário
CREATE PROCEDURE spIncluiSensor
(
    -- Declaração dos parâmetros que serão utilizados
    @ID INT,                               -- ID do sensor
    @DS_TIPO_SENS VARCHAR(30),             -- Descrição do tipo de sensor
    @DT_VEND DATE,                         -- Data de venda do sensor
    @VL_TEMP_ALVO DECIMAL(5, 2),           -- Valor da temperatura alvo
    @CD_MOTOR INT,                         -- Código do motor associado ao sensor
    @ID_FUNC INT,                          -- ID do funcionário responsável (chave estrangeira)
    @ID_EMPR INT                           -- ID da empresa responsável (chave estrangeira)
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

-- Criação da procedure spAlteraSensor para alterar os dados de um sensor existente
CREATE PROCEDURE spAlteraSensor
(
    -- Declaração dos parâmetros que serão utilizados
    @ID INT,                               -- ID do sensor
    @DS_TIPO_SENS VARCHAR(30),             -- Descrição do tipo de sensor
    @DT_VEND DATE,            -- Data de venda do sensor
    @VL_TEMP_ALVO DECIMAL(5, 2),           -- Valor da temperatura alvo
    @CD_MOTOR INT,                         -- Código do motor associado ao sensor
    @ID_FUNC INT,                          -- ID do funcionário responsável (chave estrangeira)
    @ID_EMPR INT                           -- ID da empresa responsável (chave estrangeira)
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
    WHERE ID = @ID                       -- Condição para identificar o sensor a ser atualizado
END
GO

---------------------------------------------------------------------

-- Criação da procedure spExcluiSensor para excluir um sensor
CREATE PROCEDURE spExcluiSensor
(
    -- Declaração do parâmetro que será utilizado
    @ID INT                                -- ID do sensor a ser excluído
)
AS
BEGIN
    -- Exclui o registro do sensor com base no ID informado
    DELETE cadr_sens WHERE ID = @ID
END
GO

---------------------------------------------------------------------

-- Criação da procedure spConsultaSensor para consultar os dados de um sensor específico
CREATE PROCEDURE spConsultaSensor
(
    -- Declaração do parâmetro que será utilizado
    @ID INT                                -- ID do sensor a ser consultado
) 
AS
BEGIN
    -- Seleciona todos os dados do sensor com o ID informado
    SELECT * FROM cadr_sens WHERE ID = @ID
END
GO

---------------------------------------------------------------------

-- Criação da procedure spListagemSensor para listar todos os sensores
CREATE PROCEDURE spListagemSensor
AS
BEGIN
    -- Seleciona todos os registros da tabela 'cadr_sens'
    SELECT * FROM cadr_sens
END
GO

---------------------------------------------------------------------

-- Criação da procedure spProximoId para obter o próximo ID disponível em uma tabela
CREATE PROCEDURE spProximoId
(
    -- Declaração do parâmetro que será utilizado
    @tabela VARCHAR(MAX)                   -- Nome da tabela onde será pesquisado o próximo ID
)
AS
BEGIN
    -- Executa uma consulta dinâmica para encontrar o maior ID + 1 na tabela especificada
    EXEC ('SELECT ISNULL(MAX(ID) + 1, 1) AS MAIOR FROM ' + @tabela)
END
GO