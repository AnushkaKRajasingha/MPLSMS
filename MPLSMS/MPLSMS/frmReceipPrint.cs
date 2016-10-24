using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;


namespace MPLSMS
{
    public partial class frmReceipPrint : Form
    {
        public int invoiceNo { get; set; }
        public frmReceipPrint()
        {
            InitializeComponent();
        }
        SqlDataAdapter damaxid, da_ID, da_I, da_CUS, daGetcusID;
        DataSet dsmaxid, ds_ID, ds_I, ds_CUS, dsGetCusID;
        SqlConnection SQLcon;
        SqlParameter P_maxid, P_Pay_ID, P_Cus_ID, pINVID;
        private void frmReceipPrint_Load(object sender, EventArgs e)
        {

            PrintReceipt objRpt = new PrintReceipt();
            objRpt.SetParameterValue(0, invoiceNo);
            //  objRpt.SetDataSource(ds_ID.Tables[0]);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();


          //  //try
          //  //{
          //  //    Connection obj = new Connection();
          //  //    SQLcon = obj.con();
          //  //    SQLcon.Open();
          //  //}
          //  //catch (Exception ex)
          //  //{

          //  //    MessageBox.Show(ex.Message);
          //  //}
          //  ////Get Max ID
          //  ////MessageBox.Show("Connection is okay");

          //  //damaxid = new SqlDataAdapter("select MAX(PAYID) from MPLPAYMENTS ", SQLcon);
          //  //dsmaxid = new DataSet();

          //  //damaxid.Fill(dsmaxid, "MPLPAYMENTS");

          //  //int maxid = Convert.ToInt32(dsmaxid.Tables[0].Rows[0].ItemArray[0]);

          //  ////get Payment Details MPLPAYMENTS

          //  //P_Pay_ID = new SqlParameter("@P_Pay_ID", SqlDbType.Int);
          //  //P_Pay_ID.Value = maxid;


          //  //da_ID = new SqlDataAdapter("select* from MPLPAYMENTS where PAYID=@P_Pay_ID", SQLcon);
          //  //da_ID.SelectCommand.Parameters.Add(P_Pay_ID);

          //  //ds_ID = new DataSet();
          //  //da_ID.Fill(ds_ID, "MPLPAYMENTS");


          //  PrintReceipt objRpt = new PrintReceipt();
          ////  objRpt.SetDataSource(ds_ID.Tables[0]);
          //  crystalReportViewer1.ReportSource = objRpt;
          //  crystalReportViewer1.Refresh();

          //  //get MPLINVOICE

          //  //P_maxid = new SqlParameter("@P_Pay_ID", SqlDbType.Int);
          //  //P_maxid.Value = maxid;

          //  //da_I = new SqlDataAdapter("select* from MPLPAYMENTS where PAYID=@P_Pay_ID", SQLcon);
          //  //da_I.SelectCommand.Parameters.Add(P_maxid);

          //  //ds_I = new DataSet();
          //  //da_I.Fill(ds_I, "MPLPAYMENTS");

          //  //      ,[INVID]
          //  //,[PAYTYPE]
          //  //,[AMOUNT]
          //  //,[CHEQUENO]
          //  //,[CHEQUEDATE]
          //  //,[BANK]


          //  String INVID, PAYTYPE, AMOUNT, CHEQUENO, CHEQUEDATE, BANK;


          //  INVID = ds_I.Tables[0].Rows[0].ItemArray[2].ToString();
          //  PAYTYPE = ds_I.Tables[0].Rows[0].ItemArray[3].ToString();
          //  AMOUNT = ds_I.Tables[0].Rows[0].ItemArray[4].ToString();
          //  CHEQUENO = ds_I.Tables[0].Rows[0].ItemArray[5].ToString();
          //  CHEQUEDATE = ds_I.Tables[0].Rows[0].ItemArray[6].ToString();
          //  BANK = ds_I.Tables[0].Rows[0].ItemArray[7].ToString();

          //  //get CustomerID

          //  pINVID = new SqlParameter("@INVID", SqlDbType.Int);
          //  pINVID.Value = INVID;
          //  daGetcusID = new SqlDataAdapter("select CUSID from MPLINVOICE where INVOICENO=@INVID", SQLcon);
          //  da_CUS.SelectCommand.Parameters.Add(pINVID);
          //  dsGetCusID = new DataSet();
          //  da_CUS.Fill(dsGetCusID, "MPLINVOICE");
          //  int Cus_ID;
          //  Cus_ID = Convert.ToInt32(dsGetCusID.Tables[0].Rows[0].ItemArray[2]);

          //  // Get customer Name and Address.

          //  P_Cus_ID = new SqlParameter("@Cus_ID", SqlDbType.Int);
          //  P_Cus_ID.Value = Cus_ID;

          //  da_CUS = new SqlDataAdapter("SELECT *  FROM MPLCUSTOMER WHERE CUSNO=@Cus_ID", SQLcon);
          //  da_CUS.SelectCommand.Parameters.Add(P_Cus_ID);

          //  ds_CUS = new DataSet();
          //  da_CUS.Fill(ds_CUS, "MPLCUSTOMER");


          //  String customer, address;

          //  customer = ds_CUS.Tables[0].Rows[0].ItemArray[3].ToString();
          //  address = ds_CUS.Tables[0].Rows[0].ItemArray[4].ToString();


          //  //add CR TextBox

          //  TextObject TO_Customer = (TextObject)objRpt.ReportDefinition.Sections["Section2"].ReportObjects["rpttxtCusName"];
          //  TO_Customer.Text = customer;

          //  TextObject TO_Address = (TextObject)objRpt.ReportDefinition.Sections["Section2"].ReportObjects["rpttxtCusAdd"];
          //  TO_Address.Text = address;

          //  TextObject TO_InvoiceNo = (TextObject)objRpt.ReportDefinition.Sections["Section2"].ReportObjects["rpttxtInvNo"];
          //  TO_InvoiceNo.Text = INVID;

          //  TextObject To_AMOUNT = (TextObject)objRpt.ReportDefinition.Sections["Section2"].ReportObjects["rpttxtAmount"];
          //  To_AMOUNT.Text = AMOUNT;


          //  TextObject TO_PAYTYPE = (TextObject)objRpt.ReportDefinition.Sections["Section2"].ReportObjects["rpttxtPaymentMethode"];
          //  TO_PAYTYPE.Text = PAYTYPE;

          //  TextObject TO_CHEQUENO = (TextObject)objRpt.ReportDefinition.Sections["Section2"].ReportObjects["rpttxtChqno"];
          //  TO_CHEQUENO.Text = CHEQUENO;

          //  TextObject TO_CHEQUEDATE = (TextObject)objRpt.ReportDefinition.Sections["Section2"].ReportObjects["rpttxtChqDate"];
          //  TO_CHEQUEDATE.Text = CHEQUEDATE;

          //  TextObject TO_BANK = (TextObject)objRpt.ReportDefinition.Sections["Section2"].ReportObjects["rpttxtBank"];
          //  TO_BANK.Text = BANK;
        }
    }
}
