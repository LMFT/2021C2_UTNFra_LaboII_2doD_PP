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

        public Computadora(List<string> software, List<string> perifericos, List<string> juegos, List<string> especificaciones)
        {

        }

        protected List<string> Software
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
    }
}
