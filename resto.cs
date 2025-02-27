using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using System.Data.SqlClient;
using ResortManagement;

namespace Resort_Management
{
    public partial class resto : Form
    {
        public object errorProvider1 { get; private set; }

        public resto()
        {
            InitializeComponent();
        }

        private void resto_Load(object sender, EventArgs e)
        {
            // button1_start.Show();
            //  panel1.Hide();
            //   panel2.Hide();
            // button1.Hide();
            this.Show();
           // MessageBox.Show("You Are In Restaurant Manager Module");
            
        }

        private void button1_start_Click(object sender, EventArgs e)
        {
           //  panel1.Show();
           //  panel2.Hide();
             this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Show();
            this.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(textBox1.Text.Trim());
            if (!isValid)
            {
               // errorProvider1.se(textBox1, "Invalid");
                MessageBox.Show("Please enter digits only!");
                textBox1.Focus();
                return;
            }
            else
            {
               // errorProvider1.Clear();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Beverage bv = new Beverage();
            bv.Show();
        }

        private void button1_start_Click_1(object sender, EventArgs e)
        {
            panel1.Show();
          //  panel2.Show();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        
            string id = textBox1.Text;
            string foodname = textBox2.Text;
            string foodtype = comboBox1.Text;
            string quaninty = textBox3.Text;
            string total = textBox4.Text;
           

            SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa; Password=me123;");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                cmd.Connection = con;
                cmd.CommandText = string.Format("Insert into fooditen values({0},'{1}','{2}',{3},{4})",
             
               dataGridView1.Rows[i].Cells[0].Value,
               dataGridView1.Rows[i].Cells[1].Value,
              dataGridView1.Rows[i].Cells[2].Value,
               dataGridView1.Rows[i].Cells[3].Value,
               dataGridView1.Rows[i].Cells[4].Value,
               textBox4.Text);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
             
            }
            MessageBox.Show("Data Saved Successfully");
               
          

            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            dataGridView1.ColumnCount = 5;
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();

            this.dataGridView1.DataBindings.Clear();

            dataGridView1.Columns[0].Name = "Item Id";
            dataGridView1.Columns[1].Name = "Food Name";
            dataGridView1.Columns[2].Name = "Food Type";
            dataGridView1.Columns[3].Name = "Quantity";
            dataGridView1.Columns[4].Name = "Total";

            row.Cells[0].Value = textBox1.Text;
            row.Cells[1].Value = textBox2.Text;
            row.Cells[2].Value = comboBox1.Text;
            row.Cells[3].Value = textBox3.Text;
            row.Cells[4].Value = textBox5.Text;


            dataGridView1.Rows.Add(row);
            if (MessageBox.Show("Do You want to Add Another Item", "ADD", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {


                textBox1.Text = " ";
                textBox2.Text = " ";
                comboBox1.Text = " ";
                textBox3.Text = " ";
                textBox5.Text = " ";
                textBox1.Focus();
                disccal();


            }
            else {
                textBox1.Text = " ";
                textBox2.Text = " ";
                comboBox1.Text = " ";
                textBox3.Text = " ";
                textBox5.Text = " ";
                textBox5.Focus();
                disccal();


            }       
           




        }


        public void disccal()
        {
            try
            {
                double sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    sum += double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                }
                textBox4.Text = sum.ToString("0.00");
               
            }
            catch
            {
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(textBox5.Text.Trim());
            if (!isValid)
            {
                // errorProvider1.SetError(textBox3, "Invalid");
                MessageBox.Show("Please enter digits only!");
                textBox5.Focus();
                return;
            }
            else
            {
                //  errorProvider1.Clear();
            }
        
    }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bill bl = new Bill();
            bl.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(textBox3.Text.Trim());
            if (!isValid)
            {
               // errorProvider1.SetError(textBox3, "Invalid");
                MessageBox.Show("Please enter digits only!");
                textBox3.Focus();
                return;
            }
            else
            {
              //  errorProvider1.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[a-zA-z]$");
            bool isValid = reg.IsMatch(textBox2.Text.Trim());
            if (!isValid)
            {
              //  errorProvider1.SetError(textBox2, "Invalid");
                MessageBox.Show("Please enter characters only!");
                textBox2.Focus();
                return;
            }
            else
            {
               // errorProvider1.Clear();
            }
        }
    }
    }