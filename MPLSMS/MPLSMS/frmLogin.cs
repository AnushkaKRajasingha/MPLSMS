using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace MPLSMS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        SqlDataAdapter da, da1, daSupplier;// Bring data
        DataSet ds, ds1, dsSupplier; // Holding data
        SqlCommand com;
        SqlParameter pUserName, pItemName, pICategory, pIUnits, pIWSPrice,pITPL, pICATID, pIBIN, pIBarcode;
        SqlConnection SQLcon;

        private void frmLogin_Load(object sender, EventArgs e)
        { //Open Connection 
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
            txtPassWord.Focus();

        }

        private void cmdUserLogin_Click(object sender, EventArgs e)
        {
            pUserName = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            pUserName.Value = txtUsername.Text;
            da = new SqlDataAdapter("select * from MPLVIEW_USERLOGIN where USERNAME=@UserName", SQLcon);
            da.SelectCommand.Parameters.Add(pUserName);
            ds = new DataSet();
            da.Fill(ds, "MPLVIEW_USERLOGIN");

            if(ds.Tables[0].Rows.Count==0)
            {
                MessageBox.Show("Invalead Username Or Password", "invalead User");
                return;
            }
            if(ds.Tables[0].Rows[0].ItemArray[4].ToString()!=txtPassWord.Text.Trim())
            {
                MessageBox.Show("Invalead Password", "invalead User");
                return;
            }


            string userRoll = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            File.WriteAllText(@"G:\BIT Project 2016\System\MPLSMS\txtdata\words.txt", userRoll);

            string userID = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            File.WriteAllText(@"G:\BIT Project 2016\System\MPLSMS\txtdata\wordsID.txt", userID);

            string userName = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            File.WriteAllText(@"G:\BIT Project 2016\System\MPLSMS\txtdata\wordsName.txt", userName);

            string userDes = ds.Tables[0].Rows[0].ItemArray[5].ToString();
            File.WriteAllText(@"G:\BIT Project 2016\System\MPLSMS\txtdata\wordsUserDes.txt", userDes);

            string StaffID = ds.Tables[0].Rows[0].ItemArray[4].ToString();
            File.WriteAllText(@"G:\BIT Project 2016\System\MPLSMS\txtdata\wordsStaffID.txt", StaffID);



            frmMPLMain mn = new frmMPLMain();
            mn.Show();
            this.Hide();

        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Exit", "Markspen Labels _  Exit", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            this.Close();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {


           
        }

        private void txtUsername_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
    }
}
