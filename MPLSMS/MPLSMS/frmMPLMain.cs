using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MPLSMS
{
    public partial class frmMPLMain : Form
    {
        public frmMPLMain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmdStaffExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Exit", "Markspen Labels _ Main Exit", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void cmdStores_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void cmdAccounts_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void cmdSales_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void cmdUser_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmInventory IN = new frmInventory();
            IN.Show();
          
        }

        private void cmdSUPPO_Click(object sender, EventArgs e)
        {
            frmPO PO = new frmPO();
            PO.Show();
        }

        private void cmdCusPO_Click(object sender, EventArgs e)
        {
            frmCusPO CPO =new frmCusPO();
            CPO.Show();
        }

        private void cmdItem_Click(object sender, EventArgs e)
        {
            frmItem itm = new frmItem();
            itm.Show();
        }

        private void cmdSupp_Click(object sender, EventArgs e)
        {
            frmSupplier Sup = new frmSupplier();
            Sup.Show();
        }

        private void cmdCusPO_Click_1(object sender, EventArgs e)
        {

            frmCusPO CPO = new frmCusPO();
            CPO.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            frmCustomer CUS = new frmCustomer();
            CUS.Show();
        }

        private void cmdItemCategory_Click(object sender, EventArgs e)
        {
            frmICategory ICAT = new frmICategory();
            ICAT.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            frmItem It = new frmItem();
            It.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            frmItem Itm = new frmItem();
            Itm.Show();
        }

        private void cmdBarcode_Click(object sender, EventArgs e)
        {
            frmBarCode br = new frmBarCode();
            br.Show();
        }

        private void frmMPLMain_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToShortTimeString();

            // read user and display 
            String userName = File.ReadAllText(@"G:\BIT Project 2016\System\MPLSMS\txtdata\wordsName.txt");
            
            String userDes = File.ReadAllText(@"G:\BIT Project 2016\System\MPLSMS\txtdata\wordsUserDes.txt");
            lblUserName.Text = "Hi ! " + userName + " ,  Have a Nice Day ...  You are logged in as " + "''" + userDes + "''";


            String userRoll = File.ReadAllText(@"G:\BIT Project 2016\System\MPLSMS\txtdata\words.txt");

            if (userRoll == "MD")
            {
                cmdPurchasing.Enabled = false;
                cmdStores.Enabled = true;
                cmdAccounts.Enabled = true;
                cmdSales.Enabled = true;
                cmdUser.Enabled = true;
                tabPage1.Enabled = false;
                tabPage2.Enabled = true;
                tabPage3.Enabled = true;
                tabPage4.Enabled = true;
                tabPage5.Enabled = true;
            }
            else if (userRoll == "CL_Sales")
            {
                 cmdPurchasing.Enabled = false;
                cmdStores.Enabled = true;
                cmdAccounts.Enabled = false;
                cmdSales.Enabled = true;
                cmdUser.Enabled = false;
                tabPage1.Enabled = false;
                tabPage2.Enabled = true;
                tabPage3.Enabled = false;
                tabPage4.Enabled = true;
                tabPage5.Enabled = false;
            }
            else if (userRoll == "CL_Accounts")
            {
                cmdPurchasing.Enabled = true;
                cmdStores.Enabled = false;
                cmdAccounts.Enabled = true;
                cmdSales.Enabled = false;
                cmdUser.Enabled = false;
                tabPage1.Enabled = true;
                tabPage2.Enabled = false;
                tabPage3.Enabled = true;
                tabPage4.Enabled = false;
                tabPage5.Enabled = false;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            frmInvoice fi = new frmInvoice();
            fi.Show();
        }

        private void cmdItmCat_Click(object sender, EventArgs e)
        {
            frmICategory ICAT = new frmICategory();
            ICAT.Show();
        }

        private void cmdAddStock_Click(object sender, EventArgs e)
        {
            frmAddStock AS = new frmAddStock();
            AS.Show();
        }

        private void cmdUs_Click(object sender, EventArgs e)
        {
            frmStaff fs = new frmStaff();
            fs.Show();
        }

        private void cmdChangePwd_Click(object sender, EventArgs e)
        {
            frmChangePwd cp = new frmChangePwd();
            cp.Show();
        }

        private void cmdUserRole_Click(object sender, EventArgs e)
        {
            frmSRole Ur = new frmSRole();
            Ur.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCrediPayment fc = new frmCrediPayment();
            fc.Show();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            frmChequeStatus cs = new frmChequeStatus();
            cs.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmCashPayment cp = new frmCashPayment();
            cp.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            frmAproveCredit ac = new frmAproveCredit();
            ac.Show();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            lblTime.Text=DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void cmdCusDetailsRe_Click(object sender, EventArgs e)
        {
            frmCudDetailRe cdr = new frmCudDetailRe();
            cdr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSupDetailRe sdr = new frmSupDetailRe();
            sdr.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmStockDetailsRep sdr = new frmStockDetailsRep();
            sdr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void cmdDailySale_Click(object sender, EventArgs e)
        {
            frmDailySale ds = new frmDailySale();
            ds.ShowDialog();
        }

        private void cmdMonthlySales_Click(object sender, EventArgs e)
        {
            frmMonthlySales ms = new frmMonthlySales();
            ms.ShowDialog();
        }
        

       
     
    }
}
