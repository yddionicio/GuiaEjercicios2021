using System;
using System.Collections.Generic;
using System.Text;

namespace GuiaEJercicios
{
    public class Calculadora
    {
        public static int Calcular(int n1, int  n2, char oper) 
        {
            switch(oper) 
            {
                case '+':
                    return n1 + n2;
                    
                case '-':
                    return n1 - n2;
                   
                case '*':
                    return n1 * n2;
                    
                case '/':
                    return n1 / n2;

                default:
                    return 0;
            }
        }

        private static bool Validar(int n2) 
        {
            return n2 != 0;
        }
    }
}
