-- Cria o banco de dados principal para gerenciamento de luminosidade e temperatura
CREATE DATABASE b_lumitemp_main_db;

-- Define o banco de dados a ser utilizado como o contexto atual
USE b_lumitemp_main_db;

---------------------------------------------------------------------

-- Remove a tabela de cadastro de funcionários caso ela já exista
DROP TABLE cadr_func;

-- Cria a tabela de cadastro de funcionários
CREATE TABLE cadr_func (
    CD_FUNC INT IDENTITY(1,1) PRIMARY KEY  -- Código do funcionário, chave primária com incremento automático
    ,LOGIN_FUNC VARCHAR(30)                -- Login do funcionário (máximo 30 caracteres)
    ,SENHA_FUNC VARCHAR(30)                -- Senha do funcionário (máximo 30 caracteres)
    ,DT_CADR DATE                          -- Data de cadastro do funcionário
);

---------------------------------------------------------------------

-- Remove a tabela de cadastro de sensores caso ela já exista
DROP TABLE cadr_sens;

-- Cria a tabela de cadastro de sensores
CREATE TABLE cadr_sens (
    CD_SENS INT IDENTITY(1, 1) PRIMARY KEY  -- Código do sensor, chave primária com incremento automático
    ,DS_TIPO_SENS VARCHAR(30)               -- Descrição do tipo de sensor (máximo 30 caracteres)
    ,DT_VEND  DATETIME NOT NULL             -- Data de venda do sensor, campo obrigatório
    ,VL_TEMP_ALVO DECIMAL(5, 2)             -- Valor de temperatura alvo com 5 dígitos e 2 casas decimais
    ,VL_UMID_ALVO DECIMAL(5, 2)             -- Valor de umidade alvo com 5 dígitos e 2 casas decimais
    ,CD_MOTOR INT                           -- Código do motor relacionado ao sensor
    ,CONSTRAINT FK_CD_FUNC FOREIGN KEY (CD_FUNC)  -- Chave estrangeira referenciando o funcionário que cadastrou
        REFERENCES cadr_func(CD_FUNC)
    ,CONSTRAINT FK_CD_EMPR FOREIGN KEY (CD_EMPR)  -- Chave estrangeira referenciando a empresa parceira relacionada
        REFERENCES cadr_empr(CD_EMPR)
);

---------------------------------------------------------------------

-- Remove a tabela de cadastro de empresas parceiras caso ela já exista
DROP TABLE cadr_empr_parc;

-- Cria a tabela de cadastro de empresas parceiras
CREATE TABLE cadr_empr_parc (
    CD_EMPR INT IDENTITY (1, 1) PRIMARY KEY  -- Código da empresa parceira, chave primária com incremento automático
    ,NM_EMPR VARCHAR(30)                     -- Nome da empresa parceira (máximo 30 caracteres)
    ,CEP_EMPR VARCHAR(8)                     -- CEP da empresa parceira (8 caracteres)
    ,CNPJ_EMPR VARCHAR(15)                   -- CNPJ da empresa parceira (15 caracteres)
    ,TELF_CONT_EMPR VARCHAR(10)              -- Telefone de contato da empresa parceira (10 caracteres)
    ,CONSTRAINT FK_CD_FUNC FOREIGN KEY (CD_FUNC)  -- Chave estrangeira referenciando o funcionário responsável
        REFERENCES cadr_func(CD_FUNC)
);