package aplicacoes;

import entidades.ContaBancaria;

public class TesteContaBancaria {

	public static void main(String[] args) {

		ContaBancaria conta = new ContaBancaria(1000, 0001);
		
		conta.mostrarSaldo();
		
		conta.depositar(500);
		
		conta.mostrarSaldo();

	}

}
