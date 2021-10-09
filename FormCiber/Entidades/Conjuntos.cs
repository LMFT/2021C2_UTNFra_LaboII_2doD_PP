using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generadores;

namespace Elementos
{
    internal static class Persona
    {
        private static string[] nombres = {"Lucas","Javier","Carolina", "Guadalupe", "Laura", "Maximiliano", "Bianca", "Violeta", "Martin",
                               "Facundo", "Diego", "Ezequiel", "Emanuel", "Alan", "Florencia" };
        private static string[] apellidos = { "Steinbrenner", "Fernandez", "Perez", "Gozalvez", "Martinez", "Scarsi", "Carrizo", "Gonzalez",
                                   "Albornoz", "Dotta", "Vietti", "Manriquez", "Cech", "Aspen", "Elbetti" };


        public static int Nombres 
        {
            get 
            { 
                return nombres.Length; 
            }   
        }
        public static int Apellidos
        {
            get
            {
                return apellidos.Length;
            }
        }

        internal static string ObtenerNombre(int index)
        {
            if(index>=0 && index < nombres.Length)
            {
                return nombres[index];
            }
            return String.Empty;
        }

        internal static string ObtenerApellido(int index)
        {
            if (index >= 0 && index < apellidos.Length)
            {
                return apellidos[index];
            }
            return String.Empty;
        }

    }

    internal static class Software
    {
        static List<string> software = new List<string> {"Office", "Ares", "ICQ", "Messenger",
            "Counter-Strike", "Diablo II", "MU Online", "Lineage II", "Age of Empires II", "GTA VIce CIty", "Starcraft" };

        public static string ObtenerSoftware()
        {
            return software[GeneradorNumero.Generar(0, software.Count)];
        }
    }

    internal static class Periferico
    {
        static List<string> perifericos = new List<string> { "Camara", "Auriculares", "Microfono" };

        public static string ObtenerPeriferico()
        {
            return perifericos[GeneradorNumero.Generar(0, perifericos.Count)];
        }
    }
}
