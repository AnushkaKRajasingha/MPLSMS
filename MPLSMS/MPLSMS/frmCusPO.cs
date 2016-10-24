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
    public partial class frmCusPO : Form
    {
        public frmCusPO()
        {
            InitializeComponent();
        }
        SqlConnection SQLcon;
        SqlDataAdapter daCustomer, daItem, damaxpo;
        DataSet dsCustomer,dsItem,dsMaxPo;
        DataTable dtCusPo;
        DataRow drCusPo;
        SqlParameter pPono, pPodate, pCusId, pCusname, pItemID, pItemName, pQty,pUserID;
        int userID;
        SqlCommand com;
        private void frmCusPO_Load(object sender, EventArgs e)
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

            prefill();


            //add data to data table 
            dtCusPo = new DataTable("CusPo");// Table name can give any name in here it is CusPo
            dtCusPo.Columns.Add("Item ID");
            dtCusPo.Columns.Add("Item Name");
            dtCusPo.Columns.Add("Quantity");

            //create new table and Assign data table to data set
            dsItem = new DataSet();
            dsItem.Tables.Add(dtCusPo);
            dgCusPo.DataSource = dsItem;
            dgCusPo.DataMember = "CusPo";
            dgCusPo.Columns[1].Width = 150;// set column width

            String userID_File = File.ReadAllText(@"D:\BIT Project 2016\System\MPLSMS\txtdata\wordsID.txt");


            userID = Convert.ToInt32(userID_File);// Shuld change after create loggin

            Maxwal();
            Clear();

            cboCusID.Focus();
        }
        public void Clear()
        {
            cboCusID.Text = "";
            cboCusName.Text = "";
            cboItemID.Text = "";
            cboItemDescription.Text = "";
            txtQty.Text = "";
            
        }
        public void Maxwal()
        {
            damaxpo = new SqlDataAdapter("sp_GetMaxCusPONo", SQLcon);
            dsMaxPo = new DataSet();
            damaxpo.Fill(dsMaxPo, "MPLCUSPO");
            int maxID;
            maxID = Convert.ToInt32(dsMaxPo.Tables[0].Rows[0].ItemArray[0].ToString());
            txtPoNo.Text = (maxID + 1).ToString();
            pPono = new SqlParameter("@Pono", SqlDbType.Int);
            pPono.Value = maxID;
        
        }

       public void prefill()
        {
            // Get Cus ID and Cus Name for combo box
            daCustomer = new SqlDataAdapter("sp_GetCustomer", SQLcon);
            daCustomer.SelectCommand.CommandType = CommandType.StoredProcedure;
            dsCustomer = new DataSet();
            daCustomer.Fill(dsCustomer, "MPLCUSTOMER");


            cboCusName.DataSource = dsCustomer;
            cboCusName.DisplayMember = "MPLCUSTOMER.CUSNAME";

            cboCusID.DataSource = dsCustomer;
            cboCusID.DisplayMember = "MPLCUSTOMER.CUSNO";

            //Get Item ID and Item name for Combo box

            daItem = new SqlDataAdapter("sp_GetItems", SQLcon);
            daItem.SelectCommand.CommandType = CommandType.StoredProcedure;
            dsItem = new DataSet();
            daItem.Fill(dsItem, "MPLITEM");

            cboItemID.DataSource = dsItem;
            cboItemID.DisplayMember = "MPLITEM.ITMID";

            cboItemDescription.DataSource = dsItem;
            cboItemDescription.DisplayMember = "MPLITEM.ITMNAME";
        }

       private void cmdStAdd_Click(object sender, EventArgs e)
       {
           if (txtQty.Text == "")
           {
               MessageBox.Show("Please Enter the Quantity", "Customer Purchase Order");
               return;
           }
           else 
           {
           
               // add to table

               drCusPo = dtCusPo.NewRow();
               drCusPo[0] = cboItemID.Text;
               drCusPo[1] = cboItemDescription.Text;
               drCusPo[2] = txtQty.Text;

               //add to row

               dtCusPo.Rows.Add(drCusPo);
           }


       }

       private void cmdSave_Click(object sender, EventArgs e)
       {
           if (cboCusID.Text == "")
           {
               MessageBox.Show("Please Enter the Customer ", "Customer Purchade Order");
           }

           if (cboItemID.Text=="")
           {
               MessageBox.Show("Please Enter the Item ID ", "Customer Purchade Order");
           }
           if (txtQty.Text=="")
           {
               MessageBox.Show("Please Enter the QTY ", "Customer Purchade Order");
           }


           //Add to cutomer purchase order table
           //pPono = new SqlParameter("@CusPoNo", SqlDbType.VarChar, 50);          
           pPodate = new SqlParameter("@CusPoDate", SqlDbType.Date);             
           pCusId=new SqlParameter("@CusID",SqlDbType.Int);
           pUserID = new SqlParameter("@UserID", SqlDbType.Int);

           //Assigning values for parameters
           //pPono.Value = txtPoNo.Text;
           pPodate.Value = dtpCusPO.Text;
           pCusId.Value = cboCusID.Text;
           pUserID.Value = userID;

           // Add values to data base
           com = new SqlCommand("sp_AddCusPo", SQLcon);
           com.CommandType = CommandType.StoredProcedure;
           //com.Parameters.Add(pPono);
           com.Parameters.Add(pPodate);
           com.Parameters.Add(pCusId);
           com.Parameters.Add(pUserID);
           com.ExecuteScalar();



           int Row = 0;
           while (Row < dtCusPo.Rows.Count)
           {

               SqlParameter ppPono = new SqlParameter("@CusPoNo", SqlDbType.VarChar, 50);
               SqlParameter pItemID = new SqlParameter("@ItemID", SqlDbType.VarChar, 50);
               SqlParameter pItemName = new SqlParameter("@IteDescription", SqlDbType.VarChar, 250);
               SqlParameter pQty = new SqlParameter("@Qty", SqlDbType.Int);

               ppPono.Value = txtPoNo.Text;
               pItemID.Value = dtCusPo.Rows[Row].ItemArray[0].ToString();
               pItemName.Value = dtCusPo.Rows[Row].ItemArray[1];
               pQty.Value = dtCusPo.Rows[Row].ItemArray[2].ToString();

               com = new SqlCommand("sp_AddCusPoDetails", SQLcon);
               com.CommandType = CommandType.StoredProcedure;
               com.Parameters.Add(ppPono);
               com.Parameters.Add(pItemID);
               com.Parameters.Add(pItemName);
               com.Parameters.Add(pQty);
               com.ExecuteScalar();
               Row = Row + 1;

           }
           MessageBox.Show("Item Added");
           Maxwal();
           Clear();
           dtCusPo.Clear();
       }

       private void cmdExit_Click(object sender, EventArgs e)
       {
           if (MessageBox.Show("Are You Sure You Want to Exit", "Markspen Labels _ Customer PO Exit", MessageBoxButtons.YesNo) == DialogResult.No)
           {
               return;
           }
           this.Close();
          
       }

       private void cmdICusPOClear_Click(object sender, EventArgs e)
       {
           Clear();
           dsItem.Clear();
       }

       private void cmdItmMin_Click(object sender, EventArgs e)
       {
           if (dsItem.Tables[0].Rows.Count!=0)
           {
               dsItem.Tables[0].Rows[dgCusPo.CurrentCell.RowIndex].Delete();
           }
           
       }

       private void llblViewStock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
       {
           frmInventory FIN = new frmInventory();
           FIN.Show();
       }
    }
}
