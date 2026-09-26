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
    public partial class ctrlLicenseDetails : UserControl
    {
        public ctrlLicenseDetails()
        {
            InitializeComponent();
        }


        public bool LoadDataForLicense(int LicenseID)
        {
            clsLicense LicenseInfo = clsLicense.GetLicenseByID(LicenseID);

            if (LicenseInfo != null)
            {
                lblClass.Text = LicenseInfo.LicenseClassInfo.ClassName;
                lblName.Text = LicenseInfo.ApplicationInfo.PersonInfo.FullName;
                lblLicenseID.Text = LicenseID.ToString();
                lblNationalNo.Text = LicenseInfo.ApplicationInfo.PersonInfo.NationalNo;
                lblGendor.Text = LicenseInfo.ApplicationInfo.PersonInfo.Gendor.ToString();
                lblIssueDate.Text = LicenseInfo.IssueDate.ToShortDateString();
                lblIssueReason.Text = LicenseInfo.IssueReason.ToString();
                lblIsActive.Text = LicenseInfo.IsActive.ToString();
                lblDateOfBirth.Text = LicenseInfo.ApplicationInfo.PersonInfo.DateOfBirth.ToShortDateString();
                lblDriverID.Text = LicenseInfo.DriverID.ToString();
                lblExpirationDate.Text = LicenseInfo.ExpirationDate.ToShortDateString();

                if (LicenseInfo.Notes == "")
                {
                    lblNotes.Text = "No Notes";
                }
                else
                {
                    lblNotes.Text = LicenseInfo.Notes;
                }

                if (LicenseInfo.IsActive)
                {
                    lblIsDetained.Text = "No";
                }
                else
                {
                    lblIsDetained.Text = "Yes";
                }
                return true;
            }
            else
            {
                MessageBox.Show("No License With License ID = " + LicenseID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


    }
}
