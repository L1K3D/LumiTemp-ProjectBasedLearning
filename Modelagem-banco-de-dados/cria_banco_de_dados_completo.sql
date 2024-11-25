-- Cria o banco de dados principal para gerenciamento de luminosidade e temperatura
CREATE DATABASE b_lumitemp_main_db

GO

---------------------------------------------------------------------

-- Define o banco de dados a ser utilizado como o contexto atual
USE b_lumitemp_main_db

GO

---------------------------------------------------------------------

-- Remove a tabela de cadastro de funcionários caso ela já exista
DROP TABLE IF EXISTS cadr_func

GO

-- Cria a tabela de cadastro de funcionários
CREATE TABLE cadr_func (
    ID INT PRIMARY KEY,                     -- Código do funcionário, chave primária com incremento automático
    LOGIN_FUNC VARCHAR(30),                 -- Login do funcionário (máximo 30 caracteres)
    SENHA_FUNC VARCHAR(30),                 -- Senha do funcionário (máximo 30 caracteres)
    DT_CADR DATE,                           -- Data de cadastro do funcionário
    IMAGEM VARBINARY(MAX)                   -- Imagem do funcionário
)

GO

---------------------------------------------------------------------

-- Remove a tabela de cadastro de empresas parceiras caso ela já exista
DROP TABLE IF EXISTS cadr_empr_parc

GO

-- Cria a tabela de cadastro de empresas parceiras
CREATE TABLE cadr_empr_parc (
    ID INT PRIMARY KEY,                     -- Código da empresa parceira, chave primária com incremento automático
    NM_EMPR VARCHAR(30),                    -- Nome da empresa parceira (máximo 30 caracteres)
    CEP_EMPR VARCHAR(8),                    -- CEP da empresa parceira (8 caracteres)
    LOG_EMPR VARCHAR(30),                   -- Logradouro da empresa parceira (máximo 30 caracteres)
    NUM_EMPR VARCHAR(4),                    -- Número da empresa parceira (máximo 4 caracteres)
    COMPL_EMPR VARCHAR(30),                 -- Complemento do endereço da empresa parceira (máximo 30 caracteres)
    BAIRRO_EMPR VARCHAR(20),                -- Bairro da empresa parceira (máximo 20 caracteres)
    CIDADE_EMPR VARCHAR(20),                -- Cidade da empresa parceira (máximo 20 caracteres)
    ESTADO_EMPR VARCHAR(2),                 -- Estado da empresa parceira (máximo 2 caracteres)
    CNPJ_EMPR VARCHAR(15),                  -- CNPJ da empresa parceira (15 caracteres)
    TELF_CONT_EMPR VARCHAR(11),             -- Telefone de contato da empresa parceira (11 caracteres)
    ID_FUNC INT,                            -- Código do funcionário responsável (chave estrangeira)
    CONSTRAINT FK_CD_FUNC FOREIGN KEY (ID_FUNC)  
        REFERENCES cadr_func(ID)            -- Chave estrangeira referenciando 'ID' da tabela 'cadr_func'
)

GO

---------------------------------------------------------------------

-- Remove a tabela de cadastro de sensores caso ela já exista
DROP TABLE IF EXISTS cadr_sens

GO

-- Cria a tabela de cadastro de sensores
CREATE TABLE cadr_sens (
    ID INT PRIMARY KEY,                     -- Código do sensor, chave primária com incremento automático
    DS_TIPO_SENS VARCHAR(MAX),              -- Descrição do tipo de sensor
    DT_VEND DATE,                           -- Data de venda do sensor, campo obrigatório
    VL_TEMP_ALVO DECIMAL(5, 2),             -- Valor de temperatura alvo com 5 dígitos e 2 casas decimais
    CD_MOTOR INT,                           -- Código do motor relacionado ao sensor
    ID_FUNC INT,                            -- Código do funcionário responsável (chave estrangeira)
    CONSTRAINT FK_CD_FUNC_SENS FOREIGN KEY (ID_FUNC)  -- Nome único para a chave estrangeira de 'ID_FUNC'
        REFERENCES cadr_func(ID),
    ID_EMPR INT,                            -- Código da empresa parceira (chave estrangeira)
    CONSTRAINT FK_CD_EMPR_SENS FOREIGN KEY (ID_EMPR)  -- Nome único para a chave estrangeira de 'ID_EMPR'
        REFERENCES cadr_empr_parc(ID)
)

GO

---------------------------------------------------------------------
---CRIA PROCEDURES GENERICAS---
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

GO

---------------------------------------------------------------------
---CRIA PROCEDURES PARA TABELA DE CADASTRO DE EMPRESAS PARCEIRAS---
---------------------------------------------------------------------

-- Define o banco de dados a ser utilizado
USE b_lumitemp_main_db

GO

---------------------------------------------------------------------

-- Exclui as procedures se j� existirem para recri�-las
DROP PROCEDURE IF EXISTS spInsert_cadr_empr_parc
DROP PROCEDURE IF EXISTS spUpdate_cadr_empr_parc

GO

---------------------------------------------------------------------

