#include <iostream>

using namespace std;




 static void SomaDigitoAoQuadrado()
 {
	 int numero, numElevado, somaDigitos = 0;
	 cout << "Digite algum numero inteiro: ";
	 cin >> numero;

	 numElevado = numero * numero;

	 while (numElevado > 0)
	 {
		 int digito = numElevado % 10;
		 somaDigitos += digito;
		 numElevado /= 10;
	 }
	 cout << "A soma dos algarismos ao quadrado: " << somaDigitos << endl;
 }

 int main()
{
	 int escolha;

	 cout << " ==== AGRUPAMENTO DAS FUNCOES ==== ";
	 cout << "\n Digite qual tarefa voce deseja acessar:\n 1. Calculo da media aritimetica de um conjunto de numeros.\n 3. Soma de todos os numeros impares multiplos de 3 entre 50 a 500.\n 4. Calculo da soma do quadrado dos numeros inseridos.\n";
	 cin >> escolha;
	
		 switch (escolha)
		 {
		 case 1:
			 cout << "Voce escolheu o calculo da media aritimetica de um conjunto de numeros ";
				// FuncaoMediaAritimetica();
			 break;

		 case 3:
			 cout << "Voce escolheu a soma de todos os numeros impares multiplos de 3 entre 50 a 500 ";
			 //FuncaoSomaMultTres()
			 break;
		 case 4:
			 cout << "Voce escolheu calculo da soma ao quadrado dos numeros inseridos\n";
			 SomaDigitoAoQuadrado();
			 break;
		 default:
			 cout << "Opcao invalida, tente novamente!";
			 break;
		 }
		  
}