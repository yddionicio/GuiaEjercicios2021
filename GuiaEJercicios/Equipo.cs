using System;
using System.Collections.Generic;
using System.Text;

namespace GuiaEJercicios
{
    public class Equipo
    {

        private short cantidadDeJugarodes;
        private List<Jugador> jugadores = new List<Jugador>();
        private string nombre;

        private Equipo() 
        {
        }
        private Equipo(short cantidad, string nombre) 
        {
        }

        public static bool operator +(Equipo e, Jugador j) 
        {
        }


    }
}
