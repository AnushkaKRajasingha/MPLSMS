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
    public partial class frmPrintPO : Form
    {
        public int POno { get; set; }
        public frmPrintPO()
        {
            InitializeComponent();
        }

        private void frmPrintPO_Load(object sender, EventArgs e)
        {

            rptPrintPO objRpt = new rptPrintPO();
            objRpt.SetParameterValue(0, POno);
            //  objRpt.SetDataSource(ds_ID.Tables[0]);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
