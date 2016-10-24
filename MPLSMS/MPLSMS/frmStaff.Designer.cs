namespace MPLSMS
{
    partial class frmStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaff));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgStaff = new System.Windows.Forms.DataGridView();
            this.cboSTitle = new System.Windows.Forms.ComboBox();
            this.cboSSex = new System.Windows.Forms.ComboBox();
            this.cboStaffRole = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpStaffDOB = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStaffMobNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStaffFind = new System.Windows.Forms.TextBox();
            this.txtSConformPWD = new System.Windows.Forms.TextBox();
            this.txtSPWD = new System.Windows.Forms.TextBox();
            this.txtStaffUName = new System.Windows.Forms.TextBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSAddress = new System.Windows.Forms.TextBox();
            this.txtSLName = new System.Windows.Forms.TextBox();
            this.txtSFName = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmdStaffExit = new System.Windows.Forms.Button();
            this.cmdStaffClear = new System.Windows.Forms.Button();
            this.cmdStaffDelete = new System.Windows.Forms.Button();
            this.CmdStaffUpdate = new System.Windows.Forms.Button();
            this.cmdStaffAdd = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStaff)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgStaff);
            this.groupBox4.Controls.Add(this.cboSTitle);
            this.groupBox4.Controls.Add(this.cboSSex);
            this.groupBox4.Controls.Add(this.cboStaffRole);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.dtpStaffDOB);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtTitle);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtStaffMobNo);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtStaffFind);
            this.groupBox4.Controls.Add(this.txtSConformPWD);
            this.groupBox4.Controls.Add(this.txtSPWD);
            this.groupBox4.Controls.Add(this.txtStaffUName);
            this.groupBox4.Controls.Add(this.txtStaffID);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtSAddress);
            this.groupBox4.Controls.Add(this.txtSLName);
            this.groupBox4.Controls.Add(this.txtSFName);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(-2, 1);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(770, 502);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Customer Details";
            // 
            // dgStaff
            // 
            this.dgStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStaff.Location = new System.Drawing.Point(14, 273);
            this.dgStaff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgStaff.Name = "dgStaff";
            this.dgStaff.Size = new System.Drawing.Size(755, 220);
            this.dgStaff.TabIndex = 19;
            this.dgStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStaff_CellClick);
            // 
            // cboSTitle
            // 
            this.cboSTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSTitle.FormattingEnabled = true;
            this.cboSTitle.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Ms"});
            this.cboSTitle.Location = new System.Drawing.Point(506, 14);
            this.cboSTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboSTitle.Name = "cboSTitle";
            this.cboSTitle.Size = new System.Drawing.Size(84, 21);
            this.cboSTitle.Sorted = true;
            this.cboSTitle.TabIndex = 7;
            // 
            // cboSSex
            // 
            this.cboSSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSSex.FormattingEnabled = true;
            this.cboSSex.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cboSSex.Location = new System.Drawing.Point(119, 101);
            this.cboSSex.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboSSex.Name = "cboSSex";
            this.cboSSex.Size = new System.Drawing.Size(84, 21);
            this.cboSSex.Sorted = true;
            this.cboSSex.TabIndex = 7;
            // 
            // cboStaffRole
            // 
            this.cboStaffRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStaffRole.FormattingEnabled = true;
            this.cboStaffRole.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboStaffRole.Location = new System.Drawing.Point(311, 14);
            this.cboStaffRole.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboStaffRole.Name = "cboStaffRole";
            this.cboStaffRole.Size = new System.Drawing.Size(116, 21);
            this.cboStaffRole.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(284, 105);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Mobile No";
            // 
            // dtpStaffDOB
            // 
            this.dtpStaffDOB.CustomFormat = "";
            this.dtpStaffDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStaffDOB.Location = new System.Drawing.Point(644, 14);
            this.dtpStaffDOB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpStaffDOB.Name = "dtpStaffDOB";
            this.dtpStaffDOB.Size = new System.Drawing.Size(112, 20);
            this.dtpStaffDOB.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(515, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Conform PWD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(289, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "User Name";
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(70, 107);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(26, 15);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.Text = "Sex";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(605, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "DOB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Find";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Staff ID*";
            // 
            // txtStaffMobNo
            // 
            this.txtStaffMobNo.Location = new System.Drawing.Point(355, 102);
            this.txtStaffMobNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStaffMobNo.MaxLength = 12;
            this.txtStaffMobNo.Name = "txtStaffMobNo";
            this.txtStaffMobNo.Size = new System.Drawing.Size(148, 20);
            this.txtStaffMobNo.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(459, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Title";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(238, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Staff Role*";
            // 
            // txtStaffFind
            // 
            this.txtStaffFind.Location = new System.Drawing.Point(55, 243);
            this.txtStaffFind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStaffFind.MaxLength = 12;
            this.txtStaffFind.Name = "txtStaffFind";
            this.txtStaffFind.Size = new System.Drawing.Size(196, 20);
            this.txtStaffFind.TabIndex = 17;
            this.txtStaffFind.TextChanged += new System.EventHandler(this.txtStaffFind_TextChanged);
            // 
            // txtSConformPWD
            // 
            this.txtSConformPWD.Location = new System.Drawing.Point(601, 132);
            this.txtSConformPWD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSConformPWD.Name = "txtSConformPWD";
            this.txtSConformPWD.PasswordChar = '*';
            this.txtSConformPWD.Size = new System.Drawing.Size(148, 20);
            this.txtSConformPWD.TabIndex = 11;
            // 
            // txtSPWD
            // 
            this.txtSPWD.Location = new System.Drawing.Point(354, 132);
            this.txtSPWD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSPWD.Name = "txtSPWD";
            this.txtSPWD.PasswordChar = '*';
            this.txtSPWD.Size = new System.Drawing.Size(148, 20);
            this.txtSPWD.TabIndex = 10;
            // 
            // txtStaffUName
            // 
            this.txtStaffUName.Location = new System.Drawing.Point(119, 132);
            this.txtStaffUName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStaffUName.Name = "txtStaffUName";
            this.txtStaffUName.Size = new System.Drawing.Size(148, 20);
            this.txtStaffUName.TabIndex = 9;
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(119, 14);
            this.txtStaffID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(111, 20);
            this.txtStaffID.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(52, 78);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 15);
            this.label15.TabIndex = 2;
            this.label15.Text = "Adress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(391, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Staff Last Name*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 47);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 15);
            this.label16.TabIndex = 2;
            this.label16.Text = "Staff First Name*";
            // 
            // txtSAddress
            // 
            this.txtSAddress.Location = new System.Drawing.Point(119, 75);
            this.txtSAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSAddress.Name = "txtSAddress";
            this.txtSAddress.Size = new System.Drawing.Size(641, 20);
            this.txtSAddress.TabIndex = 6;
            // 
            // txtSLName
            // 
            this.txtSLName.Location = new System.Drawing.Point(506, 46);
            this.txtSLName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSLName.Name = "txtSLName";
            this.txtSLName.Size = new System.Drawing.Size(253, 20);
            this.txtSLName.TabIndex = 5;
            // 
            // txtSFName
            // 
            this.txtSFName.Location = new System.Drawing.Point(119, 45);
            this.txtSFName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSFName.Name = "txtSFName";
            this.txtSFName.Size = new System.Drawing.Size(254, 20);
            this.txtSFName.TabIndex = 4;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmdStaffExit);
            this.groupBox6.Controls.Add(this.cmdStaffClear);
            this.groupBox6.Controls.Add(this.cmdStaffDelete);
            this.groupBox6.Controls.Add(this.CmdStaffUpdate);
            this.groupBox6.Controls.Add(this.cmdStaffAdd);
            this.groupBox6.Location = new System.Drawing.Point(11, 161);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox6.Size = new System.Drawing.Size(750, 75);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            // 
            // cmdStaffExit
            // 
            this.cmdStaffExit.FlatAppearance.BorderSize = 0;
            this.cmdStaffExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdStaffExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStaffExit.Image = global::MPLSMS.Properties.Resources.exit;
            this.cmdStaffExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdStaffExit.Location = new System.Drawing.Point(616, 12);
            this.cmdStaffExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdStaffExit.Name = "cmdStaffExit";
            this.cmdStaffExit.Size = new System.Drawing.Size(122, 59);
            this.cmdStaffExit.TabIndex = 16;
            this.cmdStaffExit.Text = "Exit";
            this.cmdStaffExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdStaffExit.UseVisualStyleBackColor = true;
            this.cmdStaffExit.Click += new System.EventHandler(this.cmdStaffExit_Click);
            // 
            // cmdStaffClear
            // 
            this.cmdStaffClear.FlatAppearance.BorderSize = 0;
            this.cmdStaffClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdStaffClear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStaffClear.Image = global::MPLSMS.Properties.Resources.clear;
            this.cmdStaffClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdStaffClear.Location = new System.Drawing.Point(310, 12);
            this.cmdStaffClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdStaffClear.Name = "cmdStaffClear";
            this.cmdStaffClear.Size = new System.Drawing.Size(122, 59);
            this.cmdStaffClear.TabIndex = 14;
            this.cmdStaffClear.Text = "Clear";
            this.cmdStaffClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdStaffClear.UseVisualStyleBackColor = true;
            this.cmdStaffClear.Click += new System.EventHandler(this.cmdStaffClear_Click);
            // 
            // cmdStaffDelete
            // 
            this.cmdStaffDelete.FlatAppearance.BorderSize = 0;
            this.cmdStaffDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdStaffDelete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStaffDelete.Image = global::MPLSMS.Properties.Resources.delete;
            this.cmdStaffDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdStaffDelete.Location = new System.Drawing.Point(463, 12);
            this.cmdStaffDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdStaffDelete.Name = "cmdStaffDelete";
            this.cmdStaffDelete.Size = new System.Drawing.Size(122, 59);
            this.cmdStaffDelete.TabIndex = 15;
            this.cmdStaffDelete.Text = "Delete";
            this.cmdStaffDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdStaffDelete.UseVisualStyleBackColor = true;
            this.cmdStaffDelete.Click += new System.EventHandler(this.cmdStaffDelete_Click);
            // 
            // CmdStaffUpdate
            // 
            this.CmdStaffUpdate.FlatAppearance.BorderSize = 0;
            this.CmdStaffUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdStaffUpdate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdStaffUpdate.Image = global::MPLSMS.Properties.Resources.Add1;
            this.CmdStaffUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdStaffUpdate.Location = new System.Drawing.Point(157, 12);
            this.CmdStaffUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmdStaffUpdate.Name = "CmdStaffUpdate";
            this.CmdStaffUpdate.Size = new System.Drawing.Size(122, 59);
            this.CmdStaffUpdate.TabIndex = 13;
            this.CmdStaffUpdate.Text = "Update";
            this.CmdStaffUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdStaffUpdate.UseVisualStyleBackColor = true;
            this.CmdStaffUpdate.Click += new System.EventHandler(this.CmdStaffUpdate_Click);
            // 
            // cmdStaffAdd
            // 
            this.cmdStaffAdd.AutoEllipsis = true;
            this.cmdStaffAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdStaffAdd.FlatAppearance.BorderSize = 0;
            this.cmdStaffAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdStaffAdd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStaffAdd.Image = global::MPLSMS.Properties.Resources.Add;
            this.cmdStaffAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdStaffAdd.Location = new System.Drawing.Point(4, 12);
            this.cmdStaffAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdStaffAdd.Name = "cmdStaffAdd";
            this.cmdStaffAdd.Size = new System.Drawing.Size(122, 59);
            this.cmdStaffAdd.TabIndex = 12;
            this.cmdStaffAdd.Text = "Add";
            this.cmdStaffAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdStaffAdd.UseVisualStyleBackColor = true;
            this.cmdStaffAdd.Click += new System.EventHandler(this.cmdStaffAdd_Click);
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 506);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MARKSPEN LABELS - STAFF";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStaff)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgStaff;
        private System.Windows.Forms.ComboBox cboSSex;
        private System.Windows.Forms.ComboBox cboStaffRole;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpStaffDOB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStaffMobNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStaffFind;
        private System.Windows.Forms.TextBox txtSConformPWD;
        private System.Windows.Forms.TextBox txtSPWD;
        private System.Windows.Forms.TextBox txtStaffUName;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSAddress;
        private System.Windows.Forms.TextBox txtSLName;
        private System.Windows.Forms.TextBox txtSFName;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button cmdStaffExit;
        private System.Windows.Forms.Button cmdStaffClear;
        private System.Windows.Forms.Button cmdStaffDelete;
        private System.Windows.Forms.Button CmdStaffUpdate;
        private System.Windows.Forms.Button cmdStaffAdd;
        private System.Windows.Forms.ComboBox cboSTitle;
        private System.Windows.Forms.Label label8;
    }
}