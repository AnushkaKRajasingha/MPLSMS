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
    public partial class frmInvoiceReport : Form
    {
        public frmInvoiceReport()
        {
            InitializeComponent();
        }
        SqlDataAdapter damaxid, da_ID, da_I, da_CUS;
        DataSet dsmaxid, ds_ID, ds_I, ds_CUS;
        SqlConnection SQLcon;
        SqlParameter P_maxid, P_Invoice_ID, P_Cus_ID;

        private void frmInvoiceReport_Load(object sender, EventArgs e)
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


            //get max id


            damaxid = new SqlDataAdapter("SELECT MAX(INVOICENO) FROM MPLINVOICE", SQLcon);
            dsmaxid = new DataSet();

            damaxid.Fill(dsmaxid, "MPLINVOICE");

            int maxid = Convert.ToInt32(dsmaxid.Tables[0].Rows[0].ItemArray[0]);


            //get MPLINVOICEDETAILS

            P_Invoice_ID = new SqlParameter("@Invoice_ID", SqlDbType.Int);
            P_Invoice_ID.Value = maxid;

            da_ID = new SqlDataAdapter("SELECT *  FROM MPLINVOICEDETAILS WHERE INVOICENO=@Invoice_ID", SQLcon);
            da_ID.SelectCommand.Parameters.Add(P_Invoice_ID);

            ds_ID = new DataSet();
            da_ID.Fill(ds_ID, "MPLINVOICEDETAILS");
            //


            InvoicePrint objRpt = new InvoicePrint();
            objRpt.SetDataSource(ds_ID.Tables[0]);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();

            //get MPLINVOICE

            P_maxid = new SqlParameter("@Invoice_ID", SqlDbType.Int);
            P_maxid.Value = maxid;

            da_I = new SqlDataAdapter("SELECT *  FROM MPLINVOICE WHERE INVOICENO=@Invoice_ID", SQLcon);
            da_I.SelectCommand.Parameters.Add(P_maxid);

            ds_I = new DataSet();
            da_I.Fill(ds_I, "MPLINVOICEDETAILS");


            String PONO, InvoiceNO, IN_Date, Cus_ID;


            InvoiceNO = ds_I.Tables[0].Rows[0].ItemArray[0].ToString();
            IN_Date = ds_I.Tables[0].Rows[0].ItemArray[1].ToString();
            Cus_ID = ds_I.Tables[0].Rows[0].ItemArray[2].ToString();
            PONO = ds_I.Tables[0].Rows[0].ItemArray[3].ToString();


            //

            //get Customer

            P_Cus_ID = new SqlParameter("@Cus_ID", SqlDbType.Int);
            P_Cus_ID.Value = Cus_ID;

            da_CUS = new SqlDataAdapter("SELECT *  FROM MPLCUSTOMER WHERE CUSNO=@Cus_ID", SQLcon);
            da_CUS.SelectCommand.Parameters.Add(P_Cus_ID);

            ds_CUS = new DataSet();
            da_CUS.Fill(ds_CUS, "MPLCUSTOMER");


            String customer, address, tel, vatNo;

            customer = ds_CUS.Tables[0].Rows[0].ItemArray[3].ToString();
            address = ds_CUS.Tables[0].Rows[0].ItemArray[4].ToString();
            vatNo = ds_CUS.Tables[0].Rows[0].ItemArray[5].ToString();
            tel = ds_CUS.Tables[0].Rows[0].ItemArray[11].ToString();

            //add CR TextBox


            TextObject TO_PoNO = (TextObject)objRpt.ReportDefinition.Sections["Section1"].ReportObjects["crtxtPONo"];
            TO_PoNO.Text = PONO;

            TextObject TO_InvoiceNo = (TextObject)objRpt.ReportDefinition.Sections["Section1"].ReportObjects["crtxtInvNo"];
            TO_InvoiceNo.Text = InvoiceNO;

            TextObject To_Barcode = (TextObject)objRpt.ReportDefinition.Sections["Section1"].ReportObjects["crtxtInvNo"];
            TO_InvoiceNo.Text = InvoiceNO;


            TextObject TO_PODate = (TextObject)objRpt.ReportDefinition.Sections["Section1"].ReportObjects["crtxtInvDate"];
            TO_PODate.Text = IN_Date;

            TextObject TO_Customer = (TextObject)objRpt.ReportDefinition.Sections["Section1"].ReportObjects["cttxtCustomer"];
            TO_Customer.Text = customer;

            TextObject TO_Address = (TextObject)objRpt.ReportDefinition.Sections["Section1"].ReportObjects["crtxtAddress"];
            TO_Address.Text = address;

            TextObject TO_Tell = (TextObject)objRpt.ReportDefinition.Sections["Section1"].ReportObjects["crtxtTell"];
            TO_Tell.Text = tel;

            TextObject TO_VATNo = (TextObject)objRpt.ReportDefinition.Sections["Section1"].ReportObjects["crtxtVATNo"];
            TO_VATNo.Text = vatNo;
        }

        private void InvoicePrint1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
