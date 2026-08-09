using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsCountry
    {

        public int CountryID { set; get; }

        public string CountryName { set; get; }

        public clsCountry(int CountryID , string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }

        public static clsCountry GetCountryByID(int CountryID)
        {
            string CountryName = "";

            if(clsCountryData.GetCountryByID(CountryID,ref CountryName))
            {
                return new clsCountry(CountryID, CountryName);
            }
            else
            {
                return null;
            }
        }

        public static clsCountry GetCountryByName(string CountryName)
        {
            int CountryID = -1;

            if (clsCountryData.GetCountryByName(ref CountryID, CountryName))
            {
                return new clsCountry(CountryID, CountryName);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllCountry()
        {
            return clsCountryData.GetAllCountry();
        }

    }
}
