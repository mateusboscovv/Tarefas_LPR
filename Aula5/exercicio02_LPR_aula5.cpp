
#include <iostream>

using namespace std;

int main()
{
	//variaveis
	int numero1, numero;


	cout << "Digite o primeiro valor inteiro: ";
	cin >> numero;

	cout << "Digite o segundo valor inteiro: ";
	cin >> numero1;

	if (numero % numero1 == 0 || numero1 % numero == 0)
	{
		cout << numero << " e " << numero1 << " " << "Sao Multiplos" << endl;
	}
	else
	{
		cout << numero << " e " << numero1 << " " << "Nao sao multiplos" << endl;
	}
}

