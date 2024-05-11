using System;
using System.Globalization;
using System.IO.Pipes;
using System.Runtime.Serialization;


namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //ESTUDO DE VARIAVEIS

            string nome = "Andréia Dias"; 
            string sobrenome = "Ferreira";
            int n1nasc = 1975;
            int n2anoatual = 2024;
            int n3idade = (n1nasc-n2anoatual);
            char genero = 'F';
            bool gostadehomente = false;
            float n4 = 4.5f;
            double n5 = 10.358789;
            Console.WriteLine("======================================================================");

            //ESTUDO DE IMPRESSAO DAS VARIAVEIS NA TELA

            Console.WriteLine(nome);
            Console.WriteLine(sobrenome);
            Console.WriteLine(n3idade);
            Console.WriteLine(genero);
            Console.WriteLine(gostadehomente);
            Console.WriteLine(n4);
            Console.WriteLine(n5.ToString("F2"));//COMANDO ARREDONDA AS CASAS DECIMAIS APOS A VIRGULA F2 DUAS CASAS F4 4 CASAS
            Console.WriteLine("======================================================================");

            //ESTUDO DE IMPRESSAO DIRETA NA TELA - Write(quebra linha) e Writeline (não quebra linha)

            Console.Write("Bom dia");
            Console.WriteLine("Boa tarde");
            Console.WriteLine("Boa noite");
            Console.WriteLine("======================================================================");

            //ESTUDO DE PLACEHOLDER
            Console.WriteLine("{0} tem {1} e é do genero{2} ", nome, n3idade, genero);
            //ESTUDO DE INTERPOLAÇÃO
            Console.WriteLine($"{nome} tem {n3idade}");
            //ESTUDO DE CONCATENAÇÃO
            Console.WriteLine(nome + " TEM " + n3idade);
            Console.WriteLine("======================================================================");

            //EXERCÍCIO DE FIXAÇÃO

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade1 = 30;
            int codigo1 = 5290;
            char genero5 = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos");
            Console.WriteLine("{0} cujo preço é R$ {1}", produto1, preco1.ToString("F2"));
            Console.WriteLine("Registro {0} de idade, código {1} e gênero: {2}", idade1, codigo1, genero5);
            Console.WriteLine("Medida com oito casas decimais:{0}", medida);
            Console.WriteLine("Arrendondado com oito casas decimais:{0}", medida.ToString("F3"));
            Console.WriteLine(" Separador decimal " + medida.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("======================================================================");

            string nnome = "Andréia";
            string sobrenome6 = "Dias";
            int salario = 30;
            int ferias = 30;
            int total = salario + ferias;
            double medidaapto = 65.987654;

            Console.WriteLine(nnome + sobrenome6);
            Console.WriteLine("Meu salário de férias será: " + total);
            Console.WriteLine("Compro apartamento com a medida de  " + medidaapto.ToString ("F2"));
            Console.WriteLine("Compro apartamento com a medida de  " + medidaapto.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}