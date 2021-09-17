using System;

namespace Dispositivos
{
    public enum Estado { Ocupado, Libre, Reservado, Roto}
    public class Dispositivo
    {
        string[] id;
        Estado estado;
        double costoFraccion;

    }
}
