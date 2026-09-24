using DVLD_Business.Application;
using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsLicense
    {
        public clsApplication ApplicationInfo;

        public clsDriver DriverInfo;

        public clsLicenseClass LicenseClassInfo;

        public int LicenseID { set; get; }

        public int ApplicationID { set; get; }

        public int DriverID { set; get; }

        public int LicenseClass { set; get; }

        public DateTime IssueDate { set; get; }

        public DateTime ExpirationDate { set; get; }

        public string Notes { set; get; }

        public decimal PaidFees { set; get; }

        public bool IsActive { set; get; }

        public enIssueReason IssueReason { set; get; }

        public int CreatedByUserID { set; get; }


        public clsLicense()
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClass = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = -1;
            this.IsActive = false;
            this.IssueReason = enIssueReason.FirstTime;
            this.CreatedByUserID = -1;

            ApplicationInfo = new clsApplication();
            DriverInfo = new clsDriver();
            LicenseClassInfo = new clsLicenseClass();
        }

        private clsLicense(int LicenseID,int ApplicationID , int DriverID , int LicenseClass ,DateTime IssueDate 
            ,DateTime ExpirationDate,string Notes,decimal PaidFees,bool IsActive, enIssueReason IssueReason,int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClass = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;

            ApplicationInfo = clsApplication.GetApplicationByID(ApplicationID);
            LicenseClassInfo = clsLicenseClass.GetLicenseClassByID(LicenseClass);

        }

        public clsLicense(int LocalID)
        {
            clsLoaclApplication LocalInfo = clsLoaclApplication.GetLocalApplicationByID(LocalID);

            this.ApplicationInfo = LocalInfo.ApplicationInfo;
            this.LicenseClassInfo = LocalInfo.LicenseClassInfo;
        }

        public bool AddNewLicense()
        {
            this.LicenseID = clsLicenseData.AddNewLicense(ApplicationID, DriverID, LicenseClass, IssueDate
                , ExpirationDate, Notes, PaidFees, IsActive,(byte)IssueReason, CreatedByUserID);

            return (this.LicenseID != -1);
        }

        public static DataTable GetLicense(int DriverID)
        {
            return clsLicenseData.GetLicense(DriverID);
        }

        public static clsLicense GetLicenseByID(int LicenseID)
        {
            int ApplicationID = -1, DriverID = -1, LicenseClass = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            string Notes = "";
            decimal PaidFees = 1;
            bool IsActive = false;
            byte IssueReason =1;
            
            if(clsLicenseData.GetLicenseByID(LicenseID,ref ApplicationID,ref DriverID , ref LicenseClass
                ,ref IssueDate, ref ExpirationDate,ref Notes , ref PaidFees , ref IsActive ,ref IssueReason
                ,ref CreatedByUserID))
            {
                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate
                    , ExpirationDate, Notes, PaidFees, IsActive,(enIssueReason)IssueReason, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        public static int GetLicenseIDByApplicationID(int ApplicationID)
        {
            return clsLicenseData.GetLicenseIDByApplicationID(ApplicationID);
        }

        public static bool IsDriverHasLicense(int DriverID , int LicenseClassID)
        {
            return clsLicenseData.IsDriverHasLicense(DriverID, LicenseClassID);
        }

    }
}
