using System;
using System.Collections.Generic;
using System.Text;

namespace GuiaEJercicios.PruebaSpace
{
    public class Bolígrafo
    {
        private ConsoleColor color;
        private short tinta;
        public const short cantidadTintaMaxima = 100;

        public Bolígrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetTinta()
        {
            return tinta;
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            int i;
            dibujo = "";

            if (tinta == 0)
            {
                return false;
            }

            for (i = 0; i < gasto && i < tinta; i++)
            {
                dibujo += "*";
            }

            SetTinta((short)-gasto);  // negamos gasto para que sea un negativo, asi cuando entra al set lo resta 
            return true;
        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        private void SetTinta(short tinta)
        {
            short suma = (short)(this.tinta + tinta);

            if (suma < 0)
            {
                this.tinta = 0;
            }
            else if (suma > cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }
            else
            {
                this.tinta = suma;
            }

        }

    }
}
