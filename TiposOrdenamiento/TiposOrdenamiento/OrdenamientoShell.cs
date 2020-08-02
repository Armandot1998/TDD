
using System;

namespace TiposOrdenamiento
{
    public class OrdenamientoShell
    {
        public int[] OrdenarShellInt(int[] entrada)
        {
            int salto = entrada.Length / 2;

            while (salto >= 1)
            {
                salto /= 2;
                for (int i = 0; i < entrada.Length - salto; i++)
                {
                    if (entrada[i] > entrada[i + salto])
                    {
                        int tmp = entrada[i + salto];
                        entrada[i + salto] = entrada[i];
                        entrada[i] = tmp;
                    }
                    for (int j = 0; j <= i; j++)
                    {
                        if (entrada[j] > entrada[j + salto])
                        {
                            int tmp = entrada[j + salto];
                            entrada[j + salto] = entrada[j];
                            entrada[j] = tmp;
                        }
                    }
                }
            }
            return entrada;

        }

        public double[] OrdenarShellDouble(double[] entrada)
        {
            int salto = entrada.Length / 2;

            while (salto >= 1)
            {
                salto /= 2;
                for (int i = 0; i < entrada.Length - salto; i++)
                {
                    if (entrada[i] > entrada[i + salto])
                    {
                        double tmp = entrada[i + salto];
                        entrada[i + salto] = entrada[i];
                        entrada[i] = tmp;
                    }
                    for (int j = 0; j <= i; j++)
                    {
                        if (entrada[j] > entrada[j + salto])
                        {
                            double tmp = entrada[j + salto];
                            entrada[j + salto] = entrada[j];
                            entrada[j] = tmp;
                        }
                    }
                }
            }
            return entrada;

        }
    }
}
