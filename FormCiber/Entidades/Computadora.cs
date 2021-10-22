using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;
using Colecciones;

namespace Entidades
{
    public class Computadora : Dispositivo
    {
        private List<string> software;
        private List<string> perifericos;
        private List<string> juegos;
        private Dictionary<string, string> especificaciones;
        private static int ultimoId;

        static Computadora()
        {
            ultimoId = 0;
        }
        public Computadora(string id, List<string> perifericos, Dictionary<string, string> especificaciones) : base(id, 30)
        {
            this.perifericos = perifericos;
            this.especificaciones = especificaciones;
        }
        public Computadora(string id, List<string> perifericos, List<string> software, Dictionary<string, string> especificaciones)
            : this(id, perifericos, especificaciones)
        {
            this.software = software;
        }
        public Computadora(List<string> perifericos, string id, List<string> juegos, Dictionary<string, string> especificaciones) :
            this(id, perifericos, especificaciones)
        {
            this.juegos = juegos;
        }
        public Computadora(string id, List<string> software, List<string> perifericos, List<string> juegos,
                          Dictionary<string, string> especificaciones) : this(id, perifericos, software, especificaciones)
        {
            this.juegos = juegos;
        }

        public List<string> Software
        {
            get
            {
                return software;
            }
        }

        internal List<string> Juegos
        {
            get
            {
                return juegos;
            }
        }

        internal List<string> Perifericos
        {
            get
            {
                return perifericos;
            }
        }
        /// <summary>
        /// Muestra informacion sobre una computadora
        /// </summary>
        /// <returns>Un string que contiene infrmacion sobre una computadora determinada</returns>
        public override string MostrarDispositivo()
        {
            StringBuilder pcStr = new StringBuilder();
            pcStr.AppendLine($"ID Dispositivo: {Id}\n");
            pcStr.AppendLine($"Perifericos: {Coleccion.MostrarLista(perifericos)}");
            pcStr.AppendLine($"Software: {Coleccion.MostrarLista(software)}");
            pcStr.AppendLine($"Juegos: {Coleccion.MostrarLista(juegos)}");
            pcStr.AppendLine($"Estado: {Estado}");
            pcStr.AppendLine($"\nEspecificaciones: {Coleccion.MostrarDiccionario(especificaciones)}");
            return pcStr.ToString();
        }
        /// <summary>
        /// Genera un ID autoincremental y lo retorna
        /// </summary>
        /// <returns>Nuevo ID autoincremental</returns>
        private static string GenerarId()
        {
            return String.Format("C{0:00}", ++ultimoId);
        }
        /// <summary>
        /// Instancia y añade computadoras hardcodeadas al liostado de dispositivos pasado como parametro
        /// </summary>
        /// <param name="listado">Listado al cual añadir las nuevas computadoras</param>
        internal static void HardcodearComputadoras(List<Dispositivo> listado)
        {
            #region Listado Software
            /* "Office", "Messenger", "ICQ", "Ares", "eMule", */
            List<string>[] listadoSoftware = new List<string>[] {       new List<string> { "Office", "Ares"},
                                                                        new List<string> { "Messenger", "eMule", "Office"},
                                                                        new List<string> (),
                                                                        new List<string> { "Office", "Ares", "Messenger"},
                                                                        new List<string>(), 
                                                                        new List<string> { "Office"},
                                                                        new List<string> { "ICQ", "Messenger", "Office"},
                                                                        new List<string> { "Office", "Ares", "ICQ"},
                                                                        new List<string> { "eMule", "Ares"},
                                                                        new List<string> ()};
            #endregion
            #region Listado Perifericos
            /*"Cámara", "Auriculares", "Micrófono"*/
            List<string>[] listadoPerifericos = new List<string>[] {    new List<string> { "Auriculares", "Microfono"},
                                                                        new List<string> { "Auriculares"},
                                                                        new List<string> {"Auriculares", "Microfono" },
                                                                        new List<string> { "Camara"},
                                                                        new List<string>{"Auriculares", "Microfono"}, 
                                                                        new List<string> { "Camara"},
                                                                        new List<string> { "Camara", "Microfono", "Auriculares"},
                                                                        new List<string> {"Auriculares"},
                                                                        new List<string> { "Camara", "Microfono"},
                                                                        new List<string> {"Auriculares"} };
            #endregion
            #region Listado Juegos
            /* "Counter-Strike", "Diablo II", "MU Online","Lineage II", "Age of Empires II", "GTA VIce CIty", "Starcraft"*/
            List<string>[] listadoJuegos = new List<string>[] {         new List<string> { "GTA Vice City", "Warcraft 3", "Counter Strike"},
                                                                        new List<string> { "Counter Strike", "Age of Empires II", "MU Online"},
                                                                        new List<string> {"Diablo II", "MU Online", "Lineage II", "Starcraft"},
                                                                        new List<string> {"Starcraft" },
                                                                        new List<string> { "Mu Online", "GTA VIce City"},
                                                                        new List<string> { "Counter Strike","Starcraft"},
                                                                        new List<string> { "MU Online", "Lineage II"},
                                                                        new List<string> {"MU Online", "Lineage II" },
                                                                        new List<string> { "Counter Strike", "Diablo II", "GTA Vice City"},
                                                                        new List<string> { "Starcraft", "Age of Empires II", "Diablo II"}};
            #endregion
            if (listado is not null)
            {
                for(int i=0;i<10;i++)
                {
                    Computadora pc = new Computadora(GenerarId(), listadoSoftware[i], listadoPerifericos[i],listadoJuegos[i], 
                                        GenerarEspecificaciones());
                    listado.Add(pc);
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static Dictionary<string, string> GenerarEspecificaciones()
        {
            Dictionary<string, string> especificaciones = new Dictionary<string, string>();
            #region Listados de componentes
            string[] procesador = new string[] { "Pentium II", "Pentium III", "Pentium 4" };
            string[] placaBase = new string[] { "Abit VP6", "Iwill PIILD P2LD", "Asus P4T" };
            string[] ram = new string[] { "Nanya 256 MB DDR RAM PC-3200 184-pin DIMM", "acp-ep memoria 512 MB PC133 168-pin", "DELL Dimension 8100 PC800 RDRAM 1 GB" };
            string[] placaVideo = new string[] { "Voodoo I", "nVidia Riva", "GeForce 256" };
            #endregion
            especificaciones.Add("Procesador", procesador[Utilidades.GeneradorNumero.Generar(0, 3)]);
            especificaciones.Add("Placa base", placaBase[Utilidades.GeneradorNumero.Generar(0, 3)]);
            especificaciones.Add("Memoria RAM", ram[Utilidades.GeneradorNumero.Generar(0, 3)]);
            especificaciones.Add("Placa de video", placaVideo[Utilidades.GeneradorNumero.Generar(0, 3)]);

            return especificaciones;
        }
    }
}
