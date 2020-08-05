
namespace TiposOrdenamiento
{
    public class OrdenamientoHeapInt
    {
		public int[] OrdenarHeapInt(int[] entrada)
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

	public class OrdenamientoHeapDouble
	{
		public double[] OrdenarHeapDouble(double[] entrada)
		{
			int dimension = entrada.Length;

			DimensionMax(entrada);

			for (int i = dimension - 1; i >= 1; i--)
			{
				double tmp = entrada[i];
				entrada[i] = entrada[0];
				entrada[0] = tmp;
				dimension--;
				Contener(entrada, dimension, 0);
			}
			return entrada;
		}

		private void DimensionMax(double[] entrada)
		{
			int dimension = entrada.Length;

			for (int i = (dimension / 2) - 1; i >= 0; i--)
			{
				Contener(entrada, dimension, i);
			}
		}

		private static void Contener(double[] entrada, int dimension, int contenerPos)
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
				double tmp = entrada[contenerPos];
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

