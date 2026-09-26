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
    public partial class ctrlShowInternationalLicense : UserControl
    {
        public ctrlShowInternationalLicense()
        {
            InitializeComponent();
        }

        public void LoadDataForLicense(int InternationalID)
        {
            clsInternationalLicense InternationalInfo = clsInternationalLicense.GetInternaionalByID(InternationalID);

            lblName.Text = InternationalInfo.ApplicationInfo.PersonInfo.FullName;
            lblIntLicenseID.Text = InternationalInfo.InternationalLicenseID.ToString();
            lblLicenseID.Text = InternationalInfo.IssuedUsingLocalLicenseID.ToString();
            lblNationalNo.Text = InternationalInfo.ApplicationInfo.PersonInfo.NationalNo;
            lblGendor.Text = InternationalInfo.ApplicationInfo.PersonInfo.Gendor.ToString();
            lblIssueDate.Text = InternationalInfo.IssueDate.ToShortDateString();
            lblApplicationID.Text = InternationalInfo.ApplicationID.ToString();
            lblDateOfBirth.Text = InternationalInfo.ApplicationInfo.PersonInfo.DateOfBirth.ToShortDateString();
            lblIsActive.Text = InternationalInfo.IsActive.ToString();
            lblDriverID.Text = InternationalInfo.DriverID.ToString();
            lblExpirationDate.Text = InternationalInfo.ExpirationDate.ToShortDateString();

        }

    }
}
