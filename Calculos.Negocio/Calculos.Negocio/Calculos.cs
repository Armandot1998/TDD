using System;

namespace Calculos.Negocio
{
    public class Calculadora
    {
        public int Suma(int primerNumero, int segundoNumero)
        {
            int resultado = primerNumero + segundoNumero;
            return resultado;
        }
        public int Factorial(int numero)
        {
            int resultado = 1;
            if(numero < 1)
            {
                resultado = 1;
            }
            else
            {
                for (int i = 1; i <= numero; i++)
                {
                    resultado = resultado * i;
                }
            }
            return resultado;
        }
    }
}

