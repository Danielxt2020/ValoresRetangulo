using System;
using System.Globalization;

namespace ValoresRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo lados = new Retangulo();

            Console.WriteLine("Entre a Largura e altura do retângulo:");
            lados.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            lados.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Area:" + lados.Area());
            Console.WriteLine("Perimetro:" + lados.Perimetro());
            Console.WriteLine("Perimetro:" + lados.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
