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

        private void LoadData()
        {
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            cbLicenseClass.SelectedIndex = 3;
            lblCteatedByUser.Text = clsGlobalSettings.CurrentUser.UserName;

            if(Mode==enMode.AddNewApplication)
            {
                lblHeader.Text = "New Local Driving Licesne Application";
                _LoacApplInfo = new clsLoaclApplication();
                return;
            }
        }

        private void _LoadInfoForApplication()
        {
           
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
            tabControl1.SelectedTab = tpApplicationInfo;
        }

    }
}
