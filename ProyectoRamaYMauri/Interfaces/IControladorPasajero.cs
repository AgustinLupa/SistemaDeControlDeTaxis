using ProyectoRamaYMauri.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRamaYMauri.Interfaces
{
    public interface IControladorPasajero
    {
        string CrearPasajero(string nombre, string apellido, int DNI, string TEL);
        string ActualizarPasajero(int id, string nombre, string apellido, int DNI, string TEL);
        List<Pasajero> List();
        Pasajero BuscarXDNI(int DNI);

    }
}
