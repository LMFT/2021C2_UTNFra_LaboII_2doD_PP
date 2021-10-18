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
        private Dispositivo dispositivoActual;
        private Button botonSeleccionado;
        Dictionary<Button, string> botonera;
        public FormCiber()
        {
            InitializeComponent();
            dispositivoActual = null;
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
            dispositivoActual = Cibercafe.ObtenerDispositivo("C01");
            if(dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnPc1;
            }
            
        }

        private void btnPc2_Click_1(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("C02");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnPc2;
            }
        }

        private void btnPc3_Click(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("C03");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnPc3;
            }
        }

        private void btnPc4_Click(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("C04");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnPc4;
            }
        }

        private void btnPc5_Click(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("C05");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnPc5;
            }
        }

        private void btnPc6_Click(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("C06");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnPc6;
            }
        }

        private void btnPc7_Click(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("C07");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnPc7;
            }
        }

        private void btnPc8_Click(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("C08");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnPc8;
            }
        }

        private void btnPc9_Click(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("C09");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnPc9;
            }
        }

        private void btnPc10_Click(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("C10");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnPc10;
            }
        }

        private void btnT1_Click(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("T01");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnT1;
            }
        }

        private void btnT2_Click(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("T02");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnT2;
            }
        }

        private void btnT3_Click(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("T03");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnT3;
            }
        }

        private void btnT4_Click(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("T04");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnT4;
            }
        }

        private void btnT5_Click(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("T05");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
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
            if(dispositivoActual is not null && dispositivoActual.ObtenerEstado() == Estado.Libre)
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
                    rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                    Cliente proximoCliente = Cibercafe.VerProximoCliente();
                    MessageBox.Show("El dispositivo se asignó correctamente");
                    rtxtProximoCliente.Text = Cibercafe.VerProximoCliente().ToString();
                    CambiarColorBotones(proximoCliente);
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
            cliente.AsignarDispositivo(dispositivoActual);
            if(rbtnFraccion.Checked)
            {
                DateTime horaFinalizacion = DateTime.Now;
                dispositivoActual.Fracciones = (int)nudCantidadFracciones.Value;
                horaFinalizacion.AddSeconds(dispositivoActual.TiempoUso());
                double monto = Cibercafe.Cobrar(cliente, horaFinalizacion);
                Cibercafe.AgregarOperacionAHistorial(cliente, monto);
                return;
            }
            dispositivoActual.Fracciones = 0;
        }

        private bool ValidarComputadora(Cliente cliente)
        {
            if(dispositivoActual.GetType() == typeof(Computadora))
            {
                return cliente == dispositivoActual;
            }
            return true;
        }

        private bool ValidarDispositivo(Cliente cliente)
        {
            return (cliente.Necesidad == Necesidad.Computadora && dispositivoActual.GetType() == typeof(Computadora)) ||
            (cliente.Necesidad == Necesidad.Telefono && dispositivoActual.GetType() == typeof(Telefono));
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
            Cliente cliente = Cibercafe.ObtenerClientePorDispositivo(dispositivoActual);
            string mensajeExtendido = null;

            if(cliente is not null)
            {
                if(VerificarFraccion())
                {
                    if(TiempoLibre())
                    {
                        double monto = Cibercafe.Cobrar(cliente);
                        Cibercafe.AgregarOperacionAHistorial(cliente, monto);
                        mensajeExtendido = String.Format(" El monto bruto a cobrar es de ${0:0.00} y el costo neto a cobrar"+
                            "es de ${1:0.00}", monto, CajaRegistradora.AplicarIva(monto));
                    }
                    else
                    {
                        dispositivoActual.Liberar();
                    }
                    string mensaje = $"Se ha finalizado el uso del dispositivo despues de {Math.Round(cliente.TiempoUso())} minutos.";
                    MostrarMensaje(mensaje, mensajeExtendido);
                    CambiarColorBotones(Cibercafe.VerProximoCliente());
                    rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                }
                else
                {
                    MessageBox.Show($"Este dispositivo todavia tiene {cliente.TiempoRestante()} minutos disponibles");
                }
            }
            else
            {
                MessageBox.Show("Este dispositivo ya se encuentra libre", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void MostrarMensaje(string mensaje, string mensajeExtendido)
        {
            if(mensajeExtendido is null)
            {
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show(mensaje + mensajeExtendido);
            }
        }

        private bool TiempoLibre()
        {
            if(dispositivoActual.Fracciones == 0)
            {
                return true;
            }
            return false;
        }

        private bool VerificarFraccion()
        {
            double tiempoUso = Cibercafe.ObtenerClientePorDispositivo(dispositivoActual).TiempoUso();
            if(dispositivoActual.Fracciones == 0 || tiempoUso/dispositivoActual.TiempoFraccion >= dispositivoActual.Fracciones)
            {
                return true;
            }
            return false;
        }

        private void rbtnLibre_CheckedChanged(object sender, EventArgs e)
        {
            nudCantidadFracciones.Enabled = false;
            
        }

        private void rbtnFraccion_CheckedChanged(object sender, EventArgs e)
        {
            nudCantidadFracciones.Enabled = true;
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FormHistorial frm = new FormHistorial();
            frm.ShowDialog();
        }

        private void btnTerminarPrograma_Click(object sender, EventArgs e)
        {
            Close();
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
