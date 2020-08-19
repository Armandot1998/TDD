using System;

namespace DataDrivenUnitTest
{
    internal class Calculadora
    {
        internal int Suma(int number1, int number2)
        {
            return number1 + number2;
        }

        internal int Factorial(int numero)
        {
            int resultado = 1;
            if (numero < 1)
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