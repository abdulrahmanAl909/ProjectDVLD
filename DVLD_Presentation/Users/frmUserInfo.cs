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
    public partial class frmUserInfo : Form
    {
        enum enStateUser { CureentUser, ManageUser }
        enStateUser StateUser = enStateUser.CureentUser;

        int _UserID = -1;

        public frmUserInfo()
        {
            InitializeComponent();

            StateUser = enStateUser.CureentUser;
        }

        public frmUserInfo(int UserID)
        {
            InitializeComponent();

            StateUser = enStateUser.ManageUser;

            _UserID = UserID;
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            if(StateUser == enStateUser.CureentUser)
            {
                ctrlUserCard2.LoadDataForCureentUser();
            }
            else
            {
                ctrlUserCard2.LoadDataForManageUser(_UserID);
            }
        }
    }
}
