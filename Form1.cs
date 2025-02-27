using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resort_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();
                login lg = new login();
                lg.Show();
                this.Hide();
            }
           
        

           
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
