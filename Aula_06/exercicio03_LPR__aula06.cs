using System; 
class Program
{
    static void Main()
    {
        int soma = 0; 

        for (int i = 50; i <= 500; i++)  
        {
            if (i % 2 != 0 && i % 3 == 0)
            {
                soma +=i;


            }
        }
        Console.Write("A soma do intervalo dos números de 50 a 500 de seus números ímpares múltiplos de 3 resulta em: " + soma);
    }
}