using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

 

namespace ResortManagement
{
    public partial class pdffomat : Form
    {
        public pdffomat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();

            cryRpt.Load(@"D:\VAI2\ResortManagement\ResortManagement\Groupinfo.rpt");

            crystalReportViewer1.ReportSource = cryRpt;

            crystalReportViewer1.Refresh();

            cryRpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"D:\ASD.pdf");

            MessageBox.Show("Exported in PDF Successfully.....");
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
