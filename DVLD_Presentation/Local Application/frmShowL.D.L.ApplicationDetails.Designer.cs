namespace DVLD_Presentation
{
    partial class frmShowL
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
            this.ctrlL1 = new DVLD_Presentation.ctrlL();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Traditional Arabic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(335, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "L.D.L Application Details";
            // 
            // ctrlL1
            // 
            this.ctrlL1.BackColor = System.Drawing.Color.SteelBlue;
            this.ctrlL1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.ctrlL1.Location = new System.Drawing.Point(12, 215);
            this.ctrlL1.Name = "ctrlL1";
            this.ctrlL1.Size = new System.Drawing.Size(1176, 538);
            this.ctrlL1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Presentation.Properties.Resources.ChatGPT_Image_Aug_23__2026__02_14_05_PM2;
            this.pictureBox1.Location = new System.Drawing.Point(362, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmShowL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1200, 779);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctrlL1);
            this.Controls.Add(this.label1);
            this.Name = "frmShowL";
            this.Text = "frmShowL";
            this.Load += new System.EventHandler(this.frmShowL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ctrlL ctrlL1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}