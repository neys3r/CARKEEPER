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
using System.Data;
using C_Datos;
using C_Entidad;
namespace C_Presentacio
{
    public partial class Form2 : Form
    {
        Agent agente = new Agent();
        Database DB = new Database();
        
        SqlConnection cn;
        public Form2()
        {
            InitializeComponent();
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            String ConnectionString = "Server=Winter2;Database=Winter;Trusted_Connection=true";
            var query = @"select top 1 A.AgentID, A.ID, A.Name from Agent A";
            var cnx = new SqlConnection(ConnectionString);
            var command = new SqlCommand(query, cnx);

            var dataAdapter = new SqlDataAdapter(command);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.AutoGenerateColumns = false;
           dataGridView1.DataSource = dataSet.Tables[0];
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
