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
   - [Controllers](#controllers)
   - [DAO (Data Access Object)](#dao-(data-access-object))
   - [Models](#models)
   - [Views](#views)
   - [Main pages](#main-pages)
13. [🌐 MVC Application ](#mvc-application)
   - [Table Creation](#table-creation)
   - [Procedure Creation](#procedure-creation)
13. [📑 Manual](#manual)
   - [How to Run the System](#how-to-run-the-system)
   - [Example of Use](#example-of-use)
   - [How to Test](#how-to-test)
   - [Test Coverage](#test-coverage)
14. [🤝 Project Members](#project-members)


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

![diagrama_camadas](https://github.com/user-attachments/assets/7d92677a-88ec-4c5a-804d-a9f6d91a8cc4)

## 🔧 ESP32 Code

### Dependencies
- **WiFi.h**: Library for Wi-Fi connection
- **PubSubClient.h**: MQTT library for Arduino

```cpp
#include <WiFi.h>
#include <PubSubClient.h>

// Configurations - editable variables
const char* default_SSID = "your_wifi_network"; // Wi-Fi network name
const char* default_PASSWORD = "your_wifi_password"; // Wi-Fi network password
const char* default_BROKER_MQTT = "ip_host_fiware"; // MQTT Broker IP
const int default_BROKER_PORT = 1883; // MQTT Broker port
const char* default_ID_MQTT = "your_fiware_mqtt_id"; // MQTT ID

// MQTT topics for temperature
const char* default_TOPICO_TEMPERATURA_PUBLISH_1 = "/TEF/temp04x/attrs"; // Temperature state publication
const char* default_TOPICO_TEMPERATURA_PUBLISH_2 = "/TEF/temp04x/attrs/t"; // Temperature value publication
char* TOPICO_TEMPERATURA_PUBLISH_1 = const_cast<char*>(default_TOPICO_TEMPERATURA_PUBLISH_1);
char* TOPICO_TEMPERATURA_PUBLISH_2 = const_cast<char*>(default_TOPICO_TEMPERATURA_PUBLISH_2);
```

### Wi-Fi and MQTT Broker Configuration
Establishes the connection to the Wi-Fi network and the MQTT Broker. If the connection is lost, the code attempts to reconnect automatically.

```cpp
// Editable settings for Wi-Fi and MQTT connection
char* SSID = const_cast<char*>(default_SSID);
char* PASSWORD = const_cast<char*>(default_PASSWORD);
char* BROKER_MQTT = const_cast<char*>(default_BROKER_MQTT);
int BROKER_PORT = default_BROKER_PORT;
char* ID_MQTT = const_cast<char*>(default_ID_MQTT);
int D4 = default_D4; // LED pin

WiFiClient espClient; // Wi-Fi client
PubSubClient MQTT(espClient); // MQTT client
char EstadoSaida = '0'; // Initial state of the LED

void initWiFi() {
    delay(10); // Short delay to allow the Wi-Fi module to initialize
    Serial.println("------Conexao WI-FI------"); // Print Wi-Fi connection status
    Serial.print("Conectando-se na rede: "); // Print message indicating network connection
    Serial.println(SSID); // Print the SSID of the network
    Serial.println("Aguarde"); // Print message asking to wait
    reconectWiFi(); // Call function to reconnect to Wi-Fi
}

void initMQTT() {
    MQTT.setServer(BROKER_MQTT, BROKER_PORT); // Set the MQTT broker server and port
    MQTT.setCallback(mqtt_callback); // Set the callback function for incoming MQTT messages
}
```

### System Setup Function
In the setup(), the necessary components are initialized, including the configuration of serial communication, Wi-Fi, and MQTT. Additionally, the onboard LED is initially set to the "on" state command.

```cpp
void setup() {
    InitOutput(); // Initialize the output pin for the LED
    initSerial(); // Initialize serial communication
    initWiFi(); // Connect to the Wi-Fi network
    initMQTT(); // Connect to the MQTT broker
    delay(5000); // Delay for 5000 milliseconds (5 seconds) to ensure connections are stable
}
```

### Main Loop
The loop() function checks the Wi-Fi and MQTT connection, sends the LED state, and handles the transmission of data about the temperature.

```cpp
void loop() {
    VerificaConexoesWiFIEMQTT(); // Check Wi-Fi and MQTT connections
    handleTemperature(); // Monitor and handle temperature readings
    MQTT.loop(); // Maintain the MQTT connection
    delay(1500); // Delay for 1500 milliseconds (1.5 seconds)
}
```

### Wi-Fi Reconnection
The reconnectWiFi() function attempts to reconnect the ESP32 to the Wi-Fi network if the connection is lost. A new attempt is made every 100 ms until the connection is successful.

```cpp
void reconectWiFi() {
    if (WiFi.status() == WL_CONNECTED)
        return; // If already connected to Wi-Fi, exit the function
    WiFi.begin(SSID, PASSWORD); // Start Wi-Fi connection with the given SSID and password
    while (WiFi.status() != WL_CONNECTED) {
        delay(100); // Delay for 100 milliseconds
        Serial.print("."); // Print a dot to indicate connection progress
    }
    Serial.println(); // Print a new line
    Serial.println("Conectado com sucesso na rede "); // Print successful connection message
    Serial.print(SSID); // Print the SSID of the connected network
    Serial.println("IP obtido: "); // Print message for obtained IP
    Serial.println(WiFi.localIP()); // Print the local IP address obtained

    // Ensure that the LED starts off
    digitalWrite(D4, LOW); // Set the LED pin to LOW (off)
}
```

### MQTT Callback Function
The mqtt_callback() function is responsible for handling messages received from the MQTT Broker. If the message is to turn on the LED, pin D4 is set to HIGH (LED on). Otherwise, the LED is turned off.

```cpp
void mqtt_callback(char* topic, byte* payload, unsigned int length) {
    String msg; // Initialize a string to store the message
    for (int i = 0; i < length; i++) {
        char c = (char)payload[i]; // Convert each byte of the payload to a char
        msg += c; // Append the char to the message string
    }
    Serial.print("- Mensagem recebida: "); // Print "Message received: "
    Serial.println(msg); // Print the received message

    // Forms the topic pattern for comparison
    String onTopic = String(topicPrefix) + "@on|"; // Define the topic pattern for "on" messages
    String offTopic = String(topicPrefix) + "@off|"; // Define the topic pattern for "off" messages

    // Compares with the received topic
    if (msg.equals(onTopic)) { // If the message matches the "on" pattern
        digitalWrite(D4, HIGH); // Turn the LED on
        EstadoSaida = '1'; // Set the LED state to on
    }

    if (msg.equals(offTopic)) { // If the message matches the "off" pattern
        digitalWrite(D4, LOW); // Turn the LED off
        EstadoSaida = '0'; // Set the LED state to off
    }
}
```

### Control and Monitoring Functions
These functions are responsible for ensuring that the LED and the temperature sensor operate correctly.

#### Connection Verification
The VerificaConexoesWiFIEMQTT() function ensures that Wi-Fi and MQTT are connected, and reconnects if necessary.

```cpp
void VerificaConexoesWiFIEMQTT() {
    if (!MQTT.connected()) // Check if the MQTT client is connected
        reconnectMQTT(); // If not connected, attempt to reconnect to the MQTT broker
    reconectWiFi(); // Ensure the Wi-Fi connection is still active, and reconnect if necessary
}
```

### Helper Functions
InitOutput(): Initializes the LED pin and performs a blink to indicate that the system has started.
reconnectMQTT(): Attempts to reconnect to the MQTT Broker if the connection is lost.
handleLuminosity(): Reads the temperature value from an analog sensor (connected to pin 34) and sends this value to the MQTT Broker.

```cpp
void InitOutput() {
    pinMode(D4, OUTPUT); // Set the D4 pin as an output
    digitalWrite(D4, HIGH); // Turn the LED on
    boolean toggle = false; // Initialize toggle variable to false

    for (int i = 0; i <= 10; i++) {
        toggle = !toggle; // Toggle the LED state
        digitalWrite(D4, toggle); // Write the toggle state to the LED
        delay(200); // Delay for 200 milliseconds
    }
}

void reconnectMQTT() {
    while (!MQTT.connected()) { // Loop until the MQTT client is connected
        Serial.print("* Tentando se conectar ao Broker MQTT: "); // Print message indicating connection attempt
        Serial.println(BROKER_MQTT); // Print the MQTT broker IP
        if (MQTT.connect(ID_MQTT)) { // Try to connect to the MQTT broker with the specified ID
            Serial.println("Conectado com sucesso ao broker MQTT!"); // Print success message
            MQTT.subscribe(TOPICO_LUMINOSIDADE_SUBSCRIBE); // Subscribe to the control topic
        } else { // If connection failed
            Serial.println("Falha ao reconectar no broker."); // Print failure message
            Serial.println("Haverá nova tentativa de conexão em 2s"); // Print retry message
            delay(2000); // Wait for 2000 milliseconds (2 seconds) before retrying
        }
    }
}

void handleTmperature() {
    const float potPin = 34; // Analog pin for luminosity (Might need to change this to 'int')
    float sensorValue = analogRead(potPin); // Read the sensor value (Might need to change this to 'int')
    float temperature = map(sensorValue, 0, 4095, 0, 100); // Map the sensor value to a range of 0 to 100 (Might need to change this to 'int')
    char msg[10];
    sprintf(msg, "%d", temperature); // Convert the temperature to a string
    MQTT.publish(TOPICO_TEMPERATURA_PUBLISH_2, msg); // Publish the temperature
    Serial.println("Temperature: " + String(msg)); // Display the temperature on the serial monitor
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
| `IMAGEM`      | `VARBINARY`   | Employee registration image.                             |

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

| Column           | Type          | Description                                                        |
|------------------|---------------|--------------------------------------------------------------------|
| `ID`             | `INT`         | Partner company code, primary key with auto-increment.             |
| `NM_EMPR`        | `VARCHAR(30)` | Partner company name (maximum 30 characters).                      |
| `CEP_EMPR`       | `VARCHAR(8)`  | Partner company ZIP code (8 characters).                           |
| `LOG_EMPR`       | `VARCHAR(30)` | Partner company address (maximum 30 characters).                   |
| `NUM_EMPR`       | `VARCHAR(4)`  | Partner company address number (maximum 4 characters).             |
| `COMPL_EMPR`     | `VARCHAR(30)` | Partner company address complement (maximum 30 characters).        |
| `BAIRRO_EMPR`    | `VARCHAR(20)` | Partner company neighborhood (maximum 20 characters).              |
| `CIDADE_EMPR`    | `VARCHAR(20)` | Partner company city (maximum 20 characters).                      |
| `ESTADO_EMPR`    | `VARCHAR(2)`  | Partner company state (maximum 2 characters).                      |
| `CNPJ_EMPR`      | `VARCHAR(15)` | Partner company CNPJ (15 characters).                              |
| `TELF_CONT_EMPR` | `VARCHAR(11)` | Partner company contact phone (11 characters).                     |
| `ID_FUNC`        | `INT`         | Responsible employee code, foreign key referencing `cadr_func(ID)`.|

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

## 🌐 MVC Application

To display the collected data, we are using the MVC (Model-View-Controller) architecture implemented in C#. This approach provides a clear separation between business logic, user interface, and application flow control, making the system more organized, scalable, and easier to maintain. In our project, the Model will be responsible for managing the data received via MQTT and storing it appropriately. The Controller will mediate requests, process the data, and pass it to the presentation layer, while the View will display the information in a dynamic and interactive graph, making it easy to monitor the thermal behavior of the greenhouse in real-time.

<p align="center">
  <img src="https://github.com/user-attachments/assets/226604d0-ec1e-4c52-888b-9a0d58689066" alt="MVC">
</p>

### Controllers
Controllers are responsible for managing requests and coordinating actions between the View and Model. They receive user requests, interact with the DAO to retrieve or manipulate data, and decide which View to return as a response.
Main controllers in the project:

**ApiController:** Handles API requests, allowing other systems to interact with the application.
```c#
namespace LumiTempMVC.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {

        private readonly FiwareDataDAO _fiwareDataDAO;

        public ApiController()
        {

            _fiwareDataDAO = new FiwareDataDAO();

        }

        [HttpGet("temperature")]
        public async Task<IActionResult> GetTemperatureData(int lastN)
        {
            var data = await _fiwareDataDAO.GetTemperatureDataAsync(lastN);
            if (data.Count == 0)
            {
                return NotFound("Sem dados de temperatura");
            }
            return Ok(data);
        }

    }
}
```

**DashboardController:** Manages the display of a control panel, showing general system information.
```c#
namespace LumiTempMVC.Controllers
{
    public class DashboardController : Controller
    {
        private readonly SensorDAO _sensorDao;
        private readonly FuncionarioDAO _funcionarioDao;
        private readonly EmpresaParceiraDAO _empresaParceiraDao;

        public DashboardController()
        {
            _sensorDao = new SensorDAO();
            _funcionarioDao = new FuncionarioDAO();
            _empresaParceiraDao = new EmpresaParceiraDAO();
        }

        public IActionResult Index()
        {
            var sensores = _sensorDao.Listagem();
            var funcionarios = _funcionarioDao.Listagem();
            var empresas = _empresaParceiraDao.Listagem();

            var model = new DashboardViewModel
            {
                Sensores = sensores,
                Funcionarios = funcionarios,
                Empresas = empresas
            };

            return View(model);
        }
    }
}
```

**EmpresaParceiraController:** Handles operations related to partner companies.
```c#
namespace LumiTempMVC.Controllers
{
    public class EmpresaParceiraController : PadraoController<EmpresaParceiraViewModel>
    {
        public EmpresaParceiraController()
        {
            DAO = new EmpresaParceiraDAO();
            GeraProximoId = true;
            NomeViewForm = "Form";
            NomeViewIndex = "Index";
            NecessitaCaixaComboEmpresas = false;
            NecessitaCaixaComboFuncionarios = true;
            PossuiCampoData = false;
            ExigeAutenticacao = true;
        }

        public IActionResult ExtrairDados()
        {
            try
            {
                EmpresaParceiraDAO dao = new EmpresaParceiraDAO();
                List<EmpresaParceiraViewModel> lista = dao.Listagem();

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Id, Nome Empresa, CEP Empresa, Logradouro Empresa, Número Empresa, Complemento Empresa, Bairro Empresa, Cidade Empresa, Estado Empresa, CNPJ Empresa, Telefone Empresa, ID Funcionario");

                foreach (var empresa in lista)
                {
                    sb.AppendLine($"{empresa.id}, {empresa.nm_empr}, {empresa.cep_empr}, {empresa.log_empr}, {empresa.num_empr}, {empresa.compl_empr}, {empresa.bairro_empr}, {empresa.cidade_empr}, {empresa.estado_empr}, {empresa.cnpj_empr}, {empresa.telf_cont_empr}, {empresa.id_func}");
                }

                string fileName = "empresas.txt";
                return File(Encoding.UTF8.GetBytes(sb.ToString()), "text/plain", fileName);
            }
            catch (Exception erro)
            {
                return RedirectToAction("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        protected override void ValidaDados(EmpresaParceiraViewModel empresa, string operacao)
        {
            if (string.IsNullOrEmpty(empresa.nm_empr))
                ModelState.AddModelError("nm_empr", "Preencha o nome.");
            
            if (string.IsNullOrEmpty(empresa.log_empr))
                ModelState.AddModelError("log_empr", "Preencha o logradouro.");

            if (string.IsNullOrEmpty(empresa.num_empr))
                ModelState.AddModelError("num_empr", "Preencha o número.");
            
            if (string.IsNullOrEmpty(empresa.bairro_empr))
                ModelState.AddModelError("bairro_empr", "Preencha o bairro.");

            if (string.IsNullOrEmpty(empresa.cidade_empr))
                ModelState.AddModelError("cidade_empr", "Preencha a cidade.");

            if (string.IsNullOrEmpty(empresa.estado_empr))
                ModelState.AddModelError("estado_empr", "Preencha o estado.");

            if (string.IsNullOrEmpty(empresa.cnpj_empr))
            {
                ModelState.AddModelError("cnpj_empr", "Preencha o CNPJ.");
            }
            else if (!IsValidCnpj(empresa.cnpj_empr))
            {
                ModelState.AddModelError("cnpj_empr", "CNPJ inválido.");
            }

            if (string.IsNullOrEmpty(empresa.cep_empr))
            {
                ModelState.AddModelError("cep_empr", "Preencha o CEP.");
            }
            else if (empresa.cep_empr.Length != 8 || !long.TryParse(empresa.cep_empr, out _))
            {
                ModelState.AddModelError("cep_empr", "CEP inválido.");
            }

            if (string.IsNullOrEmpty(empresa.telf_cont_empr))
            {
                ModelState.AddModelError("telf_cont_empr", "Preencha o telefone.");
            }
            else if (empresa.telf_cont_empr.Length < 10 || empresa.telf_cont_empr.Length > 11 || !long.TryParse(empresa.telf_cont_empr, out _))
            {
                ModelState.AddModelError("telf_cont_empr", "Telefone inválido.");
            }
        }

        private bool IsValidCnpj(string cnpj)
        {
            if (cnpj.Length != 14 || !long.TryParse(cnpj, out _))
                return false;

            int[] multiplicador1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCnpj, digito;
            int soma, resto;

            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);
            resto = resto < 2 ? 0 : 11 - resto;
            digito = resto.ToString();
            tempCnpj += digito;
            soma = 0;

            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            resto = resto < 2 ? 0 : 11 - resto;
            digito += resto.ToString();

            return cnpj.EndsWith(digito);
        }

        protected override void PreencheDadosParaView(string Operacao, EmpresaParceiraViewModel model)
        {
            base.PreencheDadosParaView(Operacao, model);
        }
    }
}

```

**FuncionarioController:** Manages CRUD (create, read, update, and delete) actions for employees.
```c#
public class FuncionarioController : PadraoController<FuncionarioViewModel>
{
    public FuncionarioController()
    {
        DAO = new FuncionarioDAO();
        GeraProximoId = true;
        NomeViewForm = "Form";
        NomeViewIndex = "Index";
        NecessitaCaixaComboEmpresas = false;
        NecessitaCaixaComboFuncionarios = false;
        PossuiCampoData = true;
        ExigeAutenticacao = false;
    }

    public byte[] ConvertImageToByte(IFormFile file)
    {
        if (file != null)
            using (var ms = new MemoryStream())
            {
                file.CopyTo(ms);
                return ms.ToArray();
            }
        else
            return null;
    }

    public IActionResult ExtrairDados()
    {
        try
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            List<FuncionarioViewModel> lista = dao.Listagem();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Id, Login Funcionário, Data de cadastro funcionário");

            foreach (var funcionario in lista)
            {
                sb.AppendLine($"{funcionario.id}, {funcionario.login_func}, {funcionario.dt_cadr}");
            }

            string fileName = "funcionarios.txt";
            return File(Encoding.UTF8.GetBytes(sb.ToString()), "text/plain", fileName);
        }
        catch (Exception erro)
        {
            return RedirectToAction("Error", new ErrorViewModel(erro.ToString()));
        }
    }

    protected override void ValidaDados(FuncionarioViewModel funcionario, string operacao)
    {
        if (string.IsNullOrEmpty(funcionario.login_func))
            ModelState.AddModelError("login_func", "Preencha o login");

        if (string.IsNullOrEmpty(funcionario.senha_func))
            ModelState.AddModelError("senha_func", "Preencha a senha.");

        if (funcionario.dt_cadr == DateTime.MinValue)
            ModelState.AddModelError("dt_cadr", "Preencha uma data");

        if (funcionario.Imagem == null && operacao == "I")
            ModelState.AddModelError("Imagem", "Escolha uma imagem.");
        if (funcionario.Imagem != null && funcionario.Imagem.Length / 1024 / 1024 >= 2)
            ModelState.AddModelError("Imagem", "Imagem limitada a 2 mb.");
        
        if (ModelState.IsValid)
        {
            if (

```

**SensorController:** Controls interactions with sensors, such as displaying data and performing analyses.
```c#
namespace LumiTempMVC.Controllers
{
    public class SensorController : PadraoController<SensorViewModel>
    {
        public SensorController()
        {
            DAO = new SensorDAO();
            GeraProximoId = true;
            NomeViewForm = "Form";
            NomeViewIndex = "Index";
            NecessitaCaixaComboEmpresas = true;
            NecessitaCaixaComboFuncionarios = true;
            PossuiCampoData = true;
            ExigeAutenticacao = true;
        }

        public IActionResult ExtrairDados()
        {
            try
            {
                SensorDAO dao = new SensorDAO();
                List<SensorViewModel> lista = dao.Listagem();

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Id, Descrição do tipo de sensor, Data da venda do sensor, valor da temperatura alvo configurada, código do motor atrelado ao sensor, id do funcionário atrelado ao sensor, id da empresa atrelada ao sensor");

                foreach (var sensor in lista)
                {
                    sb.AppendLine($"{sensor.id}, {sensor.ds_tipo_sens}, {sensor.dt_vend}, {sensor.vl_temp_alvo}, {sensor.cd_motor}, {sensor.id_func}, {sensor.id_empr}");
                }

                string fileName = "sensores.txt";
                return File(Encoding.UTF8.GetBytes(sb.ToString()), "text/plain", fileName);
            }
            catch (Exception erro)
            {
                return RedirectToAction("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        protected override void ValidaDados(SensorViewModel sensor, string operacao)
        {
            if (string.IsNullOrEmpty(sensor.ds_tipo_sens))
                ModelState.AddModelError("ds_tipo_sens", "Preencha a descrição do sensor");

            if (sensor.dt_vend == DateTime.MinValue)
                ModelState.AddModelError("dt_vend", "Preencha uma data correta");

            if (sensor.vl_temp_alvo <= 0.00)
                ModelState.AddModelError("vl_temp_alvo", "Preencha o valor alvo");

            if (sensor.cd_motor <= 0)
                ModelState.AddModelError("cd_motor", "Preencha o código de um motor");
        }

        protected override void PreencheDadosParaView(string Operacao, SensorViewModel model)
        {
            base.PreencheDadosParaView(Operacao, model);
            model.dt_vend = DateTime.Now;
            PreparaListaFuncionariosParaCombo();
            PreparaListaEmpresasParceirasParaCombo();

            List<SelectListItem> listaTipos = new List<SelectListItem>
            {
                new SelectListItem("Selecione um tipo...", "0"),
                new SelectListItem("LUMINOSIDADE", "LUMINOSIDADE"),
                new SelectListItem("UMIDADE", "UMIDADE"),
                new SelectListItem("TEMPERATURA", "TEMPERATURA")
            };
            ViewBag.Tipos = listaTipos;
        }

        public IActionResult ExibeConsultaAvancada()
        {
            try
            {
                PreparaComboEmpresas();
                ViewBag.empresas.Insert(0, new SelectListItem("TODAS", "0"));
                return View("ConsultaAvancada");
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.Message));
            }
        }

        public IActionResult ObtemDadosConsultaAvancada2(string descricao, int empresa, DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                SensorDAO dao = new SensorDAO();
                if (string.IsNullOrEmpty(descricao))
                    descricao = "";
                if (dataInicial.Date == Convert.ToDateTime("01/01/0001"))
                    dataInicial = SqlDateTime.MinValue.Value;
                if (dataFinal.Date == Convert.ToDateTime("01/01/0001"))
                    dataFinal = SqlDateTime.MaxValue.Value;
                var lista = dao.ConsultaAvancadaSensores(descricao, empresa, dataInicial, dataFinal);
                return PartialView("pvGridSensores", lista);
            }
            catch (Exception erro)
            {
                return Json(new { erro = true, msg = erro.Message });
            }
        }

        private void PreparaComboEmpresas()
        {
            EmpresaParceiraDAO dao = new EmpresaParceiraDAO();
            var lista = dao.Listagem();
            List<SelectListItem> listaRetorno = new List<SelectListItem>();
            foreach (var categ in lista)
                listaRetorno.Add(new SelectListItem(categ.nm_empr, categ.id.ToString()));

            ViewBag.Empresas = listaRetorno;
        }
    }
}

```

### DAO (Data Access Object)
DAO classes are responsible for direct communication with the database. They contain methods that perform operations such as inserting, updating, deleting, and retrieving data.
Main DAOs in the project:

**ConexaoDB:** This class manages the database connection.
```c#
namespace LumiTempMVC.DAO
{
    public class ConexaoDB
    {
        public static SqlConnection GetConexao()
        {
            string strCon = "Data Source=LOCALHOST; Initial Catalog=b_lumitemp_main_db; integrated security=true";
            SqlConnection conexao = new SqlConnection(strCon);
            conexao.Open();
            return conexao;
        }
    }
}
```

**FuncionarioDAO, EmpresaParceiraDAO, SensorDAO:** Each of these classes contains methods to handle specific data for their respective entities in the database.

**FuncionarioDAO:**
```c#
namespace LumiTempMVC.DAO
{
    public class FuncionarioDAO : PadraoDAO<FuncionarioViewModel>
    {
        protected override SqlParameter[] CriaParametros(FuncionarioViewModel model)
        {
            object imgByte = model.ImagemEmByte ?? DBNull.Value;

            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = new SqlParameter("ID", model.id);
            parametros[1] = new SqlParameter("LOGIN_FUNC", model.login_func);
            parametros[2] = new SqlParameter("SENHA_FUNC", model.senha_func);
            parametros[3] = new SqlParameter("DT_CADR", model.dt_cadr);
            parametros[4] = new SqlParameter("imagem", imgByte);

            return parametros;
        }

        protected override FuncionarioViewModel MontaModel(DataRow registro)
        {
            FuncionarioViewModel funcionario = new FuncionarioViewModel
            {
                id = Convert.ToInt32(registro["ID"]),
                login_func = Convert.ToString(registro["LOGIN_FUNC"]),
                senha_func = Convert.ToString(registro["SENHA_FUNC"]),
                dt_cadr = Convert.ToDateTime(registro["DT_CADR"])
            };

            if (registro["imagem"] != DBNull.Value)
                funcionario.ImagemEmByte = registro["imagem"] as byte[];

            return funcionario;
        }

        protected override void SetTabela()
        {
            Tabela = "cadr_func";
        }

        public List<FuncionarioViewModel> ConsultaAvancadaFuncionarios(string descricao, DateTime dataInicial, DateTime dataFinal)
        {
            SqlParameter[] p = {
                new SqlParameter("descricao", descricao),
                new SqlParameter("dataInicial", dataInicial),
                new SqlParameter("dataFinal", dataFinal),
            };

            var tabela = HelperDAO.ExecutaProcSelect("spConsultaAvancadaFuncionarios", p);
            var lista = new List<FuncionarioViewModel>();
            foreach (DataRow dr in tabela.Rows)
                lista.Add(MontaModel(dr));

            return lista;
        }
    }
}

```
**EmpresaParceiraDAO:**
```c#
namespace LumiTempMVC.DAO
{
    public class EmpresaParceiraDAO : PadraoDAO<EmpresaParceiraViewModel>
    {
        protected override SqlParameter[] CriaParametros(EmpresaParceiraViewModel model)
        {
            SqlParameter[] parametros = new SqlParameter[12];

            parametros[0] = new SqlParameter("ID", model.id);
            parametros[1] = new SqlParameter("NM_EMPR", model.nm_empr);
            parametros[2] = new SqlParameter("CEP_EMPR", model.cep_empr);
            parametros[3] = new SqlParameter("LOG_EMPR", model.log_empr);
            parametros[4] = new SqlParameter("NUM_EMPR", model.num_empr);
            parametros[5] = new SqlParameter("COMPL_EMPR", model.compl_empr ?? DBNull.Value);
            parametros[6] = new SqlParameter("BAIRRO_EMPR", model.bairro_empr);
            parametros[7] = new SqlParameter("CIDADE_EMPR", model.cidade_empr);
            parametros[8] = new SqlParameter("ESTADO_EMPR", model.estado_empr);
            parametros[9] = new SqlParameter("CNPJ_EMPR", model.cnpj_empr);
            parametros[10] = new SqlParameter("TELF_CONT_EMPR", model.telf_cont_empr);
            parametros[11] = new SqlParameter("ID_FUNC", model.id_func);

            return parametros;
        }

        protected override EmpresaParceiraViewModel MontaModel(DataRow registro)
        {
            EmpresaParceiraViewModel empresa = new EmpresaParceiraViewModel
            {
                id = Convert.ToInt32(registro["ID"]),
                nm_empr = Convert.ToString(registro["NM_EMPR"]),
                cep_empr = Convert.ToString(registro["CEP_EMPR"]),
                log_empr = Convert.ToString(registro["LOG_EMPR"]),
                num_empr = Convert.ToString(registro["NUM_EMPR"]),
                compl_empr = Convert.ToString(registro["COMPL_EMPR"]),
                bairro_empr = Convert.ToString(registro["BAIRRO_EMPR"]),
                cidade_empr = Convert.ToString(registro["CIDADE_EMPR"]),
                estado_empr = Convert.ToString(registro["ESTADO_EMPR"]),
                cnpj_empr = Convert.ToString(registro["CNPJ_EMPR"]),
                telf_cont_empr = Convert.ToString(registro["TELF_CONT_EMPR"]),
                id_func = Convert.ToInt32(registro["ID_FUNC"])
            };

            return empresa;
        }

        protected override void SetTabela()
        {
            Tabela = "cadr_empr_parc";
        }
    }
}

```
**SensorDAO:**
```c#
public class SensorDAO : PadraoDAO<SensorViewModel>
{
    protected override SqlParameter[] CriaParametros(SensorViewModel model)
    {
        SqlParameter[] parametros = new SqlParameter[7];
        parametros[0] = new SqlParameter("ID", model.id);
        parametros[1] = new SqlParameter("DS_TIPO_SENS", model.ds_tipo_sens);
        parametros[2] = new SqlParameter("DT_VEND", model.dt_vend);
        parametros[3] = new SqlParameter("VL_TEMP_ALVO", model.vl_temp_alvo);
        parametros[4] = new SqlParameter("CD_MOTOR", model.cd_motor);
        parametros[5] = new SqlParameter("ID_FUNC", model.id_func);
        parametros[6] = new SqlParameter("ID_EMPR", model.id_empr);
        return parametros;
    }

    protected override SensorViewModel MontaModel(DataRow registro)
    {
        SensorViewModel sensor = new SensorViewModel();
        sensor.id = Convert.ToInt32(registro["ID"]);
        sensor.ds_tipo_sens = Convert.ToString(registro["DS_TIPO_SENS"]);
        sensor.dt_vend = Convert.ToDateTime(registro["DT_VEND"]);
        sensor.vl_temp_alvo = Convert.ToDouble(registro["VL_TEMP_ALVO"]);
        sensor.cd_motor = Convert.ToInt32(registro["CD_MOTOR"]);
        sensor.id_func = Convert.ToInt32(registro["ID_FUNC"]);
        sensor.id_empr = Convert.ToInt32(registro["ID_EMPR"]);

        if (registro.Table.Columns.Contains("DescricaoEmpresa"))
            sensor.DescricaoEmpresa = registro["DescricaoEmpresa"].ToString();

        return sensor;
    }

    protected override void SetTabela()
    {
        Tabela = "cadr_sens";
    }

    public List<SensorViewModel> ConsultaAvancadaSensores(string descricao, int empresa, DateTime dataInicial,
                                                          DateTime dataFinal)
    {
        SqlParameter[] p = {
            new SqlParameter("descricao", descricao),
            new SqlParameter("empresa", empresa),
            new SqlParameter("dataInicial", dataInicial),
            new SqlParameter("dataFinal", dataFinal),
        };
        var tabela = HelperDAO.ExecutaProcSelect("spConsultaAvancadaSensores", p);
        var lista = new List<SensorViewModel>();
        foreach (DataRow dr in tabela.Rows)
            lista.Add(MontaModel(dr));
        return lista;
    }
}

```

**HelperDAO:** This is a utility class for database operations that are common to multiple entities.
```c#
namespace LumiTempMVC.DAO
{
    public static class HelperDAO
    {
        public static void ExecutaSQL(string sql, SqlParameter[] parametros)
        {
            using (SqlConnection conexao = ConexaoDB.GetConexao())
            {
                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    if (parametros != null)
                        comando.Parameters.AddRange(parametros);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public static DataTable ExecutaSelect(string sql, SqlParameter[] parametros)
        {
            using (SqlConnection conexao = ConexaoDB.GetConexao())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conexao))
                {
                    if (parametros != null)
                        adapter.SelectCommand.Parameters.AddRange(parametros);

                    DataTable tabelaTemp = new DataTable();
                    adapter.Fill(tabelaTemp);
                    return tabelaTemp;
                }
            }
        }

        public static void ExecutaProc(string nomeProc, SqlParameter[] parametros)
        {
            using (SqlConnection conexao = ConexaoDB.GetConexao())
            {
                using (SqlCommand comando = new SqlCommand(nomeProc, conexao))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    if (parametros != null)
                        comando.Parameters.AddRange(parametros);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public static DataTable ExecutaProcSelect(string nomeProc, SqlParameter[] parametros)
        {
            using (SqlConnection conexao = ConexaoDB.GetConexao())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(nomeProc, conexao))
                {
                    if (parametros != null)
                        adapter.SelectCommand.Parameters.AddRange(parametros);

                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    return tabela;
                }
            }
        }
    }
}

```

### Models
Models represent the structure of the data manipulated in the application and usually correspond to tables in the database.
In this project, classes ending in ViewModel are data transfer classes used to carry data between the Controller and the View.
Main Models:

**DashboardViewModel, FuncionarioViewModel, SensorViewModel:** Each of these classes contains the necessary properties to display data on a specific page, such as the dashboard, employee data, and sensors.

**DashboardViewModel:**
```c#
namespace LumiTempMVC.Models
{
    public class DashboardViewModel
    {
        public List<SensorViewModel> Sensores { get; set; }
        public List<FuncionarioViewModel> Funcionarios { get; set; }
        public List<EmpresaParceiraViewModel> Empresas { get; set; }
    }
}
```
**FuncionarioViewModel:**
```c#
namespace LumiTempMVC.Models
{
    public class FuncionarioViewModel : PadraoViewModel 
    {
        public string login_func { get; set; }
        public string senha_func { get; set; }
        public DateTime dt_cadr { get; set; }
        public IFormFile Imagem { get; set; }
        public byte[] ImagemEmByte { get; set; }

        public string ImagemEmBase64
        {
            get
            {
                if (ImagemEmByte != null)
                    return Convert.ToBase64String(ImagemEmByte);
                else
                    return string.Empty;
            }
        }
    }
}
```
**SensorViewModel:**
```c#
namespace LumiTempMVC.Models
{
    public class SensorViewModel : PadraoViewModel
    {
        public string ds_tipo_sens { get; set; }
        public DateTime dt_vend { get; set; }
        public double vl_temp_alvo { get; set; }
        public int cd_motor { get; set; }
        public int id_func { get; set; }
        public int id_empr { get; set; }
        public string DescricaoEmpresa { get; set; }
    }
}
```

### Views
Views are responsible for the user interface, displaying the data provided by the Controller. In this project, each folder within Views corresponds to a specific entity or functionality, and each folder contains page files (.cshtml).
Example of View:

**Dashboard/Index.cshtml:** Displays the control panel.
```c#
@model LumiTempMVC.Models.DashboardViewModel
@{
    ViewData["Title"] = "Dashboard - Visões Executivas";
}

<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewData["Title"]</title>
    <link rel="stylesheet" href="~/css/site.css" />
    <script src="https://cdn.jsdelivr.net/npm/plotly.js-dist@2.3.0"></script>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <style>
        .chart-container {
            display: flex;
            justify-content: space-between;
            flex-wrap: wrap;
        }

        .chart {
            width: 48%;
            margin-bottom: 20px;
        }
    </style>
</head>
<body>
    <div class="container">
        <h1>@ViewData["Title"]</h1>

        <div class="chart-container">
            <div id="empresas-pie-chart" class="chart"></div>
            <div id="vendas-sensores-line-chart" class="chart"></div>
            <div id="vendas-funcionarios-bar-chart" class="chart"></div>
            <div id="vendas-tipo-sensores-bar-chart" class="chart"></div>
        </div>

        <script type="text/javascript">
            $(document).ready(function () {
                var empresas = @Html.Raw(Json.Serialize(Model.Empresas));

                var empresaStates = empresas.map(empresa => empresa.estado_empr);
                var empresaCounts = empresaStates.reduce((acc, state) => {
                    acc[state] = (acc[state] || 0) + 1;
                    return acc;
                }, {});

                var pieData = [{
                    values: Object.values(empresaCounts),
                    labels: Object.keys(empresaCounts),
                    type: 'pie'
                }];

                var pieLayout = {
                    title: 'Quantidade de Empresas por Estado'
                };

                Plotly.newPlot('empresas-pie-chart', pieData, pieLayout);

                var sensores = @Html.Raw(Json.Serialize(Model.Sensores));
                var vendasPorDia = sensores.reduce((acc, sensor) => {
                    var date = new Date(sensor.dt_vend).toISOString().split('T')[0];
                    acc[date] = (acc[date] || 0) + 1;
                    return acc;
                }, {});

                var lineData = [{
                    x: Object.keys(vendasPorDia),
                    y: Object.values(vendasPorDia),
                    type: 'scatter',
                    mode: 'lines+markers',
                    line: { shape: 'linear' }
                }];

                var lineLayout = {
                    title: 'Quantidade de Vendas de Sensores por Dia e Mês de Venda',
                    xaxis: { title: 'Data' },
                    yaxis: { title: 'Quantidade' }
                };

                Plotly.newPlot('vendas-sensores-line-chart', lineData, lineLayout);

                var funcionarios = @Html.Raw(Json.Serialize(Model.Funcionarios));
                var vendasPorFuncionario = sensores.reduce((acc, sensor) => {
                    var login = funcionarios.find(func => func.id === sensor.id_func).login_func;
                    acc[login] = (acc[login] || 0) + 1;
                    return acc;
                }, {});

                var barData = [{
                    x: Object.keys(vendasPorFuncionario),
                    y: Object.values(vendasPorFuncionario),
                    type: 'bar',
                    name: 'Quantidade de Sensores Vendidos'
                }];

                var barLayout = {
                    title: 'Quantidade de Sensores Vendidos por Funcionário',
                    xaxis: { title: 'Login Funcionário' },
                    yaxis: { title: 'Quantidade de Sensores' }
                };

                Plotly.newPlot('vendas-funcionarios-bar-chart', barData, barLayout);

                var vendasPorTipoFuncionario = sensores.reduce((acc, sensor) => {
                    var login = funcionarios.find(func => func.id === sensor.id_func).login_func;
                    acc[login] = acc[login] || { LUMINOSIDADE: 0, TEMPERATURA: 0, UMIDADE: 0 };
                    acc[login][sensor.ds_tipo_sens.toUpperCase()] += 1;
                    return acc;
                }, {});

                var traceLuminosidade = {
                    y: Object.keys(vendasPorTipoFuncionario),
                    x: Object.values(vendasPorTipoFuncionario).map(func => func.LUMINOSIDADE),
                    name: 'LUMINOSIDADE',
                    type: 'bar',
                    orientation: 'h'
                };

                var traceTemperatura = {
                    y: Object.keys(vendasPorTipoFuncionario),
                    x: Object.values(vendasPorTipoFuncionario).map(func => func.TEMPERATURA),
                    name: 'TEMPERATURA',
                    type: 'bar',
                    orientation: 'h'
                };

                var traceUmidade = {
                    y: Object.keys(vendasPorTipoFuncionario),
                    x: Object.values(vendasPorTipoFuncionario).map(func => func.UMIDADE),
                    name: 'UMIDADE',
                    type: 'bar',
                    orientation: 'h'
                };

                var barStackedData = [traceLuminosidade, traceTemperatura, traceUmidade];

                var barStackedLayout = {
                    title: 'Quantidade de Sensores Vendidos por Tipo de Sensor',
                    barmode: 'stack',
                    xaxis: { title: 'Quantidade' },
                    yaxis: { title: 'Login Funcionário' }
                };

                Plotly.newPlot('vendas-tipo-sensores-bar-chart', barStackedData, barStackedLayout);
            });
        </script>
    </div>
</body>
</html>
```

### Main pages

Home:

![Home](https://github.com/user-attachments/assets/9fe105c2-7fd3-499f-889a-a39d2b1efd23)

About us:

![Sobre](https://github.com/user-attachments/assets/0e3ce64e-ea96-46f4-aa6e-55e2a6feb726)

Login:

![Login](https://github.com/user-attachments/assets/370ef7f1-9551-408c-8852-a8e178bc02e7)

The user will only be able to access the rest of the platform after logging in.

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

![Project Members](https://github.com/user-attachments/assets/9ff8e54f-bbfa-4f48-b6b9-e7829fa02184)

- Enzo Brito Alves de Oliveira - RA: 082220040
- Erikson Vieira Queiroz - RA: 082220021
- Guilherme Alves Barbosa - RA: 082220014
- Heitor Santos Ferreira - RA: 081230042
- Tainara do Nascimento Casimiro - RA: 082220011
- William Santim - RA: 082220033
