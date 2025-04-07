package entidades;

public class Pessoa {
	
	private String nome;
	private int idade;
	
	
	public Pessoa(String nome, int idade) {
		this.nome = nome;
		this.idade = idade;
	}
	
	public void infos() {
		System.out.println("Nome da pessoa: " + nome);
		System.out.println("Idade da pessoa: " + idade);
	}
	
	

}
