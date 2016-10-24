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
    public partial class frmItem : Form
    {
        public frmItem()
        {
            InitializeComponent();
        }
        SqlDataAdapter da, da1,daSupplier;// Bring data
        DataSet ds,ds1,dsSupplier; // Holding data
        SqlCommand com;
        SqlParameter pItemId,pItemName, pICategory, pIUnits, pIWSPrice,pRETSPrice,pIQty, pIDescription, pIStatus, pIReOrderQTY,  pISupID, pITPL, pICATID, pIBIN, pIBarcode;
        SqlConnection SQLcon;


        private void frmItem_Load(object sender, EventArgs e)
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
            txtItemID.Focus();
            // Load data to data grid----------------------------------

            Prefill();
            cmdItemDelete.Enabled = false;
            CmdItemUpdate.Enabled = false;
            Clear();

           
        }
        public void Prefill()
        {
            da = new SqlDataAdapter("sp_GetItems", SQLcon);
            ds = new DataSet();
            da.Fill(ds, "MPLITEM");
            dgItem.DataSource = ds;
            dgItem.DataMember = "MPLITEM";

            da1 = new SqlDataAdapter("sp_GetICategory", SQLcon);
            ds1 = new DataSet();
            da1.Fill(ds1, "MPLITEMCATEGORY");
            cboItemCategory.DataSource = ds1;
            cboItemCategory.DisplayMember = "MPLITEMCATEGORY.ICATNAME";
            cboItemCategory.ValueMember = "MPLITEMCATEGORY.ICATID";

            daSupplier = new SqlDataAdapter("select * from MPLSUPPLIER order by SUPPLIERID asc", SQLcon);
            dsSupplier = new DataSet();
            daSupplier.Fill(dsSupplier, "MPLSUPPLIER");
            cboSuplier.DataSource = dsSupplier;
            cboSuplier.DisplayMember = "MPLSUPPLIER.SUPPLIERNAME";
            cboSuplier.ValueMember = "MPLSUPPLIER.SUPPLIERID";



        }
        void Clear()
        {
            txtItemID.Text = "";
            txtItemName.Text = "";
            cboItemCategory.Text = "";
            cboUnit.Text = "";
            txtWholeSalePrice.Text = "";
            txtRetailPrice.Text = "";
            txtReOrderQty.Text = "";
            txtItemDescription.Text = "";
            chkItemBlocked.Text = "";
            cboSuplier.Text = "";
            txtTPL.Text = "";
            txtBarcode.Text = "";
            txtBin.Text = "";
            txtItemQty.Text = "";
            chkItemBlocked.Checked = false;
            txtTPL.Text = "0";
            txtRetailPrice.Text = "0";
            txtWholeSalePrice.Text = "0";
            txtItemQty.Text = "0";
            txtReOrderQty.Text = "0";
            cmdItemAdd.Enabled = true;
            cmdItemDelete.Enabled = false;
            CmdItemUpdate.Enabled = false;
            txtItemID.BackColor = Color.White;
        }

        private void cmdItemClear_Click(object sender, EventArgs e)
        {
            Clear();
            txtItemID.Focus();
            cmdItemAdd.Enabled = true;
        }

        private void cmdItemExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Exit", "Markspen Labels _ Item Exit", MessageBoxButtons.YesNo) == DialogResult.No)
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
            da = new SqlDataAdapter("sp_SearchItem", SQLcon);
            da.SelectCommand.Parameters.Add(psearch);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            da.Fill(ds, "MPLITEM");
            dgItem.DataSource = ds;
            dgItem.DataMember = "MPLITEM";
        }

        private void cmdItemAdd_Click(object sender, EventArgs e)
        
        
      {
                if (string.IsNullOrEmpty(txtItemID.Text))
                {
                    MessageBox.Show(" Please, Enter Item ID ", "Markspen Labels");
                    return;
                }
                if (string.IsNullOrEmpty(txtItemName.Text))
                {
                    MessageBox.Show("Please, Enter Item Name ", "Markspen Labels");
                    return;
                }
                if (string.IsNullOrEmpty(cboItemCategory.Text))
                {
                    MessageBox.Show(" Please, Enter Item Category ", "Markspen Labels");
                    return;
                }
                if (string.IsNullOrEmpty(cboUnit.Text))
                {
                    MessageBox.Show(" Please, Enter Item Units ", "Markspen Labels");
                    return;
                }

                pItemId = new SqlParameter("@ItemId", SqlDbType.VarChar, 50);
                pItemName = new SqlParameter("@ItemName", SqlDbType.VarChar, 50);
                pICategory = new SqlParameter("@ICategory", SqlDbType.VarChar,50);
                pIUnits = new SqlParameter("@IUnits", SqlDbType.VarChar, 10);
                pRETSPrice = new SqlParameter("@RETSPrice", SqlDbType.Decimal);
                pIWSPrice = new SqlParameter("@IWSPrice", SqlDbType.Decimal);
                pIQty = new SqlParameter("@IQty", SqlDbType.Int);
                pIDescription = new SqlParameter("@IDescription", SqlDbType.VarChar, 200);
                pIStatus = new SqlParameter("@IStatus", SqlDbType.Int);
                pIReOrderQTY = new SqlParameter("@IReOrderQTY", SqlDbType.Int);
                pISupID = new SqlParameter("@ISupID", SqlDbType.Int);
                pITPL = new SqlParameter("@ITPL", SqlDbType.Int);
                pICATID = new SqlParameter("@ICATID", SqlDbType.VarChar, 50);
                pIBIN = new SqlParameter("@IBIN", SqlDbType.VarChar,50);
                pIBarcode = new SqlParameter("@IBarcode", SqlDbType.VarChar, 50);

                //Assign values for parameters---------------------------------------------

                pItemId.Value = txtItemID.Text;
                pItemName.Value = txtItemName.Text;
                pICategory.Value =cboItemCategory.Text;
                pIUnits.Value = (cboUnit.SelectedItem).ToString();
                pRETSPrice.Value = Convert.ToDecimal(txtRetailPrice.Text);
                pIWSPrice.Value = Convert.ToDecimal(txtWholeSalePrice.Text);
                pIQty.Value = Convert.ToInt16(txtItemQty.Text);
                pIDescription.Value = txtItemDescription.Text;

                     if (chkItemBlocked.Checked == true)
                {
                    pIStatus.Value = Convert.ToInt16("1");
                }
                else
                {
                    pIStatus.Value = Convert.ToInt16("0");
                }
                     if (txtReOrderQty.Text == "")
                     {
                         pIReOrderQTY.Value = Convert.ToInt16("0");
                     }
                     pIReOrderQTY.Value = Convert.ToInt16(txtReOrderQty.Text);

                     pISupID.Value = Convert.ToInt16(cboSuplier.SelectedValue);
                pITPL.Value = Convert.ToInt16(txtTPL.Text);
                pICATID.Value = Convert.ToInt16(cboItemCategory.SelectedValue);
                pIBIN.Value = txtBin.Text;
                pIBarcode.Value = txtItemID.Text;

                com = new SqlCommand("sp_AddItem", SQLcon);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(pItemId);
                com.Parameters.Add(pItemName);
                com.Parameters.Add(pICategory);
                com.Parameters.Add(pIUnits);
                com.Parameters.Add(pRETSPrice);
                com.Parameters.Add(pIWSPrice);
                com.Parameters.Add(pIQty);
                com.Parameters.Add(pIDescription);
                com.Parameters.Add(pIStatus);
                com.Parameters.Add(pIReOrderQTY);
                com.Parameters.Add(pISupID);
                com.Parameters.Add(pITPL);
                com.Parameters.Add(pICATID);
                com.Parameters.Add(pIBIN);
                com.Parameters.Add(pIBarcode);

                try
                {
                    com.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                //com.ExecuteScalar();
              
                MessageBox.Show("Item was Added","MARKSPEN LABELS - Item");

                dgItem.Refresh();
                Prefill();

                Clear();
                txtItemID.Focus();
            }

    
        private void cmdItemDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemID.Text))
            {
                MessageBox.Show("Select Item", "Markspen Labels _ Supplier Delete");
                return;
            }
            if (MessageBox.Show("Are You Sure You want to Delete ?", "Markspen Labels _ Supplier Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Delete Data
                pItemId = new SqlParameter("@ItemId", SqlDbType.VarChar,50);
                pItemId.Value = txtItemID.Text;
                com = new SqlCommand("sp_ItemDelete ", SQLcon);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(pItemId);
                com.ExecuteScalar();

                MessageBox.Show("Item was  Deleted ", "Markspen Labels _ Supplier Delete");
                Clear();
                dgItem.Refresh();
                Prefill();
                dgItem.Focus();
            }
        }

        private void dgItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clear();
            if (dgItem.CurrentCell.Value.ToString() != "")
            {

                txtItemID.Text = ds.Tables["MPLITEM"].Rows[dgItem.CurrentCell.RowIndex].ItemArray[0].ToString();
                txtItemName.Text = ds.Tables["MPLITEM"].Rows[dgItem.CurrentCell.RowIndex].ItemArray[1].ToString();
                cboItemCategory.SelectedText = ds.Tables["MPLITEM"].Rows[dgItem.CurrentCell.RowIndex].ItemArray[2].ToString();
                cboUnit.Text = ds.Tables["MPLITEM"].Rows[dgItem.CurrentCell.RowIndex].ItemArray[3].ToString();
                txtRetailPrice.Text = ds.Tables["MPLITEM"].Rows[dgItem.CurrentCell.RowIndex].ItemArray[4].ToString();
                txtWholeSalePrice.Text = ds.Tables["MPLITEM"].Rows[dgItem.CurrentCell.RowIndex].ItemArray[5].ToString();
                txtItemQty.Text = ds.Tables["MPLITEM"].Rows[dgItem.CurrentCell.RowIndex].ItemArray[6].ToString();
                txtItemDescription.Text = ds.Tables["MPLITEM"].Rows[dgItem.CurrentCell.RowIndex].ItemArray[7].ToString();


                // get value from check box
                string strcheck = ds.Tables["MPLITEM"].Rows[dgItem.CurrentCell.RowIndex].ItemArray[8].ToString();

                if (strcheck == "1")
                {

                    chkItemBlocked.Checked = true;
                    txtItemID.BackColor=Color.Red;
                }
                else
                {
                    chkItemBlocked.Checked = false;
                    txtItemID.BackColor = Color.Empty;

                }
                txtReOrderQty.Text = ds.Tables["MPLITEM"].Rows[dgItem.CurrentCell.RowIndex].ItemArray[9].ToString();

                
                txtTPL.Text = ds.Tables["MPLITEM"].Rows[dgItem.CurrentCell.RowIndex].ItemArray[11].ToString();

                
                txtBin.Text = ds.Tables["MPLITEM"].Rows[dgItem.CurrentCell.RowIndex].ItemArray[13].ToString();


             SqlParameter p = new SqlParameter("@id", SqlDbType.Int);
             p.Value = Convert.ToInt32(ds.Tables["MPLITEM"].Rows[dgItem.CurrentCell.RowIndex].ItemArray[10].ToString());

                       

            SqlDataAdapter  dasup = new SqlDataAdapter("Select * from MPLSUPPLIER WHERE SUPPLIERID=@id", SQLcon);
            dasup.SelectCommand.Parameters.Add(p);
           

            DataSet dssup = new DataSet();

            dasup.Fill(dssup, "MPLSUPPLIER");

          string suppname = dssup.Tables[0].Rows[0].ItemArray[3].ToString();

     
           cboSuplier.SelectedText = suppname;

           cmdItemAdd.Enabled = false;
           cmdItemDelete.Enabled = true;
           CmdItemUpdate.Enabled = true;


            }
        }

        private void CmdItemUpdate_Click(object sender, EventArgs e)
        {

            pItemId = new SqlParameter("@ItemId", SqlDbType.VarChar, 50);
            pItemName = new SqlParameter("@ItemName", SqlDbType.VarChar, 50);
            pICategory = new SqlParameter("@ICategory", SqlDbType.VarChar, 50);
            pIUnits = new SqlParameter("@IUnits", SqlDbType.VarChar, 10);
            pRETSPrice = new SqlParameter("@RETSPrice", SqlDbType.Decimal);
            pIWSPrice = new SqlParameter("@IWSPrice", SqlDbType.Decimal);
            pIQty = new SqlParameter("@IQty", SqlDbType.Int);
            pIDescription = new SqlParameter("@IDescription", SqlDbType.VarChar, 200);
            pIStatus = new SqlParameter("@IStatus", SqlDbType.Int);
            pIReOrderQTY = new SqlParameter("@IReOrderQTY", SqlDbType.Int);

            pISupID = new SqlParameter("@ISupID", SqlDbType.Int);

            pITPL = new SqlParameter("@ITPL", SqlDbType.Int);
            pICATID = new SqlParameter("@ICATID", SqlDbType.VarChar, 50);
            pIBIN = new SqlParameter("@IBIN", SqlDbType.VarChar, 50);
            pIBarcode = new SqlParameter("@IBarcode", SqlDbType.VarChar, 50);

            //Assign values for parameters---------------------------------------------

            pItemId.Value = txtItemID.Text;
            pItemName.Value = txtItemName.Text;
            pICategory.Value = cboItemCategory.Text;
            pIUnits.Value = (cboUnit.SelectedItem).ToString();
            pRETSPrice.Value = Convert.ToDecimal(txtRetailPrice.Text);
            pIWSPrice.Value = Convert.ToDecimal(txtWholeSalePrice.Text);
            pIQty.Value = Convert.ToInt16(txtItemQty.Text);
            pIDescription.Value = txtItemDescription.Text;

            if (chkItemBlocked.Checked == true)
            {
                pIStatus.Value = Convert.ToInt16("1");
            }
            else
            {
                pIStatus.Value = Convert.ToInt16("0");
            }
            if (txtReOrderQty.Text == "")
            {
                pIReOrderQTY.Value = Convert.ToInt16("0");
            }
            pIReOrderQTY.Value = Convert.ToInt16(txtReOrderQty.Text);

           ///changebyme
    
            try
            {
                v = cboSuplier.SelectedValue.ToString();
            }
            catch (Exception)
            {
                v = "10";
            }

            if (v == "10")
            {

                SqlParameter getsup_p = new SqlParameter("@Supp",SqlDbType.VarChar,50);
                getsup_p.Value = cboSuplier.Text;

                SqlDataAdapter da_getsup = new SqlDataAdapter("SELECT * FROM MPLSUPPLIER WHERE SUPPLIERNAME=@supp",SQLcon);

                da_getsup.SelectCommand.Parameters.Add(getsup_p);


                DataSet ds_getsup = new DataSet();

                da_getsup.Fill(ds_getsup, "MPLSUPPLIER");


                pISupID.Value = Convert.ToInt32(ds_getsup.Tables[0].Rows[0].ItemArray[0].ToString());
            }
            else
            {
                pISupID.Value = Convert.ToInt32(cboSuplier.SelectedValue);
            }

            ///changeme end

            pITPL.Value = Convert.ToInt16(txtTPL.Text);
            pICATID.Value = Convert.ToInt16(cboItemCategory.SelectedValue);
            pIBIN.Value = txtBin.Text;
            pIBarcode.Value = txtItemID.Text;

            com = new SqlCommand("sp_UpdateItem", SQLcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(pItemId);
            com.Parameters.Add(pItemName);
            com.Parameters.Add(pICategory);
            com.Parameters.Add(pIUnits);
            com.Parameters.Add(pRETSPrice);
            com.Parameters.Add(pIWSPrice);
            com.Parameters.Add(pIQty);
            com.Parameters.Add(pIDescription);
            com.Parameters.Add(pIStatus);
            com.Parameters.Add(pIReOrderQTY);
            com.Parameters.Add(pISupID);
            com.Parameters.Add(pITPL);
            com.Parameters.Add(pICATID);
            com.Parameters.Add(pIBIN);
            com.Parameters.Add(pIBarcode);
           

            com.ExecuteScalar();

            MessageBox.Show("Item was Updated", "MARKSPEN LABELS - Item");

            dgItem.Refresh();
            Prefill();

            Clear();
            txtItemID.Focus();
        }
        string v;
       

    

       
            
        

    }
}
