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
    public partial class FormCiber : Form
    {
        private Dispositivo dispositivoSeleccionado;
        private Dictionary<Button, string> botonesDispositivos;
        public FormCiber()
        {
            InitializeComponent();
            dispositivoSeleccionado = null;
            botonesDispositivos = InicializarBotones();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetearFecha();
        }

        private void btnPc1_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("C01");
            rtxtInfoDispositivo.Text = Cibercafe.MostrarDispositivo(dispositivoSeleccionado.ObtenerId());
            
        }

        private void btnPc2_Click_1(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("C02");
            rtxtInfoDispositivo.Text = Cibercafe.MostrarDispositivo(dispositivoSeleccionado.ObtenerId());
        }

        private void btnPc3_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("C03");
            rtxtInfoDispositivo.Text = Cibercafe.MostrarDispositivo(dispositivoSeleccionado.ObtenerId());
        }

        private void btnPc4_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("C04");
            rtxtInfoDispositivo.Text = Cibercafe.MostrarDispositivo(dispositivoSeleccionado.ObtenerId());
        }

        private void btnPc5_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("C05");
            rtxtInfoDispositivo.Text = Cibercafe.MostrarDispositivo(dispositivoSeleccionado.ObtenerId());
        }

        private void btnPc6_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("C06");
            rtxtInfoDispositivo.Text = Cibercafe.MostrarDispositivo(dispositivoSeleccionado.ObtenerId());
        }

        private void btnPc7_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("C07");
            rtxtInfoDispositivo.Text = Cibercafe.MostrarDispositivo(dispositivoSeleccionado.ObtenerId());
        }

        private void btnPc8_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("C08");
            rtxtInfoDispositivo.Text = Cibercafe.MostrarDispositivo(dispositivoSeleccionado.ObtenerId());
        }

        private void btnPc9_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("C09");
            rtxtInfoDispositivo.Text = Cibercafe.MostrarDispositivo(dispositivoSeleccionado.ObtenerId());
        }

        private void btnPc10_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("C10");
            rtxtInfoDispositivo.Text = Cibercafe.MostrarDispositivo(dispositivoSeleccionado.ObtenerId());
        }

        private void btnT1_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("T01");
            rtxtInfoDispositivo.Text = Cibercafe.MostrarDispositivo(dispositivoSeleccionado.ObtenerId());
        }

        private void btnT2_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("T02");
            rtxtInfoDispositivo.Text = Cibercafe.MostrarDispositivo(dispositivoSeleccionado.ObtenerId());
        }

        private void btnT3_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("T03");
            rtxtInfoDispositivo.Text = Cibercafe.MostrarDispositivo(dispositivoSeleccionado.ObtenerId());
        }

        private void btnT4_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("T04");
            rtxtInfoDispositivo.Text = Cibercafe.MostrarDispositivo(dispositivoSeleccionado.ObtenerId());
        }

        private void btnT5_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("T05");
            rtxtInfoDispositivo.Text = Cibercafe.MostrarDispositivo(dispositivoSeleccionado.ObtenerId());
        }

        private void btnClientesEspera_Click(object sender, EventArgs e)
        {
            FormListaClientes frm = new FormListaClientes();
            frm.ShowDialog();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            Cliente cliente = Cibercafe.AtenderCliente();
            if (dispositivoSeleccionado is not null && ValidarDispositivo(cliente))
            {
                if(dispositivoSeleccionado as Computadora is not null)
                {
                    if(ValidarComputadora(cliente) == false)
                    {
                        MessageBox.Show("Error: Esta computadora no cuenta con el software requerido por el cliente");
                        return;
                    }
                }
                MessageBoxButtons respuesta = MessageBoxButtons.YesNo;
                if(MessageBox.Show("Esta seguro que desea asignar este dispositivo?", "Confirmar accion", respuesta) == DialogResult.Yes)
                {
                    cliente.AsignarDispositivo(dispositivoSeleccionado);
                    CambiarColorBoton(ObtenerBotonPorId(dispositivoSeleccionado.ObtenerId()));
                }

            }

        }
        
        private bool ValidarDispositivo(Cliente cliente)
        {
            Computadora c = dispositivoSeleccionado as Computadora;
            Telefono t = dispositivoSeleccionado as Telefono;
            if((cliente.Necesidad == Necesidad.Telefono && t is not null) || 
               (cliente.Necesidad == Necesidad.Computadora && c is not null))
            {
                return true;
            }
            return false;
        }

        private bool ValidarComputadora(Cliente cliente)
        {
            Computadora computadora = dispositivoSeleccionado as Computadora;
            if(computadora is not null)
            {
                foreach(string software in computadora.ObtenerSoftware())
                {
                    if(software == cliente.ObtenerSoftwareNecesario())
                    {
                        return true;
                    }
                }
                foreach(string juego in computadora.ObtenerJuegos())
                {
                    if(juego == cliente.ObtenerSoftwareNecesario())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void SetearFecha()
        {
            string strFecha = DateTime.Today.ToString("dd-MM-yyyy");
            ToolStripItemCollection items =  stbBarraInformacion.Items;

            foreach(ToolStripLabel lbl in items)
            {
                if(lbl.Text == "Fecha: ")
                {
                    lbl.Text += strFecha;
                    return;
                }
            }
        }

        private void CambiarColorBoton(Button btn)
        {
            if(btn.BackColor == Color.LightGreen)
            {
                btn.BackColor = Color.IndianRed;
            }
            else
            {
                btn.BackColor = Color.LightGreen;
            }
        }

        private Dictionary<Button, string> InicializarBotones()
        {
            Dictionary<Button, string> botones = new Dictionary<Button, string>();
            int idPc = 1;
            int idTelefono = 1;
            foreach (Button btn in this.Controls)
            {
                if(btn.Name.Contains("PC"))
                {
                    botones.Add(btn, idPc.ToString("{0:00}"));
                    idPc++;
                }
                else if (btn.Name.Contains("T "))
                {
                    botones.Add(btn, idTelefono.ToString("{0:00}"));
                    idTelefono++;
                }
            }
            return botones;
        }

        private Button ObtenerBotonPorId(string id)
        {
            foreach(KeyValuePair<Button, string> par in this.botonesDispositivos)
            {
                if(par.Value == id)
                {
                    return par.Key;
                }
            }
            return new Button();
        }
    }
}
