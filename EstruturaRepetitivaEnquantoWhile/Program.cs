using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Digite um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //variavel x guarda o número

            while (x >= 0.0)
            {
                double raiz = Math.Sqrt(x); // já pronta para calcular a raiz quadrada
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture)); //ToString imprime 3 casas apos virgula e o Culture
                Console.WriteLine("Digite outro número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Número negativo");

        }
    }
}