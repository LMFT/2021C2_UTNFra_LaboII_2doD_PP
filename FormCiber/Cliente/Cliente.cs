using System;

namespace Personas.Cliente
{
    public enum Necesidad { Telefono, Computadora }
    public enum TipoLlamada{Local, LargaDistancia, Internacional}

    public class Cliente
    {
        string nombre;
        Necesidad necesidad;
        TipoLlamada tipoLlamada;
        string softwareNecesario;

        public Cliente(string nombre, Necesidad necesidad)
        {
            this.Nombre = nombre;
            this.Necesidad = necesidad;
        }
        public Cliente(string nombre, Necesidad necesidad, TipoLlamada tipoLlamada):this(nombre, necesidad)
        {
            this.tipoLlamada = tipoLlamada;
        }

        public Cliente(string nombre, Necesidad necesidad, string softwareNecesario) : this(nombre, necesidad)
        {
            this.softwareNecesario = softwareNecesario;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public Necesidad Necesidad { get => necesidad; set => necesidad = value; }
        public TipoLlamada TipoLlamada { get => tipoLlamada; set => tipoLlamada = value; }
        public string SoftwareNecesario { get => softwareNecesario; set => softwareNecesario = value; }
    }
}
