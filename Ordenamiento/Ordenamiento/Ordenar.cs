using System;
using System.Collections.Generic;

namespace Ordenamiento
{
    public class Ordenar
    {
        public List<int> OrdenarAsc(int primero, int segundo, int tercero)
        {
            var resultado = new List<int>();
          
            if(primero < segundo && primero < tercero)
            {
                resultado.Add(primero);

                if(segundo < tercero)
                {
                    resultado.Add(segundo);
                    resultado.Add(tercero);
                }
                else
                {
                    resultado.Add(tercero);
                    resultado.Add(segundo);
                }
            }
            else
            {
                if(segundo < primero && segundo < tercero)
                {
                    resultado.Add(segundo);

                    if(primero < tercero)
                    {
                        resultado.Add(primero);
                        resultado.Add(tercero);
                    }


                }
                else
                {
                    if(tercero < primero && tercero < segundo)
                    {
                        resultado.Add(tercero);

                        if (primero < segundo)
                        {
                            resultado.Add(primero);
                            resultado.Add(segundo);
                        }
                        else
                        {
                            resultado.Add(segundo);
                            resultado.Add(primero);
                        }
                    }
                }
            }

            return resultado;
        }
    }
}