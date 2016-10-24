namespace MPLSMS
{
    partial class frmSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplier));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgSupplir = new System.Windows.Forms.DataGridView();
            this.cboSupId = new System.Windows.Forms.ComboBox();
            this.dtpSup = new System.Windows.Forms.DateTimePicker();
            this.chkSupBlocked = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboTitle = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtConPerson = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSupSvatNo = new System.Windows.Forms.TextBox();
            this.txtSupVatNo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSupAdLine1 = new System.Windows.Forms.TextBox();
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmdSupExit = new System.Windows.Forms.Button();
            this.cmdSupClear = new System.Windows.Forms.Button();
            this.cmdSupDelete = new System.Windows.Forms.Button();
            this.CmdSupUpdate = new System.Windows.Forms.Button();
            this.cmdSupAdd = new System.Windows.Forms.Button();
            this.txtMobNo = new System.Windows.Forms.MaskedTextBox();
            this.txtTell = new System.Windows.Forms.MaskedTextBox();
            this.txtFaxNo = new System.Windows.Forms.MaskedTextBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplir)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgSupplir);
            this.groupBox4.Controls.Add(this.cboSupId);
            this.groupBox4.Controls.Add(this.dtpSup);
            this.groupBox4.Controls.Add(this.chkSupBlocked);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtfind);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txtSupSvatNo);
            this.groupBox4.Controls.Add(this.txtSupVatNo);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtSupAdLine1);
            this.groupBox4.Controls.Add(this.txtSupName);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(8, 12);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(770, 513);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Supplier Details";
            // 
            // dgSupplir
            // 
            this.dgSupplir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSupplir.Location = new System.Drawing.Point(14, 299);
            this.dgSupplir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgSupplir.Name = "dgSupplir";
            this.dgSupplir.Size = new System.Drawing.Size(755, 220);
            this.dgSupplir.TabIndex = 24;
            this.dgSupplir.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSupplir_CellClick);
            // 
            // cboSupId
            // 
            this.cboSupId.Enabled = false;
            this.cboSupId.FormattingEnabled = true;
            this.cboSupId.Location = new System.Drawing.Point(136, 14);
            this.cboSupId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboSupId.Name = "cboSupId";
            this.cboSupId.Size = new System.Drawing.Size(183, 21);
            this.cboSupId.TabIndex = 21;
            // 
            // dtpSup
            // 
            this.dtpSup.CustomFormat = "";
            this.dtpSup.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSup.Location = new System.Drawing.Point(532, 16);
            this.dtpSup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpSup.Name = "dtpSup";
            this.dtpSup.Size = new System.Drawing.Size(112, 21);
            this.dtpSup.TabIndex = 22;
            // 
            // chkSupBlocked
            // 
            this.chkSupBlocked.AutoSize = true;
            this.chkSupBlocked.Location = new System.Drawing.Point(745, 18);
            this.chkSupBlocked.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkSupBlocked.Name = "chkSupBlocked";
            this.chkSupBlocked.Size = new System.Drawing.Size(15, 14);
            this.chkSupBlocked.TabIndex = 23;
            this.chkSupBlocked.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 16);
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
            this.label2.Location = new System.Drawing.Point(17, 272);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Find";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Supplier ID*";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtFaxNo);
            this.groupBox5.Controls.Add(this.txtTell);
            this.groupBox5.Controls.Add(this.txtMobNo);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.cboTitle);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txtTitle);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.txtEmail);
            this.groupBox5.Controls.Add(this.txtConPerson);
            this.groupBox5.Location = new System.Drawing.Point(20, 101);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(750, 82);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Contact Details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(344, 54);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Fax";
            // 
            // cboTitle
            // 
            this.cboTitle.FormattingEnabled = true;
            this.cboTitle.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Ms"});
            this.cboTitle.Location = new System.Drawing.Point(88, 19);
            this.cboTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboTitle.Name = "cboTitle";
            this.cboTitle.Size = new System.Drawing.Size(84, 21);
            this.cboTitle.Sorted = true;
            this.cboTitle.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(486, 54);
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
            this.label12.Location = new System.Drawing.Point(186, 54);
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
            this.label13.Location = new System.Drawing.Point(7, 54);
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
            this.label14.Size = new System.Drawing.Size(90, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "Contact Person";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(535, 49);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(208, 21);
            this.txtEmail.TabIndex = 12;
            // 
            // txtConPerson
            // 
            this.txtConPerson.Location = new System.Drawing.Point(307, 21);
            this.txtConPerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtConPerson.Name = "txtConPerson";
            this.txtConPerson.Size = new System.Drawing.Size(435, 21);
            this.txtConPerson.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(682, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Block";
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(55, 270);
            this.txtfind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtfind.MaxLength = 12;
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(196, 21);
            this.txtfind.TabIndex = 19;
            this.txtfind.TextChanged += new System.EventHandler(this.txtfind_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(617, 48);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 15);
            this.label18.TabIndex = 2;
            this.label18.Text = "SVAT No";
            // 
            // txtSupSvatNo
            // 
            this.txtSupSvatNo.Location = new System.Drawing.Point(685, 45);
            this.txtSupSvatNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSupSvatNo.Name = "txtSupSvatNo";
            this.txtSupSvatNo.Size = new System.Drawing.Size(78, 21);
            this.txtSupSvatNo.TabIndex = 4;
            // 
            // txtSupVatNo
            // 
            this.txtSupVatNo.Location = new System.Drawing.Point(532, 45);
            this.txtSupVatNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSupVatNo.Name = "txtSupVatNo";
            this.txtSupVatNo.Size = new System.Drawing.Size(78, 21);
            this.txtSupVatNo.TabIndex = 3;
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
            this.label5.Location = new System.Drawing.Point(472, 48);
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
            this.label16.Size = new System.Drawing.Size(94, 15);
            this.label16.TabIndex = 2;
            this.label16.Text = "Supplier Name*";
            // 
            // txtSupAdLine1
            // 
            this.txtSupAdLine1.Location = new System.Drawing.Point(136, 75);
            this.txtSupAdLine1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSupAdLine1.Name = "txtSupAdLine1";
            this.txtSupAdLine1.Size = new System.Drawing.Size(626, 21);
            this.txtSupAdLine1.TabIndex = 5;
            // 
            // txtSupName
            // 
            this.txtSupName.Location = new System.Drawing.Point(136, 45);
            this.txtSupName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Size = new System.Drawing.Size(329, 21);
            this.txtSupName.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmdSupExit);
            this.groupBox6.Controls.Add(this.cmdSupClear);
            this.groupBox6.Controls.Add(this.cmdSupDelete);
            this.groupBox6.Controls.Add(this.CmdSupUpdate);
            this.groupBox6.Controls.Add(this.cmdSupAdd);
            this.groupBox6.Location = new System.Drawing.Point(11, 189);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox6.Size = new System.Drawing.Size(750, 75);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            // 
            // cmdSupExit
            // 
            this.cmdSupExit.FlatAppearance.BorderSize = 0;
            this.cmdSupExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSupExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSupExit.Image = global::MPLSMS.Properties.Resources.exit;
            this.cmdSupExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSupExit.Location = new System.Drawing.Point(616, 12);
            this.cmdSupExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdSupExit.Name = "cmdSupExit";
            this.cmdSupExit.Size = new System.Drawing.Size(122, 59);
            this.cmdSupExit.TabIndex = 18;
            this.cmdSupExit.Text = "Exit";
            this.cmdSupExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSupExit.UseVisualStyleBackColor = true;
            this.cmdSupExit.Click += new System.EventHandler(this.cmdSupExit_Click);
            // 
            // cmdSupClear
            // 
            this.cmdSupClear.FlatAppearance.BorderSize = 0;
            this.cmdSupClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSupClear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSupClear.Image = global::MPLSMS.Properties.Resources.clear;
            this.cmdSupClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSupClear.Location = new System.Drawing.Point(310, 12);
            this.cmdSupClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdSupClear.Name = "cmdSupClear";
            this.cmdSupClear.Size = new System.Drawing.Size(122, 59);
            this.cmdSupClear.TabIndex = 16;
            this.cmdSupClear.Text = "Clear";
            this.cmdSupClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSupClear.UseVisualStyleBackColor = true;
            this.cmdSupClear.Click += new System.EventHandler(this.cmdSupClear_Click);
            // 
            // cmdSupDelete
            // 
            this.cmdSupDelete.FlatAppearance.BorderSize = 0;
            this.cmdSupDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSupDelete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSupDelete.Image = global::MPLSMS.Properties.Resources.delete;
            this.cmdSupDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSupDelete.Location = new System.Drawing.Point(463, 12);
            this.cmdSupDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdSupDelete.Name = "cmdSupDelete";
            this.cmdSupDelete.Size = new System.Drawing.Size(122, 59);
            this.cmdSupDelete.TabIndex = 17;
            this.cmdSupDelete.Text = "Delete";
            this.cmdSupDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSupDelete.UseVisualStyleBackColor = true;
            this.cmdSupDelete.Click += new System.EventHandler(this.cmdSupEdit_Click);
            // 
            // CmdSupUpdate
            // 
            this.CmdSupUpdate.FlatAppearance.BorderSize = 0;
            this.CmdSupUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSupUpdate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSupUpdate.Image = global::MPLSMS.Properties.Resources.Add1;
            this.CmdSupUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdSupUpdate.Location = new System.Drawing.Point(157, 12);
            this.CmdSupUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmdSupUpdate.Name = "CmdSupUpdate";
            this.CmdSupUpdate.Size = new System.Drawing.Size(122, 59);
            this.CmdSupUpdate.TabIndex = 15;
            this.CmdSupUpdate.Text = "Update";
            this.CmdSupUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdSupUpdate.UseVisualStyleBackColor = true;
            this.CmdSupUpdate.Click += new System.EventHandler(this.CmdSupUpdate_Click);
            // 
            // cmdSupAdd
            // 
            this.cmdSupAdd.AutoEllipsis = true;
            this.cmdSupAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdSupAdd.FlatAppearance.BorderSize = 0;
            this.cmdSupAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSupAdd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSupAdd.Image = global::MPLSMS.Properties.Resources.Add;
            this.cmdSupAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSupAdd.Location = new System.Drawing.Point(4, 12);
            this.cmdSupAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdSupAdd.Name = "cmdSupAdd";
            this.cmdSupAdd.Size = new System.Drawing.Size(122, 59);
            this.cmdSupAdd.TabIndex = 14;
            this.cmdSupAdd.Text = "Add";
            this.cmdSupAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSupAdd.UseVisualStyleBackColor = true;
            this.cmdSupAdd.Click += new System.EventHandler(this.cmdSupAdd_Click);
            // 
            // txtMobNo
            // 
            this.txtMobNo.Location = new System.Drawing.Point(78, 50);
            this.txtMobNo.Mask = "(999) 000-0000";
            this.txtMobNo.Name = "txtMobNo";
            this.txtMobNo.Size = new System.Drawing.Size(94, 21);
            this.txtMobNo.TabIndex = 13;
            // 
            // txtTell
            // 
            this.txtTell.Location = new System.Drawing.Point(218, 50);
            this.txtTell.Mask = "(999) 000-0000";
            this.txtTell.Name = "txtTell";
            this.txtTell.Size = new System.Drawing.Size(94, 21);
            this.txtTell.TabIndex = 14;
            // 
            // txtFaxNo
            // 
            this.txtFaxNo.Location = new System.Drawing.Point(376, 50);
            this.txtFaxNo.Mask = "(999) 000-0000";
            this.txtFaxNo.Name = "txtFaxNo";
            this.txtFaxNo.Size = new System.Drawing.Size(94, 21);
            this.txtFaxNo.TabIndex = 15;
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 537);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Markspen Labels - Supplier";
            this.Load += new System.EventHandler(this.frmSupplier_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplir)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgSupplir;
        private System.Windows.Forms.ComboBox cboSupId;
        private System.Windows.Forms.DateTimePicker dtpSup;
        private System.Windows.Forms.CheckBox chkSupBlocked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboTitle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtConPerson;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSupSvatNo;
        private System.Windows.Forms.TextBox txtSupVatNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSupAdLine1;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button cmdSupExit;
        private System.Windows.Forms.Button cmdSupClear;
        private System.Windows.Forms.Button cmdSupDelete;
        private System.Windows.Forms.Button CmdSupUpdate;
        private System.Windows.Forms.Button cmdSupAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.MaskedTextBox txtFaxNo;
        private System.Windows.Forms.MaskedTextBox txtTell;
        private System.Windows.Forms.MaskedTextBox txtMobNo;
    }
}

