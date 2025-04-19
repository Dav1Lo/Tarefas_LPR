#include <iostream>
using namespace std;

void mediaPares() {
    int quantidade, numero, soma = 0, contador = 0;
    cout << "Digite a quantidade de numeros: ";
    cin >> quantidade;
    for (int i = 0; i < quantidade; i++) {
        cout << "Digite um numero: ";
        cin >> numero;
        if (numero % 2 == 0) {
            soma += numero;
            contador++;
        }
    }
    if (contador > 0)
        cout << "Media dos numeros pares: " << (float)soma / contador;
    else
        cout << "Nenhum numero par foi digitado.";
}

void somaImparesMultiplosDe3() {
    int soma = 0;
    for (int i = 50; i <= 500; i++) {
        if (i % 2 != 0 && i % 3 == 0) soma += i;
    }
    cout << "Soma dos impares multiplos de 3 entre 50 e 500: " << soma;
}

void somaDigitosQuadrado() {
    int numero;
    cout << "Digite um numero: ";
    cin >> numero;
    int quadrado = numero * numero, soma = 0;
    while (quadrado > 0) {
        soma += quadrado % 10;
        quadrado /= 10;
    }
    cout << "Soma dos digitos do quadrado: " << soma;
}

int main() {
    int opcao;
    
    cout << "1 - Media de numeros pares" << endl;
    cout << "2 - Soma dos impares multiplos de 3" << endl;
    cout << "3 - Soma dos digitos do quadrado" << endl;
    cout << "Escolha uma opcao: ";
    cin >> opcao;

    switch (opcao) {
        case 1:
            mediaPares();
            break;
        case 2:
            somaImparesMultiplosDe3();
            break;
        case 3:
            somaDigitosQuadrado();
            break;
        default:
            cout << "Opcao invalida!";
    }
    
    return 0;
}

