using System;
using System.Collections.Generic;
using System.Text;

namespace GuiaEJercicios.Geometría
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public float Area()
        {     
            return vertice1.GetX() * vertice2.GetY(); 
        }
        public float Perimetro() 

        {
            return ((vertice1.GetX() + vertice2.GetY())*2);   
        }

        public Rectangulo(Punto vertice1, Punto vertice3)
        {            
            Math.Abs(Math.Sqrt(Math.Pow(vertice1.GetX() - vertice3.GetX(), 2) + Math.Pow(vertice1.GetY() - vertice3.GetY(), 2)));           
        }   
    }
}
