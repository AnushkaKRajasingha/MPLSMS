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
    public partial class frmCUSPODetails : Form
    {
        public frmCUSPODetails()
        {
            InitializeComponent();
        }
        SqlConnection SQLcon;
        SqlDataAdapter da;
        DataSet ds;

        private void frmCUSPODetails_Load(object sender, EventArgs e)
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
            prefill();

        }
        public void prefill()
        {
            da = new SqlDataAdapter("sp_GetCusPODetails", SQLcon);
            ds = new DataSet();
            da.Fill(ds, "MPLCUSPODETAILS");
            dgCusPoDetails.DataSource = ds;
            dgCusPoDetails.DataMember = "MPLCUSPODETAILS";
        }

        private void txtPONumber_TextChanged(object sender, EventArgs e)
        {
            SqlParameter psearch;
            psearch = new SqlParameter("@PoNosearch", SqlDbType.VarChar, 50);
            psearch.Value = txtPONumber.Text;
            da = new SqlDataAdapter("sp_SearchCusPoNo", SQLcon);
            da.SelectCommand.Parameters.Add(psearch);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            da.Fill(ds, "MPLCUSPODETAILS");
            dgCusPoDetails.DataSource = ds;
            dgCusPoDetails.DataMember = "MPLCUSPODETAILS";
        }
    }
}
