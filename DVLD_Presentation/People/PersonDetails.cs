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
    public partial class PersonDetails : Form
    {

        int _PersonID;
        public PersonDetails(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PersonDetails_Load(object sender, EventArgs e)
        {
            ctrlShowPersonDetails1.LoadData(_PersonID);
        }
    }
}
