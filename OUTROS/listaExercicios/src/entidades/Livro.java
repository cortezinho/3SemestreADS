package entidades;

public class Livro {
	
	private String titulo = "Senhor dos anéis: A sociedade do anel";
	private String autor = "J.R.R Tolkien";
	private int numeroPaginas = 576;
	
	public void infos() {
		System.out.println("O título do livro é: " + titulo + ".");
		System.out.println("O autor é: " + autor + ".");
		System.out.println("O livro tem: " + numeroPaginas + " páginas" + ".");
	}
	
	

}
