const ctx = document.getElementById('sensorChart').getContext('2d');

const chart = new Chart(ctx, {
  type: 'line',
  data: {
    labels: [],
    datasets: [
      { label: 'Temperatura (°C)', data: [], borderColor: 'red', fill: false },
      { label: 'Unidade (%)', data: [], borderColor: 'blue', fill: false },
      { label: 'Pressão (hPa)', data: [], borderColor: 'green', fill: false },
    ],
  },
  options: {
    responsive: true,
    scales: {
      x: { title: { display: true, text: 'Tempo' } },
    },
  },
});

async function atualizarSensores() {
  try {
    const response = await fetch('http://127.0.0.1:5000/sensores');

    const data = await response.json();

    document.getElementById('temp').innerText = data.temperatura;
    document.getElementById('hum').innerText = data.umidade;
    document.getElementById('pres').innerText = data.pressao;

    const now = new Date().toLocaleTimeString();

    chart.data.labels.push(now); // Adiciona o horário atual ao eixo X
    chart.data.datasets[0].data.push(data.temperatura); // Adiciona temperatura ao gráfico
    chart.data.datasets[1].data.push(data.umidade); // Adiciona umidade ao gráfico
    chart.data.datasets[2].data.push(data.pressao); // Adiciona pressão ao gráfico

    // Mantém apenas os últimos 10 valores no gráfico para evitar sobrecarga
    if (chart.data.labels.length > 20) {
      chart.data.labels.shift(); // Remove o primeiro item da lista de labels
      chart.data.datasets.forEach((dataset) => dataset.data.shift()); // Remove os primeiros valores de cada datase
    }

    // Atualiza o gráfico na tela
    chart.update();
  } catch (error) {
    // Se houver um erro na requisicão, exibe no console
    console.error('Erro ao buscar dados:', error);
  }
}

setInterval(atualizarSensores, 2000);
