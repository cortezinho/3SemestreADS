import requests
import random
import csv
import time  # time.sleep para adicionar um intervalo entre os envios

API_KEY = "ESY3ORO7UBF9F0YQ"
URL = f"https://api.thingspeak.com/update?api_key={API_KEY}"
api_key = "ESY3ORO7UBF9F0YQ"

def enviar_dados(id1, id2, id3, id4):
    url = f"https://api.thingspeak.com/update?api_key={api_key}&field1={id1}&field2={id2}&field3={id3}&field4={id4}"
    resposta = requests.get(url)
    print(f"Resposta: {resposta.text}")
    print(id1,id2,id3,id4)

def main():
    while True:  # Loop infinito
        temperatura = random.uniform(20, 30)  # Simula temperatura entre 20 e 30°C
        umidade = random.uniform(50, 70)  # Simula umidade entre 50% e 70%
        pressao = random.uniform(100, 900)  # Simula pressão atmosférica entre 100 bar e 900 bar
        luz = random.uniform(45, 250)  # Simula umidade entre 45 lux e 250 lux
        enviar_dados(temperatura, umidade, pressao, luz)
        time.sleep(15)  # Espera 30 segundos entre os envios (pode ajustar o tempo)        

main()


