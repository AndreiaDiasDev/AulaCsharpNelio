using System;

class Estudar
{
    static void Main()
    {
        Console.WriteLine("Vamos calcular o IMC");
        
        Console.WriteLine("Digite o seu peso");
        double peso = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua altura");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);

        Console.WriteLine("Seu IMC é " +  imc.ToString("F2"));

    }
}
