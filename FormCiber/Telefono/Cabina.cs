using System;

namespace Dispositivos.Cabina
{
    public enum TipoTelefono { Disco, Teclado}
    public class Cabina
    {
        TipoTelefono tipo;
        string marca;

        public TipoTelefono Tipo { get => tipo; set => tipo = value; }
        public string Marca { get => marca; set => marca = value; }
    }
}
