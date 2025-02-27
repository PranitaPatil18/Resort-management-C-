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

namespace Resort_Management
{
    public partial class staff : Form
    {
        public staff()
        {
            InitializeComponent();
        }

        int id = 0;
        public string s;
        private string val;

        public object db { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton_male.Checked == true)
            {


                string ID = ID_textbox.Text;
                string Name = Name_textbox.Text;
                string Age = Age_textbox.Text;
                string Mob = Mob_textbox.Text;
                string Salary = Salary_textbox.Text;
                string Category = comboBox_category.Text;
                string Gender = radioButton_male.Text;
                string Join_Date = Join_date.Value.ToString("MM/dd/yyyy");

                SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa; Password=me123;");
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert into staff3 values (' " + Name + "', '" + Age + "','" + Gender + "','" + Category + "','" + Mob + "','" + Join_Date + "','" + Salary + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfully...!");
                SqlDataAdapter da = new SqlDataAdapter("Select * from staff3", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
                //ID_textbox.Text = " ";
                //Name_textbox.Text = " ";
                //Age_textbox.Text = " ";
                //Mob_textbox.Text = "";
                //Salary_textbox.Text = "";
                //comboBox_category.Text = "";
            }


            if (pictureBox1.Image != null)
            {

                SqlCommand cmd = new SqlCommand();
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] a = ms.GetBuffer();
                ms.Close();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@picture", a);


                SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa; Password=me123;");
                con.Open();

                cmd.Connection = con;

                cmd.CommandText = "insert into image1(name,image) values ('" + Name_textbox.Text + "',@picture)";

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved");
            }

