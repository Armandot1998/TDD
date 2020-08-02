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

			Heap heap = new Heap();
			int[] resultado = heap.heapSort(entrada);

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
    class Heap { 

		public int[] heapSort(int[] entrada)
		{
			int dimension = entrada.Length;

			DimensionMax(entrada);

			for (int i = dimension - 1; i >= 1; i--)
			{
				int tmp = entrada[i];
				entrada[i] = entrada[0];
				entrada[0] = tmp;
				dimension--;
				Contener(entrada, dimension, 0);
			}
			return entrada;
		}

		private void DimensionMax(int[] entrada)
		{
			int dimension = entrada.Length;

			for (int i = (dimension / 2) - 1; i >= 0; i--)
			{
				Contener(entrada, dimension, i);
			}
		}

		private static void Contener(int[] entrada, int dimension, int contenerPos)
		{
			if (HijoIzqPos(contenerPos) >= dimension)
			{
				return;
			}
			int HijoPosMax;
			bool IzqMax;

			if (HijoDerPos(contenerPos) >= dimension || entrada[HijoDerPos(contenerPos)].CompareTo(entrada[HijoIzqPos(contenerPos)]) < 0)
			{
				HijoPosMax = HijoIzqPos(contenerPos);
				IzqMax = true;
			}
			else
			{
				HijoPosMax = HijoDerPos(contenerPos);
				IzqMax = false;
			}

			if (entrada[HijoPosMax].CompareTo(entrada[contenerPos]) > 0)
			{
				//Intercambiar(entrada, contenerPos, HijoPosMax);
				int tmp = entrada[contenerPos];
				entrada[contenerPos] = entrada[HijoPosMax];
				entrada[HijoPosMax] = tmp;

				if (IzqMax)
				{
					Contener(entrada, dimension, HijoIzqPos(contenerPos));

				}
				else
				{
					Contener(entrada, dimension, HijoDerPos(contenerPos));
				}
			}

		}

		private static int HijoIzqPos(int PadrePos)
		{
			return (2 * (PadrePos + 1)) - 1;
		}

		private static int HijoDerPos(int PadrePos)
		{
			return 2 * (PadrePos + 1);
		}
	}
}