using System;

namespace Entidades
{
    /// <summary>
    /// Contiene métodos comunes a las clases Computadora y Telefono, las cuales heredan de esta clase
    /// </summary>
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
        /// <summary>
        /// Muestra la informacion de un dispositivo
        /// </summary>
        /// <returns>Informacion del dispositivo en formato string</returns>
        public abstract string MostrarDispositivo();
        /// <summary>
        /// Retorna el ID del dispositivo
        /// </summary>
        /// <returns>ID del dispositivo</returns>
        public string ObtenerId()
        {
            return id;
        }
        /// <summary>
        /// Establece un criterio de igualdad para dos dispositivos, comparando que sus ID sean iguales
        /// </summary>
        /// <param name="d1">Primer dispositivo</param>
        /// <param name="d2">Segundo dispositivo</param>
        /// <returns>Retorna true si los ID de ambos dispositivos coinciden, de lo contrario false</returns>
        public static  bool operator ==(Dispositivo d1, Dispositivo d2)
        {
            return d1.id == d2.id;
        }
        /// <summary>
        /// Establece un criterio de desigualdad para dos dispositivos, comparando que sus ID sean iguales
        /// </summary>
        /// <param name="d1">Primer dispositivo</param>
        /// <param name="d2">Segundo dispositivo</param>
        /// <returns>Retorna false si los ID de ambos dispositivos coinciden, de lo contrario true</returns>
        public static bool operator !=(Dispositivo d1, Dispositivo d2)
        {
            return !(d1 == d2);
        }
        /// <summary>
        /// Establece un criterio de igualdad para un dispositivo y un string, comparando que el ID del dispositovo sea igual al string
        /// </summary>
        /// <param name="d">Dispositivo</param>
        /// <param name="s">String</param>
        /// <returns>Retorna true si el ID del dispositivo es igual al string recibido, de lo contrario false</returns>
        public static bool operator ==(Dispositivo d, string s)
        {
            return d.id == s;
        }
        /// <summary>
        /// Establece un criterio de desigualdad para un dispositivo y un string, comparando que el ID del dispositovo sea 
        /// igual al string
        /// </summary>
        /// <param name="d">Dispositivo</param>
        /// <param name="s">String</param>
        /// <returns>Retorna false si el ID del dispositivo es igual al string recibido, de lo contrario true</returns>
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
        /// <summary>
        /// Alterna el estado del dispositivo entre libre y ocupado
        /// </summary>
        internal void CambiarEstado()
        {
            if(estado == Estado.Libre)
            {
                this.estado = Estado.Ocupado;
                return;
            }
            Liberar();
        }
        /// <summary>
        /// Obtiene el estado del dispositivo
        /// </summary>
        /// <returns>Estado del dispositivo</returns>
        public Estado ObtenerEstado()
        {
            return Estado;
        }
        /// <summary>
        /// Retorna la cantidad de fracciones asignadas al dispositivo
        /// </summary>
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
        /// <summary>
        /// 
        /// </summary>
        public void Liberar()
        {
            this.Estado = Estado.Libre;
            this.Cliente = null;
        }
        /// <summary>
        /// Calcula el tiempo de uso de un dispositivo, en base a la cantidad de fracciones asignadas y el tiempo por fraccion
        /// </summary>
        /// <returns></returns>
        public int TiempoUso()
        {
            return this.Fracciones * this.TiempoFraccion;
        }
        /// <summary>
        /// Valida si el dispositivo es de tipo Telefono
        /// </summary>
        /// <param name="d"></param>
        /// <returns>true si el dispositivo recibido es de tipo telefono, de lo contrario false</returns>
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
