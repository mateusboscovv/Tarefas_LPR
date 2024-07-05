#include <iostream>
#include <map>
#include <string>
#include <numeric>
#include <algorithm>

using namespace std;

int main() {
    map<string, int> cidades = {
        {"CidadeA", 100000},
        {"CidadeB", 200000},
        {"CidadeC", 150000},
        {"CidadeD", 300000},
        {"CidadeE", 250000}
    };


    double mediaPopulacao = accumulate(cidades.begin(), cidades.end(), 0,
        [](int soma, const pair<string, int>& p) {
            return soma + p.second;
        }) / static_cast<double>(cidades.size());


    cout << "Cidades com população acima da média:" << endl;
    for (const auto& cidade : cidades) {
        if (cidade.second > mediaPopulacao) {
            cout << cidade.first << endl;
        }
    }


    auto cidadeMaisPopulosa = max_element(cidades.begin(), cidades.end(),
        [](const pair<string, int>& a, const pair<string, int>& b) {
            return a.second < b.second;
        });

    auto cidadeMenosPopulosa = min_element(cidades.begin(), cidades.end(),
        [](const pair<string, int>& a, const pair<string, int>& b) {
            return a.second < b.second;
        });

    cout << "\nCidade mais populosa: " << cidadeMaisPopulosa->first << endl;
    cout << "Cidade menos populosa: " << cidadeMenosPopulosa->first << endl;


    int populacaoParaRemover;
    cout << "\nDigite um valor de populacao para remover: ";
    cin >> populacaoParaRemover;


    for (auto it = cidades.begin(); it != cidades.end();) {
        if (it->second == populacaoParaRemover) {
            it = cidades.erase(it);
        }
        else {
            ++it;
        }
    }


    cout << "\nDicionário atualizado:" << endl;
    for (const auto& cidade : cidades) {
        cout << cidade.first << ": " << cidade.second << endl;
    }

    return 0;
}