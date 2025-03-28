/*DO WHILE: Construa um algoritmo de adivinhação
de números. Com as linhas abaixo, o algoritmo
gerará um número inteiro aleatório de 1a 100:
(C#)
Random numAleatorio = new Random();
int valorInteiro = numAleatorio.Next(1,100);
(C++)
random_device numAleatorio ;
uniform_int_distribution<> distribuicao(1,100);
int valorInteiro = distribuicao(numAleatorio);
O seu trabalho é elaborar um algoritmo em que o
usuário possa digitar números no console até
acertar o número inteiro aleatório valorInteiro, de 1 a
100. A cada chute, o programa deve responder com
“chutou alto”, “chutou baixo” ou “acertou”. Após
acertar, deve ser mostrado quantas tentativas foram
usadas para descobrir o número. */

Console.WriteLine("Jogo de adivinhação de números!");
Random numAleatorio = new Random();
int valorInteiro = numAleatorio.Next(1,100);
int qntchutes = 0;

do while (true)
{
    Console.WriteLine("Insira um número entre 0 e 100: ");
    int num = int.Parse(Console.ReadLine());
    qntchutes++;
    if (num > valorInteiro)
    {
        Console.WriteLine("Chutou alto!");
    }
    else if (num < valorInteiro )
    {
        Console.WriteLine("Chutou baixo!");
    }
    else
    {
        Console.WriteLine("Acertou em ", qntchutes, " tentativas!");
        break;
    }
}
