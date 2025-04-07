package entidades;

public class ContaBancaria {

	private double saldo;
	private int numero;
	
	

	public ContaBancaria(double saldo, int numero) {
		this.saldo = saldo;
		this.numero = numero;
	}

	public double getSaldo() {
		return saldo;
	}

	public void setSaldo(double saldo) {
		this.saldo = saldo;
	}
	
	public void mostrarSaldo() {
		System.out.println(saldo);
	}

	public void depositar(double deposito) {
		saldo += deposito;
		
	}

}
