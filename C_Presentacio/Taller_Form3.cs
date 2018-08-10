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
    public partial class Taller_Form3 : Form
    {
        public Taller_Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Propuesta enviada");
            textBox2.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Taller_Form3_Load(object sender, EventArgs e)
        {
            String ConnectionString = "Server=Winter2;Database=Winter;Trusted_Connection=true";
          
            var query = @"select date, Status, Location from Incident";
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
