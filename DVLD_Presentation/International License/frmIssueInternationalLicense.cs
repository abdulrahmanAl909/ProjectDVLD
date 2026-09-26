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
    public partial class frmIssueInternationalLicense : Form
    {
        public clsInternationalLicense InternationalInfo;


        int LicenseID;
        decimal FeesForApplicationType;

        private bool _CheckLicenseRule()
        {
            if (InternationalInfo.LicenseInfo.LicenseClass != 3)
            {
                MessageBox.Show("You Must Have License For 3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (!InternationalInfo.LicenseInfo.IsActive)
            {
                MessageBox.Show("You Must Have License Is Active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (InternationalInfo.LicenseInfo.ExpirationDate < DateTime.Now)
            {
                MessageBox.Show("You Must Have Renew License ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }


        private void FillData()
        {
            InternationalInfo = new clsInternationalLicense();

            InternationalInfo.LicenseInfo = clsLicense.GetLicenseByID(LicenseID);

            if(_CheckLicenseRule())
            {
                return;
            }

            btnIssue.Enabled = true;

            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            FeesForApplicationType = clsApplicationType.GetPaidFees((int)enApplicationType.NewInternationalLicense);
            lblFees.Text = FeesForApplicationType.ToString();
            lblLocalLicenseID.Text = LicenseID.ToString();
            lblExpirationDate.Text = InternationalInfo.LicenseInfo.ExpirationDate.ToShortDateString();
            lblCreateUser.Text = clsGlobalSettings.CurrentUser.UserName;

            llLicenseHistory.Enabled = true;
        }

        public frmIssueInternationalLicense()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if(clsInternationalLicense.IsInternationalExsit(LicenseID))
            {
                MessageBox.Show("Person already have an active international lincense", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Fill Info For Application
            InternationalInfo.ApplicationInfo.ApplicationPersonID = InternationalInfo.LicenseInfo.ApplicationInfo.ApplicationPersonID;
            InternationalInfo.ApplicationInfo.ApplicationDate = DateTime.Now;
            InternationalInfo.ApplicationInfo.ApplicationType = (int)enApplicationType.NewInternationalLicense;
            InternationalInfo.ApplicationInfo.ApplicationStatus = enApplicationStatus.AddNewApp;
            InternationalInfo.ApplicationInfo.LastStatusDate = DateTime.Now;
            InternationalInfo.ApplicationInfo.PaidFees = FeesForApplicationType;
            InternationalInfo.ApplicationInfo.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;

            InternationalInfo.ApplicationInfo.Save();

            // Fill Info For International
            InternationalInfo.ApplicationID = InternationalInfo.ApplicationInfo.ApplicationID;
            InternationalInfo.DriverID = InternationalInfo.LicenseInfo.DriverID;
            InternationalInfo.IssuedUsingLocalLicenseID = InternationalInfo.LicenseInfo.LicenseID;
            InternationalInfo.IssueDate = DateTime.Now;
            DateTime dateTime = DateTime.Now;
            InternationalInfo.ExpirationDate = dateTime.AddYears(1);
            InternationalInfo.IsActive = true;
            InternationalInfo.CreateByUserID = clsGlobalSettings.CurrentUser.UserID;

            if(MessageBox.Show("Are you sure you want to Issue The License" , "Confirm" , MessageBoxButtons.OKCancel , MessageBoxIcon.Question)==DialogResult.OK)
            {
                if (InternationalInfo.AddNewInternational())
                {
                    MessageBox.Show("International License Issue Successfully with ID = " + InternationalInfo.InternationalLicenseID, "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("International License is Not Saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }

            lblApplicationID.Text = InternationalInfo.ApplicationID.ToString();
            lblLicenseInternation.Text = InternationalInfo.InternationalLicenseID.ToString();

            llLicenseInfo.Enabled = true;
        }

        private void ctrlFilterLicense1_OnSearshForLicense(int obj)
        {
            LicenseID = obj;
            FillData();

        }

        private void llLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInternationalLicenseInfo frm = new frmInternationalLicenseInfo(InternationalInfo.InternationalLicenseID);

            frm.ShowDialog();
        }

        private void llLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(InternationalInfo.LicenseInfo.ApplicationInfo.PersonInfo.PersonID);

            frm.ShowDialog();
        }
    }
}
