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
        /// <summary>
        /// Añade al cliente recibido como parametro a la queue recibida como parametro en caso de que la última no lo contenga
        /// </summary>
        /// <param name="cliente">Cliente a añadir</param>
        /// <param name="cola">Queue de clientes</param>
        /// <returns>Queue con el cliente añadido</returns>
        public static Queue<Cliente> operator +(Cliente cliente, Queue<Cliente> cola)
        {
            if(cliente != cola)
            {
                cola.Enqueue(cliente);
            }
            return cola;
        }
        /// <summary>
        /// Añade al cliente recibido como parametro a la queue recibida como parametro en caso de que la última no lo contenga
        /// </summary>
        /// <param name="cliente">Cliente a añadir</param>
        /// <param name="cola">Queue de clientes</param>
        /// <returns>Queue con el cliente añadido</returns>
        public static Queue<Cliente> operator +(Queue<Cliente> cola, Cliente cliente)
        {
            return cliente + cola;
        }
        /// <summary>
        /// Verifica que el tipo de dispositivo sea compatible con la necesidad del cliente 
        /// </summary>
        /// <param name="c">Cliente</param>
        /// <param name="d">Dispositivo</param>
        /// <returns>Retornara true si el tipo de dispositivo coincide con la necesidad del cliente, de lo contrario false</returns>
        public static bool operator ==(Cliente c, Dispositivo d)
        {
            Telefono t = d as Telefono;
            Computadora pc = d as Computadora;
            return (t is not null && c.Necesidad == Necesidad.Telefono) || (pc is not null && c == pc);
        }
        /// <summary>
        /// Verifica que el tipo de dispositivo sea compatible con la necesidad del cliente 
        /// </summary>
        /// <param name="c">Cliente</param>
        /// <param name="d">Dispositivo</param>
        /// <returns>Retornara false si el tipo de dispositivo coincide con la necesidad del cliente, de lo contrario true</returns>
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
        /// <summary>
        /// Retorna la informacion del cliente formateada como string
        /// </summary>
        /// <returns>Retorna la informacion del cliente en formato string</returns>
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
        /// <summary>
        /// Crea una queue de clientes y la hardcodea con 15 clientes iniciales
        /// </summary>
        /// <returns>Queue de clientes hardcodeada</returns>
        public static Queue<Cliente> HardcodearClientes()
        {
            Queue<Cliente> cola = new Queue<Cliente>();
            #region Datos hardcodeados de clientes
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
            #endregion
            for (int i=0;i<15;i++)
            {
                Cliente cliente = new Cliente(nombres[i], apellidos[i], necesidades[i], dni[i], edades[i]);
                cola.Enqueue(cliente);
            }
            return cola;
        }
        /// <summary>
        /// Asigna el dispositivo recibido como parametro a la instancia actual de cliente, y setea la hora de inicio de uso
        /// al valor recibido como parametro
        /// </summary>
        /// <param name="dispositivo">Dispositivo a asignar al cliente</param>
        /// <param name="horaInicio">Hora de inicio de uso del dispositivo</param>
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
        /// <summary>
        /// Asigna el dispositivo recibido como parametro a la instancia actual de cliente y setea su hora de inicio de uso
        /// a la hora actual
        /// </summary>
        /// <param name="dispositivo">Dispositivo a asignar</param>
        public void AsignarDispositivo(Dispositivo dispositivo)
        {
            AsignarDispositivo(dispositivo, DateTime.Now);
        }
        /// <summary>
        /// Selecciona aleatoriamente un software o videojuego, el cual se asigna al atributo softwareNecesario
        /// </summary>
        private void GenerarSoftwareNecesario()
        {
            this.softwareNecesario = Software.ObtenerSoftware();
        }
        /// <summary>
        /// Selecciona aleatoriamente un periferico, el cual se asigna al atributo perifericoNecesario
        /// </summary>
        private void GenerarPerifericoNecesario()
        {
            this.perifericoNecesario = Periferico.ObtenerPeriferico();
        }
        /// <summary>
        /// Genera un cliente nuevo, utilizando valores precargados seleccionados aleatoriamente
        /// </summary>
        /// <returns>Nueva instancia de cliente con valores asignados de forma aleatoria</returns>
        internal static Cliente GenerarCliente()
        {
            Cliente c = new Cliente(GenerarNombre(), GenerarApellido(), GenerarNecesidad(), GenerarDni(), GenerarEdad());
            c.GenerarSoftwareYPerifericos();
            return c;
        }
        /// <summary>
        /// Genera un cliente nuevo, utilizando valores precargados seleccionados aleatoriamente
        /// </summary>
        /// <param name="horaInicio">Hora de inicio de uso del programa</param>
        /// <returns>Nueva instancia de cliente con valores asignados de forma aleatoria</returns>
        internal static Cliente GenerarCliente(DateTime horaInicio)
        {
            Cliente cliente = GenerarCliente();
            cliente.horaInicio = horaInicio;
            return cliente;
        }
        /// <summary>
        /// Selecciona un nombre aleatorio del listado y lo retorna
        /// </summary>
        /// <returns>Nombre seleccionado aleatoriamente</returns>
        private static string GenerarNombre()
        {
            return Persona.ObtenerNombre(Utilidades.GeneradorNumero.Generar(0, Persona.Nombres));
        }
        /// <summary>
        /// Selecciona un apellido aleatorio del listado y lo retorna
        /// </summary>
        /// <returns>Apellido seleccionado aleatoriamente</returns>
        private static string GenerarApellido()
        {
            return Persona.ObtenerApellido(Utilidades.GeneradorNumero.Generar(0, Persona.Apellidos));
        }
        /// <summary>
        /// Selecciona un numero de documento aleatorio y lo retorna
        /// </summary>
        /// <returns>DNI seleccionado aleatoriamente</returns>
        internal static int GenerarDni()
        {
            return Utilidades.GeneradorNumero.Generar(15000000, 50000000);
        }
        /// <summary>
        /// Selecciona una edad aleatoria y la retorna
        /// </summary>
        /// <returns>Edad generada aleatoriamente</returns>
        private static int GenerarEdad()
        {
            return Utilidades.GeneradorNumero.Generar(15, 75);
        }
        /// <summary>
        /// Genera de forma aleatoria la necesidad actual del cliente
        /// </summary>
        /// <returns>Necesidad generada aleatoriamente</returns>
        private static Necesidad GenerarNecesidad()
        {
            return (Necesidad)Utilidades.GeneradorNumero.Generar(0, 2);
        }
        /// <summary>
        /// Retorna el atributo softwareNecesario de la instancia actual de clientes
        /// </summary>
        /// <returns>Software necesario por el cliente</returns>
        public string GetSoftwareNecesario()
        {
            return softwareNecesario;
        }
        /// <summary>
        /// Retorna el atributo perifericoNecesario de la instancia actual de clientes
        /// </summary>
        /// <returns>Periferico necesario por el cliente</returns>
        public string GetPerifericoNecesario()
        {
            return perifericoNecesario;
        }
        /// <summary>
        /// Retorna el atributo dispositivoAsignado de la instancia actual de cliente
        /// </summary>
        /// <returns>Dispositivo asignado al cliente</returns>
        public Dispositivo GetDispositivo()
        {
            return dispositivoAsignado;
        }
        /// <summary>
        /// Calcula el tiempo de uso total del dispositivo asignado
        /// </summary>
        /// <returns>Tiempo de uso del dispositivo asignado, expresado en segundos totales</returns>
        public double TiempoUso()
        {
            return (horaFinalizacion - horaInicio).TotalSeconds;
        }
        /// <summary>
        /// Calcula el tiempo restante de uso del dispositivo 
        /// </summary>
        /// <returns>Tiempo de uso restante</returns>
        public double TiempoRestante()
        {
            return (horaFinalizacion - DateTime.Now).TotalSeconds;
        }
        /// <summary>
        /// Valida que la instancia actual de cliente tenga necesidad de una computadora y, de ser asi, selecciona aleatoriamente
        /// un software/videojuego del listado, asi como un periferico
        /// </summary>
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

