using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leitor.fonteDeDados;

namespace leitor
{
    public class fonteDeDados
    {
        public struct Func_t
        {
            public string nome;
            public float salario;
        }
        Func_t var_funcionario;


        public float calculoSalarial(Func_t var_funcionario)
        {
            float part = 0;
            float total = 0;

            part = var_funcionario.salario / 100;

            Console.WriteLine("O(a) funcionário(a): " + var_funcionario.nome, "tem um salário de: " + var_funcionario.salario);


            if (var_funcionario.salario <= 2000)
            {
                total = (part * 10) + var_funcionario.salario;
            }

            else if (var_funcionario.salario <= 3000)
            {
                total = (part * 15) + var_funcionario.salario;
            }

            else
            {
                total = (part * 20) + var_funcionario.salario;
            }

            return total;
        }

        public string get_var_nome()
        {

            return var_funcionario.nome;

        }
        public void set_var_funcionario_nome(Func_t dados_funcionario_nome)
        {

            var_funcionario = dados_funcionario_nome;

        }

        public float get_var_salario()
        {

            return var_funcionario.salario;

        }
        public void set_var_funcionario(Func_t dados_funcionario)
        {

            var_funcionario = dados_funcionario;

        }


    }


}
