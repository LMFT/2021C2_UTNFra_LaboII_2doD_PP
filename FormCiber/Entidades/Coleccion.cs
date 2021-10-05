using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    public static class Coleccion
    {
        public static string ObtenerElementosLista(List<string> lista)
        {
            StringBuilder str = new StringBuilder("\n");
            foreach(string s in lista)
            {
                str.AppendLine(s);
            }
            return str.ToString();
        }

        public static string ObtenerElementosDiccionario(Dictionary<string, string> diccionario)
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
