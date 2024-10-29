using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leitorGeometrico
{
    internal class Retangulo
    {
        public double Altura;
        public double Largura;

        public double calcArea()
        {
            double area = Altura * Largura;
            return area;
        }

        public double calcPerimetro()
        {
            double perimetro = (2*Altura)+(2*Largura);
            return perimetro;

        }
    }
}
