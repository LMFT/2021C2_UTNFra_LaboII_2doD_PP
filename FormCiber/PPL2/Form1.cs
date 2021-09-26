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
        private string dispositivoSeleccionado; 
        public FormCiber()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dispositivoSeleccionado = String.Empty;
        }

        private void btnPc1_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = "C01";

        }

        private void btnPc2_Click_1(object sender, EventArgs e)
        {
            dispositivoSeleccionado = "C02";
        }

        private void btnPc3_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = "C03";
        }

        private void btnPc4_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = "C04";
        }

        private void btnPc5_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = "C05";
        }

        private void btnPc6_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = "C06";
        }

        private void btnPc7_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = "C07";
        }

        private void btnPc8_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = "C08";
        }

        private void btnPc9_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = "C09";
        }

        private void btnPc10_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = "C10";
        }

        private void btnT1_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = "T01";
        }

        private void btnT2_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = "T02";
        }

        private void btnT3_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = "T03";
        }

        private void btnT4_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = "T04";
        }

        private void btnT5_Click(object sender, EventArgs e)
        {
            dispositivoSeleccionado = "T05";
        }
    }
}
