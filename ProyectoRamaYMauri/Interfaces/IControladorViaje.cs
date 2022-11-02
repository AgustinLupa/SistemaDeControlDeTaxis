using ProyectoRamaYMauri.Controlladores;
using ProyectoRamaYMauri.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRamaYMauri.Interfaces
{
    public interface IControladorViaje
    {
        string CrearViaje(int id_auto, int id_pasajero, string Direccion_De_Salida);

        string Actualizar(int id, DateTime fecha, int id_auto, int id_pasajero, string Direccion_De_Salida, string Direccion_De_Llegada);

        List<Viaje> Listar(ControladorPasajero controladorPasajero, ControladorAutos controladorAutos);

        string ActualizarXLlegada(int id_auto, string Direccion_de_llegada);
    }
}
