/*  ESCOLHA A MELHOR ESTRUTURA DE
REPETIÇÃO: Solicite ao usuário para inserir
um número e calcule a soma dos dígitos do
quadrado desse número. Por exemplo, se o
número fornecido for 123, calcule 123² =
15129 e então a soma dos seus dígitos: 1 +
5 + 1 + 2 + 9 = 18.     */
#include <iostream>
using namespace std;

int main()
{
    int numero, soma = 0;
    cout << "Digite um número: ";
    cin >> numero;
    int quadrado = numero * numero;
    while( quadrado > 0 )
    {
        soma += quadrado % 10;
        quadrado /= 10;
    }
    cout << "A soma dos dígitos do quadrado de " << numero << " é: " << soma << endl;
}