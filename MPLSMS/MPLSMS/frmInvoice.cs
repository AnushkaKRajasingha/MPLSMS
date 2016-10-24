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
    public partial class frmInvoice : Form
    {
        public frmInvoice()
        {
            InitializeComponent();
        }

        SqlConnection SQLcon;
        SqlDataAdapter daCustomer, daPO, damaxpo, daItem;
        DataSet dsCustomer, dsPO1, dsMaxPo, dsItem;
        DataTable dtInvoice;
        DataRow drInvoice;
        SqlParameter pInvDate,pCusID,pPONo,pInvType,pSubTot,pDiscount,pVat,pNbt,pGTot,pInvStat,pUserID,pInvNo,pItemId,pItemDes,pUnitPrice,pQty,pAmount;
        double amount, total, DiscA, GTotal, disA;
        SqlCommand cmdInv;

        private void frmInvoice_Load(object sender, EventArgs e)
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

            txtSubTot.Text = "0";
            cboDecountP.Text = "0";
            cmdPrint.Enabled = false;
            cboCusNo.Focus();

            preFill();// fill data when the form load
            MaxVal();
            Clear();
            //Add Data to Data table

            dtInvoice = new DataTable("IvoiceDetails");
            dtInvoice.Columns.Add("Item ID");
            dtInvoice.Columns.Add("Item Description");
            dtInvoice.Columns.Add("Unit Price");
            dtInvoice.Columns.Add("Quantity");
            dtInvoice.Columns.Add("Amount");
           

            //create new table and Assign data table to data set
            dsItem = new DataSet();
            dsItem.Tables.Add(dtInvoice);
            dgInvoice.DataSource = dsItem;
            dgInvoice.DataMember = "IvoiceDetails";
            dgInvoice.Columns[1].Width = 250;// set column width


        }
        public void preFill()
        {
            //fill Cus No , Cus name
            daCustomer = new SqlDataAdapter("sp_GetCustomer", SQLcon);
            dsCustomer = new DataSet();
            daCustomer.Fill(dsCustomer, "MPLCUSTOMER");

            cboCusNo.DataSource = dsCustomer;
            cboCusNo.DisplayMember = "MPLCUSTOMER.CUSNO";

            cboCusName.DataSource = dsCustomer;
            cboCusName.DisplayMember = "MPLCUSTOMER.CUSNAME";

            //fill PO No, Podate

            daPO = new SqlDataAdapter("sp_GetCusPO", SQLcon);
            dsPO1 = new DataSet();
            daPO.Fill(dsPO1, "MPLCUSPO");

            cboPONo.DataSource = dsPO1;
            cboPONo.DisplayMember = "MPLCUSPO.CUSPONO";
            txtPODate.DataBindings.Clear();
            txtPODate.DataBindings.Add("TEXT", dsPO1, "MPLCUSPO.PODATE"); /// how to add PO date to textbox

        }
        public void Clear()
        {
            cboCusNo.Text = "";
            cboCusName.Text = "";
            cboDecountP.Text = "";
            cboInvoiceType.Text = "";
            cboPONo.Text = "";
            txtBarcode.Text = "";
            txtItemDes.Text = "";
            txtItemID.Text = "";
            txtPODate.Text = "";
            txtUnitPrice.Text = "";
            txtCurrentBalance.Text = "";
            txtSubTot.Text = "0";
            txtDisA.Text = "0";
            txtVATA.Text = "0";
            txtVATA.Text = "0";
            txtGT.Text = "0";

            txtOrderQty.Text = "0";
            txtLineAmount.Text = "0";
            
        }
        public void MaxVal()
        {
            damaxpo = new SqlDataAdapter("sp_GetMaxInvNo", SQLcon);
            dsMaxPo = new DataSet();
            damaxpo.Fill(dsMaxPo, "MPLINVOICE");

            if (dsMaxPo.Tables[0].Rows[0].ItemArray[0].ToString() == "")
            {
                txtInvoiceNo.Text = "1000";
            }
            else
            {

                int maxID;
                maxID = Convert.ToInt32(dsMaxPo.Tables[0].Rows[0].ItemArray[0].ToString());
                txtInvoiceNo.Text = (maxID + 1).ToString();
                //pInvNo = new SqlParameter("@InvNo", SqlDbType.Int);
                //pInvNo.Value = maxID;

            }
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
            txtItemID.DataBindings.Add("TEXT", dsItem,"MPLITEM.ITMID");

            txtItemDes.DataBindings.Clear();
            txtItemDes.DataBindings.Add("TEXT", dsItem, "MPLITEM.ITMNAME");

            txtUnitPrice.DataBindings.Clear();
            txtUnitPrice.DataBindings.Add("TEXT", dsItem, "MPLITEM.RETAILPRICE");
           
            txtCurrentBalance.DataBindings.Clear();
            txtCurrentBalance.DataBindings.Add("TEXT", dsItem, "MPLITEM.ITMQTY");
              
                 
        }

        private void txtOrderQty_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUnitPrice.Text) && !String.IsNullOrEmpty(txtOrderQty.Text))
            {
                txtLineAmount.Text = (float.Parse(txtOrderQty.Text) * float.Parse(txtUnitPrice.Text)).ToString();
            }
            
        }

        private void cmdStAdd_Click(object sender, EventArgs e)
        {
            if (txtOrderQty.Text == "")
            {
                MessageBox.Show("Please Enter the Quantity", "Invoice-MARKSPEN LABELS");
                return;
            }
            else
            {

                // add to table

                drInvoice = dtInvoice.NewRow();
                drInvoice[0] = txtItemID.Text;
                drInvoice[1] = txtItemDes.Text;
                drInvoice[2] = txtUnitPrice.Text;
                drInvoice[3] = txtOrderQty.Text;
                drInvoice[4] = txtLineAmount.Text;
                

                //add to row

                dtInvoice.Rows.Add(drInvoice);

//
                      double total;
                Double Subtot;

                var amount = 0.00 ;

                if (!String.IsNullOrEmpty(txtLineAmount.Text))
                {
                    amount = float.Parse(txtLineAmount.Text);
                }
                
                Subtot = Convert.ToDouble(txtSubTot.Text);
                total = (Subtot+amount);
              
                
                txtSubTot.Text = total.ToString();

//

                txtBarcode.Text = "";
                //txtCurrentBalance.Text = "";
                //txtItemID.Text = "";
                //txtItemDes.Text = "";
                //txtUnitPrice.Text = "";
                //txtOrderQty.Text = "";
                //txtLineAmount.Text = "";
                txtBarcode.Focus();
                txtItemDes.Text = "";
                txtItemID.Text = "";
                txtPODate.Text = "";
                txtUnitPrice.Text = "0";
                txtOrderQty.Text = "0";
                txtLineAmount.Text = "0";
                txtCurrentBalance.Text = "";



            }
        }

        private void cboDecountP_SelectedIndexChanged(object sender, EventArgs e)
        {
            double DiscP;
           
            DiscP = Convert.ToDouble(cboDecountP.SelectedItem);
            total = Convert.ToDouble(txtSubTot.Text);
            DiscA = ((total * DiscP) / 100);
            txtDisA.Text = DiscA.ToString();

            
        }
            
        
        private void cmdExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Exit", "Markspen Labels _ Invoce Exit", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            this.Close();
          
        }

        private void txtSubTot_TextChanged(object sender, EventArgs e)
        {
            // VAT calculation
            double VATP;
            double VATA;
            VATP = Convert.ToDouble(txtVATP.Text);
            total = Convert.ToDouble(txtSubTot.Text);
            VATA = ((total * VATP) / 100);
            txtVATA.Text = VATA.ToString();

            // NBT Calculation.

            double NBTP;
            double NBTA;
            NBTP = Convert.ToDouble(txtNbt.Text);
            total = Convert.ToDouble(txtSubTot.Text);
            NBTA = ((total * NBTP) / 100);
            txtNbtA.Text = NBTA.ToString();

            //Grand Total Calculation

            GTotal = (VATA + NBTA + total) - disA;
            txtGT.Text = GTotal.ToString();

            //  decimal places and round
            Double d = Convert.ToDouble(txtSubTot.Text);
            txtSubTot.Text = Math.Round(d, 2).ToString("F");
        }

        private void txtLineAmount_TextChanged(object sender, EventArgs e)
        {

            // trim values to two decimal places and round.

            Double d = Convert.ToDouble(txtLineAmount.Text);
            txtLineAmount.Text = Math.Round(d, 2).ToString("F");
      
        }
       
        private void txtDisA_TextChanged(object sender, EventArgs e)
        {
            //  decimal places and round
            Double disA = Convert.ToDouble(txtDisA.Text);

          // 

            if (txtDisA.Text!="0")
            {
                decimal tot = Convert.ToDecimal(txtGT.Text);
                decimal des = Convert.ToDecimal(txtDisA.Text);
                decimal gt = (tot - des);
                txtGT.Text = gt.ToString();
              
            }
  //          txtDisA.Text = Math.Round(disA, 2).ToString("F");
  //return;

        }

        private void txtVATA_TextChanged(object sender, EventArgs e)
        {
            //  decimal places and round
            Double d = Convert.ToDouble(txtVATA.Text);
            txtVATA.Text = Math.Round(d, 2).ToString("F");
        }

        private void txtNbtA_TextChanged(object sender, EventArgs e)
        {
            //  decimal places and round
            Double d = Convert.ToDouble(txtNbtA.Text);
            txtNbtA.Text = Math.Round(d, 2).ToString("F");
        }

        private void txtGT_TextChanged(object sender, EventArgs e)
        {
            //  decimal places and round
            Double d = Convert.ToDouble(txtGT.Text);
            txtGT.Text = Math.Round(d, 2).ToString("F");
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            frmInvoiceReport IN = new frmInvoiceReport();
            IN.Show();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            SqlTransaction _trans = null;
            try
            {
                Connection obj = new Connection();
                
                using (var _con = obj.con())
                {
                    if (_con.State != ConnectionState.Open)
                    {
                        _con.Open();
                    }
                    _trans = _con.BeginTransaction();
                   

                    // Add data to MPLINVOICE
                    pInvDate = new SqlParameter("@InvDate", SqlDbType.Date);
                    pInvDate.Value = dtpInvoiceDate.Text;

                    pCusID = new SqlParameter("@CusID", SqlDbType.Int);
                    pCusID.Value = Convert.ToInt32(cboCusNo.Text);

                    pPONo = new SqlParameter("@PONo", SqlDbType.Int);
                    pPONo.Value = Convert.ToInt32(cboPONo.Text);

                    pInvType = new SqlParameter("@InvType", SqlDbType.VarChar, 50);
                    pInvType.Value = cboInvoiceType.Text;

                    pSubTot = new SqlParameter("@SubTot", SqlDbType.Decimal);
                    pSubTot.Value = Convert.ToDecimal(txtSubTot.Text);

                    pDiscount = new SqlParameter("@Discount", SqlDbType.Decimal);
                    pDiscount.Value = Convert.ToDecimal(txtDisA.Text);

                    pVat = new SqlParameter("@Vat", SqlDbType.Decimal);
                    pVat.Value = Convert.ToDecimal(txtVATA.Text);

                    pNbt = new SqlParameter("@Nbt", SqlDbType.Decimal);
                    pNbt.Value = Convert.ToDecimal(txtNbtA.Text);

                    pGTot = new SqlParameter("@GTot", SqlDbType.Decimal);
                    pGTot.Value = Convert.ToDecimal(txtGT.Text);



                    pInvStat = new SqlParameter("@InvStat", SqlDbType.VarChar, 50);
                    pInvStat.Value = "Approved";

                    String StaffID = File.ReadAllText(@"G:\BIT Project 2016\System\MPLSMS\txtdata\wordsID.txt");
                    pUserID = new SqlParameter("@UserID", SqlDbType.Int);
                    pUserID.Value = StaffID;

                    // Add Invoice

                    cmdInv = _con.CreateCommand();
                    cmdInv.CommandText = "sp_AddInv";
                    cmdInv.CommandType = CommandType.StoredProcedure;
                    cmdInv.Transaction = _trans;
                    cmdInv.Parameters.Add(pInvDate);
                    cmdInv.Parameters.Add(pCusID);
                    cmdInv.Parameters.Add(pPONo);
                    cmdInv.Parameters.Add(pInvType);
                    cmdInv.Parameters.Add(pSubTot);
                    cmdInv.Parameters.Add(pDiscount);
                    cmdInv.Parameters.Add(pVat);
                    cmdInv.Parameters.Add(pNbt);
                    cmdInv.Parameters.Add(pGTot);
                    cmdInv.Parameters.Add(pInvStat);
                    cmdInv.Parameters.Add(pUserID);
                    
                    try
                    {
                        cmdInv.ExecuteNonQuery();
                        cmdInv.Parameters.Clear();
                    }
                    catch (Exception ex)
                    {
                        _trans.Rollback();
                        MessageBox.Show(ex.Message);
                        return;
                    }


                    //add data to Invoice Details table

                    int row = 0;
                    while (row < dtInvoice.Rows.Count)
                    {
                        pInvNo = new SqlParameter("@InvNo", SqlDbType.Int);
                        pItemId = new SqlParameter("@ItemId", SqlDbType.VarChar, 50);
                        pItemDes = new SqlParameter("@ItemDes", SqlDbType.VarChar, 100);
                        pUnitPrice = new SqlParameter("@UnitPrice", SqlDbType.Decimal);
                        pQty = new SqlParameter("@Qty", SqlDbType.Int);
                        pAmount = new SqlParameter("@Amount", SqlDbType.Decimal);

                        pInvNo.Value = Convert.ToInt32(txtInvoiceNo.Text);
                        pItemId.Value = dtInvoice.Rows[row].ItemArray[0].ToString();
                        pItemDes.Value = dtInvoice.Rows[row].ItemArray[1].ToString();
                        pUnitPrice.Value = Convert.ToDecimal(dtInvoice.Rows[row].ItemArray[2]);
                        pQty.Value = dtInvoice.Rows[row].ItemArray[3].ToString();
                        pAmount.Value = Convert.ToDecimal(dtInvoice.Rows[row].ItemArray[4]);

                        cmdInv = _con.CreateCommand();
                        cmdInv.CommandText = "sp_AddInvDe";
                        cmdInv.CommandType = CommandType.StoredProcedure;
                        cmdInv.Transaction = _trans;
                        cmdInv.Parameters.Add(pInvNo);
                        cmdInv.Parameters.Add(pItemId);
                        cmdInv.Parameters.Add(pItemDes);
                        cmdInv.Parameters.Add(pUnitPrice);
                        cmdInv.Parameters.Add(pQty);
                        cmdInv.Parameters.Add(pAmount);
                       
                        try
                        {
                            cmdInv.ExecuteNonQuery();
                            cmdInv.Parameters.Clear();
                        }
                        catch (Exception ex)
                        {
                            _trans.Rollback();
                            MessageBox.Show(ex.Message);
                            return;
                        }

                        row = row + 1;
                    }

                    _trans.Commit();

                    _con.Close();

                    MessageBox.Show("Item was Added", "MARKSPEN LABELS - Stock");
                    cmdPrint.Enabled = true;
                    Clear();
                    dtInvoice.Clear();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


          

            
        }

        private void lblviewPO_Click(object sender, EventArgs e)
        {
            frmCUSPODetails cpo = new frmCUSPODetails();
            cpo.Show();
        }

        private void txtOrderQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Double Price;
                Double qty;
                //double amount;

                Price = Convert.ToDouble(txtUnitPrice.Text);
                qty = Convert.ToDouble(txtOrderQty.Text);

                amount = (Price * qty);
                txtLineAmount.Text = amount.ToString();

                //Total = (Total + amount);
                //txtSubTot.Text = Total.ToString();

               
            }
        }

        private void cmdStMi_Click(object sender, EventArgs e)
        {
            if (dtInvoice.Rows.Count != 0)
            {
                dtInvoice.Rows[dgInvoice.CurrentCell.RowIndex].Delete();
            }
        }

        private void cmdItemClear_Click(object sender, EventArgs e)
        {
            Clear();
            dtInvoice.Clear();
            cmdPrint.Enabled = false;
            //txtSubTot.Text = "0";
            //txtDisA.Text = "0";
            //txtVATA.Text = "0";
            //txtVATA.Text = "0";
            //txtGT.Text = "0";

        }

       
    }
}
