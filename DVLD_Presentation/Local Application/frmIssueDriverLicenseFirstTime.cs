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
    public partial class frmIssueDriverLicenseFirstTime : Form
    {
        int _LocalID;

        clsLicense LicenseInfo;
        int LicenseID;

        public frmIssueDriverLicenseFirstTime(int LocalID)
        {
            InitializeComponent();

            this._LocalID = LocalID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IssueDriverLicenseFirstTime_Load(object sender, EventArgs e)
        {
            ctrlL1.LoadDataForLocalApplication(_LocalID);
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            // وقت م دخلنا الاوبجيكت عبيت معلومات الطلب و نوع الرخصة
            LicenseInfo = new clsLicense(_LocalID);


            // لو السائق كان موجود يحط لي رقمه ولا كان مهو موجود ينشئ لي واحد جديد
            int DriverID = clsDriver.IsDriverExist(LicenseInfo.ApplicationInfo.ApplicationPersonID);

            //اذا كان يساويه يعني مافي سائق ولو كان مايساويه فيه سائق
            if (DriverID != -1)
            {
                LicenseInfo.DriverID = DriverID;
            }
            else
            {
                LicenseInfo.DriverID = clsDriver.AddNewDriver(LicenseInfo.ApplicationInfo.ApplicationPersonID, clsGlobalSettings.CurrentUser.UserID, DateTime.Now);
            }

            LicenseInfo.ApplicationID = LicenseInfo.ApplicationInfo.ApplicationID;
            LicenseInfo.LicenseClass = LicenseInfo.LicenseClassInfo.LicenseClassID;
            LicenseInfo.IssueDate = DateTime.Now;
            DateTime datetime = DateTime.Now;
            LicenseInfo.ExpirationDate =datetime.AddYears(LicenseInfo.LicenseClassInfo.DefaultValidityLength);
            LicenseInfo.Notes = txtNotes.Text;
            LicenseInfo.PaidFees = LicenseInfo.LicenseClassInfo.ClassFees;
            LicenseInfo.IsActive = true;
            LicenseInfo.IssueReason = enIssueReason.FirstTime;
            LicenseInfo.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;

            if(LicenseInfo.AddNewLicense())
            {
                MessageBox.Show("License Issue Successfully with License ID = " + LicenseInfo.LicenseID , "Succeded" , MessageBoxButtons.OK , MessageBoxIcon.Information);

                if(!clsLoaclApplication.CompeletedApplicatiom(_LocalID))
                {
                    MessageBox.Show("Not Saved Completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("License Issue Not Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
