using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace C_Presentacio
{
    public partial class Ag_Form3 : Form
    {
        public Ag_Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ag_Form3_Load(object sender, EventArgs e)
        {
            String ConnectionString = "Server=.;Database=Winter;Trusted_Connection=true";
            var query = @"select CustomerID, Name, Phone, VehicleID_FK, email from Customer";
            var cnx = new SqlConnection(ConnectionString);
            var command = new SqlCommand(query, cnx);

            var dataAdapter = new SqlDataAdapter(command);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}
