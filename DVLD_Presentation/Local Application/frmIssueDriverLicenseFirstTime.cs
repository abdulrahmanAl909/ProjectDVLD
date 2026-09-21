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
    public partial class frmIssueDriverLicenseFirstTime : Form
    {
        int _LocalID;

        public frmIssueDriverLicenseFirstTime(int LocalID)
        {
            InitializeComponent();

            this._LocalID = LocalID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IssueDriverLicenseFirstTime_Load(object sender, EventArgs e)
        {
            ctrlL1.LoadDataForLocalApplication(_LocalID);
        }
    }
}
