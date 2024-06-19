using System;
using System.Globalization;

class Program
{
    public struct Produto
    {
        public string nome;
        public int codigo;
        public float preco;
        public int quantidade;
    }

    static void Main()
    {
        //Igualei igual a zero, pois para somar dessa forma: total += preco. É necessário que a variável inicie como zero para se igualar em algo.
        float totalDePreco = 0;
        int totalDeQuantidade = 0;


        Produto[] estoque = new Produto[3];
        
        Console.WriteLine("---- Estoque ----\n");

        //Este  for "roda" as perguntas ao usuário durante três vezes.
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Digite o nome do produto que deseja estocar");
            estoque[i].nome = Console.ReadLine();

            Console.WriteLine("Digite o código do produto que deseja estocar");
            estoque[i].codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço do produto que deseja estocar");
            estoque[i].preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade do produto que deseja estocar");
            estoque[i].quantidade = int.Parse(Console.ReadLine());

            totalDeQuantidade += estoque[i].quantidade;

            totalDePreco += estoque[i].preco * estoque[i].quantidade; 
        }

        Console.WriteLine($"O preço dos três produtos é: {totalDePreco} e a quantidade de produto é: {totalDeQuantidade} ");


    }
}
