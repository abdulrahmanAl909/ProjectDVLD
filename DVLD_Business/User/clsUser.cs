using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsUser
    {

        clsPerson _PersonInfo;
        enum enMode { AddNew , Update}
        enMode Mode = enMode.AddNew;
        public int UserID { set; get; }

        public int PersonID { set; get; }

        public string UserName { set; get; }

        public string UserPassword { set; get; }

        public bool IsActive { set; get; }

        public clsUser()
        {
            this.UserID = 0;
            this.PersonID = 0;
            this.UserName = "";
            this.UserPassword = "";
            this.IsActive = false;

            _PersonInfo = new clsPerson();

            Mode = enMode.AddNew;
        }

        private clsUser(int UserID ,int PersonID,string UserName,string UserPassword ,bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.UserPassword = UserPassword;
            this.IsActive = IsActive;

            _PersonInfo = clsPerson.GetPersonInfoByID(PersonID);

            Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            return clsUserData.AddNewUser(this.UserID, this.PersonID, this.UserName, this.UserPassword, this.IsActive);
        }

        private bool _UpdateUser()
        {
            return false;
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }

    }
}
