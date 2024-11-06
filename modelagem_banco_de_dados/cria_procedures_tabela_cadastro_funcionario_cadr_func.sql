/*RESUMO*/
/*O código define e recria procedures no banco de dados `b_lumitemp_main_db` para gerenciar registros 
da tabela de funcionários. As procedures incluem inserção de novos funcionários (`spIncluiFuncionario`), 
atualização de informações existentes (`spAlteraFuncionario`), exclusão de registros (`spExcluiFuncionario`), 
consulta de um funcionário específico por ID (`spConsultaFuncionario`), listagem de todos os funcionários (`spListagemFuncionario`) 
e obtenção do próximo ID disponível em uma tabela específica (`spProximoId`).*/

---------------------------------------------------------------------

-- Define o banco de dados a ser utilizado
USE b_lumitemp_main_db

---------------------------------------------------------------------

-- Exclui as procedures se já existirem para recriá-las
DROP PROCEDURE spIncluiFuncionario;
DROP PROCEDURE spAlteraFuncionario;
DROP PROCEDURE spExcluiFuncionario;
DROP PROCEDURE spConsultaFuncionario;
DROP PROCEDURE spListagemFuncionario;
DROP PROCEDURE spProximoId;

---------------------------------------------------------------------

-- Criação da procedure spIncluiFuncionario para inserir um novo funcionário
CREATE PROCEDURE spIncluiFuncionario
(
    -- Declaração dos parâmetros que serão utilizados
    @ID INT,                               -- ID do funcionário
    @LOGIN_FUNC VARCHAR(30),               -- Login do funcionário
    @SENHA_FUNC VARCHAR(30),               -- Senha do funcionário
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

-- Criação da procedure spAlteraFuncionario para alterar os dados de um funcionário existente
CREATE PROCEDURE spAlteraFuncionario
(
    -- Declaração dos parâmetros que serão utilizados
    @ID INT,                               -- ID do funcionário
    @LOGIN_FUNC VARCHAR(30),               -- Login do funcionário
    @SENHA_FUNC VARCHAR(30),               -- Senha do funcionário
    @DT_CADR DATE                          -- Data de cadastro
) 
AS
BEGIN
    -- Atualiza o registro do funcionário na tabela 'cadr_func' com os novos dados
    UPDATE cadr_func SET
        ID = @ID,
        LOGIN_FUNC = @LOGIN_FUNC,
        SENHA_FUNC = @SENHA_FUNC,
        DT_CADR = @DT_CADR
    WHERE ID = @ID                         -- Condição para identificar qual funcionário será atualizado
END
GO

---------------------------------------------------------------------

-- Criação da procedure spExcluiFuncionario para excluir um funcionário
/*CREATE PROCEDURE spExcluiFuncionario
(
    -- Declaração do parâmetro que será utilizado
    @ID INT                                -- ID do funcionário a ser excluído
)
AS
BEGIN
    -- Exclui o registro do funcionário com base no ID informado
    DELETE cadr_func WHERE ID = @ID
END
GO

---------------------------------------------------------------------

-- Criação da procedure spConsultaFuncionario para consultar os dados de um funcionário específico
CREATE PROCEDURE spConsultaFuncionario
(
    -- Declaração do parâmetro que será utilizado
    @ID INT                                -- ID do funcionário a ser consultado
) 
AS
BEGIN
    -- Seleciona todos os dados do funcionário com o ID informado
    SELECT * FROM cadr_func WHERE ID = @ID
END
GO

---------------------------------------------------------------------

-- Criação da procedure spListagemFuncionario para listar todos os funcionários
CREATE PROCEDURE spListagemFuncionario
AS
BEGIN
    -- Seleciona todos os registros da tabela 'cadr_func'
    SELECT * FROM cadr_func
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
GO*/