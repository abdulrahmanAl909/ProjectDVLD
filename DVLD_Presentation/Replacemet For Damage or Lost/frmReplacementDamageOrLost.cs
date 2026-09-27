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
    public partial class frmReplacementDamageOrLost : Form
    {
        clsLicense NewLicenseInfo;
        clsLicense OldLicenseInfo;

        int OldLicenseID;
        decimal FeesForApplicationType;

        private bool _CheckLicenseRlue()
        {
            if (OldLicenseInfo.ExpirationDate < DateTime.Now)
            {
                MessageBox.Show("Selected License is expiration","Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (!OldLicenseInfo.IsActive)
            {
                MessageBox.Show("The License Is Not Active", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }

        }


        private void FillData()
        {
            OldLicenseInfo = clsLicense.GetLicenseByID(OldLicenseID);

            if (_CheckLicenseRlue())
            {
                return;
            }

            btnIReplacement.Enabled = true;

            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblOldLicense.Text = OldLicenseInfo.LicenseID.ToString();
            lblCreateUser.Text = clsGlobalSettings.CurrentUser.UserName;

            llLicenseHistory.Enabled = true;

        }

        public frmReplacementDamageOrLost()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReplacementDamageOrLost_Load(object sender, EventArgs e)
        {
            rbDamageLicense.Checked = true;
        }

        private void rbDamageLicense_CheckedChanged(object sender, EventArgs e)
        {

            lblTitle.Text = "Replacement For Damage License";
            FeesForApplicationType = clsApplicationType.GetPaidFees((int)enApplicationType.ReplacementOrDamagedDrivingLicense);
            lblFees.Text = FeesForApplicationType.ToString();
            
        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {

            lblTitle.Text = "Replacement For Lost License";
            FeesForApplicationType = clsApplicationType.GetPaidFees((int)enApplicationType.ReplacementOrLostDrivingLicense);
            lblFees.Text = FeesForApplicationType.ToString();
            
        }

        private void ctrlFilterLicense1_OnSearshForLicense(int obj)
        {
            OldLicenseID = obj;
            FillData();
        }

        private void btnIReplacement_Click(object sender, EventArgs e)
        {
            NewLicenseInfo = new clsLicense();

            // Fill Info For Application
            NewLicenseInfo.ApplicationInfo.ApplicationPersonID = OldLicenseInfo.ApplicationInfo.ApplicationPersonID;
            NewLicenseInfo.ApplicationInfo.ApplicationDate = DateTime.Now;
            NewLicenseInfo.ApplicationInfo.ApplicationStatus = enApplicationStatus.Completed;
            NewLicenseInfo.ApplicationInfo.LastStatusDate = DateTime.Now;
            NewLicenseInfo.ApplicationInfo.PaidFees = FeesForApplicationType;
            NewLicenseInfo.ApplicationInfo.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;

            if(rbDamageLicense.Checked)
            {
                NewLicenseInfo.ApplicationInfo.ApplicationType = (int)enApplicationType.ReplacementOrDamagedDrivingLicense;
                NewLicenseInfo.IssueReason = enIssueReason.ReplacementforDamaged;
            }
            else
            {
                NewLicenseInfo.ApplicationInfo.ApplicationType = (int)enApplicationType.ReplacementOrLostDrivingLicense;
                NewLicenseInfo.IssueReason = enIssueReason.ReplacementforLost;
            }

            NewLicenseInfo.ApplicationInfo.Save();

            //Fill Info For License

            NewLicenseInfo.ApplicationID = NewLicenseInfo.ApplicationInfo.ApplicationID;
            NewLicenseInfo.DriverID = OldLicenseInfo.DriverID;
            NewLicenseInfo.LicenseClass = OldLicenseInfo.LicenseClass;
            NewLicenseInfo.IssueDate = DateTime.Now;
            DateTime dateTime = DateTime.Now;
            NewLicenseInfo.ExpirationDate = dateTime.AddYears(OldLicenseInfo.LicenseClassInfo.DefaultValidityLength);
            NewLicenseInfo.PaidFees = FeesForApplicationType;
            NewLicenseInfo.IsActive = true;
            NewLicenseInfo.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
            NewLicenseInfo.Notes = "";

            if (MessageBox.Show("Are you sure you want to Issue The License", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (NewLicenseInfo.AddNewLicense())
                {
                    MessageBox.Show("International License Issue Successfully with ID = " + NewLicenseInfo.LicenseID, "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clsLicense.ChangeActive(OldLicenseID, false);
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

            lblApplicationID.Text = NewLicenseInfo.ApplicationID.ToString();
            lblReplacedLicenseID.Text = NewLicenseInfo.LicenseID.ToString();

            llLicenseInfo.Enabled = true;
        }

        private void llLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(OldLicenseInfo.ApplicationInfo.PersonInfo.PersonID);

            frm.ShowDialog();
        }

        private void llLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(NewLicenseInfo.LicenseID);

            frm.ShowDialog();
        }


    }
}
