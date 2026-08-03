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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD_Presentation
{
    public partial class AddEditPersonInfo : Form
    {
        public AddEditPersonInfo()
        {
            InitializeComponent();
        }

        private void GetAlllCountryIn()
        {
            DataTable dataTable = clsCountry.GetAllCountry();

            foreach (DataRow row in dataTable.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }

            cbCountry.SelectedIndex = 148;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEditPersonInfo_Load(object sender, EventArgs e)
        {
            GetAlllCountryIn();
            dtpDateOfBirth.MaxDate = DateTime.Today.AddYears(-18);
            dtpDateOfBirth.MinDate = DateTime.Today.AddYears(-100);
        }

    }
}
