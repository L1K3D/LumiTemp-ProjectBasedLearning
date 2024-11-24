import dash
from dash import dcc, html
from dash.dependencies import Input, Output, State
import plotly.graph_objs as go
import requests
from datetime import datetime
import pytz

# Constantes para IP e porta
IP_ADDRESS = "4.228.60.11"
PORT_STH = 8666
DASH_HOST = "0.0.0.0"  # Configurado para permitir acesso de qualquer IP

# Função para obter dados de luminosidade da API
def get_luminosity_data(lastN):
    url = f"http://{IP_ADDRESS}:{PORT_STH}/STH/v1/contextEntities/type/Lamp/id/urn:ngsi-ld:Lamp:04x/attributes/luminosity?lastN={lastN}"
    headers = {
        'fiware-service': 'smart',
        'fiware-servicepath': '/'
    }
    response = requests.get(url, headers=headers)
    if response.status_code == 200:
        data = response.json()
        try:
            values = data['contextResponses'][0]['contextElement']['attributes'][0]['values']
            return values
        except KeyError as e:
            print(f"Erro de chave: {e}")
            return []
    else:
        print(f"Erro ao acessar {url}: {response.status_code}")
        return []
    
# Função para obter dados de umidade da API
def get_humidity_data(lastN):
    url = f"http://{IP_ADDRESS}:{PORT_STH}/STH/v1/contextEntities/type/Humi/id/urn:ngsi-ld:Humi:04x/attributes/humidity?lastN={lastN}"
    headers = {
        'fiware-service': 'smart',
        'fiware-servicepath': '/'
    }
    response = requests.get(url, headers=headers)
    if response.status_code == 200:
        data = response.json()
        try:
            values = data['contextResponses'][0]['contextElement']['attributes'][0]['values']
            return values
        except KeyError as e:
            print(f"Erro de chave: {e}")
            return []
    else:
        print(f"Erro ao acessar {url}: {response.status_code}")
        return []
    
# Função para obter dados de temperatura da API
def get_temperature_data(lastN):
    url = f"http://{IP_ADDRESS}:{PORT_STH}/STH/v1/contextEntities/type/Temp/id/urn:ngsi-ld:Temp:04x/attributes/temperature?lastN={lastN}"
    headers = {
        'fiware-service': 'smart',
        'fiware-servicepath': '/'
    }
    response = requests.get(url, headers=headers)
    if response.status_code == 200:
        data = response.json()
        try:
            values = data['contextResponses'][0]['contextElement']['attributes'][0]['values']
            return values
        except KeyError as e:
            print(f"Erro de chave: {e}")
            return []
    else:
        print(f"Erro ao acessar {url}: {response.status_code}")
        return []

# Função para converter os timestamps de UTC para o horário do Brasil
def convert_to_brazil_time(timestamps):
    utc = pytz.utc
    brazil_time_zone = pytz.timezone('America/Sao_Paulo')
    converted_timestamps = []
    
    for timestamp in timestamps:
        try:
            # Remover 'T' e 'Z' para padronizar o formato de timestamp
            timestamp = timestamp.replace('T', ' ').replace('Z', '')
            # Converte a string para um objeto datetime, usando o fuso horário UTC
            converted_time = utc.localize(datetime.strptime(timestamp, '%Y-%m-%d %H:%M:%S.%f')).astimezone(brazil_time_zone)
        except ValueError:
            # Caso o timestamp não tenha milissegundos
            converted_time = utc.localize(datetime.strptime(timestamp, '%Y-%m-%d %H:%M:%S')).astimezone(brazil_time_zone)
        
        converted_timestamps.append(converted_time)
    
    return converted_timestamps

# Define o valor de lastN (quantidade de pontos mais recentes a serem obtidos)
lastN = 15  # Obter os 10 pontos mais recentes a cada intervalo

# Inicializa a aplicação Dash
app = dash.Dash(__name__)

# Layout da aplicação, definindo os componentes visuais
app.layout = html.Div([
    html.H1('LumiTemp Data Viewer'),  # Título da página
    dcc.Graph(id='lumitemp-graph'),  # Gráfico para exibir os dados
    # Store para armazenar os dados históricos
    dcc.Store(id='data-store', data={'timestamps': [], 'luminosity_values': [], 'humidity_values': [], 'temperature_values': []}),
    # Intervalo de atualização dos dados (a cada 10 segundos)
    dcc.Interval(
        id='interval-component',
        interval=10*6000,  # em milissegundos (10 segundos)
        n_intervals=0
    )
])

