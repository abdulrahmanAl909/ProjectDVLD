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
    public partial class ManagePeople : Form
    {
        public ManagePeople()
        {
            InitializeComponent();
        }

        public void ReflishTable()
        {
            dgvLoadPeople.DataSource = clsPeople.GetAllPeople();
            lblCountRecorde.Text = dgvLoadPeople.RowCount.ToString();
        }

        private void ManagePeople_Load(object sender, EventArgs e)
        {
            ReflishTable();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
