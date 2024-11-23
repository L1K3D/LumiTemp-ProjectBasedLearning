-- Cria o banco de dados principal para gerenciamento de luminosidade e temperatura
CREATE DATABASE b_lumitemp_main_db

GO

-- Define o banco de dados a ser utilizado como o contexto atual
USE b_lumitemp_main_db

GO

---------------------------------------------------------------------

-- Remove a tabela de cadastro de funcionários caso ela já exista
DROP TABLE cadr_func;

-- Cria a tabela de cadastro de funcionários
CREATE TABLE cadr_func (
    ID INT PRIMARY KEY,  -- Código do funcionário, chave primária com incremento automático
    LOGIN_FUNC VARCHAR(30),             -- Login do funcionário (máximo 30 caracteres)
    SENHA_FUNC VARCHAR(30),              -- Senha do funcionário (máximo 30 caracteres)
    DT_CADR DATE                          -- Data de cadastro do funcionário
);

GO

---------------------------------------------------------------------

-- Remove a tabela de cadastro de empresas parceiras caso ela já exista
DROP TABLE cadr_empr_parc;

-- Cria a tabela de cadastro de empresas parceiras
CREATE TABLE cadr_empr_parc (
    ID INT PRIMARY KEY,                      -- Código da empresa parceira, chave primária com incremento automático
    NM_EMPR VARCHAR(30),                     -- Nome da empresa parceira (máximo 30 caracteres)
    CEP_EMPR VARCHAR(8),                     -- CEP da empresa parceira (8 caracteres)
	LOG_EMPR VARCHAR(30),					 -- LOGRADOURO da empresa parceira (máximo 30 caracteres)
	NUM_EMPR VARCHAR(4),                     -- NÚMERO da empresa parceira (máximo 4 caracteres)
	COMPL_EMPR VARCHAR (30),                 -- COMPLEMENTO da empresa parceira (máximo 30 caracteres)
	BAIRRO_EMPR VARCHAR (20),               -- BAIRRO da empresa parceira (máximo 20 caracteres)
	CIDADE_EMPR VARCHAR (20),                -- CIDADE da empresa parceira (máximo 20 caracteres)
	ESTADO_EMPR VARCHAR (2),				 -- ESTADO da empresa parceira (máximo 2 caracteres) 
    CNPJ_EMPR VARCHAR(15),                   -- CNPJ da empresa parceira (15 caracteres)
    TELF_CONT_EMPR VARCHAR(11),              -- Telefone de contato da empresa parceira (11 caracteres)
    ID_FUNC INT,                             -- Código do funcionário responsável (chave estrangeira)
    CONSTRAINT FK_CD_FUNC FOREIGN KEY (ID_FUNC)  
        REFERENCES cadr_func(ID)        -- Chave estrangeira referenciando 'CD_FUNC' da tabela 'cadr_func'
);

GO

select * from cadr_empr_parc

---------------------------------------------------------------------

-- Remove a tabela de cadastro de sensores caso ela já exista
DROP TABLE cadr_sens

-- Cria a tabela de cadastro de sensores
CREATE TABLE cadr_sens (
    ID INT PRIMARY KEY,  -- Código do sensor, chave primária com incremento automático
    DS_TIPO_SENS VARCHAR(MAX),                -- Descrição do tipo de sensor (máximo 30 caracteres)
    DT_VEND DATE,               -- Data de venda do sensor, campo obrigatório
    VL_TEMP_ALVO DECIMAL(5, 2),              -- Valor de temperatura alvo com 5 dígitos e 2 casas decimais
    CD_MOTOR INT,                            -- Código do motor relacionado ao sensor
    ID_FUNC INT,
    CONSTRAINT FK_CD_FUNC_SENS FOREIGN KEY (ID_FUNC)  -- Nome único para a chave estrangeira de 'CD_FUNC'
        REFERENCES cadr_func(ID),
    ID_EMPR INT,
    CONSTRAINT FK_CD_EMPR_SENS FOREIGN KEY (ID_EMPR)  -- Nome único para a chave estrangeira de 'CD_EMPR'
        REFERENCES cadr_empr_parc(ID)
);

---------------------------------------------------------------------

ALTER TABLE cadr_func ADD IMAGEM varbinary(max);
GO
 
