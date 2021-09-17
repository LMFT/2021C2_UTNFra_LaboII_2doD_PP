using System;
using System.Collections.Generic;
using Dispositivos;

namespace Dispositivos.Computadora
{
    public static class Biblioteca
    {
        static Dictionary<string, string> biblioteca;

        
    }

    public class Computadora : Dispositivo
    {
        List<string> softwareInstalado;
        List<string> perifericos;
        Dictionary<string, string> especificaciones;

        
        public Computadora(Dictionary<string, string> especificaciones, List<string> perifericos, List<string> software, string id
            , Estado estado, double costoFraccion): base(id, estado, costoFraccion)
        {
            this.SoftwareInstalado = software;
            this.Especificaciones = especificaciones;
            this.Perifericos = perifericos;
        }

        public List<string> SoftwareInstalado { get => softwareInstalado; set => softwareInstalado = value; }
        public List<string> Perifericos { get => perifericos; set => perifericos = value; }
        public Dictionary<string, string> Especificaciones { get => especificaciones; set => especificaciones = value; }
    }
}
