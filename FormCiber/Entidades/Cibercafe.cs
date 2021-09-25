using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cibercafe
    {
        Queue<Cliente> colaClientes;
        List<Dispositivo> dispositivos;

        public Cibercafe()
        {
            this.colaClientes = Cliente.HardcodearClientes();
            //this.dispositivos;
        }

    }
}
