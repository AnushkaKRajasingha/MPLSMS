namespace MPLSMS
{
    partial class frmInvoice
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
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.cboCusName = new System.Windows.Forms.ComboBox();
            this.cboCusNo = new System.Windows.Forms.ComboBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNbtA = new System.Windows.Forms.TextBox();
            this.txtNbt = new System.Windows.Forms.TextBox();
            this.cboDecountP = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVATP = new System.Windows.Forms.TextBox();
            this.txtGT = new System.Windows.Forms.TextBox();
            this.txtVATA = new System.Windows.Forms.TextBox();
            this.txtDisA = new System.Windows.Forms.TextBox();
            this.txtSubTot = new System.Windows.Forms.TextBox();
            this.cmdStMi = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdStAdd = new System.Windows.Forms.Button();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPODate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgInvoice = new System.Windows.Forms.DataGridView();
            this.cboInvoiceType = new System.Windows.Forms.ComboBox();
            this.cboPONo = new System.Windows.Forms.ComboBox();
            this.txtLineAmount = new System.Windows.Forms.TextBox();
            this.txtOrderQty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItemDes = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.txtCurrentBalance = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblviewPO = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmdItemClear = new System.Windows.Forms.Button();
            this.cmdItemDelete = new System.Windows.Forms.Button();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoice)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.CustomFormat = "";
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(601, 40);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(97, 20);
            this.dtpInvoiceDate.TabIndex = 5;
            // 
            // cboCusName
            // 
            this.cboCusName.FormattingEnabled = true;
            this.cboCusName.Location = new System.Drawing.Point(205, 14);
            this.cboCusName.Name = "cboCusName";
            this.cboCusName.Size = new System.Drawing.Size(309, 21);
            this.cboCusName.TabIndex = 2;
            // 
            // cboCusNo
            // 
            this.cboCusNo.FormattingEnabled = true;
            this.cboCusNo.Location = new System.Drawing.Point(92, 14);
            this.cboCusNo.Name = "cboCusNo";
            this.cboCusNo.Size = new System.Drawing.Size(88, 21);
            this.cboCusNo.Sorted = true;
            this.cboCusNo.TabIndex = 1;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(407, 150);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(70, 20);
            this.txtUnitPrice.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtNbtA);
            this.groupBox4.Controls.Add(this.txtNbt);
            this.groupBox4.Controls.Add(this.cboDecountP);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtVATP);
            this.groupBox4.Controls.Add(this.txtGT);
            this.groupBox4.Controls.Add(this.txtVATA);
            this.groupBox4.Controls.Add(this.txtDisA);
            this.groupBox4.Controls.Add(this.txtSubTot);
            this.groupBox4.Controls.Add(this.cmdStMi);
            this.groupBox4.Controls.Add(this.dtpInvoiceDate);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.cmdStAdd);
            this.groupBox4.Controls.Add(this.txtInvoiceNo);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.txtPODate);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.dgInvoice);
            this.groupBox4.Controls.Add(this.cboCusName);
            this.groupBox4.Controls.Add(this.cboInvoiceType);
            this.groupBox4.Controls.Add(this.cboPONo);
            this.groupBox4.Controls.Add(this.cboCusNo);
            this.groupBox4.Controls.Add(this.txtUnitPrice);
            this.groupBox4.Controls.Add(this.txtLineAmount);
            this.groupBox4.Controls.Add(this.txtOrderQty);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtItemDes);
            this.groupBox4.Controls.Add(this.txtItemID);
            this.groupBox4.Controls.Add(this.txtCurrentBalance);
            this.groupBox4.Controls.Add(this.txtBarcode);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.lblviewPO);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(721, 489);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // txtNbtA
            // 
            this.txtNbtA.Location = new System.Drawing.Point(546, 435);
            this.txtNbtA.Name = "txtNbtA";
            this.txtNbtA.ReadOnly = true;
            this.txtNbtA.Size = new System.Drawing.Size(93, 20);
            this.txtNbtA.TabIndex = 46;
            this.txtNbtA.Text = "0";
            this.txtNbtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNbtA.TextChanged += new System.EventHandler(this.txtNbtA_TextChanged);
            // 
            // txtNbt
            // 
            this.txtNbt.Location = new System.Drawing.Point(471, 437);
            this.txtNbt.Name = "txtNbt";
            this.txtNbt.Size = new System.Drawing.Size(43, 20);
            this.txtNbt.TabIndex = 45;
            this.txtNbt.Text = "2";
            this.txtNbt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboDecountP
            // 
            this.cboDecountP.FormattingEnabled = true;
            this.cboDecountP.Items.AddRange(new object[] {
            "0",
            "10",
            "15"});
            this.cboDecountP.Location = new System.Drawing.Point(471, 374);
            this.cboDecountP.Name = "cboDecountP";
            this.cboDecountP.Size = new System.Drawing.Size(43, 21);
            this.cboDecountP.TabIndex = 39;
            this.cboDecountP.SelectedIndexChanged += new System.EventHandler(this.cboDecountP_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(517, 377);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 15);
            this.label15.TabIndex = 37;
            this.label15.Text = "%";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(517, 438);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(16, 15);
            this.label21.TabIndex = 38;
            this.label21.Text = "%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(517, 408);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 15);
            this.label14.TabIndex = 38;
            this.label14.Text = "%";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(408, 408);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 15);
            this.label13.TabIndex = 33;
            this.label13.Text = "VAT";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(408, 377);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 15);
            this.label12.TabIndex = 34;
            this.label12.Text = "Discount";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(408, 466);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 15);
            this.label20.TabIndex = 36;
            this.label20.Text = "Total";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(408, 439);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 15);
            this.label17.TabIndex = 36;
            this.label17.Text = "NBT";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(408, 346);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 15);
            this.label11.TabIndex = 35;
            this.label11.Text = "Sub Total";
            // 
            // txtVATP
            // 
            this.txtVATP.Location = new System.Drawing.Point(471, 405);
            this.txtVATP.Name = "txtVATP";
            this.txtVATP.Size = new System.Drawing.Size(43, 20);
            this.txtVATP.TabIndex = 43;
            this.txtVATP.Text = "12";
            this.txtVATP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGT
            // 
            this.txtGT.Location = new System.Drawing.Point(546, 463);
            this.txtGT.Name = "txtGT";
            this.txtGT.ReadOnly = true;
            this.txtGT.Size = new System.Drawing.Size(93, 20);
            this.txtGT.TabIndex = 44;
            this.txtGT.Text = "0";
            this.txtGT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGT.TextChanged += new System.EventHandler(this.txtGT_TextChanged);
            // 
            // txtVATA
            // 
            this.txtVATA.Location = new System.Drawing.Point(546, 405);
            this.txtVATA.Name = "txtVATA";
            this.txtVATA.ReadOnly = true;
            this.txtVATA.Size = new System.Drawing.Size(93, 20);
            this.txtVATA.TabIndex = 42;
            this.txtVATA.Text = "0";
            this.txtVATA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVATA.TextChanged += new System.EventHandler(this.txtVATA_TextChanged);
            // 
            // txtDisA
            // 
            this.txtDisA.Location = new System.Drawing.Point(546, 374);
            this.txtDisA.Name = "txtDisA";
            this.txtDisA.ReadOnly = true;
            this.txtDisA.Size = new System.Drawing.Size(93, 20);
            this.txtDisA.TabIndex = 40;
            this.txtDisA.Text = "0";
            this.txtDisA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisA.TextChanged += new System.EventHandler(this.txtDisA_TextChanged);
            // 
            // txtSubTot
            // 
            this.txtSubTot.Location = new System.Drawing.Point(546, 343);
            this.txtSubTot.Name = "txtSubTot";
            this.txtSubTot.ReadOnly = true;
            this.txtSubTot.Size = new System.Drawing.Size(93, 20);
            this.txtSubTot.TabIndex = 9;
            this.txtSubTot.Text = "0";
            this.txtSubTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubTot.TextChanged += new System.EventHandler(this.txtSubTot_TextChanged);
            // 
            // cmdStMi
            // 
            this.cmdStMi.Image = global::MPLSMS.Properties.Resources.Add2;
            this.cmdStMi.Location = new System.Drawing.Point(652, 232);
            this.cmdStMi.Name = "cmdStMi";
            this.cmdStMi.Size = new System.Drawing.Size(46, 40);
            this.cmdStMi.TabIndex = 0;
            this.cmdStMi.UseVisualStyleBackColor = true;
            this.cmdStMi.Click += new System.EventHandler(this.cmdStMi_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(521, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 15);
            this.label18.TabIndex = 27;
            this.label18.Text = "Invoice No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(517, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Invoice Date";
            // 
            // cmdStAdd
            // 
            this.cmdStAdd.Image = global::MPLSMS.Properties.Resources.Add;
            this.cmdStAdd.Location = new System.Drawing.Point(652, 186);
            this.cmdStAdd.Name = "cmdStAdd";
            this.cmdStAdd.Size = new System.Drawing.Size(46, 40);
            this.cmdStAdd.TabIndex = 8;
            this.cmdStAdd.UseVisualStyleBackColor = true;
            this.cmdStAdd.Click += new System.EventHandler(this.cmdStAdd_Click);
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(601, 14);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(97, 20);
            this.txtInvoiceNo.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(562, 71);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 15);
            this.label19.TabIndex = 2;
            this.label19.Text = "Type";
            // 
            // txtPODate
            // 
            this.txtPODate.Location = new System.Drawing.Point(260, 50);
            this.txtPODate.Name = "txtPODate";
            this.txtPODate.Size = new System.Drawing.Size(91, 20);
            this.txtPODate.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(202, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "PO Date";
            // 
            // dgInvoice
            // 
            this.dgInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInvoice.Location = new System.Drawing.Point(12, 177);
            this.dgInvoice.Name = "dgInvoice";
            this.dgInvoice.Size = new System.Drawing.Size(634, 161);
            this.dgInvoice.TabIndex = 0;
            // 
            // cboInvoiceType
            // 
            this.cboInvoiceType.FormattingEnabled = true;
            this.cboInvoiceType.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.cboInvoiceType.Location = new System.Drawing.Point(601, 68);
            this.cboInvoiceType.Name = "cboInvoiceType";
            this.cboInvoiceType.Size = new System.Drawing.Size(88, 21);
            this.cboInvoiceType.Sorted = true;
            this.cboInvoiceType.TabIndex = 4;
            // 
            // cboPONo
            // 
            this.cboPONo.FormattingEnabled = true;
            this.cboPONo.Location = new System.Drawing.Point(92, 50);
            this.cboPONo.Name = "cboPONo";
            this.cboPONo.Size = new System.Drawing.Size(88, 21);
            this.cboPONo.Sorted = true;
            this.cboPONo.TabIndex = 3;
            // 
            // txtLineAmount
            // 
            this.txtLineAmount.Location = new System.Drawing.Point(565, 150);
            this.txtLineAmount.Name = "txtLineAmount";
            this.txtLineAmount.Size = new System.Drawing.Size(70, 20);
            this.txtLineAmount.TabIndex = 0;
            this.txtLineAmount.TextChanged += new System.EventHandler(this.txtLineAmount_TextChanged);
            // 
            // txtOrderQty
            // 
            this.txtOrderQty.Location = new System.Drawing.Point(486, 150);
            this.txtOrderQty.Name = "txtOrderQty";
            this.txtOrderQty.Size = new System.Drawing.Size(70, 20);
            this.txtOrderQty.TabIndex = 7;
            this.txtOrderQty.TextChanged += new System.EventHandler(this.txtOrderQty_TextChanged);
            this.txtOrderQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrderQty_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Unit Price";
            // 
            // txtItemDes
            // 
            this.txtItemDes.Location = new System.Drawing.Point(137, 151);
            this.txtItemDes.Name = "txtItemDes";
            this.txtItemDes.Size = new System.Drawing.Size(264, 20);
            this.txtItemDes.TabIndex = 0;
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(12, 150);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(119, 20);
            this.txtItemID.TabIndex = 0;
            // 
            // txtCurrentBalance
            // 
            this.txtCurrentBalance.Location = new System.Drawing.Point(377, 93);
            this.txtCurrentBalance.Name = "txtCurrentBalance";
            this.txtCurrentBalance.Size = new System.Drawing.Size(78, 20);
            this.txtCurrentBalance.TabIndex = 0;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(90, 93);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(181, 20);
            this.txtBarcode.TabIndex = 6;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(587, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(504, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "QTY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Item Description";
            // 
            // lblviewPO
            // 
            this.lblviewPO.AutoSize = true;
            this.lblviewPO.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblviewPO.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblviewPO.Location = new System.Drawing.Point(361, 55);
            this.lblviewPO.Name = "lblviewPO";
            this.lblviewPO.Size = new System.Drawing.Size(54, 15);
            this.lblviewPO.TabIndex = 2;
            this.lblviewPO.Text = "View PO";
            this.lblviewPO.Click += new System.EventHandler(this.lblviewPO_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(277, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Current Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barcode";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "PO No:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 15);
            this.label16.TabIndex = 2;
            this.label16.Text = "Customer";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmdItemClear);
            this.groupBox6.Controls.Add(this.cmdItemDelete);
            this.groupBox6.Controls.Add(this.cmdPrint);
            this.groupBox6.Controls.Add(this.cmdExit);
            this.groupBox6.Controls.Add(this.cmdSave);
            this.groupBox6.Location = new System.Drawing.Point(6, 344);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox6.Size = new System.Drawing.Size(386, 139);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = ";";
            // 
            // cmdItemClear
            // 
            this.cmdItemClear.FlatAppearance.BorderSize = 0;
            this.cmdItemClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdItemClear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdItemClear.Image = global::MPLSMS.Properties.Resources.clear;
            this.cmdItemClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdItemClear.Location = new System.Drawing.Point(13, 75);
            this.cmdItemClear.Name = "cmdItemClear";
            this.cmdItemClear.Size = new System.Drawing.Size(107, 52);
            this.cmdItemClear.TabIndex = 19;
            this.cmdItemClear.Text = "Clear";
            this.cmdItemClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdItemClear.UseVisualStyleBackColor = true;
            this.cmdItemClear.Click += new System.EventHandler(this.cmdItemClear_Click);
            // 
            // cmdItemDelete
            // 
            this.cmdItemDelete.FlatAppearance.BorderSize = 0;
            this.cmdItemDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdItemDelete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdItemDelete.Image = global::MPLSMS.Properties.Resources.delete;
            this.cmdItemDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdItemDelete.Location = new System.Drawing.Point(137, 75);
            this.cmdItemDelete.Name = "cmdItemDelete";
            this.cmdItemDelete.Size = new System.Drawing.Size(116, 52);
            this.cmdItemDelete.TabIndex = 20;
            this.cmdItemDelete.Text = "Cancel";
            this.cmdItemDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdItemDelete.UseVisualStyleBackColor = true;
            // 
            // cmdPrint
            // 
            this.cmdPrint.FlatAppearance.BorderSize = 0;
            this.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPrint.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPrint.Image = global::MPLSMS.Properties.Resources.print;
            this.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdPrint.Location = new System.Drawing.Point(137, 13);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(107, 52);
            this.cmdPrint.TabIndex = 10;
            this.cmdPrint.Text = "Print";
            this.cmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdPrint.UseVisualStyleBackColor = true;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.FlatAppearance.BorderSize = 0;
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Image = global::MPLSMS.Properties.Resources.exit;
            this.cmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExit.Location = new System.Drawing.Point(266, 13);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(116, 52);
            this.cmdExit.TabIndex = 11;
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
            this.cmdSave.Location = new System.Drawing.Point(8, 13);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(112, 52);
            this.cmdSave.TabIndex = 9;
            this.cmdSave.Text = "Save";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 513);
            this.Controls.Add(this.groupBox4);
            this.Name = "frmInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice -MARKSPEN LABELS";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoice)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdStMi;
        private System.Windows.Forms.Button cmdStAdd;
        private System.Windows.Forms.Button cmdPrint;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.ComboBox cboCusName;
        private System.Windows.Forms.ComboBox cboCusNo;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgInvoice;
        private System.Windows.Forms.TextBox txtLineAmount;
        private System.Windows.Forms.TextBox txtOrderQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtItemDes;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.TextBox txtCurrentBalance;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtPODate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboDecountP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtVATP;
        private System.Windows.Forms.TextBox txtVATA;
        private System.Windows.Forms.TextBox txtDisA;
        private System.Windows.Forms.TextBox txtSubTot;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cboInvoiceType;
        private System.Windows.Forms.ComboBox cboPONo;
        private System.Windows.Forms.Button cmdItemClear;
        private System.Windows.Forms.Button cmdItemDelete;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtGT;
        private System.Windows.Forms.TextBox txtNbt;
        private System.Windows.Forms.TextBox txtNbtA;
        private System.Windows.Forms.Label lblviewPO;
    }
}