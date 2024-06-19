using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("==== RPG ====");
        Console.WriteLine("Criação de peronagem");

        Console.WriteLine("Digite o nome da sua personagem: ");
        string persona = Console.ReadLine();

        Console.WriteLine("==== CLASSES ====");

        Console.WriteLine($"Escolha a classe da personagem {persona}\n 1. Guerreira: Ataque pesado, Defesa total\n 2. Mago: Bola de fogo, Escudo de gelo\n 3. Arqueira: Flecha Precisa, Disparo triplo");
        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Console.WriteLine($"A personagem {persona} é um Gerreira de ataque pesado e defesa total");
                break;
            case 2:
                Console.WriteLine($"A personagem {persona} é um Mago com bolas de fogo e escudo de gelo");
                break;
            case 3:
                Console.WriteLine($"A personagem {persona} é uma Arqueira deflecha precisa e disparo triplo");
                break;

            default:
                Console.WriteLine($"Opção inválida, escolha uma classe para {persona} de acordo com as opções disponíveis, tente novamente!");
                break;
        }
    }
}
