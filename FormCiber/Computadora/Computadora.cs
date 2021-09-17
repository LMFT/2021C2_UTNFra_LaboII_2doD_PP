using System;
using System.Collections.Generic;
namespace Dispositivos.Computadora
{
    public static class Biblioteca
    {
        static List<string> biblioteca;


    }
    
    public class Computadora
    {
        List<string> software;
        List<string> juegos;
        List<string> perifericos;
        Dictionary<string, string> especificaciones;

        public List<string> Software { get => software; set => software = value; }
        public List<string> Juegos { get => juegos; set => juegos = value; }
        public List<string> Perifericos { get => perifericos; set => perifericos = value; }
        public Dictionary<string, string> Especificaciones { get => especificaciones; set => especificaciones = value; }
    }
}
