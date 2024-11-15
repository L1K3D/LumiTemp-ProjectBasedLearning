/*RESUMO*/
/*O código define e recria procedures no banco de dados `b_lumitemp_main_db` para gerenciar registros 
da tabela de funcionários. As procedures incluem inserção de novos funcionários (`spIncluiFuncionario`), 
atualização de informações existentes (`spAlteraFuncionario`), exclusão de registros (`spExcluiFuncionario`), 
consulta de um funcionário específico por ID (`spConsultaFuncionario`), listagem de todos os funcionários (`spListagemFuncionario`) 
e obtenção do próximo ID disponível em uma tabela específica (`spProximoId`).*/

---------------------------------------------------------------------

-- Define o banco de dados a ser utilizado
USE b_lumitemp_main_db

GO

---------------------------------------------------------------------

-- Exclui as procedures se já existirem para recriá-las
DROP PROCEDURE spInsert_cadr_func
DROP PROCEDURE spUpdate_cadr_func

GO

---------------------------------------------------------------------

-- Criação da procedure spIncluiFuncionario para inserir um novo funcionário
CREATE PROCEDURE spInsert_cadr_func
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
CREATE PROCEDURE spUpdate_cadr_func
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