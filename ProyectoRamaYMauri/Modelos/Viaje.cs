using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRamaYMauri.Modelos
{
    public class Viaje
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public string Direccion_De_Salida { get; set; }
        public string Direccion_De_Llegada { get; set; }
        public Pasajero pasajero { get; set; }
        public Auto auto { get; set; }

        public override string ToString()
        {
            return $"|id: {this.id} |fecha: {this.fecha} |Direccion de salida: {this.Direccion_De_Salida} |DNI del pasajero: {pasajero.DNI} |patente del vehiculo: {auto.patente} |Destino de viaje: {Direccion_De_Llegada} |";
        }
    }
}
