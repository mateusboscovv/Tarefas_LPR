#include <iostream>
#include <vector>
#include <algorithm>
#include <cstdlib>
#include <ctime>
#include <unordered_map>
#include <unordered_set>
using namespace std;

int main() {
    srand(time(nullptr));
    vector<int> numeros;

    for (int i = 0; i < 100; ++i) {
        numeros.push_back(rand() % 100 + 1);
    }

    sort(numeros.begin(), numeros.end());


    cout << "Lista ordenada:" << endl;
    for (int num : numeros) {
        cout << num << " ";
    }
    cout << endl;


    numeros.erase(std::remove_if(numeros.begin(), numeros.end(), [](int num) {
        return num % 2 == 0;
        }), numeros.end());

    cout << "Lista sem numeros pares:" << endl;
    for (int num : numeros) {
        cout << num << " ";
    }
    cout << endl;

    unordered_map<int, int> contador;
    unordered_set<int> repetidos;

    for (int num : numeros) {
        contador[num]++;
        if (contador[num] > 1) {
            repetidos.insert(num);
        }
    }

    if (!repetidos.empty()) {
        std::cout << "Numeros repetidos:" << endl;
        for (int num : repetidos) {
            cout << num << " ";
        }
        cout << endl;
    }
    else {
        cout << "Não tem numeros repetidos." << endl;
    }

    return 0;
}