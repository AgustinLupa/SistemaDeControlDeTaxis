using ProyectoRamaYMauri.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRamaYMauri.Vistas
{
    public partial class CambiarDisponibilidad : Form
    {
        IControladorAutos autos;
        IControladorViaje viaje;
        int c = 0;
        public CambiarDisponibilidad(IControladorAutos controladorAutos, IControladorViaje controladorViaje)
        {
            InitializeComponent();
            this.autos = controladorAutos;
            this.viaje = controladorViaje;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void CambiarDisponibilidad_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        public void Actualizar()
        {
            lbAutoNoDispo.DataSource = null;
            lbAutoNoDispo.DataSource = autos.ListaDeAutosNoDispo();
        }

        private void lbAutoNoDispo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (c > 0)
            {
                pDestino.Enabled = true;
                pDestino.Visible = true;
            }
            c++;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(viaje.ActualizarXLlegada(lbAutoNoDispo.SelectedIndex, txtLugarDeDestino.Text));
                MessageBox.Show(autos.ActualizarDispoDeAutosNoDisponibles(lbAutoNoDispo.SelectedIndex));
                Actualizar();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pDestino.Enabled = false;
            pDestino.Visible = false;
        }

        private void btnCancelarPan_Click(object sender, EventArgs e)
        {
            pDestino.Enabled = false;
            pDestino.Visible = false;
        }
    }
}
