using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generadores;

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
            historial = new List<Operacion>();
            caja = CajaRegistradora.InicializarCaja(10);
        }

        static List<Dispositivo> GenerarDispositivos()
        {
            List<Dispositivo> lista = new List<Dispositivo>();
            Computadora.HardcodearComputadoras(lista);
            Telefono.HardcodearTelefonos(lista);
            caja = new CajaRegistradora();
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

        public static List<Operacion> GetHistorial()
        {
            return historial;
        }

        public static List<Computadora> FiltrarComputadoras()
        {
            List<Computadora> listaFiltrada = new List<Computadora>();
            foreach (Dispositivo dispositivo in dispositivos)
            {
                if (dispositivo.ObtenerId().StartsWith("C"))
                {
                    listaFiltrada.Add(dispositivo as Computadora);
                }
            }

            return listaFiltrada;
        }

        public static List<Telefono> FiltrarTelefonos()
        {
            List<Telefono> listaFiltrada = new List<Telefono>();
            foreach (Dispositivo dispositivo in dispositivos)
            {
                if (dispositivo.ObtenerId().StartsWith("T"))
                {
                    listaFiltrada.Add(dispositivo as Telefono);
                }
            }

            return listaFiltrada;
        }

        public static Cliente VerProximoCliente()
        {
            return colaClientes.Peek();
        }

        public static Cliente AtenderCliente()
        {
            return colaClientes.Dequeue();
        }

        public static bool AgregarCliente()
        {
            Cliente c = Cliente.GenerarCliente();
            return AgregarCliente(c);
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
                if (d.Cliente is not null && d.Cliente == dispositivo.Cliente)
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

        internal static double Cobrar(Cliente cliente, DateTime horaInicio)
        {
            if(cliente is not null && cliente.Dispositivo is not null && cliente.Dispositivo.Estado == Estado.Ocupado)
            {
                cliente.Dispositivo.CambiarEstado();
                return caja.Cobrar(cliente, horaInicio);
            }
            return 0;
        }

        public static double Cobrar(Cliente cliente)
        {
            return Cobrar(cliente, DateTime.Now);
        }

        public static void AsignarDispositivoAleatorio(Cliente cliente)
        {
            if(cliente.Necesidad == Necesidad.Computadora)
            {
                List<Computadora> lista = FiltrarComputadoras();
                cliente.AsignarDispositivo(lista.ElementAt(GeneradorNumero.Generar(0, lista.Count)));
            }
            else
            {
                List<Telefono> lista = FiltrarTelefonos();
                cliente.AsignarDispositivo(lista.ElementAt(GeneradorNumero.Generar(0, lista.Count)));
            }
            
        }
    }
}
