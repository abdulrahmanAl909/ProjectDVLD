namespace DVLD_Presentation
{
    partial class ctrlUserCard
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
            this.ctrlShowPersonDetails1 = new DVLD_Presentation.ctrlShowPersonDetails();
            this.gbLoginInfo = new System.Windows.Forms.GroupBox();
            this.lblIsUserActive = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlShowPersonDetails1
            // 
            this.ctrlShowPersonDetails1.BackColor = System.Drawing.Color.SteelBlue;
            this.ctrlShowPersonDetails1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlShowPersonDetails1.Location = new System.Drawing.Point(0, 0);
            this.ctrlShowPersonDetails1.Name = "ctrlShowPersonDetails1";
            this.ctrlShowPersonDetails1.Size = new System.Drawing.Size(889, 449);
            this.ctrlShowPersonDetails1.TabIndex = 0;
            // 
            // gbLoginInfo
            // 
            this.gbLoginInfo.Controls.Add(this.lblIsUserActive);
            this.gbLoginInfo.Controls.Add(this.lblUserName);
            this.gbLoginInfo.Controls.Add(this.lblUserID);
            this.gbLoginInfo.Controls.Add(this.label3);
            this.gbLoginInfo.Controls.Add(this.label2);
            this.gbLoginInfo.Controls.Add(this.label1);
            this.gbLoginInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbLoginInfo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gbLoginInfo.ForeColor = System.Drawing.Color.White;
            this.gbLoginInfo.Location = new System.Drawing.Point(0, 492);
            this.gbLoginInfo.Name = "gbLoginInfo";
            this.gbLoginInfo.Size = new System.Drawing.Size(889, 220);
            this.gbLoginInfo.TabIndex = 1;
            this.gbLoginInfo.TabStop = false;
            this.gbLoginInfo.Text = "Login Information";
            // 
            // lblIsUserActive
            // 
            this.lblIsUserActive.AutoSize = true;
            this.lblIsUserActive.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblIsUserActive.Location = new System.Drawing.Point(184, 152);
            this.lblIsUserActive.Name = "lblIsUserActive";
            this.lblIsUserActive.Size = new System.Drawing.Size(69, 36);
            this.lblIsUserActive.TabIndex = 4;
            this.lblIsUserActive.Text = "true";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblUserName.Location = new System.Drawing.Point(183, 93);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(357, 36);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "Abdulrahman Mohammed";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblUserID.Location = new System.Drawing.Point(183, 38);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(47, 36);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "18";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.Location = new System.Drawing.Point(6, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Is Active:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID:";
            // 
            // ctrlUserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.gbLoginInfo);
            this.Controls.Add(this.ctrlShowPersonDetails1);
            this.Name = "ctrlUserCard";
            this.Size = new System.Drawing.Size(889, 712);
            this.gbLoginInfo.ResumeLayout(false);
            this.gbLoginInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlShowPersonDetails ctrlShowPersonDetails1;
        private System.Windows.Forms.GroupBox gbLoginInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIsUserActive;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
