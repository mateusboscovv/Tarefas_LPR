using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, int> pessoas = new Dictionary<string, int>
        {
            { "Ana", 25 },
            { "Carlos", 40 },
            { "Maria", 30 },
            { "João", 20 },
            { "Paula", 35 },
            { "Lucas", 50 }
        };
        double mediaIdade = pessoas.Values.Average();


        var acimaDaMedia = pessoas.Where(p => p.Value > mediaIdade).Select(p => p.Key).ToList();
        Console.WriteLine("Pessoas com idade acima da média:");
        foreach (var nome in acimaDaMedia)
        {
            Console.WriteLine(nome);
        }

        var pessoaMaisVelha = pessoas.OrderByDescending(p => p.Value).First();
        var pessoaMaisNova = pessoas.OrderBy(p => p.Value).First();
        Console.WriteLine($"\nPessoa mais velha: {pessoaMaisVelha.Key}");
        Console.WriteLine($"Pessoa mais nova: {pessoaMaisNova.Key}");


        Console.WriteLine("\nDigite um valor de idade para remover:");
        int idadeParaRemover = int.Parse(Console.ReadLine());


        var pessoasAtualizadas = pessoas.Where(p => p.Value != idadeParaRemover).ToDictionary(p => p.Key, p => p.Value);


        Console.WriteLine("\nDicionário atualizado:");
        foreach (var pessoa in pessoasAtualizadas)
        {
            Console.WriteLine($"{pessoa.Key}: {pessoa.Value}");
        }
    }
}