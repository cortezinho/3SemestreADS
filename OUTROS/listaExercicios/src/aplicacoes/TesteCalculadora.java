package aplicacoes;

import entidades.Calculadora;

public class TesteCalculadora {

	public static void main(String[] args) {
		
		Calculadora calc = new Calculadora(10,5);
		
		calc.somar();
		
		calc.subtrair();
		
		calc.multiplicar();
		
		calc.dividir();

	}

}
