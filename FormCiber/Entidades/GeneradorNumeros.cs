using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rng
{
    public static class GeneradorNumeros
    {
        private static Random rng = new Random();

        public static int Generar(int min, int max)
        {
            return rng.Next(min, max);
        }

        public static List<string> SeleccionAleatoria(List<string> listado, int cantidadElementos)
        {
            List<string> listadoFiltrado = new List<string>();
            string elemento;
            if (cantidadElementos == listado.Count)
            {
                listadoFiltrado = listado;
            }
            else
            {
                if (cantidadElementos < listado.Count)
                {
                    for (int i = 0; i < cantidadElementos; i++)
                    {
                        int index = GeneradorNumeros.Generar(0, listado.Count);
                        elemento = listado.ElementAt(index);
                        /*Si la lista no contiene el elemento, lo añado y continuo a la siguiente iteracion
                         De lo contrario decremento el iterador*/
                        if (!listadoFiltrado.Contains<string>(elemento))
                        {
                            listadoFiltrado.Add(elemento);
                            continue;
                        }
                        i--;
                    }
                }
            }
            return listadoFiltrado;
        }
    }
}
