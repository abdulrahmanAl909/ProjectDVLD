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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLoadPeople = new System.Windows.Forms.DataGridView();
            this.cmsPersonInformation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewPerswonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPhone = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCountRecorde = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.txtFilterBy = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadPeople)).BeginInit();
            this.cmsPersonInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(433, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage People";
            // 
            // dgvLoadPeople
            // 
            this.dgvLoadPeople.AllowUserToAddRows = false;
            this.dgvLoadPeople.AllowUserToDeleteRows = false;
            this.dgvLoadPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoadPeople.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLoadPeople.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoadPeople.ColumnHeadersHeight = 34;
            this.dgvLoadPeople.ContextMenuStrip = this.cmsPersonInformation;
            this.dgvLoadPeople.GridColor = System.Drawing.Color.DarkGray;
            this.dgvLoadPeople.Location = new System.Drawing.Point(16, 253);
            this.dgvLoadPeople.Name = "dgvLoadPeople";
            this.dgvLoadPeople.ReadOnly = true;
            this.dgvLoadPeople.RowHeadersVisible = false;
            this.dgvLoadPeople.RowHeadersWidth = 62;
            this.dgvLoadPeople.RowTemplate.Height = 29;
            this.dgvLoadPeople.Size = new System.Drawing.Size(1186, 219);
            this.dgvLoadPeople.TabIndex = 1;
            // 
            // cmsPersonInformation
            // 
            this.cmsPersonInformation.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsPersonInformation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.addNewPerswonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem3,
            this.cmsEmail,
            this.cmsPhone});
            this.cmsPersonInformation.Name = "contextMenuStrip1";
            this.cmsPersonInformation.Size = new System.Drawing.Size(225, 208);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.resume;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // addNewPerswonToolStripMenuItem
            // 
            this.addNewPerswonToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.add_user__2_;
            this.addNewPerswonToolStripMenuItem.Name = "addNewPerswonToolStripMenuItem";
            this.addNewPerswonToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.addNewPerswonToolStripMenuItem.Text = "Add New Person";
            this.addNewPerswonToolStripMenuItem.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.resume__1_;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.delete_user;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(221, 6);
            // 
            // cmsEmail
            // 
            this.cmsEmail.Image = global::DVLD_Presentation.Properties.Resources.email;
            this.cmsEmail.Name = "cmsEmail";
            this.cmsEmail.Size = new System.Drawing.Size(224, 32);
            this.cmsEmail.Text = "Send Email";
            this.cmsEmail.Click += new System.EventHandler(this.cmsEmail_Click);
            // 
            // cmsPhone
            // 
            this.cmsPhone.Image = global::DVLD_Presentation.Properties.Resources.phone;
            this.cmsPhone.Name = "cmsPhone";
            this.cmsPhone.Size = new System.Drawing.Size(224, 32);
            this.cmsPhone.Text = "Phone Call";
            this.cmsPhone.Click += new System.EventHandler(this.cmsPhone_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Records:";
            // 
            // lblCountRecorde
            // 
            this.lblCountRecorde.AutoSize = true;
            this.lblCountRecorde.BackColor = System.Drawing.Color.Transparent;
            this.lblCountRecorde.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblCountRecorde.ForeColor = System.Drawing.Color.White;
            this.lblCountRecorde.Location = new System.Drawing.Point(105, 493);
            this.lblCountRecorde.Name = "lblCountRecorde";
            this.lblCountRecorde.Size = new System.Drawing.Size(22, 24);
            this.lblCountRecorde.TabIndex = 3;
            this.lblCountRecorde.Text = "A";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkBlue;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1096, 478);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 53);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filter By:";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.Color.White;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Location = new System.Drawing.Point(108, 217);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(151, 27);
            this.cbFilterBy.TabIndex = 7;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1097, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Add Person";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Presentation.Properties.Resources.people1;
            this.pictureBox1.Location = new System.Drawing.Point(472, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAddPerson.BackgroundImage = global::DVLD_Presentation.Properties.Resources.add_user__1_;
            this.btnAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPerson.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerson.Font = new System.Drawing.Font("Tahoma", 1F);
            this.btnAddPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddPerson.Location = new System.Drawing.Point(1101, 196);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(101, 49);
            this.btnAddPerson.TabIndex = 5;
            this.btnAddPerson.Text = "Close";
            this.btnAddPerson.UseVisualStyleBackColor = false;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.Location = new System.Drawing.Point(277, 218);
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.Size = new System.Drawing.Size(240, 27);
            this.txtFilterBy.TabIndex = 10;
            this.txtFilterBy.Visible = false;
            this.txtFilterBy.TextChanged += new System.EventHandler(this.txtFilterBy_TextChanged);
            // 
            // ManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1219, 563);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCountRecorde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLoadPeople);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ManagePeople";
            this.Text = "ManagePeople";
            this.Load += new System.EventHandler(this.ManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadPeople)).EndInit();
            this.cmsPersonInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLoadPeople;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCountRecorde;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip cmsPersonInformation;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addNewPerswonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cmsEmail;
        private System.Windows.Forms.ToolStripMenuItem cmsPhone;
        private System.Windows.Forms.TextBox txtFilterBy;
    }
}