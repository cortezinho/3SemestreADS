package aplicacoes;

import entidades.enumeracoes.NivelPrioridade;

public class TestePrioridade {

	public static void main(String[] args) {
		
		NivelPrioridade prioridade = NivelPrioridade.BAIX0;
		
		System.out.println("Status: " + prioridade);
		System.out.println("Código do status: " + prioridade.getCodigo());

	}

}
