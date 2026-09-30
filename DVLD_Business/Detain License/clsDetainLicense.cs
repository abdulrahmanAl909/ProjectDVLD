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
    public class clsDetainLicense
    { 

        public clsLicense LicenseInfo;

        public clsApplication ApplicationInfo;

        public int DetainID { set; get; }
        public int LicenseID { set; get; }
        public DateTime DetainDate { set; get; }
        public decimal FineFees { set; get; }
        public int CreatedByUserID { set; get; }
        public bool IsReleased { set; get; }

        public DateTime ReleaseDate { set; get; }
        public int ReleasedByUserID { set; get; }
        public int ReleaseApplicationID { set; get; }


        public clsDetainLicense()
        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = 1;
            this.CreatedByUserID = -1;
            this.IsReleased = false;

            this.ReleaseDate = DateTime.Now;
            this.ReleasedByUserID = -1;
            this.ReleaseApplicationID = -1;

            LicenseInfo = new clsLicense();
            ApplicationInfo = new clsApplication();
        }

        private clsDetainLicense(int DetainID, int LicenseID, DateTime DetainDate,decimal FineFees,int CreatedByUserID
            ,bool IsReleased, DateTime ReleaseDate , int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;

            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;

            LicenseInfo = clsLicense.GetLicenseByID(LicenseID);
            ApplicationInfo = new clsApplication();
        }

        public static DataTable GetAllDetains()
        {
            return clsDetainLicenseData.GetAllDetains();
        }

        public static DataTable GetAllDetainsByFilter(string ColumnName, int FilterBy)
        {
            return clsDetainLicenseData.GetAllDetainsByFilter(ColumnName, FilterBy);
        }

        public static DataTable GetAllDetainsByFilter(string ColumnName, string FilterBy)
        {
            return clsDetainLicenseData.GetAllDetainsByFilter(ColumnName, FilterBy);
        }

        public static DataTable GetAllDetainsByFilter(string ColumnName, bool FilterBy)
        {
            return clsDetainLicenseData.GetAllDetainsByFilter(ColumnName, FilterBy);
        }

        public static clsDetainLicense GetDetainByID(int DetainID)
        {
            int LicenseID = -1,ReleasedByUserID = -1, ReleaseApplicationID = -1, CreatedByUserID = -1;
            DateTime DetainDate = DateTime.Now, ReleaseDate = DateTime.Now;
            decimal FineFees = 1;
            bool IsReleased = false;

            if(clsDetainLicenseData.GetDetainByID(DetainID ,ref LicenseID ,ref DetainDate ,ref FineFees ,ref CreatedByUserID ,
               ref IsReleased ,ref ReleaseDate ,ref ReleasedByUserID ,ref ReleaseApplicationID ))
            {
                return new clsDetainLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID,
                    IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }
            else
            {
                return null;
            }
        }

        public static clsDetainLicense GetDetainByLicenseID(int LicenseID)
        {
            int DetainID = -1, ReleasedByUserID = -1, ReleaseApplicationID = -1, CreatedByUserID = -1;
            DateTime DetainDate = DateTime.Now, ReleaseDate = DateTime.Now;
            decimal FineFees = 1;
            bool IsReleased = false;

            if (clsDetainLicenseData.GetDetainByLicenseID(ref DetainID ,LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID,
               ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new clsDetainLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID,
                    IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }
            else
            {
                return null;
            }
        }


        public bool AddDetain()
        {
            this.DetainID = clsDetainLicenseData.AddDetain(LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased);

            return (this.DetainID != -1);
        }

        public bool UpdateDetain()
        {
            return clsDetainLicenseData.UpdateDetain(this.DetainID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);
        }

        public static bool GetIsRelease(int DetainID)
        {
            return clsDetainLicenseData.GetIsRelease(DetainID);
        }

        public static bool IsLicenseDetain(int LicenseID)
        {
            return clsDetainLicenseData.IsLicenseDetain(LicenseID);
        }

    }
}
