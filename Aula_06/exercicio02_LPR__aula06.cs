using System;
class Program {
    static void Main()
    {
        Random numAleatorio= new Random();
        int valorInteiro = numAleatorio.Next(1, 100);
        int numDigitado, cont = 0;

        do
        {
            Console.WriteLine("Digite um número inteiro para o chute");
            numDigitado = int.Parse(Console.ReadLine());

            cont++;

            if (numDigitado == valorInteiro)
            {
                Console.WriteLine("Tentativa finalizada, você acertou e seu número de tentativas foi: " + cont);

            }
            else if (numDigitado < valorInteiro)
            {
                Console.WriteLine("Chutou baixo, tente novamente");
            }
            else
            {
                Console.WriteLine("Chutou alto, tente novamente");
            }

        }
        while (numDigitado != valorInteiro); //1234
    }
}