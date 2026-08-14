using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsTestType
    {


        public static DataTable GetAllTestType()
        {
            return clsTestTypeData.GetAllTestType();
        }

        public static bool UpdateTestType(int ID , string Title , string Description , decimal Fees)
        {
            return clsTestTypeData.UpdateTestType(ID, Title, Description, Fees);
        }


    }
}
