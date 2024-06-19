#include <iostream>

using namespace std;

 float totalPreco, mediaLivros, numPaginas, quantLivros;

int main(void) {


	struct Livro {
		string Titulo;
		string Autor;
		int AnoPublicacao;
		int NumeroPaginas;
		float Preco;
	};

	cout << "Biblioteca\n";

	Livro biblioteca[3];

	for (int i = 0; i < 3; i++) {
	
		cout << "Digite o titulo da obra: ";
		cin >> biblioteca[i].Titulo;

		cout << "Digite o autor: ";
		cin >> biblioteca[i].Autor;

		cout << "Digite o ano de publicação: ";
		cin >> biblioteca[i].AnoPublicacao;

		cout << "Digite o número de páginas: ";
		cin >> biblioteca[i].NumeroPaginas;

		cout << "Digite o preço: ";
		cin >> biblioteca[i].Preco;

		 totalPreco += biblioteca[i].Preco;
		 numPaginas += biblioteca[i].NumeroPaginas;

		 /* Dúvida: Como faria para saber o numero p/ quant. Poderia acessa o ultimo indice do vetor para fazer a conta.interrogaçção*/
	}

	mediaLivros = numPaginas / 3;

	/*for (int i = 0; i < 3; i++) {
		cout << "Os livros cadastrados foram: " << biblioteca[i].Titulo << "\n";
	}*/

	cout << "O preco total dos livros : " << totalPreco << "\n";
	cout << " A media de paginas dos livros: " << mediaLivros << "\n";
}