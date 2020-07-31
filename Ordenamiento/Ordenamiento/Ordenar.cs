using System;
using System.Collections.Generic;

namespace Ordenamiento
{
    public class Ordenar
    {
        public List<int> OrdenarAsc(int primero, int segundo, int tercero)
        {
            var resultado = new List<int>();

            if (primero < segundo
                && primero < tercero){
                resultado.Add(primero); // resultado[0] = primero
                if (segundo < tercero){
                    resultado.Add(segundo); // resultado[1] = segundo
                    resultado.Add(tercero); // resultado[2] = tercero
                }
                else{
                    resultado.Add(tercero); // resultado[1] = tercero
                    resultado.Add(segundo); // resultado[2] = segundo
                }
            }else{
                if (segundo < primero
                    && segundo < tercero){
                    resultado.Add(segundo); // resultado[0] = segundo
                    if (primero < tercero){
                        resultado.Add(primero); // resultado[1] = segundo
                        resultado.Add(tercero); // resultado[2] = tercero
                    }
                    else{
                        resultado.Add(tercero); // resultado[1] = tercero
                        resultado.Add(primero); // resultado[2] = primero
                    }
                    }else{
                    if (tercero < primero
                        && tercero < segundo){
                        resultado.Add(tercero); // resultado[0] = tercero
                        if (primero < segundo){
                            resultado.Add(primero); // resultado[1] = primero
                            resultado.Add(segundo);  // resultado[2] = segundo
                        }else{
                            resultado.Add(segundo); // resultado[1] = segundo
                            resultado.Add(primero); // resultado[2] = primero
                        }
                    }
                }
            }


            /* if(primero < segundo && primero < tercero)
            {
                resultado.Add(primero); resultado[0] = primero 

                if(segundo < tercero)
                {
                    resultado.Add(segundo); // resultado[1] = segundo
                    resultado.Add(tercero); // resultado[2] = tercero
                }
                else
                {
                    resultado.Add(tercero); // resultado[1] = tercero
                    resultado.Add(segundo); // resultado[2] = segundo
                }
            }
            else
            {
                if(segundo < primero && segundo < tercero)
                {
                    resultado.Add(segundo); // resultado[0] = segundo

                    if(primero < tercero)
                    {
                        resultado.Add(primero); // resultado[1] = primero
                        resultado.Add(tercero); // resultado[2] = tercero
                    }
                    else
                    {
                        resultado.Add(tercero); // resultado[1] = tercero
                        resultado.Add(primero); // resultado[2] = primero
                    }


                }
                else
                {
                    if(tercero < primero && tercero < segundo)
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
                            resultado.Add(primero); // resultado[2] = segundo
                        }
                    }
                }
            } */

            return resultado;
        }
    }
}