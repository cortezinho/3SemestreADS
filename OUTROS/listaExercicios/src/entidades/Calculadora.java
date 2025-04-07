package entidades;

public class Calculadora {
	private double valor1;
	private double valor2;
	
	public Calculadora(double valor1, double valor2) {
		this.valor1 = valor1;
		this.valor2 = valor2;
	}
	
	public void somar() {
		double resultado = valor1 + valor2;
		System.out.println(resultado);
	}
	
	public void subtrair() {
		double resultado = valor1 - valor2;
		System.out.println(resultado);
	}
	
	public void multiplicar() {
		double resultado = valor1 * valor2;
		System.out.println(resultado);
	}
	
	public void dividir() {
		double resultado = valor1 / valor2;
		System.out.println(resultado);
	}
	
	

}
