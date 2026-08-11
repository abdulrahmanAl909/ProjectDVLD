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
    public partial class ctrlUserCard : UserControl
    {
        public ctrlUserCard()
        {
            InitializeComponent();
        }

        private void ctrlShowPersonDetails1_Load(object sender, EventArgs e)
        {
            lblUserID.Text = clsGlobalSettings.CurrentUser.UserID.ToString();
            lblUserName.Text = clsGlobalSettings.CurrentUser.UserName;
            lblIsUserActive.Text = clsGlobalSettings.CurrentUser.IsActive.ToString();

            ctrlShowPersonDetails1.LoadDataByPersonID(clsGlobalSettings.CurrentUser.PersonID);
        }
    }
}
