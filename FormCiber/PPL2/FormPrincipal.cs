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
        /// <summary>
        /// Inicializa el estado de las variables necesarias para el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            SetearFecha();
            rtxtProximoCliente.Text = Cibercafe.VerProximoCliente().ToString();
            botonera = InicializarBotones();
            CambiarColorBotones(Cibercafe.VerProximoCliente());
        }
        /// <summary>
        /// Selecciona la computadora con el ID C01
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPc1_Click(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("C01");
            if(dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnPc1;
            }
            
        }
        /// <summary>
        /// Selecciona la computadora con el ID C02
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPc2_Click_1(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("C02");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnPc2;
            }
        }
        /// <summary>
        /// Selecciona la computadora con el ID C03
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPc3_Click(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("C03");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnPc3;
            }
        }
        /// <summary>
        /// Selecciona la computadora con el ID C04
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPc4_Click(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("C04");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnPc4;
            }
        }
        /// <summary>
        /// Selecciona la computadora con el ID C05
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPc5_Click(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("C05");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnPc5;
            }
        }
        /// <summary>
        /// Selecciona la computadora con el ID C06
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPc6_Click(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("C06");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnPc6;
            }
        }
        /// <summary>
        /// Selecciona la computadora con el ID C07
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPc7_Click(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("C07");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnPc7;
            }
        }
        /// <summary>
        /// Selecciona la computadora con el ID C08
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPc8_Click(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("C08");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnPc8;
            }
        }
        /// <summary>
        /// Selecciona la computadora con el ID C09
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPc9_Click(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("C09");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnPc9;
            }
        }
        /// <summary>
        /// Selecciona la computadora con el ID C10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPc10_Click(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("C10");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnPc10;
            }
        }
        /// <summary>
        /// Selecciona la computadora con el ID T01
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnT1_Click(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("T01");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnT1;
            }
        }
        /// <summary>
        /// Selecciona la computadora con el ID T02
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnT2_Click(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("T02");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnT2;
            }
        }
        /// <summary>
        /// Selecciona la computadora con el ID T03
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnT3_Click(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("T03");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnT3;
            }
        }
        /// <summary>
        /// Selecciona la computadora con el ID T04
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnT4_Click(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("T04");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnT4;
            }
        }
        /// <summary>
        /// Selecciona la computadora con el ID T05
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnT5_Click(object sender, EventArgs e)
        {
            dispositivoActual = Cibercafe.ObtenerDispositivo("T05");
            if (dispositivoActual is not null)
            {
                rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
                botonSeleccionado = btnT5;
            }
        }
        /// <summary>
        /// Muestra el formulario con los clientes en espera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClientesEspera_Click(object sender, EventArgs e)
        {
            FormListaClientes frm = new FormListaClientes();
            frm.ShowDialog();
        }
        /// <summary>
        /// Asigna el dispositivo seleccionado al próximo cliente, validando que el mismo cuente con los requisitos del cliente (tipo
        /// de dispositvo y, en caso de ser una computadora, software/juego y periferico)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if(dispositivoActual is not null && dispositivoActual.ObtenerEstado() == Estado.Libre)
            {
                 
                Cliente cliente = Cibercafe.VerProximoCliente();
                if(ValidarDispositivo(cliente))
                {
                    
                    Asignar(cliente);
                    //Actualizo la interfaz para reflejar los cambios en el programa
                    ActualizarInterfaz();
                    MessageBox.Show("El dispositivo se asignó correctamente", "Dispositivo asignado", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Este dispositivo se encuentra ocupado o no se ha seleccionado ningun dispositivo",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Actualiza la interfaz de la aplicacion tras asignar un dispositivo
        /// </summary>
        private void ActualizarInterfaz()
        {
            rtxtInfoDispositivo.Text = dispositivoActual.MostrarDispositivo();
            rtxtProximoCliente.Text = Cibercafe.VerProximoCliente().ToString();
            CambiarColorBotones(Cibercafe.VerProximoCliente());
            SetearFecha();
        }
        /// <summary>
        /// Asigna el dispositivo al cliente y, en caso de ser solicitado por fraccion, realiza el cobro
        /// </summary>
        /// <param name="cliente"></param>
        private void Asignar(Cliente cliente)
        {
            cliente.AsignarDispositivo(dispositivoActual);
            Cibercafe.AsignarDispositivo(Cibercafe.AtenderCliente());
            if (rbtnFraccion.Checked)
            {
                DateTime horaFinalizacion = DateTime.Now;
                dispositivoActual.Fracciones = (int)nudCantidadFracciones.Value;
                horaFinalizacion.AddSeconds(dispositivoActual.TiempoUso());
                Cobrar(cliente);
                return;

                
            }
            dispositivoActual.Fracciones = 0;
        }
        /// <summary>
        /// Valida que la computadora seleccionada cuente con los requisitos del cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>True si la computadora cuenta con los requisitos, de lo contrario false</returns>
        private bool ValidarComputadora(Cliente cliente)
        {
            return cliente ==(Computadora)dispositivoActual;
        }
        /// <summary>
        /// Valida que el dispositivo seleccionado coincida con el dispositivo necesario para el cliente, y en caso de ser una 
        /// computadora que la misma cuente con los requisitos del cliente (software/juegos y periferico
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>True si el dispositivo coincide con los requisitos del cliente, de lo contrario false</returns>
        private bool ValidarDispositivo(Cliente cliente)
        {
            if(cliente.Necesidad == Necesidad.Computadora && dispositivoActual.GetType() == typeof(Computadora))
            {
                if(ValidarComputadora(cliente))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Esta computadora no cuenta con el software o perifericos requeridos por el cliente",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if(cliente.Necesidad == Necesidad.Telefono && dispositivoActual.GetType() == typeof(Telefono))
                {
                    return true;
                }
            }
            MessageBox.Show("El cliente no requiere este tipo de dispositivo", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        /// <summary>
        /// Setea la fecha actual en la barra de informacion
        /// </summary>
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
        /// <summary>
        /// Inicializa el conjunto de botones de seleccion de dispositivos
        /// </summary>
        /// <returns>Diccionario que contiene los botones de seleccion inicializados</returns>
        private Dictionary<Button, string> InicializarBotones()
        {
            Dictionary<Button, string> botonera = new Dictionary<Button, string>();
            List<Computadora> listaComputadoras = Cibercafe.FiltrarComputadoras();
            List<Telefono> listaTelefonos = Cibercafe.FiltrarTelefonos();
            CargarBotonesComputadoras(botonera, listaComputadoras);
            CargarBotonesTelefonos(botonera, listaTelefonos);
            return botonera;
        }
        /// <summary>
        /// Asigna cada computadora a su correspondiente boton en la interfaz
        /// </summary>
        /// <param name="botonera"></param>
        /// <param name="lista"></param>
        private void CargarBotonesComputadoras(Dictionary<Button, string> botonera, List<Computadora> lista)
        {
            string id = new string(string.Empty);
            for (int i = 0; i < lista.Count;i++)
            {
                id = lista[i].ObtenerId();
                //Para asignar cada boton verifico que el numero del dispositivo coincida con el numero del ID
                foreach (Button btn in gpbComputadoras.Controls)
                {
                    if (btn.Text.EndsWith(id.Remove(0, 1)))
                    {
                        botonera.Add(btn, id);
                    }
                }
            }
        }
        /// <summary>
        /// Asigna cada telefono a su correspondiente boton en la interfaz
        /// </summary>
        /// <param name="botonera"></param>
        /// <param name="lista"></param>
        private void CargarBotonesTelefonos(Dictionary<Button, string> botonera, List<Telefono> lista)
        {
            string id;
            for (int i = 0; i < lista.Count;i++)
            {
                id = lista[i].ObtenerId();
                //Para asignar cada boton verifico que el numero del dispositivo coincida con el numero del ID
                foreach (Button btn in gpbTelefonos.Controls)
                {
                    if (btn.Text.EndsWith(id.Remove(0, 1)))
                    {
                        botonera.Add(btn, id);
                    }
                }
            }
        }
        /// <summary>
        /// Cambia el color de los botones de seleccion, en base a si el mismo cumple con los requerimientos del cliente y si
        /// se encuentra ocupado o no
        /// </summary>
        /// <param name="cliente"></param>
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
        /// <summary>
        /// Finaliza la utilizacion del dispositivo seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLiberar_Click(object sender, EventArgs e)
        {
            Cliente cliente = Cibercafe.ObtenerClientePorDispositivo(dispositivoActual);

            if(cliente is not null && dispositivoActual.ObtenerEstado() == Estado.Ocupado)
            {
                if(VerificarFraccion())
                {
                    if(TiempoLibre())
                    {
                        Cobrar(cliente);
                    }
                    else
                    {
                        dispositivoActual.Liberar();
                    }
                    MessageBox.Show($"Se ha finalizado el uso del dispositivo despues de {Math.Round(cliente.TiempoUso())} minutos.");
                    
                    ActualizarInterfaz();
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
        /// <summary>
        /// Calcula el monto a cobrar e informa al usuario del mismo
        /// </summary>
        /// <param name="cliente"></param>
        private void Cobrar(Cliente cliente)
        {
            double monto = Cibercafe.Cobrar(cliente);
            Cibercafe.AgregarOperacionAHistorial(cliente, monto);
            MessageBox.Show($"El monto bruto a cobrar es de ${monto:0.00} y el costo neto a cobrar" +
                            $" es de ${ CajaRegistradora.AplicarIva(monto):0.00}");
        }
        /// <summary>
        /// Verifica si el dispositivo fue asignado en modo libre
        /// </summary>
        /// <returns></returns>
        private bool TiempoLibre()
        {
            if(dispositivoActual.Fracciones == 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Valida que hayan transcurrido las fracciones de tiempo asignadas a un dispositivo
        /// </summary>
        /// <returns>True si el dispositivo se asigno como libre o si el tiempo de uso supera el tiempo asignado al cliente, de lo contrario
        /// false</returns>
        private bool VerificarFraccion()
        {
            double tiempoUso = Cibercafe.ObtenerClientePorDispositivo(dispositivoActual).TiempoUso();
            if(dispositivoActual.Fracciones == 0 || tiempoUso/dispositivoActual.TiempoFraccion >= dispositivoActual.Fracciones)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Muestra el historial de operaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FormHistorial frm = new FormHistorial();
            frm.ShowDialog();
        }
        /// <summary>
        /// Cierra la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTerminarPrograma_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Verifica que el usuario esté seguro de querer cerrar la aplicacion
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult respuesta = MessageBox.Show("Esta seguro que desea salirdel programa?", "Salir?", botones);
            if (respuesta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Muestra la vendad de ayuda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
