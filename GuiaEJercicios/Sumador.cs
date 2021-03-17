using System;
using System.Collections.Generic;
using System.Text;

namespace GuiaEJercicios
{
    public class Sumador
    {
        private int cantidadSumas;

        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        public static implicit operator string(Sumador s)         // este lo agregamos porque fue de prueba 
        {
            return s.cantidadSumas.ToString();
        }


        public static bool operator |(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas == s2.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0)
        {
        }

        public long Sumar(long a, long b)
        {
            cantidadSumas += 1;
            return (a + b);
        }

        public string Sumar(string a, string b)
        {
            cantidadSumas += 1;
            return string.Concat(a, b);
        }

    }
}




