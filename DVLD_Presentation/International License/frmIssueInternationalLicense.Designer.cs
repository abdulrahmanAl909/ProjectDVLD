namespace DVLD_Presentation
{
    partial class frmIssueInternationalLicense
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.llLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.llLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.ctrlApplicationInfo1 = new DVLD_Presentation.ctrlApplicationInfo();
            this.ctrlFilterLicense1 = new DVLD_Presentation.ctrlFilterLicense();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "International License Application";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(501, 950);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(153, 50);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.Color.SteelBlue;
            this.btnIssue.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnIssue.ForeColor = System.Drawing.Color.White;
            this.btnIssue.Location = new System.Drawing.Point(669, 950);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(153, 50);
            this.btnIssue.TabIndex = 2;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = false;
            // 
            // llLicenseHistory
            // 
            this.llLicenseHistory.AutoSize = true;
            this.llLicenseHistory.Font = new System.Drawing.Font("Tahoma", 12F);
            this.llLicenseHistory.Location = new System.Drawing.Point(14, 958);
            this.llLicenseHistory.Name = "llLicenseHistory";
            this.llLicenseHistory.Size = new System.Drawing.Size(249, 29);
            this.llLicenseHistory.TabIndex = 3;
            this.llLicenseHistory.TabStop = true;
            this.llLicenseHistory.Text = "Show Licenses History";
            // 
            // llLicenseInfo
            // 
            this.llLicenseInfo.AutoSize = true;
            this.llLicenseInfo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.llLicenseInfo.Location = new System.Drawing.Point(269, 958);
            this.llLicenseInfo.Name = "llLicenseInfo";
            this.llLicenseInfo.Size = new System.Drawing.Size(142, 29);
            this.llLicenseInfo.TabIndex = 4;
            this.llLicenseInfo.TabStop = true;
            this.llLicenseInfo.Text = "License Info";
            // 
            // ctrlApplicationInfo1
            // 
            this.ctrlApplicationInfo1.BackColor = System.Drawing.Color.SteelBlue;
            this.ctrlApplicationInfo1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.ctrlApplicationInfo1.Location = new System.Drawing.Point(12, 702);
            this.ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            this.ctrlApplicationInfo1.Size = new System.Drawing.Size(826, 242);
            this.ctrlApplicationInfo1.TabIndex = 6;
            // 
            // ctrlFilterLicense1
            // 
            this.ctrlFilterLicense1.BackColor = System.Drawing.Color.SteelBlue;
            this.ctrlFilterLicense1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.ctrlFilterLicense1.Location = new System.Drawing.Point(8, 55);
            this.ctrlFilterLicense1.Name = "ctrlFilterLicense1";
            this.ctrlFilterLicense1.Size = new System.Drawing.Size(811, 657);
            this.ctrlFilterLicense1.TabIndex = 5;
            // 
            // frmIssueInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(829, 1005);
            this.Controls.Add(this.ctrlApplicationInfo1);
            this.Controls.Add(this.ctrlFilterLicense1);
            this.Controls.Add(this.llLicenseInfo);
            this.Controls.Add(this.llLicenseHistory);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Name = "frmIssueInternationalLicense";
            this.Text = "frmInternationalLicense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.LinkLabel llLicenseHistory;
        private System.Windows.Forms.LinkLabel llLicenseInfo;
        private ctrlFilterLicense ctrlFilterLicense1;
        private ctrlApplicationInfo ctrlApplicationInfo1;
    }
}