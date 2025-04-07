package aplicacoes;

import entidades.Animal;
import entidades.Cachorro;
import entidades.Gato;

public class TesteAnimais {

	public static void main(String[] args) {
		
		Animal animal = new Animal();
		Cachorro cachorro = new Cachorro();
		Gato gato = new Gato();
		
		animal.fazerSom();
		cachorro.fazerSom();
		gato.fazerSom();
		
		

	}

}
