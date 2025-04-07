package entidades;

public class Gerente extends Funcionario {

	public Gerente(double salario) {
		super(salario);
	}

	@Override
	public void calcularSalario() {
		System.out.println("O gerente tem um bônus salarial de 500 reais");
		double salario = getSalario() + 500;
		System.out.println("O salario do gerente é: " + salario);
	}

}
