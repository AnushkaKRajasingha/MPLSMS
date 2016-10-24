namespace MPLSMS
{
    partial class frmICategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmICategory));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgICat = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtICatName = new System.Windows.Forms.TextBox();
            this.txtICatFind = new System.Windows.Forms.TextBox();
            this.txtICatID = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmdICatExit = new System.Windows.Forms.Button();
            this.cmdICatClear = new System.Windows.Forms.Button();
            this.cmdICatDelete = new System.Windows.Forms.Button();
            this.CmdICatUpdate = new System.Windows.Forms.Button();
            this.cmdICatAdd = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgICat)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgICat);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtICatName);
            this.groupBox4.Controls.Add(this.txtICatFind);
            this.groupBox4.Controls.Add(this.txtICatID);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(2, 12);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(563, 377);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // dgICat
            // 
            this.dgICat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgICat.Location = new System.Drawing.Point(24, 147);
            this.dgICat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgICat.Name = "dgICat";
            this.dgICat.Size = new System.Drawing.Size(519, 220);
            this.dgICat.TabIndex = 8;
            this.dgICat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgICat_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 123);
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
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category ID*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(208, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Category Name*";
            // 
            // txtICatName
            // 
            this.txtICatName.Location = new System.Drawing.Point(314, 14);
            this.txtICatName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtICatName.MaxLength = 100;
            this.txtICatName.Name = "txtICatName";
            this.txtICatName.Size = new System.Drawing.Size(229, 20);
            this.txtICatName.TabIndex = 1;
            // 
            // txtICatFind
            // 
            this.txtICatFind.Location = new System.Drawing.Point(55, 121);
            this.txtICatFind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtICatFind.MaxLength = 12;
            this.txtICatFind.Name = "txtICatFind";
            this.txtICatFind.Size = new System.Drawing.Size(196, 20);
            this.txtICatFind.TabIndex = 7;
            this.txtICatFind.TextChanged += new System.EventHandler(this.txtICatFind_TextChanged);
            // 
            // txtICatID
            // 
            this.txtICatID.Enabled = false;
            this.txtICatID.Location = new System.Drawing.Point(101, 14);
            this.txtICatID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtICatID.Name = "txtICatID";
            this.txtICatID.Size = new System.Drawing.Size(74, 20);
            this.txtICatID.TabIndex = 9;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmdICatExit);
            this.groupBox6.Controls.Add(this.cmdICatClear);
            this.groupBox6.Controls.Add(this.cmdICatDelete);
            this.groupBox6.Controls.Add(this.CmdICatUpdate);
            this.groupBox6.Controls.Add(this.cmdICatAdd);
            this.groupBox6.Location = new System.Drawing.Point(20, 40);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox6.Size = new System.Drawing.Size(528, 75);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            // 
            // cmdICatExit
            // 
            this.cmdICatExit.FlatAppearance.BorderSize = 0;
            this.cmdICatExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdICatExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdICatExit.Image = global::MPLSMS.Properties.Resources.exit;
            this.cmdICatExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdICatExit.Location = new System.Drawing.Point(426, 12);
            this.cmdICatExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdICatExit.Name = "cmdICatExit";
            this.cmdICatExit.Size = new System.Drawing.Size(97, 59);
            this.cmdICatExit.TabIndex = 6;
            this.cmdICatExit.Text = "Exit";
            this.cmdICatExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdICatExit.UseVisualStyleBackColor = true;
            this.cmdICatExit.Click += new System.EventHandler(this.cmdICatExit_Click);
            // 
            // cmdICatClear
            // 
            this.cmdICatClear.FlatAppearance.BorderSize = 0;
            this.cmdICatClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdICatClear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdICatClear.Image = global::MPLSMS.Properties.Resources.clear;
            this.cmdICatClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdICatClear.Location = new System.Drawing.Point(226, 12);
            this.cmdICatClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdICatClear.Name = "cmdICatClear";
            this.cmdICatClear.Size = new System.Drawing.Size(103, 59);
            this.cmdICatClear.TabIndex = 4;
            this.cmdICatClear.Text = "Clear";
            this.cmdICatClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdICatClear.UseVisualStyleBackColor = true;
            this.cmdICatClear.Click += new System.EventHandler(this.cmdICatClear_Click);
            // 
            // cmdICatDelete
            // 
            this.cmdICatDelete.FlatAppearance.BorderSize = 0;
            this.cmdICatDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdICatDelete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdICatDelete.Image = global::MPLSMS.Properties.Resources.delete;
            this.cmdICatDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdICatDelete.Location = new System.Drawing.Point(326, 12);
            this.cmdICatDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdICatDelete.Name = "cmdICatDelete";
            this.cmdICatDelete.Size = new System.Drawing.Size(110, 59);
            this.cmdICatDelete.TabIndex = 5;
            this.cmdICatDelete.Text = "Delete";
            this.cmdICatDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdICatDelete.UseVisualStyleBackColor = true;
            this.cmdICatDelete.Click += new System.EventHandler(this.cmdICatDelete_Click);
            // 
            // CmdICatUpdate
            // 
            this.CmdICatUpdate.FlatAppearance.BorderSize = 0;
            this.CmdICatUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdICatUpdate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdICatUpdate.Image = global::MPLSMS.Properties.Resources.Add1;
            this.CmdICatUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdICatUpdate.Location = new System.Drawing.Point(106, 12);
            this.CmdICatUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmdICatUpdate.Name = "CmdICatUpdate";
            this.CmdICatUpdate.Size = new System.Drawing.Size(122, 59);
            this.CmdICatUpdate.TabIndex = 3;
            this.CmdICatUpdate.Text = "Update";
            this.CmdICatUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdICatUpdate.UseVisualStyleBackColor = true;
            this.CmdICatUpdate.Click += new System.EventHandler(this.CmdICatUpdate_Click);
            // 
            // cmdICatAdd
            // 
            this.cmdICatAdd.AutoEllipsis = true;
            this.cmdICatAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdICatAdd.FlatAppearance.BorderSize = 0;
            this.cmdICatAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdICatAdd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdICatAdd.Image = global::MPLSMS.Properties.Resources.Add;
            this.cmdICatAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdICatAdd.Location = new System.Drawing.Point(4, 12);
            this.cmdICatAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdICatAdd.Name = "cmdICatAdd";
            this.cmdICatAdd.Size = new System.Drawing.Size(103, 59);
            this.cmdICatAdd.TabIndex = 2;
            this.cmdICatAdd.Text = "Add";
            this.cmdICatAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdICatAdd.UseVisualStyleBackColor = true;
            this.cmdICatAdd.Click += new System.EventHandler(this.cmdICatAdd_Click);
            // 
            // frmICategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 394);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmICategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ITEM CATEGORY - MARKSPEN LABELS";
            this.Load += new System.EventHandler(this.frmICategory_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgICat)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtICatName;
        private System.Windows.Forms.TextBox txtICatFind;
        private System.Windows.Forms.TextBox txtICatID;
        private System.Windows.Forms.DataGridView dgICat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button cmdICatExit;
        private System.Windows.Forms.Button cmdICatClear;
        private System.Windows.Forms.Button cmdICatDelete;
        private System.Windows.Forms.Button CmdICatUpdate;
        private System.Windows.Forms.Button cmdICatAdd;
    }
}