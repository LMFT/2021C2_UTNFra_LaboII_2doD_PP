using System;

namespace Entidades
{
    
    public abstract class Dispositivo
    {
        private string id;
        private Estado estado;
        private Cliente clienteActual;
        private int tiempoFraccion;
        private int fraccionesAsignadas;

        public Dispositivo(string id, int tiempoFraccion)
        {
            this.estado = Estado.Libre;
            this.id = id;
            this.tiempoFraccion = tiempoFraccion;
        }

        protected string Id
        {
            get
            {
                return id;
            }
            set
            {
                if(value is not null && value != String.Empty)
                {
                    id = value;
                }
            }
        }

        internal Estado Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }

        public int TiempoFraccion
        {
            get
            {
                return tiempoFraccion;
            }
        }
        internal Cliente Cliente
        {
            get
            {
                return clienteActual;
            }
            set 
            {
                clienteActual = value;
            }
        }

        public abstract string MostrarDispositivo();

        public string ObtenerId()
        {
            return id;
        }

        public static  bool operator ==(Dispositivo d1, Dispositivo d2)
        {
            return d1.id == d2.id;
        }

        public static bool operator !=(Dispositivo d1, Dispositivo d2)
        {
            return !(d1 == d2);
        }

        public static bool operator ==(Dispositivo d, string s)
        {
            return d.id == s;
        }

        public static bool operator !=(Dispositivo d, string s)
        {
            return !(d == s);
        }

        public override bool Equals(object obj)
        {
            Dispositivo dispositivo = obj as Dispositivo;
            if(dispositivo is not null && this == dispositivo)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }

        internal void CambiarEstado()
        {
            if(estado == Estado.Libre)
            {
                this.estado = Estado.Ocupado;
                return;
            }
            estado = Estado.Libre;
        }

        public Estado ObtenerEstado()
        {
            return Estado;
        }

        public int Fracciones
        {
            get 
            {
                return fraccionesAsignadas;
            }
            set
            {
                if(value>=0)
                {
                    fraccionesAsignadas = value;
                }
            }
        }
        public void Liberar()
        {
            this.Estado = Estado.Libre;
            this.Cliente = null;
        }

        public int TiempoUso()
        {
            return this.Fracciones * this.TiempoFraccion;
        }

        public static bool EsTelefono(Dispositivo d)
        {
            if(typeof(Telefono) == d.GetType())
            {
                return true;
            }
            return false;
        }
    }
}
