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
    public partial class frmDetainLicense : Form
    {
        clsLicense Licenseinfo;

        int PersonID;
        int LicenseID;

        private void LoadData()
        {
            Licenseinfo = clsLicense.GetLicenseByID(LicenseID);


            if (clsDetainLicense.IsLicenseDetain(LicenseID))
            {
                MessageBox.Show("Select License already detained", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(!Licenseinfo.IsActive)
            {
                MessageBox.Show("This License is Not Active", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PersonID = Licenseinfo.ApplicationInfo.ApplicationPersonID;

            lblDetainDate.Text = DateTime.Now.ToShortDateString();
            lblLicenseID.Text = LicenseID.ToString();
            lblCreateBy.Text = clsGlobalSettings.CurrentUser.UserName;

            btnDetain.Enabled = true;
            llLicenseHistory.Enabled = true;
        }

        public frmDetainLicense()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlFilterLicense1_OnSearshForLicense(int obj)
        {
            LicenseID = obj;
            LoadData();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            clsDetainLicense DetainInfo = new clsDetainLicense();

            DetainInfo.LicenseID = LicenseID;
            DetainInfo.DetainDate = DateTime.Now;
            DetainInfo.FineFees = nudPaidFees.Value;
            DetainInfo.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
            DetainInfo.IsReleased = false;

            if (MessageBox.Show("Are you sure you want to Detain The License", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (DetainInfo.AddDetain())
                {
                    MessageBox.Show("License Detain Successfully with ID = " + DetainInfo.DetainID, "License Detain", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clsLicense.ChangeActive(LicenseID, false);
                }
                else
                {
                    MessageBox.Show("License is Not Saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }

            lblDetainID.Text = DetainInfo.DetainID.ToString();

            llLicenseInfo.Enabled = true;
        }

        private void llLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(PersonID);

            frm.ShowDialog();
        }

        private void llLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(LicenseID);

            frm.ShowDialog();
        }

    }
}
