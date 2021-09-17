using System;
using System.Collections.Generic;
using Dispositivos;

namespace Dispositivos.Computadora
{
    public enum TipoPrograma {Software, Juego}
    public static class Biblioteca
    {
        static Dictionary<string, TipoPrograma> biblioteca;

        public static void GenerarBiblioteca()
        {
            string[] software = {"ICQ", "Ares", "Office", "Messenger", "Winamp"};
            string[] juegos = {"Counter Strike", "Diablo 2", "Warcraft 3", "Mu Online", "Lineage 2", "Age of Empires 2", "GTA Vice City"};
            
            foreach(string item in software)
            {
                biblioteca.Add(item, TipoPrograma.Software);
            }

            foreach(string item in juegos)
            {
                biblioteca.Add(item, TipoPrograma.Juego);
            }
        }

        public static Dictionary<string, TipoPrograma> ObtenerProgramas(int cantidad, TipoPrograma tipo)
        {
            List<string> listado = FiltrarBiblioteca(tipo);
            Dictionary<string, TipoPrograma> softwareInstalado = new Dictionary<string, TipoPrograma>();
            Random rng = new Random();
            if(cantidad<=listado.Count)
            {
                int i = 0;
                while(i<cantidad)
                {
                    int indiceSoftware = rng.Next(0, listado.Count);
                    string software = listado[indiceSoftware];
                    if(!softwareInstalado.ContainsKey(software))
                    {
                        softwareInstalado.Add(software, tipo);
                        i++;
                    }
                }
            }
            return softwareInstalado;
        }

        private static List<string> FiltrarBiblioteca(TipoPrograma tipo)
        {
            List<string> listado = new List<string>();
            foreach(KeyValuePair<string, TipoPrograma>item in biblioteca)
            {
                if(item.Value == tipo)
                {
                    listado.Add(item.Key);
                }
            }
            return listado;
        }
    }

    public class Computadora : Dispositivo
    {
        Dictionary<string, TipoPrograma> softwareInstalado;
        List<string> perifericos;
        Dictionary<string, string> especificaciones;

        
        public Computadora(Dictionary<string, string> especificaciones, List<string> perifericos, Dictionary<string, string> software,
            string id, Estado estado, double costoFraccion): base(id, estado, costoFraccion)
        {
            this.SoftwareInstalado = software;
            this.Especificaciones = especificaciones;
            this.Perifericos = perifericos;
        }

        public Dictionary<string, string> SoftwareInstalado { get => softwareInstalado; set => softwareInstalado = value; }
        public List<string> Perifericos { get => perifericos; set => perifericos = value; }
        public Dictionary<string, string> Especificaciones { get => especificaciones; set => especificaciones = value; }
    }
}
