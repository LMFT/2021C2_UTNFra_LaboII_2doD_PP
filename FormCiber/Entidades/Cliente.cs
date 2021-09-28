using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneradorNumeros;
using Elementos;

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
        private string perifericoNecesario;


        public Cliente(string nombre, string apellido, int dni, int edad, Necesidad necesidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
            this.necesidad = necesidad;
        }


        public Cliente(string nombre, string apellido, int dni, int edad, Necesidad necesidad, string software) : 
            this(nombre, apellido, dni, edad, necesidad)
        {
            this.softwareNecesario = software;
        }

        public Cliente(string nombre, string apellido, int dni, int edad, Necesidad necesidad, string software, string periferico) :
            this(nombre, apellido, dni, edad, necesidad, software)
        {
            this.perifericoNecesario = periferico;
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

        public string Periferico
        {
            get
            {
                return perifericoNecesario;
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

        public static Cliente GenerarCliente()
        {
            Cliente cliente = new Cliente(Elemento.ObtenerNombre(GeneradorNumero.Generar(0, Elemento.Nombres)),
                                          Elemento.ObtenerApellido(GeneradorNumero.Generar(0, Elemento.Apellidos)),
                                          GeneradorNumero.Generar(16000000, 50000000), GeneradorNumero.Generar(13, 80),
                                          (Necesidad)GeneradorNumero.Generar(0,2));
            if(cliente.Necesidad == Necesidad.Computadora)
            {
                cliente.softwareNecesario = Elemento.Ob
            }


            return cliente;
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

        private static string GenerarSoftwareNecesario()
        {
            string[] softwareDisponible = { "Office", "Messenger", "ICQ", "Ares", "Counter-Strike", "Diablo II", "Lineage II",
                                            "Warcraft 3", "Age of Empires II" };
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

        public void AsignarDispositivo(Dispositivo dispositivo)
        {
            this.Dispositivo = dispositivo;
        }

        public string ObtenerSoftwareNecesario()
        {
            return this.softwareNecesario;
        }
    }
}

