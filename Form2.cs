using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResortManagement;

namespace Resort_Management
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void bon2(string sql)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa; Password=me123;");
                con.Open();


                SqlDataAdapter da = new SqlDataAdapter(sql, con);
              

                DataSet2 ds = new DataSet2();


                da.Fill(ds, "View_2");
              

                StaffReport cr = new StaffReport();



                cr.SetDataSource(ds);
                crystalReportViewer1.ReportSource = cr;


            }
            catch
            {
            }
        }



        public void resourcereport(string sql)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa; Password=me123;");
                con.Open();


                SqlDataAdapter da = new SqlDataAdapter(sql, con);


                DataSet2 ds = new DataSet2();


                da.Fill(ds, "resource");


                Groupinfo cr = new Groupinfo();



                cr.SetDataSource(ds);
                crystalReportViewer1.ReportSource = cr;


            }
            catch
            {
            }
        }


        public void resourcereport1(string sql)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa; Password=me123;");
                con.Open();


                SqlDataAdapter da = new SqlDataAdapter(sql, con);


                DataSet2 ds = new DataSet2();


                da.Fill(ds, "staff3");


                staff3 cr = new staff3();



                cr.SetDataSource(ds);
                crystalReportViewer1.ReportSource = cr;


            }
            catch
            {
            }
        }

        public void resourcereport2(string sql)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa; Password=me123;");
                con.Open();


                SqlDataAdapter da = new SqlDataAdapter(sql, con);


                DataSet2 ds = new DataSet2();


                da.Fill(ds, "staff3");


                Bookreport cr = new Bookreport();



                cr.SetDataSource(ds);
                crystalReportViewer1.ReportSource = cr;


            }
            catch
            {
            }
        }

        public void ownerinfo(string sql)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa; Password=me123;");
                con.Open();


                SqlDataAdapter da = new SqlDataAdapter(sql, con);


                DataSet2 ds = new DataSet2();


                da.Fill(ds, "resource");


                owner cr = new owner();



                cr.SetDataSource(ds);
                crystalReportViewer1.ReportSource = cr;


            }
            catch
            {
            }
        }

        public void Trainersport(string sql)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa; Password=me123;");
                con.Open();


                SqlDataAdapter da = new SqlDataAdapter(sql, con);


                DataSet2 ds = new DataSet2();


                da.Fill(ds, "Trainer");


                Trainer cr = new Trainer();



                cr.SetDataSource(ds);
                crystalReportViewer1.ReportSource = cr;


            }
            catch
            {
            }
        }

        public void Equipmentsport(string sql)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa; Password=me123;");
                con.Open();


                SqlDataAdapter da = new SqlDataAdapter(sql, con);


                DataSet2 ds = new DataSet2();


                da.Fill(ds, "Equipment");


                Equipment cr = new Equipment();



                cr.SetDataSource(ds);
                crystalReportViewer1.ReportSource = cr;


            }
            catch
            {
            }
        }


        public void Entryfeessport(string sql)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa; Password=me123;");
                con.Open();


                SqlDataAdapter da = new SqlDataAdapter(sql, con);


                DataSet2 ds = new DataSet2();


                da.Fill(ds, "Entryfees");


                Entryfees cr = new Entryfees();



                cr.SetDataSource(ds);
                crystalReportViewer1.ReportSource = cr;


            }
            catch
            {
            }
        }

        public void Roomresevation(string sql)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa; Password=me123;");
                con.Open();


                SqlDataAdapter da = new SqlDataAdapter(sql, con);


                DataSet2 ds = new DataSet2();


                da.Fill(ds, "Room_Bill");


                GenerateRomeBill cr = new GenerateRomeBill();



                cr.SetDataSource(ds);
                crystalReportViewer1.ReportSource = cr;


            }
            catch
            {
            }
        }
        public void Hallreservation(string sql)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=resort; User Id=sa; Password=me123;");
                con.Open();


                SqlDataAdapter da = new SqlDataAdapter(sql, con);


                DataSet2 ds = new DataSet2();


                da.Fill(ds, "Hall_Bill");


                generateHallbill cr = new generateHallbill();



                cr.SetDataSource(ds);
                crystalReportViewer1.ReportSource = cr;


            }
            catch
            {
            }
        }


    }
}
