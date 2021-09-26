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
            this.dispositivos = CrearDispositivos();
        }

        private List<Dispositivo> CrearDispositivos()
        {
            List<Dispositivo> listado = new List<Dispositivo>();
            Computadora.HardcodearComputadoras(listado);
            Telefono.HardcodearTelefonos(listado);
            return listado;
        }

        internal Queue<Cliente> ColaClientes
        {
            get
            {
                return colaClientes;
            }
        }

        public List<Dispositivo> Dispositivos
        {
            get
            {
                return dispositivos;
            }
        }

        public List<Cliente> ObtenerListaClientes()
        {
            return ColaClientes.ToList();
        }

    }
}
