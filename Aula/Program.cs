using System;
using System.Runtime.Serialization;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            string nome = "Andréia Dias";
            string sobrenome = "Ferreira";
            int n1nasc = 1975;
            int n2anoatual = 2024;
            int n3idade = (n1nasc-n2anoatual);



            Console.WriteLine(nome);
            Console.WriteLine(sobrenome);
            Console.WriteLine(n3idade);
            

        }
    }
}