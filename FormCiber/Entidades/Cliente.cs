using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;
using Elementos;

namespace Entidades
{
    public class Cliente
    {
        private int dni;
        private int edad;
        private string apellido;
        private string nombre;
        private string perifericoNecesario;
        private string softwareNecesario;
        Necesidad necesidad;
        Dispositivo dispositivoAsignado;
        private DateTime horaInicio;
        private DateTime horaFinalizacion;

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
        internal Dispositivo Dispositivo
        {
            get
            {
                return dispositivoAsignado;
            }
            set
            {
                dispositivoAsignado = value;
            }
        }

        internal string SoftwareNecesario
        {
            get
            {
                return softwareNecesario;
            }
            set
            {
                if(value is not null && value != string.Empty)
                {
                    softwareNecesario = value;
                }
            }
        }

        internal string PerifericoNecesario
        {
            get
            {
                return perifericoNecesario;
            }
            set
            {
                if(value is not null && value != string.Empty)
                {
                    perifericoNecesario = value;
                }
            }
        }

        public DateTime HoraFinalizacion
        {
            get
            {
                return horaFinalizacion;
            }
        }
        /// <summary>
        /// Setea la hora de finalizacion del dispositivo
        /// </summary>
        /// <param name="horaFinalizacion">Valor de la hora de finalizacion a setear</param>
        public void SetHoraFinalizacion(DateTime horaFinalizacion)
        {
            this.horaFinalizacion = horaFinalizacion;
        }
        /// <summary>
        /// Establece un criterio de igualdad para dos clientes en base a su numero de DNI
        /// </summary>
        /// <param name="c1">Primer cliente</param>
        /// <param name="c2">Segundo cliente</param>
        /// <returns>Retorna true si los numeros de DNI coinciden, de lo contrario false</returns>
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.dni == c2.dni;
        }
        /// <summary>
        /// Establece un criterio de desigualdad para dos clientes en base a su numero de DNI
        /// </summary>
        /// <param name="c1">Primer cliente</param>
        /// <param name="c2">Segundo cliente</param>
        /// <returns>Retorna false si los numeros de DNI coinciden, de lo contrario true</returns>
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
        /// <summary>
        /// Establece un criterio de igualdad para un cliente y una queue de clientes, analizando si el mismo se encuentra en la queue
        /// </summary>
        /// <param name="cliente">Cliente a analizar si se encuentra en cola</param>
        /// <param name="cola">Cola de clientes</param>
        /// <returns>Retornará true si el cliente se encuentra en la queue, de lo contrario false</returns>
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
        /// <summary>
        /// Establece un criterio de desigualdad para un cliente y una queue de clientes, analizando si el mismo se encuentra en la queue
        /// </summary>
        /// <param name="cliente">Cliente a analizar si se encuentra en cola</param>
        /// <param name="cola">Cola de clientes</param>
        /// <returns>Retornará false si el cliente se encuentra en la queue, de lo contrario true</returns>
        public static bool operator !=(Cliente cliente, Queue<Cliente> cola)
        {
            return !(cliente == cola);
        }
        /// <summary>
        /// Establece un criterio de desigualdad para un cliente y una computadora, verificando si la misma posee o no el software/juego
        /// necesario para el cliente, asi como cualquier periferico necesario
        /// </summary>
        /// <param name="cliente">Cliente a analizar</param>
        /// <param name="cola">Computadora a analizar</param>
        /// <returns>Retornará false si la computadora cuenta con los requisitos del cliente, de lo contrario true</returns>
        public static bool operator !=(Cliente cliente, Computadora pc)
        {
            return !(cliente == pc);
        }
        /// <summary>
        /// Establece un criterio de igualdad para un cliente y una computadora, verificando si la misma posee o no el software/juego
        /// necesario para el cliente, asi como cualquier periferico necesario
        /// </summary>
        /// <param name="cliente">Cliente a analizar</param>
        /// <param name="cola">Computadora a analizar</param>
        /// <returns>Retornará true si la computadora cuenta con los requisitos del cliente, de lo contrario false</returns>
        public static bool operator ==(Cliente cliente, Computadora pc)
        {
            if((pc.Juegos.Contains<string>(cliente.softwareNecesario) || pc.Software.Contains<string>(cliente.softwareNecesario)) &&
                pc.Perifericos.Contains<string>(cliente.perifericoNecesario))
            {
                return true;
            }
            return false;
        }


