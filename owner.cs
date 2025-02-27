using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using ResortManagement;


namespace Resort_Management
{
    public partial class owner : Form
    {
        public owner()
        {
            InitializeComponent();
        }
        int SrNo = 0;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void staff_btn1_Click(object sender, EventArgs e)
        {
            
        }

        private void resource_btn_Click(object sender, EventArgs e)
        {
            resource_panel.Show(); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void restextbox_name_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[a-zA-z]$");
            bool isValid = reg.IsMatch(name_textbox.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(name_textbox, "Invalid");
                MessageBox.Show("Please enter characters only!");
                name_textbox.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void rescombobox_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            staff stf = new staff();
            stf.Show();
            this.Hide();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            String SrNo = SrNo_textbox.Text;
            String Name = name_textbox.Text;
            String Qty = qty_textbox.Text;
            SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa; Password=me123;");
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert into resource values (' " + SrNo + "',' " + Name + "', '" + Qty + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Saved Successfully...!");
            SqlDataAdapter da = new SqlDataAdapter("Select * from resource", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa;Password=me123;");
            con.Open();

            SqlCommand cmd = new SqlCommand("delete from resource where SrNo ='" + SrNo + "'");

            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Successfully..");
            SqlDataAdapter da = new SqlDataAdapter("select * from resource", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        internal void SetDataSource(DataSet2 ds)
        {
            throw new NotImplementedException();
        }

        private void qty_textbox_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(qty_textbox.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(qty_textbox, "Invalid");
                MessageBox.Show("Please enter numeric value!");
                qty_textbox.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SrNo_textbox.Text = "";
            name_textbox.Text = "";
            qty_textbox.Text = "";
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void owner_Load(object sender, EventArgs e)
        {
            SqlConnection con;
            con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa;Password=me123;");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from resource", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con;
                con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa;Password=me123;");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from SrNo='" + dataGridView2.Rows[dataGridView2.SelectedCells[0].RowIndex].Cells[0].Value + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    SrNo_textbox.Text = dt.Rows[0][0].ToString();
                    name_textbox.Text = dt.Rows[0][1].ToString();
                    qty_textbox.Text = dt.Rows[0][2].ToString();
                }
            }
            catch { }

        }

        private void SrNo_textbox_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(SrNo_textbox.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(SrNo_textbox, "Invalid");
                MessageBox.Show("Please enter numeric value!");
                SrNo_textbox.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
        }



        private void DisplayData()
        {
           

                SqlConnection con;
                con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa;Password=me123;");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from resource Where SrNo='" + dataGridView2.Rows[dataGridView2.SelectedCells[0].RowIndex].Cells[0].Value + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // con.Open();

                dataGridView2.DataSource = dt;
                con.Close();
            }

        private void k_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SrNo = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.resourcereport("Select * from resource");
            frm.Show();
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            SrNo_textbox.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            name_textbox.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            qty_textbox.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
          
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pdffomat pt = new pdffomat();
             pt.Show();
        }
    }
    }
