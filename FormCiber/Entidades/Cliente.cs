using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneradorNumeros;

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
        private string softwareNecesario;

        public Cliente(string nombre, string apellido, int dni, int edad, Necesidad necesidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
            this.necesidad = necesidad;
            if(necesidad == Necesidad.Computadora)
            {
                this.softwareNecesario = GenerarSoftwareNecesario();
            }
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

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
        }

        public int Dni
        {
            get
            {
                return dni;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }
        }
        public Necesidad Necesidad
        {
            get
            {
                return necesidad;
            }
        }

        public static Queue<Cliente> HardcodearClientes()
        {
            Queue<Cliente> colaClientes = new Queue<Cliente>();
            string[] nombres = {"Jose", "Javier", "Marcelo", "Marcos", "Juan", "Gonzalo"};
            string[] apellidos = { "Ramirez", "Perez", "Fernandez", "Tapia", "Gonzalez", "Alonso" };
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

        public string MostrarCliente()
        {
            StringBuilder clienteStr = new StringBuilder();
            clienteStr.AppendLine($"Nombre: {this.Nombre}");
            clienteStr.AppendLine($"Apellido: {this.Apellido}");
            clienteStr.AppendLine($"Dni: {this.Dni}");
            clienteStr.AppendLine($"Edad: {this.Edad}");
            return clienteStr.ToString();
        }

        private string GenerarSoftwareNecesario()
        {
            string[] softwareDisponible = { "Office", "Messenger", "ICQ", "Ares", "Counter-Strike", "Diablo II", "Lineage II", "Warcraft 3", "Age of Empires II" };
            return softwareDisponible[GeneradorNumero.Generar(0, softwareDisponible.Length)];
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.dni == c2.dni;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            Cliente c = obj as Cliente;
            if(c is not null && this.dni == c.dni)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.dni.GetHashCode();
        }
    }
}

