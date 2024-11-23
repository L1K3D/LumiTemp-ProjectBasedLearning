# LUMITEMP - Sistema para monitoramento de secagem de motores elétricos usando IOT

## Tecnologias
![JavaScript](https://img.shields.io/badge/JavaScript-323330?style=for-the-badge&logo=javascript&logoColor=F7DF1E)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![HTML5](https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white)
![CSS3](https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white)
![C++](https://img.shields.io/badge/C%2B%2B-00599C?style=for-the-badge&logo=c%2B%2B&logoColor=white)
![Microsoft SQL Server](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)


## Objetivo
Desenvolver um sistema de monitoramento baseado em Internet das Coisas (IoT) para o controle de estufa de secagem de motores elétricos. Esse sistema deverá obter de forma precisa os dados de temperatura em tempo real, mediante ajustes dinâmicos dos parâmetros de controle, garantido a eficiência operacional. Esse sistema utilizará a plataforma de backend FIWARE para processamento e armazenamento de informações contextuais, visando a otimização do processo de fabricação. A solução permitirá a regulação precisa da temperatura, monitoramento remoto em tempo real e aprimoramento da eficiência operacional, garantindo a produção de motores elétricos de alta qualidade e uniformidade em todas as unidades da empresa. O sistema será complementado por uma plataforma web desenvolvida em ASP.NET MVC, que dará suporte a cadastros e fornecerá visualização de dados em consultas e dashboards.

## Descrição da Proposta
Em um contexto de produção global, uma empresa de motores elétricos enfrenta desafios significativos relacionados ao monitoramento em tempo real da temperatura nas estufas utilizadas para a secagem dos enrolamentos dos motores. Esse processo é crucial para assegurar a qualidade e durabilidade dos produtos, impactando diretamente a eficiência e a confiabilidade dos motores em aplicações industriais, comerciais e residenciais.

A proposta deste projeto é criar um sistema de monitoramento IoT para um protótipo em escala reduzida de uma estufa de secagem. Este protótipo contará com uma resistência de aquecimento e sensores de temperatura, funcionando como um modelo para o desenvolvimento e teste de um sistema de controle e monitoramento térmico baseado em dispositivos IoT. Os testes serão realizados com base em condições reais de produção, proporcionando a oportunidade de desenvolver um sistema robusto e escalável antes de sua aplicação em larga escala em unidades industriais ao redor do mundo.

O protótipo consiste em uma resistência de 6 Ohms com potência de 50W, utilizada para o aquecimento, acoplada a um dissipador de calor e a um sensor de temperatura LM35.

## Hardware

### Componentes

| Componente       | Função                                                                                          | Imagem       |
|------------------|-------------------------------------------------------------------------------------------------|--------------|
| Protoboard       | Construção de circuitos temporários sem solda                                                   | ![Imagem](URL_PROTOBOARD) |
| ESP32            | Comunicação com FIWARE via Wi-Fi e Bluetooth                                                    | ![Imagem](URL_ESP32)      |
| Resistor 10KΩ    | Proteção contra correntes excessivas e leitura precisa de sinais                                | ![Imagem](URL_RESISTOR)   |
| Jumper Wires     | Conexão entre componentes                                                                       | ![Imagem](URL_JUMPER)     |
| Fonte DC         | Fornecimento de tensão contínua                                                                 | ![Imagem](URL_FONTE_DC)   |
| Cabo de Força    | Transmissão de energia para dispositivos eletrônicos                                            | ![Imagem](URL_CABO_FORCA) |
| Cabos Banana     | Conexões seguras para equipamentos                                                              | ![Imagem](URL_CABO_BANANA)|
| Cabo USB         | Comunicação e alimentação de dispositivos eletrônicos                                           | ![Imagem](URL_CABO_USB)   |
| Protótipo        | Simulação do funcionamento da estufa                                                            | ![Imagem](URL_PROTOIPO)   |
| Notebook         | Desenvolvimento e monitoramento do sistema                                                      | ![Imagem](URL_NOTEBOOK)   |


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

## Software

### FIWARE
FIWARE é uma plataforma aberta que oferece ferramentas para interoperabilidade entre dispositivos IoT. Com o **Orion Context Broker**, o sistema gerencia dados em tempo real, possibilitando a tomada de decisões automatizadas com base na temperatura. Componentes são implantados via Docker, e APIs RESTful e MQTT garantem a comunicação e integração de dados com o ESP32.

### Diagrama em Camadas da Aplicação
![Diagrama em Camadas](diagrama_camadas.png)

## Código do ESP32

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
### Tópicos MQTT Utilizados


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

## Structured Query Language

### Diagrama Conceitual
![Diagrama Conceitual](diagrama_eletrico.png)

### Diagrama Lógico
![Diagrama Lógico](projeto_fisico.png)

## Banco de Dados

### Criação do Banco de Dados
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

