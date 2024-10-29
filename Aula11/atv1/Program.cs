namespace leitorGeometrico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo obj; //crio uma variável ue acessa a classe;
            obj = new Retangulo(); //instancio largura na classe retãngulo permitindo-a que referencie objetos dentro da classe;
            Console.WriteLine("Digite a largura do rentângulo");
            obj.Largura = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do retângulo");
            obj.Altura = Double.Parse(Console.ReadLine());
            obj.calcArea();
            obj.calcPerimetro();
            double area = obj.calcArea();
            double perimetro = obj.calcPerimetro();
            Console.WriteLine("A área do retângulo é: " + area);
            Console.WriteLine("A área do retângulo é: " + perimetro);

        }

    }
}
