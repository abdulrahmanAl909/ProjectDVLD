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
    public partial class frmTakeTest : Form
    {
        enTestType _TestType = enTestType.VisionTest;

        clsTakeTest TakeTestInfo;
        
        public frmTakeTest(int TestAppointmentID , enTestType TestType)
        {
            InitializeComponent();

            TakeTestInfo = new clsTakeTest(TestAppointmentID);
            this._TestType = TestType;
        }

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

            lblDLAppID.Text = TakeTestInfo.TestAppointmentInfo.LocalInfo.LocalApplicationID.ToString();
            lblClassName.Text = TakeTestInfo.TestAppointmentInfo.LocalInfo.LicenseClassInfo.ClassName;
            lblName.Text = TakeTestInfo.TestAppointmentInfo.LocalInfo.ApplicationInfo.PersonInfo.FullName;
            dtpDate.Value = TakeTestInfo.TestAppointmentInfo.AppointmentDate;
            lblFees.Text = TakeTestInfo.TestAppointmentInfo.PaidFees.ToString();

            rbPass.Checked = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("are you sure you want to save? After that you cannot change " +
                "the Pass/Fail result after you save?," , "Confirm" , 
                MessageBoxButtons.OKCancel,MessageBoxIcon.Information) != DialogResult.OK)
            {
                return;
            }

            if(rbPass.Checked)
            {
                TakeTestInfo.TestResult = true;
            }
            else
            {
                TakeTestInfo.TestResult = false;
            }

            TakeTestInfo.Notes = txtNotes.Text;
            TakeTestInfo.CreateByUserID = clsGlobalSettings.CurrentUser.UserID;

            if(TakeTestInfo.CheckAddNewTest())
            {
                MessageBox.Show("Data Saved Successfully.");
            }
            else
            {
                MessageBox.Show("Error: Data Is NOT Saved Successfully", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            this.Close();
        }


    }
}
