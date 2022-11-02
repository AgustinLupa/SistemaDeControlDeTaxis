using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRamaYMauri.Modelos
{
    public class Auto
    {
        public int id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string patente { get; set; }
        public bool Disponibilidad { get; set; }
        public override string ToString()
        {
            return $"ID={id} Marca={Marca} Modelo={Modelo} Patente= {patente}";
        }
    }
}
