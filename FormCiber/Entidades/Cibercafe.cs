using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Cibercafe
    {
        private static Queue<Cliente> colaClientes = Cliente.HardcodearClientes();
        private static List<Dispositivo> dispositivos = CrearDispositivos();

        private static List<Dispositivo> CrearDispositivos()
        {
            List<Dispositivo> listado = new List<Dispositivo>();
            Computadora.HardcodearComputadoras(listado);
            Telefono.HardcodearTelefonos(listado);
            return listado;
        }

        public static List<Cliente> ObtenerClientesEnEspera()
        {
            List<Cliente> lista = new List<Cliente>();
            foreach(Cliente c in colaClientes)
            {
                lista.Add(c);
            }
            return lista;
        }

        public static string MostrarDispositivo(string id)
        {
            foreach(Dispositivo dispositivo in dispositivos)
            {
                if(dispositivo == id)
                {
                    return dispositivo.MostrarDispositivo();
                }
            }
            return String.Empty;
        }

        public static Dispositivo ObtenerDispositivo(string id)
        {
            Dispositivo d = null;
            foreach(Dispositivo d2 in dispositivos)
            {
                if(d2 == id)
                {
                    d = d2;
                    return d;
                }
            }
            return d;
        }

        public static Cliente AtenderCliente()
        {
            return colaClientes.Dequeue();
        }

        public static string MostrarProximoCliente()
        {
            return colaClientes.Peek().MostrarCliente();
        }
    }
}
