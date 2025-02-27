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

using ResortManagement;
using Resort_Management;

namespace ResortManagement
{
    public partial class sport : Form
    {
        public sport()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                String name = textBox6.Text;
                String mobile = textBox5.Text;
                String address = textBox4.Text;
                String joindate = Join_date.Text;
                String salary = textBox2.Text;
                SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa; Password=me123;");
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert into Trainer values (' " + name + "',' " + mobile + "', '" + address + "', '" + joindate + "', '" + salary + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfully...!");
                SqlDataAdapter da = new SqlDataAdapter("Select * from Trainer", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (panel2.Visible == true)

            {

                String name = textBox10.Text;
                String type = textBox9.Text;
                String quantity = textBox8.Text;

                SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa; Password=me123;");
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert into Equipment values (' " + name + "',' " + type + "', '" + quantity + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfully...!");
                SqlDataAdapter da = new SqlDataAdapter("Select * from Equipment", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            else if (panel3.Visible == true)
            {
                String cus_name = textBox15.Text;
                String fees = textBox14.Text;
                String mobile = textBox13.Text;

                SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa; Password=me123;");
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert into Entryfees values (' " + cus_name + "',' " + fees + "', '" + mobile + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfully...!");
                SqlDataAdapter da = new SqlDataAdapter("Select * from Entryfees", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sport_Load(object sender, EventArgs e)
        {

            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;

            panel2.Show();
            panel1.Hide();
            panel3.Hide();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            panel3.Show();
            panel1.Hide();
            panel2.Hide();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                try
                {
                    SqlConnection con;
                    con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa;Password=me123;");
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from Trainer Where name='" + dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {


                        textBox6.Text = dt.Rows[0][0].ToString();
                        textBox5.Text = dt.Rows[0][1].ToString();
                        textBox4.Text = dt.Rows[0][2].ToString();
                        Join_date.Text = dt.Rows[0][3].ToString();
                        textBox2.Text = dt.Rows[0][4].ToString();


                    }
                }

                catch
                {
                    textBox6.Text = "";
                    textBox5.Text = "";
                    textBox4.Text = "";
                    Join_date.Text = "";
                    textBox2.Text = "";

                }
            }

            else if (panel2.Visible == true)
            {

                try
                {
                    SqlConnection con;
                    con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa;Password=me123;");
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from Equipment Where name='" + dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {


                        textBox10.Text = dt.Rows[0][0].ToString();
                        textBox9.Text = dt.Rows[0][1].ToString();
                        textBox8.Text = dt.Rows[0][2].ToString();



                    }
                }

                catch
                {
                    textBox10.Text = "";
                    textBox9.Text = "";
                    textBox8.Text = "";

                }

            }

            else if (panel3.Visible == true)
            {

                try
                {
                    SqlConnection con;
                    con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa;Password=me123;");
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from Entryfees Where name='" + dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {


                        textBox15.Text = dt.Rows[0][0].ToString();
                        textBox14.Text = dt.Rows[0][1].ToString();
                        textBox13.Text = dt.Rows[0][2].ToString();



                    }
                    else
                    {
                        MessageBox.Show("something went's wrong....");
                    }


                }

                catch
                {
                    textBox15.Text = "";
                    textBox14.Text = "";
                    textBox13.Text = "";


                }

            }

        }

        private void DisplayData()
        {
            if (panel1.Visible == true)

            {

                SqlConnection con;
                con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa;Password=me123;");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Trainer Where name='" + dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // con.Open();

                dataGridView1.DataSource = dt;
                con.Close();
            }

            else if (panel2.Visible == true)
            {

                SqlConnection con;
                con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa;Password=me123;");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Equipment Where name='" + dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // con.Open();

                dataGridView1.DataSource = dt;
                con.Close();
            }

            else if (panel3.Visible == true)
            {

                SqlConnection con;
                con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa;Password=me123;");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Entryfees Where name='" + dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // con.Open();

                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                SqlConnection con;
                con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa;Password=me123;");
                con.Open();

                SqlCommand cmd = new SqlCommand("delete from Trainer where name ='" + textBox6.Text + "'");

                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully..");
                SqlDataAdapter da = new SqlDataAdapter("select * from Trainer", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                textBox6.Text = "";
                textBox5.Text = "";
                textBox4.Text = "";
                Join_date.Text = "";
                textBox2.Text = "";
                dataGridView1.DataSource = dt;
            }

            else if (panel2.Visible == true)
            {
                SqlConnection con;
                con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa;Password=me123;");
                con.Open();

                SqlCommand cmd = new SqlCommand("delete from Equipment where name ='" + textBox10.Text + "'");

                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully..");
                SqlDataAdapter da = new SqlDataAdapter("select * from Equipment", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                textBox10.Text = "";
                textBox9.Text = "";
                textBox8.Text = "";
                
                dataGridView1.DataSource = dt;

            }

            else if (panel3.Visible == true)
            {
                SqlConnection con;
                con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa;Password=me123;");
                con.Open();

                SqlCommand cmd = new SqlCommand("delete from Entryfees where name ='" + textBox15.Text + "'");

                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully..");
                SqlDataAdapter da = new SqlDataAdapter("select * from Entryfees", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                textBox15.Text = "";
                textBox14.Text = "";
                textBox13.Text = "";

                dataGridView1.DataSource = dt;

            }

            else
            {
                MessageBox.Show("something went's wrong....");
            }





        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                SqlConnection con;
                con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa;Password=me123;");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Trainer set  mobile='" + textBox5.Text + "', address='" + textBox4.Text + "',joindate='" + Join_date.Text + "', salary='" + textBox2.Text +  "' Where name='" + textBox6.Text + "'", con);
             
                cmd.Parameters.AddWithValue("@name", textBox6.Text);
                cmd.Parameters.AddWithValue("@mobile", textBox5.Text);
                cmd.Parameters.AddWithValue("@address", textBox4.Text);
                cmd.Parameters.AddWithValue("@joindate", Join_date.Text);
                cmd.Parameters.AddWithValue("@salary", textBox2.Text);
               
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                 DisplayData();
                textBox6.Text = "";
                textBox5.Text = "";
                textBox4.Text = "";
                Join_date.Text = "";
                textBox2.Text = "";


            }
            else if (panel2.Visible == true)
            {

                SqlConnection con;
                con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa;Password=me123;");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Equipment set  type='" + textBox9.Text + "', quantity='" + textBox8.Text +  "' Where name='" + textBox10.Text + "'", con);

                cmd.Parameters.AddWithValue("@name", textBox10.Text);
                cmd.Parameters.AddWithValue("@type", textBox9.Text);
                cmd.Parameters.AddWithValue("@quantity", textBox8.Text);
               

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                 DisplayData();
                //textBox10.Text = "";
                //textBox9.Text = "";
                //textBox8.Text = "";
               

            }

            else if (panel3.Visible == true)
            {

                SqlConnection con;
                con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa;Password=me123;");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Entryfees set  fees='" + textBox14.Text + "', mobile='" + textBox13.Text + "' Where name='" + textBox15.Text + "'", con);

                cmd.Parameters.AddWithValue("@name", textBox15.Text);
                cmd.Parameters.AddWithValue("@fees", textBox14.Text);
                cmd.Parameters.AddWithValue("@mobile", textBox13.Text);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                 DisplayData();
                //textBox10.Text = "";
                //textBox9.Text = "";
                //textBox8.Text = "";


            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Trainersport("Select * from Trainer");
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Equipmentsport("Select * from Equipment");
            frm.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Entryfeessport("Select * from Entryfees");
            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[a-zA-z]$");
            bool isValid = reg.IsMatch(textBox6.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(textBox6, "Invalid");
                MessageBox.Show("Please enter characters only!");
                textBox6.Focus();
                return;
            }
            else
            {
                object errorProvider1 = null;
                //errorProvider1.Clear();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(textBox5.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(textBox5, "Invalid");
                MessageBox.Show("Please enter digits only!");
                textBox5.Focus();
                return;
            }
            else
            {
                errorProvider1.clear();
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

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[a-zA-z]$");
            bool isValid = reg.IsMatch(textBox10.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(textBox10, "Invalid");
                MessageBox.Show("Please enter characters only!");
                textBox10.Focus();
                return;
            }
            else
            {
                object errorProvider1 = null;
                //errorProvider1.Clear();
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[a-zA-z]$");
            bool isValid = reg.IsMatch(textBox9.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(textBox9, "Invalid");
                MessageBox.Show("Please enter characters only!");
                textBox9.Focus();
                return;
            }
            else
            {
                object errorProvider1 = null;
                //errorProvider1.Clear();
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(textBox8.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(textBox8, "Invalid");
                MessageBox.Show("Please enter digits only!");
                textBox8.Focus();
                return;
            }
            else
            {
                errorProvider1.clear();
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[a-zA-z]$");
            bool isValid = reg.IsMatch(textBox15.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(textBox15, "Invalid");
                MessageBox.Show("Please enter characters only!");
                textBox15.Focus();
                return;
            }
            else
            {
                object errorProvider1 = null;
                //errorProvider1.Clear();
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(textBox14.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(textBox14, "Invalid");
                MessageBox.Show("Please enter digits only!");
                textBox14.Focus();
                return;
            }
            else
            {
                errorProvider1.clear();
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(textBox13.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(textBox13, "Invalid");
                MessageBox.Show("Please enter digits only!");
                textBox13.Focus();
                return;
            }
            else
            {
                errorProvider1.clear();
            }
        }
    }

    internal class errorProvider1
    {
        internal static void clear()
        {
           // throw new NotImplementedException();
        }

        internal static void SetError(TextBox textBox6, string v)
        {
          //  throw new NotImplementedException();
        }
    }
}
