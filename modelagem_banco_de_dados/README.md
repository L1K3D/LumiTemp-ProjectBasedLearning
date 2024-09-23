# Banco de Dados - Gerenciamento de Luminosidade e Temperatura

Este banco de dados foi desenvolvido para gerenciar sensores de luminosidade e temperatura, além de armazenar informações sobre funcionários responsáveis e empresas parceiras. O objetivo é monitorar e controlar os dados de sensores em ambientes industriais ou comerciais.

## Estrutura do Banco de Dados

- **Nome do Banco de Dados**: `b_lumitemp_main_db`
  
  O banco de dados principal é utilizado para armazenar informações sobre funcionários, sensores, e empresas parceiras envolvidas no sistema de gerenciamento de sensores.

## Tabelas

### 1. `cadr_func` - Cadastro de Funcionários

Tabela responsável por armazenar os dados dos funcionários que têm acesso ao sistema.

| Coluna     | Tipo        | Descrição                                               |
|------------|-------------|---------------------------------------------------------|
| `CD_FUNC`  | `INT`       | Código do funcionário, chave primária com incremento automático. |
| `LOGIN_FUNC` | `VARCHAR(30)` | Login do funcionário (máximo 30 caracteres).         |
| `SENHA_FUNC` | `VARCHAR(30)` | Senha do funcionário (máximo 30 caracteres).         |
| `DT_CADR`  | `DATE`      | Data de cadastro do funcionário.                         |

### 2. `cadr_sens` - Cadastro de Sensores

Tabela que armazena informações sobre os sensores de luminosidade e temperatura cadastrados no sistema.

| Coluna          | Tipo          | Descrição                                                     |
|-----------------|---------------|---------------------------------------------------------------|
| `CD_SENS`       | `INT`         | Código do sensor, chave primária com incremento automático.    |
| `DS_TIPO_SENS`  | `VARCHAR(30)` | Descrição do tipo de sensor (máximo 30 caracteres).            |
| `DT_VEND`       | `DATETIME`    | Data de venda do sensor. Campo obrigatório.                    |
| `VL_TEMP_ALVO`  | `DECIMAL(5,2)`| Valor de temperatura alvo com 5 dígitos e 2 casas decimais.    |
| `VL_UMID_ALVO`  | `DECIMAL(5,2)`| Valor de umidade alvo com 5 dígitos e 2 casas decimais.        |
| `CD_MOTOR`      | `INT`         | Código do motor relacionado ao sensor.                         |
| `CD_FUNC`       | `INT`         | Chave estrangeira referenciando o funcionário responsável.     |
| `CD_EMPR`       | `INT`         | Chave estrangeira referenciando a empresa parceira relacionada.|

#### Relacionamentos:
- `CD_FUNC`: Referência à tabela `cadr_func` (funcionário responsável pelo cadastro do sensor).
- `CD_EMPR`: Referência à tabela `cadr_empr_parc` (empresa parceira relacionada ao sensor).

### 3. `cadr_empr_parc` - Cadastro de Empresas Parceiras

Tabela que armazena os dados das empresas parceiras envolvidas no fornecimento e suporte dos sensores.

| Coluna          | Tipo          | Descrição                                                    |
|-----------------|---------------|--------------------------------------------------------------|
| `CD_EMPR`       | `INT`         | Código da empresa parceira, chave primária com incremento automático. |
| `NM_EMPR`       | `VARCHAR(30)` | Nome da empresa parceira (máximo 30 caracteres).              |
| `CEP_EMPR`      | `VARCHAR(8)`  | CEP da empresa parceira (8 caracteres).                      |
| `CNPJ_EMPR`     | `VARCHAR(15)` | CNPJ da empresa parceira (15 caracteres).                    |
| `TELF_CONT_EMPR`| `VARCHAR(10)` | Telefone de contato da empresa parceira (10 caracteres).      |
| `CD_FUNC`       | `INT`         | Chave estrangeira referenciando o funcionário responsável.    |

#### Relacionamento:
- `CD_FUNC`: Referência à tabela `cadr_func` (funcionário responsável pela relação com a empresa parceira).

## Considerações Finais

O banco de dados foi estruturado para garantir a rastreabilidade de informações importantes, como a origem e o cadastro de sensores, além de estabelecer relacionamentos entre os funcionários responsáveis e as empresas parceiras. Cada tabela foi desenvolvida com o objetivo de facilitar a gestão dos dispositivos e das entidades envolvidas no processo.
