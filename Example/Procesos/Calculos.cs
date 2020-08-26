using Example;
using System;

namespace Procesos
{
    class Calculos
    {
        static void Main(string[] args)
        {
            Calculos calculadora = new Calculos();

            calculadora.primerNumero = 70;
            calculadora.segundoNumero = 50;

            int resultado = calculadora.suma(10, 40);
            Console.WriteLine(resultado);
        }
    }
}
