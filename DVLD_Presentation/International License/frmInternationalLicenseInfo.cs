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
    public partial class frmInternationalLicenseInfo : Form
    {
        int _InternationalID;
        public frmInternationalLicenseInfo(int InternationalID)
        {
            InitializeComponent();

            _InternationalID = InternationalID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlShowInternationalLicense1.LoadDataForLicense(_InternationalID);
        }
    }
}
