using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        private bool _AddNewApplication()
        {
            this.ApplicationID = clsLocalApplicationData.AddNewApplication(this.ApplicationPersonID,
                this.ApplicationDate, this.ApplicationType,(byte) this.ApplicationStatus, this.LastStatusDate,
                this.PaidFees, this.CreatedByUserID);

            return (this.ApplicationID !=-1);
        }

        private bool _UpdateApplication()
        {
            return clsLocalApplicationData.UpdateApplication(this.ApplicationID, this.ApplicationPersonID,
                this.ApplicationDate, this.ApplicationType,(byte)this.ApplicationStatus, this.LastStatusDate,
                this.PaidFees, this.CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if(_AddNewApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateApplication();
            
            }
            return false;
        }
    }
}
