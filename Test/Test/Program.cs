using System;
using System.Collections.Generic;
using System.Numerics;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] entrada = { 1, 10, 6, 5, 2, 7, 4};

            int salto = entrada.Length / 2;

            while (salto >=1)
            {
                salto /= 2;
                for (int i = 0; i < entrada.Length-salto; i++)
                {
                    if (entrada[i] > entrada[i + salto])
                    {
                        int tmp = entrada[i + salto];
                        entrada[i + salto] = entrada[i];
                        entrada[i] = tmp;
                    }
                    for (int j = 0; j<=i; j++)
                    {
                        if(entrada[j] > entrada[j + salto])
                        {
                            int tmp = entrada[j+salto];
                            entrada[j + salto] = entrada[j];
                            entrada[j] = tmp;
                        }
                    }
                }
            }

            Console.WriteLine(entrada[0]);
            Console.WriteLine(entrada[1]);
            Console.WriteLine(entrada[2]);
            Console.WriteLine(entrada[3]);
            Console.WriteLine(entrada[4]);
            Console.WriteLine(entrada[5]);
            Console.WriteLine(entrada[6]);
        }
    }
}
