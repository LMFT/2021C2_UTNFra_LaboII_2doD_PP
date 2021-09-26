using System;

namespace Entidades
{
    public enum Estado
    {
        Libre,
        Ocupado
    }
    public abstract class Dispositivo
    {
        private string id;
        Estado estado;

        protected abstract void SetearId();

        protected string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
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

        public abstract string MostrarDispositivo();

        public static  bool operator ==(Dispositivo d1, Dispositivo d2)
        {
            return d1.id == d2.id;
        }

        public static bool operator !=(Dispositivo d1, Dispositivo d2)
        {
            return !(d1 == d2);
        }

        public override bool Equals(object obj)
        {
            Dispositivo dispositivo = obj as Dispositivo;
            if(dispositivo is not null && this.Id == dispositivo.Id)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }


    }
}
