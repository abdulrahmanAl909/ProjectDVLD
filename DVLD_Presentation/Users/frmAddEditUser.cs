using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation
{
    public partial class frmAddEditUser : Form
    {

        enum enMode { AddNewUser , UpdateUser}
        enMode Mode = enMode.AddNewUser;

        int _UserID;
        clsUser _UserInfo;

        bool allowLoginTab = false;

        public frmAddEditUser()
        {
            InitializeComponent();

            Mode = enMode.AddNewUser;
        }

        public frmAddEditUser(int UserID)
        {
            InitializeComponent();

            Mode = enMode.UpdateUser;

            _UserID = UserID;
        }

        private void _CheckIsEmptyOrWhiteSpace(TextBox text , CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(text.Text))
            {
                e.Cancel = true;
                epConfirmPassword.SetError(text, "This Text is Required");
            }
            else
            {
                e.Cancel = false;
                epConfirmPassword.SetError(text, "");
            }
        }

        private void LoadData()
        {
            if(Mode == enMode.AddNewUser)
            {
                lblName.Text = "Add New User";
                _UserInfo = new clsUser();
                return;
            }

            _UserInfo = clsUser.GetUserInfoByID(_UserID);

            lblName.Text = "Update User";
            btnSave.Enabled = true;

            lblUserID.Text = _UserInfo.UserID.ToString();
            txtUserName.Text = _UserInfo.UserName;
            txtUserPassword.Text = _UserInfo.UserPassword;
            txtConfirmPassword.Text = _UserInfo.UserPassword;
            cbIsActive.Checked = _UserInfo.IsActive;

            ctrlFilterPerson1.StatusOfUpdate(_UserInfo.PersonID);
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _UserInfo.PersonInfo = ctrlFilterPerson1._PersonInfo;

            if (_UserInfo.PersonInfo != null && !clsUser.IsPersonExist(_UserInfo.PersonInfo.PersonID))
            {
                allowLoginTab = true;
                tcAddEditUser.SelectedTab = tpLoginInfo;
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Select Person already has a user, choose another one", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields have invalid information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _UserInfo.PersonID = _UserInfo.PersonInfo.PersonID;
            _UserInfo.UserName = txtUserName.Text;
            _UserInfo.IsActive = cbIsActive.Checked;

            if(txtUserPassword.Text==txtConfirmPassword.Text)
            {
                _UserInfo.UserPassword = txtUserPassword.Text;
            }
            else
            {
                MessageBox.Show("Confirm Password Is Worng", "Confirm Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_UserInfo.Save())
            {
                MessageBox.Show("Data Saved Successfully.");
            }
            else
            {
                if (MessageBox.Show("Error: Data Is NOT Saved Successfully", "Error!", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }

            lblUserID.Text = _UserInfo.UserID.ToString();
            lblName.Text = "Update User";
            ctrlFilterPerson1.StatusOfUpdate(_UserInfo.PersonID);
            Mode = enMode.UpdateUser;
        }

        private void CheckIsEmpty(object sender, CancelEventArgs e)
        {
            _CheckIsEmptyOrWhiteSpace((TextBox)sender, e);
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowPassword.Checked)
            {
                txtUserPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtUserPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void tcAddEditUser_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tpLoginInfo && !allowLoginTab)
            {
                e.Cancel = true;
            }
        }
    }
}
