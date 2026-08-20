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


        public static DataTable GetAllLicenseClass()
        {
            return clsLicenseClassData.GetAllLicenseClass();
        }

        public static DataTable GetAllClassName()
        {
            return clsLicenseClassData.GetClassName();
        }


    }
}
