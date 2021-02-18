using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace ValoresRetangulo
{
    class Retangulo
    {
        public double Largura;
        public double Altura;


    public double Area()
        {
            return Largura * Altura;
        } 

    public double Perimetro()
        {
            return (Largura + Altura) * 2.0;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Altura * Altura + Largura * Largura);
        }

        
    }
    
}
