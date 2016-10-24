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
        SqlParameter pCusID1, pCreditLimit, pCusStatus;
        SqlCommand com;

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

            txtCreditLimit.DataBindings.Clear();
            txtCreditLimit.DataBindings.Add("Text", dsCustomer, "MPLCUSTOMER.CUSSREDITLIMIT");

            // get checkBox Value


            //string strcheck = dsCustomer.Tables[0].Rows[0].ItemArray[7].ToString();
            //MessageBox.Show(strcheck);

            //if (strcheck == "1")
            //{
            //    chkCusBlocked.Checked = true;
            //    //txtCusID.BackColor = Color.Red;
            //}
            //else
            //{
            //    chkCusBlocked.Checked = false;
            //    //txtCusID.BackColor = Color.Empty;
            //}

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

            // Change Check Box

            int CusID = Convert.ToInt32(cboCusId.Text);
            pCusID1 = new SqlParameter("@CusID1", SqlDbType.Int);

            pCusID1.Value = CusID;
            daOutstanding = new SqlDataAdapter("select CUSSTATUS from MPLCUSTOMER where  CUSNO=@CusID1 ", SQLcon);
            daOutstanding.SelectCommand.Parameters.Add(pCusID1);
            dsOutstanding = new DataSet();
            daOutstanding.Fill(dsOutstanding, "MPLCUSTOMER");

            string strcheck = dsOutstanding.Tables[0].Rows[0].ItemArray[0].ToString();




            if (strcheck == "1")
            {
                chkCusBlocked.Checked = true;
                lblBlocked.Enabled = true;
            }
            else
            {
                chkCusBlocked.Checked = false;
                lblBlocked.Enabled = false;
            }


        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            // Check Null or empty
            if (string.IsNullOrEmpty(txtCreditLimit.Text))
            {
                MessageBox.Show("EnterCredit Limit", "Markspen Labels - Aprove Credit");
                return;
            }
            // create Parameters
            pCusID1=new SqlParameter("@CusID1",SqlDbType.Int);
            pCreditLimit = new SqlParameter("@CreditLimit", SqlDbType.Decimal);
            pCusStatus = new SqlParameter("@CusStatus", SqlDbType.Int);
           
            //Assign value
            pCusID1.Value = Convert.ToInt32(cboCusId.Text);
            pCreditLimit.Value = Convert.ToDecimal(txtCreditLimit.Text) ;

            if (chkCusBlocked.Checked == true)
            {
                pCusStatus.Value = Convert.ToInt16("1");
            }
            else
            {
                pCusStatus.Value = Convert.ToInt16("0");
            }

            //save data

            com = new SqlCommand("[sp_UpdateCreditLimitCustomer]", SQLcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(pCusID1);
            com.Parameters.Add(pCreditLimit);
            com.Parameters.Add(pCusStatus);
            com.ExecuteScalar();
            MessageBox.Show("Customer Credit Limit was Updated", "MARKSPEN LABELS - CUSTOMER");

            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }

}
