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
    public partial class frmReleaseLicense : Form
    {
        clsDetainLicense DetainInfo;

        int DetainID;
        int PersonID;

        decimal ApplicationTypeFees;

        private void FillData()
        {
            if (!clsDetainLicense.IsLicenseDetain(DetainInfo.LicenseID))
            {
                MessageBox.Show("Select License Is NOT detained", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblDetainID.Text = DetainInfo.DetainID.ToString();
            lblLicenseID.Text = DetainInfo.LicenseID.ToString();
            lblDetainDate.Text = DetainInfo.DetainDate.ToShortDateString();
            lblCreateByUser.Text = clsGlobalSettings.CurrentUser.UserName;
            ApplicationTypeFees = clsApplicationType.GetPaidFees((int)enApplicationType.ReleaseDetainedDrivingLicsense);
            lblApplicationFees.Text = ApplicationTypeFees.ToString();
            lblFineFees1.Text = DetainInfo.FineFees.ToString();
            lblTotalFees.Text = (DetainInfo.FineFees + ApplicationTypeFees).ToString();


            btnRelease.Enabled = true;
            llLicenseHistory.Enabled = true;
        }

        public frmReleaseLicense()
        {
            InitializeComponent();
        }

        public frmReleaseLicense(int DetainID)
        {
            InitializeComponent();

            this.DetainID = DetainID;

            DetainInfo = clsDetainLicense.GetDetainByID(DetainID);

            ctrlFilterLicense1.ShowLicenseInfo(DetainInfo.LicenseID);

            FillData();
        }

        private void frmReleaseLicense_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlFilterLicense1_OnSearshForLicense(int obj)
        {
            DetainInfo = clsDetainLicense.GetDetainByLicenseID(obj);

            FillData();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {

            DetainInfo.ApplicationInfo.ApplicationPersonID = DetainInfo.LicenseInfo.ApplicationInfo.ApplicationPersonID;
            DetainInfo.ApplicationInfo.ApplicationDate = DateTime.Now;
            DetainInfo.ApplicationInfo.ApplicationType =(int) enApplicationType.ReleaseDetainedDrivingLicsense;
            DetainInfo.ApplicationInfo.ApplicationStatus = enApplicationStatus.Completed;
            DetainInfo.ApplicationInfo.LastStatusDate = DateTime.Now;
            DetainInfo.ApplicationInfo.PaidFees = ApplicationTypeFees;
            DetainInfo.ApplicationInfo.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;

            DetainInfo.ApplicationInfo.Save();

            DetainInfo.IsReleased = true;
            DetainInfo.ReleaseDate = DateTime.Now;
            DetainInfo.ReleasedByUserID = clsGlobalSettings.CurrentUser.UserID;
            DetainInfo.ReleaseApplicationID = DetainInfo.ApplicationInfo.ApplicationID;

            if (MessageBox.Show("Are you sure you want to Release The License", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (DetainInfo.UpdateDetain())
                {
                    MessageBox.Show("License Release Successfully with ID =", "License Release", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clsLicense.ChangeActive(DetainInfo.LicenseID, true);
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

            lblRLAppID.Text = DetainInfo.ReleaseApplicationID.ToString();

            llLicenseInfo.Enabled = true;

        }

        private void llLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(DetainInfo.LicenseInfo.ApplicationInfo.ApplicationPersonID);

            frm.ShowDialog();
        }

        private void llLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(DetainInfo.LicenseInfo.ApplicationInfo.ApplicationPersonID);

            frm.ShowDialog();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
