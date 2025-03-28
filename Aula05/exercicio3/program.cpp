/* FOR: Elabore um algoritmo que calcule a
soma de todos os números ímpares
múltiplos de 3 que se encontrem no
conjunto dos números de 50 a 500    */

#include <iostream>
using namespace std;

int main()
{
    int acumulador = 0;
    for( int i = 50; i <= 500; i++ )
    {
        if( i % 2 != 0 && i % 3 == 0 )
        {
            acumulador += i;
        }
    }
    cout << "A soma dos números ímpares múltiplos de 3 entre 50 e 500 é: " << acumulador << endl;
}