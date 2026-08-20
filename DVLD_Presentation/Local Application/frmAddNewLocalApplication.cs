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
    public partial class frmAddNewLocalApplication : Form
    {
        enum enMode { AddNewApplication, UpdateApplication }
        enMode Mode = enMode.AddNewApplication;

        int _AppID;
        clsLoaclApplication _LoacApplInfo;
        DateTime dateTime = new DateTime();

        bool allowLoginTab = false;

        public frmAddNewLocalApplication()
        {
            InitializeComponent();

            Mode = enMode.AddNewApplication;
        }

        public frmAddNewLocalApplication(int AppID)
        {
            InitializeComponent();

            _AppID = AppID;
            Mode = enMode.UpdateApplication;
        }

        private void FillComboBixForClassName()
        {
            DataTable dataTable = clsLicenseClass.GetAllClassName();

            foreach(DataRow row in dataTable.Rows)
            {
                cbLicenseClass.Items.Add(row["ClassName"]);
            }
            cbLicenseClass.SelectedIndex = 2;
        }

        private void LoadData()
        {
            FillComboBixForClassName();
            dateTime = DateTime.Now;
            lblApplicationDate.Text = dateTime.ToShortDateString();
            lblCteatedByUser.Text = clsGlobalSettings.CurrentUser.UserName;

            if(Mode==enMode.AddNewApplication)
            {
                lblHeader.Text = "New Local Driving Licesne Application";
                _LoacApplInfo = new clsLoaclApplication();
                return;
            }

            _LoacApplInfo = clsLoaclApplication.GetApplicationByID(_AppID);

            lblHeader.Text = "Update Local Driving Licesne Application";
            btnSave.Enabled = true;
            allowLoginTab = true;

            lblApplicationID.Text = _LoacApplInfo.ApplicationID.ToString();
            lblApplicationDate.Text = _LoacApplInfo.ApplicationDate.ToShortDateString();
            lblApplicationFees.Text = _LoacApplInfo.PaidFees.ToString();
            lblCteatedByUser.Text = clsGlobalSettings.CurrentUser.UserName;

            cbLicenseClass.SelectedIndex = _LoacApplInfo.ApplicationType;
        }

        private void _LoadInfoForApplication()
        {
            LoadData();
        }

        private void frmAddNewLocalApplication_Load(object sender, EventArgs e)
        {
            _LoadInfoForApplication();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _LoacApplInfo.PersonInfo = ctrlFilterPerson1.PersonInfo;

            if (_LoacApplInfo.PersonInfo != null)
            {
                tabControl1.SelectedTab = tpApplicationInfo;
                btnSave.Enabled = true;
                allowLoginTab = true;

            }
            else
            {
                MessageBox.Show("You don't Choech Any One To Application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _LoacApplInfo.ApplicationDate = dateTime;
            _LoacApplInfo.ApplicationType = cbLicenseClass.SelectedIndex+1;
            _LoacApplInfo.ApplicationStatus = (enApplicationStatus)enApplicationStatus.AddNewApp;
            _LoacApplInfo.LastStatusDate = dateTime;
            _LoacApplInfo.PaidFees = 15;
            _LoacApplInfo.ApplicationPersonID = _LoacApplInfo.PersonInfo.PersonID;
            _LoacApplInfo.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;

            if(_LoacApplInfo.Save())
            {
                MessageBox.Show("Data Saved Successfully." , "Saved" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Error: Data Is NOT Saved Successfully", "Error!", MessageBoxButtons.OK , MessageBoxIcon.Error) == DialogResult.OK)
                {
                    this.Close();
                }
            }

            lblHeader.Text = "Update Local Driving Licesne Application";
            lblApplicationID.Text = _LoacApplInfo.ApplicationID.ToString();
            Mode = enMode.UpdateApplication;
            allowLoginTab = true;

        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tpApplicationInfo && !allowLoginTab)
            {
                e.Cancel = true;
            }
        }


    }
}
