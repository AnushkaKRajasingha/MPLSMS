namespace MPLSMS
{
    partial class frmSRole
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgSRole = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.txtSroleFind = new System.Windows.Forms.TextBox();
            this.txtRoleID = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmdSRoleExit = new System.Windows.Forms.Button();
            this.cmdSRoleClear = new System.Windows.Forms.Button();
            this.cmdSRoleDelete = new System.Windows.Forms.Button();
            this.CmdSRoleUpdate = new System.Windows.Forms.Button();
            this.cmdSRoleAdd = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSRole)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgSRole);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtDescription);
            this.groupBox4.Controls.Add(this.txtRoleName);
            this.groupBox4.Controls.Add(this.txtSroleFind);
            this.groupBox4.Controls.Add(this.txtRoleID);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(5, 3);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(563, 413);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Staff Role";
            // 
            // dgSRole
            // 
            this.dgSRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSRole.Location = new System.Drawing.Point(20, 182);
            this.dgSRole.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgSRole.Name = "dgSRole";
            this.dgSRole.Size = new System.Drawing.Size(528, 220);
            this.dgSRole.TabIndex = 19;
            this.dgSRole.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSRole_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 159);
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
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Role ID*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 52);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(178, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Role Name*";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(90, 49);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescription.MaxLength = 50;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(458, 20);
            this.txtDescription.TabIndex = 17;
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(255, 14);
            this.txtRoleName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRoleName.MaxLength = 12;
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(288, 20);
            this.txtRoleName.TabIndex = 17;
            // 
            // txtSroleFind
            // 
            this.txtSroleFind.Location = new System.Drawing.Point(55, 156);
            this.txtSroleFind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSroleFind.MaxLength = 12;
            this.txtSroleFind.Name = "txtSroleFind";
            this.txtSroleFind.Size = new System.Drawing.Size(196, 20);
            this.txtSroleFind.TabIndex = 17;
            this.txtSroleFind.TextChanged += new System.EventHandler(this.txtSroleFind_TextChanged);
            // 
            // txtRoleID
            // 
            this.txtRoleID.Location = new System.Drawing.Point(92, 14);
            this.txtRoleID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRoleID.Name = "txtRoleID";
            this.txtRoleID.Size = new System.Drawing.Size(74, 20);
            this.txtRoleID.TabIndex = 20;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmdSRoleExit);
            this.groupBox6.Controls.Add(this.cmdSRoleClear);
            this.groupBox6.Controls.Add(this.cmdSRoleDelete);
            this.groupBox6.Controls.Add(this.CmdSRoleUpdate);
            this.groupBox6.Controls.Add(this.cmdSRoleAdd);
            this.groupBox6.Location = new System.Drawing.Point(20, 75);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox6.Size = new System.Drawing.Size(528, 75);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            // 
            // cmdSRoleExit
            // 
            this.cmdSRoleExit.FlatAppearance.BorderSize = 0;
            this.cmdSRoleExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSRoleExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSRoleExit.Image = global::MPLSMS.Properties.Resources.exit;
            this.cmdSRoleExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSRoleExit.Location = new System.Drawing.Point(426, 12);
            this.cmdSRoleExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdSRoleExit.Name = "cmdSRoleExit";
            this.cmdSRoleExit.Size = new System.Drawing.Size(97, 59);
            this.cmdSRoleExit.TabIndex = 16;
            this.cmdSRoleExit.Text = "Exit";
            this.cmdSRoleExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSRoleExit.UseVisualStyleBackColor = true;
            this.cmdSRoleExit.Click += new System.EventHandler(this.cmdSRoleExit_Click);
            // 
            // cmdSRoleClear
            // 
            this.cmdSRoleClear.FlatAppearance.BorderSize = 0;
            this.cmdSRoleClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSRoleClear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSRoleClear.Image = global::MPLSMS.Properties.Resources.clear;
            this.cmdSRoleClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSRoleClear.Location = new System.Drawing.Point(226, 12);
            this.cmdSRoleClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdSRoleClear.Name = "cmdSRoleClear";
            this.cmdSRoleClear.Size = new System.Drawing.Size(103, 59);
            this.cmdSRoleClear.TabIndex = 14;
            this.cmdSRoleClear.Text = "Clear";
            this.cmdSRoleClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSRoleClear.UseVisualStyleBackColor = true;
            this.cmdSRoleClear.Click += new System.EventHandler(this.cmdSRoleClear_Click);
            // 
            // cmdSRoleDelete
            // 
            this.cmdSRoleDelete.FlatAppearance.BorderSize = 0;
            this.cmdSRoleDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSRoleDelete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSRoleDelete.Image = global::MPLSMS.Properties.Resources.delete;
            this.cmdSRoleDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSRoleDelete.Location = new System.Drawing.Point(326, 12);
            this.cmdSRoleDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdSRoleDelete.Name = "cmdSRoleDelete";
            this.cmdSRoleDelete.Size = new System.Drawing.Size(110, 59);
            this.cmdSRoleDelete.TabIndex = 15;
            this.cmdSRoleDelete.Text = "Delete";
            this.cmdSRoleDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSRoleDelete.UseVisualStyleBackColor = true;
            this.cmdSRoleDelete.Click += new System.EventHandler(this.cmdSRoleDelete_Click);
            // 
            // CmdSRoleUpdate
            // 
            this.CmdSRoleUpdate.FlatAppearance.BorderSize = 0;
            this.CmdSRoleUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSRoleUpdate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSRoleUpdate.Image = global::MPLSMS.Properties.Resources.Add1;
            this.CmdSRoleUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdSRoleUpdate.Location = new System.Drawing.Point(106, 12);
            this.CmdSRoleUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmdSRoleUpdate.Name = "CmdSRoleUpdate";
            this.CmdSRoleUpdate.Size = new System.Drawing.Size(122, 59);
            this.CmdSRoleUpdate.TabIndex = 13;
            this.CmdSRoleUpdate.Text = "Update";
            this.CmdSRoleUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdSRoleUpdate.UseVisualStyleBackColor = true;
            this.CmdSRoleUpdate.Click += new System.EventHandler(this.CmdSRoleUpdate_Click);
            // 
            // cmdSRoleAdd
            // 
            this.cmdSRoleAdd.AutoEllipsis = true;
            this.cmdSRoleAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdSRoleAdd.FlatAppearance.BorderSize = 0;
            this.cmdSRoleAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSRoleAdd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSRoleAdd.Image = global::MPLSMS.Properties.Resources.Add;
            this.cmdSRoleAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSRoleAdd.Location = new System.Drawing.Point(4, 12);
            this.cmdSRoleAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdSRoleAdd.Name = "cmdSRoleAdd";
            this.cmdSRoleAdd.Size = new System.Drawing.Size(103, 59);
            this.cmdSRoleAdd.TabIndex = 12;
            this.cmdSRoleAdd.Text = "Add";
            this.cmdSRoleAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSRoleAdd.UseVisualStyleBackColor = true;
            this.cmdSRoleAdd.Click += new System.EventHandler(this.cmdSRoleAdd_Click);
            // 
            // frmSRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 421);
            this.Controls.Add(this.groupBox4);
            this.Name = "frmSRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STAFF ROLE- MARKSPEN LABELS";
            this.Load += new System.EventHandler(this.frmSRole_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSRole)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgSRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.TextBox txtSroleFind;
        private System.Windows.Forms.TextBox txtRoleID;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button cmdSRoleExit;
        private System.Windows.Forms.Button cmdSRoleClear;
        private System.Windows.Forms.Button cmdSRoleDelete;
        private System.Windows.Forms.Button CmdSRoleUpdate;
        private System.Windows.Forms.Button cmdSRoleAdd;

    }
}