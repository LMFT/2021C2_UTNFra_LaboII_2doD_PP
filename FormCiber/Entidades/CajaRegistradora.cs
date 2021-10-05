using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CajaRegistradora
    {
        private double efectivo;
        private const double costoFraccionPc = 0.5;
        private const double tiempoFraccionPc = 30;
        private const double tiempoFraccionTelefono = 60;
        private const double costoLlamadaLocal = 1;
        private const double costoLlamadaLargaDistancia = 2.5;
        private const double costoLlamadaInternacional = 5;

        public CajaRegistradora() { }
        public CajaRegistradora(double efectivo)
        {
            this.efectivo = efectivo;
        }

        internal CajaRegistradora InicializarCaja(int cantidadClientes)
        {
            CajaRegistradora caja = new CajaRegistradora();
            double monto;
            
            if(caja is not null)
            {
                for(int i=0;i<cantidadClientes;i++)
                {
                    Cliente cliente = Cliente.GenerarCliente();
                    monto = Cobrar(cliente);
                    Operacion operacion = new Operacion(cliente, monto);
                    Cibercafe.AgregarOperacionAHistorial(operacion);
                }
            }
            return caja;
        }

        public double Cobrar(Cliente cliente)
        {
            DateTime horaFinalizacion = DateTime.Now;
            TimeSpan tiempoUso;
            double fraccionesTotales;
            double monto = 0;
            if (cliente is not null)
            {
                tiempoUso = horaFinalizacion - cliente.HoraInicio;
                if(cliente.Dispositivo.GetType() == typeof(Computadora))
                {
                    fraccionesTotales = Math.Ceiling(tiempoUso.TotalSeconds / tiempoFraccionPc);
                    monto += fraccionesTotales * costoFraccionPc;
                }
                else
                {
                    fraccionesTotales = Math.Ceiling(tiempoUso.TotalSeconds / tiempoFraccionTelefono);
                    monto += CalcularCostoLlamada(cliente, fraccionesTotales);
                }
                efectivo += monto;
            }
            return monto;
        }

        private double CalcularCostoLlamada(Cliente cliente, double fraccionesTotales)
        {
            double total = 0;
            Telefono tel = cliente.Dispositivo as Telefono;
            if (tel is not null)
            {
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
            }
            return total;
        }


    }
}
