using System;

namespace myfirst.dotnetcore3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Escrevanome();
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

        public static void ProcessarSalario()
        {
            decimal salarioAtual;
            Console.WriteLine("informe seu salário: ");
            decimal.TryParse(Console.ReadLine(), out salarioAtual);
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Seu salario atual é: {salarioAtual}");
            
            Console.ResetColor();
            Console.WriteLine("Estamos calculando seu salário... ");
            
            var novoSalario = CalcularSalario(salarioAtual);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Seu novo salario atual é : {novoSalario}");
        }

        public static decimal CalcularSalario(decimal salarioAtual) 
        {
            decimal novoSalario;
            if(salarioAtual < 1700) 
            {
                novoSalario = salarioAtual + 300;
            }
            else
            {
                novoSalario = salarioAtual + 200;

            }

            return novoSalario;
        }
        public static void Escrevanome()

        {
            string nomePessoa;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Informe seu Nome: ");
            nomePessoa=Console.ReadLine();

            string sobreNome;
            Console.WriteLine("Informe seu sobrenome: ");
            sobreNome=Console.ReadLine();

            string textoConcatenado = nomePessoa + " " + sobreNome;
            Console.Write($"nome e sobrenome é:  {textoConcatenado}");




            


        }


    }
}
