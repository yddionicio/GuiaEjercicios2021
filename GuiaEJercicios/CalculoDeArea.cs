using System;
using System.Collections.Generic;
using System.Text;

namespace GuiaEJercicios
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double c)
        {
            return c*c;                         // (a*a)
        }

        public static double CalcularTriangulo(double a, double b)
        {
            return (a * b) / 2;
        }

        public static double CalcularCirculo(double d) 
        {
            return (d * d)* 3.14;
        }
    }
}
