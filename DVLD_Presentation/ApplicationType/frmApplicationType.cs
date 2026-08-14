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
    public partial class frmApplicationType : Form
    {
        public frmApplicationType()
        {
            InitializeComponent();
        }

        private void _ReflieshData()
        {
            dgvManageApp.DataSource = clsApplicationType.GetAllApplicationsType();
            lblcountRecord.Text = dgvManageApp.RowCount.ToString();
            dgvManageApp.Columns["Title"].AutoSizeMode =DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmApplicationType_Load(object sender, EventArgs e)
        {
            _ReflieshData();
        }

        private void editFeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateApplicationType frm = new frmUpdateApplicationType((int)dgvManageApp.CurrentRow.Cells[0].Value,
                (string)dgvManageApp.CurrentRow.Cells[1].Value, (decimal)dgvManageApp.CurrentRow.Cells[2].Value);

            frm.ShowDialog();
            _ReflieshData();
        }
    }
}
