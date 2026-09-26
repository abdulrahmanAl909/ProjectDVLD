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

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Application ", "Confirm" ,MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsLoaclApplication.DeleteApplication((int)dgvLocalApplication.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Application Delete Successfully");
                    _RefrishLocalApplication();
                }
                else
                {
                    MessageBox.Show("Application is NOT Delete");
                }
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowL frm = new frmShowL((int)dgvLocalApplication.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
        }

        private void sechduleViToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTest frm = new frmTest((int)dgvLocalApplication.CurrentRow.Cells[0].Value, enTestType.VisionTest);

            frm.ShowDialog();
            _RefrishLocalApplication();
        }

        private void sechduleWriteTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTest frm = new frmTest((int)dgvLocalApplication.CurrentRow.Cells[0].Value, enTestType.WriteTest);

            frm.ShowDialog();
            _RefrishLocalApplication();
        }

        private void sechduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTest frm = new frmTest((int)dgvLocalApplication.CurrentRow.Cells[0].Value, enTestType.StreetTest);

            frm.ShowDialog();
            _RefrishLocalApplication();

        }

        private void cmsMenuApplication_Opening(object sender, CancelEventArgs e)
        {
            int PassedTest = (int)dgvLocalApplication.CurrentRow.Cells[5].Value;

            string ApplicationStatus = (string)dgvLocalApplication.CurrentRow.Cells[6].Value;

            if(ApplicationStatus=="Cancelled")
            {
                MessageBox.Show("This Application Was Cancelled", "Cancelled Application!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
                return;
            }

            if (PassedTest == 0)
            {
                sechduleViToolStripMenuItem.Enabled = true;
                sechduleTestsToolStripMenuItem.Enabled = true;
                sechduleWriteTestToolStripMenuItem.Enabled = false;
                sechduleStreetTestToolStripMenuItem.Enabled = false;
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;

                // اللي تحت علشان الحذف والاضافة

                editApplicationToolStripMenuItem.Enabled = true;
                editApplicationToolStripMenuItem1.Enabled = true;
                deleteApplicationToolStripMenuItem.Enabled = true;
                cancelApplicatinnToolStripMenuItem.Enabled = true;

                showLicenseToolStripMenuItem.Enabled = false;
            }
            else if (PassedTest == 1)
            {
                sechduleWriteTestToolStripMenuItem.Enabled = true;
                sechduleTestsToolStripMenuItem.Enabled = true;
                sechduleViToolStripMenuItem.Enabled = false;
                sechduleStreetTestToolStripMenuItem.Enabled = false;
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;

                editApplicationToolStripMenuItem.Enabled = true;
                editApplicationToolStripMenuItem1.Enabled = true;
                deleteApplicationToolStripMenuItem.Enabled = true;
                cancelApplicatinnToolStripMenuItem.Enabled = true;

                showLicenseToolStripMenuItem.Enabled = false;
            }
            else if (PassedTest == 2)
            {
                sechduleStreetTestToolStripMenuItem.Enabled = true;
                sechduleTestsToolStripMenuItem.Enabled = true;
                sechduleViToolStripMenuItem.Enabled = false;
                sechduleWriteTestToolStripMenuItem.Enabled = false;
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;

                editApplicationToolStripMenuItem.Enabled = true;
                editApplicationToolStripMenuItem1.Enabled = true;
                deleteApplicationToolStripMenuItem.Enabled = true;
                cancelApplicatinnToolStripMenuItem.Enabled = true;

                showLicenseToolStripMenuItem.Enabled = false;
            }
            else if (PassedTest == 3 && ApplicationStatus!="Completed")
            {
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;
                sechduleTestsToolStripMenuItem.Enabled = false;
                sechduleViToolStripMenuItem.Enabled = false;
                sechduleWriteTestToolStripMenuItem.Enabled = false;
                sechduleStreetTestToolStripMenuItem.Enabled = false;


                editApplicationToolStripMenuItem.Enabled = true;
                editApplicationToolStripMenuItem1.Enabled = true;
                deleteApplicationToolStripMenuItem.Enabled = true;
                cancelApplicatinnToolStripMenuItem.Enabled = true;

                showLicenseToolStripMenuItem.Enabled = false;
            }
            else
            {
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                sechduleTestsToolStripMenuItem.Enabled = false;
                sechduleViToolStripMenuItem.Enabled = false;
                sechduleWriteTestToolStripMenuItem.Enabled = false;
                sechduleStreetTestToolStripMenuItem.Enabled = false;

                editApplicationToolStripMenuItem.Enabled = false;
                editApplicationToolStripMenuItem1.Enabled = false;
                deleteApplicationToolStripMenuItem.Enabled = false;
                cancelApplicatinnToolStripMenuItem.Enabled = false;

                showLicenseToolStripMenuItem.Enabled = true;

            }

            /*
            switch (PassedTest)
            {

                case 0:
                    sechduleViToolStripMenuItem.Enabled = true;
                    sechduleTestsToolStripMenuItem.Enabled = true;
                    sechduleWriteTestToolStripMenuItem.Enabled = false;
                    sechduleStreetTestToolStripMenuItem.Enabled = false;
                    issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                    break;

                case 1:
                    sechduleWriteTestToolStripMenuItem.Enabled = true;
                    sechduleTestsToolStripMenuItem.Enabled = true;
                    sechduleViToolStripMenuItem.Enabled = false;
                    sechduleStreetTestToolStripMenuItem.Enabled = false;
                    issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                    break;

                case 2:
                    sechduleStreetTestToolStripMenuItem.Enabled = true;
                    sechduleTestsToolStripMenuItem.Enabled = true;
                    sechduleViToolStripMenuItem.Enabled = false;
                    sechduleWriteTestToolStripMenuItem.Enabled = false;
                    issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                    break;


                case 3:
                    issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;
                    sechduleTestsToolStripMenuItem.Enabled = false;
                    sechduleViToolStripMenuItem.Enabled = false;
                    sechduleWriteTestToolStripMenuItem.Enabled = false;
                    sechduleStreetTestToolStripMenuItem.Enabled = false;
                    break;

            }*/
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueDriverLicenseFirstTime frm = new frmIssueDriverLicenseFirstTime((int)dgvLocalApplication.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
            _RefrishLocalApplication();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationID = clsLoaclApplication.GetApplicationIDByLocalID((int)dgvLocalApplication.CurrentRow.Cells[0].Value);

            int LicenseID = clsLicense.GetLicenseIDByApplicationID(ApplicationID);

            frmShowLicenseInfo frm = new frmShowLicenseInfo(LicenseID);

            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = clsPerson.GetPersonIDByNationalNo(dgvLocalApplication.CurrentRow.Cells[2].Value.ToString());

            frmLicenseHistory frm = new frmLicenseHistory(PersonID);

            frm.ShowDialog();
        }


    }
}
