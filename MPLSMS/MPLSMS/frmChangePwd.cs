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
    public partial class frmChangePwd : Form
    {
        public frmChangePwd()
        {
            InitializeComponent();
        }
        SqlConnection SQLcon;
        SqlDataAdapter da;
        DataSet ds;
        string OldPwd;

        private void frmChangePwd_Load(object sender, EventArgs e)
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

            cboUserName.Focus();
            prefill();
        }
        public void prefill()
        {
            da = new SqlDataAdapter("sp_GetStaff", SQLcon);
            ds = new DataSet();
            da.Fill(ds, "MPLSTAFF");

            cboUserName.DataSource = ds;
            cboUserName.DisplayMember = "MPLSTAFF.USERNAME";
           
            //OldPwd = ds.Tables["MPLSTAFF"].Rows[0]["PWD"].ToString();
          
            
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (true)
            {
                
            }
        }

        private void cboUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string str1 = cboUserName.Text.ToString();
            
            MessageBox.Show(str1);
           
        }
    }
}
