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
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;// Bring data
        DataSet ds; // Holding data
        SqlCommand com;
        SqlParameter pStaffId, pSFName, pSLName, pSDOB, pSsex, pSAddress, pSMobNO, pSUName, pSPWD, pSRoleID, pSTitle, pSRoleName;
        SqlConnection SQLcon;

        private void frmStaff_Load(object sender, EventArgs e)
        {
            //Open Connection 
            try
            {

            Connection obj = new Connection();
            SQLcon = obj.con();
            SQLcon.Open();
           
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message); 
                
            }

            cboStaffRole.Focus();

            // Load data to data grid----------------------------------

            Prefill();
            txtStaffID.Enabled = false;

            cmdStaffDelete.Enabled = false;
            CmdStaffUpdate.Enabled = false;
        }
        void Prefill()
        {
            da = new SqlDataAdapter("sp_GetStaff", SQLcon);
            ds = new DataSet();
            da.Fill(ds, "MPLSTAFF");
            dgStaff.DataSource = ds;
            dgStaff.DataMember = "MPLSTAFF";

            SqlDataAdapter da1;
            DataSet ds1;
            
            
            da1 = new SqlDataAdapter("sp_GetSRole", SQLcon);
            ds1 = new DataSet();
            da1.Fill(ds1, "MPLROLE");
            cboStaffRole.DataSource = ds1;
            cboStaffRole.DisplayMember = "MPLROLE.ROLENAME";
            cboStaffRole.ValueMember = "MPLROLE.ROLEID";

        }
        void Clear()
        {
            txtStaffID.Text = "";
            cboStaffRole.Text = "";
            txtSFName.Text = "";
            txtSLName.Text = "";
            dtpStaffDOB.Text = "";
            cboSSex.Text = "";
            txtSAddress.Text = "";
            txtStaffMobNo.Text = "";
            txtStaffUName.Text = "";
            txtSPWD.Text = "";
            txtSConformPWD.Text = "";
            cboSTitle.Text = "";
        }

        private void cmdStaffClear_Click(object sender, EventArgs e)
        {
            cmdStaffDelete.Enabled = false;
            CmdStaffUpdate.Enabled = false;
            cmdStaffAdd.Enabled = true;
            Clear();
            cboStaffRole.Focus();
        }

        private void cmdStaffExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Exit", "Markspen Labels _ Staff Exit", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            this.Close();
        }

        private void txtStaffFind_TextChanged(object sender, EventArgs e)
        {
            SqlParameter psearch;
            psearch = new SqlParameter("@Cussearch", SqlDbType.VarChar, 50);
            psearch.Value = txtStaffFind.Text;
            da = new SqlDataAdapter("sp_SearchStaff", SQLcon);
            da.SelectCommand.Parameters.Add(psearch);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            da.Fill(ds, "MPLSTAFF");
            dgStaff.DataSource = ds;
            dgStaff.DataMember = "MPLSTAFF";
        }

        private void cmdStaffAdd_Click(object sender, EventArgs e)
        {
            //validate Sup name Is empty
            if (string.IsNullOrEmpty(txtSFName.Text))
            {
                MessageBox.Show("Enter First Name", "Markspen Labels");
                return;

            }
            if (string.IsNullOrEmpty(txtSLName.Text))
            {
                MessageBox.Show("Enter Last Name", "Markspen Labels");
                return;
            }
            if (string.IsNullOrEmpty(txtStaffUName.Text))
            {
                MessageBox.Show("Enter User Name", "Markspen Labels");
                return;
            }
            if (string.IsNullOrEmpty(txtSPWD.Text))
            {
                MessageBox.Show("Enter Password", "Markspen Labels");
                return;
            }
            if (string.IsNullOrEmpty(txtSConformPWD.Text))
            {
                MessageBox.Show("Enter Confrom Password", "Markspen Labels");
                return;
            }
            if (txtSPWD.Text != txtSConformPWD.Text)
            {
                MessageBox.Show("Enter Same Password to Conform Password", "Markspen Labels");
                return;
            }
            // Save parameters----------------------------------------------------------

            //pStaffId = new SqlParameter("@StaffId", SqlDbType.Int);
            pSFName = new SqlParameter("@SFName", SqlDbType.VarChar, 50);
            pSLName = new SqlParameter("@SLName", SqlDbType.VarChar, 50);
            pSDOB = new SqlParameter("@SDOB", SqlDbType.Date);
            pSsex = new SqlParameter("@Ssex", SqlDbType.VarChar, 50);
            pSAddress = new SqlParameter("@SAddress", SqlDbType.VarChar, 150);
            pSMobNO = new SqlParameter("@SMobNO", SqlDbType.VarChar, 50);
            pSUName = new SqlParameter("@SUName", SqlDbType.VarChar, 50);
            pSPWD = new SqlParameter("@SPWD", SqlDbType.VarChar, 50);
            pSRoleID = new SqlParameter("@SRoleID", SqlDbType.Int);
            pSTitle = new SqlParameter("@STitle", SqlDbType.VarChar, 50);
            pSRoleName = new SqlParameter("@SRoleName", SqlDbType.VarChar, 50);
            //pSRoleDescription = new SqlParameter("@SRoleDescription", SqlDbType.VarChar, 100);

            // add value to parameters
            pSFName.Value = txtSFName.Text;
            pSLName.Value = txtSLName.Text;
            pSDOB.Value = dtpStaffDOB.Text;
            pSsex.Value = (cboSSex.SelectedItem).ToString();
            pSAddress.Value = txtSAddress.Text;
            pSMobNO.Value = txtStaffMobNo.Text;
            pSUName.Value = txtStaffUName.Text;
            pSPWD.Value = txtSPWD.Text;
            pSRoleID.Value = Convert.ToInt16(cboStaffRole.SelectedValue);
            pSTitle.Value = (cboSTitle.SelectedItem).ToString();
            //pSRoleName.Value = cboStaffRole.Text;
            //pSRoleDescription.Value=

            com = new SqlCommand("sp_AddStaff", SQLcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(pSFName);
            com.Parameters.Add(pSLName);
            com.Parameters.Add(pSDOB);
            com.Parameters.Add(pSsex);
            com.Parameters.Add(pSAddress);
            com.Parameters.Add(pSMobNO);
            com.Parameters.Add(pSUName);
            com.Parameters.Add(pSPWD);
            com.Parameters.Add(pSRoleID);
            com.Parameters.Add(pSTitle);

            com.ExecuteScalar();

            MessageBox.Show("Staff Member was Added", "MARKSPEN LABELS - Staff");

            dgStaff.Refresh();
            Prefill();

            Clear();
            txtSFName.Focus();

        }

        private void cmdStaffDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStaffID.Text))
            {
                MessageBox.Show("Select Staff Member", "Markspen Labels _ Staff Member Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("Are You Sure You want to Delete ?", "Markspen Labels _ Supplier Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Delete Data
                pStaffId = new SqlParameter("@StaffId", SqlDbType.Int);
                pStaffId.Value = Convert.ToInt16(txtStaffID.Text);
                com = new SqlCommand("sp_StaffDelete ", SQLcon);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(pStaffId);
                com.ExecuteScalar();

                MessageBox.Show("Staff Member was  Deleted ", "Markspen Labels _ Staff Member Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                dgStaff.Refresh();
                Prefill();
                dgStaff.Focus();
            }



        }

        private void dgStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmdStaffDelete.Enabled = true;
            CmdStaffUpdate.Enabled = true;
            cmdStaffAdd.Enabled = false;
            if (dgStaff.CurrentCell.Value.ToString() != "")
            {

                txtStaffID.Text = ds.Tables["MPLSTAFF"].Rows[dgStaff.CurrentCell.RowIndex].ItemArray[0].ToString();
                txtSFName.Text = ds.Tables["MPLSTAFF"].Rows[dgStaff.CurrentCell.RowIndex].ItemArray[1].ToString();
                txtSLName.Text = ds.Tables["MPLSTAFF"].Rows[dgStaff.CurrentCell.RowIndex].ItemArray[2].ToString();
                dtpStaffDOB.Text = ds.Tables["MPLSTAFF"].Rows[dgStaff.CurrentCell.RowIndex].ItemArray[3].ToString();
                cboSSex.Text = ds.Tables["MPLSTAFF"].Rows[dgStaff.CurrentCell.RowIndex].ItemArray[4].ToString();
                txtSAddress.Text = ds.Tables["MPLSTAFF"].Rows[dgStaff.CurrentCell.RowIndex].ItemArray[5].ToString();
                txtStaffMobNo.Text = ds.Tables["MPLSTAFF"].Rows[dgStaff.CurrentCell.RowIndex].ItemArray[6].ToString();
                txtStaffUName.Text = ds.Tables["MPLSTAFF"].Rows[dgStaff.CurrentCell.RowIndex].ItemArray[7].ToString();
                txtSPWD.Text = ds.Tables["MPLSTAFF"].Rows[dgStaff.CurrentCell.RowIndex].ItemArray[8].ToString();
                cboStaffRole.Text = ds.Tables["MPLSTAFF"].Rows[dgStaff.CurrentCell.RowIndex].ItemArray[9].ToString();
                cboSTitle.Text = ds.Tables["MPLSTAFF"].Rows[dgStaff.CurrentCell.RowIndex].ItemArray[10].ToString();
            }
        }
        private void CmdStaffUpdate_Click(object sender, EventArgs e)
        {
            pStaffId = new SqlParameter("@StaffId", SqlDbType.Int);
            pSFName = new SqlParameter("@SFName", SqlDbType.VarChar, 50);
            pSLName = new SqlParameter("@SLName", SqlDbType.VarChar, 50);
            pSDOB = new SqlParameter("@SDOB", SqlDbType.Date);
            pSsex = new SqlParameter("@Ssex", SqlDbType.VarChar, 50);
            pSAddress = new SqlParameter("@SAddress", SqlDbType.VarChar, 150);
            pSMobNO = new SqlParameter("@SMobNO", SqlDbType.VarChar, 50);
            pSUName = new SqlParameter("@SUName", SqlDbType.VarChar, 50);
            pSPWD = new SqlParameter("@SPWD", SqlDbType.VarChar, 50);
            pSRoleID = new SqlParameter("@SRoleID", SqlDbType.Int);
            pSTitle = new SqlParameter("@STitle", SqlDbType.VarChar, 50);
            //pSRoleName = new SqlParameter("@SRoleName", SqlDbType.VarChar, 50);
            //pSRoleDescription = new SqlParameter("@SRoleDescription", SqlDbType.VarChar, 100);

            // add value to parameters
            pStaffId.Value = txtStaffID.Text;
            pSFName.Value = txtSFName.Text;
            pSLName.Value = txtSLName.Text;
            pSDOB.Value = dtpStaffDOB.Text;
            pSsex.Value = (cboSSex.SelectedItem).ToString();
            pSAddress.Value = txtSAddress.Text;
            pSMobNO.Value = txtStaffMobNo.Text;
            pSUName.Value = txtStaffUName.Text;
            pSPWD.Value = txtSPWD.Text;
            pSRoleID.Value = Convert.ToInt16(cboStaffRole.SelectedValue);
            pSTitle.Value = (cboSTitle.SelectedItem).ToString();
            //pSRoleName.Value = cboStaffRole.Text;
            //pSRoleDescription.Value=

            com = new SqlCommand("sp_UpdateStaf", SQLcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(pStaffId);
            com.Parameters.Add(pSFName);
            com.Parameters.Add(pSLName);
            com.Parameters.Add(pSDOB);
            com.Parameters.Add(pSsex);
            com.Parameters.Add(pSAddress);
            com.Parameters.Add(pSMobNO);
            com.Parameters.Add(pSUName);
            com.Parameters.Add(pSPWD);
            com.Parameters.Add(pSRoleID);
            com.Parameters.Add(pSTitle);

            com.ExecuteScalar();

            MessageBox.Show("Staff Member was Updated", "MARKSPEN LABELS - Staff");

            dgStaff.Refresh();
            Prefill();

            Clear();
            txtSFName.Focus();

        

       

        }
    }
}
