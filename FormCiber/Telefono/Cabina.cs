using System;
using Dispositivos;

namespace Dispositivos.Cabina
{
    public enum TipoTelefono { Disco, Teclado}
    public class Cabina : Dispositivo
    {
        TipoTelefono tipo;
        string marca;

        public Cabina(TipoTelefono tipo, string marca, string id, Estado estado, double costoFraccion) : base(id, estado, costoFraccion)
        {
            this.tipo = tipo;
            this.marca = marca;
        }
        public TipoTelefono Tipo { get => tipo; set => tipo = value; }
        public string Marca { get => marca; set => marca = value; }
    }
}
