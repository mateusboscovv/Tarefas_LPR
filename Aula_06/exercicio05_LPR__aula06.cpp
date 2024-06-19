#include <iostream>
#include <string>  //essa string me premite criar (to_sting)'s, função parecida da interpolação em c#
#include <iomanip> // p/ usar stprecision e fixed

using namespace std;

int main()
{
    double horasTreinadas, totalHorasUmaSemana, tempo, dias, semanas, meses;
    int cont;
    cout << "Insira o numero de horas de treinamento por dia: ";
    cin >> horasTreinadas;

    totalHorasUmaSemana = horasTreinadas * 5; //horas de treinamento em uma semana 

    for (double i = totalHorasUmaSemana; i < 1000; i++)
    {
        dias = 1000 / totalHorasUmaSemana;

        semanas = dias / 5;

        meses = semanas / 4, 5;
    }

    // Convertendo cada número para uma string com precisão de uma casa decimal
    std::string strDias = std::to_string(dias);
    std::string strSemanas = std::to_string(semanas);
    std::string strMeses = std::to_string(meses);

    // Ajustando cada string para conter apenas uma casa decimal
    size_t posPonto1 = strDias.find('.');
    size_t posPonto2 = strSemanas.find('.');
    size_t posPonto3 = strMeses.find('.');

    if (posPonto1 != std::string::npos && posPonto2 != std::string::npos && posPonto3 != std::string::npos) {
        strDias = strDias.substr(0, posPonto1 + 0);
        strSemanas = strSemanas.substr(0, posPonto2 + 0);
        strMeses = strMeses.substr(0, posPonto3 + 0);
    }

    // Imprimindo as strings formatadas
    cout << "Serao necessarias " << strMeses << " mes(es), " << strSemanas << " semana(s) e " << strDias << " dia(s)." << endl;
    return 0;
}




