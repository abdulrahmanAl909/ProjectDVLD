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
            this.UserID= clsUserData.AddNewUser( this.PersonID, this.UserName, this.UserPassword, this.IsActive);
            return (UserID !=-1);
        }

        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.UserID, this.PersonID, this.UserName, this.UserPassword, this.IsActive);

        }

        public static clsUser GetUserInfoByNameandPassword(string UserName , string Password)
        {
            int UserID = -1, PersonID = -1;
            bool IsActive = false;

            if(clsUserData.GetUserInfoByUserNameAndPassword(ref UserID,ref PersonID,UserName,Password,ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public static DataTable GetAllColumnName()
        {
            return clsUserData.GetAllColumnName();
        }

        public static DataTable GetAllIsActive(string ColumnName , bool FilterBy)
        {
            return clsUserData.GetAllIsActive(ColumnName, FilterBy);
        }

        public static clsUser GetUserInfoByID(int UserID)
        {
            int PersonID = -1;
            string UserName = "", UserPassword = "";
            bool IsActive = false;

            if(clsUserData.GetUserInfoByID(UserID,ref PersonID,ref UserName,ref UserPassword ,ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, UserPassword, IsActive);
            }
            else
            {
                return null;
            }
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }

        public static bool IsUserExist(int UserID)
        {
            return clsUserData.IsUserExist(UserID);
        }

        public static bool ChangePassword(int ID , string Password)
        {
            return clsUserData.ChangePasswor(ID, Password);
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
