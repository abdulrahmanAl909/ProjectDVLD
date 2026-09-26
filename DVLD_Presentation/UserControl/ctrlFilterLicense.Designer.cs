namespace DVLD_Presentation
{
    partial class ctrlFilterLicense
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFilterLicense = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFilterLicense = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlLicenseDetails2 = new DVLD_Presentation.ctrlLicenseDetails();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.txtFilterLicense);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter License";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFilter.BackgroundImage = global::DVLD_Presentation.Properties.Resources.manage_application_64x64_1_;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFilter.Location = new System.Drawing.Point(538, 46);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 49);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // txtFilterLicense
            // 
            this.txtFilterLicense.BackColor = System.Drawing.Color.SteelBlue;
            this.txtFilterLicense.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtFilterLicense.Location = new System.Drawing.Point(148, 59);
            this.txtFilterLicense.Name = "txtFilterLicense";
            this.txtFilterLicense.Size = new System.Drawing.Size(374, 27);
            this.txtFilterLicense.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(10, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "License ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFilterLicense);
            this.groupBox2.Controls.Add(this.txtFilter);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(9, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(796, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter License";
            // 
            // btnFilterLicense
            // 
            this.btnFilterLicense.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFilterLicense.BackgroundImage = global::DVLD_Presentation.Properties.Resources.manage_application_64x64_1_;
            this.btnFilterLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFilterLicense.Location = new System.Drawing.Point(433, 39);
            this.btnFilterLicense.Name = "btnFilterLicense";
            this.btnFilterLicense.Size = new System.Drawing.Size(75, 52);
            this.btnFilterLicense.TabIndex = 2;
            this.btnFilterLicense.UseVisualStyleBackColor = false;
            this.btnFilterLicense.Click += new System.EventHandler(this.btnFilterLicense_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.Color.SteelBlue;
            this.txtFilter.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtFilter.ForeColor = System.Drawing.Color.White;
            this.txtFilter.Location = new System.Drawing.Point(154, 51);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(264, 32);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterBy_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(28, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "License ID:";
            // 
            // ctrlLicenseDetails2
            // 
            this.ctrlLicenseDetails2.BackColor = System.Drawing.Color.SteelBlue;
            this.ctrlLicenseDetails2.Location = new System.Drawing.Point(0, 121);
            this.ctrlLicenseDetails2.Name = "ctrlLicenseDetails2";
            this.ctrlLicenseDetails2.Size = new System.Drawing.Size(821, 547);
            this.ctrlLicenseDetails2.TabIndex = 0;
            // 
            // ctrlFilterLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ctrlLicenseDetails2);
            this.Name = "ctrlFilterLicense";
            this.Size = new System.Drawing.Size(824, 668);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFilterLicense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilter;
        private ctrlLicenseDetails ctrlLicenseDetails1;
        private ctrlLicenseDetails ctrlLicenseDetails2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFilterLicense;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label2;
    }
}
