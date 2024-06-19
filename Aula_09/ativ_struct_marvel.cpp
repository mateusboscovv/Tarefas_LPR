#include <iostream>
#include <string>

using namespace std; 

 struct DadosHeroi {
	 string Nome;
	 string Poder;
	 float Pontuacao = 0;
};

 int indice, escolha;
 float pontuacaoTotal = 0;

 DadosHeroi Dados[5];
 DadosHeroi Equipe[3];

 void Cadastro() {
	
	for (int i = 0; i < 5; i++) {
		cout << "Insira o nome do heroi: ";
		cin >> Dados[i].Nome;

		cout << "Insira o poder do heroi: ";
		cin >> Dados[i].Poder;
		
		cout << "Insira a pontuacao do heroi: ";
		cin >> Dados[i].Pontuacao;
	}
}

 void SelecionarHeroi() {

	 cout << "---- Selecionar Equipe ----";
	 cout << "\n Os herois sao: \n";
	 for (int i = 0; i < 5; i++) {
		 cout << "\nO heroi: " << Dados[i].Nome << "\n";
	 }

	 for (int i = 0; i < 3; i++) {
		 cout << " Digite um numero de 0 a 4 para escolher o heroi, (esta ordem de 0 a 4 eh respectiva aos nomes):\n";
		 cin >> indice;

		 if (indice >= 0 && indice <= 4) {

			 cout << "\nHeroi selecionado: ";
			
			 cout << "\nNome: " << Dados[indice].Nome;

			 cout << "\nPoder: " << Dados[indice].Poder;

			 cout << "\nPontuacao: " << Dados[indice].Pontuacao;
		 }
		 else {
			 cout << "\nÍndice inválido!";
		 }

		 Equipe[i].Nome = Dados[indice].Nome;;
		 Equipe[i].Poder = Dados[indice].Poder;
		 Equipe[i].Pontuacao += Dados[indice].Pontuacao;

	 }


 }

 void calcularPontuacaoTotal(DadosHeroi Equipe[3]) {

	 for (int i = 0; i < 3; i++) {

		 pontuacaoTotal += Equipe[i].Pontuacao;

	 }

 }

 float exibirEquipe() {

	 cout << "\nOs integrantes da equipe sao: \n";
	 for (int i = 0; i < 3; i++) {
		 cout << "heroi: " << Equipe[i].Nome << "\n";
		 cout << "Seu poder: " << Equipe[i].Poder << "\n";
	 }

	 cout << "A pontuacao total em equipe eh: " << pontuacaoTotal;

	 return 0;
 }

 void menuPrincipal() {

	 cout << "\nOpcoes:\n 1. Cadastro de herois.\n 2. Selecao de equipe.\n 3. Exibicao da equipe.\n 4. Sair do programa.\n Digite um numero correspondente a partir de sua escolha:\n";
	 cin >> escolha;

	 switch (escolha)
	 {
	 case 1:
		 Cadastro();
		 break;
	 case 2: 
		 SelecionarHeroi();
		 break;
	 case 3:
		 exibirEquipe();
		 printf("passou");
		 break;
	 case 4:
		 exit(0);
	 default:
		 break;
	 }

 }

int main() {

	cout << " ---- Cadastro de Herois ----"; 

	while (1) {
		menuPrincipal();
	}

	return 0;
}