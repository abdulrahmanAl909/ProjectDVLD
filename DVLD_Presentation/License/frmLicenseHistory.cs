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
    public partial class frmLicenseHistory : Form
    {

        int _PersonID;

        public frmLicenseHistory(int PersonID )
        {
            InitializeComponent();

            _PersonID = PersonID;
        }

        private void LoadData()
        {
            int DriverID = clsDriver.IsDriverExist(_PersonID);

            // for Local License 
            dgvDataForLocalLicense.DataSource = clsLicense.GetLicense(DriverID);
            lblCountRecordFroLocal.Text = dgvDataForLocalLicense.RowCount.ToString();

            //For International License
            dgvLoadDataForInternational.DataSource = clsInternationalLicense.GetInternationalLicense(DriverID);
            lblCountRecordForInternational.Text = dgvLoadDataForInternational.RowCount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
            LoadData();

            ctrlShowPersonDetails1.LoadDataByPersonID(_PersonID);
        }


    }
}
