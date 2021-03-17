using System;
using System.Collections.Generic;
using System.Text;

namespace GuiaEJercicios
{
    public class Empleado
    {
        public int valorHora;
        public string nombre;
        public int antiguedad;
        public int cantidadHoras;

        public Empleado(int valorHora, string nombre, int antiguedad, int cantidadHoras)
        {
            this.valorHora = valorHora;
            this.nombre = nombre;
            this.antiguedad = antiguedad;
            this.cantidadHoras = cantidadHoras; 
        }
    }
}
