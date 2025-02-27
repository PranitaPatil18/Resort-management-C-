using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;


namespace ResortManagement
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String id = foodidtxt.Text;
            String name = custnametxt.Text;
            String price = pricetxt.Text;
            String Quantity = quatytxt.Text;
            SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa; Password=me123;");
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert into Food_Bill values (' " + id + "',' " + name + "',' " + price + "', '" + Quantity + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Saved Successfully...!");
            SqlDataAdapter da = new SqlDataAdapter("Select * from Food_Bill", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
           // dataGridView1.DataSource = dt;
        }

        private void custnametxt_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[a-zA-z]$");
            bool isValid = reg.IsMatch(custnametxt.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(custnametxt, "Invalid");
                MessageBox.Show("Please enter characters only!");
                custnametxt.Focus();
                return;
            }
            else
            {
                object errorProvider1 = null;
                //errorProvider1.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foodidtxt.Text = "";
            custnametxt.Text = "";
            pricetxt.Text = "";
            quatytxt.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String id = beverageidtxt.Text;
            String name = cuttxt.Text;
            String price = prtxt.Text;
            String Quantity = qtxt.Text;
            SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa; Password=me123;");
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert into Beverage_Bill values (' " + id + "',' " + name + "',' " + price + "', '" + Quantity + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Saved Successfully...!");
            SqlDataAdapter da = new SqlDataAdapter("Select * from Beverage_Bill", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            beverageidtxt.Text = "";
            cuttxt.Text = " ";
            prtxt.Text = "";
            qtxt.Text = "";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void foodidtxt_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(foodidtxt.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(foodidtxt, "Invalid");
                MessageBox.Show("Please enter digits only!");
                foodidtxt.Focus();
                return;
            }
            else
            {
                errorProvider1.clear();
            }
        }

        private void pricetxt_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(pricetxt.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(pricetxt, "Invalid");
                MessageBox.Show("Please enter digits only!");
                pricetxt.Focus();
                return;
            }
            else
            {
                errorProvider1.clear();
            }

        }

        private void quatytxt_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(quatytxt.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(quatytxt, "Invalid");
                MessageBox.Show("Please enter digits only!");
                quatytxt.Focus();
                return;
            }
            else
            {
                errorProvider1.clear();
            }
        }

        private void beverageidtxt_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(beverageidtxt.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(beverageidtxt, "Invalid");
                MessageBox.Show("Please enter digits only!");
                beverageidtxt.Focus();
                return;
            }
            else
            {
                errorProvider1.clear();
            }
        }

        private void cuttxt_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[a-zA-z]$");
            bool isValid = reg.IsMatch(cuttxt.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(cuttxt, "Invalid");
                MessageBox.Show("Please enter characters only!");
                cuttxt.Focus();
                return;
            }
            else
            {
                object errorProvider1 = null;
                //errorProvider1.Clear();
            }
        }

        private void prtxt_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(prtxt.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(prtxt, "Invalid");
                MessageBox.Show("Please enter digits only!");
                prtxt.Focus();
                return;
            }
            else
            {
                errorProvider1.clear();
            }
        }

        private void qtxt_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(qtxt.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(qtxt, "Invalid");
                MessageBox.Show("Please enter digits only!");
                qtxt.Focus();
                return;
            }
            else
            {
                errorProvider1.clear();
            }
        }

    //    private void button7_Click_1(object sender, EventArgs e)
      //  {

           
//}
    }
}
