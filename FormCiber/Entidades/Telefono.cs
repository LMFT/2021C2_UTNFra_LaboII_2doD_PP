using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum TipoTelefono
    {
        Disco,
        Teclado
    }
    public class Telefono : Dispositivo
    {
        private TipoTelefono tipo;
        private string marca;
        static private int siguienteId = 1;

        public Telefono(string id, TipoTelefono tipo, string marca)
        {
            SetearId();
            this.tipo = tipo;
            this.marca = marca;
            
        }

        protected override void SetearId()
        {
            base.Id = String.Format("T{0:00}", siguienteId);
            siguienteId++;
        }

        internal TipoTelefono Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }
        }

        internal string Marca
        {
            get
            {
                return marca;
            }
            set
            {
                if(value is not null && value != String.Empty)
                {
                    marca = value;
                }
            }
        }

    }
}
