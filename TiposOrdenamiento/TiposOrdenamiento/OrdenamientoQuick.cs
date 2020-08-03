using System;
using System.Collections.Generic;
using System.Text;

namespace TiposOrdenamiento
{
    public class OrdenamientoQuickInt
    {
        public int[] OrdenarQuick(int[] vector, int primero, int ultimo)
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
                OrdenarQuick(vector, primero, j);
            }
            if (i < ultimo)
            {
                OrdenarQuick(vector, i, ultimo);
            }
            return vector;
        }
    }

    public class OrdenamientoQuickDouble
    {
        public double[] OrdenarQuick(double[] vector, int primero, int ultimo)
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
                    double temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);
            if (primero < j)
            {
                OrdenarQuick(vector, primero, j);
            }
            if (i < ultimo)
            {
                OrdenarQuick(vector, i, ultimo);
            }
            return vector;
        }
    }
}
