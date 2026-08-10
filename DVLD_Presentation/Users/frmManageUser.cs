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
    public partial class frmManageUser : Form
    {
        public frmManageUser()
        {
            InitializeComponent();
        }

        private void _RefrishUser()
        {
            dgvUser.DataSource = clsUser.GetAllUsers();
            lblCountRecord.Text = dgvUser.RowCount.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageUser_Load(object sender, EventArgs e)
        {
            _RefrishUser();
        }

        private void cmsPhoneCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void cmsSendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();

            frm.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo();

            frm.ShowDialog();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();

            frm.ShowDialog();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();

            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();

            frm.ShowDialog();
        }
    }
}
