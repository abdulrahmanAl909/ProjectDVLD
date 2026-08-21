using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsLicenseClass
    {
        enum enMode { AddNewLicenseClass , UpdateLicenseClass }
        enMode Mode = enMode.AddNewLicenseClass;

        public int LicenseClassID { set; get; }

        public string ClassName { set; get; }

        public string ClassDescription { set; get; }

        public byte MinimumAllowedAge { set; get; }

        public byte DefaultValidityLength { set; get; }

        public decimal ClassFees { set; get; }

        public clsLicenseClass()
        {
            this.LicenseClassID = 0;
            this.ClassName = "";
            this.ClassDescription = "";
            this.MinimumAllowedAge = 0;
            this.DefaultValidityLength = 0;
            this.ClassFees = 0;

            Mode = enMode.AddNewLicenseClass;
        }

        private clsLicenseClass(int LicenseClassID ,string ClassName ,string ClassDescriptionm,
            byte MinimumAllowedAge,byte DefaultValidityLength ,decimal ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescriptionm;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;

            Mode = enMode.UpdateLicenseClass;
        }

        public static DataTable GetAllLicenseClass()
        {
            return clsLicenseClassData.GetAllLicenseClass();
        }

        public static DataTable GetAllClassName()
        {
            return clsLicenseClassData.GetClassName();
        }

        public static clsLicenseClass GetLicenseClassByID(int LicenseClassID)
        {
            string ClassName = "", ClassDescriptionm = "";
            byte MinimumAllowedAge = 0, DefaultValidityLength = 0;
            decimal ClassFees = 0;

            if(clsLicenseClassData.GetLicenseClassByID(LicenseClassID ,ref ClassName,ref ClassDescriptionm,
            ref MinimumAllowedAge, ref DefaultValidityLength,ref ClassFees))
            {
                return new clsLicenseClass(LicenseClassID, ClassName,
                    ClassDescriptionm, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else
            {
                return null;
            }
        }


    }
}
