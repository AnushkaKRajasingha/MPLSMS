using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MPLSMS
{
    public partial class frmCashPayment : Form
    {
        public frmCashPayment()
        {
            InitializeComponent();
        }
        SqlConnection SQLcon;

        private void frmCashPayment_Load(object sender, EventArgs e)
        {
            try
            {
                Connection obj = new Connection();
                SQLcon = obj.con();
                SQLcon.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void prfill()
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
