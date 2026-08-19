using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsLoaclApplication
    {

        enum enMode { Add , Update}
        enMode Mode = enMode.Add;

        public clsPerson PersonInfo;

        public int ApplicationID { set; get; }

        public int ApplicationPersonID { set; get; }

        public DateTime ApplicationDate { set; get; }

        public int ApplicationType { set; get; }

        public enApplicationStatus ApplicationStatus { set; get; }

        public DateTime LastStatusDate { set; get; }

        public decimal PaidFees { set; get; }

        public int CreatedByUserID { set; get; }

        public clsLoaclApplication()
        {
            this.ApplicationID = -1;
            this.ApplicationPersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationType = -1;
            this.ApplicationStatus = enApplicationStatus.AddNewApp;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = -1;
            this.CreatedByUserID = -1;

            PersonInfo = new clsPerson();

            Mode = enMode.Add;
        }

        private clsLoaclApplication(int ApplicationID,int PersonID , DateTime AppDate , int AppType , enApplicationStatus AppStatus ,
            DateTime LastStatusDate , decimal PaidFees , int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicationPersonID = PersonID; 
            this.ApplicationDate = AppDate;
            this.ApplicationType = AppType;
            this.ApplicationStatus = AppStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;

            PersonInfo = clsPerson.GetPersonInfoByID(PersonID);


            Mode = enMode.Update;
        }

        private bool _AddNewLocalApplication()
        {
            this.ApplicationID = clsLocalApplicationData.AddNewLocalApplication(this.ApplicationPersonID,
                this.ApplicationDate, this.ApplicationType,(byte) this.ApplicationStatus, this.LastStatusDate,
                this.PaidFees, this.CreatedByUserID);

            return (this.ApplicationID !=-1);
        }

        private bool _UpdateLocalApplication()
        {
            return clsLocalApplicationData.UpdateLocalApplication(this.ApplicationID, this.ApplicationPersonID,
                this.ApplicationDate, this.ApplicationType,(byte)this.ApplicationStatus, this.LastStatusDate,
                this.PaidFees, this.CreatedByUserID);
        }

        public static DataTable GetAllLocalApplication()
        {
            return clsLocalApplicationData.GetAllLocalApplication();
        }

        public static clsLoaclApplication GetApplicationByID(int AppID)
        {
            int ApplicationID = -1, PersonID = -1, AppType = -1, CreatedByUserID = -1;
            decimal PaidFees=-1;
            DateTime AppDate=DateTime.Now , LastStatusDate = DateTime.Now;
            byte AppStatus = 0;

            if (clsLocalApplicationData.GetApplicationInfoByID(AppID,ref PersonID,ref AppDate,
                ref AppType,ref AppStatus,ref LastStatusDate,ref PaidFees,ref CreatedByUserID))
            {
                return new clsLoaclApplication(AppID, PersonID, AppDate, AppType,(enApplicationStatus)AppStatus, LastStatusDate, PaidFees, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllApplicationByFilter(string ColumnName, int FilterBy)
        {
            return clsLocalApplicationData.GetAllApplicationByFilter(ColumnName, FilterBy);
        }

        public static DataTable GetAllApplicationByFilter(string ColumnName, string FilterBy)
        {
            return clsLocalApplicationData.GetAllApplicationByFilter(ColumnName, FilterBy);
        }

        public static DataTable GetAllApplicationByFilter(string ColumnName, byte FilterBy)
        {
            return clsLocalApplicationData.GetAllApplicationByFilter(ColumnName, FilterBy);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if(_AddNewLocalApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateLocalApplication();
            
            }
            return false;
        }
    }
}
