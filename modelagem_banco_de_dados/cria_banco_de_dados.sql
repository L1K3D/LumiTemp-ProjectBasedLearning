-- Criação do Data Base do projeto
CREATE DATABASE b_lumitemp_main_db;

USE b_lumitemp_main_db;

------------------------------------
-- Criação da tabela de cadastro de funcionários representantes de vendas ou de funcionários capazes de realizar cadastros ou manutenções nos sensores

DROP TABLE cadr_func;

CREATE TABLE cadr_func (

    NR_USUA INT IDENTITY(1,1) PRIMARY KEY
	,LOGIN_USUA VARCHAR(30)
	,SENHA_USUA VARCHAR(30)
	,DT_CADR DATE

);

------------------------------------
-- Criação de tabela que guarda informações dos sensores

DROP TABLE cadr_sens;

CREATE TABLE cadr_sens (

    CD_SENS INT IDENTITY(1, 1) PRIMARY KEY
    ,DS_TIPO_SENS VARCHAR(30)
    ,DT_VEND  DATETIME NOT NULL
    ,VL_TEMP_ALVO DECIMAL(5, 2)
    ,VL_UMID_ALVO DECIMAL(5, 2)
    ,CD_MOTOR INT
    ,CONSTRAINT FK_NR_USUA FOREIGN KEY (NR_USUA)
        REFERENCES cadr_func(NR_USUA)
    ,CONSTRAINT FK_CD_EMPR FOREIGN KEY (CD_EMPR)
        REFERENCES cadr_empr(CD_EMPR)

);

------------------------------------
-- Criação de tabela que contém informações sobre as empresas parceiras das quais essas alugaram os sensores

DROP TABLE cadr_empr_parc;

CREATE TABLE cadr_empr_parc (

    CD_EMPR INT IDENTITY (1, 1) PRIMARY KEY
    ,NM_EMPR VARCHAR(30)
    ,CEP_EMPR VARCHAR(8)
    ,CNPJ_EMPR VARCHAR(15)
    ,TELF_CONT_EMPR VARCHAR(10)
    ,CONSTRAINT FK_NR_USUA FOREIGN KEY (NR_USUA)
        REFERENCES cadr_func(NR_USUA)

)