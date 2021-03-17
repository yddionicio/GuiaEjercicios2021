using System;
using System.Collections.Generic;
using System.Text;

namespace GuiaEJercicios
{
    public class Conversor
    {
        public static string DecimalBinario(int numero)      //Convierte un número de entero a binario.
        {
            return Convert.ToString(numero,2);
        }

        public static int BinarioDecimal(string c)          //Convierte un binario a un numero entero.
        {
            return Convert.ToInt32(c,2);
        }

    }
}
