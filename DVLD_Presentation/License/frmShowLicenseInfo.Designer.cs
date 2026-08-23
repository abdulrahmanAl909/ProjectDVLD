namespace DVLD_Presentation
{
    partial class frmShowLicenseInfo
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
            this.ctrlLicenseDetails1 = new DVLD_Presentation.ctrlLicenseDetails();
            this.SuspendLayout();
            // 
            // ctrlLicenseDetails1
            // 
            this.ctrlLicenseDetails1.BackColor = System.Drawing.Color.SteelBlue;
            this.ctrlLicenseDetails1.Location = new System.Drawing.Point(4, 150);
            this.ctrlLicenseDetails1.Name = "ctrlLicenseDetails1";
            this.ctrlLicenseDetails1.Size = new System.Drawing.Size(849, 551);
            this.ctrlLicenseDetails1.TabIndex = 3;
            // 
            // frmShowLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(861, 701);
            this.Controls.Add(this.ctrlLicenseDetails1);
            this.Name = "frmShowLicenseInfo";
            this.Text = "frmShowLicenseInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlLicenseDetails ctrlLicenseDetails1;
    }
}