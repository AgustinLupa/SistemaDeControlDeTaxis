using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRamaYMauri.Datos
{
    internal class ConeccionSQL
    {
        private SqlConnection _conection = new SqlConnection("Data source =MSI\\SQLEXPRESS; Initial catalog = Taxi; integrated security = true;TrustServerCertificate=true");        
        public void Open()
        {
            _conection.Open();
        }
        public void Close()
        {
            _conection.Close();
        }

        public SqlConnection Conect()
        {
            return _conection;
        }
    }
}
