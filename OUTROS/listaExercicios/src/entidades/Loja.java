package entidades;

public class Loja {

	public Integer calcularPreco(int preco, int quantidade) {
		return preco * quantidade;
	}

	public Integer calcularPreco(int preco, int quantidade, int desconto) {
		return (preco - (preco * (desconto / 100))) * quantidade;
	}

}