-- Cria procedure spInsert_cadr_empr_parc para inserir uma nova empresa parceira
CREATE PROCEDURE spInsert_cadr_empr_parc
(
    -- Declara��o dos par�metros que ser�o utilizados
    @ID INT,                               -- ID da empresa
    @NM_EMPR VARCHAR(30),                  -- Nome da empresa
    @CEP_EMPR VARCHAR(30),                 -- CEP da empresa
    @LOG_EMPR VARCHAR(30),                 -- Logradouro da empresa
    @NUM_EMPR VARCHAR(4),                  -- N�mero da empresa
    @COMPL_EMPR VARCHAR(30),               -- Complemento do endere�o da empresa
    @BAIRRO_EMPR VARCHAR(20),              -- Bairro da empresa
    @CIDADE_EMPR VARCHAR(20),              -- Cidade da empresa
    @ESTADO_EMPR VARCHAR(2),               -- Estado da empresa
    @CNPJ_EMPR VARCHAR(15),                -- CNPJ da empresa
    @TELF_CONT_EMPR VARCHAR(10),           -- Telefone de contato da empresa
    @ID_FUNC INT                           -- ID do funcion�rio respons�vel pela empresa (chave estrangeira)
) 
AS
BEGIN
    -- Insere um novo registro na tabela 'cadr_empr_parc' com os dados informados
    INSERT INTO cadr_empr_parc
    (ID, NM_EMPR, CEP_EMPR, LOG_EMPR, NUM_EMPR, COMPL_EMPR, BAIRRO_EMPR, CIDADE_EMPR, ESTADO_EMPR, CNPJ_EMPR, TELF_CONT_EMPR, ID_FUNC)
    VALUES
    (@ID, @NM_EMPR, @CEP_EMPR, @LOG_EMPR, @NUM_EMPR, @COMPL_EMPR, @BAIRRO_EMPR, @CIDADE_EMPR, @ESTADO_EMPR, @CNPJ_EMPR, @TELF_CONT_EMPR, @ID_FUNC)
END

GO

---------------------------------------------------------------------

-- Cria��o da procedure spUpdate_cadr_empr_parc para alterar os dados de uma empresa existente
CREATE PROCEDURE spUpdate_cadr_empr_parc
(
    -- Declara��o dos par�metros que ser�o utilizados
    @ID INT,                               -- ID da empresa
    @NM_EMPR VARCHAR(30),                  -- Nome da empresa
    @CEP_EMPR VARCHAR(30),                 -- CEP da empresa
    @LOG_EMPR VARCHAR(30),                 -- Logradouro da empresa
    @NUM_EMPR VARCHAR(4),                  -- N�mero da empresa
    @COMPL_EMPR VARCHAR(30),               -- Complemento do endere�o da empresa
    @BAIRRO_EMPR VARCHAR(20),              -- Bairro da empresa
    @CIDADE_EMPR VARCHAR(20),              -- Cidade da empresa
    @ESTADO_EMPR VARCHAR(2),               -- Estado da empresa
    @CNPJ_EMPR VARCHAR(15),                -- CNPJ da empresa
    @TELF_CONT_EMPR VARCHAR(11),           -- Telefone de contato da empresa
    @ID_FUNC INT                           -- ID do funcion�rio respons�vel pela empresa (chave estrangeira)
) 
AS
BEGIN
    -- Atualiza o registro da empresa na tabela 'cadr_empr_parc' com os novos dados
    UPDATE cadr_empr_parc SET
        NM_EMPR = @NM_EMPR,                -- Nome da empresa
        CEP_EMPR = @CEP_EMPR,              -- CEP da empresa
        LOG_EMPR = @LOG_EMPR,              -- Logradouro da empresa
        NUM_EMPR = @NUM_EMPR,              -- N�mero da empresa
        COMPL_EMPR = @COMPL_EMPR,          -- Complemento do endere�o da empresa
        BAIRRO_EMPR = @BAIRRO_EMPR,        -- Bairro da empresa
        CIDADE_EMPR = @CIDADE_EMPR,        -- Cidade da empresa
        ESTADO_EMPR = @ESTADO_EMPR,        -- Estado da empresa
        CNPJ_EMPR = @CNPJ_EMPR,            -- CNPJ da empresa
        TELF_CONT_EMPR = @TELF_CONT_EMPR,  -- Telefone de contato da empresa
        ID_FUNC = @ID_FUNC                 -- ID do funcion�rio respons�vel pela empresa
    WHERE ID = @ID                         -- Condi��o para identificar a empresa a ser atualizada
END

GO

---------------------------------------------------------------------
---CRIA PROCEDURES PARA TABELA DE CADASTRO DE FUNCIONÁRIOS---
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

---------------------------------------------------------------------
---CRIA PROCEDURES PARA TABELA DE CADASTRO DE SENSORES---
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

-- Cria��o da procedure spConsultaAvancadaSensores para consultar sensores

create procedure [dbo].[spConsultaAvancadaSensores] 
(
	@descricao varchar(max),
	@empresa int,
	@dataInicial datetime,
	@dataFinal datetime)
as
begin
	declare @empresaIni int
	declare @empresaFim int
 
	set @empresaIni = case @empresa when 0 then 0 else @empresa end
	set @empresaFim = case @empresa when 0 then 999999 else @empresa end 
 select cadr_sens.*, cadr_empr_parc.NM_EMPR as 'DescricaoEmpresa'
from cadr_sens 
inner join cadr_empr_parc on cadr_sens.ID_EMPR = cadr_empr_parc.ID
where cadr_sens.DS_TIPO_SENS like '%' + @descricao + '%' and 
 cadr_sens.DT_VEND between @dataInicial and @dataFinal and 
 cadr_sens.ID_EMPR between @empresaIni and @empresaFim; 
end