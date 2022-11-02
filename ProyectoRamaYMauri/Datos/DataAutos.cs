using ProyectoRamaYMauri.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRamaYMauri.Datos
{
    internal class DataAutos
    {
        private ConeccionSQL _conection = new ConeccionSQL();

        public string Crear(string marca, string modelo, string patente, bool Disponibilidad)
        {
            try
            {
                _conection.Open();
                const string query = @"INSERT INTO autos VALUES (@marca, @modelo, @patente, @Disponibilidad)";
                SqlCommand cmd = new SqlCommand(query, _conection.Conect());
                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@patente", patente);
                cmd.Parameters.AddWithValue("@Disponibilidad", Disponibilidad);
                cmd.ExecuteNonQuery();
                return "Auto Cargado con exito";
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

        public string Actualizar(int id, string marca, string modelo, string patente, bool Disponibilidad)
        {

            try
            {
                _conection.Open();
                const string query = @"UPDATE autos SET marca= @marca, modelo = @modelo, patente= @patente, Disponibilidad= @Disponibilidad WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, _conection.Conect());
                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@patente", patente);
                cmd.Parameters.AddWithValue("@Disponibilidad", Disponibilidad);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                return "Auto Cargado con exito";
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

        public List<Auto> List()
        {
            List<Auto> _autos = new List<Auto>();
            _conection.Open();
            const string query = @"SELECT * FROM autos";
            SqlCommand cmd = new SqlCommand(query, _conection.Conect());
            SqlDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                Auto _auto = new Auto()
                {
                    id = Convert.ToInt32(Reader["id"]),
                    Marca = Convert.ToString(Reader["marca"]),
                    Modelo = Convert.ToString(Reader["modelo"]),
                    patente = Convert.ToString(Reader["patente"]),
                    Disponibilidad = Convert.ToBoolean(Reader["Disponibilidad"])                    
                };
                _autos.Add(_auto);
            }
            _conection.Close();
            return _autos;
        }

        public string ActulizarDispo(int id, bool dispo)
        {
            try
            {                
                _conection.Open();
                const string query = @"UPDATE autos SET Disponibilidad = @dispo where id=@id";
                SqlCommand cmd = new SqlCommand(query, _conection.Conect());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@dispo", dispo);
                cmd.ExecuteNonQuery();
                return "Se cambio la disponibilidad del auto correctamente";
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
    }
}
