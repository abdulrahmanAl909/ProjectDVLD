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
    public partial class ManagePeople : Form
    {
        public ManagePeople()
        {
            InitializeComponent();
        }

        private void _RefreshPeople()
        {
            dgvLoadPeople.DataSource = clsPerson.GetAllPeople();
            lblCountRecorde.Text = dgvLoadPeople.RowCount.ToString();
        }

        private void GetAllFilter()
        {
            DataTable dataTable = clsPerson.GetAllColumnName();

            foreach(DataColumn column in dataTable.Columns)
            {
                cbFilterBy.Items.Add(column.ColumnName);
            }
        }

        private void ManagePeople_Load(object sender, EventArgs e)
        {
            _RefreshPeople();
            GetAllFilter();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            AddEditPersonInfo frmAddEdit = new AddEditPersonInfo(-1);

            frmAddEdit.ShowDialog();
            _RefreshPeople();

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonDetails frmShowPersonDetails = new PersonDetails((int)dgvLoadPeople.CurrentRow.Cells[0].Value);

            frmShowPersonDetails.ShowDialog();
            _RefreshPeople();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete person[" + dgvLoadPeople.CurrentRow.Cells[0].Value + "]","Delete Person" , MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (clsPerson.DeletePerson((int)dgvLoadPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Delete Successfully");
                    _RefreshPeople();
                }
                else
                {
                    MessageBox.Show("Person is NOT Delete");
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditPersonInfo frm = new AddEditPersonInfo((int)dgvLoadPeople.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
            _RefreshPeople();

        }

        private void cmsEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void cmsPhone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterBy.Visible = true;

            if(cbFilterBy.Text=="Gendor")
            {
                // doing late
            }
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            dgvLoadPeople.DataSource = clsPerson.GetAllPeopleByFilter(cbFilterBy.Text, txtFilterBy.Text);

            if(txtFilterBy.Text=="")
            {
                _RefreshPeople();
            }
        }
    }
}


