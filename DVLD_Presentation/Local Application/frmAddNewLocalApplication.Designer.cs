namespace DVLD_Presentation
{
    partial class frmAddNewLocalApplication
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpPersonalInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlFilterPerson1 = new DVLD_Presentation.ctrlFilterPerson();
            this.tpApplicationInfo = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbLicenseClass = new System.Windows.Forms.ComboBox();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblCteatedByUser = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpPersonalInfo.SuspendLayout();
            this.tpApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 23F);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(51, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(789, 56);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "New Local Driving Licesne Application";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPersonalInfo);
            this.tabControl1.Controls.Add(this.tpApplicationInfo);
            this.tabControl1.Location = new System.Drawing.Point(23, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(817, 613);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tpPersonalInfo
            // 
            this.tpPersonalInfo.BackColor = System.Drawing.Color.SteelBlue;
            this.tpPersonalInfo.Controls.Add(this.btnNext);
            this.tpPersonalInfo.Controls.Add(this.ctrlFilterPerson1);
            this.tpPersonalInfo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tpPersonalInfo.Location = new System.Drawing.Point(4, 28);
            this.tpPersonalInfo.Name = "tpPersonalInfo";
            this.tpPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonalInfo.Size = new System.Drawing.Size(809, 581);
            this.tpPersonalInfo.TabIndex = 0;
            this.tpPersonalInfo.Text = "Personal Info";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(643, 529);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(151, 46);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlFilterPerson1
            // 
            this.ctrlFilterPerson1.BackColor = System.Drawing.Color.SteelBlue;
            this.ctrlFilterPerson1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlFilterPerson1.Font = new System.Drawing.Font("Tahoma", 7F);
            this.ctrlFilterPerson1.Location = new System.Drawing.Point(3, 3);
            this.ctrlFilterPerson1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlFilterPerson1.Name = "ctrlFilterPerson1";
            this.ctrlFilterPerson1.PersonInfo = null;
            this.ctrlFilterPerson1.Size = new System.Drawing.Size(803, 575);
            this.ctrlFilterPerson1.TabIndex = 0;
            // 
            // tpApplicationInfo
            // 
            this.tpApplicationInfo.BackColor = System.Drawing.Color.SteelBlue;
            this.tpApplicationInfo.Controls.Add(this.pictureBox1);
            this.tpApplicationInfo.Controls.Add(this.cbLicenseClass);
            this.tpApplicationInfo.Controls.Add(this.lblApplicationDate);
            this.tpApplicationInfo.Controls.Add(this.lblCteatedByUser);
            this.tpApplicationInfo.Controls.Add(this.lblApplicationFees);
            this.tpApplicationInfo.Controls.Add(this.lblApplicationID);
            this.tpApplicationInfo.Controls.Add(this.label7);
            this.tpApplicationInfo.Controls.Add(this.label6);
            this.tpApplicationInfo.Controls.Add(this.label5);
            this.tpApplicationInfo.Controls.Add(this.label4);
            this.tpApplicationInfo.Controls.Add(this.label3);
            this.tpApplicationInfo.Controls.Add(this.label2);
            this.tpApplicationInfo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tpApplicationInfo.Location = new System.Drawing.Point(4, 28);
            this.tpApplicationInfo.Name = "tpApplicationInfo";
            this.tpApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpApplicationInfo.Size = new System.Drawing.Size(809, 581);
            this.tpApplicationInfo.TabIndex = 1;
            this.tpApplicationInfo.Text = "Application Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Presentation.Properties.Resources.photo_5769563666645717550_x;
            this.pictureBox1.Location = new System.Drawing.Point(516, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 578);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // cbLicenseClass
            // 
            this.cbLicenseClass.BackColor = System.Drawing.Color.SteelBlue;
            this.cbLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClass.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cbLicenseClass.ForeColor = System.Drawing.Color.White;
            this.cbLicenseClass.FormattingEnabled = true;
            this.cbLicenseClass.Items.AddRange(new object[] {
            "None"});
            this.cbLicenseClass.Location = new System.Drawing.Point(213, 314);
            this.cbLicenseClass.Name = "cbLicenseClass";
            this.cbLicenseClass.Size = new System.Drawing.Size(297, 27);
            this.cbLicenseClass.TabIndex = 10;
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.ForeColor = System.Drawing.Color.White;
            this.lblApplicationDate.Location = new System.Drawing.Point(220, 237);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(122, 29);
            this.lblApplicationDate.TabIndex = 9;
            this.lblApplicationDate.Text = "10/7/2026";
            // 
            // lblCteatedByUser
            // 
            this.lblCteatedByUser.AutoSize = true;
            this.lblCteatedByUser.ForeColor = System.Drawing.Color.White;
            this.lblCteatedByUser.Location = new System.Drawing.Point(220, 439);
            this.lblCteatedByUser.Name = "lblCteatedByUser";
            this.lblCteatedByUser.Size = new System.Drawing.Size(46, 29);
            this.lblCteatedByUser.TabIndex = 8;
            this.lblCteatedByUser.Text = "???";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.ForeColor = System.Drawing.Color.White;
            this.lblApplicationFees.Location = new System.Drawing.Point(220, 377);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(39, 29);
            this.lblApplicationFees.TabIndex = 7;
            this.lblApplicationFees.Text = "15";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.ForeColor = System.Drawing.Color.White;
            this.lblApplicationID.Location = new System.Drawing.Point(220, 161);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(46, 29);
            this.lblApplicationID.TabIndex = 6;
            this.lblApplicationID.Text = "???";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "Created By         :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Application Fees  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Licesne Classe    :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Application Date  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "D.L.Application ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 54);
            this.label2.TabIndex = 0;
            this.label2.Text = "Application Info";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(543, 718);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(161, 49);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(726, 718);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 49);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddNewLocalApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(899, 779);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblHeader);
            this.Name = "frmAddNewLocalApplication";
            this.Text = "frmAddNewLocalApplication";
            this.Load += new System.EventHandler(this.frmAddNewLocalApplication_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpPersonalInfo.ResumeLayout(false);
            this.tpApplicationInfo.ResumeLayout(false);
            this.tpApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpPersonalInfo;
        private System.Windows.Forms.TabPage tpApplicationInfo;
        private ctrlFilterPerson ctrlFilterPerson1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLicenseClass;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblCteatedByUser;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}