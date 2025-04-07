package entidades.interfaces;

public class Carro implements Veiculo {

	@Override
	public boolean mover() {
		System.out.println("vruum");
		return false;
	}

}
