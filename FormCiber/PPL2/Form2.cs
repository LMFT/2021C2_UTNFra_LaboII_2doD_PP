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

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Cliente> clientes = Cibercafe.ObtenerClientesEnEspera();
            
            for(int i=0;i<clientes.Count;i++)
            {
                dgvClientes.Rows.Add();
                DataGridViewRow fila = dgvClientes.Rows[i];
                fila.SetValues(clientes[i].Nombre, clientes[i].Apellido, clientes[i].Dni, clientes[i].Edad);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
