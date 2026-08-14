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
    public partial class TestType : Form
    {
        public TestType()
        {
            InitializeComponent();
        }

        private void _RefileshData()
        {
            dgvTestType.DataSource = clsTestType.GetAllTestType();
            lblCountRecord.Text = dgvTestType.RowCount.ToString();
        }

        private void TestType_Load(object sender, EventArgs e)
        {
            _RefileshData();
            dgvTestType.Columns["Title"].Width = 200;
            dgvTestType.Columns["Description"].Width = 300;
            dgvTestType.Columns["Fees"].Width = 130;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateTestType frm = new UpdateTestType((int)dgvTestType.CurrentRow.Cells[0].Value,
                (string)dgvTestType.CurrentRow.Cells[1].Value, (string)dgvTestType.CurrentRow.Cells[2].Value,
                (decimal)dgvTestType.CurrentRow.Cells[3].Value);

            frm.ShowDialog();
            _RefileshData();
                
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
