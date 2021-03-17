using System;
using System.Collections.Generic;
using System.Text;

namespace GuiaEJercicios
{
    public class Validacion
    {
        public int valor;
        public int min;
        public int max;

        public static bool Validar(int valor, int min, int max)
        {
            return valor > min && valor < max;
        }
    }
}



