using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos
{
    internal static class Elemento
    {
        private static List<string> nombres = new List<string>{ "Carolina", "Javier", "Marcelo", "Marcos", "Juan", "Gonzalo", "Mauricio", "Estefania", "Carla", "Milena"};
        private static List<string> apellidos = new List<string>{ "Ramirez", "Perez", "Fernandez", "Tapia", "Gonzalez", "Alonso", "Steinbrenner"};
        private static List<string> software = new List<string> { "Office", "Messenger", "ICQ", "Ares" };
        private static List<string> perifericos = new List<string> { "Cámara", "Auriculares", "Micrófono" };
        private static List<string> juegos = new List<string> { "Counter-Strike", "Diablo II", "MU Online", 
                                                                "Lineage II", "Age of Empires II" };

        public static int Nombres 
        {
            get 
            { 
                return nombres.Count; 
            }   
        }
        public static int Apellidos
        {
            get
            {
                return apellidos.Count;
            }
        }
        public static int Software
        {
            get
            {
                return software.Count;
            }
        }
        public static int Perifericos
        {
            get
            {
                return perifericos.Count;
            }
        }
        public static int Juegos
        {
            get
            {
                return juegos.Count;
            }
        }

        internal static string ObtenerNombre(int index)
        {
            if(index>=0 && index < nombres.Count)
            {
                return nombres[index];
            }
            return String.Empty;
        }

        internal static string ObtenerApellido(int index)
        {
            if (index >= 0 && index < apellidos.Count)
            {
                return apellidos[index];
            }
            return String.Empty;
        }

        internal static string ObtenerSoftware(int index)
        {
            if (index >= 0 && index < software.Count)
            {
                return software[index];
            }
            return String.Empty;
        }

        internal static string ObtenerPeriferico(int index)
        {
            if (index >= 0 && index < perifericos.Count)
            {
                return perifericos[index];
            }
            return String.Empty;
        }

        internal static string ObtenerJuego(int index)
        {
            if (index >= 0 && index < juegos.Count)
            {
                return juegos[index];
            }
            return String.Empty;
        }
    }
}
