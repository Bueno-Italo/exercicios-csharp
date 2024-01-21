using System.Drawing;

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