using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibercontrol
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
        static private int ultimoId = 1;

        public Telefono(string id, TipoTelefono tipo, string marca)
        {
            this.tipo = tipo;
            this.marca = marca;
            
        }

        protected override void SetearId()
        {
            base.Id = String.Format("T{0:00}", ultimoId);
            ultimoId++;
        }
        

    }
}
