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
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

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
            log.Info("El Agente 1 Aceptó la Incidencia 1");
        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Solicitud aceptada");
           this.Close();
        }
    }
}
