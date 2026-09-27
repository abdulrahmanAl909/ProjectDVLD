namespace DVLD_Presentation
{
    partial class frmRenewLicense
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
            this.ctrlFilterLicense1 = new DVLD_Presentation.ctrlFilterLicense();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblOldLicense = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCreateBy = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRenewedLicenseID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblLicenseFees = new System.Windows.Forms.Label();
            this.lblRenewApplication = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.llLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.llLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.btnRenew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlFilterLicense1
            // 
            this.ctrlFilterLicense1.BackColor = System.Drawing.Color.SteelBlue;
            this.ctrlFilterLicense1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.ctrlFilterLicense1.Location = new System.Drawing.Point(-1, -9);
            this.ctrlFilterLicense1.Name = "ctrlFilterLicense1";
            this.ctrlFilterLicense1.Size = new System.Drawing.Size(824, 654);
            this.ctrlFilterLicense1.TabIndex = 0;
            this.ctrlFilterLicense1.OnSearshForLicense += new System.Action<int>(this.ctrlFilterLicense1_OnSearshForLicense);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblOldLicense);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.lblTotalFees);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblExpirationDate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblCreateBy);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblRenewedLicenseID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblApplicationDate);
            this.groupBox1.Controls.Add(this.lblIssueDate);
            this.groupBox1.Controls.Add(this.lblApplicationFees);
            this.groupBox1.Controls.Add(this.lblLicenseFees);
            this.groupBox1.Controls.Add(this.lblRenewApplication);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 640);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 300);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application New License Info";
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.SteelBlue;
            this.txtNotes.ForeColor = System.Drawing.Color.White;
            this.txtNotes.Location = new System.Drawing.Point(114, 248);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(608, 45);
            this.txtNotes.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(26, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "Notes:";
            // 
            // lblOldLicense
            // 
            this.lblOldLicense.AutoSize = true;
            this.lblOldLicense.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblOldLicense.Location = new System.Drawing.Point(663, 78);
            this.lblOldLicense.Name = "lblOldLicense";
            this.lblOldLicense.Size = new System.Drawing.Size(46, 29);
            this.lblOldLicense.TabIndex = 19;
            this.lblOldLicense.Text = "???";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label15.Location = new System.Drawing.Point(429, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(239, 29);
            this.label15.TabIndex = 18;
            this.label15.Text = "Old License ID        :";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblTotalFees.Location = new System.Drawing.Point(663, 216);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(46, 29);
            this.lblTotalFees.TabIndex = 17;
            this.lblTotalFees.Text = "???";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label13.Location = new System.Drawing.Point(429, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(239, 29);
            this.label13.TabIndex = 16;
            this.label13.Text = "Expiration Date       :";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblExpirationDate.Location = new System.Drawing.Point(663, 128);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(46, 29);
            this.lblExpirationDate.TabIndex = 15;
            this.lblExpirationDate.Text = "???";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label11.Location = new System.Drawing.Point(429, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(237, 29);
            this.label11.TabIndex = 14;
            this.label11.Text = "Create By              :";
            // 
            // lblCreateBy
            // 
            this.lblCreateBy.AutoSize = true;
            this.lblCreateBy.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblCreateBy.Location = new System.Drawing.Point(663, 174);
            this.lblCreateBy.Name = "lblCreateBy";
            this.lblCreateBy.Size = new System.Drawing.Size(46, 29);
            this.lblCreateBy.TabIndex = 13;
            this.lblCreateBy.Text = "???";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label9.Location = new System.Drawing.Point(429, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(236, 29);
            this.label9.TabIndex = 12;
            this.label9.Text = "Total Fees             :";
            // 
            // lblRenewedLicenseID
            // 
            this.lblRenewedLicenseID.AutoSize = true;
            this.lblRenewedLicenseID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblRenewedLicenseID.Location = new System.Drawing.Point(663, 30);
            this.lblRenewedLicenseID.Name = "lblRenewedLicenseID";
            this.lblRenewedLicenseID.Size = new System.Drawing.Size(46, 29);
            this.lblRenewedLicenseID.TabIndex = 11;
            this.lblRenewedLicenseID.Text = "???";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(429, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Renewed License ID:";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblApplicationDate.Location = new System.Drawing.Point(237, 78);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(46, 29);
            this.lblApplicationDate.TabIndex = 9;
            this.lblApplicationDate.Text = "???";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblIssueDate.Location = new System.Drawing.Point(237, 128);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(46, 29);
            this.lblIssueDate.TabIndex = 8;
            this.lblIssueDate.Text = "???";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblApplicationFees.Location = new System.Drawing.Point(237, 174);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(46, 29);
            this.lblApplicationFees.TabIndex = 7;
            this.lblApplicationFees.Text = "???";
            // 
            // lblLicenseFees
            // 
            this.lblLicenseFees.AutoSize = true;
            this.lblLicenseFees.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblLicenseFees.Location = new System.Drawing.Point(237, 216);
            this.lblLicenseFees.Name = "lblLicenseFees";
            this.lblLicenseFees.Size = new System.Drawing.Size(46, 29);
            this.lblLicenseFees.TabIndex = 6;
            this.lblLicenseFees.Text = "???";
            // 
            // lblRenewApplication
            // 
            this.lblRenewApplication.AutoSize = true;
            this.lblRenewApplication.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblRenewApplication.Location = new System.Drawing.Point(237, 30);
            this.lblRenewApplication.Name = "lblRenewApplication";
            this.lblRenewApplication.Size = new System.Drawing.Size(46, 29);
            this.lblRenewApplication.TabIndex = 5;
            this.lblRenewApplication.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(23, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Application Date  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(23, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Issue Date         :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(23, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Application Fees  : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(26, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "License Fees      : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "R.L.Application ID:";
            // 
            // llLicenseInfo
            // 
            this.llLicenseInfo.AutoSize = true;
            this.llLicenseInfo.Enabled = false;
            this.llLicenseInfo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.llLicenseInfo.Location = new System.Drawing.Point(273, 951);
            this.llLicenseInfo.Name = "llLicenseInfo";
            this.llLicenseInfo.Size = new System.Drawing.Size(142, 29);
            this.llLicenseInfo.TabIndex = 8;
            this.llLicenseInfo.TabStop = true;
            this.llLicenseInfo.Text = "License Info";
            this.llLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLicenseInfo_LinkClicked);
            // 
            // llLicenseHistory
            // 
            this.llLicenseHistory.AutoSize = true;
            this.llLicenseHistory.Enabled = false;
            this.llLicenseHistory.Font = new System.Drawing.Font("Tahoma", 12F);
            this.llLicenseHistory.Location = new System.Drawing.Point(18, 951);
            this.llLicenseHistory.Name = "llLicenseHistory";
            this.llLicenseHistory.Size = new System.Drawing.Size(249, 29);
            this.llLicenseHistory.TabIndex = 7;
            this.llLicenseHistory.TabStop = true;
            this.llLicenseHistory.Text = "Show Licenses History";
            this.llLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLicenseHistory_LinkClicked);
            // 
            // btnRenew
            // 
            this.btnRenew.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRenew.Enabled = false;
            this.btnRenew.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnRenew.ForeColor = System.Drawing.Color.White;
            this.btnRenew.Location = new System.Drawing.Point(660, 946);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(153, 52);
            this.btnRenew.TabIndex = 6;
            this.btnRenew.Text = "Renew";
            this.btnRenew.UseVisualStyleBackColor = false;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(501, 948);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(153, 50);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmRenewLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(825, 1000);
            this.Controls.Add(this.llLicenseInfo);
            this.Controls.Add(this.llLicenseHistory);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlFilterLicense1);
            this.Name = "frmRenewLicense";
            this.Text = "frmRenewLicense";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlFilterLicense ctrlFilterLicense1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOldLicense;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCreateBy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblRenewedLicenseID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblLicenseFees;
        private System.Windows.Forms.Label lblRenewApplication;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel llLicenseInfo;
        private System.Windows.Forms.LinkLabel llLicenseHistory;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Button btnClose;
    }
}