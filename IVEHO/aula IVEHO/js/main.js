function atualizarValor(id) {
  document.getElementById(
    'valor' + id.charAt(0).toUpperCase() + id.slice(1)
  ).innerText = document.getElementById(id).value;
}

function calcularMedia() {
  let preco = parseFloat(document.getElementById('preco').value) || 0;
  let qualidade = parseFloat(document.getElementById('qualidade').value) || 0;
  let tempo = parseFloat(document.getElementById('tempo').value) || 0;

  let pesos = [0.4, 0.35, 0.25];
  let somaPesos = pesos.reduce((a, b) => a + b, 0);
  let mediaPonderada =
    (preco * pesos[0] + qualidade * pesos[1] + tempo * pesos[2]) / somaPesos;

  document.getElementById('resultado').innerText = mediaPonderada.toFixed(2);
}

function calcularMontante() {
  // Pegando valores dos inputs
  let P = parseFloat(document.getElementById('capital').value) || 0;
  let i = parseFloat(document.getElementById('taxa').value) / 100 || 0;
  let n = parseInt(document.getElementById('periodos').value) || 0;

  // Cálculo dos juros compostos: M = P * (1 + i)^n
  let M = P * Math.pow(1 + i, n);

  // Exibir resultado formatado
  document.getElementById('resultado1').innerText = M.toFixed(2);
}

function converterParaBinario() {
  // Pegando o valor do input
  let decimal = parseInt(document.getElementById('decimal').value) || 0;

  // Garantindo que esteja dentro do intervalo permitido (0 a 255)
  if (decimal < 0 || decimal > 255) {
    alert('Insira um valor entre 0 e 255.');
    return;
  }

  // Convertendo para binário e garantindo 8 bits (com zeros à esquerda)
  let binario = decimal.toString(2).padStart(8, '0');

  // Exibir resultado
  document.getElementById('resultado2').innerText = binario;
}

function convertTemperature() {
  let temp = parseFloat(document.getElementById('inputTemp').value);
  let conversionType = document.getElementById('conversionType').value;
  let result;

  if (isNaN(temp)) {
    document.getElementById('result').innerText =
      'Por favor, insira um número válido.';
    return;
  }

  switch (conversionType) {
    case 'cToF':
      result = (temp * 9) / 5 + 32;
      document.getElementById(
        'result'
      ).innerText = `${temp}°C = ${result.toFixed(2)}°F`;
      break;
    case 'cToK':
      result = temp + 273.15;
      document.getElementById(
        'result'
      ).innerText = `${temp}°C = ${result.toFixed(2)}K`;
      break;
    case 'fToC':
      result = ((temp - 32) * 5) / 9;
      document.getElementById(
        'result'
      ).innerText = `${temp}°F = ${result.toFixed(2)}°C`;
      break;
    case 'kToC':
      result = temp - 273.15;
      document.getElementById(
        'result'
      ).innerText = `${temp}K = ${result.toFixed(2)}°C`;
      break;
    default:
      document.getElementById('result').innerText =
        'Selecione uma conversão válida.';
  }
}

function calcularResistencia() {
  let resistencias = document
    .getElementById('inputResistencias')
    .value.split(',')
    .map(Number);
  let tipoCircuito = document.getElementById('circuitType').value;
  let resultado;

  if (resistencias.some(isNaN)) {
    document.getElementById('resultado').innerText =
      'Por favor, insira valores numéricos válidos.';
    return;
  }

  if (tipoCircuito === 'serie') {
    resultado = resistencias.reduce((acc, r) => acc + r, 0);
  } else if (tipoCircuito === 'paralelo') {
    resultado = 1 / resistencias.reduce((acc, r) => acc + 1 / r, 0);
  }

  document.getElementById(
    'resultado9'
  ).innerText = `Resistência Equivalente: ${resultado.toFixed(2)} Ω`;
}
