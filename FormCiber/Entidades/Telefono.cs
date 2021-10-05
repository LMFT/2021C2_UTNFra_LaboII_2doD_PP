using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneradorNumeros;
namespace Entidades
{

    public class Telefono : Dispositivo
    {
        private string marca;
        private TipoTelefono tipo;
        private static int ultimoId;
        private Llamada llamada;
        public enum TipoTelefono
        {
            Disco,
            Teclado
        }
        public Telefono(string id,string marca, TipoTelefono tipo) : base(id)
        {
            this.marca = marca;
            this.tipo = tipo;
        }

        internal Llamada Llamada
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

        private static string GenerarId()
        {
            return String.Format("T{0;00}", ++ultimoId);
        }

        internal static void HardcodearTelefonos(List<Dispositivo> lista)
        {
            string[] marca = { "Panasonic", "Telecom", "Alcatel", "T&T", "Entel" };
            TipoTelefono[] tipo = { TipoTelefono.Teclado, TipoTelefono.Teclado, TipoTelefono.Teclado, TipoTelefono.Teclado, 
                                    TipoTelefono.Disco, };
            if(lista is not null)
            {
                for(int i=0;i<5;i++)
                {
                    Telefono t = new Telefono(GenerarId(), marca[i], tipo[i]);
                    lista.Add(t);
                }
            }
        }

        public override string MostrarDispositivo()
        {
            StringBuilder telefonoStr = new StringBuilder();

            telefonoStr.AppendLine($"ID: {Id}");
            telefonoStr.AppendLine($"Marca: {marca}");
            telefonoStr.AppendLine($"Tipo de telefono: {tipo}");
            return telefonoStr.ToString();
        }

        
    }
}
