using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Presentacio
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 i = new Form1();
            i.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ag_Form3 i = new Ag_Form3();
            i.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Taller_Form3 i = new Taller_Form3();
            i.Show();
        }
    }
}
