using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace PPL2
{
    public partial class FormListaClientes : Form
    {
        public FormListaClientes()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Carga el DataGridView con los datos de los clientes en espera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach(Cliente cliente in Cibercafe.Clientes)
            {
                dgvClientes.Rows.Add();
                DataGridViewRow fila = dgvClientes.Rows[i];
                fila.SetValues(cliente.Nombre, cliente.Apellido, cliente.Dni, cliente.Edad, cliente.Necesidad);
                i++;
            }
        }
        /// <summary>
        /// Cierra el formulario de clientes en espera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
