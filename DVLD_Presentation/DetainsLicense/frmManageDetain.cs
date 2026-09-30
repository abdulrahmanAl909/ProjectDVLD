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
    public partial class frmManageDetain : Form
    {
        int _PersonID;

        public frmManageDetain()
        {
            InitializeComponent();
        }

        private void _RefilshData()
        {
            dgvDetainManage.DataSource = clsDetainLicense.GetAllDetains();
            lblCountRecord.Text = dgvDetainManage.RowCount.ToString();
        }

        private void frmManageDetain_Load(object sender, EventArgs e)
        {
            _RefilshData();
            _PersonID = clsPerson.GetPersonIDByNationalNo((string)dgvDetainManage.CurrentRow.Cells[6].Value);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "None")
            {
                txtFilterBy.Visible = false;
                cbIsReleased.Visible = false;
            }
            else if (cbFilterBy.Text == "IsReleased")
            {
                txtFilterBy.Visible = false;
                cbIsReleased.Visible = true;
                cbIsReleased.SelectedIndex = 0;
            }
            else
            {
                txtFilterBy.Visible = true;
                cbIsReleased.Visible = false;
                txtFilterBy.Clear();
            }
            _RefilshData();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIsReleased.Text == "All")
            {
                _RefilshData();
            }
            else
            {
                if (cbIsReleased.Text == "Yes")
                {
                    dgvDetainManage.DataSource = clsDetainLicense.GetAllDetainsByFilter(cbFilterBy.Text, true);
                }
                else
                {
                    dgvDetainManage.DataSource = clsDetainLicense.GetAllDetainsByFilter(cbFilterBy.Text, false);
                }
                lblCountRecord.Text = dgvDetainManage.RowCount.ToString();
            }
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "FullName" || cbFilterBy.Text == "NationalNo" && !string.IsNullOrWhiteSpace(txtFilterBy.Text))
            {
                dgvDetainManage.DataSource = clsDetainLicense.GetAllDetainsByFilter(cbFilterBy.Text, txtFilterBy.Text);
                lblCountRecord.Text = dgvDetainManage.RowCount.ToString();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFilterBy.Text))
            {
                _RefilshData();
            }
            else
            {
                dgvDetainManage.DataSource = clsDetainLicense.GetAllDetainsByFilter(cbFilterBy.Text, int.Parse(txtFilterBy.Text));
                lblCountRecord.Text = dgvDetainManage.RowCount.ToString();
            }

        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(cbFilterBy.Text == "DetainID" || cbFilterBy.Text=="ReleaseApplicationID"))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Asterisk.Play();
            }
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonDetails frm = new PersonDetails(_PersonID);

            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo((int)dgvDetainManage.CurrentRow.Cells[1].Value);

            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(_PersonID);

            frm.ShowDialog();
        }

        private void btnAddDetain_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();

            frm.ShowDialog();
        }

        private void btnAddRelease_Click(object sender, EventArgs e)
        {
            frmReleaseLicense frm = new frmReleaseLicense();

            frm.ShowDialog();
            _RefilshData();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (!clsDetainLicense.GetIsRelease((int)dgvDetainManage.CurrentRow.Cells[0].Value))
            {
                releaseLicToolStripMenuItem.Enabled = true;
            }
            else
            {
                releaseLicToolStripMenuItem.Enabled = false;
            }
        }

        private void releaseLicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseLicense frm = new frmReleaseLicense((int)dgvDetainManage.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
            _RefilshData();
        }
    }
}
