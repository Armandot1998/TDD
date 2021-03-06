﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Ordenador
{
    public class Ordenador
    {
         public List<int> OrdenarAsc(int primero, int segundo, int tercero)
        {
            var resultado = new List<int>();

            if (primero < segundo && primero < tercero)
            {
                resultado.Add(primero);

                if (segundo < tercero)
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
                if (segundo < primero && segundo < tercero)
                {
                    resultado.Add(segundo);

                    if (primero < tercero)
                    {
                        resultado.Add(primero);
                        resultado.Add(tercero);
                    }


                }
                else
                {
                    if (tercero < primero && tercero < segundo)
                    {
                        resultado.Add(tercero); // resultado[0] = tercero

                        if (primero < segundo)
                        {
                            resultado.Add(primero); // resultado[1] = primero
                            resultado.Add(segundo); // resultado[2] = segundo
                        }
                        else
                        {
                            resultado.Add(segundo); // resultado[1] = segundo
                            resultado.Add(primero); // resultado[1] = primero
                        }
                    }
                }
            }

            return resultado;



        }
    }
}
         