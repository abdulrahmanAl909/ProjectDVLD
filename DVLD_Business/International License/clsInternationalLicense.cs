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

        public clsLicense LicenseInfo;

        public int InternationalLicenseID { set; get; }

        public int ApplicationID { set; get; }

        public int DriverID { set; get; }
        public int IssuedUsingLocalLicenseID { set; get; }

        public DateTime IssueDate { set; get; }

        public DateTime ExpirationDate { set; get; }

        public bool IsActive { set; get; }

        public int CreateByUserID { set; get; }

        public clsInternationalLicense()
        {
            this.InternationalLicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.IsActive = false;
            this.CreateByUserID = -1;

            ApplicationInfo = new clsApplication();
            LicenseInfo = new clsLicense();
        }

        private clsInternationalLicense(int InternationalLicenseID , int ApplicationID , int DriverID , int IssuedUsingLocalLicenseID
            , DateTime IssueDate , DateTime ExpirationDate , bool IsActive , int CreateByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreateByUserID = CreateByUserID;

            ApplicationInfo = clsApplication.GetApplicationByID(ApplicationID);
            LicenseInfo = clsLicense.GetLicenseByID(IssuedUsingLocalLicenseID);
        }


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

        public static bool IsInternationalExsit(int LicenseID)
        {
            return clsInternationalLicenseData.IsInternationalExsit(LicenseID);
        }

        public static clsInternationalLicense GetInternaionalByID(int InternationalID)
        {
            int ApplicationID = -1, DriverID = -1, IssuedUsingLocalLicenseID = -1, CreateByUserID = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            bool IsActive = false;

            if(clsInternationalLicenseData.GetInternaionalByID(InternationalID ,ref ApplicationID ,ref DriverID ,
              ref IssuedUsingLocalLicenseID ,ref IssueDate ,ref ExpirationDate ,ref IsActive ,ref CreateByUserID))
            {
                return new clsInternationalLicense(InternationalID, ApplicationID, DriverID,
                    IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreateByUserID);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetInternationalLicense(int DriverID)
        {
            return clsInternationalLicenseData.GetInternationalLicense(DriverID);
        }

        public bool AddNewInternational()
        {
            this.InternationalLicenseID = clsInternationalLicenseData.AddNewInternational(this.ApplicationID, this.DriverID
                , this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreateByUserID);

            return (this.InternationalLicenseID != -1);
        }


    }
}
