using Entidades;
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
    public partial class FrmLlamada : Form
    {
        private Llamada llamada;
        /// <summary>
        /// Permite obtener el valor del atributo llamada
        /// </summary>
        public Llamada Llamada
        {
            get
            {
                return llamada;
            }
        }
        public FrmLlamada()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Intenta convertir los numeros ingresados en los campos a numero y asignarlos a la llamada. En caso de exito, los almacena en el atributo llamada y cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            llamada = Llamada.ParsearLlamada(txtCodigoPais.Text, txtCodigoArea.Text, txtNumero.Text);
            if(llamada is null)
            {
                MessageBox.Show("Error en el ingreso de datos. Verifique que los campos no contengan caracteres ni numeros negativos e intente de nuevo");
                return;
            }
            Close();
        }
        /// <summary>
        /// Cancela el ingreso de la llamada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