# Função de callback para atualizar os dados armazenados a cada intervalo
@app.callback(
    Output('data-store', 'data'),
    Input('interval-component', 'n_intervals'),
    State('data-store', 'data')
)
def update_data_store(n, stored_data):
    # Garantir que todas as chaves necessárias existem
    stored_data.setdefault('timestamps', [])
    stored_data.setdefault('luminosity_values', [])
    stored_data.setdefault('humidity_values', [])
    stored_data.setdefault('temperature_values', [])

    # Obtém os dados de luminosidade, umidade e temperatura
    data_luminosity = get_luminosity_data(lastN)
    data_humidity = get_humidity_data(lastN)
    data_temperature = get_temperature_data(lastN)

    # Se houver dados de luminosidade, processa-os e armazena
    if data_luminosity:
        luminosity_values = [float(entry['attrValue']) for entry in data_luminosity]
        timestamps = [entry['recvTime'] for entry in data_luminosity]
        timestamps = convert_to_brazil_time(timestamps)  # Converte os timestamps para horário de Brasília

        stored_data['timestamps'].extend(timestamps)
        stored_data['luminosity_values'].extend(luminosity_values)

    # Se houver dados de umidade, processa-os e armazena
    if data_humidity:
        humidity_values = [float(entry['attrValue']) for entry in data_humidity]
        timestamps = [entry['recvTime'] for entry in data_humidity]
        timestamps = convert_to_brazil_time(timestamps)  # Converte os timestamps para horário de Brasília

        stored_data['timestamps'].extend(timestamps)
        stored_data['humidity_values'].extend(humidity_values)

    # Se houver dados de temperatura, processa-os e armazena
    if data_temperature:
        temperature_values = [float(entry['attrValue']) for entry in data_temperature]
        timestamps = [entry['recvTime'] for entry in data_temperature]
        timestamps = convert_to_brazil_time(timestamps)  # Converte os timestamps para horário de Brasília

        stored_data['timestamps'].extend(timestamps)
        stored_data['temperature_values'].extend(temperature_values)

    return stored_data

# Função de callback para atualizar o gráfico com os dados armazenados
@app.callback(
    Output('lumitemp-graph', 'figure'),
    Input('data-store', 'data')
)
def update_graph(stored_data):
    # Verifica se há dados para atualizar o gráfico
    if (stored_data['timestamps']) and (stored_data['luminosity_values'] or stored_data['humidity_values'] or stored_data['temperature_values']):
        # Calcula a média de luminosidade, umidade e temperatura
        mean_luminosity = sum(stored_data['luminosity_values']) / len(stored_data['luminosity_values']) if stored_data['luminosity_values'] else 0
        mean_humidity = sum(stored_data['humidity_values']) / len(stored_data['humidity_values']) if stored_data['humidity_values'] else 0
        mean_temperature = sum(stored_data['temperature_values']) / len(stored_data['temperature_values']) if stored_data['temperature_values'] else 0

        # Cria as séries de dados para o gráfico
        trace_luminosity = go.Scatter(
            x=stored_data['timestamps'],
            y=stored_data['luminosity_values'],
            mode='lines+markers',
            name='Luminosidade',
            line=dict(color='orange')
        )
        
        trace_mean_luminosity = go.Scatter(
            x=[stored_data['timestamps'][0], stored_data['timestamps'][-1]],
            y=[mean_luminosity, mean_luminosity],
            mode='lines',
            name='Média Luminosidade',
            line=dict(color='orange', dash='dash')
        )
        
        trace_humidity = go.Scatter(
            x=stored_data['timestamps'],
            y=stored_data['humidity_values'],
            mode='lines+markers',
            name='Umidade',
            line=dict(color='blue')
        )
        
        trace_mean_humidity = go.Scatter(
            x=[stored_data['timestamps'][0], stored_data['timestamps'][-1]],
            y=[mean_humidity, mean_humidity],
            mode='lines',
            name='Média Umidade',
            line=dict(color='blue', dash='dash')
        )
        
        trace_temperature = go.Scatter(
            x=stored_data['timestamps'],
            y=stored_data['temperature_values'],
            mode='lines+markers',
            name='Temperatura',
            line=dict(color='red')
        )
        
        trace_mean_temperature = go.Scatter(
            x=[stored_data['timestamps'][0], stored_data['timestamps'][-1]],
            y=[mean_temperature, mean_temperature],
            mode='lines',
            name='Média Temperatura',
            line=dict(color='red', dash='dash')
        )

        # Cria a figura do gráfico com as séries de dados
        fig = go.Figure(data=[trace_luminosity, trace_mean_luminosity, trace_humidity, trace_mean_humidity, trace_temperature, trace_mean_temperature])

        # Atualiza o layout do gráfico
        fig.update_layout(
            title='Luminosidade, Umidade e Temperatura ao Longo do Tempo',
            xaxis_title='Timestamp',
            yaxis_title='Valores',
            hovermode='closest'
        )

        return fig

    return {}

# Inicia o servidor da aplicação Dash
if __name__ == '__main__':
    app.run_server(debug=True, host=DASH_HOST, port=8050)