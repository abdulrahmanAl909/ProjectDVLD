using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsDriver
    {


        public static DataTable GetAllDriver()
        {
            return clsDriverData.GetAllDriver();
        }

        public static DataTable GetAllDriverByFilter(string ColumnName, int FilterBy)
        {
            return clsDriverData.GetAllDriverByFilter(ColumnName, FilterBy);
        }

        public static DataTable GetAllDriverByFilter(string ColumnName, string FilterBy)
        {
            return clsDriverData.GetAllDriverByFilter(ColumnName, FilterBy);
        }

        public static bool AddNewDriver(int PersonID,int CreateByUserID,DateTime CreateDate)
        {
            int DriverID = 0;

            DriverID = clsDriverData.AddNewDriver(PersonID, CreateByUserID, CreateDate);

            return (DriverID > 0);
        }


    }
}
