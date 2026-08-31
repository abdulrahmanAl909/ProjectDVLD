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
        int _LpaclID = -1;
        enTestType _TestType = enTestType.VisionTest;

        public frmTest(int LocalID,enTestType TestType)
        {
            InitializeComponent();

            _LpaclID = LocalID;
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

        private void frmTest_Load(object sender, EventArgs e)
        {
            ctrlL1.LoadDataForLocalApplication(_LpaclID);
            _FillInfoForTest();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            frmDateOfTest frm = new frmDateOfTest();

            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTakeTest frm = new frmTakeTest();

            frm.ShowDialog();
        }

        private void editTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDateOfTest frm = new frmDateOfTest();

            frm.ShowDialog();
        }
    }
}
