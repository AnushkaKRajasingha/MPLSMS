namespace MPLSMS
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgCustomer = new System.Windows.Forms.DataGridView();
            this.cboCusType = new System.Windows.Forms.ComboBox();
            this.dtpCus = new System.Windows.Forms.DateTimePicker();
            this.chkCusBlocked = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboCusTitle = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCusEmail = new System.Windows.Forms.TextBox();
            this.txtCusConPerson = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCusSvatNo = new System.Windows.Forms.TextBox();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.txtCusVatNo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCusAdLine1 = new System.Windows.Forms.TextBox();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmdCusExit = new System.Windows.Forms.Button();
            this.cmdCusClear = new System.Windows.Forms.Button();
            this.cmdCusDelete = new System.Windows.Forms.Button();
            this.CmdCusUpdate = new System.Windows.Forms.Button();
            this.cmdCusAdd = new System.Windows.Forms.Button();
            this.lblEmailval = new System.Windows.Forms.Label();
            this.txtCusMobNo = new System.Windows.Forms.MaskedTextBox();
            this.txtCusTell = new System.Windows.Forms.MaskedTextBox();
            this.txtCusFaxNo = new System.Windows.Forms.MaskedTextBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgCustomer);
            this.groupBox4.Controls.Add(this.cboCusType);
            this.groupBox4.Controls.Add(this.dtpCus);
            this.groupBox4.Controls.Add(this.chkCusBlocked);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtfind);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txtCusSvatNo);
            this.groupBox4.Controls.Add(this.txtCusID);
            this.groupBox4.Controls.Add(this.txtCusVatNo);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtCusAdLine1);
            this.groupBox4.Controls.Add(this.txtCusName);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(4, 12);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(770, 513);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Customer Details";
            // 
            // dgCustomer
            // 
            this.dgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomer.Location = new System.Drawing.Point(14, 299);
            this.dgCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgCustomer.Name = "dgCustomer";
            this.dgCustomer.Size = new System.Drawing.Size(755, 220);
            this.dgCustomer.TabIndex = 24;
            this.dgCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomer_CellClick);
            // 
            // cboCusType
            // 
            this.cboCusType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCusType.FormattingEnabled = true;
            this.cboCusType.Items.AddRange(new object[] {
            "Ordinary ",
            "Retail"});
            this.cboCusType.Location = new System.Drawing.Point(397, 13);
            this.cboCusType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCusType.Name = "cboCusType";
            this.cboCusType.Size = new System.Drawing.Size(116, 21);
            this.cboCusType.Sorted = true;
            this.cboCusType.TabIndex = 2;
            // 
            // dtpCus
            // 
            this.dtpCus.CustomFormat = "";
            this.dtpCus.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCus.Location = new System.Drawing.Point(559, 13);
            this.dtpCus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpCus.Name = "dtpCus";
            this.dtpCus.Size = new System.Drawing.Size(112, 20);
            this.dtpCus.TabIndex = 21;
            // 
            // chkCusBlocked
            // 
            this.chkCusBlocked.AutoSize = true;
            this.chkCusBlocked.Location = new System.Drawing.Point(745, 16);
            this.chkCusBlocked.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkCusBlocked.Name = "chkCusBlocked";
            this.chkCusBlocked.Size = new System.Drawing.Size(15, 14);
            this.chkCusBlocked.TabIndex = 22;
            this.chkCusBlocked.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 278);
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
            this.label3.Location = new System.Drawing.Point(8, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer ID*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(293, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Customer Type*";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtCusFaxNo);
            this.groupBox5.Controls.Add(this.txtCusTell);
            this.groupBox5.Controls.Add(this.txtCusMobNo);
            this.groupBox5.Controls.Add(this.lblEmailval);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.cboCusTitle);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txtTitle);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.txtCusEmail);
            this.groupBox5.Controls.Add(this.txtCusConPerson);
            this.groupBox5.Location = new System.Drawing.Point(11, 101);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(750, 91);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Contact Details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(307, 57);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Fax";
            // 
            // cboCusTitle
            // 
            this.cboCusTitle.FormattingEnabled = true;
            this.cboCusTitle.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Ms"});
            this.cboCusTitle.Location = new System.Drawing.Point(88, 19);
            this.cboCusTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCusTitle.Name = "cboCusTitle";
            this.cboCusTitle.Size = new System.Drawing.Size(84, 21);
            this.cboCusTitle.Sorted = true;
            this.cboCusTitle.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(486, 52);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(186, 57);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "Tell";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 57);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Mobile No";
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(7, 24);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(31, 15);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.Text = "Title";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(195, 23);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "Customer Person";
            // 
            // txtCusEmail
            // 
            this.txtCusEmail.Location = new System.Drawing.Point(535, 49);
            this.txtCusEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCusEmail.Name = "txtCusEmail";
            this.txtCusEmail.Size = new System.Drawing.Size(208, 20);
            this.txtCusEmail.TabIndex = 13;
            this.txtCusEmail.TabIndexChanged += new System.EventHandler(this.txtCusEmail_TabIndexChanged);
            this.txtCusEmail.TextChanged += new System.EventHandler(this.txtCusEmail_TextChanged);
            this.txtCusEmail.Leave += new System.EventHandler(this.txtCusEmail_Leave);
            // 
            // txtCusConPerson
            // 
            this.txtCusConPerson.Location = new System.Drawing.Point(307, 21);
            this.txtCusConPerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCusConPerson.Name = "txtCusConPerson";
            this.txtCusConPerson.Size = new System.Drawing.Size(435, 20);
            this.txtCusConPerson.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(697, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Block";
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(55, 276);
            this.txtfind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtfind.MaxLength = 12;
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(196, 20);
            this.txtfind.TabIndex = 19;
            this.txtfind.TextChanged += new System.EventHandler(this.txtfind_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(611, 47);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 15);
            this.label18.TabIndex = 2;
            this.label18.Text = "SVAT No";
            // 
            // txtCusSvatNo
            // 
            this.txtCusSvatNo.Location = new System.Drawing.Point(664, 45);
            this.txtCusSvatNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCusSvatNo.Name = "txtCusSvatNo";
            this.txtCusSvatNo.Size = new System.Drawing.Size(99, 20);
            this.txtCusSvatNo.TabIndex = 5;
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(119, 13);
            this.txtCusID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(148, 20);
            this.txtCusID.TabIndex = 20;
            // 
            // txtCusVatNo
            // 
            this.txtCusVatNo.Location = new System.Drawing.Point(503, 45);
            this.txtCusVatNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCusVatNo.Name = "txtCusVatNo";
            this.txtCusVatNo.Size = new System.Drawing.Size(100, 20);
            this.txtCusVatNo.TabIndex = 4;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(456, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "VAT No";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 48);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 15);
            this.label16.TabIndex = 2;
            this.label16.Text = "Customer Name*";
            // 
            // txtCusAdLine1
            // 
            this.txtCusAdLine1.Location = new System.Drawing.Point(119, 75);
            this.txtCusAdLine1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCusAdLine1.Name = "txtCusAdLine1";
            this.txtCusAdLine1.Size = new System.Drawing.Size(641, 20);
            this.txtCusAdLine1.TabIndex = 6;
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(119, 45);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(329, 20);
            this.txtCusName.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmdCusExit);
            this.groupBox6.Controls.Add(this.cmdCusClear);
            this.groupBox6.Controls.Add(this.cmdCusDelete);
            this.groupBox6.Controls.Add(this.CmdCusUpdate);
            this.groupBox6.Controls.Add(this.cmdCusAdd);
            this.groupBox6.Location = new System.Drawing.Point(11, 198);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox6.Size = new System.Drawing.Size(750, 75);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            // 
            // cmdCusExit
            // 
            this.cmdCusExit.FlatAppearance.BorderSize = 0;
            this.cmdCusExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCusExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCusExit.Image = global::MPLSMS.Properties.Resources.exit;
            this.cmdCusExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCusExit.Location = new System.Drawing.Point(616, 12);
            this.cmdCusExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdCusExit.Name = "cmdCusExit";
            this.cmdCusExit.Size = new System.Drawing.Size(122, 59);
            this.cmdCusExit.TabIndex = 19;
            this.cmdCusExit.Text = "Exit";
            this.cmdCusExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCusExit.UseVisualStyleBackColor = true;
            this.cmdCusExit.Click += new System.EventHandler(this.cmdCusExit_Click);
            // 
            // cmdCusClear
            // 
            this.cmdCusClear.FlatAppearance.BorderSize = 0;
            this.cmdCusClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCusClear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCusClear.Image = global::MPLSMS.Properties.Resources.clear;
            this.cmdCusClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCusClear.Location = new System.Drawing.Point(310, 12);
            this.cmdCusClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdCusClear.Name = "cmdCusClear";
            this.cmdCusClear.Size = new System.Drawing.Size(122, 59);
            this.cmdCusClear.TabIndex = 17;
            this.cmdCusClear.Text = "Clear";
            this.cmdCusClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCusClear.UseVisualStyleBackColor = true;
            this.cmdCusClear.Click += new System.EventHandler(this.cmdCusClear_Click);
            // 
            // cmdCusDelete
            // 
            this.cmdCusDelete.FlatAppearance.BorderSize = 0;
            this.cmdCusDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCusDelete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCusDelete.Image = global::MPLSMS.Properties.Resources.delete;
            this.cmdCusDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCusDelete.Location = new System.Drawing.Point(463, 12);
            this.cmdCusDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdCusDelete.Name = "cmdCusDelete";
            this.cmdCusDelete.Size = new System.Drawing.Size(122, 59);
            this.cmdCusDelete.TabIndex = 18;
            this.cmdCusDelete.Text = "Delete";
            this.cmdCusDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCusDelete.UseVisualStyleBackColor = true;
            this.cmdCusDelete.Click += new System.EventHandler(this.cmdCusDelete_Click);
            // 
            // CmdCusUpdate
            // 
            this.CmdCusUpdate.FlatAppearance.BorderSize = 0;
            this.CmdCusUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdCusUpdate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCusUpdate.Image = global::MPLSMS.Properties.Resources.Add1;
            this.CmdCusUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdCusUpdate.Location = new System.Drawing.Point(157, 12);
            this.CmdCusUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmdCusUpdate.Name = "CmdCusUpdate";
            this.CmdCusUpdate.Size = new System.Drawing.Size(122, 59);
            this.CmdCusUpdate.TabIndex = 16;
            this.CmdCusUpdate.Text = "Update";
            this.CmdCusUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdCusUpdate.UseVisualStyleBackColor = true;
            this.CmdCusUpdate.Click += new System.EventHandler(this.CmdCusUpdate_Click);
            // 
            // cmdCusAdd
            // 
            this.cmdCusAdd.AutoEllipsis = true;
            this.cmdCusAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdCusAdd.FlatAppearance.BorderSize = 0;
            this.cmdCusAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCusAdd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCusAdd.Image = global::MPLSMS.Properties.Resources.Add;
            this.cmdCusAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCusAdd.Location = new System.Drawing.Point(4, 12);
            this.cmdCusAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdCusAdd.Name = "cmdCusAdd";
            this.cmdCusAdd.Size = new System.Drawing.Size(122, 59);
            this.cmdCusAdd.TabIndex = 15;
            this.cmdCusAdd.Text = "Add";
            this.cmdCusAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCusAdd.UseVisualStyleBackColor = true;
            this.cmdCusAdd.Click += new System.EventHandler(this.cmdCusAdd_Click);
            // 
            // lblEmailval
            // 
            this.lblEmailval.AutoSize = true;
            this.lblEmailval.ForeColor = System.Drawing.Color.Red;
            this.lblEmailval.Location = new System.Drawing.Point(543, 71);
            this.lblEmailval.Name = "lblEmailval";
            this.lblEmailval.Size = new System.Drawing.Size(0, 13);
            this.lblEmailval.TabIndex = 14;
            // 
            // txtCusMobNo
            // 
            this.txtCusMobNo.Location = new System.Drawing.Point(79, 54);
            this.txtCusMobNo.Mask = "(999) 000-0000";
            this.txtCusMobNo.Name = "txtCusMobNo";
            this.txtCusMobNo.Size = new System.Drawing.Size(82, 20);
            this.txtCusMobNo.TabIndex = 15;
            // 
            // txtCusTell
            // 
            this.txtCusTell.Location = new System.Drawing.Point(215, 54);
            this.txtCusTell.Mask = "(999) 000-0000";
            this.txtCusTell.Name = "txtCusTell";
            this.txtCusTell.Size = new System.Drawing.Size(82, 20);
            this.txtCusTell.TabIndex = 16;
            // 
            // txtCusFaxNo
            // 
            this.txtCusFaxNo.Location = new System.Drawing.Point(339, 54);
            this.txtCusFaxNo.Mask = "(999) 000-0000";
            this.txtCusFaxNo.Name = "txtCusFaxNo";
            this.txtCusFaxNo.Size = new System.Drawing.Size(82, 20);
            this.txtCusFaxNo.TabIndex = 17;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 536);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MARKSPEN LABELS - Customer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgCustomer;
        private System.Windows.Forms.ComboBox cboCusType;
        private System.Windows.Forms.DateTimePicker dtpCus;
        private System.Windows.Forms.CheckBox chkCusBlocked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboCusTitle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCusEmail;
        private System.Windows.Forms.TextBox txtCusConPerson;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCusSvatNo;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.TextBox txtCusVatNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCusAdLine1;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button cmdCusExit;
        private System.Windows.Forms.Button cmdCusClear;
        private System.Windows.Forms.Button cmdCusDelete;
        private System.Windows.Forms.Button CmdCusUpdate;
        private System.Windows.Forms.Button cmdCusAdd;
        private System.Windows.Forms.Label lblEmailval;
        private System.Windows.Forms.MaskedTextBox txtCusMobNo;
        private System.Windows.Forms.MaskedTextBox txtCusFaxNo;
        private System.Windows.Forms.MaskedTextBox txtCusTell;

    }
}