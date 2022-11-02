using ProyectoRamaYMauri.Controlladores;
using ProyectoRamaYMauri.Interfaces;
using ProyectoRamaYMauri.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRamaYMauri
{
    public partial class MainForm : Form
    {
        ControladorAutos controlAutos = new ControladorAutos();
        ControladorPasajero controlPasajero = new ControladorPasajero();
        ControladorViajes controlViajes = new ControladorViajes();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            Autos autos = new Autos(controlAutos, controlPasajero, controlViajes);
            autos.Owner = this;            
            this.Hide();
            autos.ShowDialog();
        }

        private void lbViajes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnViajeRealizado_Click(object sender, EventArgs e)
        {            
            pViajes.Enabled = true;
            pViajes.Visible = true;
            lbViajes.DataSource = null;
            lbViajes.DataSource = controlViajes.Listar(controlPasajero, controlAutos);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pViajes.Enabled = false;
            pViajes.Visible = false;
        }

        private void btnCambiarDispo_Click(object sender, EventArgs e)
        {
            CambiarDisponibilidad cambiar = new CambiarDisponibilidad(controlAutos, controlViajes);
            cambiar.Owner = this;
            this.Hide();
            cambiar.ShowDialog();
        }
    }
}
