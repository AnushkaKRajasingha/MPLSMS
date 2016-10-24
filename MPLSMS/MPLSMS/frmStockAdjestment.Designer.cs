namespace MPLSMS
{
    partial class frmStockAdjestment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockAdjestment));
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalQty = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtAdjNO = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtRefNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmdDeleteFromStok = new System.Windows.Forms.Button();
            this.cmdAddToStok = new System.Windows.Forms.Button();
            this.cmdStockAdPrint = new System.Windows.Forms.Button();
            this.cmdStockAdSave = new System.Windows.Forms.Button();
            this.dtpStock = new System.Windows.Forms.DateTimePicker();
            this.cmdStockAdExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cboItemDescription = new System.Windows.Forms.ComboBox();
            this.cboItemID = new System.Windows.Forms.ComboBox();
            this.cboEntryType = new System.Windows.Forms.ComboBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtBin = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(427, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Unit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(465, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Adj. No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ref. No";
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.Location = new System.Drawing.Point(518, 48);
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.Size = new System.Drawing.Size(78, 20);
            this.txtTotalQty.TabIndex = 9;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(296, 51);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(123, 20);
            this.txtBarcode.TabIndex = 9;
            // 
            // txtAdjNO
            // 
            this.txtAdjNO.Location = new System.Drawing.Point(518, 17);
            this.txtAdjNO.Name = "txtAdjNO";
            this.txtAdjNO.Size = new System.Drawing.Size(117, 20);
            this.txtAdjNO.TabIndex = 9;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(90, 77);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(329, 52);
            this.txtComment.TabIndex = 9;
            // 
            // txtRefNo
            // 
            this.txtRefNo.Location = new System.Drawing.Point(90, 17);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Size = new System.Drawing.Size(117, 20);
            this.txtRefNo.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(587, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Qty.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(504, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "BIN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Item Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(458, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Total Qty.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barcode";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Comment";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmdDeleteFromStok);
            this.groupBox4.Controls.Add(this.cmdAddToStok);
            this.groupBox4.Controls.Add(this.cmdStockAdPrint);
            this.groupBox4.Controls.Add(this.cmdStockAdSave);
            this.groupBox4.Controls.Add(this.dtpStock);
            this.groupBox4.Controls.Add(this.cmdStockAdExit);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.cboItemDescription);
            this.groupBox4.Controls.Add(this.cboItemID);
            this.groupBox4.Controls.Add(this.cboEntryType);
            this.groupBox4.Controls.Add(this.txtUnit);
            this.groupBox4.Controls.Add(this.txtQty);
            this.groupBox4.Controls.Add(this.txtBin);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtTotalQty);
            this.groupBox4.Controls.Add(this.txtBarcode);
            this.groupBox4.Controls.Add(this.txtAdjNO);
            this.groupBox4.Controls.Add(this.txtComment);
            this.groupBox4.Controls.Add(this.txtRefNo);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(12, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(685, 469);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // cmdDeleteFromStok
            // 
            this.cmdDeleteFromStok.FlatAppearance.BorderSize = 0;
            this.cmdDeleteFromStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDeleteFromStok.Image = global::MPLSMS.Properties.Resources.Add2;
            this.cmdDeleteFromStok.Location = new System.Drawing.Point(646, 230);
            this.cmdDeleteFromStok.Name = "cmdDeleteFromStok";
            this.cmdDeleteFromStok.Size = new System.Drawing.Size(30, 30);
            this.cmdDeleteFromStok.TabIndex = 29;
            this.cmdDeleteFromStok.UseVisualStyleBackColor = true;
            // 
            // cmdAddToStok
            // 
            this.cmdAddToStok.FlatAppearance.BorderSize = 0;
            this.cmdAddToStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAddToStok.Image = global::MPLSMS.Properties.Resources.Minus;
            this.cmdAddToStok.Location = new System.Drawing.Point(644, 177);
            this.cmdAddToStok.Name = "cmdAddToStok";
            this.cmdAddToStok.Size = new System.Drawing.Size(32, 30);
            this.cmdAddToStok.TabIndex = 29;
            this.cmdAddToStok.UseVisualStyleBackColor = true;
            // 
            // cmdStockAdPrint
            // 
            this.cmdStockAdPrint.FlatAppearance.BorderSize = 0;
            this.cmdStockAdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdStockAdPrint.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStockAdPrint.Image = global::MPLSMS.Properties.Resources.print;
            this.cmdStockAdPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdStockAdPrint.Location = new System.Drawing.Point(278, 413);
            this.cmdStockAdPrint.Name = "cmdStockAdPrint";
            this.cmdStockAdPrint.Size = new System.Drawing.Size(107, 52);
            this.cmdStockAdPrint.TabIndex = 21;
            this.cmdStockAdPrint.Text = "Print";
            this.cmdStockAdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdStockAdPrint.UseVisualStyleBackColor = true;
            // 
            // cmdStockAdSave
            // 
            this.cmdStockAdSave.FlatAppearance.BorderSize = 0;
            this.cmdStockAdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdStockAdSave.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStockAdSave.Image = global::MPLSMS.Properties.Resources.Save;
            this.cmdStockAdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdStockAdSave.Location = new System.Drawing.Point(149, 413);
            this.cmdStockAdSave.Name = "cmdStockAdSave";
            this.cmdStockAdSave.Size = new System.Drawing.Size(112, 52);
            this.cmdStockAdSave.TabIndex = 19;
            this.cmdStockAdSave.Text = "Save";
            this.cmdStockAdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdStockAdSave.UseVisualStyleBackColor = true;
            // 
            // dtpStock
            // 
            this.dtpStock.CustomFormat = "";
            this.dtpStock.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStock.Location = new System.Drawing.Point(322, 17);
            this.dtpStock.Name = "dtpStock";
            this.dtpStock.Size = new System.Drawing.Size(97, 20);
            this.dtpStock.TabIndex = 28;
            // 
            // cmdStockAdExit
            // 
            this.cmdStockAdExit.FlatAppearance.BorderSize = 0;
            this.cmdStockAdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdStockAdExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStockAdExit.Image = global::MPLSMS.Properties.Resources.exit;
            this.cmdStockAdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdStockAdExit.Location = new System.Drawing.Point(407, 413);
            this.cmdStockAdExit.Name = "cmdStockAdExit";
            this.cmdStockAdExit.Size = new System.Drawing.Size(116, 52);
            this.cmdStockAdExit.TabIndex = 18;
            this.cmdStockAdExit.Text = "Exit";
            this.cmdStockAdExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdStockAdExit.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Stock Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(628, 222);
            this.dataGridView1.TabIndex = 24;
            // 
            // cboItemDescription
            // 
            this.cboItemDescription.FormattingEnabled = true;
            this.cboItemDescription.Location = new System.Drawing.Point(90, 150);
            this.cboItemDescription.Name = "cboItemDescription";
            this.cboItemDescription.Size = new System.Drawing.Size(287, 21);
            this.cboItemDescription.Sorted = true;
            this.cboItemDescription.TabIndex = 8;
            // 
            // cboItemID
            // 
            this.cboItemID.FormattingEnabled = true;
            this.cboItemID.Location = new System.Drawing.Point(13, 150);
            this.cboItemID.Name = "cboItemID";
            this.cboItemID.Size = new System.Drawing.Size(71, 21);
            this.cboItemID.Sorted = true;
            this.cboItemID.TabIndex = 8;
            // 
            // cboEntryType
            // 
            this.cboEntryType.FormattingEnabled = true;
            this.cboEntryType.Location = new System.Drawing.Point(90, 50);
            this.cboEntryType.Name = "cboEntryType";
            this.cboEntryType.Size = new System.Drawing.Size(117, 21);
            this.cboEntryType.Sorted = true;
            this.cboEntryType.TabIndex = 8;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(407, 150);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(70, 20);
            this.txtUnit.TabIndex = 9;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(565, 150);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(70, 20);
            this.txtQty.TabIndex = 9;
            // 
            // txtBin
            // 
            this.txtBin.Location = new System.Drawing.Point(486, 150);
            this.txtBin.Name = "txtBin";
            this.txtBin.Size = new System.Drawing.Size(70, 20);
            this.txtBin.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 15);
            this.label16.TabIndex = 2;
            this.label16.Text = "Entry Type";
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(12, 400);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox6.Size = new System.Drawing.Size(623, 69);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = ";";
            // 
            // frmStockAdjestment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 486);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStockAdjestment";
            this.Text = "STOCK ADJESTMENT - MARKSPEN LABELS";
            this.Load += new System.EventHandler(this.frmStockAdjestment_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalQty;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtAdjNO;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtRefNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button cmdDeleteFromStok;
        private System.Windows.Forms.Button cmdAddToStok;
        private System.Windows.Forms.Button cmdStockAdPrint;
        private System.Windows.Forms.Button cmdStockAdSave;
        private System.Windows.Forms.DateTimePicker dtpStock;
        private System.Windows.Forms.Button cmdStockAdExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboItemDescription;
        private System.Windows.Forms.ComboBox cboItemID;
        private System.Windows.Forms.ComboBox cboEntryType;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtBin;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}