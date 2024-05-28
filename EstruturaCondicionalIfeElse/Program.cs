using System;
using System.IO.Pipes;
using System.Security.AccessControl;


namespace Estrutura
{
    class Aprender
    {
        static void Main()
        {
            /*
            Console.WriteLine("Vamos decobrir se o seu número é Par ou Ímpar");
            Console.WriteLine("Digite um número");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Seu número é PAR");
            }
            else
            {
                Console.WriteLine("Seu número e IMPAR");
            }
            

            Console.WriteLine("==============================================================================================================");
            
            Console.WriteLine("VAMOS SABER SE PELO SEU ANO DE NASCIMENTO VOCE PODE VOTAR?");

            Console.WriteLine("DIGITE SEU ANO DE NASCIMENTO");
            int anonasc = int.Parse(Console.ReadLine());
            int idade = 2024 - anonasc;

            if (idade > 18)
            {
                Console.WriteLine("Você  pode votar pois tem " + idade);

            }

           else
            {
                Console.WriteLine("Você não pode votar pois é menor de idade, voce tem " + idade); Console.WriteLine("anos");
            }
            

            //CLASSIFICAÇÃO DE NOTA

            Console.WriteLine("Qual foi sua nota?");
            int nota = int.Parse(Console.ReadLine());

            if (nota >=90 )
            {
                Console.WriteLine("Excelente");
            }
            else if (nota >=80 )
            {
                Console.WriteLine("bom");
            }

            else if (nota >=70)
            {
                Console.WriteLine("Regular");
            }

            else if (nota >=60)
            {
                Console.WriteLine("Suficiente");
            }
            */

            Console.WriteLine("Digite a nota");
            double nota = double.Parse(Console.ReadLine());

            if (nota >= 7)
            {
                Console.WriteLine("Você está aprovado");
            }

            else if (nota < 7 && nota >=5)
            {
                Console.WriteLine(" Você está de recuperação");
            }

            else if (nota < 5)
            {
                Console.WriteLine("Reprovado");
            }


        }
    }
}