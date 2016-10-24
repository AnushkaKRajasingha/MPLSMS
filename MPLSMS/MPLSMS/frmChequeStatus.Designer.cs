namespace MPLSMS
{
    partial class frmChequeStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChequeStatus));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpEnteredDate = new System.Windows.Forms.DateTimePicker();
            this.dtpChqDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCusName = new System.Windows.Forms.ComboBox();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.cboCusId = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.txtUnrChq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.txtCheckNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpEnteredDate);
            this.groupBox4.Controls.Add(this.dtpChqDate);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.cboCusName);
            this.groupBox4.Controls.Add(this.txtStatus);
            this.groupBox4.Controls.Add(this.cboCusId);
            this.groupBox4.Controls.Add(this.txtAmount);
            this.groupBox4.Controls.Add(this.txtBank);
            this.groupBox4.Controls.Add(this.txtUnrChq);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtCusID);
            this.groupBox4.Controls.Add(this.txtCheckNo);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(551, 363);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // dtpEnteredDate
            // 
            this.dtpEnteredDate.CustomFormat = "";
            this.dtpEnteredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnteredDate.Location = new System.Drawing.Point(279, 249);
            this.dtpEnteredDate.Name = "dtpEnteredDate";
            this.dtpEnteredDate.Size = new System.Drawing.Size(106, 20);
            this.dtpEnteredDate.TabIndex = 31;
            // 
            // dtpChqDate
            // 
            this.dtpChqDate.CustomFormat = "";
            this.dtpChqDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpChqDate.Location = new System.Drawing.Point(279, 116);
            this.dtpChqDate.Name = "dtpChqDate";
            this.dtpChqDate.Size = new System.Drawing.Size(106, 20);
            this.dtpChqDate.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Customer ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Customer ID";
            // 
            // cboCusName
            // 
            this.cboCusName.FormattingEnabled = true;
            this.cboCusName.Location = new System.Drawing.Point(279, 16);
            this.cboCusName.Name = "cboCusName";
            this.cboCusName.Size = new System.Drawing.Size(251, 21);
            this.cboCusName.Sorted = true;
            this.cboCusName.TabIndex = 8;
            // 
            // txtStatus
            // 
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Location = new System.Drawing.Point(279, 215);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(106, 21);
            this.txtStatus.Sorted = true;
            this.txtStatus.TabIndex = 8;
            // 
            // cboCusId
            // 
            this.cboCusId.FormattingEnabled = true;
            this.cboCusId.Location = new System.Drawing.Point(99, 14);
            this.cboCusId.Name = "cboCusId";
            this.cboCusId.Size = new System.Drawing.Size(71, 21);
            this.cboCusId.Sorted = true;
            this.cboCusId.TabIndex = 8;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(279, 182);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(107, 20);
            this.txtAmount.TabIndex = 9;
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(279, 149);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(107, 20);
            this.txtBank.TabIndex = 9;
            // 
            // txtUnrChq
            // 
            this.txtUnrChq.Location = new System.Drawing.Point(24, 80);
            this.txtUnrChq.Multiline = true;
            this.txtUnrChq.Name = "txtUnrChq";
            this.txtUnrChq.Size = new System.Drawing.Size(106, 174);
            this.txtUnrChq.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unrealized Checque";
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(280, 57);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(106, 20);
            this.txtCusID.TabIndex = 9;
            // 
            // txtCheckNo
            // 
            this.txtCheckNo.Location = new System.Drawing.Point(279, 90);
            this.txtCheckNo.Name = "txtCheckNo";
            this.txtCheckNo.Size = new System.Drawing.Size(106, 20);
            this.txtCheckNo.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(193, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Amount (LKR)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(240, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Bank";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(203, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Entered Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(213, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "CHQ Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(223, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "CHQ No";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmdExit);
            this.groupBox6.Controls.Add(this.cmdSave);
            this.groupBox6.Location = new System.Drawing.Point(99, 288);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox6.Size = new System.Drawing.Size(389, 69);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = ";";
            // 
            // cmdExit
            // 
            this.cmdExit.FlatAppearance.BorderSize = 0;
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Image = global::MPLSMS.Properties.Resources.exit;
            this.cmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExit.Location = new System.Drawing.Point(244, 13);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(107, 52);
            this.cmdExit.TabIndex = 21;
            this.cmdExit.Text = "Exit";
            this.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdExit.UseVisualStyleBackColor = true;
            // 
            // cmdSave
            // 
            this.cmdSave.FlatAppearance.BorderSize = 0;
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSave.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Image = global::MPLSMS.Properties.Resources.Save;
            this.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSave.Location = new System.Drawing.Point(5, 10);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(100, 52);
            this.cmdSave.TabIndex = 19;
            this.cmdSave.Text = "Save";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSave.UseVisualStyleBackColor = true;
            // 
            // frmChequeStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 392);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChequeStatus";
            this.Text = "CHEQUE STATUS - MARKSPEN LABELS";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpEnteredDate;
        private System.Windows.Forms.DateTimePicker dtpChqDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCusName;
        private System.Windows.Forms.ComboBox txtStatus;
        private System.Windows.Forms.ComboBox cboCusId;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.TextBox txtUnrChq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.TextBox txtCheckNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdSave;
    }
}