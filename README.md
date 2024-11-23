# 🚀 LUMITEMP - Sistema para monitoramento de secagem de motores elétricos usando IOT

# 📚 Índice

1. [💻 Tecnologias Utilizadas](#tecnologias-utilizadas)
2. [📜 Introdução](#introdução)
   - [Objetivo](#objetivo)
   - [Descrição da Proposta](#descrição-da-proposta)
6. [🖥️ Hardware](#hardware)
   - [Componentes](#componentes)
   - [Conexões](#conexões)
   - [Diagrama Elétrico](#diagrama-elétrico)
   - [Projeto Físico](#projeto-físico)
7. [🧑‍💻 Software](#software)
   - [FIWARE](#fiware)
8. [🏗️ Visão Geral da Arquitetura](#visão-geral-da-arquitetura)
   - [Diagrama de Arquitetura](#diagrama-de-arquitetura)
10. [🔧 Código do ESP32](#código-do-esp32)
   - [Dependências](#dependências)
   - [Configuração de Rede Wi-Fi e Broker MQTT](#configuração-de-rede-wi-fi-e-broker-mqtt)
   - [Função de Configuração do Sistema](#função-de-configuração-do-sistema)
   - [Loop Principal](#loop-principal)
   - [Reconexão com o Wi-Fi](#reconexão-com-o-wi-fi)
   - [Função Callback MQTT](#função-callback-mqtt)
   - [Funções de Controle e Monitoramento](#funções-de-controle-e-monitoramento)
      - [Verificação de Conexões](#verificação-de-conexões)
      - [Envio de Estado do LED](#envio-de-estado-do-led)
   - [Funções Auxiliares](#funções-auxiliares)
   - [Função de Leitura de Luminosidade](#função-de-leitura-de-luminosidade)
11. [📊 Structured Query Language](#structured-query-language)
   - [Diagrama Conceitual](#diagrama-conceitual)
   - [Diagrama Lógico](#diagrama-lógico)
11. [🗃️ Banco de Dados](#banco-de-dados)
   - [Criação das Tabelas](#criação-das-tabelas)
   - [Criação das Procedures](#criação-das-procedures)
11. [📑 Manual](#manual)
   - [Como Rodar o Sistema](#como-rodar-o-sistema)
   - [Exemplo de Uso](#exemplo-de-uso)
   - [Como Testar](#como-testar)
   - [Cobertura de Testes](cobertura-de-testes)
12. [🤝 Project Members](#project-members)


## 💻 Tecnologias Utilizadas
![JavaScript](https://img.shields.io/badge/JavaScript-323330?style=for-the-badge&logo=javascript&logoColor=F7DF1E)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![HTML5](https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white)
![CSS3](https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white)
![C++](https://img.shields.io/badge/C%2B%2B-00599C?style=for-the-badge&logo=c%2B%2B&logoColor=white)
![Microsoft SQL Server](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)

## 📜 Introdução

### Objetivo
Desenvolver um sistema de monitoramento baseado em Internet das Coisas (IoT) para o controle de estufa de secagem de motores elétricos. Esse sistema deverá obter de forma precisa os dados de temperatura em tempo real, mediante ajustes dinâmicos dos parâmetros de controle, garantido a eficiência operacional. Esse sistema utilizará a plataforma de backend FIWARE para processamento e armazenamento de informações contextuais, visando a otimização do processo de fabricação. A solução permitirá a regulação precisa da temperatura, monitoramento remoto em tempo real e aprimoramento da eficiência operacional, garantindo a produção de motores elétricos de alta qualidade e uniformidade em todas as unidades da empresa. O sistema será complementado por uma plataforma web desenvolvida em ASP.NET MVC, que dará suporte a cadastros e fornecerá visualização de dados em consultas e dashboards.

### Descrição da Proposta
Em um contexto de produção global, uma empresa de motores elétricos enfrenta desafios significativos relacionados ao monitoramento em tempo real da temperatura nas estufas utilizadas para a secagem dos enrolamentos dos motores. Esse processo é crucial para assegurar a qualidade e durabilidade dos produtos, impactando diretamente a eficiência e a confiabilidade dos motores em aplicações industriais, comerciais e residenciais.

A proposta deste projeto é criar um sistema de monitoramento IoT para um protótipo em escala reduzida de uma estufa de secagem. Este protótipo contará com uma resistência de aquecimento e sensores de temperatura, funcionando como um modelo para o desenvolvimento e teste de um sistema de controle e monitoramento térmico baseado em dispositivos IoT. Os testes serão realizados com base em condições reais de produção, proporcionando a oportunidade de desenvolver um sistema robusto e escalável antes de sua aplicação em larga escala em unidades industriais ao redor do mundo.

O protótipo consiste em uma resistência de 6 Ohms com potência de 50W, utilizada para o aquecimento, acoplada a um dissipador de calor e a um sensor de temperatura LM35.

## 🖥️ Hardware

### Componentes

| Componente       | Função                                                                                          | Imagem       |
|------------------|-------------------------------------------------------------------------------------------------|--------------|
| Protoboard       | Construção de circuitos temporários sem solda                                                   | <img src="https://github.com/user-attachments/assets/43ccb680-1546-4225-9526-bfe1e3fc829b" width="250" height="250"> |
| ESP32            | Comunicação com FIWARE via Wi-Fi e Bluetooth                                                    | <img src="https://github.com/user-attachments/assets/aea63641-54cb-41b6-a435-959bf6ee645d" width="250" height="250"> |
| Resistor 10KΩ    | Proteção contra correntes excessivas e leitura precisa de sinais                                | <img src="https://github.com/user-attachments/assets/c20623c0-d764-4970-8d9c-c2642155a82f" width="250" height="250"> |
| Jumper Wires     | Conexão entre componentes                                                                       | <img src="https://github.com/user-attachments/assets/83e9871a-9d96-41eb-a67e-fb5d86d9f0ce" width="250" height="250"> |
| Fonte DC         | Fornecimento de tensão contínua                                                                 | <img src="https://github.com/user-attachments/assets/4e6ff303-c9aa-41b7-833a-441ba92742d5" width="250" height="250"> |
| Cabo de Força    | Transmissão de energia para dispositivos eletrônicos                                            | <img src="https://github.com/user-attachments/assets/6bdb4698-f50f-47df-9d20-79768471e0a5" width="250" height="250"> |
| Cabos Banana     | Conexões seguras para equipamentos                                                              | <img src="https://github.com/user-attachments/assets/d91e1335-3588-43ac-a931-7da2e27fb276" width="250" height="250"> |
| Cabo USB         | Comunicação e alimentação de dispositivos eletrônicos                                           | <img src="https://github.com/user-attachments/assets/0425962d-8de5-4643-bd68-18ba22c9553c" width="250" height="250"> |
| Protótipo        | Simulação do funcionamento da estufa                                                            | <img src="https://github.com/user-attachments/assets/787b509b-2409-42ee-ac23-f2e15ad136dc" width="250" height="250"> |
| Notebook         | Desenvolvimento e monitoramento do sistema                                                      | <img src="https://github.com/user-attachments/assets/22eb6f01-7e89-43a2-b073-e100ba58843b" width="250" height="250"> |


### Conexões
| Componente | Conexão |
|------------|---------|
| ESP32      | ...     |
| Fonte DC   | ...     |
| Protótipo  | ...     |

### Diagrama Elétrico
![Diagrama Elétrico](diagrama_eletrico.png)

### Projeto Físico
![Projeto Físico](projeto_fisico.png)

## 🧑‍💻 Software

### FIWARE
O FIWARE é uma plataforma de código aberto que oferece ferramentas e componentes para desenvolver soluções inteligentes, especialmente para IoT e cidades inteligentes. Ele facilita a integração de dispositivos conectados, gerenciamento de dados em tempo real e a criação de serviços baseados em APIs abertas, como o Context Broker. Com suporte a análise de dados e segurança, o FIWARE é ideal para desenvolver sistemas escaláveis e eficientes, permitindo automação e otimização de processos em diversos setores.

## 🏗️ Visão Geral da Arquitetura
O sistema é composto por três partes principais:

1. **Hardware (ESP32 e sensores):** O ESP32 se conecta aos sensores de temperatura e envia os dados para a plataforma FIWARE via MQTT.
2. **Plataforma FIWARE:** Recebe os dados e gerencia os dispositivos IoT, fornecendo uma interface para análise dos dados.
3. **Plataforma Web:** Interface onde os usuários podem visualizar os dados e controlar os dispositivos remotamente.

### Diagrama de Arquitetura
```plaintext
[Sensor de Temperatura] → [ESP32] → [FIWARE] → [Plataforma Web]
```

![diagrama_camadas](https://github.com/user-attachments/assets/1576a5d7-562f-47af-a26c-0902aa1188af)

## 🔧 Código do ESP32

### Dependências
- **WiFi.h**: Biblioteca para conexão Wi-Fi
- **PubSubClient.h**: Biblioteca MQTT para Arduino

```cpp
#include <WiFi.h>
#include <PubSubClient.h>

// Configurações de Wi-Fi
const char* default_SSID = "POCO F5";
const char* default_PASSWORD = "kanx5025";

// Configurações do Broker MQTT
const char* default_BROKER_MQTT = "4.228.64.5";
const int default_BROKER_PORT = 1883;

// Tópicos MQTT
const String lamp = "03y";
const String mensagem_TOPICO_SUBSCRIBE = "/TEF/lamp" + lamp + "/cmd";
const String mensagem_TOPICO_PUBLISH_1 = "/TEF/lamp" + lamp + "/attrs";
const String mensagem_TOPICO_PUBLISH_2 = "/TEF/lamp" + lamp + "/attrs/t";

// GPIO do LED
const int default_D4 = 2;
```

### Configuração de Rede Wi-Fi e Broker MQTT
Estabelece a conexão com a rede Wi-Fi e o Broker MQTT. Caso a conexão seja perdida, o código tenta reconectar automaticamente.

```cpp
void initWiFi() {
    delay(10);
    Serial.println("------Conexao WI-FI------");
    Serial.print("Conectando-se na rede: ");
    Serial.println(SSID);
    Serial.println("Aguarde");
    reconectWiFi();
}

void initMQTT() {
    MQTT.setServer(BROKER_MQTT, BROKER_PORT);
    MQTT.setCallback(mqtt_callback);
}
```

### Função de Configuração do Sistema
No setup(), são inicializados os componentes necessários, incluindo a configuração da comunicação serial, Wi-Fi e MQTT. Além disso, o LED onboard é inicialmente enviado com o comando de estado "ligado".

```cpp
void setup() {
    InitOutput();
    initSerial();
    initWiFi();
    initMQTT();
    delay(5000);
    MQTT.publish(TOPICO_PUBLISH_1, "s|on");
}
```

### Loop Principal
A função loop() verifica a conexão Wi-Fi e MQTT, envia o estado do LED e trata o envio de dados sobre a luminosidade.

```cpp
void loop() {
    VerificaConexoesWiFIEMQTT();
    EnviaEstadoOutputMQTT();
    handleLuminosity();
    MQTT.loop();
}
```

### Reconexão com o Wi-Fi
A função reconectWiFi() tenta conectar o ESP32 à rede Wi-Fi caso ele perca a conexão. A cada 100 ms é feita uma nova tentativa, até que a conexão seja bem-sucedida.

```cpp
void reconectWiFi() {
    if (WiFi.status() == WL_CONNECTED)
        return;
    WiFi.begin(SSID, PASSWORD);
    while (WiFi.status() != WL_CONNECTED) {
        delay(100);
        Serial.print(".");
    }
    Serial.println();
    Serial.println("Conectado com sucesso na rede ");
    Serial.print(SSID);
    Serial.println("IP obtido: ");
    Serial.println(WiFi.localIP());

    // Garantir que o LED inicie desligado
    digitalWrite(D4, LOW);
}
```

### Função Callback MQTT
A função mqtt_callback() é responsável por tratar as mensagens recebidas do Broker MQTT. Caso a mensagem seja para ligar o LED, o pino D4 é configurado como HIGH (LED ligado). Caso contrário, o LED é desligado.

```cpp
void mqtt_callback(char* topic, byte* payload, unsigned int length) {
    String msg;
    for (int i = 0; i < length; i++) {
        char c = (char)payload[i];
        msg += c;
    }
    Serial.print("- Mensagem recebida: ");
    Serial.println(msg);

    // Forma o padrão de tópico para comparação
    String onTopic = String(topicPrefix) + "@on|";
    String offTopic = String(topicPrefix) + "@off|";

    // Compara com o tópico recebido
    if (msg.equals(onTopic)) {
        digitalWrite(D4, HIGH);
        EstadoSaida = '1';
    }

    if (msg.equals(offTopic)) {
        digitalWrite(D4, LOW);
        EstadoSaida = '0';
    }
}
```

### Funções de Controle e Monitoramento
Essas funções são responsáveis por garantir que o LED e o sensor de luminosidade funcionem corretamente.

#### Verificação de Conexões
A função VerificaConexoesWiFIEMQTT() garante que o Wi-Fi e o MQTT estejam conectados, e reconecta caso necessário.

```cpp
void VerificaConexoesWiFIEMQTT() {
    if (!MQTT.connected())
        reconnectMQTT();
    reconectWiFi();
}
```

#### Envio de Estado do LED
A função EnviaEstadoOutputMQTT() publica o estado do LED no Broker MQTT e imprime o status no monitor serial.

```cpp
void EnviaEstadoOutputMQTT() {
    if (EstadoSaida == '1') {
        MQTT.publish(TOPICO_PUBLISH_1, "s|on");
        Serial.println("- Led Ligado");
    }

    if (EstadoSaida == '0') {
        MQTT.publish(TOPICO_PUBLISH_1, "s|off");
        Serial.println("- Led Desligado");
    }
    Serial.println("- Estado do LED onboard enviado ao broker!");
    delay(1000);
}
```

### Funções Auxiliares
InitOutput(): Inicializa o pino do LED e realiza um pisca-pisca para indicar que o sistema foi iniciado.
reconnectMQTT(): Tenta reconectar ao Broker MQTT caso a conexão seja perdida.
handleLuminosity(): Lê o valor de luminosidade de um sensor analógico (conectado no pino 34) e envia esse valor para o Broker MQTT.

```cpp
void InitOutput() {
    pinMode(D4, OUTPUT);
    digitalWrite(D4, HIGH);
    boolean toggle = false;

    for (int i = 0; i <= 10; i++) {
        toggle = !toggle;
        digitalWrite(D4, toggle);
        delay(200);
    }
}
```

### Função de Leitura de Luminosidade
Lê um valor de luminosidade de um potenciômetro e publica este valor no Broker MQTT.

```cpp
void handleLuminosity() {
    const int potPin = 34;
    int sensorValue = analogRead(potPin);
    int luminosity = map(sensorValue, 0, 4095, 0, 100);
    String mensagem = String(luminosity);
    Serial.print("Valor da luminosidade: ");
    Serial.println(mensagem.c_str());
    MQTT.publish(TOPICO_PUBLISH_2, mensagem.c_str());
}
```

## 📊 Structured Query Language

### Diagrama Conceitual
![Diagrama Conceitual](diagrama_eletrico.png)

### Diagrama Lógico
![Diagrama Lógico](projeto_fisico.png)

## 🗃️ Banco de Dados

### Criação das Tabelas
Cria o banco de dados principal para gerenciamento de luminosidade e temperatura

```sql
CREATE DATABASE b_lumitemp_main_db

GO
```

Define o banco de dados a ser utilizado como o contexto atual

```sql
USE b_lumitemp_main_db

GO
```

Remove a tabela de cadastro de funcionários caso ela já exista

```sql
DROP TABLE IF EXISTS cadr_func;
```

Cria a tabela de cadastro de funcionários

```sql
CREATE TABLE cadr_func (
    ID INT PRIMARY KEY,                     -- Código do funcionário, chave primária com incremento automático
    LOGIN_FUNC VARCHAR(30),                 -- Login do funcionário (máximo 30 caracteres)
    SENHA_FUNC VARCHAR(30),                 -- Senha do funcionário (máximo 30 caracteres)
    DT_CADR DATE,                           -- Data de cadastro do funcionário
    IMAGEM VARBINARY(MAX)                   -- Imagem do funcionário
);

GO
```

Remove a tabela de cadastro de empresas parceiras caso ela já exista

```sql
DROP TABLE IF EXISTS cadr_empr_parc;
```

Cria a tabela de cadastro de empresas parceiras

```sql
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
);

GO
```

Remove a tabela de cadastro de sensores caso ela já exista

```sql
DROP TABLE IF EXISTS cadr_sens;
```

Cria a tabela de cadastro de sensores

```sql
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
);
```

### Criação das Procedures

Exclui as procedures se já existirem para recriá-las

```sql
DROP PROCEDURE IF EXISTS spDelete
DROP PROCEDURE IF EXISTS spConsulta
DROP PROCEDURE IF EXISTS spListagem
DROP PROCEDURE IF EXISTS spProximoId
DROP PROCEDURE IF EXISTS spInsert_cadr_empr_parc
DROP PROCEDURE IF EXISTS spUpdate_cadr_empr_parc
DROP PROCEDURE IF EXISTS spInsert_cadr_func
DROP PROCEDURE IF EXISTS spUpdate_cadr_func
DROP PROCEDURE IF EXISTS spConsultaAvancadaFuncionarios
DROP PROCEDURE IF EXISTS spInsert_cadr_sens
DROP PROCEDURE IF EXISTS spUpdate_cadr_sens

GO
```

Criação da procedure spDelete para deletar um registro baseado no ID

```sql
CREATE PROCEDURE spDelete
(
    -- Declaração dos parâmetros que serão utilizados
    @ID INT,                               -- ID do registro a ser deletado
    @tabela VARCHAR(MAX)                   -- Nome da tabela onde o registro será deletado
)
AS
BEGIN
    -- Declarar a variável para armazenar a consulta SQL
    DECLARE @sql VARCHAR(MAX);
    -- Montar a consulta SQL para deletar o registro pelo ID
    SET @sql = 'DELETE FROM ' + @tabela +
               ' WHERE ID = ' + CAST(@ID AS VARCHAR(MAX));
    -- Executar a consulta SQL
    EXEC(@sql)
END

GO
```

Criação da procedure spConsulta para consultar registros baseados no ID

```sql
CREATE PROCEDURE spConsulta
(
    -- Declaração dos parâmetros que serão utilizados
    @id INT,                               -- ID do registro a ser consultado
    @tabela VARCHAR(MAX)                   -- Nome da tabela onde o registro será consultado
)
AS
BEGIN
    -- Declarar a variável para armazenar a consulta SQL
    DECLARE @sql VARCHAR(MAX);
    -- Montar a consulta SQL para selecionar registros pelo ID
    SET @sql = 'SELECT * FROM ' + @tabela +
               ' WHERE id = ' + CAST(@id AS VARCHAR(MAX));
    -- Executar a consulta SQL
    EXEC(@sql)
END

GO
```

Criação da procedure spListagem para listar registros ordenados por um campo específico

```sql
CREATE PROCEDURE spListagem
(
    -- Declaração dos parâmetros que serão utilizados
    @tabela VARCHAR(MAX),                  -- Nome da tabela a ser consultada
    @ordem VARCHAR(MAX)                    -- Nome do campo pelo qual os registros serão ordenados
)
AS
BEGIN
    -- Executar a consulta SQL para listar os registros ordenados
    EXEC('SELECT * FROM ' + @tabela +
         ' ORDER BY ' + @ordem)
END

GO
```

Criação da procedure spProximoId para obter o próximo ID disponível na tabela

```sql
CREATE PROCEDURE spProximoId
(
    -- Declaração dos parâmetros que serão utilizados
    @tabela VARCHAR(MAX)                   -- Nome da tabela para obter o próximo ID
)
AS
BEGIN
    -- Executar a consulta SQL para obter o maior ID e incrementar em 1
    EXEC('SELECT ISNULL(MAX(id) + 1, 1) AS MAIOR FROM ' + @tabela)
END
```

Criação da procedure spInsert_cadr_empr_parc para inserir uma nova empresa parceira

```sql
CREATE PROCEDURE spInsert_cadr_empr_parc
(
    -- Declaração dos parâmetros que serão utilizados
    @ID INT,                               -- ID da empresa
    @NM_EMPR VARCHAR(30),                  -- Nome da empresa
    @CEP_EMPR VARCHAR(30),                 -- CEP da empresa
    @LOG_EMPR VARCHAR(30),                 -- Logradouro da empresa
    @NUM_EMPR VARCHAR(4),                  -- Número da empresa
    @COMPL_EMPR VARCHAR(30),               -- Complemento do endereço da empresa
    @BAIRRO_EMPR VARCHAR(20),              -- Bairro da empresa
    @CIDADE_EMPR VARCHAR(20),              -- Cidade da empresa
    @ESTADO_EMPR VARCHAR(2),               -- Estado da empresa
    @CNPJ_EMPR VARCHAR(15),                -- CNPJ da empresa
    @TELF_CONT_EMPR VARCHAR(10),           -- Telefone de contato da empresa
    @ID_FUNC INT                           -- ID do funcionário responsável pela empresa (chave estrangeira)
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
```

Criação da procedure spUpdate_cadr_empr_parc para alterar os dados de uma empresa existente

```sql
CREATE PROCEDURE spUpdate_cadr_empr_parc
(
    -- Declaração dos parâmetros que serão utilizados
    @ID INT,                               -- ID da empresa
    @NM_EMPR VARCHAR(30),                  -- Nome da empresa
    @CEP_EMPR VARCHAR(30),                 -- CEP da empresa
    @LOG_EMPR VARCHAR(30),                 -- Logradouro da empresa
    @NUM_EMPR VARCHAR(4),                  -- Número da empresa
    @COMPL_EMPR VARCHAR(30),               -- Complemento do endereço da empresa
    @BAIRRO_EMPR VARCHAR(20),              -- Bairro da empresa
    @CIDADE_EMPR VARCHAR(20),              -- Cidade da empresa
    @ESTADO_EMPR VARCHAR(2),               -- Estado da empresa
    @CNPJ_EMPR VARCHAR(15),                -- CNPJ da empresa
    @TELF_CONT_EMPR VARCHAR(11),           -- Telefone de contato da empresa
    @ID_FUNC INT                           -- ID do funcionário responsável pela empresa (chave estrangeira)
) 
AS
BEGIN
    -- Atualiza o registro da empresa na tabela 'cadr_empr_parc' com os novos dados
    UPDATE cadr_empr_parc SET
        NM_EMPR = @NM_EMPR,                -- Nome da empresa
        CEP_EMPR = @CEP_EMPR,              -- CEP da empresa
        LOG_EMPR = @LOG_EMPR,              -- Logradouro da empresa
        NUM_EMPR = @NUM_EMPR,              -- Número da empresa
        COMPL_EMPR = @COMPL_EMPR,          -- Complemento do endereço da empresa
        BAIRRO_EMPR = @BAIRRO_EMPR,        -- Bairro da empresa
        CIDADE_EMPR = @CIDADE_EMPR,        -- Cidade da empresa
        ESTADO_EMPR = @ESTADO_EMPR,        -- Estado da empresa
        CNPJ_EMPR = @CNPJ_EMPR,            -- CNPJ da empresa
        TELF_CONT_EMPR = @TELF_CONT_EMPR,  -- Telefone de contato da empresa
        ID_FUNC = @ID_FUNC                 -- ID do funcionário responsável pela empresa
    WHERE ID = @ID                         -- Condição para identificar a empresa a ser atualizada
END
GO
```

Criação da procedure spInsert_cadr_func para inserir um novo funcionário

```sql
CREATE PROCEDURE spInsert_cadr_func
(
    -- Declaração dos parâmetros que serão utilizados na inserção
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
```

Criação da procedure spUpdate_cadr_func para alterar os dados de um funcionário existente

```sql
CREATE PROCEDURE spUpdate_cadr_func
(
    -- Declaração dos parâmetros que serão utilizados na atualização
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
```

Criação da procedure spConsultaAvancadaFuncionarios para consultar funcionários

```sql
CREATE PROCEDURE spConsultaAvancadaFuncionarios
(
    -- Declaração dos parâmetros para a consulta avançada
    @descricao varchar(max),
    @dataInicial datetime,
    @dataFinal datetime
)
AS
BEGIN
    -- Seleciona registros na tabela cadr_func com base em critérios fornecidos
    SELECT * FROM cadr_func
    WHERE cadr_func.DT_CADR BETWEEN @dataInicial AND @dataFinal
    AND cadr_func.LOGIN_FUNC LIKE '%' + @descricao + '%'
END
GO
```

Criação da procedure spInsert_cadr_sens para inserir um novo sensor

```sql
CREATE PROCEDURE spInsert_cadr_sens
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
```

Criação da procedure spUpdate_cadr_sens para alterar os dados de um sensor existente

```sql
CREATE PROCEDURE spUpdate_cadr_sens
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
```

## 📑 Manual

### Como Rodar o Sistema
1. **Carregar o código no ESP32:**
   - Conecte o ESP32 à sua máquina e faça upload do código para o microcontrolador usando o Arduino IDE.
   - O código fará a leitura de temperatura via sensor e enviará os dados para a plataforma FIWARE via MQTT.

2. **Acessar a Plataforma Web:**
   - Abra o navegador e acesse a plataforma web configurada para visualizar os dados de temperatura em tempo real.

### Exemplo de Uso
- **Monitoramento em Tempo Real:**
  Após a configuração, a temperatura do motor estará visível na interface web. Você poderá visualizar gráficos e alertas de temperatura.

### Como Testar

1. **Testar o envio de dados:** Após configurar o ESP32, verifique se os dados estão sendo enviados corretamente para a plataforma FIWARE.
2. **Testar a interface web:** Acesse a plataforma web e confira se as informações estão sendo exibidas corretamente e se os gráficos de temperatura estão atualizados.

### Cobertura de Testes

- **Testes de conectividade:** Garantir que o ESP32 está se conectando corretamente à rede Wi-Fi.
- **Testes de visualização de dados:** Verificar se a interface web está recebendo e exibindo os dados de temperatura em tempo real.

## 🤝 Project Members

- Enzo Brito Alves de Oliveira - RA: 082220040
- Erikson Vieira Queiroz - RA: 082220021
- Guilherme Alves Barbosa - RA: 082220014
- Heitor Santos Ferreira - RA: 081230042
- Tainara do Nascimento Casimiro - RA: 082220011
- William Santim - RA: 082220033
