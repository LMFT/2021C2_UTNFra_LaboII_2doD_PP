using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elementos;
using Utilidades;

namespace Entidades
{
    /// <summary>
    /// Contiene métodos y constantes relacionados al cobro por los dispositivos alquilados
    /// </summary>
    public class CajaRegistradora
    {
        private const double iva = 1.21;
        private const double costoFraccionPc = 0.5;
        private const double costoLlamadaLocal = 1;
        private const double costoLlamadaLargaDistancia = 2.5;
        private const double costoLlamadaInternacional = 5;

        /// <summary>
        /// Genera una nueva instancia del objeto y genera operaciones aleatorias para simular usos previos en base a la cantidad de clientes pasados por
        /// parametro
        /// </summary>
        /// <param name="cantidadOperaciones">Cantidad de operaciones a añadir al historial </param>
        /// <returns>Instancia inicializada de la caja registradora</returns>
        internal static CajaRegistradora InicializarCaja(int cantidadOperaciones)
        {
            CajaRegistradora caja = new CajaRegistradora();
            double monto;
            
            if(caja is not null)
            {
                for(int i=0;i<cantidadOperaciones;i++)
                {
                    {
                        Cliente cliente = Cibercafe.GenerarOperacionPrevia();
                        DateTime horaFinalizacion = cliente.HoraInicio.AgregarTiempo(Dispositivo.EsTelefono(cliente.Dispositivo));
                        monto = Cibercafe.Cobrar(cliente, horaFinalizacion);
                        Cibercafe.AgregarOperacionAHistorial(cliente, monto);
                    }
                }
            }
            return caja;
        }
        /// <summary>
        /// Calcula el monto bruto a cobrar en base al tiempo de uso del dispositivo asignado al cliente
        /// </summary>
        /// <param name="cliente">Cliente al cual cobrar el monto</param>
        /// <param name="horaFinalizacion">Hora en la cual terminó el uso del dispositivo</param>
        /// <returns>El monto bruto a cobrar por el dispositivo asignado</returns>
        internal double CalcularMontoBruto(Cliente cliente)
        {
            double tiempoUso;
            double fraccionesTotales;
            double montoBruto = -1;
            if (cliente is not null)
            {
                tiempoUso = cliente.TiempoUso();
                fraccionesTotales = Math.Ceiling(tiempoUso / cliente.Dispositivo.TiempoFraccion);
                if(cliente.Dispositivo.GetType() == typeof(Computadora))
                {
                    montoBruto = fraccionesTotales * costoFraccionPc;
                }
                else
                {
                    
                    montoBruto = CalcularCostoLlamada(cliente);
                }
            }
            return montoBruto;
        }
        /// <summary>
        /// Setea el valor del atributo horaFinaliacion del cliente y retorna el monto bruto a cobrar por los servicios prestados
        /// </summary>
        /// <param name="cliente">Cliente al cual cobrar por el servicio</param>
        /// <param name="horaFinalizacion">Hora de finalizacion del servicio</param>
        /// <returns>El monto bruto a cobrar por el dispositivo asignado</returns>
        internal double Cobrar(Cliente cliente, DateTime horaFinalizacion)
        {
            cliente.SetHoraFinalizacion(horaFinalizacion);
            return CalcularMontoBruto(cliente);
        }
        /// <summary>
        /// Calcula el costo de la llamada telefónica realizada por el cliente
        /// </summary>
        /// <param name="cliente">Cliente que realizó la llamada</param>
        /// <returns>Costo total de la lamada</returns>
        private double CalcularCostoLlamada(Cliente cliente)
        {
            double total = 0;
            double fraccionesTotales = Math.Ceiling(cliente.TiempoUso() / cliente.Dispositivo.TiempoFraccion);
            Telefono tel = cliente.Dispositivo as Telefono;
            switch (tel.Llamada.Tipo)
            {
                case TipoLlamada.Local:
                    total = fraccionesTotales * costoLlamadaLocal;
                    break;
                case TipoLlamada.LargaDistancia:
                    total = fraccionesTotales * costoLlamadaLargaDistancia;
                    break;
                case TipoLlamada.Internacional:
                    total = fraccionesTotales * costoLlamadaInternacional;
                    break;
            }

            return total;
        }
        /// <summary>
        /// Aplica el cálculo de IVA al monto recibido como parámetro
        /// </summary>
        /// <param name="monto">Monto sobre el cual aplicar iva</param>
        /// <returns></returns>
        public static double AplicarIva(double monto)
        {
            return monto * iva;
        }
    }
}
