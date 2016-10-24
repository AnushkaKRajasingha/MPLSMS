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
    public partial class frmAproveCredit : Form
    {
        public frmAproveCredit()
        {
            InitializeComponent();
        }
        SqlConnection SQLcon;
        SqlDataAdapter daCustomer, daOutstanding;
        DataSet dsCustomer, dsOutstanding;
        SqlParameter pCusID1;

        private void frmAproveCredit_Load(object sender, EventArgs e)
        {


            //Open Connection 
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
            preFill();
        }

        public void preFill()
        {
            //fill Cus No , Cus name
            daCustomer = new SqlDataAdapter("sp_GetCustomer", SQLcon);
            dsCustomer = new DataSet();
            daCustomer.Fill(dsCustomer, "MPLCUSTOMER");

            cboCusId.DataSource = dsCustomer;
            cboCusId.DisplayMember = "MPLCUSTOMER.CUSNO";

            cboCusName.DataSource = dsCustomer;
            cboCusName.DisplayMember = "MPLCUSTOMER.CUSNAME";

        }
        // get Outstanding Balance 
        public void _uotstanding()
        {

            int CusID = Convert.ToInt32(cboCusId.Text);
            pCusID1 = new SqlParameter("@CusID1", SqlDbType.Int);

            pCusID1.Value = CusID;
            daOutstanding = new SqlDataAdapter("select SUM(GTOTAL) from MPLINVOICE where INSTATUS='A' AND CUSID=@CusID1 AND INTYPE='Credit'", SQLcon);
            daOutstanding.SelectCommand.Parameters.Add(pCusID1);
            dsOutstanding = new DataSet();
            daOutstanding.Fill(dsOutstanding, "MPLINVOICE");

            txtOutstandingBalance.Text = dsOutstanding.Tables[0].Rows[0].ItemArray[0].ToString();


        }

        private void cboCusId_SelectedIndexChanged(object sender, EventArgs e)
        {
            _uotstanding();
        }
    }

}
