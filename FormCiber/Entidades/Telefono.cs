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
            SetearId();
            this.Tipo = tipo;
            this.Marca = marca;
        }

        protected override void SetearId()
        {
            base.Id = String.Format("T{0:00}", siguienteId);
            siguienteId++;
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
    }
}
