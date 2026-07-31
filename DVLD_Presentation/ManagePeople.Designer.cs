namespace DVLD_Presentation
{
    partial class ManagePeople
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
            this.dgvLoadPeople = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label1.Location = new System.Drawing.Point(378, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage People";
            // 
            // dgvLoadPeople
            // 
            this.dgvLoadPeople.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLoadPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoadPeople.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLoadPeople.Location = new System.Drawing.Point(0, 218);
            this.dgvLoadPeople.Name = "dgvLoadPeople";
            this.dgvLoadPeople.RowHeadersWidth = 62;
            this.dgvLoadPeople.RowTemplate.Height = 29;
            this.dgvLoadPeople.Size = new System.Drawing.Size(1167, 297);
            this.dgvLoadPeople.TabIndex = 1;
            // 
            // ManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 515);
            this.Controls.Add(this.dgvLoadPeople);
            this.Controls.Add(this.label1);
            this.Name = "ManagePeople";
            this.Text = "ManagePeople";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLoadPeople;
    }
}