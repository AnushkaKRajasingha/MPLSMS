namespace MPLSMS
{
    partial class frmCUSPODetails
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
            this.dgCusPoDetails = new System.Windows.Forms.DataGridView();
            this.txtPONumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCusPoDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCusPoDetails
            // 
            this.dgCusPoDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCusPoDetails.Location = new System.Drawing.Point(12, 42);
            this.dgCusPoDetails.Name = "dgCusPoDetails";
            this.dgCusPoDetails.Size = new System.Drawing.Size(548, 370);
            this.dgCusPoDetails.TabIndex = 0;
            // 
            // txtPONumber
            // 
            this.txtPONumber.Location = new System.Drawing.Point(82, 12);
            this.txtPONumber.Name = "txtPONumber";
            this.txtPONumber.Size = new System.Drawing.Size(181, 20);
            this.txtPONumber.TabIndex = 8;
            this.txtPONumber.TextChanged += new System.EventHandler(this.txtPONumber_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "PO Number";
            // 
            // frmCUSPODetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 424);
            this.Controls.Add(this.txtPONumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgCusPoDetails);
            this.Name = "frmCUSPODetails";
            this.Text = "Customer Purchase Order Details";
            this.Load += new System.EventHandler(this.frmCUSPODetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCusPoDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCusPoDetails;
        private System.Windows.Forms.TextBox txtPONumber;
        private System.Windows.Forms.Label label1;
    }
}