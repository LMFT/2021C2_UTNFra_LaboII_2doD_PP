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
    public partial class FormHistorial : Form
    {
        public FormHistorial()
        {
            InitializeComponent();
        }

        private void FormHistorial_Load(object sender, EventArgs e)
        {
            DesactivarDataGrids();
            InicializarDataGrids();
            lblGanancias.Text += $" ${CalcularGananciasTotales()}";
            ClasificarGanancias(out double pc, out double telefono);
            lblComputadoras.Text += $" ${pc}";
            lblTelefonos.Text += $" ${telefono}";
            lblJuegos.Text += $" {ObtenerJuegoMasPedido()}";
            lblSoftware.Text += $" {ObtenerSoftwareMasPedido()}";
            lblPeriferico.Text += $" {ObtenerPerifericoMasPedido()}";
        }
        /// <summary>
        /// Ancla los distintos DataGridView
        /// </summary>
        private void InicializarDataGrids()
        {
            foreach(DataGridView dgv in Controls.OfType<DataGridView>())
            {
                dgv.Anchor = (AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            }
        }
        
        /// <summary>
        /// Lista las computadoras, ordenadas por tiempo de uso
        /// </summary>
        /// <param name="historial">Historial de operaciones del cibercafe</param>
        private void ListarComputadorasPorTiempoDeUso(List<Operacion> historial)
        {
            dgvDispositivos.Rows.Clear();
            DesactivarDataGrids();
            List<Computadora> computadoras = Cibercafe.FiltrarComputadoras();
            double[] tiempoUso = CalcularTiempoDeUso(computadoras, historial);
            OrdenarComputadorasPorTiempoDeUso(computadoras, tiempoUso);
            for(int i=0;i<tiempoUso.Length;i++)
            {
                AgregarDispositivoADataGrid(computadoras[i], tiempoUso[i]);
            }
            dgvDispositivos.Show();
        }
        /// <summary>
        /// Añade un dispositivo al datagridview
        /// </summary>
        /// <param name="dispositivo"></param>
        /// <param name="tiempoUso"></param>
        private void AgregarDispositivoADataGrid(Dispositivo dispositivo, double tiempoUso)
        {
            int index = dgvDispositivos.Rows.Add();
            DataGridViewRow fila = dgvDispositivos.Rows[index];
            fila.SetValues(dispositivo.ObtenerId(), tiempoUso);
        }
        /// <summary>
        /// Esconde los datagrid
        /// </summary>
        private void DesactivarDataGrids()
        {
            foreach(DataGridView dgv in this.Controls.OfType<DataGridView>())
            {
                dgv.Hide();
            }
        }
        /// <summary>
        /// Calcula el tiempo de uso total de cada computadora
        /// </summary>
        /// <param name="lista">Listado de computadoras</param>
        /// <param name="historial">Historial de operaciones previas</param>
        /// <returns>Array que contiene el tiempo de uso de cada computadora, de forma paralela al listado de computadoras</returns>
        private double[] CalcularTiempoDeUso(List<Computadora> lista, List<Operacion> historial)
        {
            double[] tiempoUso = new double[lista.Count];
            Computadora pcCliente;
            foreach (Operacion operacion in historial)
            {
                pcCliente = operacion.Cliente.GetDispositivo() as Computadora;
                if(pcCliente is not null)
                {
                    tiempoUso[lista.IndexOf(pcCliente)] += operacion.Cliente.TiempoUso();
                }
            }
            return tiempoUso;
        }
        /// <summary>
        /// Ordena un listado de computadoras en base al tiempo de uso total de cada una de ellas
        /// </summary>
        /// <param name="lista">Listado de computadoras a ordenar</param>
        /// <param name="tiempoUso">Array que contiene el uso total de cada computadora</param>
        private void OrdenarComputadorasPorTiempoDeUso(List<Computadora> lista, double[] tiempoUso)
        {
            double auxDouble;
            Computadora auxPc;
            for (int i=0;i<lista.Count-1;i++)
            {
                for(int j=i+1;j<lista.Count;j++)
                {
                    if(tiempoUso[i] < tiempoUso[j])
                    {
                        auxDouble = tiempoUso[i];
                        tiempoUso[i] = tiempoUso[j];
                        tiempoUso[j] = auxDouble;

                        auxPc = lista[i];
                        lista[i] = lista[j];
                        lista[j] = auxPc;
                    }
                }
            }
        }

        /// <summary>
        /// Muestra todo los telefonos, ordenados por tiempo de uso
        /// </summary>
        /// <param name="historial">Historial de operaciones previas</param>
        private void ListarTelefonosPorTiempoDeUso(List<Operacion> historial)
        {
            dgvDispositivos.Rows.Clear();
            DesactivarDataGrids();
            List<Telefono> telefonos = Cibercafe.FiltrarTelefonos();
            double[] tiempoUso = CalcularTiempoDeUso(telefonos, historial);
            OrdenarTelefonosPorTiempoDeUso(telefonos, tiempoUso);
            for (int i = 0; i < tiempoUso.Length; i++)
            {
                AgregarDispositivoADataGrid(telefonos[i], tiempoUso[i]);
            }
            dgvDispositivos.Show();
        }
        /// <summary>
        /// Calcula el tiempò de uso de cada telefono
        /// </summary>
        /// <param name="lista">Listado de telefonos</param>
        /// <param name="historial">Historial de operaciones previas</param>
        /// <returns>Array que contiene el uso total de cada telefono</returns>
        private double[] CalcularTiempoDeUso(List<Telefono> lista, List<Operacion> historial)
        {
            double[] tiempoUso = new double[lista.Count];
            Telefono telefono;
            foreach (Operacion operacion in historial)
            {
                telefono = operacion.Cliente.GetDispositivo() as Telefono;
                if (telefono is not null)
                {
                    tiempoUso[lista.IndexOf(telefono)] += operacion.Cliente.TiempoUso();
                }
            }
            return tiempoUso;
        }
        /// <summary>
        /// Ordena el listado de telefonos por tiempo de uso
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="tiempoUso"></param>
        private void OrdenarTelefonosPorTiempoDeUso(List<Telefono> lista, double[] tiempoUso)
        {
            double auxDouble;
            Telefono auxPc;
            for (int i = 0; i < lista.Count - 1; i++)
            {
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (tiempoUso[i] < tiempoUso[j])
                    {
                        auxDouble = tiempoUso[i];
                        tiempoUso[i] = tiempoUso[j];
                        tiempoUso[j] = auxDouble;

                        auxPc = lista[i];
                        lista[i] = lista[j];
                        lista[j] = auxPc;
                    }
                }
            }
        }
        /// <summary>
        /// Calcula el monto acumulado por todas las operaciones
        /// </summary>
        /// <returns>Ingresos totales por las operaciones del cibercafe</returns>
        private double CalcularGananciasTotales()
        {
            ClasificarGanancias(out double montoPc, out double montoTelefono);
            return montoPc + montoTelefono;
        }
        /// <summary>
        /// Clasifica las ganancias segun el tipo de dispositivo asignado a cada operacion
        /// </summary>
        /// <param name="gananciaPc">Ganancia total obtenida por el alquiler de computadoras</param>
        /// <param name="gananciaTelefono">Ganacia total obtenida por el alquiler de cabinas telefonicas</param>
        private void ClasificarGanancias (out double gananciaPc, out double gananciaTelefono)
        {
            gananciaPc = 0;
            gananciaTelefono = 0;
            
            foreach(Operacion operacion in Cibercafe.GetHistorial())
            {
                if(operacion.Cliente.GetDispositivo().GetType() == typeof(Computadora))
                {
                    gananciaPc += operacion.Monto;
                }
                else
                {
                    gananciaTelefono += operacion.Monto;
                }
            }
        }
        /// <summary>
        /// Calcula el total de horas y minutos entre todas las llamadas realizadas, clasificadas por tipo (local, larga distancia o internacional)
        /// </summary>
        private void MostrarInformacionLlamadas()
        {
            dgvTipoLlamada.Rows.Clear();
            DesactivarDataGrids();
            double[] horasTotales = new double[3];
            double[] minutosTotales = new double[3];
            double[] recaudaciones = new double[3];

            CargarInformacionLlamadas(horasTotales, minutosTotales, recaudaciones);
            for(int i=0;i<3;i++)
            {
                AgregarLlamadaADataGridView(horasTotales[i], minutosTotales[i], recaudaciones[i]);
            }
            dgvTipoLlamada.Show();
        }
        /// <summary>
        /// Añade un tipo de llamada al datagrid
        /// </summary>
        /// <param name="horasTotales"></param>
        /// <param name="minutosTotales"></param>
        /// <param name="recaudaciones"></param>
        private void AgregarLlamadaADataGridView(double horasTotales, double minutosTotales, double recaudaciones)
        {
            int index = dgvTipoLlamada.Rows.Add();
            DataGridViewRow fila = dgvTipoLlamada.Rows[index];
            fila.SetValues((TipoLlamada)index, horasTotales, minutosTotales, recaudaciones);
        }
        /// <summary>
        /// Obtiene informacion de cada tipo de llamada (local, larga distancia o internacional)
        /// </summary>
        /// <param name="horasTotales"></param>
        /// <param name="minutosTotales"></param>
        /// <param name="recaudaciones"></param>
        private void CargarInformacionLlamadas(double[] horasTotales, double[] minutosTotales, double[] recaudaciones)
        {
            Telefono telefono;
            foreach (Operacion operacion in Cibercafe.GetHistorial())
            {
                telefono = operacion.Cliente.GetDispositivo() as Telefono;
                if (telefono is not null)
                {
                    int index = (int)telefono.GetLlamada().Tipo;
                    minutosTotales[index] += operacion.Cliente.TiempoUso();
                    if(minutosTotales[index] >= 60)
                    {
                        horasTotales[index]++;
                        minutosTotales[index] -= 60;
                    }
                recaudaciones[index] += operacion.Monto;
                }
            }
        }
        /// <summary>
        /// Obtiene el software mas pedido por los clientes
        /// </summary>
        /// <returns>Software con mayor cantidad de peticiones</returns>
        private string ObtenerSoftwareMasPedido()
        {
            Computadora pc;
            string software;
            List<string> softwareMasPedido = new List<string>();
            List<int> peticiones = new List<int>();

            foreach(Operacion operacion in Cibercafe.GetHistorial())
            {
                pc = operacion.Cliente.GetDispositivo() as Computadora;
                if(pc is not null)
                {
                    software = operacion.Cliente.GetSoftwareNecesario();
                    if(!softwareMasPedido.Contains<string>(software))
                    {
                        softwareMasPedido.Add(software);
                        peticiones.Add(0);
                    }
                    else
                    {
                        peticiones[softwareMasPedido.IndexOf(software)]++;
                    }
                }
            }
            return softwareMasPedido[peticiones.IndexOf(peticiones.Max())];
        }
        /// <summary>
        /// Obtiene el periferico mas pedido por los clientes
        /// </summary>
        /// <returns>Periferico con mayor cantidad de peticiones</returns>
        private string ObtenerPerifericoMasPedido()
        {
            Computadora pc;
            string periferico;
            List<string> perifericoMasPedido = new List<string>();
            List<int> peticiones = new List<int>();

            foreach (Operacion operacion in Cibercafe.GetHistorial())
            {
                pc = operacion.Cliente.GetDispositivo() as Computadora;
                if (pc is not null)
                {
                    periferico = operacion.Cliente.GetPerifericoNecesario();
                    if (!perifericoMasPedido.Contains<string>(periferico))
                    {
                        perifericoMasPedido.Add(periferico);
                        peticiones.Add(0);
                    }
                    else
                    {
                        peticiones[perifericoMasPedido.IndexOf(periferico)]++;
                    }
                }
            }
            return perifericoMasPedido[peticiones.IndexOf(peticiones.Max())];
        }
        /// <summary>
        /// Obtiene el juego mas pedido por los clientes
        /// </summary>
        /// <returns>Juego con mayor cantidad de peticiones</returns>
        private string ObtenerJuegoMasPedido()
        {
            Computadora pc;
            string juego;
            List<string> juegoMasPedido = new List<string>();
            List<int> peticiones = new List<int>();

            foreach (Operacion operacion in Cibercafe.GetHistorial())
            {
                pc = operacion.Cliente.GetDispositivo() as Computadora;
                if (pc is not null)
                {
                    juego = operacion.Cliente.GetSoftwareNecesario();
                    if (!juegoMasPedido.Contains<string>(juego))
                    {
                        juegoMasPedido.Add(juego);
                        peticiones.Add(0);
                    }
                    else
                    {
                        peticiones[juegoMasPedido.IndexOf(juego)]++;
                    }
                }
            }
            return juegoMasPedido[peticiones.IndexOf(peticiones.Max())];
        }
        /// <summary>
        /// Muestra un listado con todas las operaciones realizadas por el cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarOperaciones_Click(object sender, EventArgs e)
        {
            DesactivarDataGrids();
            dgvOperaciones.Show();
            string horaInicio;
            string horaFin;
            foreach(Operacion operacion in Cibercafe.GetHistorial())
            {
                horaInicio = ParsearHora(operacion.Cliente.HoraInicio);
                horaFin = ParsearHora(operacion.Cliente.HoraFinalizacion);
                DataGridViewRow fila = dgvOperaciones.Rows[dgvOperaciones.Rows.Add()];
                fila.SetValues(operacion.Cliente.GetDispositivo().ObtenerId(), $"{operacion.Cliente.Nombre} " + operacion.Cliente.Apellido,
                                horaInicio, horaFin, operacion.Monto);
            }
        }
        /// <summary>
        /// Parsea la hora recibida como parametro a string, ignorando el componente de milisegundos
        /// </summary>
        /// <param name="hora">Hora a parsear</param>
        /// <returns></returns>
        private string ParsearHora(DateTime hora)
        {
            string horaStr;
            horaStr = string.Format("{0:00}:{1:00}:{2:00}", hora.Hour, hora.Minute, hora.Second);
            return horaStr;
        }
        /// <summary>
        /// Muestra el listado de computadoras, ordenado por tiempo de uso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListarComputadora_Click(object sender, EventArgs e)
        {
            ListarComputadorasPorTiempoDeUso(Cibercafe.GetHistorial());
        }
        /// <summary>
        /// Muestra el listado de telefonos, ordenado por tiempo de uso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListarTelefono_Click(object sender, EventArgs e)
        {
            ListarTelefonosPorTiempoDeUso(Cibercafe.GetHistorial());
        }
        /// <summary>
        /// Muestra el listado de tipo de llamadas, con informacion sobre cada tipo (local, larga distancia o ionternacional)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLlamadas_Click(object sender, EventArgs e)
        {
            MostrarInformacionLlamadas();
        }
        /// <summary>
        /// Cierra el formulario del historial y vuelve al formulario principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
