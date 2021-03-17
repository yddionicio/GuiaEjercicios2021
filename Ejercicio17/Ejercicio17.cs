using Ejercicio17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17Practica
{
    class Ejercicio17
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 17";

            string dibujito1, dibujito2;
            
            //INSTANCIAMOS BOLIGRAFO
            Boligrafo b1 = new Boligrafo(100,ConsoleColor.Blue);
            Boligrafo b2 = new Boligrafo(50,ConsoleColor.Red);

            //LLAMAMOS AL METODO PINTAR
            b1.Pintar(12, out dibujito1);
            b2.Pintar(2, out dibujito2);

            //LLAMAMOS AL METODO RECARGAR
            b1.Recargar();
            b2.Recargar();

            //SEATEMOS EL COLOR
            Console.ForegroundColor = b1.GetColor();
            Console.ForegroundColor = b2.GetColor();

            // MOSTRAMOS 
            Console.WriteLine(dibujito1);
            Console.WriteLine(dibujito2);
            Console.ReadKey();
        }
    }
}
