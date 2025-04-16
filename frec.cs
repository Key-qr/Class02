#include <iostream>
using namespace std;

int main() {
    int n;
    cout << "Ingresa la cantidad de elementos: ";
    cin >> n;

    int arreglo[n];

    // Leer elementos
    for(int i = 0; i < n; i++) {
        cout << "Elemento " << i+1 << ": ";
        cin >> arreglo[i];
    }

    // Calcular frecuencia
    cout << "\nFrecuencia de los elementos:\n";
    for(int i = 0; i < n; i++) {
        int contador = 1;
        bool yaContado = false;

        // Verifica si ya fue contado antes
        for(int j = 0; j < i; j++) {
            if(arreglo[i] == arreglo[j]) {
                yaContado = true;
                break;
            }
        }

        // Si no fue contado, cuenta su frecuencia
        if(!yaContado) {
            for(int j = i+1; j < n; j++) {
                if(arreglo[i] == arreglo[j]) {
                    contador++;
                }
            }
            cout << arreglo[i] << " aparece " << contador << " veces.\n";
        }
    }

    return 0;
}
