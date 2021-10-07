using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operacion
    {
        private int id;
        private Cliente cliente;
        private DateTime horaFinalizacion;
        private double montoPercibido;
        private static int ultimoId = 1;

        public Operacion (Cliente cliente, DateTime horaFinalizacion, double montoPercibido)
        {
            id = ultimoId;
            ultimoId++;
            this.cliente = cliente;
            this.horaFinalizacion = horaFinalizacion;
            this.montoPercibido = montoPercibido;
        }
        public Operacion (Cliente cliente, double montoPercibido) : this(cliente, DateTime.Now, montoPercibido) { }

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

        public override string ToString()
        {
            StringBuilder operacion = new StringBuilder();

            operacion.AppendLine($"Operacion Nº {id}");
            operacion.AppendLine($"Datos del cliente: \n{cliente}");
            operacion.AppendLine($"Fecha de la operacion: {horaFinalizacion}");
            operacion.AppendLine($"Monto: {montoPercibido}");
            return operacion.ToString();
        }

        public double GetTiempoUso()
        {
            return (horaFinalizacion - cliente.HoraInicio).TotalSeconds;
        }
    }
}
