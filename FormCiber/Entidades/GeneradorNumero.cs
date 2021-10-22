using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    /// <summary>
    /// 
    /// </summary>
    public static class GeneradorNumero
    {
        
        private static Random rng;
        /// <summary>
        /// Inicializa el generador de numeros con un seed inicial igual al hash code de la hora actual
        /// </summary>
        static GeneradorNumero()
        {
            rng = new Random(DateTime.Now.GetHashCode());
        }
        /// <summary>
        /// Genera un numero aleatorio mayor o igual a min y menor a max
        /// </summary>
        /// <param name="min">Valor minimo del numero aleatorio(incluido)</param>
        /// <param name="max">Valor maximo del numero aleatorio(excluido)</param>
        /// <returns>Numero aleatorio cuyo valor se encuentra entre min y max</returns>
        public static int Generar(int min, int max)
        {
            return rng.Next(min, max);
        }
    }
}

