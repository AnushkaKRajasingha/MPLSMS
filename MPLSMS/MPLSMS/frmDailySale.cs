﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MPLSMS
{
    public partial class frmDailySale : Form
    {

        public frmDailySale()
        {
            InitializeComponent();
        }

        private void frmDailySale_Load(object sender, EventArgs e)
        {
            rptDailySale objRpt = new rptDailySale();
            // objRpt.SetParameterValue(0, String.Format("{0:yyyy-MM-dd}", this.Dailysale));
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
