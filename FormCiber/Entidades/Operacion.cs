using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Contiene informacion sobre una operacion realizada en el cibercafe(alquiler de un disposiutivo)
    /// </summary>
    public class Operacion
    {
        private int id;
        private Cliente cliente;
        private double montoPercibido;
        private static int ultimoId = 1;

        public Operacion(Cliente cliente, double montoPercibido)
        {
            id = ultimoId;
            ultimoId++;
            this.cliente = cliente;
            this.montoPercibido = montoPercibido;
        }

        public Cliente Cliente
        {
            get
            {
                return cliente;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public double Monto
        {
            get
            {
                return montoPercibido;
            }
        }
        /// <summary>
        /// Muestra los datos de la instancia de operacion actual
        /// </summary>
        /// <returns>Informacion ed la operacion en formato string</returns>
        public override string ToString()
        {
            StringBuilder operacion = new StringBuilder();

            operacion.AppendLine($"Operacion Nº {id}");
            operacion.AppendLine($"Datos del cliente: \n{cliente}");
            operacion.AppendLine($"Fecha de la operacion: {cliente.HoraFinalizacion}");
            operacion.AppendLine($"Monto: {montoPercibido}");
            return operacion.ToString();
        }
    }
}
