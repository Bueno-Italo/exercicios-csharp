using System.Drawing;
using System.Globalization;

Console.WriteLine(" ##\n Funções Aritméticas! ##");

double x = 3.0;

double y = 4.0;

double z = -5.0;

double A, B, C;

A = Math.Pow(x, y);

B = Math.Pow(x, 2.0);

C = Math.Pow(5.0, 2.0);

Console.WriteLine(x + " Elevado a " + y + " = " + A);

Console.WriteLine(x + " Elevado ao quadrado = " + B);

Console.WriteLine("5 elevado ao quadrado = " + C);

A = Math.Abs(y);
B = Math.Abs(z);

Console.WriteLine("Valor absoluto de  " +y + " = " + A);
Console.WriteLine("Valor absoluto de " +z + " =  + B ");
Console.ReadLine();

Console.WriteLine("---------------------------------------");

//Fazer um programa para ler as medidas de base e altura de um retangulo. Em seguida, mostrar o valor da área, 
//perímetro e diagonal, com quatro casas decimais

Console.WriteLine(" ##\n Exercício Resolvido ##");

double b, a, area, perimetro, diagonal;

b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

area = b * a;
perimetro = 2 * b + 2 * a;
diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0));

Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("PRETIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

Console.ReadLine();