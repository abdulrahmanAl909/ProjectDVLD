using DVLD_Business;
using DVLD_Presentation.Properties;
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
    public partial class frmTestAppointment : Form
    {      
        enum enMode { Add, Update }
        enMode Mode = enMode.Add;

        enTestType _TestType = enTestType.VisionTest;

        decimal PaidFees;

        clsTestAppointment TestAppointmentInfo;
        private int TestAppointmentID;
        private int LocalID;
        bool RetakeTest = true;

        //private void _FillInfoFprLocalApplication()
        //{
        //    lblDLAppID.Text = TestAppointmentInfo.LocalInfo.LocalApplicationID.ToString();
        //    lblClassName.Text = TestAppointmentInfo.LocalInfo.LicenseClassInfo.ClassName;
        //    lblName.Text = TestAppointmentInfo.LocalInfo.ApplicationInfo.PersonInfo.FullName;
        //    PaidFees = clsTestType.GetTestTypeFees((int)_TestType);
        //}

        private void _FillInfoForTest()
        {
            if (_TestType == enTestType.VisionTest)
            {
                pbTestImage.Image = Resources.ChatGPT_Image_Aug_23__2026__02_37_44_PM3;
                pbTestImage.SizeMode = PictureBoxSizeMode.StretchImage;
                lblTitle.Text = "Vision Test Appointments";
                gbTitle.Text = "Vision Test";
            }
            else if (_TestType == enTestType.WriteTest)
            {
                pbTestImage.Image = Resources.ChatGPT_Image_Aug_29__2026__06_57_41_AM__1_;
                pbTestImage.SizeMode = PictureBoxSizeMode.StretchImage;
                lblTitle.Text = "Write Test Appointments";
                gbTitle.Text = "Write Test";
            }
            else
            {
                pbTestImage.Image = Resources.ChatGPT_Image_Aug_29__2026__08_59_25_AM555;
                pbTestImage.SizeMode = PictureBoxSizeMode.StretchImage;
                lblTitle.Text = "Street Test Appointments";
                gbTitle.Text = "Street Test";
            }
        }

        private void LoadData()
        {
            _FillInfoForTest();

            lblDLAppID.Text = TestAppointmentInfo.LocalInfo.LocalApplicationID.ToString();
            lblClassName.Text = TestAppointmentInfo.LocalInfo.LicenseClassInfo.ClassName;
            lblName.Text = TestAppointmentInfo.LocalInfo.ApplicationInfo.PersonInfo.FullName;
            dtpDate.Value = DateTime.Now;
            dtpDate.MinDate = DateTime.Now;
            PaidFees = clsTestType.GetTestTypeFees((int)_TestType);
            lblFees.Text = PaidFees.ToString();

            if (Mode == enMode.Add)
            {
                TestAppointmentInfo = new clsTestAppointment();
                return;
            }

            TestAppointmentInfo = clsTestAppointment.GetTestAppointmentByID(TestAppointmentID);

            // there is error here becase the date
            dtpDate.Value = TestAppointmentInfo.AppointmentDate;
        }

        public frmTestAppointment(int TestAppointmentID,int LocalID,enTestType TestType,bool TheTestResult = true)
        {
            InitializeComponent();

            if(TheTestResult==false)
            {
                dtpDate.Enabled = false;
                btnSave.Enabled = false;
                gbRetakeTest.Enabled = true;
                lblWorngForRetakeTest.Visible = true;
            }

            this._TestType = TestType;
            this.TestAppointmentID = TestAppointmentID;
            this.LocalID = LocalID;

            // Fill Object LocalApplication
            TestAppointmentInfo = new clsTestAppointment(LocalID);

            Mode = enMode.Update;
        }

        public frmTestAppointment(int LocalID, enTestType TestType, bool TheTestResult=true)
        {
            InitializeComponent();

            if(TheTestResult==false)
            {
                RetakeTest = TheTestResult;

                gbRetakeTest.Enabled = true;

                decimal RetakeTestFeed = clsTestType.GetTestTypeFees((int)_TestType);

                if (decimal.TryParse(lblRAppFees.Text,out decimal Value))
                {
                    RetakeTestFeed += Value;
                }
                else
                {
                    MessageBox.Show("It Must Be All Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                lblTotalFees.Text = RetakeTestFeed.ToString();
            }

            this._TestType = TestType;
            this.LocalID = LocalID;

            // Fill Object LocalApplication
            TestAppointmentInfo = new clsTestAppointment(LocalID);

            Mode = enMode.Add;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDateOfTest_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            TestAppointmentInfo.TestTypeID = (int)_TestType;
            TestAppointmentInfo.LocalLicenseApplicationID = LocalID;
            TestAppointmentInfo.PaidFees = this.PaidFees;
            TestAppointmentInfo.AppointmentDate = dtpDate.Value;
            TestAppointmentInfo.CreateByUserID = clsGlobalSettings.CurrentUser.UserID;
            TestAppointmentInfo.IsLocked = false;
            TestAppointmentInfo.RetakeTestApplicationID = -1;

            if (RetakeTest == false)
            {

            }

            if (TestAppointmentInfo.Save())
            {
                MessageBox.Show("Data Saved Successfully.");
            }
            else
            {
                if (MessageBox.Show("Error: Data Is NOT Saved Successfully", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    this.Close();
                }
            }
           
            Mode = enMode.Update;
        }

    }
}