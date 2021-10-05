using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Cibercafe
    {
        private static Queue<Cliente> colaClientes;
        private static CajaRegistradora caja;
        private static List<Dispositivo> dispositivos;
        private static List<Operacion> historial;

        static Cibercafe()
        {
            colaClientes = Cliente.HardcodearClientes();
            dispositivos = GenerarDispositivos();
        }

        static List<Dispositivo> GenerarDispositivos()
        {
            List<Dispositivo> lista = new List<Dispositivo>();
            Computadora.HardcodearComputadoras(lista);
            Telefono.HardcodearTelefonos(lista);
            return lista;
        }
        
        public static Dispositivo ObtenerDispositivo(string id)
        {
            foreach(Dispositivo d in dispositivos)
            {
                if(d == id)
                {

                    return d;
                }
            }
            return null;
        }

        public static string VerProximoCliente()
        {
            return colaClientes.Peek().ToString();
        }

        public static Cliente AtenderCliente()
        {
            return colaClientes.Dequeue();
        }

        public static bool AgregarCliente()
        {
            Cliente c = Cliente.GenerarCliente();
            if(c is not null)
            {
                colaClientes.Enqueue(c);
                return true;
            }
            return false;
        }

        public static bool AgregarCliente(Cliente c)
        {
            if(c is not null)
            {
                colaClientes.Enqueue(c);
                return true;
            }
            return false;
        }

        public static Queue<Cliente> Clientes
        {
            get
            {
                return colaClientes;
            }
        }
        internal static List<Dispositivo> Dispositivos
        {
            get
            {
                return dispositivos;
            }
        }

        public static void AgregarOperacionAHistorial(Operacion operacion)
        {
            historial.Add(operacion);
        }

        public static Cliente ObtenerClientePorDispositivo(Dispositivo dispositivo)
        {
            foreach(Dispositivo d in dispositivos)
            {
                if (d.Cliente == dispositivo.Cliente)
                {
                    return d.Cliente;
                }
            }
            return null;
        }

        public static Cliente ObtenerClientePorDispositivo(string id)
        {
            Dispositivo d = Cibercafe.ObtenerDispositivo(id);
            return ObtenerClientePorDispositivo(d);
        }

        public static double Cobrar(Cliente cliente)
        {
            if(cliente is not null && cliente.Dispositivo.Estado == Estado.Ocupado)
            {
                cliente.Dispositivo.CambiarEstado();
                return caja.Cobrar(cliente);
            }
            return 0;
        }
    }
}
