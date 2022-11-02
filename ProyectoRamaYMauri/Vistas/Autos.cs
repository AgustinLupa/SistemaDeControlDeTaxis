using ProyectoRamaYMauri.Controlladores;
using ProyectoRamaYMauri.Excepciones;
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
    public partial class Autos : Form
    {
        IControladorAutos ControlAutos;
        IControladorPasajero ControladorPasajero;
        IControladorViaje ControladorViaje;
        int c = 0;
        int auxcont =1;
        public Autos(IControladorAutos controladorAutos, IControladorPasajero controlPasajero, IControladorViaje controlViajes)
        {            
            InitializeComponent();
            this.ControlAutos = controladorAutos;
            this.ControladorPasajero= controlPasajero;
            this.ControladorViaje = controlViajes;
            Actualizar();
        }

        private void lbAuto_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (c>0)
            {                
                PAltaPasajero.Enabled = true;
                PAltaPasajero.Visible = true;
            }
            c++;
        }

        private void brnVolverMenu_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        public void Actualizar()
        {
            lbAuto.DataSource = null;
            lbAuto.DataSource = this.ControlAutos.ListaDeAutosDispo();           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ControladorPasajero.BuscarXDNI((int)numDNI.Value) == null)
                {
                    if (ControladorPasajero.CrearPasajero(txtNombre.Text, txtApellido.Text, (int)numDNI.Value, txtTel.Text) != "Faltan Datos")
                    {
                        if (ControladorViaje.CrearViaje(lbAuto.SelectedIndex, ControladorPasajero.BuscarXDNI((int)numDNI.Value).id, txtSalida.Text) != "Falta la dirreccion")
                        {
                            auxcont += lbAuto.SelectedIndex;
                            MessageBox.Show(ControladorViaje.CrearViaje(auxcont, ControladorPasajero.BuscarXDNI((int)numDNI.Value).id, txtSalida.Text));
                            MessageBox.Show(ControlAutos.ActualizarDispoDeAutosDisponibles(auxcont));
                        }
                        else
                        {
                            MessageBox.Show(ControladorViaje.CrearViaje(lbAuto.SelectedIndex, ControladorPasajero.BuscarXDNI((int)numDNI.Value).id, txtSalida.Text));
                        }
                        Actualizar();
                        PAltaPasajero.Enabled = false;
                        PAltaPasajero.Visible = false;
                    }
                    MessageBox.Show(ControladorPasajero.CrearPasajero(txtNombre.Text, txtApellido.Text, (int)numDNI.Value, txtTel.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(ControladorViaje.CrearViaje(lbAuto.SelectedIndex, ControladorPasajero.BuscarXDNI((int)numDNI.Value).id, txtSalida.Text) != "Falta la dirreccion")
                    {
                        MessageBox.Show(ControladorPasajero.ActualizarPasajero(ControladorPasajero.BuscarXDNI((int)numDNI.Value).id, txtNombre.Text, txtApellido.Text, (int)numDNI.Value, txtTel.Text));
                        auxcont += lbAuto.SelectedIndex;
                        MessageBox.Show(ControladorViaje.CrearViaje(auxcont, ControladorPasajero.BuscarXDNI((int)numDNI.Value).id, txtSalida.Text));
                        MessageBox.Show(ControlAutos.ActualizarDispoDeAutosDisponibles(auxcont));
                    }
                    else
                    {
                        MessageBox.Show(ControladorViaje.CrearViaje(lbAuto.SelectedIndex, ControladorPasajero.BuscarXDNI((int)numDNI.Value).id, txtSalida.Text));
                    }                                        
                    Actualizar();
                    PAltaPasajero.Enabled = false;
                    PAltaPasajero.Visible = false;
                }                
            }           
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PAltaPasajero.Enabled = false;
            PAltaPasajero.Visible = false;
        }

        private void Autos_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if(ControladorPasajero.BuscarXDNI(Convert.ToInt32(numDNI.Value)) != null)
                {
                    txtNombre.Text = ControladorPasajero.BuscarXDNI(Convert.ToInt32(numDNI.Value)).nombre;
                    txtApellido.Text = ControladorPasajero.BuscarXDNI(Convert.ToInt32(numDNI.Value)).apellido;
                    txtTel.Text = ControladorPasajero.BuscarXDNI(Convert.ToInt32(numDNI.Value)).TEL;
                }
                else
                {
                    throw new DNINoEncontradoException("No se encontro el Cliente con su DNI");
                }
                
            }
            catch (DNINoEncontradoException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}