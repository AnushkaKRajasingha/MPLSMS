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
    public partial class frmCrediPayment : Form
    {
        public frmCrediPayment()
        {
            InitializeComponent();
        }
        SqlConnection SQLcon;
        SqlDataAdapter daCustomer, da_ID,da_ID1 ;
        DataSet dsCustomer, ds_ID,ds_ID1 ;
        SqlParameter pCusID, pCusID1, pPayDate, pInvID, pPaytype, pAmount, pChkNo, pchkDate, pBank, pChkStatus;
        SqlCommand com,com1;

        private void frmCrediPayment_Load(object sender, EventArgs e)
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
                return;
            }
            prefill();
        }

        public void prefill()
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

        private void cboCusId_SelectedIndexChanged(object sender, EventArgs e)
        {

            int CusID = Convert.ToInt32(cboCusId.Text);


            pCusID = new SqlParameter("@CusID", SqlDbType.Int);
            pCusID.Value = CusID;



            da_ID = new SqlDataAdapter("SELECT *  FROM MPLINVOICE WHERE CUSID=@CusID AND INSTATUS='A' AND  INTYPE='Credit'", SQLcon);
            da_ID.SelectCommand.Parameters.Add(pCusID);

            ds_ID = new DataSet();
            da_ID.Fill(ds_ID, "MPLINVOICE");

            cboInvNo.DataSource = ds_ID;
            cboInvNo.DisplayMember = "MPLINVOICE.INVOICENO";
            cboInvNo.ValueMember = "MPLINVOICE.INVOICENO";
            txtInvAmount.DataBindings.Clear();
            txtInvAmount.DataBindings.Add("TEXT",ds_ID,"MPLINVOICE.GTOTAL");



            // sum of invoice total

            pCusID1 = new SqlParameter("@CusID1", SqlDbType.Int);

            pCusID1.Value = CusID;
            da_ID1 = new SqlDataAdapter("select SUM(GTOTAL) from MPLINVOICE where INSTATUS='A' AND CUSID=@CusID1 AND INTYPE='Credit'", SQLcon);
            da_ID1.SelectCommand.Parameters.Add(pCusID1);
            ds_ID1 = new DataSet();
            da_ID1.Fill(ds_ID1, "MPLINVOICE");

            txtOutstandingBal.Text= ds_ID1.Tables[0].Rows[0].ItemArray[0].ToString();
           




            //MessageBox.Show(ds_ID.Tables[0].Rows.Count.ToString());

        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Exit", "Markspen Labels _ Credit Payment Exit", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            this.Close();
        }

        private void cmdPay_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text=="")
            {
                MessageBox.Show("Please Enter Amount");
                txtAmount.Focus();
                return;
            }
            if (cboPaymentMethode.Text=="")
            {
                 MessageBox.Show("Please Select Payment Metode");
                cboPaymentMethode.Focus();
                return;
            }
            pPayDate = new SqlParameter("@PayDate", SqlDbType.Date);
            pInvID = new SqlParameter("@InvID", SqlDbType.Int);
            pPaytype = new SqlParameter("@Paytype", SqlDbType.VarChar, 50);
            pAmount = new SqlParameter("@Amount", SqlDbType.Decimal);
            pChkNo = new SqlParameter("@ChkNo", SqlDbType.VarChar, 50);
            pchkDate = new SqlParameter("@chkDate", SqlDbType.Date);
            pBank = new SqlParameter("@Bank", SqlDbType.VarChar, 50);
            pChkStatus = new SqlParameter("@ChkStatus", SqlDbType.VarChar, 50);

            pPayDate.Value = dtpRecieptDate.Text;
            pInvID.Value = Convert.ToInt32(cboInvNo.Text);
            pPaytype.Value = cboPaymentMethode.Text;
            pAmount.Value = Convert.ToDecimal(txtAmount.Text);
            pChkNo.Value = txtChqNo.Text;
            pchkDate.Value = dtpChqDate.Text;
            pBank.Value = txtBank.Text;
            string PayM = cboPaymentMethode.Text;

            if (cboPaymentMethode.Text == "CHEQUE")
            {
                pChkStatus.Value = "Unrealized".ToString() ;
            }
            else
            {
                pChkStatus.Value = " ";
            }
          

            com = new SqlCommand("sp_AddCreditPayment", SQLcon);
            com.CommandType=CommandType.StoredProcedure;
            com.Parameters.Add(pPayDate);
            com.Parameters.Add(pInvID);
            com.Parameters.Add(pPaytype);
            com.Parameters.Add(pAmount);
            com.Parameters.Add(pChkNo);
            com.Parameters.Add(pchkDate);
            com.Parameters.Add(pBank);
            com.Parameters.Add(pChkStatus);
            com.ExecuteScalar();

            // Update Invoice table
            pInvID = new SqlParameter("@InvID", SqlDbType.Int);
            pInvID.Value = cboInvNo.Text;
            com1 = new SqlCommand("UPDATE MPLINVOICE SET INSTATUS='PAYED' WHERE INVOICENO=@InvID", SQLcon);
            com1.Parameters.Add(pInvID);
            com1.ExecuteScalar();
            
            
            
            //da_INVID = new SqlDataAdapter("UPDATE MPLINVOICE SET INSTATUS='PAYED' WHERE INVOICENO=@InvID", SQLcon);
            ////da_INVID.SelectCommand.Parameters.Add(pInvID)


            MessageBox.Show("Credit Payment Details ware added");



      //      [PAYDATE] pPayDate,pInvID,pPaytype,pAmount,pChkNo,pchkDate,pBank,pChkStatus
      //,[INVID]
      //,[PAYTYPE]
      //,[AMOUNT]
      //,[CHEQUENO]
      //,[CHEQUEDATE]
      //,[BANK]
      //,[CHSTATUS]
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            var _frmreciptprint = new frmReceipPrint();
            _frmreciptprint.invoiceNo = Convert.ToInt32( cboInvNo.SelectedValue.ToString());
            _frmreciptprint.ShowDialog();
        }

    }
}
