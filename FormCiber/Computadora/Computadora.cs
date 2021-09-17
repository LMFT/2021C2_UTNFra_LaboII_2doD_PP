using System;
using System.Collections.Generic;
using Dispositivos;

namespace Dispositivos.Computadora
{
    public static class Biblioteca
    {
        static Dictionary<string, string> biblioteca;

        public static void GenerarBiblioteca()
        {
            string[] software = {"ICQ", "Ares", "Office", "Messenger", "Winamp"};
            string[] juegos = {"Counter Strike", "Diablo 2", "Warcraft 3", "Mu Online", "Lineage 2", "Age of Empires 2", "GTA Vice City"};
            
            foreach(string item in software)
            {
                biblioteca.Add(item, "software");
            }
            foreach(string item in juegos)
            {
                biblioteca.Add(item, "juego");
            }
        }

        
    }

    public class Computadora : Dispositivo
    {
        Dictionary<string, string> softwareInstalado;
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
