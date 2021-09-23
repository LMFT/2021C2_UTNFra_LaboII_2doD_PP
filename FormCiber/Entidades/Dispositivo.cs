using System;

namespace Cibercontrol
{
    public abstract class Dispositivo
    {
        private string id;

        protected abstract void SetearId();

        protected string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        
    }
}
