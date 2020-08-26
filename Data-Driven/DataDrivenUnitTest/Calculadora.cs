using System;

namespace DataDrivenUnitTest
{
    internal class Calculadora
    {
        internal int SumarDosNumeros(int number1, int number2)
        {
            return number1 + number2;
        }

        internal int Factorial(int numero ) 
        {
            int resultado = 1;
            if (numero < 1)
                return resultado;

            for (int i = 1; i <= numero; i++)
                resultado *= i;
            return resultado;
        }

        internal uint FactorialRecursivo(uint numero)
        {
            return numero == 0 ? 1 : numero * FactorialRecursivo(numero - 1);
        }
    }
}