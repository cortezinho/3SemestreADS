package aplicacoes;

import entidades.Bicicleta;
import entidades.Carro;

public class TesteVeiculos {

	public static void main(String[] args) {
		
		Carro carro = new Carro();
		Bicicleta bicicleta = new Bicicleta();
		
		carro.mover();
		bicicleta.mover();

	}

}
