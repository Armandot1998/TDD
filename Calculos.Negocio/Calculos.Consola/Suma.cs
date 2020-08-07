using Calculos.Negocio;
using System;

namespace Calculos.Consola
{
    class Suma
    {
        static void Main(string[] args)
        {
            Calculadora calculos = new Calculadora();

            int numero = 8;

            int resultado = calculos.Factorial(numero);

            /*int num1 = 50;
            int num2 = 70;
            int resultado = calculos.Suma(num1, num2);
            */
            Console.WriteLine(resultado);
        }
    }
}