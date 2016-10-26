using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MPLSMS
{
    public partial class frmMonthlySales : Form
    {
        public frmMonthlySales()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frmMonthlySales_Load(object sender, EventArgs e)
        {
            rptMonthlySales objRpt = new rptMonthlySales();
            // objRpt.SetParameterValue(0, String.Format("{0:yyyy-MM-dd}", this.Dailysale));
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
