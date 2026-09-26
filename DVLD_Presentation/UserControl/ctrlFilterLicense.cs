using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation
{
    public partial class ctrlFilterLicense : UserControl
    {
        public event Action<int> OnSearshForLicense;

        protected virtual void SearshCompleted(int LicenseID)
        {
            Action<int> handler = OnSearshForLicense;
            if(handler!=null)
            {
                handler(LicenseID);
            }
        }

        public ctrlFilterLicense()
        {
            InitializeComponent();
        }

        private void btnFilterLicense_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtFilter.Text))
            {
                MessageBox.Show("You Must Put Number Of License ID", "Put Number!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(ctrlLicenseDetails2.LoadDataForLicense(int.Parse(txtFilter.Text))==true)
            {
                if (OnSearshForLicense != null)
                    SearshCompleted(int.Parse(txtFilter.Text));
            }
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Asterisk.Play();
            }
        }


    }
}
