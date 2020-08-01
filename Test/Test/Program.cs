using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] entrada = {3, 3, 5, 2, 1, 6 };
            int rango = entrada.Length -1; 

            for (int a = 0; a < entrada.Length; a++)
            {
                for (int b = 0; b < entrada.Length - 1; b++)
                {
                    if (entrada[b] > entrada[b + 1])
                    {
                        int tmp = entrada[b];
                        entrada[b] = entrada[b + 1];
                        entrada[b + 1] = tmp;
                    }
                }
            }

            Console.WriteLine(entrada[0]);
            Console.WriteLine(entrada[1]);
            Console.WriteLine(entrada[2]);
            Console.WriteLine(entrada[3]);
            Console.WriteLine(entrada[4]);
            Console.WriteLine(entrada[5]);
        }
    }
}
