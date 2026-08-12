namespace DVLD_Presentation
{
    partial class frmUserInfo
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
            this.ctrlUserCard2 = new DVLD_Presentation.ctrlUserCard();
            this.ctrlUserCard1 = new DVLD_Presentation.ctrlUserCard();
            this.SuspendLayout();
            // 
            // ctrlUserCard2
            // 
            this.ctrlUserCard2.BackColor = System.Drawing.Color.SteelBlue;
            this.ctrlUserCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlUserCard2.Location = new System.Drawing.Point(0, 0);
            this.ctrlUserCard2.Name = "ctrlUserCard2";
            this.ctrlUserCard2.Size = new System.Drawing.Size(888, 638);
            this.ctrlUserCard2.TabIndex = 0;
            // 
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.BackColor = System.Drawing.Color.SteelBlue;
            this.ctrlUserCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlUserCard1.Location = new System.Drawing.Point(0, 0);
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.Size = new System.Drawing.Size(888, 638);
            this.ctrlUserCard1.TabIndex = 0;
            // 
            // frmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 638);
            this.Controls.Add(this.ctrlUserCard2);
            this.Name = "frmUserInfo";
            this.Text = "frmUserInfo";
            this.Load += new System.EventHandler(this.frmUserInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlUserCard ctrlUserCard1;
        private ctrlUserCard ctrlUserCard2;
    }
}