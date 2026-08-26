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
    public partial class frmLicenseHistory : Form
    {

        string _NationalNo = "";
        public frmLicenseHistory(string NationalNo)
        {
            InitializeComponent();

            _NationalNo = NationalNo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
            ctrlShowPersonDetails1.LoadDataByNationalNo(_NationalNo);
        }
    }
}
