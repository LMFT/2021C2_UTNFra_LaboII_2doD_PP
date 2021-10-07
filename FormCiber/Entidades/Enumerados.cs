﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Necesidad
    {
        Telefono,
        Computadora
    }
    public enum Estado
    {
        Libre,
        Ocupado
    }
    public enum TipoLlamada
    {
        Local,
        LargaDistancia,
        Internacional
    }
}