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
    public partial class frmTest : Form
    {
        int _LoaclID = -1;
        enTestType _TestType = enTestType.VisionTest;

        bool? ResultOfTakeTest=null;

        private void _LoadDataForTestAppointment()
        {
            dgvTestAppointment.DataSource = clsTestAppointment.GetAllTestAppointment(_LoaclID, (int)_TestType);
            lblCountRecord.Text = dgvTestAppointment.RowCount.ToString();

            if(dgvTestAppointment.Rows.Count!=0)
            {
                ResultOfTakeTest = clsTakeTest.CheckTestResult((int)dgvTestAppointment.CurrentRow.Cells[0].Value);
            }
        }

        public frmTest(int LocalID,enTestType TestType)
        {
            InitializeComponent();

            _LoaclID = LocalID;
            _TestType = TestType;
        }

        private void _FillInfoForTest()
        {
            if(_TestType==enTestType.VisionTest)
            {
                pbTestImage.Image = Resources.ChatGPT_Image_Aug_23__2026__02_37_44_PM3;
                pbTestImage.SizeMode = PictureBoxSizeMode.StretchImage;
                lblTitle.Text = "Vision Test Appointments";
            }
            else if(_TestType == enTestType.WriteTest)
            {
                pbTestImage.Image = Resources.ChatGPT_Image_Aug_29__2026__06_57_41_AM__1_;
                pbTestImage.SizeMode = PictureBoxSizeMode.StretchImage;
                lblTitle.Text = "Write Test Appointments";
            }
            else
            {
                pbTestImage.Image = Resources.ChatGPT_Image_Aug_29__2026__08_59_25_AM555;
                pbTestImage.SizeMode = PictureBoxSizeMode.StretchImage;
                lblTitle.Text = "Street Test Appointments";
            }
        }

        private void ctrlL1_Load(object sender, EventArgs e)
        {
            _LoadDataForTestAppointment();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            ctrlL1.LoadDataForLocalApplication(_LoaclID);

            _FillInfoForTest();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if(clsTestAppointment.IsAppointmentExsit(_LoaclID,(int)_TestType,false))
            {
                MessageBox.Show("Person Already have an active appointment for this test, You cannot" +
                    "add new appointment", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // if he pass the test and else to fail the test
            if(ResultOfTakeTest==true)
            {
                MessageBox.Show("This person already passed this test before,you can olny retake failed" +
                    " test", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(ResultOfTakeTest==false)
            {
                //go to test appoiment for retake test
                frmTestAppointment frm1 = new frmTestAppointment(_LoaclID, _TestType ,false);

                frm1.ShowDialog();
                _LoadDataForTestAppointment();
                return;
            }

            frmTestAppointment frm = new frmTestAppointment(_LoaclID, _TestType);

            frm.ShowDialog();
            _LoadDataForTestAppointment();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTakeTest frm = new frmTakeTest((int)dgvTestAppointment.CurrentRow.Cells[0].Value , _TestType);

            frm.DataBack += TestResult;

            frm.ShowDialog();

            _LoadDataForTestAppointment();
        }

        private void TestResult(bool TestResult, int TestAppointmentID)
        {
            this.ResultOfTakeTest = TestResult;

            if(!clsTestAppointment.ChangeIsLockedToTrue(TestAppointmentID))
            {
                MessageBox.Show("Something is Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ResultOfTakeTest==false)
            {
                frmTestAppointment frm1 = new frmTestAppointment((int)dgvTestAppointment.CurrentRow.Cells[0].Value, _LoaclID, _TestType, false);

                frm1.ShowDialog();
                _LoadDataForTestAppointment();
                return;
            }

            frmTestAppointment frm = new frmTestAppointment((int)dgvTestAppointment.CurrentRow.Cells[0].Value,_LoaclID,_TestType);

            frm.ShowDialog();
            _LoadDataForTestAppointment();
        }

    }
}
