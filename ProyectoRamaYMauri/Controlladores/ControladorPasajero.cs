using ProyectoRamaYMauri.Datos;
using ProyectoRamaYMauri.Interfaces;
using ProyectoRamaYMauri.Modelos;
using System.Collections.Generic;
using System.Net;

namespace ProyectoRamaYMauri.Controlladores
{
    public class ControladorPasajero : IControladorPasajero
    {
        DataPasajeros DataPasajeros = new DataPasajeros();

        public string CrearPasajero(string nombre, string apellido, int DNI, string TEL)
        {
            if(nombre != "" && apellido != "" && TEL != "")
            {
                return DataPasajeros.Crear(nombre, apellido, DNI, TEL);
            }
            return "Faltan datos";
        }

        public string ActualizarPasajero(int id, string nombre, string apellido, int DNI, string TEL)
        {
            if (nombre != "" && apellido != "" && TEL != "")
            {
                return DataPasajeros.Actualizar(id, nombre, apellido, DNI, TEL);
            }
            return "Faltan Datos";   
        }

        public List<Pasajero> List()
        {
            return DataPasajeros.List();
        }

        public Pasajero BuscarXDNI(int DNI)
        {
            List<Pasajero> lista = List();
            foreach (Pasajero pasajero1 in lista)
            {
                if (pasajero1.DNI == DNI) {
                    return pasajero1;
                }
            }
            return null;
        }

        public Pasajero BuscarXID(int id)
        {
            List<Pasajero> lista = List();
            foreach (Pasajero pasajero1 in lista)
            {
                if (pasajero1.id == id)
                {
                    return pasajero1;
                }
            }
            return null;
        }
    }
}
