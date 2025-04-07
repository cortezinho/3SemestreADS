package aplicacoes;

import entidades.Funcionario;
import entidades.Gerente;

public class TesteFuncionario {

	public static void main(String[] args) {

		Funcionario funcionario = new Funcionario(1000);
		Gerente gerente = new Gerente(1000);
		
		funcionario.calcularSalario();
		gerente.calcularSalario();
		

	}

}
