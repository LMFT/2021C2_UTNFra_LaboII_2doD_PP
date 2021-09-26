using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneradorNumeros;
namespace Entidades
{
    public enum TipoTelefono
    {
        Disco,
        Teclado
    }
    public class Telefono : Dispositivo
    {
        private TipoTelefono tipo;
        private string marca;
        static private int siguienteId = 1;

        public Telefono(TipoTelefono tipo, string marca)
        {
            this.Id = String.Format("T{0:00}", siguienteId++);
            this.Tipo = tipo;
            this.Marca = marca;
            this.Estado = Estado.Libre;
            
        }



        internal TipoTelefono Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }
        }

        internal string Marca
        {
            get
            {
                return marca;
            }
            set
            {
                if(value is not null && value != String.Empty)
                {
                    marca = value;
                }
            }
        }

        public static void HardcodearTelefonos(List<Dispositivo> listado)
        {
            string[] marcas = { "Motorola", "Panacom", "Philips", "Noblex" };
            for(int i = 0; i < 5; i++)
            {
                Telefono telefono = new Telefono((TipoTelefono)GeneradorNumero.Generar(0, 2), marcas[GeneradorNumero.Generar(0,marcas.Length)]);
                listado.Add(telefono);
            }
        }

        public override string MostrarDispositivo()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"ID Dispositivo: {this.Id}");
            informacion.AppendLine($"Estado: {this.Estado}");
            informacion.AppendLine($"Marca: {this.Marca}");
            informacion.AppendLine($"Tipo de telefono: {this.Tipo}");
            return informacion.ToString();
        }
    }
}
