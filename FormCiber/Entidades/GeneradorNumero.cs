using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public static class GeneradorNumero
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
                        int index = GeneradorNumero.Generar(0, listado.Count);
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

    
    public static class Extension
    {
        public static DateTime RestarTiempo(this DateTime horaInicio)
        {
            horaInicio = horaInicio.AddDays(GeneradorNumero.Generar(-10, 0));
            horaInicio = horaInicio.AddHours(GeneradorNumero.Generar(-24, 0));
            horaInicio = horaInicio.AddMinutes(GeneradorNumero.Generar(-60, 0));
            horaInicio = horaInicio.AddSeconds(GeneradorNumero.Generar(-60, 0));
            return horaInicio;
        }

        public static DateTime AgregarTiempo(this DateTime horaInicio, bool esTelefono)
        {
            if(esTelefono) 
            {
                horaInicio = horaInicio.AddSeconds(GeneradorNumero.Generar(0, 5));
            }
            else
            {
                horaInicio = horaInicio.AddMinutes(GeneradorNumero.Generar(0, 6));
                horaInicio = horaInicio.AddSeconds(GeneradorNumero.Generar(0, 60));
            }
            return horaInicio;
        }
    }
}

