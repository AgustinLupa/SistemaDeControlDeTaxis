using ProyectoRamaYMauri.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRamaYMauri.Datos
{
    internal class DataViajes
    {
        private ConeccionSQL _conection = new ConeccionSQL();

        public string Crear(DateTime fecha, int id_auto, int id_pasajero, string Direccion_De_Salida)
        {
            try
            {
                _conection.Open();
                const string query = @"INSERT INTO Viajes(fecha, id_auto, id_pasajero, lugar_de_salida) VALUES (@fecha, @id_auto, @id_pasajero, @Direccion_De_Salida)";
                SqlCommand cmd = new SqlCommand(query, _conection.Conect());
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@id_auto", id_auto);
                cmd.Parameters.AddWithValue("@id_pasajero", id_pasajero);
                cmd.Parameters.AddWithValue("@Direccion_De_Salida", Direccion_De_Salida);                
                cmd.ExecuteNonQuery();
                return "Viaje Cargado con exito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                _conection.Close();
            }
        }

        public string Actualizar(int id, DateTime fecha, int id_auto, int id_pasajero, string Direccion_De_Salida, string Direccion_De_Llegada)
        {

            try
            {
                _conection.Open();
                const string query = @"UPDATE Viajes SET fecha= @fecha, lugar_de_salida=@Direccion_De_Salida, lugar_de_llegada=@Direccion_De_Llegada, id_auto = @id_auto, id_pasajero= @id_pasajero  WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, _conection.Conect());
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@id_auto", id_auto);
                cmd.Parameters.AddWithValue("@id_pasajero", id_pasajero);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Direccion_De_Salida", Direccion_De_Salida);
                cmd.Parameters.AddWithValue("@Direccion_De_Llegada", Direccion_De_Llegada);
                cmd.ExecuteNonQuery();
                return "Viaje Actualizado con exito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                _conection.Close();
            }
        }

        public List<Viaje> List()
        {
            List<Viaje> _viajes = new List<Viaje>();
            try
            {
                _conection.Open();
                const string query = @"SELECT * FROM Viajes";
                SqlCommand cmd = new SqlCommand(query, _conection.Conect());
                SqlDataReader Reader = cmd.ExecuteReader();
                Auto auto;
                Pasajero pasajero;
                Viaje _viaje;
                while (Reader.Read())
                {
                    auto = new Auto() { id = Convert.ToInt32(Reader["id_auto"]) };
                    pasajero = new Pasajero() { id = Convert.ToInt32(Reader["id_pasajero"]) };
                    _viaje = new Viaje()
                    {
                        id = Convert.ToInt32(Reader["id"]),
                        fecha = Convert.ToDateTime(Reader["fecha"]),
                        auto =  auto,
                        pasajero = pasajero,
                        Direccion_De_Salida = Convert.ToString(Reader["lugar_de_salida"]),
                        Direccion_De_Llegada = Convert.ToString(Reader["lugar_de_llegada"])
                    };
                    _viajes.Add(_viaje);
                }
                return _viajes;
            }
            catch (Exception)
            {                
                return _viajes;
            }
            finally
            {
                _conection.Close();
            }                                               
        }
    }
}
