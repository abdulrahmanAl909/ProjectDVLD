namespace DVLD_Presentation
{
    partial class frmAddEditUser
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
            this.tbAddEditUser = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlFilterPerson1 = new DVLD_Presentation.ctrlFilterPerson();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbAddEditUser.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 30F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(267, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New User";
            // 
            // tbAddEditUser
            // 
            this.tbAddEditUser.Controls.Add(this.tabPage1);
            this.tbAddEditUser.Controls.Add(this.tabPage2);
            this.tbAddEditUser.Location = new System.Drawing.Point(28, 65);
            this.tbAddEditUser.Name = "tbAddEditUser";
            this.tbAddEditUser.SelectedIndex = 0;
            this.tbAddEditUser.Size = new System.Drawing.Size(903, 795);
            this.tbAddEditUser.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.ctrlFilterPerson1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(895, 763);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(676, 682);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(214, 51);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "next";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // ctrlFilterPerson1
            // 
            this.ctrlFilterPerson1.BackColor = System.Drawing.Color.SteelBlue;
            this.ctrlFilterPerson1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlFilterPerson1.Location = new System.Drawing.Point(3, 3);
            this.ctrlFilterPerson1.Name = "ctrlFilterPerson1";
            this.ctrlFilterPerson1.Size = new System.Drawing.Size(889, 673);
            this.ctrlFilterPerson1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(895, 763);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(614, 876);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(157, 51);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(777, 876);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 51);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(941, 950);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbAddEditUser);
            this.Controls.Add(this.label1);
            this.Name = "frmAddEditUser";
            this.Text = "frmAddEditUser";
            this.tbAddEditUser.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbAddEditUser;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ctrlFilterPerson ctrlFilterPerson1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}