using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
class Program
{
    static string nomeAdd; /// <duvidas>
                           /// CS8618	O campo não anulável 'nomeAdd' precisa conter um valor não nulo ao sair do construtor. Considere declarar o campo como anulável.
    // Unica solução ocorrida foi colocar interrogação no string 
    /// </duvidas>
    static int escolhaMenu, escolhaQuantNome;
    static List<string> nomes = new();
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Digite a opção desejada:\n 1.Adicionar nomes\n 2.Exibir\n 3.Sair");
            escolhaMenu = int.Parse(Console.ReadLine());

            switch (escolhaMenu)
            {
                case 1:
                    AdicionaNomes();
                    break;
                case 2:
                    ExibeNomes(nomeAdd);
                    break;
                case 3:
                    return; // Sai do programa
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
            //criar funçções a partir da escolha do Switch e o resto
        }
    }
    static void AdicionaNomes()
    {
        Console.WriteLine("Digite digite quantos nomes você deseja adicionar à lista: ");
        escolhaQuantNome = int.Parse(Console.ReadLine());

        for (int n = 0; n <= escolhaQuantNome; n++)
        {
            Console.WriteLine("Digite o nome que você deseja adicionar à lista: ");
            nomeAdd = Console.ReadLine();

            nomes.Add(nomeAdd);
        }


    }

    static void ExibeNomes(string nomeAdd)
    {
        Console.WriteLine("Os nomes inseridos são: ");

        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
           // Console.WriteLine(ContadorDeLetras(nomeAdd));
            /*
                         Console.WriteLine("Os nomes inseridos são: ", nome);  pq não posso fazer desta forma
             */
        }
    }

    static void Ordena(string nomeAdd, int escolhaQuantNome)
    {
        //enquanto a minha lista não estiver vazia irei percorre-la 
        //um forach para 
        for(int i = 0; i <= escolhaQuantNome; i++)
        {
            //percorro a lista usando o .Length
            //analiso quantos caracteres cada um tem 
            //adicionar em uma nova lista e remover quem tem os menores caracteres 

        }
        // NOVA LÓGICA DE PROGRAMAÇÃO ----------------
        /*
          verifico varrendo a lista quem tem menor quantidade de caracter, quem tiver uma quantidade menor sai da lista e vai para uma nova para ser impresso
          verifico novamente até o nome da lista acabar
          quando um nome com uma quantidade de caracteres grande acaba, o loop de busca inicia novamente e vai para uma nova lista em uma nova linha 
         */
        }
    
}
