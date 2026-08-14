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
    public partial class UpdateTestType : Form
    {
        int _ID = 0;
        string _Title ="";
        string _Description ="";
        decimal _Fees = -1;

        public UpdateTestType(int ID , string Title , string Description , decimal Fees)
        {
            InitializeComponent();

            _ID = ID;
            _Title = Title;
            _Description = Description;
            _Fees = Fees;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(clsTestType.UpdateTestType(_ID , _Title , _Description ,decimal.Parse(txtFees.Text)))
            {
                MessageBox.Show("Data Saved Successfully", "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Not Saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTestType_Load(object sender, EventArgs e)
        {
            lblID.Text = _ID.ToString();
            txtTitle.Text = _Title;
            txtDescription.Text = _Description;
            txtFees.Text = _Fees.ToString();
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)8)
            {
                e.Handled = true;
                SystemSounds.Asterisk.Play();
            }

            if (e.KeyChar == '.' && txtFees.Text.Contains("."))
            {
                e.Handled = true;
                SystemSounds.Asterisk.Play();
            }
        }
    }
}
