﻿Console.WriteLine("Digite um número inteiro para saber se ele é par ou ímpar:");
int numero = int.Parse(Console.ReadLine());

if(numero % 2 == 0)
{
    Console.WriteLine("O número é par.");
}
else
{
    Console.WriteLine("O número", numero, " é ímpar.");
}