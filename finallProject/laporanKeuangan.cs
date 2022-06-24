using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finallProject
{
    public partial class laporanKeuangan : Form
    {
        public string varFinancialID { get; set; }
        public laporanKeuangan()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.Refresh();
            crTransactionHist6.SetParameterValue("financialID", varFinancialID);
            crystalReportViewer1.ReportSource = crTransactionHist6;
            crystalReportViewer1.Refresh();
        }

        private void laporanKeuangan_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.Refresh();
            crTransactionHist6.SetParameterValue("financialID", varFinancialID);
            crystalReportViewer1.ReportSource = crTransactionHist6;
            crystalReportViewer1.Refresh();
        }
    }
}
