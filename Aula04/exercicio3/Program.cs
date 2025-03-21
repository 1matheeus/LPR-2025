
Console.WriteLine("Bem-vindo ao RPG!");
Console.WriteLine("1 - Guerreiro");
Console.WriteLine("2 - Mago");
Console.WriteLine("3 - Arqueiro");
Console.WriteLine("Selecione sua classe: ");
int classe = int.Parse(Console.ReadLine());
switch(classe)
{
    case 1:
        Console.WriteLine("Você escolheu a classe Guerreiro.");
        Console.WriteLine("Suas habilidades são: Ataque Pesado, Defesa Total");
        break;
    case 2:
        Console.WriteLine("Você escolheu a classe Mago.");
        Console.WriteLine("Suas habilidades são: Bola de Fogo, Escudo de Gelo");
        break;
    case 3:
        Console.WriteLine("Você escolheu a classe Arqueiro.");
        Console.WriteLine("Suas habilidades são: Flecha Precisa, Disparo Triplo");
        break;
    default:
        Console.WriteLine("Classe inválida.");
        break;
}

