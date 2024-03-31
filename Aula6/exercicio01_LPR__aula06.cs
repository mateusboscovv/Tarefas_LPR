using System;

class Program
{
    static void Main()
    {
        int cont = 0;
        double soma = 0, qtd = 0;

        Console.WriteLine("Digite a quantidade de números a serem digitados: ");
        int quantNum = int.Parse(Console.ReadLine());

        while (cont<quantNum)
        {

            Console.WriteLine("Digite um número par");
            int numAnalisado = int.Parse(Console.ReadLine());

            if(numAnalisado%2 == 0 )
            {
                soma += numAnalisado;
                qtd++;
            }
            cont++;
        }
        double media;
        media= soma/qtd;

        Console.WriteLine("A média dos números digitados é: " +  media);
    }
}