            if (radioButton_female.Checked == true)
            {


                string ID = ID_textbox.Text;
                string Name = Name_textbox.Text;
                string Age = Age_textbox.Text;
                string Mob = Mob_textbox.Text;
                string Salary = Salary_textbox.Text;
                string Category = comboBox_category.Text;
                string Gender = radioButton_female.Text;
                string Join_Date = Join_date.Value.ToString("MM/dd/yyyy");

                SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa; Password=me123;");
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert into staff3 values (' " + Name + "', '" + Age + "','" + Gender + "','" + Category + "','" + Mob + "','" + Join_Date + "','" + Salary + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfully...!");
                SqlDataAdapter da = new SqlDataAdapter("Select * from staff3", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        private void ID_textbox_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(ID_textbox.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(ID_textbox, "Invalid");
                MessageBox.Show("Please enter digits only!");
                ID_textbox.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void resource_btn_Click(object sender, EventArgs e)
        {
            owner ow = new owner();
            ow.Show();
            this.Hide();
        }

        private void staff_btn1_Click(object sender, EventArgs e)
        {
            if (radioButton_male.Checked == true)
             {


                 string ID = ID_textbox.Text;
                 string Name = Name_textbox.Text;
                 string Age = Age_textbox.Text;
                 string Mob = Mob_textbox.Text;
                 string Salary = Salary_textbox.Text;
                 string Category = comboBox_category.Text;
                 string Gender = radioButton_male.Text;
                 string Join_Date = Join_date.Value.ToString("MM/dd/yyyy");

                 SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa; Password=v123;");
                 con.Open();

                 SqlCommand cmd = new SqlCommand();
                 cmd.CommandText = "Insert into staff values (' " + ID + "',' " + Name + "', '" + Age + "','" + Gender + "','" + Category + "','" + Mob + "','" + Join_Date + "','" + Salary + "')";
                 cmd.Connection = con;
                 cmd.ExecuteNonQuery();
                 MessageBox.Show("Data Saved Successfully...!");
                 SqlDataAdapter da = new SqlDataAdapter("Select * from staff", con);
                 DataTable dt = new DataTable();
                 da.Fill(dt);
                 dataGridView1.DataSource = dt;
             }
           
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa;Password=me123;");
            con.Open();

            SqlCommand cmd = new SqlCommand("delete from staff3 where ID ='" + id + "'");

            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Successfully..");

            SqlDataAdapter da = new SqlDataAdapter("select * from staff3", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void update_Click(object sender, EventArgs e)
        {

            String str = null;
            if (radioButton_male.Checked == true)
            {
                str = "Male";
            }
            else
            {
                str = "Female";
            }
            try
            {
                //// SqlDataAdapter da = new SqlDataAdapter("Update staff3 set Name=N'" + Name_textbox.Text + "', Age='" + Age_textbox.Text + "', Gender='" + str + "',Category='" + comboBox_category.Text + "', Mob='" + Mob_textbox.Text + "' , Join_Date='" + Join_date.Text + "' ,Salary='" + Salary_textbox.Text + "' Where ID='" + ID_textbox.Text + "'",con);
                //SqlDataAdapter da = new SqlDataAdapter("Update staff3 set Name=N'" + Name_textbox.Text + "', Age='" + Age_textbox.Text + "', Gender='" + str + "',Category='" + comboBox_category.Text + "', Mob='" + Mob_textbox.Text + "' , Join_Date='" + Join_date.Text + "' ,Salary='" + Salary_textbox.Text + "", con);


                //MessageBox.Show("Update Record Succsessfully...");


                //SqlDataAdapter da1 = new SqlDataAdapter("select * from staff3", con);
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                //dataGridView1.DataSource = dt;
                ////  da.fill(dataGridView1, "Select * from Company_Information");
                //  cmd = new SqlCommand("update tbl_Record set Name=@name,State=@state where ID=@id", con);

                //  con.Open();

                SqlConnection con;
                con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa;Password=me123;");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update staff3 set Name='" + Name_textbox.Text + "', Age='" + Age_textbox.Text + "', Gender='" + str + "',Category='" + comboBox_category.Text + "', Mob='" + Mob_textbox.Text + "' , Join_Date='" + Join_date.Text + "' ,Salary='" + Salary_textbox.Text + "' Where ID='" + ID_textbox.Text + "'", con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Name", Name_textbox.Text);
                cmd.Parameters.AddWithValue("@Age", Age_textbox.Text);
                 cmd.Parameters.AddWithValue("@Gender", str);
                cmd.Parameters.AddWithValue("@Category", comboBox_category.Text);
                cmd.Parameters.AddWithValue("@Mob", Mob_textbox.Text);
                cmd.Parameters.AddWithValue("@Join_Date", Join_date.Text);
                cmd.Parameters.AddWithValue("@Salary", Salary_textbox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
               

            }
            catch(Exception ex)
            {

            }
            //String str = null;
            //if (radioButton_male.Checked == true)
            //{
            //    str = "Male";
            //}
            //else
            //{
            //    str = "Female";
            //}
            //SqlConnection con;
            //con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa;Password=me123;");
            //con.Open();

            //cmd.Connection = con;
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Record Updated Successfully...!");
            //SqlDataAdapter da = new SqlDataAdapter("Select * from staff3", con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;



            //ID_textbox.Text = " ";
            //Name_textbox.Text = " ";
            //Age_textbox.Text = " ";
            //Mob_textbox.Text = "";
            //Salary_textbox.Text = "";
            //comboBox_category.Text = "";


        }





        private void clear_Click(object sender, EventArgs e)
        {
            ID_textbox.Text = " ";
            Name_textbox.Text = " ";
            Age_textbox.Text = " ";
            Mob_textbox.Text = "";
            Salary_textbox.Text = "";
            comboBox_category.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            owner_report owr = new owner_report();
            owr.Show();
            this.Hide();
        }

        private void Name_textbox_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[a-zA-z]$");
            bool isValid = reg.IsMatch(Name_textbox.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(Name_textbox, "Invalid");
                MessageBox.Show("Please enter characters only!");
                Name_textbox.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void Age_textbox_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(Age_textbox.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(Age_textbox, "Invalid");
                MessageBox.Show("Please enter digits only!");
                Age_textbox.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            //if(Age_textbox.MaxLength > 3)
            //{
            //    MessageBox.Show("Please enter valid Age!");
            //}


        }

        private void Mob_textbox_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(Mob_textbox.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(Mob_textbox, "Invalid");
                MessageBox.Show("Please enter digits only!");
                Mob_textbox.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }


        }

        private void Salary_textbox_TextChanged(object sender, EventArgs e)
        {

            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(Salary_textbox.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(Salary_textbox, "Invalid");
                MessageBox.Show("Please enter digits only!");
                Salary_textbox.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            //s = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
            //// id = dataGridView1[e.ColumnIndex, e.RowIndex].Value();
            ////   DataTable dt = db.GetTable("Select * from[newproject].[dbo].[Tmp_productinfo] Where productid='" + s + "'");
            //DataTable dt = db.("Select * from[newproject].[dbo].[Tmp_productinfo] Where productid='" + s + "'");
            //if (dt.Rows.Count > 0)
            //{
            //    txtProd.Text = dt.Rows[0][1].ToString();
            //    txtProdPur.Text = dt.Rows[0][2].ToString();
            //    txtProdSale.Text = dt.Rows[0][3].ToString();
            //}

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string val;
            if (radioButton_male.Checked == true)
            {
                val = radioButton_male.Text;
            }
            if (radioButton_female.Checked == true)
            {
                val = radioButton_female.Text;
            }
            else
            {
            }
            try
            {
                SqlConnection con;
                con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa;Password=me123;");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from staff3 Where ID='" + dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int n = dataGridView1.Rows.Add();


                if (dt.Rows.Count > 0)



                 ID_textbox.Text = dt.Rows[0][0].ToString();
                Name_textbox.Text = dt.Rows[0][1].ToString();
                Age_textbox.Text = dt.Rows[0][2].ToString();
                val = dt.Rows[0][3].ToString();
                comboBox_category.Text = dt.Rows[0][4].ToString();
                Mob_textbox.Text = dt.Rows[0][5].ToString();
                Join_date.Text = dt.Rows[0][6].ToString();
                Salary_textbox.Text = dt.Rows[0][7].ToString();
                // DisCustControl();
                //   BtnSave.Enabled = false;
                // BtnDelete.Enabled = true;
                // BtnUpdate.Enabled = true;
                //txtCustName.Focus()
            }



            catch
            {

                //txtCompName.Enabled = false;
                //txtCompAddress.Enabled = false;
                //TxtMobNo.Enabled = false;
                //txtcompaddre.Enabled = false;
                //BtnDelete.Enabled = false;
                //BtnUpdate.Enabled = false;

            }
        }

        private void staff_panel_Paint(object sender, PaintEventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
                // textBox1.Text = open.FileName;
            
        }
    }

        private void staff_Load(object sender, EventArgs e)
        {
            SqlConnection con;
            con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa;Password=me123;");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from staff3", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DisplayData()
        {
            SqlConnection con;
            con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa;Password=me123;");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from staff3 Where ID='" + dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            // con.Open();
          
            dataGridView1.DataSource = dt;
            con.Close();
        }

        //dataGridView1 RowHeaderMouseClick Event  
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

            // id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            ID_textbox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Name_textbox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Age_textbox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            val = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBox_category.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Mob_textbox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            Join_date.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            Salary_textbox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Hide();
            ID_textbox.Visible = false;
            Name_textbox.Text = " ";
            Age_textbox.Text = " ";
            Mob_textbox.Text = "";
            Salary_textbox.Text = "";
            comboBox_category.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }

        private void ID_textbox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_male_CheckedChanged(object sender, EventArgs e)
        {

        }
        //Clear Data  

    }
}
