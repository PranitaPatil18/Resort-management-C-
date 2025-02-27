using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ResortManagement;

using System.Data.SqlClient;

using System.Text.RegularExpressions;

namespace Resort_Management
{
    public partial class owner_report : Form
    {
        public owner_report()
        {
            InitializeComponent();
        }

        private void owner_report_Load(object sender, EventArgs e)
        {
            individual_report.Hide();
            group_report.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.bon2("Select * from View_2 where ID='" + Name_textbox.Text + "'");
            frm.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            individual_report.Show();
            group_report.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Restro frm = new Restro();
            frm.Show();
           // group_report.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            staff stf = new staff();
            stf.Show();
            this.Hide();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

    //        try
    //        {
    //            SqlConnection con;
    //            con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa;Password=me123;");
    //            con.Open();
    //            SqlDataAdapter da = new SqlDataAdapter("select * from staff3 Where ID='" + dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value + "'", con);
    //            DataTable dt = new DataTable();
    //            da.Fill(dt);
    //            if (dt.Rows.Count > 0)
    //            {

    //                Name_textbox.Text = dt.Rows[0][0].ToString();

    //                // DisCustControl();
    //                //   BtnSave.Enabled = false;
    //                // BtnDelete.Enabled = true;
    //                // BtnUpdate.Enabled = true;
    //                //txtCustName.Focus();
    //            }
    //        }
    //        catch
    //        {

    //            //txtCompName.Enabled = false;
    //            //txtCompAddress.Enabled = false;
    //            //TxtMobNo.Enabled = false;
    //            //txtcompaddre.Enabled = false;
    //            //BtnDelete.Enabled = false;
    //            //BtnUpdate.Enabled = false;
    //        }
    //    }

    //    private void Name_textbox_TextChanged(object sender, EventArgs e)
    //    {

     }
    }
            
        
    
}
