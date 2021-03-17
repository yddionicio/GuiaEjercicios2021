using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometría;

namespace PruebaGeometria
{
    class Ejercicio18
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 18";

            //INSTANCIAMOS PUNTOS
            Punto p1 = new Punto(10,3); 
            Punto p2 = new Punto(2,7);
            Punto p3 = new Punto(4,4);
            Punto p4 = new Punto(1,6);
            
            //INSTANCIAMOS RECTANGULOS
            Rectangulo r1 = new Rectangulo(p1, p3);
            Rectangulo r2 = new Rectangulo(p2, p4);

            //MOSTRAMOS LOS DATOS DE RECTANGULO
            Console.WriteLine(Mostrar(r1));
            Console.WriteLine(Mostrar(r2));
            Console.ReadKey();

        }
        public static string Mostrar(Rectangulo r)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DATOS DE RECTANGULO");
            sb.AppendLine("Area: "+ r.GetArea);
            sb.AppendLine("Perimetro: "+ r.GetPerimetro);

            return sb.ToString();
        }

    }
}


namespace Geometría
{
    public class Punto
    {
        private int x;
        private int y;

        public int GetX
        {
            get
            {         
                return this.x;
            }
        }
        public int GetY
        {
            get
            {
                return this.y;
            }
        }
        public Punto(int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }
    }


    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public float GetArea
        {
            get
            {
                int ancho = Math.Abs(vertice1.GetX - vertice3.GetX); // CALCULAMOS LA BASE
                int alto = Math.Abs(vertice1.GetY - vertice3.GetY); // CALCULAMOS LA ALTURA
                return ancho * alto;
            }
        }
        public float GetPerimetro
        {
            get
            {
                int ancho = Math.Abs(vertice1.GetX - vertice3.GetX); // CALCULAMOS LA BASE
                int alto = Math.Abs(vertice1.GetY - vertice3.GetY); // CALCULAMOS LA ALTURA
                return (ancho + alto) * 2;
            }
        }
        public float Area()
        {
           return GetArea;
        }
        public float Perimetro()
        {
            return GetPerimetro;
        }
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(vertice1.GetX, vertice3.GetY);
            this.vertice4 = new Punto(vertice3.GetX, vertice1.GetY);
        }
    }
}
