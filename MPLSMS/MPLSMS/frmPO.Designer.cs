namespace MPLSMS
{
    partial class frmPO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPO));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmdStMi = new System.Windows.Forms.Button();
            this.cmdStAdd = new System.Windows.Forms.Button();
            this.llblViewStock = new System.Windows.Forms.LinkLabel();
            this.dtpStock = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dgPurchaseOrder = new System.Windows.Forms.DataGridView();
            this.cboItemDescription = new System.Windows.Forms.ComboBox();
            this.cboSupName = new System.Windows.Forms.ComboBox();
            this.cboItemID = new System.Windows.Forms.ComboBox();
            this.cboSupId = new System.Windows.Forms.ComboBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtBin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtSupPONO = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdIPOClear = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchaseOrder)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmdStMi);
            this.groupBox4.Controls.Add(this.cmdStAdd);
            this.groupBox4.Controls.Add(this.llblViewStock);
            this.groupBox4.Controls.Add(this.dtpStock);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.dgPurchaseOrder);
            this.groupBox4.Controls.Add(this.cboItemDescription);
            this.groupBox4.Controls.Add(this.cboSupName);
            this.groupBox4.Controls.Add(this.cboItemID);
            this.groupBox4.Controls.Add(this.cboSupId);
            this.groupBox4.Controls.Add(this.txtUnit);
            this.groupBox4.Controls.Add(this.txtQty);
            this.groupBox4.Controls.Add(this.txtBin);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtBalance);
            this.groupBox4.Controls.Add(this.txtBarcode);
            this.groupBox4.Controls.Add(this.txtSupPONO);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(693, 456);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // cmdStMi
            // 
            this.cmdStMi.Image = global::MPLSMS.Properties.Resources.Add2;
            this.cmdStMi.Location = new System.Drawing.Point(639, 196);
            this.cmdStMi.Name = "cmdStMi";
            this.cmdStMi.Size = new System.Drawing.Size(46, 40);
            this.cmdStMi.TabIndex = 9;
            this.cmdStMi.UseVisualStyleBackColor = true;
            this.cmdStMi.Click += new System.EventHandler(this.cmdStMi_Click);
            // 
            // cmdStAdd
            // 
            this.cmdStAdd.Image = global::MPLSMS.Properties.Resources.Add;
            this.cmdStAdd.Location = new System.Drawing.Point(639, 150);
            this.cmdStAdd.Name = "cmdStAdd";
            this.cmdStAdd.Size = new System.Drawing.Size(46, 40);
            this.cmdStAdd.TabIndex = 5;
            this.cmdStAdd.UseVisualStyleBackColor = true;
            this.cmdStAdd.Click += new System.EventHandler(this.cmdStAdd_Click);
            // 
            // llblViewStock
            // 
            this.llblViewStock.AutoSize = true;
            this.llblViewStock.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblViewStock.Location = new System.Drawing.Point(461, 70);
            this.llblViewStock.Name = "llblViewStock";
            this.llblViewStock.Size = new System.Drawing.Size(67, 15);
            this.llblViewStock.TabIndex = 32;
            this.llblViewStock.TabStop = true;
            this.llblViewStock.Text = "View Stock";
            // 
            // dtpStock
            // 
            this.dtpStock.CustomFormat = "";
            this.dtpStock.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStock.Location = new System.Drawing.Point(90, 19);
            this.dtpStock.Name = "dtpStock";
            this.dtpStock.Size = new System.Drawing.Size(97, 20);
            this.dtpStock.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "PO. Date";
            // 
            // dgPurchaseOrder
            // 
            this.dgPurchaseOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPurchaseOrder.Location = new System.Drawing.Point(12, 150);
            this.dgPurchaseOrder.Name = "dgPurchaseOrder";
            this.dgPurchaseOrder.Size = new System.Drawing.Size(623, 222);
            this.dgPurchaseOrder.TabIndex = 11;
            // 
            // cboItemDescription
            // 
            this.cboItemDescription.FormattingEnabled = true;
            this.cboItemDescription.Location = new System.Drawing.Point(137, 123);
            this.cboItemDescription.Name = "cboItemDescription";
            this.cboItemDescription.Size = new System.Drawing.Size(188, 21);
            this.cboItemDescription.TabIndex = 15;
            // 
            // cboSupName
            // 
            this.cboSupName.FormattingEnabled = true;
            this.cboSupName.Location = new System.Drawing.Point(167, 45);
            this.cboSupName.Name = "cboSupName";
            this.cboSupName.Size = new System.Drawing.Size(374, 21);
            this.cboSupName.TabIndex = 2;
            // 
            // cboItemID
            // 
            this.cboItemID.FormattingEnabled = true;
            this.cboItemID.Location = new System.Drawing.Point(13, 123);
            this.cboItemID.Name = "cboItemID";
            this.cboItemID.Size = new System.Drawing.Size(118, 21);
            this.cboItemID.TabIndex = 14;
            // 
            // cboSupId
            // 
            this.cboSupId.FormattingEnabled = true;
            this.cboSupId.Location = new System.Drawing.Point(90, 45);
            this.cboSupId.Name = "cboSupId";
            this.cboSupId.Size = new System.Drawing.Size(71, 21);
            this.cboSupId.TabIndex = 1;
           
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(331, 123);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(70, 20);
            this.txtUnit.TabIndex = 16;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(567, 123);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(70, 20);
            this.txtQty.TabIndex = 4;
            // 
            // txtBin
            // 
            this.txtBin.Location = new System.Drawing.Point(407, 123);
            this.txtBin.Name = "txtBin";
            this.txtBin.Size = new System.Drawing.Size(70, 20);
            this.txtBin.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(355, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Unit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(319, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "PO. No:";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(483, 123);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(78, 20);
            this.txtBalance.TabIndex = 18;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(90, 82);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(181, 20);
            this.txtBarcode.TabIndex = 3;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            // 
            // txtSupPONO
            // 
            this.txtSupPONO.Location = new System.Drawing.Point(380, 19);
            this.txtSupPONO.Name = "txtSupPONO";
            this.txtSupPONO.Size = new System.Drawing.Size(161, 20);
            this.txtSupPONO.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(498, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Balance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(588, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Qty.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(431, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "BIN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Item Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(377, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Stock level :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barcode";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 15);
            this.label16.TabIndex = 2;
            this.label16.Text = "Supplier";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmdIPOClear);
            this.groupBox6.Controls.Add(this.cmdPrint);
            this.groupBox6.Controls.Add(this.cmdExit);
            this.groupBox6.Controls.Add(this.cmdSave);
            this.groupBox6.Location = new System.Drawing.Point(28, 378);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox6.Size = new System.Drawing.Size(498, 69);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = ";";
            // 
            // cmdPrint
            // 
            this.cmdPrint.FlatAppearance.BorderSize = 0;
            this.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPrint.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPrint.Image = global::MPLSMS.Properties.Resources.print;
            this.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdPrint.Location = new System.Drawing.Point(134, 11);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(107, 52);
            this.cmdPrint.TabIndex = 11;
            this.cmdPrint.Text = "Print";
            this.cmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdPrint.UseVisualStyleBackColor = true;
            // 
            // cmdExit
            // 
            this.cmdExit.FlatAppearance.BorderSize = 0;
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Image = global::MPLSMS.Properties.Resources.exit;
            this.cmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExit.Location = new System.Drawing.Point(378, 11);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(116, 52);
            this.cmdExit.TabIndex = 12;
            this.cmdExit.Text = "Exit";
            this.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.FlatAppearance.BorderSize = 0;
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSave.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Image = global::MPLSMS.Properties.Resources.Save;
            this.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSave.Location = new System.Drawing.Point(5, 11);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(112, 52);
            this.cmdSave.TabIndex = 10;
            this.cmdSave.Text = "Save";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdIPOClear
            // 
            this.cmdIPOClear.FlatAppearance.BorderSize = 0;
            this.cmdIPOClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdIPOClear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIPOClear.Image = global::MPLSMS.Properties.Resources.clear;
            this.cmdIPOClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdIPOClear.Location = new System.Drawing.Point(250, 11);
            this.cmdIPOClear.Name = "cmdIPOClear";
            this.cmdIPOClear.Size = new System.Drawing.Size(107, 52);
            this.cmdIPOClear.TabIndex = 33;
            this.cmdIPOClear.Text = "Clear";
            this.cmdIPOClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdIPOClear.UseVisualStyleBackColor = true;
            this.cmdIPOClear.Click += new System.EventHandler(this.cmdIPOClear_Click);
            // 
            // frmPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 476);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PURCHASE ORDERS - MARKSPEN LABELS";
            this.Load += new System.EventHandler(this.frmPO_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchaseOrder)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.LinkLabel llblViewStock;
        private System.Windows.Forms.DateTimePicker dtpStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgPurchaseOrder;
        private System.Windows.Forms.ComboBox cboItemDescription;
        private System.Windows.Forms.ComboBox cboSupName;
        private System.Windows.Forms.ComboBox cboItemID;
        private System.Windows.Forms.ComboBox cboSupId;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtBin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtSupPONO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button cmdPrint;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdStMi;
        private System.Windows.Forms.Button cmdStAdd;
        private System.Windows.Forms.Button cmdIPOClear;
    }
}