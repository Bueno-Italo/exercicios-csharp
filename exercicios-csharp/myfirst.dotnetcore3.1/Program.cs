using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Xml.Schema;

namespace myfirst.dotnetcore3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculoIdadePessoa();
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
            if (salarioAtual < 1700)
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
            nomePessoa = Console.ReadLine();

            string sobreNome;
            Console.WriteLine("Informe seu sobrenome: ");
            sobreNome = Console.ReadLine();

            string textoConcatenado = nomePessoa + " " + sobreNome;
            Console.Write($"nome e sobrenome é:  {textoConcatenado}");
        }

        public static void CalculoIdadePessoa()



        {
            decimal dia;
            Console.WriteLine("Informe o dia do seu nascimento: ");



            int mes;
            Console.WriteLine("Informe o mes do seu nascimento: ");
            


            int ano_nascimento = Int32.Parse(Console.ReadLine());
            Console.Write("Informe o ano atual: ");
            

            int ano_atual = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Informe o ano do seu nascimento: ");
            ano_nascimento += Int32.Parse(Console.ReadLine());

            int idade_anos = ano_atual - ano_nascimento;
            Console.WriteLine("\nA idade em anos é: " + idade_anos);


            
            

             
        }

        

    }
}
