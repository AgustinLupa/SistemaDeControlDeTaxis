using ProyectoRamaYMauri.Datos;
using ProyectoRamaYMauri.Interfaces;
using ProyectoRamaYMauri.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRamaYMauri.Controlladores
{
    public class ControladorViajes : IControladorViaje
    {
        DataViajes DataViajes = new DataViajes();

        public string CrearViaje(int id_auto, int id_pasajero, string Direccion_De_Salida)
        {
            if(Direccion_De_Salida != "")
            {
                DateTime date = DateTime.Now;
                return DataViajes.Crear(date, id_auto, id_pasajero, Direccion_De_Salida);
            }
            return "Falta la dirreccion";
        }

        public string Actualizar(int id, DateTime fecha, int id_auto, int id_pasajero, string Direccion_De_Salida, string Direccion_De_Llegada)
        {
            return DataViajes.Actualizar(id, fecha, id_auto, id_pasajero, Direccion_De_Salida, Direccion_De_Llegada);
        }

        public List<Viaje> Listar(ControladorPasajero controladorPasajero, ControladorAutos controladorAutos)
        {            
            List<Viaje> viajes = DataViajes.List();
            foreach (Viaje viaje in viajes)
            {
                viaje.pasajero.DNI = controladorPasajero.BuscarXID(viaje.pasajero.id).DNI;
                viaje.auto.patente = controladorAutos.BuscarXID(viaje.auto.id).patente;                                        
            }
            return viajes;
        }

        public string ActualizarXLlegada(int id_auto, string Direccion_de_llegada)
        { 
            if (Direccion_de_llegada != "")
            {
                int cont = 0;
                List<Viaje> viajes = DataViajes.List();
                foreach (Viaje viaje in viajes)
                {
                    if (cont == id_auto)
                    {
                        return DataViajes.Actualizar(viaje.id, viaje.fecha, viaje.auto.id, viaje.pasajero.id, viaje.Direccion_De_Salida, Direccion_de_llegada);
                    }
                    cont++;
                }
                return "Ocurrio otro Error inesperado";
            }
            return "Ingrese la direccion primero";
        }
    }
}
