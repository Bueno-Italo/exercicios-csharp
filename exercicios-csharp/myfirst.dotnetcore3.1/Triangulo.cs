using System;

namespace myfirst.dotnetcore3._1
{
    public class Triangulo
    {
        public double A;
        public double B;
        public double C; 

        public double Area()
        {
            double p =(A+B+C) /2;
            double raiz = Math.Sqrt(p - A) * (p - B) * (p - C);
            return raiz;
        }
    }
}
