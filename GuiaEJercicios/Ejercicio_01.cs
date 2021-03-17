using GuiaEJercicios.PruebaSpace;
using System;
using System.Collections.Generic;
using System.Text;



namespace GuiaEJercicios
{
    public class Ejercicio_01
    {
        static void Main(string[] args)
        {
            /*
           Console.Title = "Ejercicio Nro 01"; // MUESTRA TITULO EN CONSOLA 
            
            int i;
            int numero, mayor, menor, acum = 0; 

            Console.WriteLine("ingrese un numeros:");
            numero = int.Parse(Console.ReadLine());

            mayor = numero;
            menor = numero;
            acum = numero;

            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("ingrese un numeros:");
                numero = int.Parse(Console.ReadLine()); 

                if (numero > mayor) 
                {
                    mayor = numero; 
                }
                else if (numero < menor)
                {
                    menor = numero; 
                }
                acum = acum + numero; // acum += numero;
            }

            // MUESTRA EL PROMEDIO 
            acum = acum / 5;
            Console.WriteLine("PROMEDIO DE NUMEROS: {0}", acum);

            // MUESTRA LA MAYOR 
            Console.WriteLine("NUMERO MAYOR: {0}", mayor);

            // MUESTRA LA MENOR 
            Console.WriteLine("NUMERO MENOR: {0}", menor);



            //Console.WriteLine("LISTA NUMEROS");

            //foreach (int aux in numero) 
            //{
            //    Console.WriteLine(aux); 
            //}

            Console.ReadKey();

            */
            // -----------------------------------------------
            /*
            Console.Title = "Ejercicio Nro 02";

            double numero, cuadrado, cubo; 
            Console.WriteLine("Ingrese un numero");
            numero = double.Parse(Console.ReadLine());

            if (numero != 0)
            {
                cuadrado = Math.Pow(numero, 2);
                cubo = Math.Pow(numero, 3);

                Console.WriteLine("Al cuadrado: {0}", cuadrado);
                Console.WriteLine("Al cubo: {0}", cubo);

            }
            else
            {
                Console.WriteLine("ERROR. ¡Reingresar numero!");
            }
            */
            // -----------------------------------------------
            /* Console.Title = "Ejercicio Nro 03";

             int numero,i,j;
             bool esPrimo; 
             Console.WriteLine("Ingrese un numero");
             numero = int.Parse(Console.ReadLine());

             for (i=1; i<=numero; i++) 
             {
                 esPrimo = true;                   // reseteo la variable (bandera) 
                 for (j=2; j<i; j++) 
                 {
                     if (i%j==0)
                     {
                         esPrimo = false;
                         break;
                     }
                 }

                 if (!esPrimo) 
                 {
                     continue; 
                 }

                 Console.WriteLine("Numeros primos: {0}",i);

             }

             */

            // -----------------------------------------------

            /* Console.Title = "Ejercicio Nro 05";

             int i, j, medio, numero, acum=0, acum2 = 0;
             Console.WriteLine("Ingrese un numero");
             numero = int.Parse(Console.ReadLine());


             for(i=1; i< numero; i++) 
             {
                 acum = acum + i;
             }

             medio = acum / 2;
             for (j = 1; j < numero; j++)
             {
                 //(medio - j) / 2;
                 acum2 = acum2 + j;

                 if (acum2 == medio) 
                 {
                     Console.WriteLine("Centro numerico: {0}", acum2);
                 }
             }*/




            // -----------------------------------------------
            /*  Console.Title = "Ejercicio Nro 06";

              int inicio, fin ,i; 
              Console.WriteLine("Ingrese año de inicio:");
              inicio = int.Parse(Console.ReadLine());

              Console.WriteLine("Ingrese año de fin:");
              fin = int.Parse(Console.ReadLine());

              for(i=inicio; i<fin; i++) 
              {
                  if (i%4 != 0 || (i % 100 == 0 && i %400 != 0)) //     (i%4 == 0 && (i % 100 == 0 && i %400 == 0))
                  {
                      continue; 
                  }
                  Console.WriteLine("Los años bisiestos: {0} ", i);
              }
             */
            // -----------------------------------------------
            /*  
               Console.Title = "Ejercicio Nro 07";

               int i;
               DateTime fechaIni = new DateTime();
               DateTime fechaAct = DateTime.Now;

               Console.WriteLine("Ingrese fecha de nacimiento(mm/dd/yyyy): ");
               fechaIni = Convert.ToDateTime(Console.ReadLine());

               Console.WriteLine("MOSTRAR {0}", fechaIni.ToString());

               Console.WriteLine("Cantidad de dias vividos:{0}", fechaAct.Subtract(fechaIni).Days);
               */
            // -----------------------------------------------
            /*
            Console.Title = "Ejercicio Nro 08";

            int valorHora;
            string nombre;
            int antiguedad;
            int cantidadHoras;
            int importeTotal;
            int totalNeto, Descuentos,i, cant;


            List<Empleado> Empleados = new List<Empleado>();

            Console.WriteLine("Ingrese cantidad de empleados a registrar:");
            cant = int.Parse(Console.ReadLine());

            for (i = 0; i < cant; i++)
            {
                Console.WriteLine("Ingrese valor por hora");
                valorHora = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese nombre");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese antiguedad");
                antiguedad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese cantidad por hora");
                cantidadHoras = int.Parse(Console.ReadLine());

                Empleado empleado = new Empleado(valorHora, nombre, antiguedad, cantidadHoras);
                Empleados.Add(empleado);
            }

            foreach (Empleado aux in Empleados)
            {

                Console.WriteLine("RECIBO EMPLEADO");
                Console.WriteLine("Nombre:"+ aux.nombre); // ("Nombre:{0}", aux.nombre);
                Console.WriteLine("Antiguedad: "+ aux.antiguedad);
                Console.WriteLine("Valor por hora: "+ aux.valorHora);

                importeTotal = (aux.valorHora * aux.cantidadHoras) + (aux.antiguedad * 150);
                Descuentos = (importeTotal * 13) / 100;
                totalNeto = importeTotal - Descuentos;

                Console.WriteLine("Total a cobrar en bruto: "+ importeTotal);
                Console.WriteLine("Total de descuentos: "+Descuentos);                            
                Console.WriteLine("Total en Neto: "+ totalNeto);     
                */
            // -----------------------------------------------
            /*
            Console.Title = "Ejercicio Nro 09";
            int altura;
            int incremento = 0, i;

            Console.WriteLine("Ingrese la altura de la piramide:");
            altura = int.Parse(Console.ReadLine());

            // Dibujo
            while (incremento < altura)
            {
                incremento++;
                for (i = 0; i < incremento; i++)
                {
                    Console.Write("*");
                }
                 Console.WriteLine("");
            }
            Console.ReadLine();*/


            // -----------------------------------------------
            /*      Console.Title = "Ejercicio Nro 10";

                     int altura;
                     int incremento = 0, i,j;

                     Console.WriteLine("Ingrese la altura de la piramide:");
                     altura = int.Parse(Console.ReadLine());

                     // Dibujo
                     while (incremento < altura)
                     {
                         incremento++;

                         for (j = altura-1; j >= incremento; j--)
                         {
                             Console.Write(" ");
                         }

                         for (i = 0; i < incremento*2-1; i++)
                         {
                             Console.Write("*");
                         }
                         Console.WriteLine("");
                     }
                     Console.ReadLine(); 


            */
            // -----------------------------------------------
            /*         Console.Title = "Ejercicio Nro 11";

                     int i, numero, promedio = 0; 

                     for (i=0; i<10; i++) 
                     {
                         Console.WriteLine("Ingrese diez numeros: ");
                         numero = int.Parse(Console.ReadLine());

                         Validacion.Validar(numero, -100, 100);

                         promedio = promedio + numero;
                     }

                     promedio = promedio / 10; 
                     Console.WriteLine("El promedio: "+ promedio);

                     */
            // -----------------------------------------------
            /*  Console.Title = "Ejercicio Nro 12";

              int entero, acum = 0;
              char c = 'S';

              while (c == 'S')
              {
                  Console.WriteLine("Bellaquita <3");
                  Console.WriteLine("Ingrese un numero entero:");
                  entero = int.Parse(Console.ReadLine());

                  acum = acum + entero;


                  Console.WriteLine("¿Continuar? (S/N):");      //(S/N) se debe ingresar en mayuscula porque no esta validado 
                  c = Convert.ToChar(Console.ReadLine());
                  ValidarRespuesta.ValidaS_N(c);

                  if (c != 'S')
                  {
                      Console.WriteLine("La suma de los numeros enteros es:" + acum);
                  }
                  */
            // -----------------------------------------------
            /*  Console.Title = "Ejercicio Nro 12";
              int num, n1;
              string cad,n2;

              Console.WriteLine("Ingrese un numero decimal:");
              num = int.Parse(Console.ReadLine());
              n2 = Conversor.DecimalBinario(num);
              Console.WriteLine("Decimal a binario:" + n2);


              Console.WriteLine("Ingrese un numero binario:");
              cad = Convert.ToString(Console.ReadLine());
              n1 = Conversor.BinarioDecimal(cad);
              Console.WriteLine("Binario a decimal:"+ n1);
              */
            // -----------------------------------------------
            /* Console.Title = "Ejercicio Nro 13";
             double cuadrado, triangulo, circulo, a,b,c;

             Console.WriteLine("Ingrese un numero para calcular el area del cuadrado:");
             cuadrado = Convert.ToDouble(Console.ReadLine());
             a = CalculoDeArea.CalcularCuadrado(cuadrado);

             Console.WriteLine("Ingrese un numero para calcular el area del triangulo:");
             triangulo = Convert.ToDouble(Console.ReadLine());
             b = CalculoDeArea.CalcularTriangulo(triangulo, triangulo);

             Console.WriteLine("Ingrese un numero para calcular el area del circulo:");
             circulo = Convert.ToDouble(Console.ReadLine());
             c = CalculoDeArea.CalcularCirculo(circulo);

             Console.WriteLine("El aerea del cuadrado es:"+ a);
             Console.WriteLine("El aerea del triangulo es:"+ b);
             Console.WriteLine("El aerea del circulo es:"+ c);
             */
            // -----------------------------------------------
            /*Console.Title = "Ejercicio Nro 15";

            int num1, num2, resultado;
            char operacion, c = 'S';

            while (c == 'S')
            {
                Console.WriteLine("Ingrese un numero:");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese un numero:");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese una operador:");
                operacion = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("¿Continuar? (S/N):");      //(S/N) se debe ingresar en mayuscula porque no esta validado 
                c = Convert.ToChar(Console.ReadLine());

                if (c != 'S')
                {
                    resultado = Calculadora.Calcular(num1, num2, operacion);

                    Console.WriteLine("El resultado de la operacion es: {0}", resultado);
                }
            }
            */

            // -----------------------------------------------
            /* Console.Title = "Ejercicio Nro 16";

             Alumno a1 = new Alumno();
             Alumno a2 = new Alumno();
             Alumno a3 = new Alumno();

             //CARGO CADA OBJETO
             a1.nombre = "Yamila";
             a1.apellido = "Dionicio";
             a1.legajo = 123;
             a1.Estudiar(3, 5);

             a2.nombre = "pepito";
             a2.apellido = "noel";
             a2.legajo = 456899;
             a2.Estudiar(8, 5);


             a3.nombre = "fulanito";
             a3.apellido = "koo";
             a3.legajo = 123;
             a3.Estudiar(9, 9);

             // MUESTRO 
             Console.WriteLine(a1.Mostrar());
             Console.WriteLine(a2.Mostrar());
             Console.WriteLine(a3.Mostrar());
             */

            // -----------------------------------------------
            /* Console.Title = "Ejercicio Nro 17";

             string dibujito1 = "";
             string dibujito2 = "";

             Bolígrafo b1 = new Bolígrafo(10, ConsoleColor.Blue);
            // Bolígrafo b2 = new Bolígrafo(5, ConsoleColor.Red);

             b1.Pintar(5, out dibujito1);
            // b2.Pintar(10, out dibujito2);

             Console.ForegroundColor = b1.GetColor();
            //  Console.ForegroundColor = b2.GetColor();

             Console.WriteLine("boligrafo 1:"+ dibujito1);
             Console.ResetColor();

            //  --------------------------------------------

             b1.Pintar(10, out dibujito1);
             // b2.Pintar(10, out dibujito2);

             Console.ForegroundColor = b1.GetColor();
             //  Console.ForegroundColor = b2.GetColor();

             Console.WriteLine("boligrafo 1:" + dibujito1);
             Console.ResetColor();

             //  --------------------------------------------

             b1.Pintar(3, out dibujito1);
             // b2.Pintar(10, out dibujito2);

             Console.ForegroundColor = b1.GetColor();
             //  Console.ForegroundColor = b2.GetColor();

             Console.WriteLine("boligrafo 1:" + dibujito1);
             Console.ResetColor();
             */
            // -----------------------------------------------
            Console.Title = "Ejercicio Nro 18";

            Sumador sum1 = new Sumador();
            Sumador sum2 = new Sumador(2);

            Console.WriteLine("ingrese un numero");
            long num1 = long.Parse(Console.ReadLine());

            Console.WriteLine("ingrese un numero");
            long num2 = long.Parse(Console.ReadLine());

            Console.WriteLine("la suma es:" + sum1.Sumar(num1, num2));
            Console.WriteLine("-------------------------------------------");


            // -----------------------------------------------

            Console.WriteLine("ingrese un string");
            string s1 = Console.ReadLine();

            Console.WriteLine("ingrese un string");
            string s2 = Console.ReadLine();

            Console.WriteLine("la concatenacion es:" + sum1.Sumar(s1, s2));
            Console.WriteLine("-------------------------------------------");

            // -----------------------------------------------

            Console.WriteLine("Suma de los obj: " + (sum1 + sum2));
            Console.WriteLine("Contienen la misma cantidad: " + (sum1 | sum2));
            Console.WriteLine("cantidad de sumas: " + (int)sum1);
            Console.WriteLine("cantidad de sumas: " + sum2);
           

        }
    }
}
