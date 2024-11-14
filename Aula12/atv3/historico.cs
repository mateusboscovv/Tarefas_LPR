using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escola
{
    public class Historico
    {
        public struct Aluno_t
        {
            public int matricula;
            public string nome;
            public double nota1;
            public double nota2;
            public double trab;

        }
        Aluno_t aluno;

        public double media(Aluno_t aluno)
        {
            double produto1 = aluno.nota1 * 2.5;
            double produto2 = aluno.nota2 * 2.5;
            double produto3 = aluno.trab * 2;

            double soma = produto1 + produto2 + produto3;
            double resultado = soma / 4.5;

            return resultado;
        }

        public void final(double resultado, Aluno_t aluno)
        {
            double media = 50;

            if (resultado > media)
            {
                Console.WriteLine("O(a) aluno(a): " + aluno.nome, "com matricula: " + aluno.matricula, "não ficará de final");
            }
            else
            {
                double notaCorte = media - resultado;
                Console.WriteLine("O(a) aluno(a): " + aluno.nome, "com matricula: " + aluno.matricula, "precisa de: " + notaCorte);
            }
        }
    }
}
