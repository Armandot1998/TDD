using System;
using System.Collections.Generic;
using System.Numerics;
namespace Test
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] entrada = new int[] { 1, 2, 4, 3, 0, -1, 5, 7, 8, 6 };
            int primero = 0;
            int ultimo = entrada.Length - 1;

            Quick quick = new Quick();
            int[] resultado = quick.quicksort(entrada, primero, ultimo);

            Console.WriteLine(resultado[0]);
            Console.WriteLine(resultado[1]);
            Console.WriteLine(resultado[2]);
            Console.WriteLine(resultado[3]);
            Console.WriteLine(resultado[4]);
            Console.WriteLine(resultado[5]);
            Console.WriteLine(resultado[6]);
            Console.WriteLine(resultado[7]);
            Console.WriteLine(resultado[8]);
            Console.WriteLine(resultado[9]);


        }
	}
    class Quick {
        public int[] quicksort(int[] vector, int primero, int ultimo)
        {  
            int central = (primero + ultimo) / 2;
            double pivote = vector[central];
            int i = primero;
            int j = ultimo;
            do
            {
                while (vector[i] < pivote) i++;
                while (vector[j] > pivote) j--;
                if (i <= j)
                {
                    int temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);
            if (primero < j)
            {
                quicksort(vector, primero, j);
            }
            if (i < ultimo)
            {
                quicksort(vector, i, ultimo);
            }
            return vector;
        }
    }
}