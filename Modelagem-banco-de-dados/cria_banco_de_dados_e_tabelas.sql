/*RESUMO*/
/*Este código cria o banco de dados principal para gerenciamento de luminosidade e temperatura, 
incluindo tabelas para cadastro de funcionários, empresas parceiras e sensores. As tabelas são definidas com
chaves primárias, colunas específicas para armazenar os dados necessários e relacionamentos entre as tabelas.*/

/* 
Breve Descrição:
Este script SQL é utilizado para criar e configurar o banco de dados `b_lumitemp_main_db`.
Ele inclui a criação de tabelas para cadastro de funcionários, empresas parceiras e sensores, 
com os devidos relacionamentos entre essas tabelas.
*/

---------------------------------------------------------------------

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