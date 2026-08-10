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
    public partial class ctrlShowPersonDetails : UserControl
    {
        int _PersonID = -1;

        string _NationalNo = "";
        public ctrlShowPersonDetails()
        {
            InitializeComponent();

        }

        public void LoadDataByPersonID(int PersonID)
        {
            _PersonID = PersonID;

            clsPerson PersonInfo = clsPerson.GetPersonInfoByID(PersonID);

            lblPersonID.Text = PersonID.ToString();
            lblNationalNo.Text = PersonInfo.NationalNo;
            lblName.Text = PersonInfo.FullName;
            lblDateOfBirth.Text = PersonInfo.DateOfBirth.ToShortDateString();
            lblGendor.Text = PersonInfo.Gendor.ToString();
            lblAddress.Text = PersonInfo.Address;
            lblPhone.Text = PersonInfo.Phone;
            lblEmail.Text = PersonInfo.Email;

            lblCountry.Text = clsCountry.GetCountryByID(PersonInfo.CountryID).CountryName;
            
            if(PersonInfo.ImagePath!="")
            {
                pbImagePath.Load(PersonInfo.ImagePath);
            }
            else
            {
                pbImagePath.Visible = false;
            }
        }

        public void LoadDataByNationalNo(string NationalNo)
        {
            _NationalNo = NationalNo;

            clsPerson PersonInfo = clsPerson.GetPersonInfoByNationalNo(NationalNo);

            lblPersonID.Text = PersonInfo.PersonID.ToString();
            lblNationalNo.Text = PersonInfo.NationalNo;
            lblName.Text = PersonInfo.FullName;
            lblDateOfBirth.Text = PersonInfo.DateOfBirth.ToShortDateString();
            lblGendor.Text = PersonInfo.Gendor.ToString();
            lblAddress.Text = PersonInfo.Address;
            lblPhone.Text = PersonInfo.Phone;
            lblEmail.Text = PersonInfo.Email;

            lblCountry.Text = clsCountry.GetCountryByID(PersonInfo.CountryID).CountryName;

            if (PersonInfo.ImagePath != "")
            {
                pbImagePath.Load(PersonInfo.ImagePath);
            }
            else
            {
                pbImagePath.Visible = false;
            }
        }


        private void llEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddEditPersonInfo frm = new AddEditPersonInfo(_PersonID);

            frm.ShowDialog();
            LoadDataByPersonID(_PersonID);
        }

    }
}
