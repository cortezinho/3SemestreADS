package entidades;

public class Funcionario {
	
	private double salario;

	public Funcionario(double salario) {
		this.setSalario(salario);
	}
	
	public void calcularSalario() {
		System.out.println("O salario do funcionario é: " + getSalario());
	}

	public double getSalario() {
		return salario;
	}

	public void setSalario(double salario) {
		this.salario = salario;
	}

}
