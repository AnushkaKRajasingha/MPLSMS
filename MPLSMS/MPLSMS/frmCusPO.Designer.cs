namespace MPLSMS
{
    partial class frmCusPO
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
            this.llblViewStock = new System.Windows.Forms.LinkLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmdItmMin = new System.Windows.Forms.Button();
            this.cmdItmAdd = new System.Windows.Forms.Button();
            this.dtpCusPO = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dgCusPo = new System.Windows.Forms.DataGridView();
            this.cboItemDescription = new System.Windows.Forms.ComboBox();
            this.cboCusName = new System.Windows.Forms.ComboBox();
            this.cboItemID = new System.Windows.Forms.ComboBox();
            this.cboCusID = new System.Windows.Forms.ComboBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPoNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmdICusPOClear = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCusPo)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
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
            this.llblViewStock.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblViewStock_LinkClicked);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmdItmMin);
            this.groupBox4.Controls.Add(this.cmdItmAdd);
            this.groupBox4.Controls.Add(this.llblViewStock);
            this.groupBox4.Controls.Add(this.dtpCusPO);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.dgCusPo);
            this.groupBox4.Controls.Add(this.cboItemDescription);
            this.groupBox4.Controls.Add(this.cboCusName);
            this.groupBox4.Controls.Add(this.cboItemID);
            this.groupBox4.Controls.Add(this.cboCusID);
            this.groupBox4.Controls.Add(this.txtQty);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtPoNo);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(12, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(553, 456);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // cmdItmMin
            // 
            this.cmdItmMin.Image = global::MPLSMS.Properties.Resources.Add2;
            this.cmdItmMin.Location = new System.Drawing.Point(495, 196);
            this.cmdItmMin.Name = "cmdItmMin";
            this.cmdItmMin.Size = new System.Drawing.Size(46, 40);
            this.cmdItmMin.TabIndex = 34;
            this.cmdItmMin.UseVisualStyleBackColor = true;
            this.cmdItmMin.Click += new System.EventHandler(this.cmdItmMin_Click);
            // 
            // cmdItmAdd
            // 
            this.cmdItmAdd.Image = global::MPLSMS.Properties.Resources.Add;
            this.cmdItmAdd.Location = new System.Drawing.Point(495, 150);
            this.cmdItmAdd.Name = "cmdItmAdd";
            this.cmdItmAdd.Size = new System.Drawing.Size(46, 40);
            this.cmdItmAdd.TabIndex = 33;
            this.cmdItmAdd.UseVisualStyleBackColor = true;
            this.cmdItmAdd.Click += new System.EventHandler(this.cmdStAdd_Click);
            // 
            // dtpCusPO
            // 
            this.dtpCusPO.CustomFormat = "";
            this.dtpCusPO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCusPO.Location = new System.Drawing.Point(90, 19);
            this.dtpCusPO.Name = "dtpCusPO";
            this.dtpCusPO.Size = new System.Drawing.Size(97, 20);
            this.dtpCusPO.TabIndex = 28;
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
            // dgCusPo
            // 
            this.dgCusPo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCusPo.Location = new System.Drawing.Point(12, 150);
            this.dgCusPo.Name = "dgCusPo";
            this.dgCusPo.Size = new System.Drawing.Size(475, 222);
            this.dgCusPo.TabIndex = 24;
            // 
            // cboItemDescription
            // 
            this.cboItemDescription.FormattingEnabled = true;
            this.cboItemDescription.Location = new System.Drawing.Point(131, 122);
            this.cboItemDescription.Name = "cboItemDescription";
            this.cboItemDescription.Size = new System.Drawing.Size(262, 21);
            this.cboItemDescription.TabIndex = 8;
            // 
            // cboCusName
            // 
            this.cboCusName.FormattingEnabled = true;
            this.cboCusName.Location = new System.Drawing.Point(167, 45);
            this.cboCusName.Name = "cboCusName";
            this.cboCusName.Size = new System.Drawing.Size(374, 21);
            this.cboCusName.TabIndex = 8;
            // 
            // cboItemID
            // 
            this.cboItemID.FormattingEnabled = true;
            this.cboItemID.Location = new System.Drawing.Point(13, 123);
            this.cboItemID.Name = "cboItemID";
            this.cboItemID.Size = new System.Drawing.Size(112, 21);
            this.cboItemID.TabIndex = 8;
            // 
            // cboCusID
            // 
            this.cboCusID.FormattingEnabled = true;
            this.cboCusID.Location = new System.Drawing.Point(90, 45);
            this.cboCusID.Name = "cboCusID";
            this.cboCusID.Size = new System.Drawing.Size(71, 21);
            this.cboCusID.TabIndex = 8;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(417, 123);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(70, 20);
            this.txtQty.TabIndex = 9;
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
            // txtPoNo
            // 
            this.txtPoNo.Location = new System.Drawing.Point(380, 19);
            this.txtPoNo.Name = "txtPoNo";
            this.txtPoNo.ReadOnly = true;
            this.txtPoNo.Size = new System.Drawing.Size(161, 20);
            this.txtPoNo.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(441, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Qty.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(143, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Item Name";
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
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 15);
            this.label16.TabIndex = 2;
            this.label16.Text = "Customer";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmdICusPOClear);
            this.groupBox6.Controls.Add(this.cmdExit);
            this.groupBox6.Controls.Add(this.cmdSave);
            this.groupBox6.Location = new System.Drawing.Point(72, 378);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox6.Size = new System.Drawing.Size(389, 69);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = ";";
            // 
            // cmdICusPOClear
            // 
            this.cmdICusPOClear.FlatAppearance.BorderSize = 0;
            this.cmdICusPOClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdICusPOClear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdICusPOClear.Image = global::MPLSMS.Properties.Resources.clear;
            this.cmdICusPOClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdICusPOClear.Location = new System.Drawing.Point(134, 11);
            this.cmdICusPOClear.Name = "cmdICusPOClear";
            this.cmdICusPOClear.Size = new System.Drawing.Size(107, 52);
            this.cmdICusPOClear.TabIndex = 35;
            this.cmdICusPOClear.Text = "Clear";
            this.cmdICusPOClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdICusPOClear.UseVisualStyleBackColor = true;
            this.cmdICusPOClear.Click += new System.EventHandler(this.cmdICusPOClear_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.FlatAppearance.BorderSize = 0;
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Image = global::MPLSMS.Properties.Resources.exit;
            this.cmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExit.Location = new System.Drawing.Point(263, 11);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(116, 52);
            this.cmdExit.TabIndex = 18;
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
            this.cmdSave.Location = new System.Drawing.Point(4, 11);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(112, 52);
            this.cmdSave.TabIndex = 19;
            this.cmdSave.Text = "Save";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // frmCusPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 476);
            this.Controls.Add(this.groupBox4);
            this.Name = "frmCusPO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custpmer Purchase Order";
            this.Load += new System.EventHandler(this.frmCusPO_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCusPo)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel llblViewStock;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpCusPO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgCusPo;
        private System.Windows.Forms.ComboBox cboItemDescription;
        private System.Windows.Forms.ComboBox cboCusName;
        private System.Windows.Forms.ComboBox cboItemID;
        private System.Windows.Forms.ComboBox cboCusID;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPoNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdItmMin;
        private System.Windows.Forms.Button cmdItmAdd;
        private System.Windows.Forms.Button cmdICusPOClear;
    }
}