namespace DVLD_Presentation
{
    partial class ctrlFilterPerson
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
            this.gbFilterBy = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.btnFilterBy = new System.Windows.Forms.Button();
            this.txtFilterBy = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlShowPersonDetails1 = new DVLD_Presentation.ctrlShowPersonDetails();
            this.gbFilterBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilterBy
            // 
            this.gbFilterBy.Controls.Add(this.label2);
            this.gbFilterBy.Controls.Add(this.btnAddNewPerson);
            this.gbFilterBy.Controls.Add(this.btnFilterBy);
            this.gbFilterBy.Controls.Add(this.txtFilterBy);
            this.gbFilterBy.Controls.Add(this.cbFilterBy);
            this.gbFilterBy.Controls.Add(this.label1);
            this.gbFilterBy.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gbFilterBy.ForeColor = System.Drawing.Color.White;
            this.gbFilterBy.Location = new System.Drawing.Point(3, 13);
            this.gbFilterBy.Name = "gbFilterBy";
            this.gbFilterBy.Size = new System.Drawing.Size(882, 108);
            this.gbFilterBy.TabIndex = 1;
            this.gbFilterBy.TabStop = false;
            this.gbFilterBy.Text = "Filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(644, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add New";
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddNewPerson.BackgroundImage = global::DVLD_Presentation.Properties.Resources.add_user__2_;
            this.btnAddNewPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewPerson.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAddNewPerson.Location = new System.Drawing.Point(648, 43);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(70, 50);
            this.btnAddNewPerson.TabIndex = 4;
            this.btnAddNewPerson.UseVisualStyleBackColor = false;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // btnFilterBy
            // 
            this.btnFilterBy.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFilterBy.BackgroundImage = global::DVLD_Presentation.Properties.Resources.magnifying_glass;
            this.btnFilterBy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFilterBy.FlatAppearance.BorderSize = 0;
            this.btnFilterBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterBy.Location = new System.Drawing.Point(557, 43);
            this.btnFilterBy.Name = "btnFilterBy";
            this.btnFilterBy.Size = new System.Drawing.Size(70, 50);
            this.btnFilterBy.TabIndex = 3;
            this.btnFilterBy.UseVisualStyleBackColor = false;
            this.btnFilterBy.Click += new System.EventHandler(this.btnFilterBy_Click);
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.Location = new System.Drawing.Point(326, 61);
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.Size = new System.Drawing.Size(212, 32);
            this.txtFilterBy.TabIndex = 2;
            this.txtFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterBy_KeyPress);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "PersonID",
            "National No"});
            this.cbFilterBy.Location = new System.Drawing.Point(120, 60);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(188, 32);
            this.cbFilterBy.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter By:";
            // 
            // ctrlShowPersonDetails1
            // 
            this.ctrlShowPersonDetails1.BackColor = System.Drawing.Color.SteelBlue;
            this.ctrlShowPersonDetails1.Location = new System.Drawing.Point(0, 127);
            this.ctrlShowPersonDetails1.Name = "ctrlShowPersonDetails1";
            this.ctrlShowPersonDetails1.Size = new System.Drawing.Size(914, 457);
            this.ctrlShowPersonDetails1.TabIndex = 0;
            // 
            // ctrlFilterPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.gbFilterBy);
            this.Controls.Add(this.ctrlShowPersonDetails1);
            this.Name = "ctrlFilterPerson";
            this.Size = new System.Drawing.Size(917, 587);
            this.Load += new System.EventHandler(this.ctrlFilterPerson_Load);
            this.gbFilterBy.ResumeLayout(false);
            this.gbFilterBy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlShowPersonDetails ctrlShowPersonDetails1;
        private System.Windows.Forms.GroupBox gbFilterBy;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilterBy;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.Button btnFilterBy;
        private System.Windows.Forms.Label label2;
    }
}