        public static Queue<Cliente> operator +(Cliente cliente, Queue<Cliente> cola)
        {
            if(cliente != cola)
            {
                cola.Enqueue(cliente);
            }
            return cola;
        }

        public static Queue<Cliente> operator +(Queue<Cliente> cola, Cliente cliente)
        {
            return cliente + cola;
        }

        public static bool operator ==(Cliente c, Dispositivo d)
        {
            Telefono t = d as Telefono;
            Computadora pc = d as Computadora;
            return (t is not null && c.Necesidad == Necesidad.Telefono) || (pc is not null && c == pc);
        }

        public static bool operator !=(Cliente c, Dispositivo d)
        {
            return !(c == d);
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
        
        public void AsignarDispositivo(Dispositivo dispositivo, DateTime horaInicio)
        {
            this.dispositivoAsignado = dispositivo;
            this.horaInicio = horaInicio;
            dispositivo.CambiarEstado();
            dispositivo.Cliente = this;
            if(dispositivo.GetType() == typeof(Telefono))
            {
                Telefono tel = dispositivo as Telefono;
                tel.Llamada = Llamada.GenerarLlamada();
            }
        }

        public void AsignarDispositivo(Dispositivo dispositivo)
        {
            AsignarDispositivo(dispositivo, DateTime.Now);
        }

        internal void AsignarDispositivo(string id)
        {
            Dispositivo dispositivo = Cibercafe.ObtenerDispositivo(id);
            this.dispositivoAsignado = dispositivo;
            
            if (dispositivo.GetType() == typeof(Telefono))
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
            Cliente c = new Cliente(GenerarNombre(), GenerarApellido(), GenerarNecesidad(), GenerarDni(), GenerarEdad());
            c.GenerarSoftwareYPerifericos();
            return c;
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

        internal static Cliente GenerarCliente( string software)
        {
            Cliente cliente = GenerarCliente();
            if (software is not null && software != string.Empty)
            {
                cliente.softwareNecesario = software;
            }
            return cliente;
        }

        internal static Cliente GenerarCliente(string software, string periferico)
        {
            Cliente cliente = GenerarCliente(software);
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
                return inicio.AddMinutes(Utilidades.GeneradorNumero.Generar(0, rango));
        }

        private static string GenerarNombre()
        {
            return Persona.ObtenerNombre(Utilidades.GeneradorNumero.Generar(0, Persona.Nombres));
        }

        private static string GenerarApellido()
        {
            return Persona.ObtenerApellido(Utilidades.GeneradorNumero.Generar(0, Persona.Apellidos));
        }

        internal static int GenerarDni()
        {
            return Utilidades.GeneradorNumero.Generar(15000000, 50000000);
        }

        private static int GenerarEdad()
        {
            return Utilidades.GeneradorNumero.Generar(15, 75);
        }

        private static Necesidad GenerarNecesidad()
        {
            return (Necesidad)Utilidades.GeneradorNumero.Generar(0, 2);
        }

        public string GetSoftwareNecesario()
        {
            return softwareNecesario;
        }

        public string GetPerifericoNecesario()
        {
            return perifericoNecesario;
        }

        public Dispositivo GetDispositivo()
        {
            return dispositivoAsignado;
        }

        public double TiempoUso()
        {
            return (horaFinalizacion - horaInicio).TotalSeconds;
        }

        public double TiempoRestante()
        {
            return (horaFinalizacion - DateTime.Now).TotalSeconds;
        }

        internal void GenerarSoftwareYPerifericos()
        {
            if (Necesidad == Necesidad.Computadora)
            {
                SoftwareNecesario = Software.ObtenerSoftware();
                PerifericoNecesario = Periferico.ObtenerPeriferico();
            }
        }

    }
}

