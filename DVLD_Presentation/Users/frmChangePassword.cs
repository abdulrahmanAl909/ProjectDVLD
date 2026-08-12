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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD_Presentation
{
    public partial class frmChangePassword : Form
    {

        enum enStateUser { CureentUser, ManageUser }
        enStateUser StateUser = enStateUser.CureentUser;

        int _UserID = -1;

        clsUser _UserInfo;

        public frmChangePassword()
        {
            InitializeComponent();

            StateUser = enStateUser.CureentUser;
            
        }

        public frmChangePassword(int UserID)
        {
            InitializeComponent();

            StateUser = enStateUser.ManageUser;

            _UserID = UserID;
        }

        //private void _CheckIsEmptyOrWihteSpace(TextBox textBox , CancelEventArgs e)
        //{
        //    if(string.IsNullOrWhiteSpace(textBox.Text))
        //    {
        //        e.Cancel = true;
        //        textBox.Focus();
        //        epCheckPassword.SetError(textBox, "Current Password Is Worng!");
        //    }
        //    else
        //    {
        //        e.Cancel = false;
        //        epCheckPassword.SetError(textBox, "");
        //    }
        //}

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (StateUser == enStateUser.CureentUser)
            {
                if (clsGlobalSettings.CurrentUser.UserPassword != txtCurrentPassword.Text)
                {
                    e.Cancel = true;
                    txtCurrentPassword.Focus();
                    epCheckPassword.SetError(txtCurrentPassword, "Current Password Is Worng!");
                }
                else
                {
                    e.Cancel = false;
                    epCheckPassword.SetError(txtCurrentPassword, "");
                }
            }
            else
            {
                 _UserInfo = clsUser.GetUserInfoByID(_UserID);
                if (_UserInfo.UserPassword != txtCurrentPassword.Text)
                {
                    e.Cancel = true;
                    txtCurrentPassword.Focus();
                    epCheckPassword.SetError(txtCurrentPassword, "Current Password Is Worng!");
                }
                else
                {
                    e.Cancel = false;
                    epCheckPassword.SetError(txtCurrentPassword, "");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNewPassword.Text) || string.IsNullOrWhiteSpace(txtConfirmPassword.Text)
                || txtConfirmPassword.Text!=txtNewPassword.Text)
            {
                MessageBox.Show("Something Wrong In NewPassword Or ConfirmPassword", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (StateUser == enStateUser.CureentUser)
            {
                if (clsUser.ChangePassword(clsGlobalSettings.CurrentUser.UserID, txtConfirmPassword.Text))
                {
                    MessageBox.Show("Password Change Successfully.", "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something Wrong In NewPassword Or ConfirmPassword!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (clsUser.ChangePassword(_UserInfo.UserID, txtConfirmPassword.Text))
                {
                    MessageBox.Show("Password Change Successfully.", "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something Wrong In NewPassword Or ConfirmPassword!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            if(StateUser == enStateUser.CureentUser)
            {
                ctrlUserCard2.LoadDataForCureentUser();
            }
            else
            {
                ctrlUserCard2.LoadDataForManageUser(_UserID);
            }
        }


    }
}
