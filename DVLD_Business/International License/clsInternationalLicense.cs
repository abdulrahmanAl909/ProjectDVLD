using DVLD_Business.Application;
using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsInternationalLicense
    {
        public clsApplication ApplicationInfo;

        public clsDriver DriverInfo;

        public clsLoaclApplication LoaclApplicationInfo;

        public int InternationalLicenseID { set; get; }

        public int ApplicationID { set; get; }

        public int DriverID { set; get; }
        public int IssuedUsingLocalLicenseID { set; get; }

        public DateTime IssueDate { set; get; }

        public DateTime ExpirationDate { set; get; }

        public bool IsActive { set; get; }

        public int CreateByUserID { set; get; }


        public static DataTable GetAllInternationalLicense()
        {
            return clsInternationalLicenseData.GetAllInternationalLicense();
        }

        public static DataTable GetAllLicenseByFilter(string ColumnName, int FilterBy)
        {
            return clsInternationalLicenseData.GetAllLicenseByFilter(ColumnName, FilterBy);
        }

        public static DataTable GetAllLicenseByFilter(string ColumnName, bool FilterBy)
        {
            return clsInternationalLicenseData.GetAllLicenseByFilter(ColumnName, FilterBy);
        }


    }
}
