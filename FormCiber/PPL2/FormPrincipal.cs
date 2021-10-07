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
        private Button botonSeleccionado;
        public FormCiber()
        {
            InitializeComponent();
            dispositivoSeleccionado = null;
            rbtnLibre.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetearFecha();
            rtxtProximoCliente.Text = Cibercafe.VerProximoCliente().ToString();
        }

        private void btnPc1_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("C01");
            if(dispositivoSeleccionado is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoSeleccionado.MostrarDispositivo();
                botonSeleccionado = btnPc1;
            }
            
        }

        private void btnPc2_Click_1(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("C02");
            if (dispositivoSeleccionado is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoSeleccionado.MostrarDispositivo();
                botonSeleccionado = btnPc2;
            }
        }

        private void btnPc3_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("C03");
            if (dispositivoSeleccionado is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoSeleccionado.MostrarDispositivo();
                botonSeleccionado = btnPc3;
            }
        }

        private void btnPc4_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("C04");
            if (dispositivoSeleccionado is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoSeleccionado.MostrarDispositivo();
                botonSeleccionado = btnPc4;
            }
        }

        private void btnPc5_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("C05");
            if (dispositivoSeleccionado is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoSeleccionado.MostrarDispositivo();
                botonSeleccionado = btnPc5;
            }
        }

        private void btnPc6_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("C06");
            if (dispositivoSeleccionado is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoSeleccionado.MostrarDispositivo();
                botonSeleccionado = btnPc6;
            }
        }

        private void btnPc7_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("C07");
            if (dispositivoSeleccionado is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoSeleccionado.MostrarDispositivo();
                botonSeleccionado = btnPc7;
            }
        }

        private void btnPc8_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("C08");
            if (dispositivoSeleccionado is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoSeleccionado.MostrarDispositivo();
                botonSeleccionado = btnPc8;
            }
        }

        private void btnPc9_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("C09");
            if (dispositivoSeleccionado is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoSeleccionado.MostrarDispositivo();
                botonSeleccionado = btnPc9;
            }
        }

        private void btnPc10_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("C10");
            if (dispositivoSeleccionado is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoSeleccionado.MostrarDispositivo();
                botonSeleccionado = btnPc10;
            }
        }

        private void btnT1_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("T01");
            if (dispositivoSeleccionado is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoSeleccionado.MostrarDispositivo();
                botonSeleccionado = btnT1;
            }
        }

        private void btnT2_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("T02");
            if (dispositivoSeleccionado is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoSeleccionado.MostrarDispositivo();
                botonSeleccionado = btnT2;
            }
        }

        private void btnT3_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("T03");
            if (dispositivoSeleccionado is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoSeleccionado.MostrarDispositivo();
                botonSeleccionado = btnT3;
            }
        }

        private void btnT4_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("T04");
            if (dispositivoSeleccionado is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoSeleccionado.MostrarDispositivo();
                botonSeleccionado = btnT4;
            }
        }

        private void btnT5_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = Cibercafe.ObtenerDispositivo("T05");
            if (dispositivoSeleccionado is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoSeleccionado.MostrarDispositivo();
                botonSeleccionado = btnT5;
            }
        }

        private void btnClientesEspera_Click(object sender, EventArgs e)
        {
            FormListaClientes frm = new FormListaClientes();
            frm.ShowDialog();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if(dispositivoSeleccionado is not null && dispositivoSeleccionado.ObtenerEstado() == Estado.Libre)
            {
                Cliente cliente = Cibercafe.VerProximoCliente();
                if(ValidarDispositivo(cliente))
                {
                    if(ValidarComputadora(cliente) == false)
                    {
                        MessageBox.Show("Esta computadora no cuenta con el software o perifericos requeridos por el cliente", 
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    cliente = Cibercafe.AtenderCliente();
                    Asignar(cliente);
                    rtxtInfoDispositivo.Text = dispositivoSeleccionado.MostrarDispositivo();
                    rtxtProximoCliente.Text = Cibercafe.VerProximoCliente().ToString();
                    CambiarColorBoton(botonSeleccionado);
                }
                else
                {
                    MessageBox.Show("El cliente no requiere este tipo de dispositivo","Error", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Este dispositivo se encuentra ocupado o no se ha seleccionado ningun dispositivo",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Asignar(Cliente cliente)
        {
            cliente.AsignarDispositivo(dispositivoSeleccionado);
            if(rbtnFraccion.Checked)
            {
                dispositivoSeleccionado.Fracciones = (int)nudCantidadFracciones.Value;
            }
        }

        private bool ValidarComputadora(Cliente cliente)
        {
            if(dispositivoSeleccionado.GetType() == typeof(Computadora))
            {
                return cliente == dispositivoSeleccionado;
            }
            return true;
        }

        private bool ValidarDispositivo(Cliente cliente)
        {
            return (cliente.Necesidad == Necesidad.Computadora && dispositivoSeleccionado.GetType() == typeof(Computadora)) ||
            (cliente.Necesidad == Necesidad.Telefono && dispositivoSeleccionado.GetType() == typeof(Telefono));
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

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            Cliente cliente = Cibercafe.ObtenerClientePorDispositivo(dispositivoSeleccionado);
            if(cliente is not null)
            {
                double monto = Cibercafe.Cobrar(cliente);
                Operacion operacion = new Operacion(cliente, monto);
                Cibercafe.AgregarOperacionAHistorial(operacion);
                CambiarColorBoton(botonSeleccionado);
                rtxtInfoDispositivo.Text = dispositivoSeleccionado.MostrarDispositivo();
            }
            else
            {
                MessageBox.Show("Este dispositivo ya se encuentra libre", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void rbtnLibre_CheckedChanged(object sender, EventArgs e)
        {
            nudCantidadFracciones.Enabled = false;
            
        }

        private void rbtnFraccion_CheckedChanged(object sender, EventArgs e)
        {
            nudCantidadFracciones.Enabled = true;
        }

        private void VerificarFraccion(Cliente cliente, int intervalo)
        {
            double fraccionActual = (DateTime.Now - cliente.HoraInicio).TotalSeconds/intervalo;
            if(cliente.Dispositivo.Fracciones >= fraccionActual)
            {
                cliente.Dispositivo.Liberar();
            }
        }

        private void timerPc1_Tick(object sender, EventArgs e)
        {
            if(timerPc1.Enabled == true)
            {
                VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("C01"), timerPc1.Interval);
            }
        }

        private void timerPc2_Tick(object sender, EventArgs e)
        {
            if (timerPc2.Enabled == true)
            {
                VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("C02"), timerPc2.Interval);
            }
        }

        private void timerPc3_Tick(object sender, EventArgs e)
        {
            if (timerPc3.Enabled == true)
            {
                VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("C03"), timerPc3.Interval);
            }
        }

        private void timerPc4_Tick(object sender, EventArgs e)
        {
            if (timerPc4.Enabled == true)
            {
                VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("C04"), timerPc4.Interval);
            }
        }

        private void timerPc5_Tick(object sender, EventArgs e)
        {
            if (timerPc5.Enabled == true)
            {
                VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("C05"), timerPc5.Interval);
            }
        }

        private void timerPc6_Tick(object sender, EventArgs e)
        {
            if (timerPc6.Enabled == true)
            {
                VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("C06"), timerPc6.Interval);
            }
        }

        private void timerPc7_Tick(object sender, EventArgs e)
        {
            if (timerPc7.Enabled == true)
            {
                VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("C03"), timerPc1.Interval);
            }
        }

        private void timerPc8_Tick(object sender, EventArgs e)
        {
            if (timerPc8.Enabled == true)
            {
                VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("C08"), timerPc8.Interval);
            }
        }

        private void timerPc9_Tick(object sender, EventArgs e)
        {
            if (timerPc9.Enabled == true)
            {
                VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("C09"), timerPc9.Interval);
            }
        }

        private void timerPc10_Tick(object sender, EventArgs e)
        {
            if (timerPc10.Enabled == true)
            {
                VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("C10"), timerPc10.Interval);
            }

        }

        private void timerT1_Tick(object sender, EventArgs e)
        {
            if (timerT1.Enabled == true)
            {
                VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("T01"), timerT1.Interval);
            }
        }

        private void timerT2_Tick(object sender, EventArgs e)
        {
            if (timerT2.Enabled == true)
            {
                VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("T02"), timerT2.Interval);
            }
        }

        private void timerT3_Tick(object sender, EventArgs e)
        {
            if (timerT3.Enabled == true)
            {
                VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("T03"), timerT3.Interval);
            }
        }

        private void timerT4_Tick(object sender, EventArgs e)
        {
            if (timerT4.Enabled == true)
            {
                VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("T04"), timerT4.Interval);
            }
        }

        private void timerT5_Tick(object sender, EventArgs e)
        {
            if (timerT5.Enabled == true)
            {
                VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("T05"), timerT5.Interval);
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FormHistorial frm = new FormHistorial();
            frm.ShowDialog();
        }
    }
}
