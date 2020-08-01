using System;
using System.Collections.Generic;

namespace TiposOrdenamiento
{
    public class TiposOrdenamiento
    {
        public int[] OrdenarBusbuja(int[] entrada)
        {

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
            return entrada;
        }
    }
}
