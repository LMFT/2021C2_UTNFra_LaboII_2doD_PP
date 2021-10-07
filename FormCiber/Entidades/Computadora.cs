using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneradorNumeros;
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
        public Computadora(string id, List<string> perifericos, Dictionary<string, string> especificaciones) : base(id)
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


        public override string MostrarDispositivo()
        {
            StringBuilder pcStr = new StringBuilder();
            pcStr.AppendLine($"ID Dispositivo: {Id}\n");
            pcStr.AppendLine($"Perifericos: {Coleccion.ObtenerElementosLista(perifericos)}");
            pcStr.AppendLine($"Software: {Coleccion.ObtenerElementosLista(software)}");
            pcStr.AppendLine($"Juegos: {Coleccion.ObtenerElementosLista(juegos)}");
            pcStr.AppendLine($"Estado: {Estado}");
            pcStr.AppendLine($"\n\nEspecificaciones: {Coleccion.ObtenerElementosDiccionario(especificaciones)}");
            return pcStr.ToString();
        }

        private static string GenerarId()
        {
            return String.Format("C{0:00}", ++ultimoId);
        }

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
            List<string>[] listadoJuegos = new List<string>[] {         new List<string> { "GTA Vice City", "Warcraft 3", "Counter-strike"},
                                                                        new List<string> { "Counter Strike", "Age of Empires II",},
                                                                        new List<string> {"Diablo II", "MU Online", "Lineage II"},
                                                                        new List<string> (),
                                                                        new List<string> { "Office"},
                                                                        new List<string>(),
                                                                        new List<string> { "MU Online", "Lineage II"},
                                                                        new List<string> (),
                                                                        new List<string> { "Counter-Strike", "Diablo II", "GTA Vice City"},
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

        private static Dictionary<string, string> GenerarEspecificaciones()
        {
            Dictionary<string, string> especificaciones = new Dictionary<string, string>();
            string[] procesador = new string[] { "Pentium II", "Pentium III", "Pentium 4" };
            string[] placaBase = new string[] { "Abit VP6", "Iwill PIILD P2LD", "Asus P4T" };
            string[] ram = new string[] { "Nanya 256 MB DDR RAM PC-3200 184-pin DIMM", "acp-ep memoria 512 MB PC133 168-pin", "DELL Dimension 8100 PC800 RDRAM 1 GB" };
            string[] placaVideo = new string[] { "Voodoo I", "nVidia Riva", "GeForce 256" };

            especificaciones.Add("Procesador", procesador[GeneradorNumeros.GeneradorNumero.Generar(0, 3)]);
            especificaciones.Add("Placa base", placaBase[GeneradorNumeros.GeneradorNumero.Generar(0, 3)]);
            especificaciones.Add("Memoria RAM", ram[GeneradorNumeros.GeneradorNumero.Generar(0, 3)]);
            especificaciones.Add("Placa de video", placaVideo[GeneradorNumeros.GeneradorNumero.Generar(0, 3)]);

            return especificaciones;
        }

    }
}
