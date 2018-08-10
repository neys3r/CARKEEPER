using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace C_Presentacio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 i = new Form2();
            i.Show();
            this.Hide();
            String ConnectionString = "Server=Winter2;Database=Winter;Trusted_Connection=true";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Incident
                                       (
                                        Status, Location, date, CustomerID_FK, AgentID_FK
                                        , SupplierID_FK
                                       )
                                 VALUES
                                       ( 
                                        @Status, @Location, @date, @CustomerID_FK, @AgentID_FK
                                        , @SupplierID_FK)";


            cmd.CommandType = CommandType.Text;
            cmd.Connection = new SqlConnection("Server=Winter2;Database=Winter;Trusted_Connection=true");
            cmd.Connection.Open();
            //cmd.Parameters.AddWithValue("@IncidentID", 1);
            cmd.Parameters.AddWithValue("@Status", "Problema encontrado");
            cmd.Parameters.AddWithValue("@Location", "Miranda 1789");
            cmd.Parameters.AddWithValue("@date", "2018-08-11");
            cmd.Parameters.AddWithValue("@CustomerID_FK", 1);
            cmd.Parameters.AddWithValue("@AgentID_FK", 1);
            cmd.Parameters.AddWithValue("@SupplierID_FK", 1);
            cmd.ExecuteNonQuery();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
