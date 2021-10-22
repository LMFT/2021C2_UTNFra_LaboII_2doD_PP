using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    /// <summary>
    /// Contiene métodos para trabajar con colecciones generica
    /// </summary>
    public static class Coleccion
    {
        /// <summary>
        /// Muestra todos los elementos de una lista de strings
        /// </summary>
        /// <param name="lista">Listado a mostrar</param>
        /// <returns>Un string que contiene cada elemento de un listado</returns>
        public static string MostrarLista(List<string> lista)
        {
            StringBuilder str = new StringBuilder("\n");
            foreach(string s in lista)
            {
                str.AppendLine(s);
            }
            return str.ToString();
        }
        /// <summary>
        /// Muestra todos los elementos de un diccionario del tipo <string,string>
        /// </summary>
        /// <param name="diccionario">Diccionario a mostrar</param>
        /// <returns>Un string que contiene cada elemento de un diccionario</returns>
        public static string MostrarDiccionario(Dictionary<string, string> diccionario)
        {
            StringBuilder str = new StringBuilder();
            foreach(KeyValuePair<string, string> k in diccionario)
            {
                str.AppendLine($"{k.Key}: {k.Value}");
            }
            return str.ToString();
        }

        

    }
}
