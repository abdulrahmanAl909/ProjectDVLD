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
    public partial class ctrlL : UserControl
    {

        //private int _LocalID = -1;

        private int PersonID = -1;

        public ctrlL()
        {
            InitializeComponent();
        }

        public void LoadDataForLocalApplication(int LoaclID)
        {
            clsLoaclApplication LoaclInfo = clsLoaclApplication.GetLocalApplicationByID(LoaclID);

            lblLocalID.Text = LoaclInfo.LocalApplicationID.ToString();
            lblWhtichLivense.Text = LoaclInfo.LicenseClassInfo.ClassName;
            lblPassTest.Text = clsLoaclApplication.GetCountForPassedTest(LoaclID).ToString();

            // Fill Application

            lblApplicationID.Text = LoaclInfo.ApplicationID.ToString();
            lblApplicationName.Text = LoaclInfo.ApplicationInfo.PersonInfo.FullName.ToString();
            lblApplicationStatus.Text = LoaclInfo.ApplicationInfo.ApplicationStatus.ToString();
            lblApplicationType.Text = clsApplicationType.GetTitleName(LoaclInfo.ApplicationInfo.ApplicationType);
            lblApplicationDate.Text = LoaclInfo.ApplicationInfo.ApplicationDate.ToShortDateString();
            lblLastStatusDate.Text = LoaclInfo.ApplicationInfo.LastStatusDate.ToShortDateString();
            lblApplicationFees.Text = LoaclInfo.ApplicationInfo.PaidFees.ToString();
            lblCreateByUser.Text = clsGlobalSettings.CurrentUser.UserName;

            PersonID = LoaclInfo.ApplicationInfo.ApplicationPersonID;
        }

        public void ChangePassTest(int LocalID)
        {
            lblPassTest.Text = clsLoaclApplication.GetCountForPassedTest(LocalID).ToString();
        }

        private void llShowPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonDetails frm = new PersonDetails(PersonID);

            frm.ShowDialog();
        }



    }
}
