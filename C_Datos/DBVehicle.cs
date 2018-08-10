using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using C_Negocio;

namespace C_Datos
{
    public class DBVehicle
    {
        Database DB = new Database();
        SqlConnection cn;
        public void IngresarVehicle(nVehicle c)
        {
            cn = DB.ConectarBD();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("", c);
            cmd.ExecuteNonQuery();
        }
        public void ModificarVehicle(nVehicle c)
        {
            cn = DB.ConectarBD();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("", c);
            cmd.ExecuteNonQuery();
        }
        public void EliminarVehicle(String c)
        {
            cn = DB.ConectarBD();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("", c);
            cmd.ExecuteNonQuery();
        }
    }
}
