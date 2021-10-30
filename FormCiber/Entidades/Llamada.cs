using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace Entidades
{
    /// <summary>
    /// Contiene datos sobre una llamada
    /// </summary>
    public class Llamada
    {
        private int codigoPais;
        private int codigoArea;
        private int numero;
        private TipoLlamada tipo;

        public Llamada(int numero, int codigoArea, int codigoPais)
        {
            this.Numero = numero;
            this.CodigoArea = codigoArea;
            this.CodigoPais = codigoPais;
        }
        public Llamada(int numero, int codigoArea) : this ( numero, codigoArea, 54 ) { }
        public Llamada(int numero) : this (numero, 11) { }
        internal int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                if (value > 0)
                {
                    numero = value;
                }
            }
        }
        internal int CodigoArea
        {
            get
            {
                return codigoArea;
            }
            set
            {
                if (value > 0)
                {
                    codigoArea = value;
                }
            }
        }
        internal int CodigoPais
        {
            get
            {
                return codigoPais;
            }
            set
            {
                if (value > 0)
                {
                    codigoPais = value;
                }
            }
        }
        /// <summary>
        /// Genera una llamada a un numero telefonico de forma aleatoria
        /// </summary>
        /// <returns></returns>
        public static Llamada GenerarLlamada()
        {
            int numero = Utilidades.GeneradorNumero.Generar(10000000, 99999999);
            int codigoArea;
            int codigoPais;
            //Cada llamada tiene un 85% de posibilidades tener un destino dentro del pais
            if(Utilidades.GeneradorNumero.Generar(1, 101) <85)
            {
                codigoPais = 54;
                //A su vez, cada llamada tiene un 70% de probabilidades de ser una llamada local
                if(Utilidades.GeneradorNumero.Generar(1,101)<70)
                {
                    codigoArea = 11;
                }
                else
                {
                    /*Si la llamada no es local, genero un codigo de area aleatorio entre 220 y 3984 (maximo y minimo codigo de area
                    para llamadas locales*/
                    codigoArea = Utilidades.GeneradorNumero.Generar(220, 3894);
                }
            }
            else
            {
                //Si la llamada no tiene un destino en Argentina genero datos para una llamada internacional
                codigoPais = Utilidades.GeneradorNumero.Generar(1, 1000);
                codigoArea = Utilidades.GeneradorNumero.Generar(1, 9999);
            }
            Llamada llamada = new Llamada(numero, codigoArea, codigoPais);
            llamada.SetTipoLlamada();
            return llamada;
        }

        public TipoLlamada Tipo 
        { 
            get
            {
                return tipo;
            }
        }
        /// <summary>
        /// Setea el tipo de llamada en base a codigo de area y de pais
        /// </summary>
        private void SetTipoLlamada()
        {
            if(codigoPais == 54)
            {
                if (codigoArea == 11)
                {
                   tipo = TipoLlamada.Local;
                }
                else
                {
                    tipo = TipoLlamada.LargaDistancia;
                }
            }
            else
            {
                tipo = TipoLlamada.Internacional;
            }
        }
        /// <summary>
        /// Parsea los string recibidos a un numero telefonico, contando codigo de pais, area y el numero telefonico relativo a la misma
        /// </summary>
        /// <param name="codigoPaisStr">Codigo de pais asociado a la llamada</param>
        /// <param name="codigoAreaStr">Codigo de area asociado a la llamada</param>
        /// <param name="numeroStr">Numero de telefono asociado a la llamada</param>
        /// <returns></returns>
        public static Llamada ParsearLlamada(string codigoPaisStr, string codigoAreaStr, string numeroStr)
        {
            Llamada llamada = null;
            if(int.TryParse(codigoAreaStr, out int codigoArea) && 
                int.TryParse(codigoPaisStr, out int codigoPais) && 
                int.TryParse(numeroStr, out int numero))
            {
                if(numero >= 100000 && numero < 100000000 && 
                    codigoArea > 0 && codigoArea < 10000 &&
                    codigoPais > 0 && codigoPais < 10000)
                {
                    llamada = new Llamada(numero, codigoArea, codigoPais);
                }
            }
            return llamada;
        }
    }
}
