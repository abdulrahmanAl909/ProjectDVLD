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

        public clsLicenseClass licenseClassInfo;

        private int _LocalApplicationID = 0;
        private int _ApplicationID = 0;
        private int _LicenseClassID = 0;

        public clsLoaclApplication()
        {
            this._LocalApplicationID = 0;
            this._ApplicationID = 0;
            this._LicenseClassID = 0;

            ApplicationInfo = new clsApplication();
        }

        private clsLoaclApplication(int LocalApplicationID, int ApplicationID ,int LicenseClassID)
        {
            this._LocalApplicationID = LocalApplicationID;
            this._ApplicationID = ApplicationID;
            this._LicenseClassID = LicenseClassID;

            ApplicationInfo = clsApplication.GetApplicationByID(ApplicationID);
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


    }
}
