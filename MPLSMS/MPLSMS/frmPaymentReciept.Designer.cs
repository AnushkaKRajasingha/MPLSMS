namespace MPLSMS
{
    partial class frmPaymentReciept
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaymentReciept));
            this.rptPaymentSlip1 = new MPLSMS.rptPaymentSlip();
            this.rptPaymentSlip2 = new MPLSMS.rptPaymentSlip();
            this.crvPaymentReceipt = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pamentReciept1 = new MPLSMS.pamentReciept();
            this.SuspendLayout();
            // 
            // rptPaymentSlip1
            // 
            this.rptPaymentSlip1.InitReport += new System.EventHandler(this.rptPaymentSlip1_InitReport);
            // 
            // crvPaymentReceipt
            // 
            this.crvPaymentReceipt.ActiveViewIndex = 0;
            this.crvPaymentReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPaymentReceipt.CachedPageNumberPerDoc = 10;
            this.crvPaymentReceipt.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvPaymentReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPaymentReceipt.Location = new System.Drawing.Point(0, 0);
            this.crvPaymentReceipt.Name = "crvPaymentReceipt";
            this.crvPaymentReceipt.ReportSource = this.pamentReciept1;
            this.crvPaymentReceipt.Size = new System.Drawing.Size(520, 480);
            this.crvPaymentReceipt.TabIndex = 0;
            this.crvPaymentReceipt.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvPaymentReceipt.Load += new System.EventHandler(this.crystalReportViewer1_Load_1);
            // 
            // frmPaymentReciept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 480);
            this.Controls.Add(this.crvPaymentReceipt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPaymentReciept";
            this.Text = "Payment Receipt -MARKSPEN LABELS";
            this.Load += new System.EventHandler(this.frmPaymentReciept_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private rptPaymentSlip rptPaymentSlip1;
        private rptPaymentSlip rptPaymentSlip2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPaymentReceipt;
        private pamentReciept pamentReciept1;

    }
}