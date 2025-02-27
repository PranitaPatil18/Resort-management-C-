using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resort_Management;

namespace ResortManagement
{
    public partial class Restro : Form
    {
        public Restro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.resourcereport("Select * from resource");
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.resourcereport1("Select * from staff3");
            frm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.resourcereport2("Select * from View_1");
            frm.Show();

        }

        private void Restro_Load(object sender, EventArgs e)
        {
            button1.Hide();
            button3.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            staff stf = new staff();
            stf.Show();
            this.Hide();
        }
    }
}
