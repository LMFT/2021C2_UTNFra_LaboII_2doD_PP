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
        }

        
        
        //Lista de computadoras ordenadas por minutos de uso de forma descendente.
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
            dgvDispositivos.Enabled = true;
        }

        private void AgregarDispositivoADataGrid(Dispositivo dispositivo, double tiempoUso)
        {
            int index = dgvDispositivos.Rows.Add();
            DataGridViewRow fila = dgvDispositivos.Rows[index];
            fila.SetValues(dispositivo.ObtenerId(), tiempoUso);
        }

        private void DesactivarDataGrids()
        {
            foreach(DataGridView dgv in this.Controls)
            {
                dgv.Enabled = false;
            }
        }

        private double[] CalcularTiempoDeUso(List<Computadora> lista, List<Operacion> historial)
        {
            double[] tiempoUso = new double[lista.Count];
            Computadora pcCliente;
            foreach (Operacion operacion in historial)
            {
                pcCliente = operacion.Cliente.Dispositivo as Computadora;
                if(pcCliente is not null)
                {
                    tiempoUso[lista.IndexOf(pcCliente)] += operacion.GetTiempoUso();
                }
            }
            return tiempoUso;
        }

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

        //Lista de cabinas ordenadas por minutos de uso de forma descendente.
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
            dgvDispositivos.Enabled = true;
        }

        

        private double[] CalcularTiempoDeUso(List<Telefono> lista, List<Operacion> historial)
        {
            double[] tiempoUso = new double[lista.Count];
            Telefono telefono;
            foreach (Operacion operacion in historial)
            {
                telefono = operacion.Cliente.Dispositivo as Telefono;
                if (telefono is not null)
                {
                    tiempoUso[lista.IndexOf(telefono)] += operacion.GetTiempoUso();
                }
            }
            return tiempoUso;
        }

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
        //Ganancias totales y clasificadas por servicio (teléfono/computadora).
        private double CalcularGananciasTotales()
        {
            double montoAcumulado = 0;
            foreach(Operacion operacion in Cibercafe.GetHistorial())
            {
                montoAcumulado += operacion.Monto;
            }
            return montoAcumulado;
        }

        private void ClasificarGanancias (out double gananciaPc, out double gananciaTelefono)
        {
            gananciaPc = 0;
            gananciaTelefono = 0;
            
            foreach(Operacion operacion in Cibercafe.GetHistorial())
            {
                if(operacion.Cliente.Dispositivo.GetType() == typeof(Computadora))
                {
                    gananciaPc += operacion.Monto;
                }
                else
                {
                    gananciaTelefono += operacion.Monto;
                }
            }
        }
        //Horas totales y la recaudación por tipo de llamada.
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
            dgvTipoLlamada.Enabled = true;
        }

        private void AgregarLlamadaADataGridView(double horasTotales, double minutosTotales, double recaudaciones)
        {
            int index = dgvTipoLlamada.Rows.Add();
            DataGridViewRow fila = dgvTipoLlamada.Rows[index];
            fila.SetValues((TipoLlamada)index, horasTotales, minutosTotales, recaudaciones);
        }

        private void CargarInformacionLlamadas(double[] horasTotales, double[] minutosTotales, double[] recaudaciones)
        {
            Telefono telefono;
            foreach (Operacion operacion in Cibercafe.GetHistorial())
            {
                telefono = operacion.Cliente.Dispositivo as Telefono;
                if (telefono is not null)
                {
                    int index = (int)telefono.GetLlamada().Tipo;
                    minutosTotales[index] += operacion.GetTiempoUso();
                    if(minutosTotales[index] >= 60)
                    {
                        horasTotales[index]++;
                        minutosTotales[index] -= 60;
                    }
                recaudaciones[index] += operacion.Monto;
                }
            }
        }
        //El software más pedido por los clientes.
        private string ObtenerSoftwareMasPedido()
        {
            Computadora pc;
            string software;
            List<string> softwareMasPedido = new List<string>();
            List<int> peticiones = new List<int>();

            foreach(Operacion operacion in Cibercafe.GetHistorial())
            {
                pc = operacion.Cliente.Dispositivo as Computadora;
                if(pc is not null)
                {
                    software = operacion.Cliente.SoftwareNecesario;
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
        //El periférico más pedido por los clientes.
        private string ObtenerPerifericoMasPedido()
        {
            Computadora pc;
            string periferico;
            List<string> perifericoMasPedido = new List<string>();
            List<int> peticiones = new List<int>();

            foreach (Operacion operacion in Cibercafe.GetHistorial())
            {
                pc = operacion.Cliente.Dispositivo as Computadora;
                if (pc is not null)
                {
                    periferico = operacion.Cliente.PerifericoNecesario;
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
        //El juego más pedido por los clientes.
        private string ObtenerJuegoMasPedido()
        {
            Computadora pc;
            string juego;
            List<string> juegoMasPedido = new List<string>();
            List<int> peticiones = new List<int>();

            foreach (Operacion operacion in Cibercafe.GetHistorial())
            {
                pc = operacion.Cliente.Dispositivo as Computadora;
                if (pc is not null)
                {
                    juego = operacion.Cliente.SoftwareNecesario;
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


    }
}
