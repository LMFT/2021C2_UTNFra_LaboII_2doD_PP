using System;

namespace Dispositivos
{
    public enum Estado { Ocupado, Libre, Reservado, Roto}
    public class Dispositivo
    {
        string id;
        Estado estado;
        double costoFraccion;

        public Dispositivo(string id, Estado estado, double costoFraccion)
        {
            this.id = id;
            this.estado = estado;
            this.costoFraccion = costoFraccion;
        }

        public string Id { get => id; set => id = value; }
        public Estado Estado { get => estado; set => estado = value; }
        public double CostoFraccion { 
            get 
            {
                return costoFraccion;
            }  
            
            set 
            {
                if (value > 0)
                {
                    costoFraccion = value;
                }
            }  
        }
    }
}
