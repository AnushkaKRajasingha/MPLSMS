namespace MPLSMS
{
    partial class frmAproveCredit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAproveCredit));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCusName = new System.Windows.Forms.ComboBox();
            this.cboCusId = new System.Windows.Forms.ComboBox();
            this.txtCreditLimit = new System.Windows.Forms.TextBox();
            this.txtOutstandingBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.chkCusBlocked = new System.Windows.Forms.CheckBox();
            this.lblBlocked = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblBlocked);
            this.groupBox4.Controls.Add(this.chkCusBlocked);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.cboCusName);
            this.groupBox4.Controls.Add(this.cboCusId);
            this.groupBox4.Controls.Add(this.txtCreditLimit);
            this.groupBox4.Controls.Add(this.txtOutstandingBalance);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(551, 250);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Credit Limit";
            // 
            // cboCusName
            // 
            this.cboCusName.FormattingEnabled = true;
            this.cboCusName.Location = new System.Drawing.Point(167, 19);
            this.cboCusName.Name = "cboCusName";
            this.cboCusName.Size = new System.Drawing.Size(374, 21);
            this.cboCusName.Sorted = true;
            this.cboCusName.TabIndex = 8;
            // 
            // cboCusId
            // 
            this.cboCusId.FormattingEnabled = true;
            this.cboCusId.Location = new System.Drawing.Point(90, 19);
            this.cboCusId.Name = "cboCusId";
            this.cboCusId.Size = new System.Drawing.Size(71, 21);
            this.cboCusId.Sorted = true;
            this.cboCusId.TabIndex = 8;
            this.cboCusId.SelectedIndexChanged += new System.EventHandler(this.cboCusId_SelectedIndexChanged);
            // 
            // txtCreditLimit
            // 
            this.txtCreditLimit.Location = new System.Drawing.Point(167, 60);
            this.txtCreditLimit.Name = "txtCreditLimit";
            this.txtCreditLimit.Size = new System.Drawing.Size(181, 20);
            this.txtCreditLimit.TabIndex = 9;
            // 
            // txtOutstandingBalance
            // 
            this.txtOutstandingBalance.Location = new System.Drawing.Point(167, 92);
            this.txtOutstandingBalance.Name = "txtOutstandingBalance";
            this.txtOutstandingBalance.Size = new System.Drawing.Size(181, 20);
            this.txtOutstandingBalance.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Outstanding balance";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(21, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 15);
            this.label16.TabIndex = 2;
            this.label16.Text = "Customer";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmdEdit);
            this.groupBox6.Controls.Add(this.cmdExit);
            this.groupBox6.Controls.Add(this.cmdSave);
            this.groupBox6.Location = new System.Drawing.Point(90, 168);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox6.Size = new System.Drawing.Size(389, 69);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = ";";
            // 
            // cmdEdit
            // 
            this.cmdEdit.FlatAppearance.BorderSize = 0;
            this.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEdit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEdit.Image = global::MPLSMS.Properties.Resources.edit;
            this.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdEdit.Location = new System.Drawing.Point(134, 10);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(107, 52);
            this.cmdEdit.TabIndex = 21;
            this.cmdEdit.Text = "Edit";
            this.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdEdit.UseVisualStyleBackColor = true;
            // 
            // cmdExit
            // 
            this.cmdExit.FlatAppearance.BorderSize = 0;
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Image = global::MPLSMS.Properties.Resources.exit;
            this.cmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExit.Location = new System.Drawing.Point(263, 10);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(116, 52);
            this.cmdExit.TabIndex = 18;
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
            this.cmdSave.Size = new System.Drawing.Size(112, 52);
            this.cmdSave.TabIndex = 19;
            this.cmdSave.Text = "Save";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // chkCusBlocked
            // 
            this.chkCusBlocked.AutoSize = true;
            this.chkCusBlocked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCusBlocked.Location = new System.Drawing.Point(371, 97);
            this.chkCusBlocked.Name = "chkCusBlocked";
            this.chkCusBlocked.Size = new System.Drawing.Size(61, 19);
            this.chkCusBlocked.TabIndex = 28;
            this.chkCusBlocked.Text = "Block";
            this.chkCusBlocked.UseVisualStyleBackColor = true;
            // 
            // lblBlocked
            // 
            this.lblBlocked.AutoSize = true;
            this.lblBlocked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlocked.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBlocked.Location = new System.Drawing.Point(368, 60);
            this.lblBlocked.Name = "lblBlocked";
            this.lblBlocked.Size = new System.Drawing.Size(150, 16);
            this.lblBlocked.TabIndex = 29;
            this.lblBlocked.Text = "Custemer Is Blocked";
            // 
            // frmAproveCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 276);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAproveCredit";
            this.Text = "APROVE CREDIT - MARKSPEN LABELS";
            this.Load += new System.EventHandler(this.frmAproveCredit_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCusName;
        private System.Windows.Forms.ComboBox cboCusId;
        private System.Windows.Forms.TextBox txtCreditLimit;
        private System.Windows.Forms.TextBox txtOutstandingBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.CheckBox chkCusBlocked;
        private System.Windows.Forms.Label lblBlocked;
    }
}