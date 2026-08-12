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

        private void GetAllFilter()
        {
            DataTable dataTable = clsUser.GetAllColumnName();

            foreach(DataColumn column in dataTable.Columns)
            {
                cbFilterBy.Items.Add(column.ColumnName);
            }
            cbFilterBy.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageUser_Load(object sender, EventArgs e)
        {
            _RefrishUser();
            GetAllFilter();
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
            frmChangePassword frm = new frmChangePassword((int)dgvUser.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo((int)dgvUser.CurrentRow.Cells[0].Value);

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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this user [" + dgvUser.CurrentRow.Cells[0].Value + "]","Warning!" ,MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                if (clsUser.DeleteUser((int)dgvUser.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User Delete Successfully");
                    _RefrishUser();
                }
                else
                {
                    MessageBox.Show("User is NOT Delete");
                }
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterBy.Text=="None")
            {
                txtFilterBy.Visible = false;
                cbIsActive.Visible = false;
                _RefrishUser();
            }
            else if(cbFilterBy.Text=="IsActive")
            {
                txtFilterBy.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.SelectedIndex = 0;
            }
            else
            {
                txtFilterBy.Visible = true;
                cbIsActive.Visible = false;
                txtFilterBy.Clear();
            }
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbIsActive.Text=="All")
            {
                _RefrishUser();
            }
            else
            {
                if(cbIsActive.Text=="Yes")
                {
                    dgvUser.DataSource = clsUser.GetAllIsActive(cbFilterBy.Text,true);
                }
                else
                {
                    dgvUser.DataSource = clsUser.GetAllIsActive(cbFilterBy.Text, false);
                }
                lblCountRecord.Text = dgvUser.RowCount.ToString();
            }
        }


    }
}
