using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generadores
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

    public static class GeneradorFecha
    {
        private static int dia;
        private static int mes;
        private static int anio;
        private static int hora;
        private static int minuto;
        private static int segundo;

        public static string Generar()
        {
            anio = 2021;
            mes = GeneradorNumero.Generar(0, 13);
            do
            {
                dia = GeneradorNumero.Generar(0, 32);
            } while ((mes == 2 && dia > 28) || ((mes == 4 || mes == 6 || mes == 9 || mes == 11) && dia > 30));
            hora = GeneradorNumero.Generar(9, 21);
            minuto = GeneradorNumero.Generar(0, 61);
            segundo = GeneradorNumero.Generar(0, 61);
            return $"{dia}/{mes}/{anio} {hora}:{minuto}:{segundo}";
        }

        public static string Generar(DateTime horaInicio)
        {
            hora = horaInicio.Hour;
            minuto = horaInicio.Minute +  GeneradorNumero.Generar(0, 5);
            if(minuto >= 60)
            {
                minuto -= 60;
                hora++;
            }
            segundo = horaInicio.Second + GeneradorNumero.Generar(0, 61);
            if(segundo >= 60)
            {
                segundo -= 60;
                minuto++;
            }
            return $"{horaInicio.Day}/{horaInicio.Month}/{horaInicio.Year} {hora}:{minuto}:{segundo}";
        }

    }
}
