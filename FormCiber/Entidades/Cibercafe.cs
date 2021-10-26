using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace Entidades
{
    /// <summary>
    /// Contiene métodos generales relativos a la gestion del cibercafe
    /// </summary>
    public static class Cibercafe
    {
        private static Queue<Cliente> colaClientes;
        private static List<Cliente> clientesConDispositivo;
        private static CajaRegistradora caja;
        private static List<Dispositivo> dispositivos;
        private static List<Operacion> historial;
        /// <summary>
        /// Inicializa los atributos de la clase
        /// </summary>
        static Cibercafe()
        {
            colaClientes = Cliente.HardcodearClientes();
            dispositivos = GenerarDispositivos();
            historial = new List<Operacion>();
            caja = CajaRegistradora.InicializarCaja(10);
            clientesConDispositivo = new List<Cliente>();
        }
        /// <summary>
        /// Genera una lista de dispositivos y la inicializa con los dispositivos hardcodeados del cibercafe
        /// </summary>
        /// <returns>Lista de dispositivos inicializada</returns>
        private static List<Dispositivo> GenerarDispositivos()
        {
            List<Dispositivo> lista = new List<Dispositivo>();
            Computadora.HardcodearComputadoras(lista);
            Telefono.HardcodearTelefonos(lista);
            caja = new CajaRegistradora();
            return lista;
        }
        /// <summary>
        /// Obtiene un dispositivo del listado en base al ID recibido como parametro
        /// </summary>
        /// <param name="id">ID del dispositivo a buscar</param>
        /// <returns>Dispositio cuyo ID coincide con el ID recibido como parámetro, o null si el ID no se encuentra</returns>
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
        /// <summary>
        /// Retorna el historial de operaciones
        /// </summary>
        /// <returns>Retorna el historial de operaciones</returns>
        public static List<Operacion> GetHistorial()
        {
            return historial;
        }
        /// <summary>
        /// Filtra el listado de dispositivos y retorna un nuevo listado que solamente contiene computadoras
        /// </summary>
        /// <returns>Listado de computadoras del cibercafe</returns>
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
        /// <summary>
        /// Filtra el listado de dispositivos y retorna un nuevo listado que solamente contiene telefonos
        /// </summary>
        /// <returns>Listado de telefonos del cibercafe</returns>
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
        /// <summary>
        /// Retorna el proximo cliente de la cola sin removerlo
        /// </summary>
        /// <returns>Datos del proximo cliente</returns>
        public static Cliente VerProximoCliente()
        {
            return colaClientes.Peek();
        }
        /// <summary>
        /// Retorna el proximo cliente de la cola de espera y lo remueve de la misma
        /// </summary>
        /// <returns>Siguiente cliente a atender</returns>
        public static Cliente AtenderCliente()
        {
            return colaClientes.Dequeue();
        }
        /// <summary>
        /// Añade al cliente recibido al listado de clientes con dispositivos asignados
        /// </summary>
        /// <param name="cliente">Cliente a añadir</param>
        public static void AsignarDispositivo(Cliente cliente)
        {
            clientesConDispositivo.Add(cliente);
        }
        /// <summary>
        /// Elimina al cliente recibido del listado de clientes con dispositivos asignados
        /// </summary>
        /// <param name="cliente">Cliente a eliminar</param>
        public static void LiberarDispositivo(Cliente cliente)
        {
            clientesConDispositivo.Remove(cliente);
        }

        /// <summary>
        /// Genera y añade un nuevo cliente a la cola
        /// </summary>
        /// <returns>true si pudo generar y agregar un nuevo cliente, de lo contrario false</returns>
        public static bool AgregarCliente()
        {
            Cliente c = Cliente.GenerarCliente();
            return AgregarCliente(c);
        }
        /// <summary>
        /// Añade un cliente recibido como parámetro a la cola
        /// </summary>
        /// <returns>true si pudo agregar un nuevo cliente, de lo contrario false</returns>
        public static bool AgregarCliente(Cliente c)
        {
            if(c is not null)
            {
                colaClientes += c;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Retorna la cola de clientes
        /// </summary>
        public static Queue<Cliente> Clientes
        {
            get
            {
                return colaClientes;
            }
        }
        /// <summary>
        /// Retorna la lista de dispositivos
        /// </summary>
        internal static List<Dispositivo> Dispositivos
        {
            get
            {
                return dispositivos;
            }
        }
        /// <summary>
        /// Añade la operacion recibida como parametro al historial de operaciones del cibercafe
        /// </summary>
        /// <param name="operacion">Operación a añadir al historial</param>
        private static void AgregarOperacionAHistorial(Operacion operacion)
        {
            historial.Add(operacion);
        }
        /// <summary>
        /// Obtiene al cliente asignado a un dispositivo
        /// </summary>
        /// <param name="dispositivo">Dispositivo del cual se quiere obtener el cliente que lo esta utilizando</param>
        /// <returns>
        /// </returns>
        public static Cliente ObtenerClientePorDispositivo(Dispositivo dispositivo)
        {
            foreach(Cliente cliente in clientesConDispositivo)
            {
                if (dispositivo is not null && cliente.Dispositivo == dispositivo)
                {
                    return cliente;
                }
            }
            return null;
        }
        /// <summary>
        /// Obtiene el cliente asignado a un dispositivo a partir del ID del dispositivo
        /// </summary>
        /// <param name="id">ID del dispositivo a buscar</param>
        /// <returns>Cliente asignado al dispositivo recibido como parámetro o null si el dispositivo esta libre, no existe en la lista
        ///  o el ID pasado como parámetro no esta asociado a ningun dispositivo</returns>
        public static Cliente ObtenerClientePorDispositivo(string id)
        {
            Dispositivo d = Cibercafe.ObtenerDispositivo(id);
            return ObtenerClientePorDispositivo(d);
        }
        /// <summary>
        /// Cambia el estado del dispositivo y calcula el monto a cobrar en base a la hora de finalizacion del dispositivo recibida como 
        /// parametro
        /// </summary>
        /// <param name="cliente">Cliente al cual cobrar por los servicios prestados</param>
        /// <param name="horaFinalizacion">Hora de finaliación de uso del dispositivo</param>
        /// <returns>Monto a cobrar por los servicios prestados o 0 si el cliente o dispositivo son nulos, o si el dispositivo
        /// se encuentra libre</returns>
        public static double Cobrar(Cliente cliente, DateTime horaFinalizacion)
        {
            if(cliente is not null && cliente.Dispositivo is not null && cliente.Dispositivo.Estado == Estado.Ocupado)
            {
                cliente.Dispositivo.CambiarEstado();
                return caja.Cobrar(cliente, horaFinalizacion);
            }
            return 0;
        }
        /// <summary>
        /// Cambia el estado del dispositivo y calcula el monto a cobrar en base al tiempo de uso del dispositivo
        /// </summary>
        /// <param name="cliente">Cliente al cual cobrar por los servicios prestados</param>
        /// <returns>Monto a cobrar por los servicios prestados o 0 si el cliente o dispositivo son nulos, o si el dispositivo
        /// se encuentra libre</returns>
        public static double Cobrar(Cliente cliente)
        {
            return Cobrar(cliente, DateTime.Now);
        }
        /// <summary>
        /// Asigna un dispositivo aleatorio a un cliente, en base a su necesidad actual
        /// </summary>
        /// <param name="cliente">Cliente al cual asignar el dispositivo</param>
        /// <param name="horaInicio">Hora de inicio de uso del dispositivo</param>
        public static void AsignarDispositivoAleatorio(Cliente cliente, DateTime horaInicio)
        {
            if(cliente.Necesidad == Necesidad.Computadora)
            {
                List<Computadora> lista = FiltrarComputadoras();
                cliente.AsignarDispositivo(lista.ElementAt(Utilidades.GeneradorNumero.Generar(0, lista.Count)), horaInicio);
            }
            else
            {
                List<Telefono> lista = FiltrarTelefonos();
                cliente.AsignarDispositivo(lista.ElementAt(Utilidades.GeneradorNumero.Generar(0, lista.Count)), horaInicio);
            }
            
        }
        /// <summary>
        /// Genera una nueva operacion y la añade al historial de operaciones
        /// </summary>
        /// <param name="cliente">Cliente que ha solicitado un dispositivo</param>
        /// <param name="monto">Monto neto percibido por el alquiler del dispositivo</param>
        public static void AgregarOperacionAHistorial(Cliente cliente, double monto)
        {
            Operacion operacion = new Operacion(cliente, monto);
            Cibercafe.AgregarOperacionAHistorial(operacion);
        }
        /// <summary>
        /// Genera un nuevo cliente y asigna un dispositivo aleatoerio para simular una operacion previa al uso del programa
        /// </summary>
        /// <returns>Cliente inicializado con un dispositivo asignado</returns>
        public static Cliente GenerarOperacionPrevia()
        {
            Cliente cliente = Cliente.GenerarCliente();
            DateTime horaInicio = DateTime.Now.RestarTiempo();
            Cibercafe.AsignarDispositivoAleatorio(cliente, horaInicio);
            return cliente;
        }
    }
}
