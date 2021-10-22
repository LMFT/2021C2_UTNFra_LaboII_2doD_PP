using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPL2
{
    public partial class FormAyuda : Form
    {
        private string mensajeAyuda;
        public FormAyuda()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Inicializa el campo privado mensajeAyuda con el mensaje recibido como parametro
        /// </summary>
        /// <param name="mensaje"></param>
        public FormAyuda(string mensaje) : this()
        {
            if(mensaje is not null)
            {
                this.mensajeAyuda = mensaje;
            }
        }
        /// <summary>
        /// Setea el texto del Rich TextBox con el mensaje de ayuda recibido como parametro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {
            if(mensajeAyuda is not null)
            {
                rtxtAyuda.Text = mensajeAyuda;
            }
        }
        /// <summary>
        /// Cierra el form de ayuda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
