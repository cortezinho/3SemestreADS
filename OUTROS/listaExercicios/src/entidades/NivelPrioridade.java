package entidades;

public enum NivelPrioridade {
	
	BAIX0(1),
	MEDIO(2),
	ALTO(3),
	URGENTE(4);
	
	private int codigo;
	
	NivelPrioridade(int codigo){
		this.codigo = codigo;
	}
	
	public int getCodigo() {
		return codigo;
	}

}
