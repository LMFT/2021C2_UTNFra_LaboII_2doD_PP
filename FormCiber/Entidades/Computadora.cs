using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibercontrol
{
    public class Computadora : Dispositivo
    {
        private List<string> software; //(office, messenger, icq, ares).
        private List<string> perifericos; //(cámara, auriculares, micrófono).
        private List<string> juegos; //(Counter Strike, Diablo II, Mu Online, Lineage II, Warcraft III, Age of Empires II)
        private List<string> especificaciones; //(procesador, ram, placa de video, etc).*/
        static private int siguienteId = 1;
        public Computadora(List<string> software, List<string> perifericos, List<string> juegos, List<string> especificaciones)
        {
            SetearId();
            this.software = software;
            this.perifericos = perifericos;
            this.juegos = juegos;
            this.especificaciones = especificaciones;
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

        internal List<string> Especificaciones
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

        protected override void SetearId()
        {
            base.Id = String.Format("T{0:00}", siguienteId);
            siguienteId++;
        }
    }
}
