using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Establece la necesidad de un cliente
    /// </summary>
    public enum Necesidad
    {
        Telefono,
        Computadora
    }
    /// <summary>
    /// Establece el estado actual de un dispositivo
    /// </summary>
    public enum Estado
    {
        Libre,
        Ocupado
    }
    /// <summary>
    /// Establece el tipo de llamada
    /// </summary>
    public enum TipoLlamada
    {
        Local,
        LargaDistancia,
        Internacional
    }
}
