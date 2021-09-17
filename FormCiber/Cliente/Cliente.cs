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


    }
}
