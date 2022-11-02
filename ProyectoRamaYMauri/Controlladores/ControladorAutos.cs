using ProyectoRamaYMauri.Datos;
using ProyectoRamaYMauri.Interfaces;
using ProyectoRamaYMauri.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProyectoRamaYMauri.Controlladores
{
    public class ControladorAutos :IControladorAutos
    {
        DataAutos DataAutos = new DataAutos();

        public string CrearAuto(string marca, string modelo, string patente, bool Disponibilidad)
        {
            return DataAutos.Crear(marca, modelo, patente, Disponibilidad);
        }

        public string ActualizarAuto(int id, string marca, string modelo, string patente, bool Disponibilidad)
        {
            return DataAutos.Actualizar(id, marca, modelo, patente, Disponibilidad);
        }

        public List<Auto> Listar()
        {
            return DataAutos.List();
        }

        public string ActualizarDispoDeAutosDisponibles(int id)
        {
            int cont = 0;
            List<Auto> list = ListaDeAutosDispo();
            foreach (Auto item in list)
            {
                cont++;
                if (id == cont)
                {
                    return DataAutos.ActulizarDispo(item.id, false);
                }                
            }
            return null;
        }

        public string ActualizarDispoDeAutosNoDisponibles(int id)
        {
            int cont = 0;
            List<Auto> list = ListaDeAutosNoDispo();
            foreach (Auto item in list)
            {                
                if (id == cont)
                {
                    return DataAutos.ActulizarDispo(item.id, true);
                }
                cont++;
            }
            return null;
        }

        public List<Auto> ListaDeAutosDispo()
        {
            List<Auto> listaAux = new List<Auto>();
            List<Auto> lista = Listar();
            foreach (Auto item in lista)
            {
                if (item.Disponibilidad)
                {
                    listaAux.Add(item);
                }
            }
            return listaAux;
        }

        public List<Auto> ListaDeAutosNoDispo()
        {
            List<Auto> listaAux = new List<Auto>();
            List<Auto> lista = Listar();
            foreach (Auto item in lista)
            {
                if (!item.Disponibilidad)
                {
                    listaAux.Add(item);
                }
            }
            return listaAux;
        }

        public Auto BuscarXID(int id)
        {
            List<Auto> lista = Listar();
            foreach (Auto item in lista)
            {
                if (item.id == id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
