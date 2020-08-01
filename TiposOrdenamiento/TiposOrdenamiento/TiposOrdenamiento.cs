using System;
using System.Collections.Generic;

namespace TiposOrdenamiento
{
    public class TiposOrdenamiento
    {
        public List<int> OrdenarBusbuja(int[] entrada)
        {
            var resultado = new List<int>();

            for (int a = 0; a <= entrada.Length; a++)
            {
                for (int b = 0; b <= entrada.Length - 1; b++)
                {
                    if (entrada[b] > entrada[b + 1])
                    {
                        int tmp = entrada[b];
                        entrada[b] = entrada[b + 1];
                        entrada[b + 1] = tmp;
                    }
                }
            }
            for (int i = 0; i <= entrada.Length; i++)
            {
                resultado.Add(entrada[i]);
            }

            return resultado;
        }
    }
}
