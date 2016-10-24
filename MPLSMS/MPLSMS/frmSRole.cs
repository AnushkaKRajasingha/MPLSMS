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
    public partial class frmSRole : Form
    {
        public frmSRole()
        {
            InitializeComponent();
        }
            SqlDataAdapter da;// Bring data
            DataSet ds; // Holding data
            SqlCommand com;
            SqlParameter pRoleId, pRoleName, pRdescription;
            SqlConnection SQLcon;
        private void frmSRole_Load(object sender, EventArgs e)
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
            
            txtRoleName.Focus();
            // Load data to data grid----------------------------------
           
            Prefill();
            txtRoleID.Enabled = false;
            // deactive BUttons
            CmdSRoleUpdate.Enabled = false;
            cmdSRoleDelete.Enabled = false;
           
        }
           void Prefill(){
               da = new SqlDataAdapter("sp_GetSRole", SQLcon);
            ds = new DataSet();
            da.Fill(ds, "MPLROLE");
            dgSRole.DataSource = ds;
            dgSRole.DataMember = "MPLROLE";
            }
           void Clear() 
           {
               txtRoleID.Text = "";
               txtRoleName.Text = "";
               txtDescription.Text="";
               txtSroleFind.Text="";
           }

           private void cmdSRoleClear_Click(object sender, EventArgs e)
           {
               Clear();
               txtRoleName.Focus();
               cmdSRoleAdd.Enabled = true;
               CmdSRoleUpdate.Enabled = false;
               cmdSRoleDelete.Enabled = false;
           }

           private void cmdSRoleExit_Click(object sender, EventArgs e)
           {
               if (MessageBox.Show("Are You Sure You Want to Exit", "Markspen Labels _ Staff  Role Exit", MessageBoxButtons.YesNo) == DialogResult.No)
               {
                   return;
               }
               this.Close();
           }

           private void txtSroleFind_TextChanged(object sender, EventArgs e)
           {
               SqlParameter psearch;
               psearch = new SqlParameter("@Rolesearch", SqlDbType.VarChar, 50);
               psearch.Value = txtSroleFind.Text;
               da = new SqlDataAdapter("sp_SearchSRole", SQLcon);
               da.SelectCommand.Parameters.Add(psearch);
               da.SelectCommand.CommandType = CommandType.StoredProcedure;
               ds = new DataSet();
               da.Fill(ds, "MPLROLE");
               dgSRole.DataSource = ds;
               dgSRole.DataMember = "MPLROLE";

           }

           private void cmdSRoleAdd_Click(object sender, EventArgs e)
           {
               if (string.IsNullOrEmpty(txtRoleName.Text))
               {
                   MessageBox.Show("Enter Role Name", "Markspen Labels");
                   return;

               }
               //pRoleId = new SqlParameter("@RoleId", SqlDbType.Int);
               pRoleName = new SqlParameter("@RoleName", SqlDbType.VarChar, 50);
               pRdescription = new SqlParameter("@Rdescription", SqlDbType.VarChar, 50);

                pRoleName.Value = txtRoleName.Text;
                pRdescription.Value = txtDescription.Text;

                com = new SqlCommand("sp_AddStaffRole", SQLcon);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(pRoleName);
                com.Parameters.Add(pRdescription);

                com.ExecuteScalar();

                MessageBox.Show("Staff Role was Added", "MARKSPEN LABELS - Staff Role",MessageBoxButtons.OK,MessageBoxIcon.Information);

                dgSRole.Refresh();
                Prefill();

                Clear();
                dgSRole.Focus();
           }

           private void cmdSRoleDelete_Click(object sender, EventArgs e)
           {
               if (string.IsNullOrEmpty(txtRoleID.Text))
               {
                   MessageBox.Show("Select Role ", "Markspen Labels _ Staff Member Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   return;
               }
               if (MessageBox.Show("Are You Sure You want to Delete ?", "Markspen Labels _ Role Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
               {
                   // Delete Data
                   pRoleId = new SqlParameter("@RoleId", SqlDbType.Int);
                   pRoleId.Value = Convert.ToInt16(txtRoleID.Text);
                   com = new SqlCommand("sp_SRoleDelete", SQLcon);
                   com.CommandType = CommandType.StoredProcedure;
                   com.Parameters.Add(pRoleId);
                   com.ExecuteScalar();

                   MessageBox.Show("Role was  Deleted ", "Markspen Labels _ Staff Member Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   Clear();
                   dgSRole.Refresh();
                   Prefill();
                   txtRoleName.Focus();
               }
           }

           private void dgSRole_CellClick(object sender, DataGridViewCellEventArgs e)
           {
               txtRoleID.Text = ds.Tables[0].Rows[dgSRole.CurrentCell.RowIndex].ItemArray[0].ToString();
               txtRoleName.Text = ds.Tables[0].Rows[dgSRole.CurrentCell.RowIndex].ItemArray[1].ToString();
               txtDescription.Text = ds.Tables[0].Rows[dgSRole.CurrentCell.RowIndex].ItemArray[2].ToString();

               CmdSRoleUpdate.Enabled = true;
               cmdSRoleDelete.Enabled = true;
               cmdSRoleAdd.Enabled = false;
           }

           private void CmdSRoleUpdate_Click(object sender, EventArgs e)
           {
               pRoleId = new SqlParameter("@RoleId", SqlDbType.Int);
               pRoleName = new SqlParameter("@RoleName", SqlDbType.VarChar, 50);
               pRdescription = new SqlParameter("@Rdescription", SqlDbType.VarChar, 50);

               pRoleId.Value = Convert.ToInt16(txtRoleID.Text);
               pRoleName.Value = txtRoleName.Text;
               pRdescription.Value = txtDescription.Text;

               com = new SqlCommand("sp_UpdateSRole", SQLcon);
               com.CommandType = CommandType.StoredProcedure;

               com.Parameters.Add(pRoleId);
               com.Parameters.Add(pRoleName);
               com.Parameters.Add(pRdescription);


               com.ExecuteScalar();

               MessageBox.Show("Staff Role was Updated", "MARKSPEN LABELS - Staff Role");

               dgSRole.Refresh();
               Prefill();

               Clear();
               dgSRole.Focus();

           }




    }
}
