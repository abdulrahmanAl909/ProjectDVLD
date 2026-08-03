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

        private void ReflishTable()
        {
            dgvLoadPeople.DataSource = clsPerson.GetAllPeople();
            lblCountRecorde.Text = dgvLoadPeople.RowCount.ToString();
        }

        private void GetAllFilter()
        {
            DataTable dataTable = clsPerson.GetAllPeople();

            foreach(DataColumn column in dataTable.Columns)
            {
                cbFilterBy.Items.Add(column.ColumnName);
            }
        }

        private void ManagePeople_Load(object sender, EventArgs e)
        {
            ReflishTable();
            GetAllFilter();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
           Form frmAddEdit = new AddEditPersonInfo();

            frmAddEdit.ShowDialog();
        }

    }
}
