﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GuiaEJercicios.Geometría
{
    public class Punto
    {
        private int x;
        private int y;


        public int GetX()
        {
            return this.x;    
        }

        public int GetY()
        {
            return this.y;
        }

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
