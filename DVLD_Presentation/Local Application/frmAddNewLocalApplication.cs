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
        public frmAddNewLocalApplication()
        {
            InitializeComponent();
        }

        private void _LoadInfoForApplication()
        {
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            cbLicenseClass.SelectedIndex = 3;
            lblCteatedByUser.Text = clsGlobalSettings.CurrentUser.UserName;
        }

        private void frmAddNewLocalApplication_Load(object sender, EventArgs e)
        {
            _LoadInfoForApplication();

            MessageBox.Show(cbLicenseClass.SelectedIndex.ToString());
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
