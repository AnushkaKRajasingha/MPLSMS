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
    public partial class frmICategory : Form
    {
        public frmICategory()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;// Bring data
        DataSet ds; // Holding data
        SqlCommand com;
        SqlParameter pICatId, pICatName;
        SqlConnection SQLcon;

        private void frmICategory_Load(object sender, EventArgs e)
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
            Prefill();
            cmdICatAdd.Enabled = true;
            cmdICatDelete.Enabled = false;
            CmdICatUpdate.Enabled = false;
            dgICat.Columns[1].Width = 400;

        }
         void Prefill()
        {
            da = new SqlDataAdapter("sp_GetICategory", SQLcon);
            ds = new DataSet();
            da.Fill(ds, "MPLITEMCATEGORY");
            dgICat.DataSource = ds;
            dgICat.DataMember = "MPLITEMCATEGORY";
        }
         void Clear()
         {
             txtICatID.Text = "";
             txtICatName.Text = "";
             txtICatFind.Text = "";
         }

         private void cmdICatClear_Click(object sender, EventArgs e)
         {
             Clear();
             cmdICatAdd.Enabled = true;
             cmdICatDelete.Enabled = false;
             CmdICatUpdate.Enabled = false;
             txtICatName.Focus();
         }

         private void cmdICatDelete_Click(object sender, EventArgs e)
         {
             // Delete Data
             // check ICat Name is Empty
             if (string.IsNullOrEmpty(txtICatName.Text))
             {
                 MessageBox.Show(" Please, Enter Category Name ", "Markspen Labels");
                 return;
             }

             pICatId = new SqlParameter("@ICatId", SqlDbType.Int);
             pICatId.Value = Convert.ToInt16(txtICatID.Text);
             com = new SqlCommand("sp_ICatDelete ", SQLcon);
             com.CommandType = CommandType.StoredProcedure;
             com.Parameters.Add(pICatId);
             com.ExecuteScalar();

             MessageBox.Show("Item Category was  Deleted ", "Markspen Labels _ Item Category Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
             Clear();
             dgICat.Refresh();
             Prefill();
             txtICatName.Focus();
         }

         private void txtICatFind_TextChanged(object sender, EventArgs e)
         {
         
             SqlParameter psearch;
             psearch = new SqlParameter("@ICatsearch", SqlDbType.VarChar, 50);
             psearch.Value = txtICatFind.Text;
             da = new SqlDataAdapter("sp_SearchICat", SQLcon);
             da.SelectCommand.Parameters.Add(psearch);
             da.SelectCommand.CommandType = CommandType.StoredProcedure;
             ds = new DataSet();
             da.Fill(ds, "MPLITEMCATEGORY");
             dgICat.DataSource = ds;
             dgICat.DataMember = "MPLITEMCATEGORY";
         }

         private void cmdICatAdd_Click(object sender, EventArgs e)
         {
             // check ICat Name is Empty
             if (string.IsNullOrEmpty(txtICatName.Text))
             {
                 MessageBox.Show(" Please, Enter Category Name ", "Markspen Labels");
                 return;
             }

             //Set Parameter

             pICatName = new SqlParameter("@ICatName", SqlDbType.VarChar, 50);

             pICatName.Value =txtICatName.Text;

             com = new SqlCommand("sp_AddICat", SQLcon);
             com.CommandType = CommandType.StoredProcedure;
             
             com.Parameters.Add(pICatName);
             com.ExecuteScalar();
        
             MessageBox.Show("Item Category was Added", "MARKSPEN LABELS - Item");

             dgICat.Refresh();
             Prefill();

             Clear();
             txtICatName.Focus();
         }

         private void cmdICatExit_Click(object sender, EventArgs e)
         {
             if (MessageBox.Show("Are You Sure You Want to Exit", "Markspen Labels _ Item Category Exit", MessageBoxButtons.YesNo) == DialogResult.No)
             {
                 return;
             }
             this.Close();
         }

         private void CmdICatUpdate_Click(object sender, EventArgs e)
         {
             pICatId = new SqlParameter("@ICatId", SqlDbType.Int);
             pICatName = new SqlParameter("@ICatName", SqlDbType.VarChar, 50);

             pICatId.Value = Convert.ToInt16(txtICatID.Text);
             pICatName.Value = txtICatName.Text;

             com = new SqlCommand("sp_UpdateIcat", SQLcon);
             com.CommandType = CommandType.StoredProcedure;

             com.Parameters.Add(pICatId);
             com.Parameters.Add(pICatName);


             com.ExecuteScalar();

             MessageBox.Show("Item Category was Updated", "MARKSPEN LABELS - Item Category ");

             dgICat.Refresh();
             Prefill();

             Clear();
             txtICatName.Focus();


         }

         private void dgICat_CellClick(object sender, DataGridViewCellEventArgs e)
         {
             txtICatID.Text = ds.Tables[0].Rows[dgICat.CurrentCell.RowIndex].ItemArray[0].ToString();
             txtICatName.Text = ds.Tables[0].Rows[dgICat.CurrentCell.RowIndex].ItemArray[1].ToString();

             cmdICatDelete.Enabled = true;
             CmdICatUpdate.Enabled = true;
             cmdICatAdd.Enabled = false;
         }
    }
}
