using System;

namespace myfirst.dotnetcore3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EstruturaCondicional();
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
            string dia;
            Console.WriteLine("Informe o dia do seu nascimento: ");
            dia = Console.ReadLine();

            string mes;
            Console.WriteLine("Informe o mes do seu nascimento: ");
            mes = Console.ReadLine();

            Console.WriteLine("Informe o do seu nascimento: ");
            int ano_nascimento = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe o ano do atual: ");
            int ano_atual = Int32.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            var resultado = CalculoIdade(ano_atual, ano_nascimento);
            Console.WriteLine("\nA idade em anos é: " + resultado);

        }

        public static int CalculoIdade(int anoAtual, int anoNascimento)
        {
            var idade = 0;

            idade = anoAtual - anoNascimento;

            return idade;
        }

        public static void Exercicios()
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = b * b - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(delta);
            Console.WriteLine(x1);

            Console.WriteLine("Produtos: " + produto1 + ", cujo o preço é: $ " + preco1);
            Console.WriteLine(produto2 + ", cujo preco é: $" + preco2);

            Console.WriteLine("Registro: " + idade + " anos de idade, " + "código " + codigo + " e genero: " + genero);
        }

        public static void EntradadeDados()
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            string s = Console.ReadLine();

            string[] v = s.Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine("voce digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

        public static void ExerciciodeFixacao()

        {
            Console.WriteLine("Escreva um valor: ");
            Console.ReadLine();
            int valor1 = 10;
            Console.WriteLine("Escreva outro valor: ");
            Console.ReadLine();
            int valor2 = 30;

            Console.WriteLine("A soma dos valores são: ");
            int soma = valor1 + valor2;
            Console.WriteLine(soma);

        }


        public static void ExerciciodeFixacao2()

        {
            Console.WriteLine("Entre com o seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua cada? ");
            int preco1 = int.Parse( Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine());
        }

        public static void EstruturaCondicional()
        {
            Console.WriteLine("Entre com um numero inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Impar!");
            }
        }

    }
}
