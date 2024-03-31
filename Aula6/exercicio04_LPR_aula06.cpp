#include <iostream>

using namespace std;

int main()
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


