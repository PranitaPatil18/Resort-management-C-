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
using System.Text.RegularExpressions;

namespace ResortManagement
{
    public partial class Beverage : Form
    {
        public Beverage()
        {
            InitializeComponent();
        }
        int id = 0;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String price = textBox2.Text;
            String Quantity = textBox3.Text;
            SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa; Password=me123;");
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert into Beverage values (' " + name + "',' " + price + "', '" + Quantity + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Saved Successfully...!");
            SqlDataAdapter da = new SqlDataAdapter("Select * from Beverage", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa;Password=me123;");
            con.Open();

            SqlCommand cmd = new SqlCommand("delete from Beverage where id ='" + id + "'");

            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Successfully..");
            SqlDataAdapter da = new SqlDataAdapter("select * from Beverage", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
           // textBox1.Text = "";
           // textBox2.Text = "";
          //  textBox3.Text = "";
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con;
                con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa;Password=me123;");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Beverage Where Id='" + dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {


                    textBox1.Text = dt.Rows[0][0].ToString();
                    textBox2.Text = dt.Rows[0][1].ToString();
                    textBox3.Text = dt.Rows[0][2].ToString();


                }
            }

            catch
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";


            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void Beverage_Load(object sender, EventArgs e)
        {

        }

        private void Beverage_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void Beverage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[a-zA-z]$");
            bool isValid = reg.IsMatch(textBox1.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(textBox1, "Invalid");
                MessageBox.Show("Please enter characters only!");
                textBox1.Focus();
                return;
            }
            else
            {
                object errorProvider1 = null;
                //errorProvider1.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(textBox2.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(textBox2, "Invalid");
                MessageBox.Show("Please enter digits only!");
                textBox2.Focus();
                return;
            }
            else
            {
                errorProvider1.clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(textBox3.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(textBox3, "Invalid");
                MessageBox.Show("Please enter digits only!");
                textBox3.Focus();
                return;
            }
            else
            {
                errorProvider1.clear();
            }
        }
    }
}
