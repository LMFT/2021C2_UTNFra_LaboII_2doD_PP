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
        public FormCiber()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stbBarraInformacion.Controls["tsslFecha"].Text += DateTime.Today.ToString();
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


    }
}
