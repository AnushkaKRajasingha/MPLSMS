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
    public partial class frmPO : Form
    {
        public frmPO()
        {
            InitializeComponent();
        }
        SqlDataAdapter daSupplier, daItem, damaxpo;
        DataSet dsSupplier, dsItem, dsMaxPo;
        SqlConnection SQLcon;
        SqlCommand com;
        SqlParameter pPono, pPODate,pSupID,pUserID;
        DataTable dtSupPo;
        DataRow drSupPo;
        int userID;
        private void frmPO_Load(object sender, EventArgs e)
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
            }
            cboSupId.Focus();
            preFill();

            //Add Data to Data table

            dtSupPo = new DataTable("SupPo");
            dtSupPo.Columns.Add("Item ID");
            dtSupPo.Columns.Add("Item Description");
            dtSupPo.Columns.Add("Unit");
            dtSupPo.Columns.Add("BIN No");
            dtSupPo.Columns.Add("Balance");
            dtSupPo.Columns.Add("Quantity");

            //create new table and Assign data table to data set
            dsItem = new DataSet();
            dsItem.Tables.Add(dtSupPo);
            dgPurchaseOrder.DataSource = dsItem;
            dgPurchaseOrder.DataMember = "SupPo";
            dgPurchaseOrder.Columns[1].Width = 250;// set column width


            String userID_File = File.ReadAllText(@"D:\BIT Project 2016\System\MPLSMS\txtdata\wordsID.txt");
            userID = Convert.ToInt32(userID_File);// user ID Assign to int variable called user ID
            MaxVal();
            Clear();



        }
         public void preFill()
        {
            daSupplier = new SqlDataAdapter("sp_GetSupplier", SQLcon);
            dsSupplier = new DataSet();
            daSupplier.Fill(dsSupplier, "MPLSUPPLIER");
            cboSupId.DataSource = dsSupplier;
            cboSupId.DisplayMember = "MPLSUPPLIER.SUPPLIERID";

            cboSupName.DataSource = dsSupplier;
            cboSupName.DisplayMember = "MPLSUPPLIER.SUPPLIERNAME";
           
        }
            public void Clear()
            {
                cboSupId.Text = "";
                cboSupName.Text = "";
                txtBarcode.Text = "";
                cboItemID.Text = "";
                cboItemDescription.Text = "";
                txtUnit.Text = "";
                txtBin.Text = "";
                txtBalance.Text = "";
                txtQty.Text = "";


          }
         public void MaxVal()
         {
             damaxpo = new SqlDataAdapter("sp_GetMaxSupPONO", SQLcon);
             dsMaxPo = new DataSet();
             damaxpo.Fill(dsMaxPo, "MPLSUPPO");

             if (dsMaxPo.Tables[0].Rows[0].ItemArray[0].ToString()=="")
             {
                 txtSupPONO.Text = "1000";
             }
             else
             {

                 int maxID;
                 maxID = Convert.ToInt32(dsMaxPo.Tables[0].Rows[0].ItemArray[0].ToString());
                 txtSupPONO.Text = (maxID + 1).ToString();
                 pPono = new SqlParameter("@Pono", SqlDbType.Int);// why ????
                 pPono.Value = maxID;
         
             }
           
         }

         private void cmdExit_Click(object sender, EventArgs e)
         {

             if (MessageBox.Show("Are You Sure You Want to Exit", "Markspen Labels _ PO Supplier Exit", MessageBoxButtons.YesNo) == DialogResult.No)
             {
                 return;
             }
             this.Close();
         }

         private void txtBarcode_TextChanged(object sender, EventArgs e)
         {
             SqlParameter psearch;
             psearch = new SqlParameter("@Itmsearch", SqlDbType.VarChar, 50);
             psearch.Value = txtBarcode.Text;
             daItem = new SqlDataAdapter("sp_SearchItem", SQLcon);
             daItem.SelectCommand.Parameters.Add(psearch);
             daItem.SelectCommand.CommandType = CommandType.StoredProcedure;
             dsItem = new DataSet();
             daItem.Fill(dsItem, "MPLITEM");

             cboItemID.DataSource = dsItem;
             cboItemID.DisplayMember = "MPLITEM.ITMID";

             cboItemDescription.DataSource = dsItem;
             cboItemDescription.DisplayMember = "MPLITEM.ITMNAME";

             txtUnit.DataBindings.Clear();
             txtUnit.DataBindings.Add("TEXT", dsItem, "MPLITEM.UNITS");
             txtBin.DataBindings.Clear();
             txtBin.DataBindings.Add("TEXT",dsItem,"MPLITEM.BINNO");
             txtBalance.DataBindings.Clear();
             txtBalance.DataBindings.Add("TEXT",dsItem, "MPLITEM.ITMQTY");
              
                 
             

             //dgItem.DataSource = ds;
             //dgItem.DataMember = "MPLITEM";
         }

         private void cmdStAdd_Click(object sender, EventArgs e)
         {
             if (txtQty.Text == "")
             {
                 MessageBox.Show("Please Enter the Quantity", "Supplier Purchase Order");
                 return;
             }
             else
             {

                 // add to table

                 drSupPo = dtSupPo.NewRow();
                 drSupPo[0] = cboItemID.Text;
                 drSupPo[1] = cboItemDescription.Text;
                 drSupPo[2] = txtUnit.Text;
                 drSupPo[3] = txtBin.Text;
                 drSupPo[4] = txtBalance.Text;
                 drSupPo[5] = txtQty.Text;

                 //add to row

                 dtSupPo.Rows.Add(drSupPo);

                 txtBarcode.Text = "";
                 cboItemID.Text = "";
                 cboItemDescription.Text = "";
                 txtUnit.Text = "";
                 txtBin.Text = "";
                 txtBalance.Text = "";
                 txtQty.Text = "";
                 txtBarcode.Focus();

             }
         }

         private void cmdStMi_Click(object sender, EventArgs e)
         {
            
             if (dsItem.Tables[0].Rows.Count != 0)
             {
                 dsItem.Tables[0].Rows[dgPurchaseOrder.CurrentCell.RowIndex].Delete();
             }
         }

         private void cmdSave_Click(object sender, EventArgs e)
         {
             if (cboSupId.Text == "")
             {
                 MessageBox.Show("Please Enter the Supplier ", "Supplier Purchade Order");
                 return;
             }

             if (dsItem.Tables[0].Rows.Count == 0)
             {
                 MessageBox.Show("Please Enter Details ", "Supplier Purchade Order");
                 return;
             }
           

             //Add to cutomer purchase order table
             //pPono = new SqlParameter("@CusPoNo", SqlDbType.VarChar, 50);          
             pPODate = new SqlParameter("@PODate", SqlDbType.Date);
             pSupID = new SqlParameter("@SupID", SqlDbType.Int);
             pUserID = new SqlParameter("@UserID", SqlDbType.Int);

             //Assigning values for parameters
             //pPono.Value = txtPoNo.Text;
             pPODate.Value = dtpStock.Text;
             pSupID.Value = cboSupId.Text;
             pUserID.Value = userID;

             // Add values to data base
             com = new SqlCommand("sp_AddSuPPo", SQLcon);
             com.CommandType = CommandType.StoredProcedure;
             //com.Parameters.Add(pPono);
             com.Parameters.Add(pPODate);
             com.Parameters.Add(pSupID);
             com.Parameters.Add(pUserID);
             com.ExecuteScalar();



             int Row = 0;
             while (Row < dtSupPo.Rows.Count)
             {

                 SqlParameter pPono = new SqlParameter("@SupPoNo", SqlDbType.Int);
                 SqlParameter pItemID = new SqlParameter("@ItemID", SqlDbType.VarChar, 50);
                 SqlParameter pItemName = new SqlParameter("@IteDescription", SqlDbType.VarChar, 250);
                 SqlParameter pUnit = new SqlParameter("@Unit", SqlDbType.VarChar, 50);
                 SqlParameter pBinNo = new SqlParameter("@BinNo", SqlDbType.VarChar, 50);
                 SqlParameter pBalance = new SqlParameter("@Balance", SqlDbType.Int);
                 SqlParameter pQty = new SqlParameter("@Qty", SqlDbType.Int);

                 pPono.Value = Convert.ToInt32(txtSupPONO.Text);
                 pItemID.Value = dtSupPo.Rows[Row].ItemArray[0].ToString();
                 pItemName.Value = dtSupPo.Rows[Row].ItemArray[1];
                 pUnit.Value = dtSupPo.Rows[Row].ItemArray[2];
                 pBinNo.Value = dtSupPo.Rows[Row].ItemArray[3];
                 pBalance.Value = dtSupPo.Rows[Row].ItemArray[4].ToString();
                 pQty.Value = dtSupPo.Rows[Row].ItemArray[5].ToString();

                 com = new SqlCommand("sp_AddSuPPoDetails", SQLcon);
                 com.CommandType = CommandType.StoredProcedure;
                 com.Parameters.Add(pPono);
                 com.Parameters.Add(pItemID);
                 com.Parameters.Add(pItemName);
                 com.Parameters.Add(pUnit);
                 com.Parameters.Add(pBinNo);
                 com.Parameters.Add(pBalance);
                 com.Parameters.Add(pQty);
                 com.ExecuteScalar();
                 Row = Row + 1;

             }
             MessageBox.Show("Item Added");
             Clear();
             dtSupPo.Clear();
             MaxVal();
         }

     

         private void cmdIPOClear_Click(object sender, EventArgs e)
         {
             Clear();
             dtSupPo.Clear();
         }

         private void cmdPrint_Click(object sender, EventArgs e)
         {
             var _frmPrintPO = new frmPrintPO();
             _frmPrintPO.POno = Convert.ToInt32(txtSupPONO.Text);
             _frmPrintPO.ShowDialog();
         }
        
       
    }
}
