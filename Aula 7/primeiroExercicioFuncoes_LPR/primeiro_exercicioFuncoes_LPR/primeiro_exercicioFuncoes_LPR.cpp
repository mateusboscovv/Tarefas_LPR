#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

int FuncaoInversa(int numeroDigitado)
{
   int numeroInverso = 0;

    while (numeroDigitado != 0)
    {
       int digito = numeroDigitado % 10;
       numeroInverso = numeroInverso * + digito;
        numeroDigitado /= 10;
    }

    return numeroInverso;
}

int main()
{
    int numeroDigitado;

    cout << "Digite algum numero inteiro\n";
    cin >> numeroDigitado;

    cout << "O reverso do numero " << numeroDigitado << " se tornou: " << FuncaoInversa(numeroDigitado) << endl;

    return 0;
}