using DVLD_Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Presentation
{
    public static class clsGlobalSettings
    {
        public static clsUser CurrentUser { set; get; }

        public static clsUser FillCurrentUser(string UserName, string Password)
        {
            return (CurrentUser = clsUser.GetUserInfoByNameandPassword(UserName, Password));
        }
    }
}
