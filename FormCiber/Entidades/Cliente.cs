using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneradorNumeros;
using Elementos;

namespace Entidades
{
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
        private DateTime horaInicio;

        public Cliente(string nombre, string apellido, Necesidad necesidad,int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.necesidad = necesidad;
            this.dni = dni;
            if (necesidad == Necesidad.Computadora)
            {
                GenerarPerifericoNecesario();
                GenerarSoftwareNecesario();
            }
        }
        public Cliente(string nombre, string apellido, Necesidad necesidad, int dni, int edad) : this(nombre, apellido, necesidad,dni)
        {
            this.edad = edad;
            
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

        public DateTime HoraInicio
        {
            get
            {
                return horaInicio;
            }
        }
        public Dispositivo Dispositivo
        {
            get
            {
                return dispositivoAsignado;
            }
        }

        public string SoftwareNecesario
        {
            get
            {
                return softwareNecesario;
            }
        }

        public string PerifericoNecesario
        {
            get
            {
                return perifericoNecesario;
            }
        }
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.dni == c2.dni;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

        public static bool operator ==(Cliente cliente, Queue<Cliente> cola)
        {
            foreach(Cliente c in cola)
            {
                if(c == cliente)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Cliente cliente, Computadora pc)
        {
            return !(cliente == pc);
        }

        public static bool operator ==(Cliente cliente, Computadora pc)
        {
            if((pc.Juegos.Contains<string>(cliente.softwareNecesario) || pc.Software.Contains<string>(cliente.softwareNecesario)) &&
                pc.Perifericos.Contains<string>(cliente.perifericoNecesario))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Cliente cliente, Queue<Cliente> cola)
        {
            return !(cliente == cola);
        }

        public static bool operator +(Cliente cliente, Queue<Cliente> cola)
        {
            if(cliente != cola)
            {
                cola.Enqueue(cliente);
                return true;
            }
            return false;
        }

        public override bool Equals(object obj)
        {
            Cliente c = obj as Cliente;
            if(c is not null && c==this)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return dni.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder clienteStr = new StringBuilder();
            clienteStr.AppendLine($"Nombre: {Nombre}");
            clienteStr.AppendLine($"Apellido: {Apellido}");
            clienteStr.AppendLine($"DNI: {Dni}");
            clienteStr.AppendLine($"Edad: {Edad}");
            clienteStr.AppendLine($"Necesidad: {necesidad}");
            if(this.necesidad == Necesidad.Computadora)
            {
                clienteStr.AppendLine($"Software Necesario: {softwareNecesario}");
                clienteStr.AppendLine($"Perifericos necesarios: {perifericoNecesario}");
            }
            return clienteStr.ToString();
        }
        public static Queue<Cliente> HardcodearClientes()
        {
            Queue<Cliente> cola = new Queue<Cliente>();
            string[] nombres = {"Lucas","Javier","Carolina", "Guadalupe", "Laura", "Maximiliano", "Bianca", "Violeta", "Martin",
                               "Facundo", "Diego", "Ezequiel", "Emanuel", "Alan", "Florencia" };
            string[] apellidos = { "Steinbrenner", "Fernandez", "Perez", "Gozalvez", "Martinez", "Scarsi", "Carrizo", "Gonzalez",
                                   "Albornoz", "Dotta", "Vietti", "Manriquez", "Cech", "Aspen", "Elbetti" };
            int[] dni = { 12345678, 34521654, 34579157, 37789546, 26847591, 38859610, 42150369, 29684578, 35589214, 36458974, 30258965, 
                40259036, 25099681, 26509856,  42567345};
            int[] edades = { 29, 35, 49, 18, 16, 20, 21, 50, 30, 28, 45, 48, 49, 32, 15};
            Necesidad[] necesidades = { Necesidad.Telefono, Necesidad.Computadora, Necesidad.Computadora, Necesidad.Computadora,
                                        Necesidad.Telefono, Necesidad.Telefono, Necesidad.Computadora, Necesidad.Telefono, 
                                        Necesidad.Telefono, Necesidad.Computadora, Necesidad.Computadora, Necesidad.Computadora,
                                        Necesidad.Computadora, Necesidad.Computadora, Necesidad.Computadora};

            for(int i=0;i<15;i++)
            {
                Cliente cliente = new Cliente(nombres[i], apellidos[i], necesidades[i], dni[i], edades[i]);
                cola.Enqueue(cliente);
            }
            return cola;
        }
        
        public void AsignarDispositivo(Dispositivo dispositivo)
        {
            this.dispositivoAsignado = dispositivo;
            this.horaInicio = DateTime.Now;
            dispositivo.CambiarEstado();
            dispositivo.Cliente = this;
            if(dispositivo.GetType() == typeof(Telefono))
            {
                Telefono tel = dispositivo as Telefono;
                tel.Llamada = Llamada.GenerarLlamada();
            }
        }

        private void GenerarSoftwareNecesario()
        {
            this.softwareNecesario = Software.ObtenerSoftware();
        }

        private void GenerarPerifericoNecesario()
        {
            this.perifericoNecesario = Periferico.ObtenerPeriferico();
        }

        internal static Cliente GenerarCliente()
        {
            return new Cliente(GenerarNombre(), GenerarApellido(), GenerarNecesidad(), GenerarDni(), GenerarEdad());
        }

        internal static Cliente GenerarCliente(DateTime horaInicio)
        {
            Cliente cliente = GenerarCliente();
            cliente.horaInicio = horaInicio;
            return cliente;
        }

        internal static Cliente GenerarCliente(DateTime horaInicio, string software)
        {
            Cliente cliente = GenerarCliente(horaInicio);
            if(software is not null && software != string.Empty)
            {
                cliente.softwareNecesario = software;
            }
            return cliente;
        }

        internal static Cliente GenerarCliente(DateTime horaInicio, string software, string periferico)
        {
            Cliente cliente = GenerarCliente(horaInicio, software);
            if (periferico is not null && periferico != string.Empty)
            {
                cliente.perifericoNecesario = periferico;
            }
            return cliente;
        }

        internal static DateTime GenerarFechaAleatoria()
        {
                DateTime inicio = new DateTime(2021, 08, 17,16,45,23);
                int rango = (DateTime.Today - inicio).Minutes;
                return inicio.AddMinutes(GeneradorNumero.Generar(0, rango));
        }

        private static string GenerarNombre()
        {
            return Persona.ObtenerNombre(GeneradorNumero.Generar(0, Persona.Nombres));
        }

        private static string GenerarApellido()
        {
            return Persona.ObtenerApellido(GeneradorNumero.Generar(0, Persona.Apellidos));
        }

        internal static int GenerarDni()
        {
            return GeneradorNumero.Generar(15000000, 50000000);
        }

        private static int GenerarEdad()
        {
            return GeneradorNumero.Generar(15, 75);
        }

        private static Necesidad GenerarNecesidad()
        {
            return (Necesidad)GeneradorNumero.Generar(0, 2);
        }

        public static bool operator ==(Cliente c, Dispositivo d)
        {
            Computadora pc = d as Computadora;
            if(pc is not null && (  pc.Software.Contains<string>(c.softwareNecesario) || 
                                    pc.Juegos.Contains<string>(c.softwareNecesario)) && 
                                    pc.Perifericos.Contains<string>(c.perifericoNecesario))
            {
                return true; 
            }
            return false;
        }

        public static bool operator !=(Cliente c, Dispositivo d)
        {
            return !(c == d);
        }

    }
}

