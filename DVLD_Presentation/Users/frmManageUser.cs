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
    public partial class frmManageUser : Form
    {
        public frmManageUser()
        {
            InitializeComponent();
        }

        private void _RefrishUser()
        {
            dgvUser.DataSource = clsUser.GetAllUsers();
            lblCountRecord.Text = dgvUser.RowCount.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageUser_Load(object sender, EventArgs e)
        {
            _RefrishUser();
        }
    }
}
