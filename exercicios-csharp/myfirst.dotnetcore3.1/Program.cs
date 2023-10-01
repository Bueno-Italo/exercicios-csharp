using System;
using System.Net.Mail;

namespace myfirst.dotnetcore3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProcessarIdade();
            Console.ReadKey();
        }

        public static void ProcessarIdade() 
        {
            int idade;

            Console.Write("informe uma idade: ");
            int.TryParse(Console.ReadLine(), out idade);

            if (idade < 18)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sem Permissão");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Permissão Concedida");
            }
        }

    }
}
