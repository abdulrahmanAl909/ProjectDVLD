using DVLD_Business;
using DVLD_Business.Application;
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
    public partial class frmInternationalApplication : Form
    {

        private void _ReflishData()
        {
            dgvInternationalLicense.DataSource = clsInternationalLicense.GetAllInternationalLicense();
            lblCountRecord.Text = dgvInternationalLicense.RowCount.ToString();
        }

        public frmInternationalApplication()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmIssueInternationalLicense frm = new frmIssueInternationalLicense();

            frm.ShowDialog();
        }

        private void frmInternationalApplication_Load(object sender, EventArgs e)
        {
            _ReflishData();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "None")
            {
                txtFilterBy.Visible = false;
                cbIsActive.Visible = false;
            }
            else if (cbFilterBy.Text == "IsActive")
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
            _ReflishData();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIsActive.Text == "All")
            {
                _ReflishData();
            }
            else
            {
                if (cbIsActive.Text == "Yes")
                {
                    dgvInternationalLicense.DataSource = clsInternationalLicense.GetAllLicenseByFilter(cbFilterBy.Text, true);
                }
                else
                {
                    dgvInternationalLicense.DataSource = clsInternationalLicense.GetAllLicenseByFilter(cbFilterBy.Text, false);
                }
                lblCountRecord.Text = dgvInternationalLicense.RowCount.ToString();
            }
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilterBy.Text))
            {
                _ReflishData();
            }
            else
            {
                dgvInternationalLicense.DataSource = clsInternationalLicense.GetAllLicenseByFilter(cbFilterBy.Text, int.Parse(txtFilterBy.Text));
                lblCountRecord.Text = dgvInternationalLicense.RowCount.ToString();
            }

        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Asterisk.Play();
            }
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = clsApplication.GetPersonIDByApplicationID((int)dgvInternationalLicense.CurrentRow.Cells[1].Value);

            PersonDetails frm = new PersonDetails(PersonID);

            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo((int)dgvInternationalLicense.CurrentRow.Cells[3].Value);

            frm.ShowDialog();
        }


    }
}
