namespace DVLD_Presentation
{
    partial class frmChangePassword
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.ctrlUserCard1 = new DVLD_Presentation.ctrlUserCard();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 706);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 750);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Password     :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 794);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirm Password:";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BackColor = System.Drawing.Color.SteelBlue;
            this.txtCurrentPassword.Location = new System.Drawing.Point(278, 715);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '*';
            this.txtCurrentPassword.Size = new System.Drawing.Size(308, 27);
            this.txtCurrentPassword.TabIndex = 4;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.SteelBlue;
            this.txtNewPassword.Location = new System.Drawing.Point(278, 759);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(308, 27);
            this.txtNewPassword.TabIndex = 5;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.SteelBlue;
            this.txtConfirmPassword.Location = new System.Drawing.Point(278, 803);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(308, 27);
            this.txtConfirmPassword.TabIndex = 6;
            // 
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.BackColor = System.Drawing.Color.SteelBlue;
            this.ctrlUserCard1.Location = new System.Drawing.Point(12, 12);
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.Size = new System.Drawing.Size(890, 679);
            this.ctrlUserCard1.TabIndex = 0;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(918, 863);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlUserCard1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmChangePassword";
            this.Text = "frmChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlUserCard ctrlUserCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
    }
}