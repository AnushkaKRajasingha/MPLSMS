using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace MPLSMS
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;// Bring data
        DataSet ds; // Holding data
        SqlCommand com;
        SqlParameter  pCusID,pCusType, pCusDate, pCusStatus, pCusName, pCusVatNo, pCusSVatNo, pCusAddress, pCusContactPerson, pCusConPTitle, pCusTell, pCusMob, pCusFax, pCusEmail;
        SqlConnection SQLcon;
        
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            //Open Connection 
            try
            {
                Connection obj = new Connection();
                SQLcon = obj.con();
                SQLcon.Open();
                txtCusName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            cmdCusDelete.Enabled = false;
            CmdCusUpdate.Enabled = false;
            
            // Load data to data grid----------------------------------

            Prefill();
            txtCusID.Enabled = false;

        }
        void Prefill()
        {
            da = new SqlDataAdapter("sp_GetCustomer", SQLcon);
            ds = new DataSet();
            da.Fill(ds, "MPLCUSTOMER");
            dgCustomer.DataSource = ds;
            dgCustomer.DataMember = "MPLCUSTOMER";

        }
        void Clear()
        {
            txtCusID.Text = "";
            txtCusName.Text = "";
            txtCusAdLine1.Text = "";
            txtCusSvatNo.Text = "";
            txtCusVatNo.Text = "";
            txtCusTell.Text = "";
            cboCusTitle.Text = "";
            txtCusMobNo.Text = "";
            txtCusFaxNo.Text = "";
            txtCusEmail.Text = "";
            txtCusConPerson.Text = "";
            chkCusBlocked.Checked = false;
            txtCusID.BackColor = Color.Empty;
        }

        private void cmdCusClear_Click(object sender, EventArgs e)
        {
             Clear();
             txtCusName.Focus();
             cmdCusDelete.Enabled = false;
             CmdCusUpdate.Enabled = false;
             cmdCusAdd.Enabled = true;
        }

        private void cmdCusExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Exit", "Markspen Labels _ Customer Exit", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            this.Close();
        }

        private void txtfind_TextChanged(object sender, EventArgs e)
        {
            SqlParameter psearch;
            psearch = new SqlParameter("@Cussearch", SqlDbType.VarChar, 50);
            psearch.Value=txtfind.Text;
            da = new SqlDataAdapter("sp_SearchCustomer", SQLcon);
            da.SelectCommand.Parameters.Add(psearch);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds=new DataSet();
            da.Fill(ds, "MPLCUSTOMER");
            dgCustomer.DataSource = ds;
            dgCustomer.DataMember = "MPLCUSTOMER";
        }

        private void cmdCusAdd_Click(object sender, EventArgs e)
        {
            //validate Sup name Is empty
            if (string.IsNullOrEmpty(txtCusName.Text))
            {
                MessageBox.Show("Enter Customer Name", "Markspen Labels");
                return;
            }
            if (string.IsNullOrEmpty(cboCusType.Text))
            {
                MessageBox.Show("Enter Customer Type", "Markspen Labels");
                return;
            }
            if (string.IsNullOrEmpty(txtCusAdLine1.Text))
            {
                MessageBox.Show("Enter Customer Address", "Markspen Labels");
                return;
            }
            // Save parameters----------------------------------------------------------

            pCusType = new SqlParameter("@CusType", SqlDbType.VarChar, 50);
            pCusDate = new SqlParameter("@CusDate", SqlDbType.Date);
            pCusStatus = new SqlParameter("@CusStatus", SqlDbType.Int);
            pCusName = new SqlParameter("@CusName", SqlDbType.VarChar, 200);
            pCusVatNo = new SqlParameter("@CusVatNo", SqlDbType.VarChar, 50);
            pCusSVatNo = new SqlParameter("@CusSVatNo", SqlDbType.VarChar, 50);
            pCusAddress = new SqlParameter("@CusAddress", SqlDbType.VarChar, 250);
            pCusContactPerson = new SqlParameter("@CusContactPerson", SqlDbType.VarChar, 100);
            pCusConPTitle = new SqlParameter("@CusConPTitle", SqlDbType.VarChar, 50);
            pCusTell = new SqlParameter("@CusTell", SqlDbType.VarChar, 50);
            pCusMob = new SqlParameter("@CusMob", SqlDbType.VarChar, 50);
            pCusFax = new SqlParameter("@CusFax", SqlDbType.VarChar, 50);
            pCusEmail = new SqlParameter("@CusEmail", SqlDbType.VarChar, 50);

            //Assign values for parameters---------------------------------------------

            pCusType.Value = (cboCusType.SelectedItem).ToString();

            pCusDate.Value = dtpCus.Text;

            if (chkCusBlocked.Checked == true)
            {
                pCusStatus.Value = Convert.ToInt16("1");
            }
            else
            {
                pCusStatus.Value = Convert.ToInt16("0");
            }

            pCusName.Value = txtCusName.Text;
            pCusVatNo.Value = txtCusVatNo.Text;
            pCusSVatNo.Value = txtCusSvatNo.Text;
            pCusAddress.Value = txtCusAdLine1.Text;
            pCusContactPerson.Value = txtCusConPerson.Text;
            pCusConPTitle.Value = (cboCusTitle.SelectedText).ToString();
            pCusTell.Value = txtCusTell.Text;
            pCusMob.Value = txtCusMobNo.Text;
            pCusFax.Value = txtCusFaxNo.Text;
            pCusEmail.Value = txtCusEmail.Text;

            com = new SqlCommand("sp_AddCustomer", SQLcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(pCusType);
            com.Parameters.Add(pCusDate);
            com.Parameters.Add(pCusName);
            com.Parameters.Add(pCusAddress);
            com.Parameters.Add(pCusVatNo);
            com.Parameters.Add(pCusSVatNo);
            com.Parameters.Add(pCusStatus);
            com.Parameters.Add(pCusConPTitle);
            com.Parameters.Add(pCusContactPerson);
            com.Parameters.Add(pCusMob);
            com.Parameters.Add(pCusTell);
            
            com.Parameters.Add(pCusFax);
            com.Parameters.Add(pCusEmail);
            com.ExecuteScalar();
            MessageBox.Show("Customer was Added","MARKSPEN LABELS - CUSTOMER");

            dgCustomer.Refresh();
            Prefill();

            Clear();
            dgCustomer.Focus();
        }

        private void cmdCusDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCusID.Text))
            {
                MessageBox.Show("Select Supplier", "Markspen Labels _ Supplier Delete");
                return;
            }
            if (MessageBox.Show("Are You Sure You want to Delete ?", "Markspen Labels _ Supplier Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Delete Data
                pCusID = new SqlParameter("@Cuscode", SqlDbType.Int);
                pCusID.Value = Convert.ToInt16(txtCusID.Text);
                com = new SqlCommand("sp_CustomerDelete ", SQLcon);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(pCusID);
                com.ExecuteScalar();

                MessageBox.Show("Supplier was  Deleted ", "Markspen Labels _ Supplier Delete");
                Clear();
                dgCustomer.Refresh();
                Prefill();
                dgCustomer.Focus();
            }
        }

        private void dgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmdCusDelete.Enabled = true;
            CmdCusUpdate.Enabled = true;
            cmdCusAdd.Enabled = false;
            if(dgCustomer.CurrentCell.Value.ToString() != "")
            {
            txtCusID.Text = ds.Tables[0].Rows[dgCustomer.CurrentCell.RowIndex].ItemArray[0].ToString();
            cboCusType.Text = ds.Tables[0].Rows[dgCustomer.CurrentCell.RowIndex].ItemArray[1].ToString();
            dtpCus.Text = ds.Tables[0].Rows[dgCustomer.CurrentCell.RowIndex].ItemArray[2].ToString();
            txtCusName.Text = ds.Tables[0].Rows[dgCustomer.CurrentCell.RowIndex].ItemArray[3].ToString();
            txtCusAdLine1.Text = ds.Tables[0].Rows[dgCustomer.CurrentCell.RowIndex].ItemArray[4].ToString();
            txtCusVatNo.Text = ds.Tables[0].Rows[dgCustomer.CurrentCell.RowIndex].ItemArray[5].ToString();
            txtCusSvatNo.Text = ds.Tables[0].Rows[dgCustomer.CurrentCell.RowIndex].ItemArray[6].ToString();
                // get value for checkbox
            string strcheck = ds.Tables[0].Rows[dgCustomer.CurrentCell.RowIndex].ItemArray[7].ToString();

            if (strcheck == "1")
            {
                chkCusBlocked.Checked = true;
                txtCusID.BackColor = Color.Red;
            }
            else 
            {
                chkCusBlocked.Checked = false;
                txtCusID.BackColor = Color.Empty;
            }
            //chkCusBlocked.Text = ds.Tables[0].Rows[dgCustomer.CurrentCell.RowIndex].ItemArray[7].ToString();
            cboCusTitle.Text = ds.Tables[0].Rows[dgCustomer.CurrentCell.RowIndex].ItemArray[8].ToString();
            txtCusConPerson.Text = ds.Tables[0].Rows[dgCustomer.CurrentCell.RowIndex].ItemArray[9].ToString();
            txtCusMobNo.Text = ds.Tables[0].Rows[dgCustomer.CurrentCell.RowIndex].ItemArray[10].ToString();
            txtCusTell.Text = ds.Tables[0].Rows[dgCustomer.CurrentCell.RowIndex].ItemArray[11].ToString();
            txtCusFaxNo.Text = ds.Tables[0].Rows[dgCustomer.CurrentCell.RowIndex].ItemArray[12].ToString();
            txtCusEmail.Text = ds.Tables[0].Rows[dgCustomer.CurrentCell.RowIndex].ItemArray[13].ToString();
            }
          
        }

        private void CmdCusUpdate_Click(object sender, EventArgs e)
        {
            pCusID = new SqlParameter("@CusID", SqlDbType.Int);
            pCusType = new SqlParameter("@CusType", SqlDbType.VarChar, 50);
            pCusDate = new SqlParameter("@CusDate", SqlDbType.Date);
            pCusStatus = new SqlParameter("@CusStatus", SqlDbType.Int);
            pCusName = new SqlParameter("@CusName", SqlDbType.VarChar, 200);
            pCusVatNo = new SqlParameter("@CusVatNo", SqlDbType.VarChar, 50);
            pCusSVatNo = new SqlParameter("@CusSVatNo", SqlDbType.VarChar, 50);
            pCusAddress = new SqlParameter("@CusAddress", SqlDbType.VarChar, 250);
            pCusContactPerson = new SqlParameter("@CusContactPerson", SqlDbType.VarChar, 100);
            pCusConPTitle = new SqlParameter("@CusConPTitle", SqlDbType.VarChar, 50);
            pCusTell = new SqlParameter("@CusTell", SqlDbType.VarChar, 50);
            pCusMob = new SqlParameter("@CusMob", SqlDbType.VarChar, 50);
            pCusFax = new SqlParameter("@CusFax", SqlDbType.VarChar, 50);
            pCusEmail = new SqlParameter("@CusEmail", SqlDbType.VarChar, 50);

            //Assign values for parameters---------------------------------------------
            pCusID.Value = Convert.ToInt16(txtCusID.Text.ToString());
            pCusType.Value = (cboCusType.SelectedItem).ToString();

            pCusDate.Value = dtpCus.Text;

            if (chkCusBlocked.Checked == true)
            {
                pCusStatus.Value = Convert.ToInt16("1");
            }
            else
            {
                pCusStatus.Value = Convert.ToInt16("0");
            }

            pCusName.Value = txtCusName.Text;
            pCusVatNo.Value = txtCusVatNo.Text;
            pCusSVatNo.Value = txtCusSvatNo.Text;
            pCusAddress.Value = txtCusAdLine1.Text;
            pCusContactPerson.Value = txtCusConPerson.Text;
            pCusConPTitle.Value = (cboCusTitle.SelectedItem).ToString();
            pCusTell.Value = txtCusTell.Text;
            pCusMob.Value = txtCusMobNo.Text;
            pCusFax.Value = txtCusFaxNo.Text;
            pCusEmail.Value = txtCusEmail.Text;

            com = new SqlCommand("sp_UpdateCustomer", SQLcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(pCusID);
            com.Parameters.Add(pCusType);
            com.Parameters.Add(pCusDate);
            com.Parameters.Add(pCusName);
            com.Parameters.Add(pCusAddress);
            com.Parameters.Add(pCusVatNo);
            com.Parameters.Add(pCusSVatNo);
            com.Parameters.Add(pCusStatus);
            com.Parameters.Add(pCusConPTitle);
            com.Parameters.Add(pCusContactPerson);
            com.Parameters.Add(pCusMob);
            com.Parameters.Add(pCusTell);

            com.Parameters.Add(pCusFax);
            com.Parameters.Add(pCusEmail);
            com.ExecuteScalar();
            MessageBox.Show("Customer was Updated", "MARKSPEN LABELS - CUSTOMER");

            dgCustomer.Refresh();
            Prefill();

            Clear();
            dgCustomer.Focus();

        }

        private void txtCusEmail_Leave(object sender, EventArgs e)
        {
            Regex rx = new Regex("[a-zA-Z0-9]{1-20}@[a-zA-z0-9]{1-20}.[a-zA-Z]{2,3}");
            if (!rx.IsMatch(txtCusEmail.Text))
            {
                lblEmailval.Text = "Invalied Email Address";
            }
            else
            {
                lblEmailval.Text = "";
            }
           
        }

        private void txtCusEmail_TabIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtCusEmail_TextChanged(object sender, EventArgs e)
        {
            lblEmailval.Text = "";
        }
    }
}
