using System;

class Estudar
{
    static void Main()
    {
        //CÁLCULO DO IMC

         Console.WriteLine("Vamos calcular o IMC");

         Console.WriteLine("Digite o seu peso");
         double peso = double.Parse(Console.ReadLine());

         Console.WriteLine("Digite sua altura");
         double altura = double.Parse(Console.ReadLine());

         double imc = peso / (altura * altura);

         Console.WriteLine("Seu IMC é " +  imc.ToString("F2"));

        Console.WriteLine("=========================================================================================================");

        
        //CÁLCULO DA MÉDIA
        Console.WriteLine("VAMOS CALCULAR A MÉDIA");
        
        Console.WriteLine("Digite a nota1");
        int nota1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota2");
        int nota2 = int.Parse(Console.ReadLine());

        int media = (nota1 +  nota2) / 2;

        Console.WriteLine("Sua média é " + media);

        Console.WriteLine("==================================================================================================================");


        //CONVERTENDO CELSIUS EM FAHRENHEIT
        Console.WriteLine("CONVERTER TEMPERATURA EM GRAU CELSIUS PARA FAHRENHEIT");

        Console.WriteLine("DIGITE UMA TEMPERATURA");
        int temperatura = int.Parse(Console.ReadLine());

        int converte = (temperatura * 9/5) + 32;

        Console.WriteLine("FOI CONVERTIDO FAHREHEIT E O NÚMERO É " + converte);

        Console.WriteLine("==================================================================================================================");


        Console.WriteLine("CALCULAR A GORJETA");

        Console.WriteLine("Digite o valor total da conta");
        double vconta = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o percentual de gorjeta para garçom");
        double percgorjeta = double.Parse(Console.ReadLine());

        double tgorjeta = vconta * (percgorjeta / 100);
        double tgeral = vconta + tgorjeta;
        

        Console.WriteLine(" A gorjeta do garçom é R$ "  + tgorjeta);
        Console.WriteLine(" O valor total é de R$ " + tgeral);



        





    }
}
