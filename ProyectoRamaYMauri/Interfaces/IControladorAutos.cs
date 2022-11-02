using ProyectoRamaYMauri.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRamaYMauri.Interfaces
{
    public interface IControladorAutos
    {
        string CrearAuto(string marca, string modelo, string patente, bool Disponibilidad);
        string ActualizarAuto(int id, string marca, string modelo, string patente, bool Disponibilidad);
        List<Auto> Listar();
        string ActualizarDispoDeAutosDisponibles(int id);
        string ActualizarDispoDeAutosNoDisponibles(int id);
        List<Auto> ListaDeAutosDispo();
        List<Auto> ListaDeAutosNoDispo();
        Auto BuscarXID(int id);
    }
}
