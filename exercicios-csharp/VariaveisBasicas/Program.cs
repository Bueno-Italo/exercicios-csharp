using System;
using System.Globalization;

namespace VariavelBasicas // Note: actual namespace depends on the project name.
{
    internal class Program //Classe programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("## Imprimindo o nome  ##");
            Console.WriteLine();

            Console.WriteLine("Escreva seu nome: ");
            string nome  = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(nome + " " + "Seja bem vindo!");

            Console.WriteLine("----------------------------");


            double x = 10.35784;
            int y = 32;
            char w = 'F';
            string z = "MAria";

            Console.WriteLine("Olá mundo!");
            Console.WriteLine("Bom dia");
            Console.WriteLine("Até mais");

            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));

            Console.WriteLine();
            Console.WriteLine("RESULTADO = " + x);
            Console.WriteLine("O valor de tgroco é " + x + " reais");
            Console.WriteLine("O valor de troco é " + x.ToString("F2") + " reias");

            Console.WriteLine();
            Console.WriteLine("A paciente " + z + "tem" + y + " anos e seu sexo é: " +w);



            Console.ReadLine();
        }
    }
}
