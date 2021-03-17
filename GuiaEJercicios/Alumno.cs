using System;
using System.Collections.Generic;
using System.Text;

namespace GuiaEJercicios
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;
        Random rdm = new Random();

        public void CalcularFinal() 
        {
            if (this.nota1 > 4 && this.nota2 > 4)
            {
                 this.notaFinal = rdm.Next(0, 10);
            }
            else 
            {
                this.notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public string Mostrar()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DATOS DEL ALUMNO:");
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Apellido:" + this.apellido);
            sb.AppendLine("Legajo:" + this.legajo);
            sb.Append("Nota final:");
            this.CalcularFinal();

            if (this.notaFinal != -1)
            {               
                sb.AppendLine(this.notaFinal.ToString());
            }
            else 
            {
                 sb.AppendLine("Alumno desaprobado x gilastrum");
                 sb.AppendLine("ia stoy arto");
            }

            return sb.ToString();
        }
    }
}


