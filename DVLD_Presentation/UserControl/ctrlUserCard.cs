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
    public partial class ctrlUserCard : UserControl
    {

        public ctrlUserCard()
        {
            InitializeComponent();
        }



        //private void gbLoginInfo_Enter(object sender, EventArgs e)
        //{
        //    if (clsGlobalSettings.CurrentUser == null)
        //        return;

        //    lblUserID.Text = clsGlobalSettings.CurrentUser.UserID.ToString();
        //    lblUserName.Text = clsGlobalSettings.CurrentUser.UserName;
        //    lblIsUserActive.Text = clsGlobalSettings.CurrentUser.IsActive.ToString();
        //}

        //private void ctrlShowPersonDetails2_Load(object sender, EventArgs e)
        //{
        //    if (clsGlobalSettings.CurrentUser == null)
        //        return;

        //    ctrlShowPersonDetails2.LoadDataByPersonID(clsGlobalSettings.CurrentUser.PersonID);
        //}


        public void LoadDataForCureentUser()
        {
            if (clsGlobalSettings.CurrentUser == null)
                return;

            lblUserID.Text = clsGlobalSettings.CurrentUser.UserID.ToString();
            lblUserName.Text = clsGlobalSettings.CurrentUser.UserName;
            lblIsUserActive.Text = clsGlobalSettings.CurrentUser.IsActive.ToString();

            ctrlShowPersonDetails2.LoadDataByPersonID(clsGlobalSettings.CurrentUser.PersonID);
        }

        public void LoadDataForManageUser(int UserID)
        {
            clsUser UserInfo = clsUser.GetUserInfoByID(UserID);

            lblUserID.Text = UserInfo.UserID.ToString();
            lblUserName.Text = UserInfo.UserName.ToString();
            lblIsUserActive.Text = UserInfo.IsActive.ToString();

            ctrlShowPersonDetails2.LoadDataByPersonID(UserInfo.PersonID);
        }


    }
}