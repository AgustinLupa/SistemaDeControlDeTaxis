using ProyectoRamaYMauri.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRamaYMauri.Datos
{
    internal class DataPasajeros
    {
        private ConeccionSQL _conection = new ConeccionSQL();

        public string Crear(string nombre, string apellido, int DNI, string TEL)
        {
            try
            {
                _conection.Open();
                const string query = @"INSERT INTO Pasajeros VALUES (@nombre, @apellido, @DNI, @TEL)";
                SqlCommand cmd = new SqlCommand(query, _conection.Conect());
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@DNI", DNI);
                cmd.Parameters.AddWithValue("@TEL", TEL);
                cmd.ExecuteNonQuery();
                return "Pasajero Cargado con exito";
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

        public string Actualizar(int id,string nombre, string apellido, int DNI, string TEL)
        {

            try
            {
                _conection.Open();
                const string query = @"UPDATE Pasajeros SET nombre= @nombre, apellido = @apellido, DNI= @DNI, telefono= @TEL WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, _conection.Conect());
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@DNI", DNI);
                cmd.Parameters.AddWithValue("@TEL", TEL);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                return "Pasajero Cargado con exito";
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

        public List<Pasajero> List()
        {
            List<Pasajero> _usuarios = new List<Pasajero>();
            _conection.Open();
            const string query = @"SELECT * FROM Pasajeros";
            SqlCommand cmd = new SqlCommand(query, _conection.Conect());
            SqlDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                Pasajero _usuario = new Pasajero
                {
                    id = Convert.ToInt32(Reader["id"]),
                    nombre = Convert.ToString(Reader["nombre"]),
                    apellido = Convert.ToString(Reader["apellido"]),
                    DNI = Convert.ToInt32(Reader["DNI"]),
                    TEL = Convert.ToString(Reader["telefono"])                    
                };
                _usuarios.Add(_usuario);
            }
            _conection.Close();
            return _usuarios;
        }        
    }
}
