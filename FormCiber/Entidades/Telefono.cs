using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;
namespace Entidades
{

    public class Telefono : Dispositivo
    {
        private string marca;
        private TipoTelefono tipo;
        private static int ultimoId = 1;
        private Llamada llamada;
        public enum TipoTelefono
        {
            Disco,
            Teclado
        }
        public Telefono(string id, string marca, TipoTelefono tipo) : base(id, 1)
        {
            this.marca = marca;
            this.tipo = tipo;
        }

        public Llamada Llamada
        {
            get
            {
                return llamada;
            }
            set
            {
                if (value is not null)
                {
                    llamada = value;
                }
            }
        }
        /// <summary>
        /// Genera un ID autoincremental para  la instancia actual de telefono
        /// </summary>
        /// <returns>Nuevo ID generado en formato string</returns>
        private static string GenerarId()
        {
            string str = new string(string.Format("T{0:00}", ultimoId));
            ultimoId++;
            return str;
        }
        /// <summary>
        /// Instancia y hardcodea multiples telefonos y los añade al listado recibido como parametro;
        /// </summary>
        /// <param name="lista">Listado de dispositivos al cual añadir los telefonos</param>
        internal static void HardcodearTelefonos(List<Dispositivo> lista)
        {
            string[] marca = { "Panasonic", "Telecom", "Alcatel", "T&T", "Entel" };
            TipoTelefono[] tipo = { TipoTelefono.Teclado, TipoTelefono.Teclado, TipoTelefono.Teclado, TipoTelefono.Teclado,
                                    TipoTelefono.Disco, };
            if (lista is not null)
            {
                for (int i = 0; i < 5; i++)
                {
                    Telefono t = new Telefono(GenerarId(), marca[i], tipo[i]);
                    lista.Add(t);
                }
            }
        }
        /// <summary>
        /// Muestra los datos de la instancia de Telefono 
        /// </summary>
        /// <returns>Datos del telefono en formato string</returns>
        public override string MostrarDispositivo()
        {
            StringBuilder telefonoStr = new StringBuilder();

            telefonoStr.AppendLine($"ID: {Id}");
            telefonoStr.AppendLine($"Marca: {marca}");
            telefonoStr.AppendLine($"Tipo de telefono: {tipo}");
            telefonoStr.AppendLine($"Estado: {Estado}");
            return telefonoStr.ToString();
        }

    }       
}
