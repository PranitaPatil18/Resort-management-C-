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
    public partial class restortManager : Form
    {
        public restortManager()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel1.Hide();
            panel3.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Show();
            panel1.Hide();
            panel2.Hide();
        }

        private void restortManager_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
         //   dateTimePicker3.CustomFormat = "hh:mm:ss";
        }

        private void button9_Click(object sender, EventArgs e)
        {

            string cust_name = Custname.Text;
            string cust_mob = custmob.Text;
            string cust_add = custadd.Text;
            string cust_country = custcountry.Text;
            string cust_roomtype = custroomtype.Text;
            string cust_roomno = custroomno.Text;
            string check_in = Join_date.Value.ToString("MM/dd/yyyy");
            string check_out = dateTimePicker1.Value.ToString("MM/dd/yyyy");

            SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa; Password=me123;");
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert into Room_Reservation values (' " + cust_name + "', '" + cust_mob + "','" + cust_add + "','" + cust_country + "','" + cust_roomtype + "','" + cust_roomno + "','" + check_in + "','" + check_out +  "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Saved Successfully...!");
            SqlDataAdapter da = new SqlDataAdapter("Select * from Room_Reservation", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
          

            con.Close();

          
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Custname.Text = "";
            custmob.Text = "";

            custadd.Text = "";
            custcountry.Text = "";
            custroomtype.Text = "";
            custroomno.Text = "";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string cust_name = custnmetxt.Text;
            string cust_mob = custmobtxt.Text;
            string fundate = dateTimePicker3.Text;
            string star_time = dateTimePicker2.Text;
            string end_time = dateTimePicker4.Text;
            string price = pricetxt.Text;
            string extra_charge = extrachrtxt.Text;
            string total = totaltxt.Text;

            SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa; Password=me123;");
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert into Hall_Resevation values (' " + cust_name + "', '" + cust_mob + "','" + fundate + "','" + star_time + "','" + end_time + "','" + price + "','" + extra_charge + "','" + total + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Saved Successfully...!");
            SqlDataAdapter da = new SqlDataAdapter("Select * from Hall_Resevation", con);
            DataTable dt = new DataTable();
            da.Fill(dt);


            con.Close();

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.ShowUpDown = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            custnmetxt.Text = "";
            custmobtxt.Text = "";
            pricetxt.Text = "";
            extrachrtxt.Text = "";
            totaltxt.Text = "";

        }

        private void Join_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string cust_name = textBox10.Text;
            string bill_no = textBox2.Text;
            string check_in = dateTimePicker5.Text;
            string check_out = dateTimePicker6.Text;
            string allocate_room = textBox8.Text;
            string price_pernight = textBox9.Text;
            string no_of_night = textBox6.Text;
            string extra_charge = textBox4.Text;
            string total = textBox3.Text;




            SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa; Password=me123;");
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert into Room_Bill values (' " + cust_name + "', '" + bill_no + "','" + check_in + "','" + check_out + "','" + allocate_room + "','" + price_pernight + "','" + no_of_night + "','"  +  extra_charge + "','" + total + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Saved Successfully...!");
            SqlDataAdapter da = new SqlDataAdapter("Select * from Room_Bill", con);
            DataTable dt = new DataTable();
            da.Fill(dt);


            con.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string cust_name = custnemhtxt.Text;
            string bill_no = bilnohtxt.Text;
            string check_in = dateTimePicker7.Text;
            string check_out = dateTimePicker8.Text;
            string allocate_room = allocatromhtxt.Text;
          
            string no_of_days = nodayhtxt.Text;
            string extra_charge = Extrachrghtxt.Text;
            string total = totalhtxt.Text;




            SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa; Password=me123;");
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert into Hall_Bill values (' " + cust_name + "', '" + bill_no + "','" + check_in + "','" + check_out + "','" + allocate_room + "','" + no_of_days + "','" + extra_charge + "','"   + total + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Saved Successfully...!");
            SqlDataAdapter da = new SqlDataAdapter("Select * from Hall_Bill", con);
            DataTable dt = new DataTable();
            da.Fill(dt);


            con.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            textBox10.Text = "";
            textBox2.Text = "";
            dateTimePicker5.Text = "";
            dateTimePicker6.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox6.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";




        }

        private void button15_Click(object sender, EventArgs e)
        {
            custnemhtxt.Text = "";
            bilnohtxt.Text="";
            dateTimePicker7.Text="";
            dateTimePicker8.Text = "";
            allocatromhtxt.Text = "";
            nodayhtxt.Text = "";
            Extrachrghtxt.Text = "";
            totalhtxt.Text = "";



        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Roomresevation("Select * from Room_Bill");
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Hallreservation("Select * from Hall_Bill");
            frm.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
           
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            int totalvalue = 0;
            int x = Convert.ToInt32(textBox9.Text);
            int y = Convert.ToInt32(textBox6.Text);
            int z = Convert.ToInt32(textBox4.Text);

            totalvalue = x * y + z;

            textBox3.Text = Convert.ToString(totalvalue);
        }

        private void Extrachrghtxt_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(Extrachrghtxt.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(Extrachrghtxt, "Invalid");
                MessageBox.Show("Please enter digits only!");
                Extrachrghtxt.Focus();
                return;
            }
            else
            {
                errorProvider1.clear();
            }
        }

        private void Extrachrghtxt_Leave(object sender, EventArgs e)
        {
            int totalvalue = 0;
            int x = Convert.ToInt32(nodayhtxt.Text);
            int y = Convert.ToInt32(Extrachrghtxt.Text);
           
            totalvalue = x * y ;

            totalhtxt.Text = Convert.ToString(totalvalue);
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //timePicker = new DateTimePicker();
            //timePicker.Format = DateTimePickerFormat.Time;
            //timePicker.ShowUpDown = true;
        }

        private void bilnohtxt_TextChanged(object sender, EventArgs e)
        {

            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(bilnohtxt.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(bilnohtxt, "Invalid");
                MessageBox.Show("Please enter digits only!");
                bilnohtxt.Focus();
                return;
            }
            else
            {
                errorProvider1.clear();
            }
        }

        private void nodayhtxt_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(nodayhtxt.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(nodayhtxt, "Invalid");
                MessageBox.Show("Please enter digits only!");
                nodayhtxt.Focus();
                return;
            }
            else
            {
                errorProvider1.clear();
            }

        }

        private void Custname_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[a-zA-z]$");
            bool isValid = reg.IsMatch(Custname.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(Custname, "Invalid");
                MessageBox.Show("Please enter characters only!");
                Custname.Focus();
                return;
            }
            else
            {
                object errorProvider1 = null;
                //errorProvider1.Clear();
            }
        }

        private void custmob_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(custmob.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(custmob, "Invalid");
                MessageBox.Show("Please enter digits only!");
                custmob.Focus();
                return;
            }
            else
            {
                errorProvider1.clear();
            }
        }

        private void custcountry_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[a-zA-z]$");
            bool isValid = reg.IsMatch(custcountry.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(custcountry, "Invalid");
                MessageBox.Show("Please enter characters only!");
                custcountry.Focus();
                return;
            }
            else
            {
                object errorProvider1 = null;
                //errorProvider1.Clear();
            }
        }

        private void custnmetxt_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[a-zA-z]$");
            bool isValid = reg.IsMatch(custnmetxt.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(custnmetxt, "Invalid");
                MessageBox.Show("Please enter characters only!");
                custnmetxt.Focus();
                return;
            }
            else
            {
                object errorProvider1 = null;
                //errorProvider1.Clear();
            }

        }

        private void custmobtxt_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(custmob.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(custmob, "Invalid");
                MessageBox.Show("Please enter digits only!");
                custmob.Focus();
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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(textBox9.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(textBox9, "Invalid");
                MessageBox.Show("Please enter digits only!");
                textBox9.Focus();
                return;
            }
            else
            {
                errorProvider1.clear();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(textBox6.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(textBox6, "Invalid");
                MessageBox.Show("Please enter digits only!");
                textBox6.Focus();
                return;
            }
            else
            {
                errorProvider1.clear();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(textBox4.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(textBox4, "Invalid");
                MessageBox.Show("Please enter digits only!");
                textBox4.Focus();
                return;
            }
            else
            {
                errorProvider1.clear();
            }
        }

        private void custnemhtxt_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[a-zA-z]$");
            bool isValid = reg.IsMatch(custnemhtxt.Text.Trim());
            if (!isValid)
            {
                errorProvider1.SetError(custnemhtxt, "Invalid");
                MessageBox.Show("Please enter characters only!");
                custnemhtxt.Focus();
                return;
            }
            else
            {
                object errorProvider1 = null;
                //errorProvider1.Clear();
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
    }
}
