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
    public partial class frmDateOfTest : Form
    {
        //enTestType _TestType = enTestType.VisionTest;

        //clsLoaclApplication _LocalInfo;

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

        public frmDateOfTest(/*clsLoaclApplication LocalInfo , enTestType TestType*/)
        {
            InitializeComponent();

            //this._LocalInfo = LocalInfo;
            //this._TestType = TestType;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDateOfTest_Load(object sender, EventArgs e)
        {
            _FillInfoForTest();
        }
    }
}
