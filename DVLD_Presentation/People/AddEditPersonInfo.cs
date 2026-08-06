using DVLD_Business;
using DVLD_Presentation.Properties;
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
    public partial class AddEditPersonInfo : Form
    {

        enum enMode { AddNew , Update}

        enMode Mode = enMode.AddNew;

        int _PersonID;
        clsPerson _PersonInfo;

        private void _CheckIsNotEmptyText(TextBox textbox, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textbox.Text))
            {
                e.Cancel = true;
                textbox.Focus();
                epCheckText.SetError(textbox, "This Text is Required");
            }
            else
            {
                e.Cancel = false;
                epCheckText.SetError(textbox, "");
            }
        }

        public AddEditPersonInfo(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;

            if(_PersonID!=-1)
            {
                Mode = enMode.Update;
            }
            else
            {
                Mode = enMode.AddNew;
            }
        }

        private void _LoadData()
        {
            GetAlllCountryIn();
            cbCountry.SelectedIndex = 148;

            dtpDateOfBirth.MaxDate = DateTime.Today.AddYears(-18);
            dtpDateOfBirth.MinDate = DateTime.Today.AddYears(-100);

            if(Mode == enMode.AddNew)
            {
                lblAddEditPerson.Text = "Add New Person";
                _PersonInfo = new clsPerson();
                return;
            }

            _PersonInfo = clsPerson.GetPersonInfoByID(_PersonID);

            lblAddEditPerson.Text = "Update Person";

            lblPersonID.Visible = true;
            lblPersonID.Text = _PersonID.ToString();
            txtNationalNo.Text = _PersonInfo.NationalNo;
            txtFirstName.Text = _PersonInfo.FirstName;
            txtSecondName.Text = _PersonInfo.SecondName;
            txtLastName.Text = _PersonInfo.LastName;
            dtpDateOfBirth.Text = _PersonInfo.DateOfBirth.ToString();
            txtAddress.Text = _PersonInfo.Address;
            mtxtPhoneNumber.Text = _PersonInfo.Phone;

            if(_PersonInfo.ThirdName!="")
            {
                txtThirdName.Text = _PersonInfo.ThirdName;
            }

            if(_PersonInfo.Gendor==enGendor.Male)
            {
                rbMale.Checked = true;
                pbImagePath.Image = Resources.businessman;
            }
            else
            {
                rbFemale.Checked = true;
                pbImagePath.Image = Resources.businesswoman;

            }

            if (_PersonInfo.Email != "")
            {
                txtEmail.Text = _PersonInfo.Email;
            }

            if (_PersonInfo.ImagePath!="")
            {
                pbImagePath.Load(_PersonInfo.ImagePath);
            }

            llRemoveImage.Visible = (_PersonInfo.ImagePath != "");

            cbCountry.SelectedIndex = cbCountry.FindString(clsCountry.GetCountryByID(_PersonInfo.CountryID).CountryName);
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
            _LoadData();
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Asterisk.Play();
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {

            if(string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = false;
                epCheckText.SetError(txtEmail, "");
            }
            else
            {
                if (txtEmail.Text.EndsWith("@gmail.com"))
                {
                    e.Cancel = false;
                    epCheckText.SetError(txtEmail, "");
                }
                else
                {
                    e.Cancel = true;
                    txtEmail.Focus();
                    epCheckText.SetError(txtEmail, "Invaild Email Address Format!");
                }
            }
        }

        private void llImagePath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
             ofdSetImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
             ofdSetImage.FilterIndex = 1;
             ofdSetImage.RestoreDirectory = true;
      
             if (ofdSetImage.ShowDialog() == DialogResult.OK)
             {
                 // Process the selected file
                 string selectedFilePath = ofdSetImage.FileName;
                 //MessageBox.Show("Selected Image is:" + selectedFilePath);
      
                 pbImagePath.Load(selectedFilePath);
                 // ...
             }
         
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields have invalid information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int CountryID = clsCountry.GetCountryByName(cbCountry.Text).CountryID;
            _PersonInfo.NationalNo = txtNationalNo.Text;
            _PersonInfo.FirstName = txtFirstName.Text;
            _PersonInfo.SecondName = txtSecondName.Text;
            _PersonInfo.ThirdName = txtThirdName.Text;
            _PersonInfo.LastName = txtLastName.Text;
            _PersonInfo.DateOfBirth = dtpDateOfBirth.Value;
            _PersonInfo.Address = txtAddress.Text;
            _PersonInfo.Email = txtEmail.Text;
            _PersonInfo.Phone = mtxtPhoneNumber.Text;
            _PersonInfo.CountryID = CountryID;

            if(rbMale.Checked)
            {
                _PersonInfo.Gendor = enGendor.Male;
                pbImagePath.Image = Resources.businessman;
            }
            else
            {
                _PersonInfo.Gendor = enGendor.Femail;
                pbImagePath.Image = Resources.businesswoman;
            }

            if (pbImagePath.ImageLocation != null)
            {
                _PersonInfo.ImagePath = pbImagePath.ImageLocation;
            }
            else
            {
                _PersonInfo.ImagePath = "";
            }

            if(_PersonInfo.SavePerson())
            {
                MessageBox.Show("Data Saved Successfully.");
            }
            else
            {
                MessageBox.Show("Error: Data Is NOT Saved Successfully");
            }

            lblPersonID.Text = _PersonInfo.PersonID.ToString();
            lblAddEditPerson.Text = "Update Person";
            Mode = enMode.Update;

        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImagePath.ImageLocation = null;
            llRemoveImage.Visible = false;
        }

        private void IsNotEmptyText(object sender, CancelEventArgs e)
        {
            _CheckIsNotEmptyText((TextBox)sender, e);
        }


    }
}
