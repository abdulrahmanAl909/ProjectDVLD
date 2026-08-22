using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation
{
    public partial class frmLocalApplication : Form
    {
        public frmLocalApplication()
        {
            InitializeComponent();
        }

        private void _RefrishLocalApplication()
        {
            dgvLocalApplication.DataSource = clsLoaclApplication.GetAllLocalApplication();
            lblCountRecord.Text = dgvLocalApplication.RowCount.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLocalApplication_Load(object sender, EventArgs e)
        {
            _RefrishLocalApplication();
            cbFilterBy.SelectedIndex = 0;
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "None")
            {
                txtFilterBy.Visible = false;
                cbStatus.Visible = false;
            }
            else if (cbFilterBy.Text == "Status")
            {
                txtFilterBy.Visible = false;
                cbStatus.Visible = true;
                cbStatus.SelectedIndex = 0;
            }
            else
            {
                txtFilterBy.Visible = true;
                cbStatus.Visible = false;
                txtFilterBy.Clear();
            }
            _RefrishLocalApplication();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbStatus.Text=="None")
            {
                _RefrishLocalApplication();
            }
            else
            {
                dgvLocalApplication.DataSource = clsLoaclApplication.GetAllApplicationByFilter(cbFilterBy.Text, cbStatus.SelectedIndex);
                lblCountRecord.Text = dgvLocalApplication.RowCount.ToString();
            }
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "FullName"  || cbFilterBy.Text=="NationalNo" && !string.IsNullOrWhiteSpace(txtFilterBy.Text))
            {
                dgvLocalApplication.DataSource = clsLoaclApplication.GetAllApplicationByFilter(cbFilterBy.Text, txtFilterBy.Text);
                lblCountRecord.Text = dgvLocalApplication.RowCount.ToString();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFilterBy.Text))
            {
                _RefrishLocalApplication();
            }
            else
            {
                dgvLocalApplication.DataSource = clsLoaclApplication.GetAllApplicationByFilter(cbFilterBy.Text, int.Parse(txtFilterBy.Text));
                lblCountRecord.Text = dgvLocalApplication.RowCount.ToString();
            }

        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text != "LDLAppID")
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Asterisk.Play();
            }
        }

        private void btnAddApplication_Click(object sender, EventArgs e)
        {
            frmAddNewLocalApplication frm = new frmAddNewLocalApplication();

            frm.ShowDialog();
            _RefrishLocalApplication();
        }

        private void editApplicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddNewLocalApplication frm = new frmAddNewLocalApplication((int)dgvLocalApplication.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
            _RefrishLocalApplication();
        }

        private void cancelApplicatinnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalApplication.CurrentRow.Cells[6].Value.ToString() == "New")
            {
                if (MessageBox.Show("Are you sure do want to cancel this application", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (clsLoaclApplication.CancelApplication((int)dgvLocalApplication.CurrentRow.Cells[0].Value))
                    {
                        MessageBox.Show("Application Cancelled Successfully", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefrishLocalApplication();
                    }
                    else
                    {
                        MessageBox.Show("Application Dose Not Cancelled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("You Can't Change The Application Status", "Change Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
