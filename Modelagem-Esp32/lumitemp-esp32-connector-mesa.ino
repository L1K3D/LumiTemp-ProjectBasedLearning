// Função para inicializar a comunicação serial
void initSerial() {
    Serial.begin(115200);
}

// Função setup - configuração inicial do sistema
void setup() {
    InitOutput(); // Inicializa o pino de saída
    initSerial(); // Inicializa a comunicação seria
    delay(5000);
}

// Função principal - loop
void loop() {
    getValueAquecedor();
}

void getValueAquecedor() {

    const int potPin = 19;
    int sensorValue = analogRead(potPin);
    char msg[10];
    sprintf(msg, "%d", sensorValue);
    Serial.println("Valor: " + String(msg));

}