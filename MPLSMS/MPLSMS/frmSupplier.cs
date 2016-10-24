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
    public partial class frmSupplier : Form
    {
        public frmSupplier()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;// Bring data
        DataSet ds; // Holding data
        SqlCommand com;
        SqlParameter  pSupID, pSupDate, pSupStatus, pSupplierName, pSupVatNo, pSupSVatNo, pSupAddress, pSupContactPerson, pSupConPTitle, pSupTell, pSupMob, pSupFax, pSupEmail;
        SqlConnection SQLcon;
        private void frmSupplier_Load(object sender, EventArgs e)
        {
            //Open Connection 
            Connection obj = new Connection();
            SQLcon = obj.con();
            SQLcon.Open();
            txtSupName.Focus();
            // Load data to data grid----------------------------------

            Prefill();
            cboSupId.Enabled = false;
            cmdSupDelete.Enabled = false;
            CmdSupUpdate.Enabled = false;
        }

        private void cmdSupAdd_Click(object sender, EventArgs e)
        {
            //validate Sup name Is empty
            if (string.IsNullOrEmpty(txtSupName.Text))
            {
                MessageBox.Show("Enter Supplier Name","Markspen Labels");
                return;
             }
            if (string.IsNullOrEmpty(txtSupAdLine1.Text))
            {
                MessageBox.Show("Enter Supplier Address", "Markspen Labels");
                return;
            }

            // Save parameters----------------------------------------------------------
         
            pSupDate = new SqlParameter("@SupDate", SqlDbType.Date);
            pSupStatus = new SqlParameter("@SupStatus", SqlDbType.Int);
            pSupplierName = new SqlParameter("@SupplierName", SqlDbType.VarChar, 200);
            pSupVatNo = new SqlParameter("@SupVatNo", SqlDbType.VarChar, 50);
            pSupSVatNo = new SqlParameter("@SupSVatNo", SqlDbType.VarChar, 50);
            pSupAddress = new SqlParameter("@SupAddress", SqlDbType.VarChar, 250);
            pSupContactPerson = new SqlParameter("@SupContactPerson", SqlDbType.VarChar, 100);
            pSupConPTitle = new SqlParameter("@SupConPTitle", SqlDbType.VarChar, 50);
            pSupTell = new SqlParameter("@SupTell", SqlDbType.VarChar, 50);
            pSupMob = new SqlParameter("@SupMob", SqlDbType.VarChar, 50);
            pSupFax = new SqlParameter("@SupFax", SqlDbType.VarChar, 50);
            pSupEmail = new SqlParameter("@SupEmail", SqlDbType.VarChar, 50);

            //Assign values for parameters---------------------------------------------
       
            pSupDate.Value = dtpSup.Text;

            if (chkSupBlocked.Checked==true)
            {
            pSupStatus.Value = Convert.ToInt16("1");
            }
            else{
                pSupStatus.Value = Convert.ToInt16("0");
            }

            pSupplierName.Value=txtSupName.Text;
            pSupVatNo.Value=txtSupVatNo.Text;
            pSupSVatNo.Value=txtSupSvatNo.Text;
            pSupAddress.Value=txtSupAdLine1.Text;
            pSupContactPerson.Value = txtConPerson.Text;
            pSupConPTitle.Value = (cboTitle.SelectedItem).ToString();
            pSupTell.Value=txtTell.Text;
            pSupMob.Value=txtMobNo.Text;
            pSupFax.Value=txtFaxNo.Text;
            pSupEmail.Value=txtEmail.Text;

            com = new SqlCommand("sp_AddSupliers", SQLcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(pSupDate);
            com.Parameters.Add(pSupStatus);
            com.Parameters.Add(pSupplierName);
            com.Parameters.Add(pSupVatNo);
            com.Parameters.Add(pSupSVatNo);
            com.Parameters.Add(pSupAddress);
            com.Parameters.Add(pSupContactPerson);
            com.Parameters.Add(pSupConPTitle);
            com.Parameters.Add(pSupTell);
            com.Parameters.Add(pSupMob);
            com.Parameters.Add(pSupFax);
            com.Parameters.Add(pSupEmail);

            com.ExecuteScalar();
            MessageBox.Show("Supplier was Added");

            dgSupplir.Refresh();
            Prefill();

            Clear();
            txtSupName.Focus();

        }
        // Methode for fill Data to the grid
        void Prefill() 
        {
            da = new SqlDataAdapter("sp_GetSupplier", SQLcon);
            ds = new DataSet();
            da.Fill(ds, "MPLSUPPLIER");
            dgSupplir.DataSource = ds;
            dgSupplir.DataMember = "MPLSUPPLIER";

        }
        // metode for Clear all Data
        void Clear()
        {
            cboSupId.Text = "";
            txtSupName.Text = "";
            txtSupAdLine1.Text = "";
            txtSupSvatNo.Text = "";
            txtSupVatNo.Text = "";
            txtTell.Text = "";
            cboTitle.Text = "";
            txtMobNo.Text = "";
            txtFaxNo.Text = "";
            txtEmail.Text = "";
            txtConPerson.Text = "";
            chkSupBlocked.Checked = false;
            txtSupName.BackColor = Color.Empty;
            cmdSupAdd.Enabled = true;
            cmdSupDelete.Enabled = false;
            CmdSupUpdate.Enabled = false;
            
        }

        private void txtfind_TextChanged(object sender, EventArgs e)
        {
            SqlParameter psearch;
            psearch=new SqlParameter("@search",SqlDbType.VarChar,50);
            psearch.Value=txtfind.Text;
            da = new SqlDataAdapter("sp_Search", SQLcon);
            da.SelectCommand.Parameters.Add(psearch);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds=new DataSet();
            da.Fill(ds,"MPLSUPPLIER");
            dgSupplir.DataSource = ds;
            dgSupplir.DataMember = "MPLSUPPLIER";
        }

       
        private void dgSupplir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            Clear();

            cmdSupDelete.Enabled = true;
            CmdSupUpdate.Enabled = true;
            cmdSupAdd.Enabled = false;

            if (dgSupplir.CurrentCell.Value.ToString() != "")
            {
                cboSupId.Text = ds.Tables[0].Rows[dgSupplir.CurrentCell.RowIndex].ItemArray[0].ToString();
                // Get value from Check box

                string strcheck = ds.Tables["MPLSUPPLIER"].Rows[dgSupplir.CurrentCell.RowIndex].ItemArray[2].ToString();

                if (strcheck == "1")
                {

                    chkSupBlocked.Checked = true;
                    txtSupName.BackColor = Color.Red;
                }
                else
                {
                    chkSupBlocked.Checked = false;
                    txtSupName.BackColor = Color.Empty;

                }

                txtSupName.Text = ds.Tables[0].Rows[dgSupplir.CurrentCell.RowIndex].ItemArray[3].ToString();
                txtSupVatNo.Text = ds.Tables[0].Rows[dgSupplir.CurrentCell.RowIndex].ItemArray[4].ToString();
                txtSupSvatNo.Text = ds.Tables[0].Rows[dgSupplir.CurrentCell.RowIndex].ItemArray[5].ToString();
                txtSupAdLine1.Text = ds.Tables[0].Rows[dgSupplir.CurrentCell.RowIndex].ItemArray[6].ToString();
                txtConPerson.Text = ds.Tables[0].Rows[dgSupplir.CurrentCell.RowIndex].ItemArray[7].ToString();
                cboTitle.Text = ds.Tables[0].Rows[dgSupplir.CurrentCell.RowIndex].ItemArray[8].ToString();
                txtTell.Text = ds.Tables[0].Rows[dgSupplir.CurrentCell.RowIndex].ItemArray[9].ToString();

                txtMobNo.Text = ds.Tables[0].Rows[dgSupplir.CurrentCell.RowIndex].ItemArray[10].ToString();
                txtFaxNo.Text = ds.Tables[0].Rows[dgSupplir.CurrentCell.RowIndex].ItemArray[11].ToString();
                txtEmail.Text = ds.Tables[0].Rows[dgSupplir.CurrentCell.RowIndex].ItemArray[12].ToString();
            }
        }

        private void cmdSupExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Exit", "Markspen Labels _ Supplier Exit", MessageBoxButtons.YesNo) == DialogResult.No) 
            {
                return;
            }
            this.Close();
        }

        private void cmdSupClear_Click(object sender, EventArgs e)
        {
            Clear();
            txtSupName.Focus();
        }

        private void cmdSupEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboSupId.Text))
            {
                MessageBox.Show("යකො Supplier කෙනෙක් Select කරල හිටහංකො හිටං", "Markspen Labels _ Supplier Delete");
                return;
            }
            if (MessageBox.Show("Are You Sure You want to Delete ?", "Markspen Labels _ Supplier Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Delete Data
                pSupID = new SqlParameter("@Supcode", SqlDbType.Int);
                pSupID.Value = Convert.ToInt16(cboSupId.Text);
                com = new SqlCommand("sp_SupplierDelete ", SQLcon);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(pSupID);
                com.ExecuteScalar();

                MessageBox.Show("Supplier was  Deleted ", "Markspen Labels _ Supplier Delete");

                dgSupplir.Refresh();
                Prefill();
                txtSupName.Focus();

            }
        }

        private void CmdSupUpdate_Click(object sender, EventArgs e)
        {

            pSupID = new SqlParameter("@SupID", SqlDbType.Int);
            pSupDate = new SqlParameter("@SupDate", SqlDbType.Date);
            pSupStatus = new SqlParameter("@SupStatus", SqlDbType.Int);
            pSupplierName = new SqlParameter("@SupplierName", SqlDbType.VarChar, 200);
            pSupVatNo = new SqlParameter("@SupVatNo", SqlDbType.VarChar, 50);
            pSupSVatNo = new SqlParameter("@SupSVatNo", SqlDbType.VarChar, 50);
            pSupAddress = new SqlParameter("@SupAddress", SqlDbType.VarChar, 250);
            pSupContactPerson = new SqlParameter("@SupContactPerson", SqlDbType.VarChar, 100);
            pSupConPTitle = new SqlParameter("@SupConPTitle", SqlDbType.VarChar, 50);
            pSupTell = new SqlParameter("@SupTell", SqlDbType.VarChar, 50);
            pSupMob = new SqlParameter("@SupMob", SqlDbType.VarChar, 50);
            pSupFax = new SqlParameter("@SupFax", SqlDbType.VarChar, 50);
            pSupEmail = new SqlParameter("@SupEmail", SqlDbType.VarChar, 50);

            //Assign values
            pSupID.Value = Convert.ToInt16(cboSupId.Text.ToString());
            pSupDate.Value = dtpSup.Text;


            if (chkSupBlocked.Checked == true)
            {
                pSupStatus.Value = Convert.ToInt16("1");
            }
            else
            {
                pSupStatus.Value = Convert.ToInt16("0");
            }

            pSupplierName.Value = txtSupName.Text;
            pSupVatNo.Value = txtSupVatNo.Text;
            pSupSVatNo.Value = txtSupSvatNo.Text;
            pSupAddress.Value = txtSupAdLine1.Text;
            pSupContactPerson.Value = txtConPerson.Text;
            pSupConPTitle.Value = (cboTitle.SelectedText).ToString();
            pSupTell.Value = txtTell.Text;
            pSupMob.Value = txtMobNo.Text;
            pSupFax.Value = txtFaxNo.Text;
            pSupEmail.Value = txtEmail.Text;

            com = new SqlCommand("sp_UpdateSupplier", SQLcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(pSupID);
            com.Parameters.Add(pSupDate);
            com.Parameters.Add(pSupStatus);
            com.Parameters.Add(pSupplierName);
            com.Parameters.Add(pSupVatNo);
            com.Parameters.Add(pSupSVatNo);
            com.Parameters.Add(pSupAddress);
            com.Parameters.Add(pSupContactPerson);
            com.Parameters.Add(pSupConPTitle);
            com.Parameters.Add(pSupTell);
            com.Parameters.Add(pSupMob);
            com.Parameters.Add(pSupFax);
            com.Parameters.Add(pSupEmail);
        com.ExecuteScalar();
            MessageBox.Show("Supplier was Updated.", "Markspen Labels _ Supplier Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
            dgSupplir.Refresh();
            Prefill();

            txtSupName.Focus();
          

        }

       
    }
}
