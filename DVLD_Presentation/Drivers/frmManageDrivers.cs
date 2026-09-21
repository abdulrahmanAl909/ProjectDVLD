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
    public partial class frmManageDrivers : Form
    {
        public frmManageDrivers()
        {
            InitializeComponent();
        }

        private void _ReflishData()
        {
            dgvShowDriver.DataSource = clsDriver.GetAllDriver();
            lblCountRecord.Text = dgvShowDriver.RowCount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            _ReflishData();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "None")
            {
                txtFilterBy.Visible = false;
                cbIsActive.Visible = false;
            }
            else if (cbFilterBy.Text == "IsActive")
            {
                txtFilterBy.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.SelectedIndex = 0;
            }
            else
            {
                txtFilterBy.Visible = true;
                cbIsActive.Visible = false;
                txtFilterBy.Clear();
            }
            _ReflishData();
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "FullName" || cbFilterBy.Text == "NationalNo")
            {
                dgvShowDriver.DataSource = clsDriver.GetAllDriverByFilter(cbFilterBy.Text, txtFilterBy.Text);
                lblCountRecord.Text = dgvShowDriver.RowCount.ToString();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFilterBy.Text))
            {
                _ReflishData();
            }
            else
            {
                dgvShowDriver.DataSource = clsDriver.GetAllDriverByFilter(cbFilterBy.Text, int.Parse(txtFilterBy.Text));
                lblCountRecord.Text = dgvShowDriver.RowCount.ToString();
            }
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIsActive.Text == "All")
            {
                _ReflishData();
            }
            else
            {
                if (cbIsActive.Text == "Yes")
                {
                    dgvShowDriver.DataSource = clsDriver.GetAllDriverByFilter("ActiveLicense", "1");
                }
                else
                {
                    dgvShowDriver.DataSource = clsDriver.GetAllDriverByFilter("ActiveLicense", "0");
                }
                lblCountRecord.Text = dgvShowDriver.RowCount.ToString();
            }
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "FullName" || cbFilterBy.Text=="NationalNo")
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Asterisk.Play();
            }
        }

    }
}
