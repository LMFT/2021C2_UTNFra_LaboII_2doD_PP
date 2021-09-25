using System;
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
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private int dni;
        private int edad;
        Necesidad necesidad;
        Dispositivo dispositivoAsignado;

        public Cliente(string nombre, string apellido, int dni, int edad, Necesidad necesidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
            this.necesidad = necesidad;
        }

        internal Dispositivo Dispositivo
        {
            get
            {
                return dispositivoAsignado;
            }
            set
            {
                if (value is not null)
                {
                    dispositivoAsignado = value;
                }
            }
        }

        internal string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (value is not null && value != String.Empty)
                {
                    nombre = value;
                }
            }
        }

        internal string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                if (value is not null && value != String.Empty)
                {
                    apellido = value;
                }
            }
        }

        internal int Dni
        {
            get
            {
                return dni;
            }
            set
            {
                if (value > 0)
                {
                    dni = value;
                }
            }
        }

        internal int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                if (value > 0)
                {
                    edad = value;
                }
            }
        }
        internal Necesidad Necesidad
        {
            get
            {
                return necesidad;
            }
            set
            {
                necesidad = value;
            }
        }

        public static Queue<Cliente> HardcodearClientes()
        {
            Queue<Cliente> colaClientes = new Queue<Cliente>();
            string[] nombres = {"Lucas", "Javier", "Marcelo", "Marcos", "Juan", "Gonzalo"};
            string[] apellidos = { "Ferrini", "Perez", "Fernandez", "Tapia", "Gonzalez", "Alonso" };
            int[] documentos = {11111111, 22222222, 12312312, 12312312, 32132132, 27854968 };
            int[] edades = {28, 40, 35, 21, 50, 47 };
            Necesidad[] necesidades = { Necesidad.Computadora, Necesidad.Telefono,Necesidad.Computadora, Necesidad.Telefono,
                                        Necesidad.Computadora, Necesidad.Telefono };

            for(int i=0;i<6;i++)
            {
                Cliente cliente = new Cliente(nombres[i], apellidos[i], documentos[i], edades[i], necesidades[i]);
                colaClientes.Enqueue(cliente);
            }
            return colaClientes;
        }

          
    }
}

