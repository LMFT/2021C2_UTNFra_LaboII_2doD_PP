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

        public FormAyuda(string mensaje) : this()
        {
            if(mensaje is not null)
            {
                this.mensajeAyuda = mensaje;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(mensajeAyuda is not null)
            {
                rtxtAyuda.Text = mensajeAyuda;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
