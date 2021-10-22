using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace Elementos
{
    /// <summary>
    /// Contiene vectores de strings que contienen nombres y apellidos para generar personas
    /// </summary>
    internal static class Persona
    {
        private static string[] nombres = {"Lucas","Javier","Carolina", "Guadalupe", "Laura", "Maximiliano", "Bianca", "Violeta", "Martin",
                               "Facundo", "Diego", "Ezequiel", "Emanuel", "Alan", "Florencia" };
        private static string[] apellidos = { "Steinbrenner", "Fernandez", "Perez", "Gozalvez", "Martinez", "Scarsi", "Carrizo", "Gonzalez",
                                   "Albornoz", "Dotta", "Vietti", "Manriquez", "Cech", "Aspen", "Elbetti" };

        /// <summary>
        /// Retorna la cantidad de nombres contenida en el array nombres
        /// </summary>
        public static int Nombres 
        {
            get 
            { 
                return nombres.Length; 
            }   
        }
        /// <summary>
        /// Retorna la cantidad de apellidos contenida en el array apellidos
        /// </summary>
        public static int Apellidos
        {
            get
            {
                return apellidos.Length;
            }
        }
        /// <summary>
        /// Obtiene el nombre contenido en el array de acuerdo al indice recibido
        /// </summary>
        /// <param name="index">Indice del nombre a obtener</param>
        /// <returns>El nombre contenido en el índice recibido como parámetro, o un string vacio si el indice no se encuentra
        /// dentro de los limites del array</returns>
        internal static string ObtenerNombre(int index)
        {
            if(index>=0 && index < nombres.Length)
            {
                return nombres[index];
            }
            return String.Empty;
        }
        /// <summary>
        /// Obtiene el apellido contenido en el array de acuerdo al indice recibido
        /// </summary>
        /// <param name="index">Indice del apellido a obtener</param>
        /// <returns>El apellido contenido en el índice recibido como parámetro, o un string vacio si el indice no se encuentra
        /// dentro de los limites del array</returns>
        internal static string ObtenerApellido(int index)
        {
            if (index >= 0 && index < apellidos.Length)
            {
                return apellidos[index];
            }
            return String.Empty;
        }

    }
    /// <summary>
    /// Contiene un listado de software y juegos para generar una necesidad de un cliente
    /// </summary>
    internal static class Software
    {
        static List<string> software = new List<string> {"Office", "Ares", "ICQ", "Messenger",
            "Counter Strike", "Diablo II", "MU Online", "Lineage II", "Age of Empires II", "GTA VIce CIty", "Starcraft" };
        /// <summary>
        /// Obtiene un elemento del listado de forma aleatoria
        /// </summary>
        /// <returns>Elemento selecionado aleatoriamente</returns>
        public static string ObtenerSoftware()
        {
            return software[Utilidades.GeneradorNumero.Generar(0, software.Count)];
        }
    }
    /// <summary>
    /// Contiene un listado de perifericos para generar una necesidad de un cliente
    /// </summary>
    internal static class Periferico
    {
        static List<string> perifericos = new List<string> { "Camara", "Auriculares", "Microfono" };
        /// <summary>
        /// Obtiene un periferico del listado de forma aleatoria
        /// </summary>
        /// <returns>Periferico selecionado aleatoriamente</returns>
        public static string ObtenerPeriferico()
        {
            return perifericos[Utilidades.GeneradorNumero.Generar(0, perifericos.Count)];
        }
    }
}
