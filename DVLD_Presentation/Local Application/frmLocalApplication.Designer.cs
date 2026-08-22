namespace DVLD_Presentation
{
    partial class frmLocalApplication
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLocalApplication = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editApplicationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelApplicatinnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.sechduleTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.issueDrivingLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCountRecord = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddApplication = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFilterBy = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalApplication)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(371, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local Driving Lincene Application";
            // 
            // dgvLocalApplication
            // 
            this.dgvLocalApplication.AllowUserToAddRows = false;
            this.dgvLocalApplication.AllowUserToDeleteRows = false;
            this.dgvLocalApplication.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocalApplication.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLocalApplication.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocalApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalApplication.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLocalApplication.Location = new System.Drawing.Point(17, 320);
            this.dgvLocalApplication.Name = "dgvLocalApplication";
            this.dgvLocalApplication.ReadOnly = true;
            this.dgvLocalApplication.RowHeadersVisible = false;
            this.dgvLocalApplication.RowHeadersWidth = 62;
            this.dgvLocalApplication.RowTemplate.Height = 29;
            this.dgvLocalApplication.Size = new System.Drawing.Size(1253, 214);
            this.dgvLocalApplication.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.toolStripMenuItem1,
            this.editApplicationToolStripMenuItem,
            this.editApplicationToolStripMenuItem1,
            this.deleteApplicationToolStripMenuItem,
            this.toolStripMenuItem2,
            this.cancelApplicatinnToolStripMenuItem,
            this.toolStripMenuItem3,
            this.sechduleTestsToolStripMenuItem,
            this.toolStripMenuItem4,
            this.issueDrivingLicenseFirstTimeToolStripMenuItem,
            this.toolStripMenuItem5,
            this.showLicenseToolStripMenuItem,
            this.toolStripMenuItem6,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(363, 505);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.showToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.Show_Application_Details_40x40;
            this.showToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(362, 48);
            this.showToolStripMenuItem.Text = "Show Application Details";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(359, 6);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.Add_New_Application_Lines_40x40;
            this.editApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(362, 48);
            this.editApplicationToolStripMenuItem.Text = "Add New Application";
            this.editApplicationToolStripMenuItem.Click += new System.EventHandler(this.btnAddApplication_Click);
            // 
            // editApplicationToolStripMenuItem1
            // 
            this.editApplicationToolStripMenuItem1.Image = global::DVLD_Presentation.Properties.Resources.Edit_Application_40x40_fixed;
            this.editApplicationToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editApplicationToolStripMenuItem1.Name = "editApplicationToolStripMenuItem1";
            this.editApplicationToolStripMenuItem1.Size = new System.Drawing.Size(362, 48);
            this.editApplicationToolStripMenuItem1.Text = "Edit Application";
            this.editApplicationToolStripMenuItem1.Click += new System.EventHandler(this.editApplicationToolStripMenuItem1_Click);
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.Delete_Application_40x40_Clean;
            this.deleteApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(362, 48);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(359, 6);
            // 
            // cancelApplicatinnToolStripMenuItem
            // 
            this.cancelApplicatinnToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.Cancel_Application_Original_40x40;
            this.cancelApplicatinnToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancelApplicatinnToolStripMenuItem.Name = "cancelApplicatinnToolStripMenuItem";
            this.cancelApplicatinnToolStripMenuItem.Size = new System.Drawing.Size(362, 48);
            this.cancelApplicatinnToolStripMenuItem.Text = "Cancel Applicatinn";
            this.cancelApplicatinnToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicatinnToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(359, 6);
            // 
            // sechduleTestsToolStripMenuItem
            // 
            this.sechduleTestsToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.Schedule_Tests_Original_40x40;
            this.sechduleTestsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sechduleTestsToolStripMenuItem.Name = "sechduleTestsToolStripMenuItem";
            this.sechduleTestsToolStripMenuItem.Size = new System.Drawing.Size(362, 48);
            this.sechduleTestsToolStripMenuItem.Text = "Sechdule Tests";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(359, 6);
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.Issue_Driving_License_Original_40x40;
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(362, 48);
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License (First Time)";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(359, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.Show_License_40x40_Clean;
            this.showLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(362, 48);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(359, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.Show_Person_License_History_Original_40x40;
            this.showPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(362, 48);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 574);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Record:";
            // 
            // lblCountRecord
            // 
            this.lblCountRecord.AutoSize = true;
            this.lblCountRecord.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblCountRecord.ForeColor = System.Drawing.Color.White;
            this.lblCountRecord.Location = new System.Drawing.Point(100, 574);
            this.lblCountRecord.Name = "lblCountRecord";
            this.lblCountRecord.Size = new System.Drawing.Size(39, 29);
            this.lblCountRecord.TabIndex = 4;
            this.lblCountRecord.Text = "12";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Navy;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1088, 560);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(182, 54);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filter By:";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "LDLAppID",
            "NationalNo",
            "FullName",
            "Status"});
            this.cbFilterBy.Location = new System.Drawing.Point(126, 277);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(224, 27);
            this.cbFilterBy.TabIndex = 7;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1122, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Add Application";
            // 
            // btnAddApplication
            // 
            this.btnAddApplication.BackColor = System.Drawing.Color.Navy;
            this.btnAddApplication.BackgroundImage = global::DVLD_Presentation.Properties.Resources.icons8_create_order_64;
            this.btnAddApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddApplication.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnAddApplication.ForeColor = System.Drawing.Color.White;
            this.btnAddApplication.Location = new System.Drawing.Point(1122, 238);
            this.btnAddApplication.Name = "btnAddApplication";
            this.btnAddApplication.Size = new System.Drawing.Size(148, 66);
            this.btnAddApplication.TabIndex = 8;
            this.btnAddApplication.UseVisualStyleBackColor = false;
            this.btnAddApplication.Click += new System.EventHandler(this.btnAddApplication_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Presentation.Properties.Resources.Application;
            this.pictureBox1.Location = new System.Drawing.Point(449, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.Location = new System.Drawing.Point(356, 277);
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.Size = new System.Drawing.Size(263, 27);
            this.txtFilterBy.TabIndex = 10;
            this.txtFilterBy.Visible = false;
            this.txtFilterBy.TextChanged += new System.EventHandler(this.txtFilterBy_TextChanged);
            this.txtFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterBy_KeyPress);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "None",
            "New ",
            "Cancelled",
            "Completed"});
            this.cbStatus.Location = new System.Drawing.Point(369, 277);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(250, 27);
            this.cbStatus.TabIndex = 11;
            this.cbStatus.Visible = false;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // frmLocalApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1282, 623);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddApplication);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCountRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLocalApplication);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmLocalApplication";
            this.Text = "frmLocalApplication";
            this.Load += new System.EventHandler(this.frmLocalApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalApplication)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvLocalApplication;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCountRecord;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Button btnAddApplication;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicatinnToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem sechduleTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.TextBox txtFilterBy;
        private System.Windows.Forms.ComboBox cbStatus;
    }
}