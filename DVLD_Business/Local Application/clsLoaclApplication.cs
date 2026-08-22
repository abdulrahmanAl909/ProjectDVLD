using DVLD_Business.Application;
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

        public clsApplication ApplicationInfo;

        public clsLicenseClass LicenseClassInfo;

        public int LocalApplicationID { set; get; }
        public int ApplicationID  { set; get; } 
        public int LicenseClassID { set; get; }

        public clsLoaclApplication()
        {
            this.LocalApplicationID = 0;
            this.ApplicationID = 0;
            this.LicenseClassID = 0;

            Mode = enMode.Add;


            ApplicationInfo = new clsApplication();
        }

        private clsLoaclApplication(int LocalApplicationID, int ApplicationID ,int LicenseClassID)
        {
            this.LocalApplicationID = LocalApplicationID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;

            Mode = enMode.Update;

            ApplicationInfo = clsApplication.GetApplicationByID(ApplicationID);
            LicenseClassInfo = clsLicenseClass.GetLicenseClassByID(LicenseClassID);
        }

        private bool _AddNewLocalApplication()
        {
            this.LocalApplicationID = clsLocalApplicationData.AddNewLocalApplication(ApplicationID, LicenseClassID);

            return (this.LocalApplicationID != -1);
        }

        private bool _UpdateLocalApplication()
        {
            return clsLocalApplicationData.UpdateLocalApplication(this.LocalApplicationID, this.LicenseClassID);
        }

        public static DataTable GetAllLocalApplication()
        {
            return clsLocalApplicationData.GetAllLocalApplication();
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

        public static clsLoaclApplication GetLocalApplicationByID(int LocalApplication)
        {
            int ApplicationID = 0, LicenseClassID = 0;

            if(clsLocalApplicationData.GetLocalApplicationByID(LocalApplication,ref ApplicationID, ref LicenseClassID))
            {
                return new clsLoaclApplication(LocalApplication, ApplicationID, LicenseClassID);
            }
            else
            {
                return null;
            }
        }

        public static bool CancelApplication(int LocalApplication)
        {
            clsLoaclApplication LocalInfo = clsLoaclApplication.GetLocalApplicationByID(LocalApplication);
            if(LocalInfo!=null && clsApplication.ChangeStatus(LocalInfo.ApplicationID,enApplicationStatus.Cancelled))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool CheckHasOrder()
        {
            return clsLocalApplicationData.CheckHasOrder(ApplicationInfo.ApplicationPersonID,ApplicationInfo.ApplicationType , (byte)enApplicationStatus.AddNewApp);
        }

        public bool Save()
        {
            if (ApplicationInfo.Save())
            {
                ApplicationID = ApplicationInfo.ApplicationID;
                switch (Mode)
                {
                    case enMode.Add:
                        if (_AddNewLocalApplication())
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
            }
            else
            {
                return false;
            }
                return false;
        }

    }
}
