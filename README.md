# 🚀 LUMITEMP - System for Monitoring Electric Motor Drying Using IoT

# 📚 Table of Contents

1. [💻 Technologies Used](#technologies-used)
2. [📜 Introduction](#introduction)
   - [Objective](#objective)
   - [Proposal Description](#proposal-description)
6. [🖥️ Hardware](#hardware)
   - [Components](#components)
   - [Connections](#connections)
   - [Electrical Diagram](#electrical-diagram)
   - [Physical Project](#physical-project)
7. [🧑‍💻 Software](#software)
   - [FIWARE](#fiware)
8. [🏗️ Architecture Overview](#architecture-overview)
   - [Architecture Diagram](#architecture-diagram)
10. [🔧 ESP32 Code](#esp32-code)
   - [Dependencies](#dependencies)
   - [Wi-Fi and MQTT Broker Configuration](#wi-fi-and-mqtt-broker-configuration)
   - [System Setup Function](#system-setup-function)
   - [Main Loop](#main-loop)
   - [Wi-Fi Reconnection](#wi-fi-reconnection)
   - [MQTT Callback Function](#mqtt-callback-function)
   - [Control and Monitoring Functions](#control-and-monitoring-functions)
      - [Connection Verification](#connection-verification)
      - [LED State Transmission](#led-state-transmission)
   - [Helper Functions](#helper-functions)
11. [🗃️ Database](#database)
   - [Table Creation](#table-creation)
   - [Procedure Creation](#procedure-creation)
11. [📑 Manual](#manual)
   - [How to Run the System](#how-to-run-the-system)
   - [Example of Use](#example-of-use)
   - [How to Test](#how-to-test)
   - [Test Coverage](#test-coverage)
12. [🤝 Project Members](#project-members)


## 💻 Technologies Used
![JavaScript](https://img.shields.io/badge/JavaScript-323330?style=for-the-badge&logo=javascript&logoColor=F7DF1E)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![HTML5](https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white)
![CSS3](https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white)
![C++](https://img.shields.io/badge/C%2B%2B-00599C?style=for-the-badge&logo=c%2B%2B&logoColor=white)
![Microsoft SQL Server](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)

## 📜 Introduction

### Objective
Develop an IoT-based monitoring system for controlling the drying oven of electric motors. This system should accurately obtain real-time temperature data through dynamic control parameter adjustments, ensuring operational efficiency. It will use the FIWARE backend platform for processing and storing contextual information, aiming to optimize the manufacturing process. The solution will enable precise temperature regulation, real-time remote monitoring, and enhanced operational efficiency, ensuring the production of high-quality electric motors with consistency across all company units. The system will be complemented by a web platform developed in ASP.NET MVC, supporting registrations and providing data visualization through queries and dashboards.

### Proposal Description
In a global production context, an electric motor company faces significant challenges related to real-time temperature monitoring in ovens used for drying motor windings. This process is crucial for ensuring the quality and durability of the products, directly impacting the efficiency and reliability of the motors in industrial, commercial, and residential applications.

The project's proposal is to create an IoT monitoring system for a reduced-scale prototype of a drying oven. This prototype will have a heating resistor and temperature sensors, serving as a model for developing and testing a thermal control and monitoring system based on IoT devices. Tests will be conducted under real production conditions, offering the opportunity to develop a robust and scalable system before its large-scale application in industrial units worldwide.

The prototype consists of a 6-ohm, 50W heating resistor used for heating, attached to a heat sink and an LM35 temperature sensor.

## 🖥️ Hardware

### Components

| Component        | Function                                                                                       | Image        |
|------------------|------------------------------------------------------------------------------------------------|--------------|
| Breadboard       | Construction of temporary circuits without soldering                                           | <img src="https://github.com/user-attachments/assets/43ccb680-1546-4225-9526-bfe1e3fc829b" width="350" height="250"> |
| ESP32            | Communication with FIWARE via Wi-Fi and Bluetooth                                              | <img src="https://github.com/user-attachments/assets/aea63641-54cb-41b6-a435-959bf6ee645d" width="350" height="250"> |
| 10KΩ Resistor    | Protection against excessive currents and accurate signal reading                              | <img src="https://github.com/user-attachments/assets/c20623c0-d764-4970-8d9c-c2642155a82f" width="350" height="250"> |
| Jumper Wires     | Connection between components                                                                  | <img src="https://github.com/user-attachments/assets/83e9871a-9d96-41eb-a67e-fb5d86d9f0ce" width="350" height="250"> |
| DC Power Supply  | Providing continuous voltage                                                                   | <img src="https://github.com/user-attachments/assets/4e6ff303-c9aa-41b7-833a-441ba92742d5" width="350" height="250"> |
| Power Cable      | Power transmission for electronic devices                                                      | <img src="https://github.com/user-attachments/assets/6bdb4698-f50f-47df-9d20-79768471e0a5" width="350" height="250"> |
| Banana Cable     | Secure connections for equipment                                                               | <img src="https://github.com/user-attachments/assets/d91e1335-3588-43ac-a931-7da2e27fb276" width="350" height="250"> |
| USB Cable        | Communication and power for electronic devices                                                 | <img src="https://github.com/user-attachments/assets/0425962d-8de5-4643-bd68-18ba22c9553c" width="350" height="250"> |
| Prototype        | Simulation of the greenhouse operation                                                         | <img src="https://github.com/user-attachments/assets/787b509b-2409-42ee-ac23-f2e15ad136dc" width="350" height="250"> |
| Laptop           | System development and monitoring                                                              | <img src="https://github.com/user-attachments/assets/22eb6f01-7e89-43a2-b073-e100ba58843b" width="350" height="250"> |


### Connections
| Component | Connection |
|-----------|------------|
| ESP32     | Connects to Wi-Fi and MQTT broker to transmit data |
| DC Power Supply | Powers the system |
| Prototype | Connects to temperature and heating elements for control |

### Electrical Diagram
![Diagrama Eletrico](https://github.com/user-attachments/assets/344704d4-6a32-4f0e-82db-04b97bd81879)

### Physical Project
![Projeto Fisico](https://github.com/user-attachments/assets/0613bbed-6c72-4048-b0f5-aeebe96815ce)

## 🧑‍💻 Software

### FIWARE
FIWARE is an open-source platform that provides tools and components for developing smart solutions, especially for IoT and smart cities. It facilitates the integration of connected devices, real-time data management, and the creation of services based on open APIs, such as the Context Broker. With support for data analytics and security, FIWARE is ideal for developing scalable and efficient systems, enabling process automation and optimization across various sectors.

## 🏗️ System Architecture
The system consists of the following key components:

1. **Hardware (ESP32 and sensors):** Collects and transmits temperature data via Wi-Fi and MQTT.
2. **FIWARE Platform:** Manages IoT data and devices, allowing users to control and monitor systems remotely.
3. **Web Interface:** Provides an interface for user interaction, allowing temperature control and system monitoring.

### Architecture Diagram
```plaintext
[Temperature Sensor] → [ESP32] → [FIWARE] → [Web Platform]
````

![diagrama_camadas](https://github.com/L1K3D/LumiTemp-ProjectBasedLearning/blob/main/Fiware/FiwareDeploy_new_v4.png?raw=true)

## 🔧 ESP32 Code

### Dependencies
- **WiFi.h**: Library for Wi-Fi connection
- **PubSubClient.h**: MQTT library for Arduino

```cpp
#include <WiFi.h>
#include <PubSubClient.h>

// Settings - editable variables
const char* default_SSID = "your_wifi_network"; // Wi-Fi network name
const char* default_PASSWORD = "your_wifi_password"; // Wi-Fi network password
const char* default_BROKER_MQTT = "ip_host_fiware"; // IP of the MQTT Broker
const int default_BROKER_PORT = 1883; // Port of the MQTT Broker
const char* default_TOPICO_SUBSCRIBE = "/TEF/lamp001/cmd"; // MQTT topic for listening
const char* default_TOPICO_PUBLISH_1 = "/TEF/lamp001/attrs"; // MQTT topic for sending information to the Broker
const char* default_TOPICO_PUBLISH_2 = "/TEF/lamp001/attrs/l"; // MQTT topic for sending information to the Broker
const char* default_ID_MQTT = "fiware_001"; // MQTT ID
const int default_D4 = 2; // Onboard LED pin
```

### Wi-Fi and MQTT Broker Configuration
Establishes the connection to the Wi-Fi network and the MQTT Broker. If the connection is lost, the code attempts to reconnect automatically.

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

### System Setup Function
In the setup(), the necessary components are initialized, including the configuration of serial communication, Wi-Fi, and MQTT. Additionally, the onboard LED is initially set to the "on" state command.

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

### Main Loop
The loop() function checks the Wi-Fi and MQTT connection, sends the LED state, and handles the transmission of data about the brightness.

```cpp
void loop() {
    VerificaConexoesWiFIEMQTT();
    EnviaEstadoOutputMQTT();
    handleLuminosity();
    MQTT.loop();
}
```

### Wi-Fi Reconnection
The reconnectWiFi() function attempts to reconnect the ESP32 to the Wi-Fi network if the connection is lost. A new attempt is made every 100 ms until the connection is successful.

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

    // Ensure that the LED starts off
    digitalWrite(D4, LOW);
}
```

### MQTT Callback Function
The mqtt_callback() function is responsible for handling messages received from the MQTT Broker. If the message is to turn on the LED, pin D4 is set to HIGH (LED on). Otherwise, the LED is turned off.

```cpp
void mqtt_callback(char* topic, byte* payload, unsigned int length) {
    String msg;
    for (int i = 0; i < length; i++) {
        char c = (char)payload[i];
        msg += c;
    }
    Serial.print("- Mensagem recebida: ");
    Serial.println(msg);

    // Forms the topic pattern for comparison
    String onTopic = String(topicPrefix) + "@on|";
    String offTopic = String(topicPrefix) + "@off|";

    // Compares with the received topic
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

### Control and Monitoring Functions
These functions are responsible for ensuring that the LED and the brightness sensor operate correctly.

#### Connection Verification
The VerificaConexoesWiFIEMQTT() function ensures that Wi-Fi and MQTT are connected, and reconnects if necessary.

```cpp
void VerificaConexoesWiFIEMQTT() {
    if (!MQTT.connected())
        reconnectMQTT();
    reconectWiFi();
}
```

#### LED State Transmission
The EnviaEstadoOutputMQTT() function publishes the LED state to the MQTT Broker and prints the status to the serial monitor.

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

### Helper Functions
InitOutput(): Initializes the LED pin and performs a blink to indicate that the system has started.
reconnectMQTT(): Attempts to reconnect to the MQTT Broker if the connection is lost.
handleLuminosity(): Reads the brightness value from an analog sensor (connected to pin 34) and sends this value to the MQTT Broker.

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

## 🗃️ Database
This database was developed to manage brightness and temperature sensors, as well as store information about responsible employees and partner companies. The goal is to monitor and control sensor data in industrial or commercial environments.

The main database (b_lumitemp_main_db) is used to store information about employees, sensors, and partner companies involved in the sensor management system.

```sql
CREATE DATABASE b_lumitemp_main_db

GO
```

Define the database to be used as the current context.

```sql
USE b_lumitemp_main_db

GO
```
### Table Creation

**Remove the employee registration table if it already exists**

```sql
DROP TABLE IF EXISTS cadr_func;
```

**Create the Employee Registration Table (cadr_func):** Table responsible for storing the data of employees who have access to the system.

```sql
CREATE TABLE cadr_func (
    ID INT PRIMARY KEY,                     -- Employee code, primary key with auto-increment
    LOGIN_FUNC VARCHAR(30),                 -- Employee login (maximum 30 characters)
    SENHA_FUNC VARCHAR(30),                 -- Employee password (maximum 30 characters)
    DT_CADR DATE,                           -- Employee registration date
    IMAGEM VARBINARY(MAX)                   -- Employee image
);

GO
```
| Column        | Type          | Description                                              |
|---------------|---------------|----------------------------------------------------------|
| `CD_FUNC`     | `INT`         | Employee code, primary key with auto-increment.          |
| `LOGIN_FUNC`  | `VARCHAR(30)` | Employee login (maximum 30 characters).                  |
| `SENHA_FUNC`  | `VARCHAR(30)` | Employee password (maximum 30 characters).               |
| `DT_CADR`     | `DATE`        | Employee registration date.                              |

**Remove the partner companies registration table if it already exists**

```sql
DROP TABLE IF EXISTS cadr_empr_parc;
```

**Create the Partner Companies Registration Table (cadr_empr_parc)**: Table that stores the data of partner companies involved in the supply and support of the sensors.

```sql
CREATE TABLE cadr_empr_parc (
    ID INT PRIMARY KEY,                     -- Partner company code, primary key with auto-increment
    NM_EMPR VARCHAR(30),                    -- Partner company name (maximum 30 characters)
    CEP_EMPR VARCHAR(8),                    -- Partner company ZIP code (8 characters)
    LOG_EMPR VARCHAR(30),                   -- Partner company address (maximum 30 characters)
    NUM_EMPR VARCHAR(4),                    -- Partner company address number (maximum 4 characters)
    COMPL_EMPR VARCHAR(30),                 -- Partner company address complement (maximum 30 characters)
    BAIRRO_EMPR VARCHAR(20),                -- Partner company neighborhood (maximum 20 characters)
    CIDADE_EMPR VARCHAR(20),                -- Partner company city (maximum 20 characters)
    ESTADO_EMPR VARCHAR(2),                 -- Partner company state (maximum 2 characters)
    CNPJ_EMPR VARCHAR(15),                  -- Partner company CNPJ (15 characters)
    TELF_CONT_EMPR VARCHAR(11),             -- Partner company contact phone (11 characters)
    ID_FUNC INT,                            -- Responsible employee code (foreign key)
    CONSTRAINT FK_CD_FUNC FOREIGN KEY (ID_FUNC)  
        REFERENCES cadr_func(ID)            -- Foreign key referencing 'ID' from 'cadr_func' table
);

GO
```

| Column           | Type          | Description                                                    |
|------------------|---------------|----------------------------------------------------------------|
| `CD_EMPR`        | `INT`         | Partner company code, primary key with auto-increment.         |
| `NM_EMPR`        | `VARCHAR(30)` | Partner company name (maximum 30 characters).                  |
| `CEP_EMPR`       | `VARCHAR(8)`  | Partner company ZIP code (8 characters).                       |
| `CNPJ_EMPR`      | `VARCHAR(15)` | Partner company CNPJ (15 characters).                          |
| `TELF_CONT_EMPR` | `VARCHAR(10)` | Partner company contact phone (10 characters).                 |
| `CD_FUNC`        | `INT`         | Foreign key referencing the responsible employee.              |

**Remove the sensors registration table if it already exists**

```sql
DROP TABLE IF EXISTS cadr_sens;
```

**Create the Sensors Registration Table (cadr_sens)**: Table that stores information about the light and temperature sensors registered in the system.

```sql
CREATE TABLE cadr_sens (
    ID INT PRIMARY KEY,                     -- Sensor code, primary key with auto-increment
    DS_TIPO_SENS VARCHAR(MAX),              -- Description of the sensor type
    DT_VEND DATE,                           -- Sensor sale date, required field
    VL_TEMP_ALVO DECIMAL(5, 2),             -- Target temperature value with 5 digits and 2 decimal places
    CD_MOTOR INT,                           -- Motor code related to the sensor
    ID_FUNC INT,                            -- Responsible employee code (foreign key)
    CONSTRAINT FK_CD_FUNC_SENS FOREIGN KEY (ID_FUNC)  -- Unique name for the foreign key of 'ID_FUNC'
        REFERENCES cadr_func(ID),
    ID_EMPR INT,                            -- Partner company code (foreign key)
    CONSTRAINT FK_CD_EMPR_SENS FOREIGN KEY (ID_EMPR)  -- Unique name for the foreign key of 'ID_EMPR'
        REFERENCES cadr_empr_parc(ID)
);
```
| Column          | Type          | Description                                                     |
|-----------------|---------------|---------------------------------------------------------------|
| `CD_SENS`       | `INT`         | Sensor code, primary key with auto-increment.                   |
| `DS_TIPO_SENS`  | `VARCHAR(30)` | Description of the sensor type (maximum 30 characters).         |
| `DT_VEND`       | `DATETIME`    | Sensor sale date. Required field.                               |
| `VL_TEMP_ALVO`  | `DECIMAL(5,2)`| Target temperature value with 5 digits and 2 decimal places.    |
| `VL_UMID_ALVO`  | `DECIMAL(5,2)`| Target humidity value with 5 digits and 2 decimal places.       |
| `CD_MOTOR`      | `INT`         | Motor code related to the sensor.                               |
| `CD_FUNC`       | `INT`         | Foreign key referencing the responsible employee.               |
| `CD_EMPR`       | `INT`         | Foreign key referencing the related partner company.            |

### Procedure Creation

Drop the procedures if they already exist in order to recreate them.

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

Creation of the "spDelete" procedure to delete a record based on the ID

```sql
CREATE PROCEDURE spDelete
(
    -- Declaration of parameters to be used
    @ID INT,                               -- ID of the record to be deleted
    @tabela VARCHAR(MAX)                   -- Name of the table where the record will be deleted
)
AS
BEGIN
    -- Declare the variable to store the SQL query
    DECLARE @sql VARCHAR(MAX);
    -- Build the SQL query to delete the record by ID
    SET @sql = 'DELETE FROM ' + @tabela +
               ' WHERE ID = ' + CAST(@ID AS VARCHAR(MAX));
    -- Execute the SQL query
    EXEC(@sql)
END

GO
```

Creation of the "spConsulta" procedure to query records based on the ID

```sql
CREATE PROCEDURE spConsulta
(
    -- Declaration of the parameters to be used
    @id INT,                               -- ID of the record to be queried
    @tabela VARCHAR(MAX)                   -- Name of the table where the record will be queried
)
AS
BEGIN
    -- Declare the variable to store the SQL query
    DECLARE @sql VARCHAR(MAX);
    -- Build the SQL query to select records by ID
    SET @sql = 'SELECT * FROM ' + @tabela +
               ' WHERE id = ' + CAST(@id AS VARCHAR(MAX));
    -- Execute the SQL query
    EXEC(@sql)
END

GO
```

Creation of the "spListagem" procedure to list records ordered by a specific field

```sql
CREATE PROCEDURE spListagem
(
    -- Declaration of the parameters to be used
    @tabela VARCHAR(MAX),                  -- Name of the table to be queried
    @ordem VARCHAR(MAX)                    -- Name of the field by which the records will be ordered
)
AS
BEGIN
    -- Execute the SQL query to list the records ordered by the specified field
    EXEC('SELECT * FROM ' + @tabela +
         ' ORDER BY ' + @ordem)
END

GO
```

Creation of the "spProximoId" procedure to obtain the next available ID in the table.

```sql
CREATE PROCEDURE spProximoId
(
    -- Declaration of the parameters to be used
    @tabela VARCHAR(MAX)                   -- Name of the table to get the next ID
)
AS
BEGIN
    -- Execute the SQL query to get the highest ID and increment by 1
    EXEC('SELECT ISNULL(MAX(id) + 1, 1) AS MAIOR FROM ' + @tabela)
END
```

Creation of the "spInsert_cadr_empr_parc" procedure to insert a new partner company.

```sql
CREATE PROCEDURE spInsert_cadr_empr_parc
(
    -- Declaration of the parameters to be used
    @ID INT,                               -- Company ID
    @NM_EMPR VARCHAR(30),                  -- Company name
    @CEP_EMPR VARCHAR(30),                 -- Company postal code (CEP)
    @LOG_EMPR VARCHAR(30),                 - Company street address
    @NUM_EMPR VARCHAR(4),                  -- Company building number
    @COMPL_EMPR VARCHAR(30),               -- Company address complement
    @BAIRRO_EMPR VARCHAR(20),              -- Company neighborhood
    @CIDADE_EMPR VARCHAR(20),              -- Company city
    @ESTADO_EMPR VARCHAR(2),               -- Company state
    @CNPJ_EMPR VARCHAR(15),                --- Company CNPJ
    @TELF_CONT_EMPR VARCHAR(10),           -- Company contact phone
    @ID_FUNC INT                           -- Employee ID responsible for the company (foreign key)
) 
AS
BEGIN
    -- Insert a new record into the 'cadr_empr_parc' table with the provided data
    INSERT INTO cadr_empr_parc
    (ID, NM_EMPR, CEP_EMPR, LOG_EMPR, NUM_EMPR, COMPL_EMPR, BAIRRO_EMPR, CIDADE_EMPR, ESTADO_EMPR, CNPJ_EMPR, TELF_CONT_EMPR, ID_FUNC)
    VALUES
    (@ID, @NM_EMPR, @CEP_EMPR, @LOG_EMPR, @NUM_EMPR, @COMPL_EMPR, @BAIRRO_EMPR, @CIDADE_EMPR, @ESTADO_EMPR, @CNPJ_EMPR, @TELF_CONT_EMPR, @ID_FUNC)
END

GO
```

Creation of the "spUpdate_cadr_empr_parc" procedure to update the data of an existing company

```sql
CREATE PROCEDURE spUpdate_cadr_empr_parc
(
    -- Declaration of the parameters to be used
    @ID INT,                               -- Company ID
    @NM_EMPR VARCHAR(30),                  -- Company name
    @CEP_EMPR VARCHAR(30),                 -- Company postal code (CEP)
    @LOG_EMPR VARCHAR(30),                 -- Company street address
    @NUM_EMPR VARCHAR(4),                  -- Company building number
    @COMPL_EMPR VARCHAR(30),               -- Company address complement
    @BAIRRO_EMPR VARCHAR(20),              -- Company neighborhood
    @CIDADE_EMPR VARCHAR(20),              -- Company city
    @ESTADO_EMPR VARCHAR(2),               -- Company state
    @CNPJ_EMPR VARCHAR(15),                -- Company CNPJ
    @TELF_CONT_EMPR VARCHAR(11),           -- Company contact phone
    @ID_FUNC INT                           -- Employee ID responsible for the company (foreign key)
)  
AS
BEGIN
    -- Update the company record in the 'cadr_empr_parc' table with the new data
    UPDATE cadr_empr_parc SET
        NM_EMPR = @NM_EMPR,                -- Company name
        CEP_EMPR = @CEP_EMPR,              -- Company postal code
        LOG_EMPR = @LOG_EMPR,              -- Company street address
        NUM_EMPR = @NUM_EMPR,              -- Company building number
        COMPL_EMPR = @COMPL_EMPR,          -- Company address complement
        BAIRRO_EMPR = @BAIRRO_EMPR,        -- Company neighborhood
        CIDADE_EMPR = @CIDADE_EMPR,        -- Company city
        ESTADO_EMPR = @ESTADO_EMPR,        -- Company state
        CNPJ_EMPR = @CNPJ_EMPR,            -- Company CNPJ
        TELF_CONT_EMPR = @TELF_CONT_EMPR,  -- Company contact phone
        ID_FUNC = @ID_FUNC                 -- Employee ID responsible for the company
    WHERE ID = @ID                         -- Condition to identify the company to be updated
END
GO
```

Creation of the "spInsert_cadr_func" procedure to insert a new employee.

```sql
CREATE PROCEDURE spInsert_cadr_func
(
    -- Declaration of the parameters to be used in the insertion.
    @ID int,
    @LOGIN_FUNC varchar(30),
    @SENHA_FUNC varchar(30),
    @DT_CADR DATE,
    @IMAGEM VARBINARY(MAX)
) 
AS
BEGIN
    -- Inserts a new record into the cadr_func table.
    INSERT INTO cadr_func (ID, LOGIN_FUNC, SENHA_FUNC, DT_CADR, IMAGEM)
    VALUES (@ID, @LOGIN_FUNC, @SENHA_FUNC, @DT_CADR, @IMAGEM)
END
GO
```

Creation of the "spUpdate_cadr_func" procedure to update the details of an existing employee.

```sql
CREATE PROCEDURE spUpdate_cadr_func
(
    -- Declaration of the parameters to be used for the update
    @ID int,
    @LOGIN_FUNC varchar(30),
    @SENHA_FUNC varchar(30),
    @DT_CADR DATE,
    @IMAGEM VARBINARY(MAX)
) 
AS
BEGIN
    -- Updates the existing record in the cadr_func table
    UPDATE cadr_func
    SET LOGIN_FUNC = @LOGIN_FUNC, SENHA_FUNC = @SENHA_FUNC, DT_CADR = @DT_CADR, IMAGEM = @IMAGEM
    WHERE ID = @ID
END
GO
```

Creation of the "spConsultaAvancadaFuncionarios" procedure to query employees

```sql
CREATE PROCEDURE spConsultaAvancadaFuncionarios
(
    -- Declaration of parameters for the advanced query
    @descricao varchar(max),
    @dataInicial datetime,
    @dataFinal datetime
)
AS
BEGIN
    -- Select records from the cadr_func table based on the provided criteria
    SELECT * FROM cadr_func
    WHERE cadr_func.DT_CADR BETWEEN @dataInicial AND @dataFinal
    AND cadr_func.LOGIN_FUNC LIKE '%' + @descricao + '%'
END
GO
```

Creation of the "spInsert_cadr_sens" procedure to insert a new sensor

```sql
CREATE PROCEDURE spInsert_cadr_sens
(
    -- Declaration of the parameters to be used
    @ID INT,                               -- Sensor ID
    @DS_TIPO_SENS VARCHAR(30),             -- Description of the sensor type
    @DT_VEND DATE,                         -- Sale date of the sensor
    @VL_TEMP_ALVO DECIMAL(5, 2),           -- Target temperature value
    @CD_MOTOR INT,                         -- Motor code associated with the sensor
    @ID_FUNC INT,                          -- Employee ID responsible (foreign key)
    @ID_EMPR INT                           -- Company ID responsible (foreign key)
) 
AS
BEGIN
    -- Insert a new record into the 'cadr_sens' table with the provided data
    INSERT INTO cadr_sens
    (ID, DS_TIPO_SENS, DT_VEND, VL_TEMP_ALVO, CD_MOTOR, ID_FUNC, ID_EMPR)
    VALUES
    (@ID, @DS_TIPO_SENS, @DT_VEND, @VL_TEMP_ALVO, @CD_MOTOR, @ID_FUNC, @ID_EMPR)
END
GO
```

Creation of the "spUpdate_cadr_sens" procedure to update the data of an existing sensor

```sql
CREATE PROCEDURE spUpdate_cadr_sens
(
    -- Declaration of parameters to be used
    @ID INT,                               -- Sensor ID
    @DS_TIPO_SENS VARCHAR(30),             -- Description of the sensor type
    @DT_VEND DATE,                         -- Sensor sale date
    @VL_TEMP_ALVO DECIMAL(5, 2),           -- Target temperature value
    @CD_MOTOR INT,                         -- Motor code associated with the sensor
    @ID_FUNC INT,                          -- ID of the responsible employee (foreign key)
    @ID_EMPR INT                           -- ID of the responsible company (foreign key)
) 
AS
BEGIN
    -- Update the sensor record in the 'cadr_sens' table with the new data
    UPDATE cadr_sens SET
        DS_TIPO_SENS = @DS_TIPO_SENS,
        DT_VEND = @DT_VEND,
        VL_TEMP_ALVO = @VL_TEMP_ALVO,
        CD_MOTOR = @CD_MOTOR,
        ID_FUNC = @ID_FUNC,
        ID_EMPR = @ID_EMPR
    WHERE ID = @ID                       -- Condition to identify the sensor to be updated
END
GO
```

## 📑 Manual

### How to Run the System

#### 1. Upload the Code to the ESP32
   - **Connect the ESP32 to Your Computer:**
     - Use a USB cable to connect the ESP32 to your computer.
     - Make sure you have the **Arduino IDE** installed. If you don't have it yet, you can download it [here](https://www.arduino.cc/en/software).
     - Open the Arduino IDE, select the appropriate board (`ESP32 Dev Module`) and port under **Tools > Board** and **Tools > Port**.
   
   - **Upload the Code to the ESP32:**
     - Open the provided code in the Arduino IDE.
     - Click on the **Upload** button in the IDE (the right arrow icon). This will compile and upload the code to your ESP32.
     - Once the upload is complete, the ESP32 will start executing the code, reading temperature data from the sensor and sending it to the FIWARE platform via MQTT.

#### 2. Access the Web Platform
   - **View Real-Time Data:**
     - Open a web browser (Chrome, Firefox, etc.) on your computer or smartphone.
     - Enter the IP address or URL of the web platform configured to receive and display data.
     - You should be able to see real-time temperature data, graphs, and status indicators for the motor drying system.
     - The web platform will provide visual feedback with temperature trends, current readings, and any alerts or notifications based on the system’s thresholds.

### Example of Use

#### Real-Time Monitoring
   - **View Temperature Data:**
     - Once the system is up and running, you will be able to see the motor temperature on the web interface.
     - The temperature readings will be updated in real-time as the ESP32 sends data to the FIWARE platform.
     - The system will also display historical temperature data in graphical form, allowing you to track trends over time.
   
   - **Alerts and Notifications:**
     - If the motor temperature exceeds or falls below the predefined thresholds, the system will trigger an alert on the web platform, notifying users of potential issues.
     - The alert system is designed to provide real-time feedback on the motor's condition, ensuring timely intervention if necessary.

### How to Test

#### 1. Test Data Sending
   - **Verify Data Transmission from ESP32:**
     - After configuring the ESP32 and uploading the code, monitor the output in the **Arduino IDE Serial Monitor**.
     - Ensure that the ESP32 is successfully connecting to the Wi-Fi network and the MQTT broker.
     - You should see the temperature readings being transmitted periodically to the FIWARE platform. If there are no messages or connection issues, check the Wi-Fi configuration and MQTT settings in the code.
   
   - **Check Data on the FIWARE Platform:**
     - Log in to the FIWARE platform and ensure the temperature data from the ESP32 is being received and displayed correctly in the platform’s dashboard.

#### 2. Test the Web Interface
   - **Access the Web Platform:**
     - Open a web browser and navigate to the configured web platform URL.
     - Verify that the temperature data is being displayed in real-time on the web interface.
     - Check the following features:
       - The **temperature graph** should be continuously updated with the latest data.
       - The **temperature readings** should match what is being sent by the ESP32.
       - Ensure that the web platform is receiving and rendering the data accurately.

   - **Test the Alerts:**
     - Manually simulate a change in the temperature (if possible) to trigger an alert.
     - Check if the web platform correctly shows a notification when the temperature exceeds the defined threshold.
   
### Test Coverage

#### Connectivity Tests
   - **Wi-Fi Connectivity:**
     - Ensure that the ESP32 is able to connect to the configured Wi-Fi network. If there are issues, check the SSID and password in the code and verify the network settings.
   
   - **MQTT Connectivity:**
     - Verify that the ESP32 is successfully connecting to the MQTT broker and transmitting data.
     - Use tools like **MQTT Explorer** or **MQTT.fx** to monitor MQTT messages and confirm that the data is being published correctly.

#### Data Visualization Tests
   - **Real-Time Data Update:**
     - Check that the temperature data is updating in real-time on the web interface.
     - Ensure that the system can handle changes in temperature readings and update the visualizations accordingly.
   
   - **Graphical Representation:**
     - Verify that the web interface is rendering temperature graphs correctly, including historical data.
     - Test the responsiveness of the platform to ensure it scales well on different devices (PCs, tablets, and smartphones).

#### Alert and Notification Tests
   - **Threshold-based Alerts:**
     - Simulate scenarios where the motor temperature exceeds the upper or lower thresholds.
     - Ensure that the system triggers an alert and sends notifications to the web platform.
   
   - **Test Alert Handling:**
     - Check that the web platform displays the alert and provides clear information on the issue (e.g., “Motor temperature is too high!”).

## 🤝 Project Members

- Enzo Brito Alves de Oliveira - RA: 082220040
- Erikson Vieira Queiroz - RA: 082220021
- Guilherme Alves Barbosa - RA: 082220014
- Heitor Santos Ferreira - RA: 081230042
- Tainara do Nascimento Casimiro - RA: 082220011
- William Santim - RA: 082220033
