﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Ejercicio13
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 13";

            // DECIMAL A BINARIO
            int num;
            Console.WriteLine("Ingrese un numero entero: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Format("El binario del numero {0} es {1}", num, Conversor.DecimalBinario(num)));
            Console.ReadKey();

            //BINARIO A DECIMAL
            //Console.WriteLine("Ingrese un numero binario: ");
            //string binario = Console.ReadLine();

            //Console.WriteLine(string.Format("El numero entero del binario {0} es {1}", binario, Conversor.BinarioDecimal(binario)));
            //Console.ReadKey();

        }
    }
}
