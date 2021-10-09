using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generadores;

namespace Entidades
{
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

        public static Llamada GenerarLlamada()
        {
            int numero = GeneradorNumero.Generar(10000000, 99999999);
            int codigoArea;
            int codigoPais;

            if(GeneradorNumero.Generar(0, 10) <8)
            {
                codigoPais = 54;
                if(GeneradorNumero.Generar(0,10)<6)
                {
                    codigoArea = 11;
                }
                else
                {
                    codigoArea = GeneradorNumero.Generar(1, 2966);
                }
            }
            else
            {
                codigoPais = GeneradorNumero.Generar(1, 1000);
                codigoArea = GeneradorNumero.Generar(1, 9999);
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
    }
}
