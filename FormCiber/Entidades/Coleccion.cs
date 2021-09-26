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
            string str = new string("\n");
            foreach(string s in lista)
            {
                str += $"{s}\n";
            }
            return str;
        }
    }
}
