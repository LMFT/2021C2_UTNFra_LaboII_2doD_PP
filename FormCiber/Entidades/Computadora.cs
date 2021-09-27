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
        public static Random rng = new Random(0);
        private List<string> software; //(office, messenger, icq, ares).
        private List<string> perifericos; //(cámara, auriculares, micrófono).
        private List<string> juegos; //(Counter Strike, Diablo II, Mu Online, Lineage II, Warcraft III, Age of Empires II)
        private Dictionary<string, string> especificaciones; //(procesador, ram, placa de video, etc).*/
        static private int siguienteId = 1;
        public Computadora(List<string> software, List<string> perifericos, List<string> juegos, Dictionary<string, string> especificaciones)
        {
            this.Id = String.Format("C{0:00}", siguienteId++);
            this.Software = software;
            this.Perifericos = perifericos;
            this.Juegos = juegos;
            this.Especificaciones = especificaciones;
            this.Estado = Estado.Libre;
        }

        internal List<string> Software
        {
            get
            {
                return software;
            }
            set
            {
                if(value is not null)
                {
                    software = value;
                }
            }
        }

        internal List<string> Perifericos
        {
            get
            {
                return perifericos;
            }
            set
            {
                if(value is not null)
                {
                    perifericos = value;
                }
            }
        }

        internal List<string> Juegos
        {
            get
            {
                return juegos;
            }
            set
            {
                if (value is not null)
                {
                    juegos = value;
                }
            }
        }

        internal Dictionary<string, string> Especificaciones
        {
            get
            {
                return especificaciones;
            }
            set
            {
                if (value is not null)
                {
                    especificaciones = value;
                }
            }
        }

        public static void HardcodearComputadoras(List<Dispositivo> lista)
        {
            List<string> software = new List<string> { "Office", "Messenger", "ICQ", "Ares" }; 
            List<string> perifericos = new List<string> {"Cámara", "Auriculares", "Micrófono"}; 
            List<string> juegos = new List<string> { "Counter-Strike", "Diablo II", "MU Online", "Lineage II", "Age of Empires II"};
            
            for(int i=0;i<10;i++)
            {
                Computadora computadora = new Computadora(GeneradorNumero.SeleccionAleatoria(software, GeneradorNumero.Generar(0, software.Count)),
                                                            GeneradorNumero.SeleccionAleatoria(perifericos, GeneradorNumero.Generar(0, perifericos.Count)),
                                                            GeneradorNumero.SeleccionAleatoria(juegos, GeneradorNumero.Generar(0, juegos.Count)),
                                                            GenerarEspecificaciones());
                lista.Add(computadora);
            }
        }

        private static Dictionary<string, string> GenerarEspecificaciones()
        {
            Dictionary<string, string> especificaciones = new Dictionary<string, string>();
            string[] procesador = new string[]{"Pentium II", "Pentium III", "Pentium 4"};
            string[] placaBase = new string[] { "Abit VP6", "Iwill PIILD P2LD", "Asus P4T" };
            string[] ram = new string[] {"Nanya 256 MB DDR RAM PC-3200 184-pin DIMM","acp-ep memoria 512 MB PC133 168-pin","DELL Dimension 8100 PC800 RDRAM 1 GB" };
            string[] placaVideo = new string[] { "Voodoo I", "nVidia Riva", "GeForce 256"};
            
            especificaciones.Add("Procesador", procesador[GeneradorNumeros.GeneradorNumero.Generar(0,3)]);
            especificaciones.Add("Placa base", placaBase[GeneradorNumeros.GeneradorNumero.Generar(0,3)]);
            especificaciones.Add("Memoria RAM", ram[GeneradorNumeros.GeneradorNumero.Generar(0,3)]);
            especificaciones.Add("Placa de video", placaVideo[GeneradorNumeros.GeneradorNumero.Generar(0,3)]);
            
            return especificaciones;
        }

        public override string MostrarDispositivo()
        {
            StringBuilder informacion = new StringBuilder();

            informacion.AppendLine($"ID Dispositivo: {this.Id}\n");
            informacion.AppendLine($"Estado: {this.Estado}\n");
            informacion.AppendLine($"Perifericos: {Coleccion.ObtenerElementosLista(this.Perifericos)}\n");
            informacion.AppendLine($"Software instalado: {Coleccion.ObtenerElementosLista(this.Software)}\n");
            informacion.AppendLine($"Juegos instalados: {Coleccion.ObtenerElementosLista(this.Juegos)}\n");
            return informacion.ToString();
        }

        public List<string> ObtenerSoftware()
        {
            return this.Software;
        }

        public List<string> ObtenerJuegos()
        {
            return this.Juegos;
        }
    }
}
