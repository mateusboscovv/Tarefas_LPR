using System;
using System.Reflection.Metadata;

class Program
{
    static void Main()
    {
        int quantidade_par = 0;
        int quantidade_impar = 0;
        int auxiliar = 0;
        int tamanho = 10;

        int[] todosNum = new int[tamanho];
        int[] pares = new int[tamanho];
        int[] impares = new int[tamanho];

        Console.WriteLine("O programa necessita que você digite 10 números para o programa ser executado.\n");

        for(int i = 0; i < tamanho; i++)
        { 
            Console.WriteLine("Você digitou números");
            todosNum[i] = int.Parse(Console.ReadLine());
        }

        // os numeros digitados serão sepados em par e impar
        for(int i = 0; i < tamanho; i++)
        {
            if (todosNum[quantidade_par] %2 == 0)
            {

                pares[quantidade_par] = todosNum[quantidade_par];
                quantidade_par++;
            }

            else
            {
                impares[i] = todosNum[i];
                quantidade_impar = +1;
            }
        }

        Console.WriteLine("Quantidade de numeros pares: ");
        Console.WriteLine(quantidade_par);

        for (int i = 0; i < quantidade_par; i++)
        {
            auxiliar = (int)pares[i];
            Console.WriteLine("Numero par: ");
            Console.WriteLine(auxiliar);
        }

        /*
        for (int i = 0; i < quantidade_impar; i++)
        {
            
            Console.WriteLine("Os numeros pares são: ", (int)pares[i]);
            Console.WriteLine(pares[i]);

        }


        for (int i = 0; i < todosNum.Length; i++)
        {

            Console.WriteLine("Os numeros impar são: ", (int)impares[i]);

        }
        */


        /*foreach(int i in pares) 
        {
            Console.WriteLine(pares[i]);
        }
        foreach (int i in impares)
        {
            Console.WriteLine(impares[i]);
        }*/

    }
}
