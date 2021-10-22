using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    /// <summary>
    /// Provee métodos de extension para 
    /// </summary>
    public static class Extension
    {
        /// <summary>
        /// Resta una cantidad aleatoria de tiempo, hasta un maximo de 10 dias
        /// </summary>
        /// <param name="hora">Hora a la cual restar tiempo</param>
        /// <returns>Nueva hora y fecha, modificadas de forma aleatoria</returns>
        public static DateTime RestarTiempo(this DateTime hora)
        {
            hora = hora.AddDays(GeneradorNumero.Generar(-10, 0));
            hora = hora.AddHours(GeneradorNumero.Generar(-24, 0));
            hora = hora.AddMinutes(GeneradorNumero.Generar(-60, 0));
            hora = hora.AddSeconds(GeneradorNumero.Generar(-60, 0));
            return hora;
        }
        /// <summary>
        /// Añade una cantidad aleatoria de tiempo al DateTime recibido como parametro, hasta un total de 7 minutos
        /// </summary>
        /// <param name="hora">Hora a la cual añadir tiempo</param>
        /// <param name="esTelefono">Variable que verifica si el dispositivo del cliente es de tipo Telefono</param>
        /// <returns></returns>
        public static DateTime AgregarTiempo(this DateTime hora, bool esTelefono)
        {
            /*Es necesario verificar el tipo de dispositivo dado que en caso de una llamada telefonica, el tiempo aleatorio a generar
             es radicalmente distinto al de una llamada (una computadora podria utilizarse por algunas horas, mientras que lo normal
            en llamadas es que dure algunos minutos*/
            if (esTelefono)
            {
                hora = hora.AddSeconds(GeneradorNumero.Generar(0, 5));
            }
            else
            {
                hora = hora.AddMinutes(GeneradorNumero.Generar(0, 6));
                hora = hora.AddSeconds(GeneradorNumero.Generar(0, 60));
            }
            return hora;
        }
    }
}
