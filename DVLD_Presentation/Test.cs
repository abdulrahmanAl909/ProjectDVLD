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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

     
        private void Test_Load(object sender, EventArgs e)
        {
            DataTable dataTable = clsCountry.GetAllCountry();

            foreach (DataRow row in dataTable.Rows)
            {
                comboBox1.Items.Add(row["CountryName"]);
            }
            
        }
    }
}
