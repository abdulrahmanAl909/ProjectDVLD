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
    public partial class ctrlFilterPerson : UserControl
    {
        public ctrlFilterPerson()
        {
            InitializeComponent();
        }

        private void _GetInfoByFilter(int PersonID)
        {
            if(clsPerson.IsPersonExist(PersonID))
            {
                ctrlShowPersonDetails1.LoadDataByPersonID(PersonID);   
            }
            else
            {
                MessageBox.Show("No Person with Person ID = " + PersonID.ToString(),"Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void _GetInfoByFilter(string NationalNo)
        {
            if (clsPerson.IsPersonExist(NationalNo))
            {
                ctrlShowPersonDetails1.LoadDataByNationalNo(NationalNo);
            }
            else
            {
                MessageBox.Show("No Person with National No = " + NationalNo, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            AddEditPersonInfo frm = new AddEditPersonInfo(-1);

            frm.Show();
        }

        private void ctrlFilterPerson_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilterBy.Text!="PersonID")
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Asterisk.Play();
            }
        }

        private void btnFilterBy_Click(object sender, EventArgs e)
        {
            if(txtFilterBy.Text=="")
            {
                return;
            }

            if (cbFilterBy.Text == "PersonID")
            {
                _GetInfoByFilter(int.Parse(txtFilterBy.Text));
            }
            else
            {
                _GetInfoByFilter(txtFilterBy.Text);
            }
        }


    }
}
