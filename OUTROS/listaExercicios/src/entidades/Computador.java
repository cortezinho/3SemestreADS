package entidades;

public class Computador {
	
	private Processador processador;
	private Memoria memoria;
	
	public Computador(Processador processador, Memoria memoria) {
		this.processador = processador;
		this.memoria = memoria;
	}
	
	public void mostrarConfiguracao() {
		System.out.println("Processador: " + processador.getModelo());
		System.out.println("Memória RAM: " + memoria.getCapacidade() + " GB");
	}
	
	

}
