using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite algum número inteiro");
        int numero = int.Parse(Console.ReadLine());

        if (numero%2 == 0) 
        {
            Console.Write($"O número digitado {numero} é par");
        }

        else
        {
            Console.Write($"O número digitado {numero} é ímpar");
        }
    }
}
