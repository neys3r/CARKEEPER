using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace C_Datos
{
    class Database
    {
        private SqlConnection conn;
        public SqlConnection ConectarBD()
        {
            try
            {
                var cadenaconexion = "Server=Winter;Database=Winter;Trusted_Connection=True;";
                conn = new SqlConnection(cadenaconexion);
                conn.Open();
                return conn;
            }
            catch (SqlException ex)
            {
                return null;
            }
        }
        public void DesconectarBD()
        {
            conn.Close();
        }
    }
}
