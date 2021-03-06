﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using IDAutomation.NetAssembly;


namespace MPLSMS
{
    public partial class frmBarCode : Form
    {
        FontEncoder encod = new FontEncoder();
        public String barcode { get; set; }
        public frmBarCode()
        {
            InitializeComponent();
        }

        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            
        }

        private void frmBarCode_Load(object sender, EventArgs e)
        {
            rptBarcodePrint objRpt = new rptBarcodePrint();
            objRpt.SetParameterValue(0, barcode);

            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
