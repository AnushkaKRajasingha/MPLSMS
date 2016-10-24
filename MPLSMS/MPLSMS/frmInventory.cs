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
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }
        SqlConnection SQLcon;
        SqlDataAdapter da;
        DataSet ds;

        private void frmInventory_Load(object sender, EventArgs e)
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
            
            // Load data to data grid----------------------------------

            Prefill();
        }
        public void Prefill()
        {
            da = new SqlDataAdapter("sp_GetItems", SQLcon);
            ds = new DataSet();
            da.Fill(ds, "MPLITEM");
            dgInventory.DataSource = ds;
            dgInventory.DataMember = "MPLITEM";
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
            dgInventory.DataSource = ds;
            dgInventory.DataMember = "MPLITEM";
        }
    }
}
