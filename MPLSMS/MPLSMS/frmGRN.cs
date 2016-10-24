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
    public partial class frmGRN : Form
    {
        public frmGRN()
        {
            InitializeComponent();
        }
        public int StokNo { get; set; }
       

        private void frmGRN_Load(object sender, EventArgs e)
        {
            rptGRNPrint objRpt = new rptGRNPrint();
            objRpt.SetParameterValue(0, StokNo);
           
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
