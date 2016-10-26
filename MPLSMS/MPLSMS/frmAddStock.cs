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
    public partial class frmAddStock : Form
    {
        public frmAddStock()
        {
            InitializeComponent();
        }
        SqlDataAdapter daSupplier, daItem, damaxpo;
        DataSet dsSupplier, dsItem, dsMaxPo, dsGrid;
        SqlCommand com;
        SqlConnection SQLcon;
        SqlParameter pStockDate,pSupCode, pSupAddress,pSupName,pStockno,pItmeId,pItemName,pUnits,pBinNo,pQty;
        DataTable dtGrid;
        DataRow drGrid;
        private int StockNo { get; set; }
        public String barcode { get; set; }
        private void frmAddStock_Load(object sender, EventArgs e)
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
            MaxVal();
            clear();
            cmdStockPrint.Enabled = false;

            dtGrid = new DataTable("DataGride");
            dtGrid.Columns.Add("Item Code");
            dtGrid.Columns.Add("Item Description");
            dtGrid.Columns.Add("Unit");
            dtGrid.Columns.Add("BIN ");
            dtGrid.Columns.Add("Qty");
            dsGrid = new DataSet();
            dsGrid.Tables.Add(dtGrid);
            dataGridView1.DataSource = dsGrid;
            dataGridView1.DataMember = "DataGride";
            
        }
        public void Prefill()
        {
            daSupplier = new SqlDataAdapter("sp_GetSupplier", SQLcon);
            dsSupplier = new DataSet();
            daSupplier.Fill(dsSupplier, "MPLSUPPLIER");
            cboSupId.DataSource = dsSupplier;
            cboSupId.DisplayMember = "MPLSUPPLIER.SUPPLIERID";
            cboSupName.DataSource=dsSupplier;
            cboSupName.DisplayMember = "MPLSUPPLIER.SUPPLIERNAME";
            cboSupAdd.DataSource = dsSupplier;
            cboSupAdd.DisplayMember = "MPLSUPPLIER.SUPADDRESS";
            cboSupAdd.ValueMember = "MPLSUPPLIER.SUPADDRESS";
        }
        public void clear()
        {
            cboSupId.Text = "";
            cboSupName.Text = "";
            txtBarcode.Text = "";
            txtTotalQty.Text = "";
            txtItemID.Text = "";
            txtItemDes.Text = "";
            txtUnit.Text = "";
            txtBin.Text = "";
            txtQty.Text="";
            
        }
        public void clear2()
        {
            txtBarcode.Text = "";
            txtTotalQty.Text = "";
            //txtItemID.Text = "";
            txtItemDes.Text = "";
            txtUnit.Text = "";
            txtBin.Text = "";
            txtQty.Text = "";
        
        }
        public void MaxVal()
        {
            damaxpo = new SqlDataAdapter("sp_GetMaxAddStockNo", SQLcon);
            dsMaxPo = new DataSet();
            damaxpo.Fill(dsMaxPo, "MPLINVOICE");

            if (dsMaxPo.Tables[0].Rows[0].ItemArray[0].ToString() == "")
            {
                txtStockNo.Text = "1000";
            }
            else
            {

                int maxID;
                maxID = Convert.ToInt32(dsMaxPo.Tables[0].Rows[0].ItemArray[0].ToString());
                txtStockNo.Text = (maxID + 1).ToString();
                //pInvNo = new SqlParameter("@InvNo", SqlDbType.Int);
                //pInvNo.Value = maxID;

            }
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            int a=e.KeyChar;
            if(a==13)
            {
            SqlParameter psearch;
            psearch = new SqlParameter("@Itmsearch", SqlDbType.VarChar, 50);
            psearch.Value = txtBarcode.Text;
            daItem = new SqlDataAdapter("sp_SearchItem", SQLcon);
            daItem.SelectCommand.Parameters.Add(psearch);
            daItem.SelectCommand.CommandType = CommandType.StoredProcedure;
            dsItem = new DataSet();
            daItem.Fill(dsItem, "MPLITEM");
            if (dsItem.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Invalead Barcode");
                return;
            }
                cboSupId.Text=dsItem.Tables[0].Rows[0].ItemArray[10].ToString();

            txtItemID.Text = dsItem.Tables[0].Rows[0].ItemArray[0].ToString();
            txtItemDes.Text = dsItem.Tables[0].Rows[0].ItemArray[1].ToString();
            txtUnit.Text=dsItem.Tables[0].Rows[0].ItemArray[3].ToString();
            txtBin.Text=dsItem.Tables[0].Rows[0].ItemArray[13].ToString();
            txtTotalQty.Text=dsItem.Tables[0].Rows[0].ItemArray[6].ToString();
            }

           
        }

        private void cmdStAdd_Click(object sender, EventArgs e)
        {
            if (txtQty.Text == "")
            {
                MessageBox.Show("Please Enter Quantity","MPL ADD TO STORE");
                return;
            }
          
            else
            {
            drGrid = dtGrid.NewRow();
            drGrid[0] = txtItemID.Text;
            drGrid[1] = txtItemDes.Text;
            drGrid[2] = txtUnit.Text;
            drGrid[3] = txtBin.Text;
            drGrid[4] = txtQty.Text;

            // added to row
            dtGrid.Rows.Add(drGrid);

            //string userID = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            File.WriteAllText(@"D:\Data\GITHUB\MPLSMS\MPLSMS\txtdata\wordsbarcode.txt", txtItemID.Text);
            //clear2();
            txtBarcode.Focus();


         
            if (MessageBox.Show("Do You Want to Print Barcode", "Markspen Labels _ PRINT BARCODE", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                var _frmGRN = new frmBarCode();
                _frmGRN.barcode = Convert.ToString(txtItemID.Text);
                _frmGRN.ShowDialog();

                //MessageBox.Show(txtItemID.Text);
                //frmBarCode bk = new frmBarCode();
                //bk.Show();
            }
            return; 
                 
            }
            clear2();
        }

        private void cmdStMi_Click(object sender, EventArgs e)
        {
            if (dtGrid.Rows.Count!=0)
            {
                dtGrid.Rows[dataGridView1.CurrentCell.RowIndex].Delete();
            }

            
        }

        private void cmdStockSave_Click(object sender, EventArgs e)
        {
            // check ICat Name is Empty
            if (string.IsNullOrEmpty(cboSupId.Text))
            {
                MessageBox.Show(" Please, Enter Supplier ", "Markspen Labels");
                return;
            }
            if (string.IsNullOrEmpty(txtQty.Text))
            {
                MessageBox.Show(" Please, Enter Supplier ", "Markspen Labels");
                return;
            }

            // Save data to addstock table 
            pStockDate = new SqlParameter("@StockDate", SqlDbType.Date);
            pSupCode = new SqlParameter("@SupCode", SqlDbType.Int);
            pSupName = new SqlParameter("@SupplierName", SqlDbType.VarChar, 200);
            pSupAddress = new SqlParameter("@SupAddress", SqlDbType.VarChar, 250);

            //assigning values
            pStockDate.Value = dtpStock.Text;
           
            pSupCode.Value = Convert.ToInt16(cboSupId.Text);
            pSupName.Value = cboSupName.Text;
            pSupAddress.Value = cboSupAdd.SelectedValue.ToString();
         

            // added to table 
            com = new SqlCommand("sp_AddStock", SQLcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(pStockDate);
            com.Parameters.Add(pSupCode);
            com.Parameters.Add(pSupName);
            com.Parameters.Add(pSupAddress);
            com.ExecuteScalar();
            //MessageBox.Show("Stock was added to sadd");

            //Save Data to addStock Details table

            int Row1=0;
            while (Row1<dtGrid.Rows.Count)
            {
                pStockno = new SqlParameter("@Stockno", SqlDbType.Int);
                pItmeId = new SqlParameter("@ItmeId", SqlDbType.VarChar, 50);
                pItemName = new SqlParameter("@ItemName", SqlDbType.VarChar, 200);
                pUnits = new SqlParameter("@Units", SqlDbType.VarChar, 50);
                pBinNo = new SqlParameter("@BinNo", SqlDbType.VarChar, 50);
                pQty = new SqlParameter("@Qty", SqlDbType.Int);
            

                //Assigning value
                pStockno.Value =Convert.ToInt16 (txtStockNo.Text);
                pItmeId.Value = dtGrid.Rows[Row1].ItemArray[0].ToString();
                pItemName.Value = dtGrid.Rows[Row1].ItemArray[1];
                pUnits.Value = dtGrid.Rows[Row1].ItemArray[2];
                pBinNo.Value = dtGrid.Rows[Row1].ItemArray[3];
                pQty.Value = dtGrid.Rows[Row1].ItemArray[4].ToString();
                com = new SqlCommand("sp_AddStockDe", SQLcon);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(pStockno);
                com.Parameters.Add(pItmeId);
                com.Parameters.Add(pItemName);
                com.Parameters.Add(pUnits);
                com.Parameters.Add(pBinNo);
                com.Parameters.Add(pQty);
                com.ExecuteScalar();
                Row1 = Row1 + 1;
                //MessageBox.Show("Stock was added to saddDetails");
                dtGrid.Clear();


            }




            //UPDATE STOCK 
            int Row = 0;

            while(Row<dtGrid.Rows.Count)
            {
  
            SqlParameter qty = new SqlParameter("@IQty", SqlDbType.Int);
            SqlParameter itmCode = new SqlParameter("@ItemId", SqlDbType.VarChar,50);


            qty.Value = Convert.ToInt32(dtGrid.Rows[Row].ItemArray[4]);
            itmCode.Value = dtGrid.Rows[Row].ItemArray[0].ToString();

            com = new SqlCommand("sp_UpdateAddItem", SQLcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(qty);
            com.Parameters.Add(itmCode);
            com.ExecuteScalar();

            Row = Row + 1;

            }


            MessageBox.Show("Stock was Updated");
            cmdStockPrint.Enabled = true;
            clear();
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

            txtItemID.DataBindings.Clear();
            txtItemID.DataBindings.Add("TEXT", dsItem, "MPLITEM.ITMID");

            txtItemDes.DataBindings.Clear();
            txtItemDes.DataBindings.Add("TEXT", dsItem, "MPLITEM.ITMNAME");

            txtUnit.DataBindings.Clear();
            txtUnit.DataBindings.Add("TEXT", dsItem, "MPLITEM.UNITS");

            txtTotalQty.DataBindings.Clear();
            txtTotalQty.DataBindings.Add("TEXT", dsItem, "MPLITEM.ITMQTY");

            txtBin.DataBindings.Clear();
            txtBin.DataBindings.Add("TEXT", dsItem, "MPLITEM.BINNO");

         
        }

        private void cmdStockPrint_Click(object sender, EventArgs e)
        {
            var _frmGRN = new frmGRN();
            _frmGRN.StokNo = Convert.ToInt32(txtStockNo.Text);
            _frmGRN.ShowDialog();
        }

        private void cmdStockExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Exit", "Markspen Labels _ Add Stock", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            this.Close();
          
        }

        private void cmdItemClear_Click(object sender, EventArgs e)
        {
            clear();
            cmdStockPrint.Enabled = false;
            dtGrid.Clear();
        }
    }
}
