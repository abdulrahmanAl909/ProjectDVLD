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
    public partial class frmShowLicenseInfo : Form
    {
        int _LicenseID;

        public frmShowLicenseInfo(int DriverID)
        {
            InitializeComponent();

            this._LicenseID = DriverID;
        }

        private void frmShowLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlLicenseDetails1.LoadDataForLicense(_LicenseID);
        }
    }
}
