/*WHILE: Construa um algoritmo que calcule a
média aritmética de um conjunto de números
pares fornecidos pelo usuário. O usuário deve
fornecer primeiro a quantidade de números que
serão digitados, e em seguida, os números
considerados na média. O usuário pode digitar
números ímpares, que devem ser ignorados.
Por exemplo, no caso da tabela abaixo, o 5
informa que serão digitados 5 números (2 7 8 6
10), e para a média devem ser considerados
apenas os números pares (2, 8, 6 e 10)
ignorando o número 7 digitado.
*/

Console.WriteLine("Insira o número de elementos para calcular a média aritmética: ");
int n = int.Parse(Console.ReadLine()); //números a serem digitados
int i = 0; //quantidade de números digitados
int soma = 0;
int contador = 0;
while (i < n)
{
    Console.WriteLine("Insira um número: ");
    int num = int.Parse(Console.ReadLine());
    if (num % 2 == 0)
    {
        soma += num;
        contador++; //contador de números pares
    }
    i++;
}
double media = (double)soma / contador; 
Console.WriteLine($"A média aritmética dos números pares é: {media}");


