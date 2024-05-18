using System;
using System.ComponentModel.Design;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {

            // OPERADORES COMPARATIVOS

            int a = 10;
            bool c1 = a < 10;
            bool c2 = a < 20;
            bool c3 = a > 10;
            bool c4 = a > 5;


            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");


            bool c5 = a <= 10;
            bool c6 = a >= 10;
            bool c7 = a == 10;
            bool c8 = a != 10;

            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            //OPERADORES LOGICOS - && E - || OU - ! NÃO

            bool c9 = 2 > 3 || 4 != 5; //true
            bool c10 = !(2 > 3) && 4 != 5; //true
            Console.WriteLine(c9);
            Console.WriteLine(c10);







        }
    }
}
