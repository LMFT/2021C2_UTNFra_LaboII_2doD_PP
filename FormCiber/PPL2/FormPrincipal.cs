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
        Dictionary<Button, string> botonera;
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
            botonera = InicializarBotones();
            CambiarColorBotones(Cibercafe.VerProximoCliente());
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
                    cliente = Cibercafe.VerProximoCliente();
                    MessageBox.Show("El dispositivo se asignó correctamente");
                    rtxtProximoCliente.Text = Cibercafe.VerProximoCliente().ToString();
                    CambiarColorBotones(cliente);
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
                Timer timer = GetTimer(dispositivoSeleccionado);
                timer.Start();
                dispositivoSeleccionado.Fracciones = (int)nudCantidadFracciones.Value;
            }
            dispositivoSeleccionado.Fracciones = -1;
        }

        public Timer GetTimer(Dispositivo dispositivo)
        {
            switch(dispositivo.ObtenerId())
            {
                case "C01":
                    return timerPc1;
                case "C02":
                    return timerPc2;
                case "C03":
                    return timerPc3;
                case "C04":
                    return timerPc4;
                case "C05":
                    return timerPc5;
                case "C06":
                    return timerPc6;
                case "C07":
                    return timerPc7;
                case "C08":
                    return timerPc8;
                case "C09":
                    return timerPc9;
                case "C10":
                    return timerPc10;
                case "T01":
                    return timerT1;
                case "T02":
                    return timerT2;
                case "T03":
                    return timerT3;
                case "T04":
                    return timerT4;
                default:
                    return timerT5;
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

        private Dictionary<Button, string> InicializarBotones()
        {
            Dictionary<Button, string> botonera = new Dictionary<Button, string>();
            List<Computadora> listaComputadoras = Cibercafe.FiltrarComputadoras();
            List<Telefono> listaTelefonos = Cibercafe.FiltrarTelefonos();
            CargarBotonesComputadoras(botonera, listaComputadoras);
            CargarBotonesTelefonos(botonera, listaTelefonos);
            return botonera;
        }

        private void CargarBotonesComputadoras(Dictionary<Button, string> botonera, List<Computadora> lista)
        {
            string id = new string(string.Empty);
            for (int i = 0; i < lista.Count;i++)
            {
                id = lista[i].ObtenerId();
                foreach (Button btn in gpbComputadoras.Controls)
                {
                    if (btn.Text.EndsWith(id.Remove(0, 1)))
                    {
                        botonera.Add(btn, id);
                        break;
                    }
                }
            }
        }

        private void CargarBotonesTelefonos(Dictionary<Button, string> botonera, List<Telefono> lista)
        {
            string id;
            for (int i = 0; i < lista.Count;i++)
            {
                id = lista[i].ObtenerId();
                foreach (Button btn in gpbTelefonos.Controls)
                {
                    if (btn.Text.EndsWith(id.Remove(0, 1)))
                    {
                        botonera.Add(btn, id);
                    }
                }
            }
        }

        private void CambiarColorBotones(Cliente cliente)
        {
            
            foreach(Button btn in botonera.Keys)
            {
                if(botonera.TryGetValue(btn, out string id))
                {
                    Dispositivo dispositivo = Cibercafe.ObtenerDispositivo(id);
                    if(cliente == dispositivo && dispositivo.ObtenerEstado() == Estado.Libre)
                    {
                        btn.BackColor = Color.LightGreen;

                    }
                    else
                    {
                        if(dispositivo.ObtenerEstado() == Estado.Libre)
                        {
                            btn.BackColor = Color.Yellow;
                        }
                        else
                        {
                            if(dispositivo.ObtenerEstado() == Estado.Ocupado && cliente == dispositivo)
                            {
                                btn.BackColor = Color.Orange;
                            }
                            else
                            {
                                btn.BackColor = Color.IndianRed;
                            }
                        }
                    }
                }
            }
        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            Cliente cliente = Cibercafe.ObtenerClientePorDispositivo(dispositivoSeleccionado);
            if(cliente is not null)
            {
                double monto = Cibercafe.Cobrar(cliente);
                Operacion operacion = new Operacion(cliente, monto);
                MessageBox.Show($"Se finalizó el uso del dispositivo despues de {operacion.GetTiempoUso()} minutos. El total a cobrar" +
                    $" es de {operacion.Monto}");
                Cibercafe.AgregarOperacionAHistorial(operacion);
                CambiarColorBotones(cliente);
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

        private void RevisarTimer(Timer timer)
        {

        }

        private static void VerificarFraccion(Cliente cliente, Timer timer)
        {
            if(cliente.GetDispositivo().Fracciones == 0)
            {
                cliente.GetDispositivo().Liberar();
                timer.Stop();
            }
            Dispositivo dispositivo = cliente.GetDispositivo();
            dispositivo.Fracciones--;
        }

        private void timerPc1_Tick(object sender, EventArgs e)
        {
            VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("C01"), timerPc1);
        }

        private void timerPc2_Tick(object sender, EventArgs e)
        {
            VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("C02"), timerPc2);
        }

        private void timerPc3_Tick(object sender, EventArgs e)
        {
            VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("C03"), timerPc3);
        }

        private void timerPc4_Tick(object sender, EventArgs e)
        {
            VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("C04"), timerPc4);
        }

        private void timerPc5_Tick(object sender, EventArgs e)
        {
            VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("C05"), timerPc5);
        }

        private void timerPc6_Tick(object sender, EventArgs e)
        {
            VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("C06"), timerPc6);
        }

        private void timerPc7_Tick(object sender, EventArgs e)
        {
            VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("C03"), timerPc1);
        }

        private void timerPc8_Tick(object sender, EventArgs e)
        {
            VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("C08"), timerPc8);
        }

        private void timerPc9_Tick(object sender, EventArgs e)
        {
            VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("C09"), timerPc9);
        }

        private void timerPc10_Tick(object sender, EventArgs e)
        {

                VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("C10"), timerPc10);


        }

        private void timerT1_Tick(object sender, EventArgs e)
        {
            VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("T01"), timerT1);
        }

        private void timerT2_Tick(object sender, EventArgs e)
        {
                VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("T02"), timerT2);
        }

        private void timerT3_Tick(object sender, EventArgs e)
        {
                VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("T03"), timerT3);
        }

        private void timerT4_Tick(object sender, EventArgs e)
        {
                VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("T04"), timerT4);
        }

        private void timerT5_Tick(object sender, EventArgs e)
        {
                VerificarFraccion(Cibercafe.ObtenerClientePorDispositivo("T05"), timerT5);
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FormHistorial frm = new FormHistorial();
            frm.ShowDialog();
        }

        private void btnTerminarPrograma_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult respuesta = MessageBox.Show("Esta seguro que desea salirdel programa?", "Salir?", botones);
            if (respuesta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            string mensaje = new string(string.Empty);
            #region Seteo de mensaje de Ayuda
            mensaje = "Instrucciones de uso:\nEl programa identifica mediante un código de colores los dispositivos válidos segun la" +
                "necesidad actual del cliente. Seleccione un dispositivo válido y presione el boton Asignar para asignar dicho dispositivo" +
                "al cliente. \n\nCodigo de colores: \n\n-Verde: Dispositivo válido \n -Amarillo: El dispositivo se encuentra libre, pero" +
                "no posee los requisitos del cliente.\n-Naranja: El dispositivo posee los requerimientos actuales del cliente, pero" +
                "se encuentra actualmente ocupado. \n -Rojo: El dispositivo no cumple los requisitos del cliente y se encuentra ocupado." +
                "\n\nPara finalizar el uso de un dispositivo, seleccione el dispositivo a finalizar y presione el boton Finalizar." +
                "\n En todo momento puede consultarel listado de clientes pendientes utilizando el boton de consultas, o revisar el" +
                "historial de operaciones utilizando el boton Ver Historial";
            #endregion
            FormAyuda frm = new FormAyuda(mensaje);
            frm.Show();
        }
    }
}
