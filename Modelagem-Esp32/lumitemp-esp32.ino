#include <WiFi.h>
#include <PubSubClient.h>

// Configuração dos pinos e tipo de sensor DHT
#define DHTPIN 25 // Pino de dados do sensor DHT
#define DHTTYPE DHT11 // Tipo de sensor DHT22
DHT dht(DHTPIN, DHTTYPE); // Inicialização do sensor DHT

// Configurações - variáveis editáveis
const char* default_SSID = "S24FE-Heitor"; // Nome da rede Wi-Fi
const char* default_PASSWORD = "senha123"; // Senha da rede Wi-Fi
const char* default_BROKER_MQTT = "4.228.60.11"; // IP do Broker MQTT
const int default_BROKER_PORT = 1883; // Porta do Broker MQTT
const char* default_ID_MQTT = "fiware_04x"; // ID MQTT

// Tópicos MQTT para luminosidade
const char* default_TOPICO_LUMINOSIDADE_SUBSCRIBE = "/TEF/lamp04x/cmd"; // Tópico MQTT de escuta
const char* default_TOPICO_LUMINOSIDADE_PUBLISH_1 = "/TEF/lamp04x/attrs"; // Publicação de estado de luminosidade
const char* default_TOPICO_LUMINOSIDADE_PUBLISH_2 = "/TEF/lamp04x/attrs/l"; // Publicação de valor de luminosidade
const int default_D4 = 2; // Pino do LED onboard

// Declaração das variáveis de tópico de luminosidade com cast para char*
const char* topicPrefix = "lamp04x";
char* TOPICO_LUMINOSIDADE_SUBSCRIBE = const_cast<char*>(default_TOPICO_LUMINOSIDADE_SUBSCRIBE);
char* TOPICO_LUMINOSIDADE_PUBLISH_1 = const_cast<char*>(default_TOPICO_LUMINOSIDADE_PUBLISH_1);
char* TOPICO_LUMINOSIDADE_PUBLISH_2 = const_cast<char*>(default_TOPICO_LUMINOSIDADE_PUBLISH_2);

// Tópicos MQTT para temperatura
const char* default_TOPICO_TEMPERATURA_PUBLISH_1 = "/TEF/temp04x/attrs"; // Publicação de estado de temperatura
const char* default_TOPICO_TEMPERATURA_PUBLISH_2 = "/TEF/temp04x/attrs/t"; // Publicação de valor de temperatura
char* TOPICO_TEMPERATURA_PUBLISH_1 = const_cast<char*>(default_TOPICO_TEMPERATURA_PUBLISH_1);
char* TOPICO_TEMPERATURA_PUBLISH_2 = const_cast<char*>(default_TOPICO_TEMPERATURA_PUBLISH_2);

// Configurações editáveis para conexão Wi-Fi e MQTT
char* SSID = const_cast<char*>(default_SSID);
char* PASSWORD = const_cast<char*>(default_PASSWORD);
char* BROKER_MQTT = const_cast<char*>(default_BROKER_MQTT);
int BROKER_PORT = default_BROKER_PORT;
char* ID_MQTT = const_cast<char*>(default_ID_MQTT);
int D4 = default_D4;

WiFiClient espClient; // Cliente Wi-Fi
PubSubClient MQTT(espClient); // Cliente MQTT
char EstadoSaida = '0'; // Estado inicial do LED

// Função para inicializar a comunicação serial
void initSerial() {
    Serial.begin(115200);
}

// Função para inicializar o Wi-Fi
void initWiFi() {
    delay(10);
    Serial.println("------Conexao WI-FI------");
    Serial.print("Conectando-se na rede: ");
    Serial.println(SSID);
    Serial.println("Aguarde");
    reconectWiFi();
}

// Função para configurar o servidor MQTT e o callback de mensagens
void initMQTT() {
    MQTT.setServer(BROKER_MQTT, BROKER_PORT);
    MQTT.setCallback(mqtt_callback);
}

// Função setup - configuração inicial do sistema
void setup() {
    dht.begin(); // Inicializa o sensor DHT
    InitOutput(); // Inicializa o pino de saída
    initSerial(); // Inicializa a comunicação serial
    initWiFi(); // Conecta ao Wi-Fi
    initMQTT(); // Conecta ao Broker MQTT
    delay(5000);
    MQTT.publish(TOPICO_LUMINOSIDADE_PUBLISH_1, "s|on"); // Publica o estado inicial no tópico
}

// Função principal - loop
void loop() {
    VerificaConexoesWiFIEMQTT(); // Verifica as conexões Wi-Fi e MQTT
    EnviaEstadoOutputMQTT(); // Envia o estado do LED para o broker
    handleTemperature(); // Função para monitoramento de temperatura
    MQTT.loop(); // Mantém a conexão com o broker MQTT
    delay(12000);
}

// Função para reconectar ao Wi-Fi caso a conexão seja perdida
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

    // Garante que o LED inicie desligado
    digitalWrite(D4, LOW);
}

// Callback para tratar mensagens recebidas do broker MQTT
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

    // Aciona ou desliga o LED baseado no tópico
    if (msg.equals(onTopic)) {
        digitalWrite(D4, HIGH);
        EstadoSaida = '1';
    }

    if (msg.equals(offTopic)) {
        digitalWrite(D4, LOW);
        EstadoSaida = '0';
    }
}

// Verifica conexões e tenta reconectar se necessário
void VerificaConexoesWiFIEMQTT() {
    if (!MQTT.connected())
        reconnectMQTT();
    reconectWiFi();
}

// Envia o estado do LED ao broker MQTT
void EnviaEstadoOutputMQTT() {
    if (EstadoSaida == '1') {
        MQTT.publish(TOPICO_LUMINOSIDADE_PUBLISH_1, "s|on");
        Serial.println("- Led Ligado");
    }
    if (EstadoSaida == '0') {
        MQTT.publish(TOPICO_LUMINOSIDADE_PUBLISH_1, "s|off");
        Serial.println("- Led Desligado");
    }
    Serial.println("- Estado do LED onboard enviado ao broker!");
    delay(1000);
}

// Função para inicializar o LED com uma sequência piscante
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

// Função para reconectar ao broker MQTT
void reconnectMQTT() {
    while (!MQTT.connected()) {
        Serial.print("* Tentando se conectar ao Broker MQTT: ");
        Serial.println(BROKER_MQTT);
        if (MQTT.connect(ID_MQTT)) {
            Serial.println("Conectado com sucesso ao broker MQTT!");
            MQTT.subscribe(TOPICO_LUMINOSIDADE_SUBSCRIBE); // Inscrição no tópico de controle
        } else {
            Serial.println("Falha ao reconectar no broker.");
            Serial.println("Haverá nova tentativa de conexão em 2s");
            delay(2000);
        }
    }
}

// Funções para monitorar e enviar valores de luminosidade, umidade e temperatura
void handleTemperature() {
    const int potPin = 34; // Pino analógico para luminosidade
    int sensorValue = analogRead(potPin);
    int temperature = map(sensorValue, 0, 4095, 0, 100);
    char msg[10];
    sprintf(msg, "%d", temperature);
    MQTT.publish(TOPICO_TEMPERATURA_PUBLISH_2, msg); // Publica luminosidade
    Serial.println("Temperatura: " + String(msg));

}