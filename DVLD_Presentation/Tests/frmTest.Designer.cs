namespace DVLD_Presentation
{
    partial class frmTest
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTestAppointment = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCountRecord = new System.Windows.Forms.Label();
            this.pbTestImage = new System.Windows.Forms.PictureBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.ctrlL1 = new DVLD_Presentation.ctrlL();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointment)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Palatino Linotype", 20F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(374, 69);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(474, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Vision Test Appointments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 649);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = " Appointments";
            // 
            // dgvTestAppointment
            // 
            this.dgvTestAppointment.AllowUserToAddRows = false;
            this.dgvTestAppointment.AllowUserToDeleteRows = false;
            this.dgvTestAppointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTestAppointment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTestAppointment.BackgroundColor = System.Drawing.Color.White;
            this.dgvTestAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestAppointment.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTestAppointment.Location = new System.Drawing.Point(43, 703);
            this.dgvTestAppointment.Name = "dgvTestAppointment";
            this.dgvTestAppointment.ReadOnly = true;
            this.dgvTestAppointment.RowHeadersVisible = false;
            this.dgvTestAppointment.RowHeadersWidth = 62;
            this.dgvTestAppointment.RowTemplate.Height = 29;
            this.dgvTestAppointment.Size = new System.Drawing.Size(1124, 107);
            this.dgvTestAppointment.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTestToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 100);
            // 
            // editTestToolStripMenuItem
            // 
            this.editTestToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.Edit_Test_40x40;
            this.editTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editTestToolStripMenuItem.Name = "editTestToolStripMenuItem";
            this.editTestToolStripMenuItem.Size = new System.Drawing.Size(177, 48);
            this.editTestToolStripMenuItem.Text = "Edit Test";
            this.editTestToolStripMenuItem.Click += new System.EventHandler(this.editTestToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.Take_Test_40x40;
            this.takeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(177, 48);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(993, 816);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(174, 48);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 829);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Record:";
            // 
            // lblCountRecord
            // 
            this.lblCountRecord.AutoSize = true;
            this.lblCountRecord.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblCountRecord.ForeColor = System.Drawing.Color.White;
            this.lblCountRecord.Location = new System.Drawing.Point(126, 829);
            this.lblCountRecord.Name = "lblCountRecord";
            this.lblCountRecord.Size = new System.Drawing.Size(46, 29);
            this.lblCountRecord.TabIndex = 6;
            this.lblCountRecord.Text = "???";
            // 
            // pbTestImage
            // 
            this.pbTestImage.Image = global::DVLD_Presentation.Properties.Resources.ChatGPT_Image_Aug_23__2026__02_37_44_PM3;
            this.pbTestImage.Location = new System.Drawing.Point(383, 0);
            this.pbTestImage.Name = "pbTestImage";
            this.pbTestImage.Size = new System.Drawing.Size(414, 66);
            this.pbTestImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTestImage.TabIndex = 8;
            this.pbTestImage.TabStop = false;
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTest.BackgroundImage = global::DVLD_Presentation.Properties.Resources.Add_New_Application_Lines_40x40;
            this.btnTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTest.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.Location = new System.Drawing.Point(1055, 649);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(112, 48);
            this.btnTest.TabIndex = 7;
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // ctrlL1
            // 
            this.ctrlL1.BackColor = System.Drawing.Color.SteelBlue;
            this.ctrlL1.Font = new System.Drawing.Font("Tahoma", 7.75F);
            this.ctrlL1.Location = new System.Drawing.Point(25, 111);
            this.ctrlL1.Name = "ctrlL1";
            this.ctrlL1.Size = new System.Drawing.Size(1151, 540);
            this.ctrlL1.TabIndex = 1;
            this.ctrlL1.Load += new System.EventHandler(this.ctrlL1_Load);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1179, 867);
            this.Controls.Add(this.pbTestImage);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblCountRecord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvTestAppointment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrlL1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmTest";
            this.Text = "frmVisionTest";
            this.Load += new System.EventHandler(this.frmTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointment)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTestImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private ctrlL ctrlL1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTestAppointment;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCountRecord;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.PictureBox pbTestImage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}