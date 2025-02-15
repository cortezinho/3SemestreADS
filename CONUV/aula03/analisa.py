import pandas as pd

def calcular_medias(arquivo_csv):
    try:
        # Ler o arquivo CSV usando pandas
        df = pd.read_csv(arquivo_csv)
        
        # Verificar se o DataFrame contém dados
        if df.empty:
            print("O arquivo CSV está vazio.")
        else:
            # Remover as colunas específicas: field5, latitude, longitude, elevation, status
            colunas_para_remover = ['field5', 'latitude', 'longitude', 'elevation', 'status']
            df = df.drop(columns=[col for col in colunas_para_remover if col in df.columns], errors='ignore')
            
            # Renomear as colunas 'field1', 'field2', 'field3' e 'field4' para nomes mais compreensíveis
            df = df.rename(columns={
                'field1': 'temperatura',
                'field2': 'umidade',
                'field3': 'pressao',
                'field4': 'luminosidade'
            })
            
            # Remover colunas de data e hora (considerando que são do tipo datetime ou texto)
            df = df.select_dtypes(include=['number'])  # Seleciona apenas as colunas numéricas
            
            # Verificar se ainda existem colunas numéricas após a exclusão
            if df.empty:
                print("O arquivo CSV não contém colunas numéricas após a exclusão.")
                return
            
            # Calcular as médias de todas as colunas numéricas
            medias = df.mean()
            
            # Exibir as médias
            print("Médias das colunas numéricas:")
            print(medias)
            
            # Criar um novo DataFrame com as médias
            medias_df = pd.DataFrame(medias).reset_index()
            medias_df.columns = ['Coluna', 'Média']  # Renomear as colunas para 'Coluna' e 'Média'
            
            # Salvar as médias em um novo arquivo CSV
            output_file = 'medias_calculadas.csv'
            medias_df.to_csv(output_file, index=False)
            
            # Confirmar a criação do arquivo CSV
            print(f"As médias foram salvas no arquivo '{output_file}'.")
    
    except FileNotFoundError:
        print(f"O arquivo '{arquivo_csv}' não foi encontrado. Verifique se o caminho está correto.")
    except Exception as e:
        print(f"Ocorreu um erro: {e}")

# Caminho do arquivo CSV de entrada (substitua com o nome correto do seu arquivo CSV)
arquivo_csv = 'dados.csv'  # Certifique-se de que este arquivo está no mesmo diretório do script
calcular_medias(arquivo_csv)
