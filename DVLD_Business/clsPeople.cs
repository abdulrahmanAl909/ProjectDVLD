using DVLD_DataAccess;
using System;
using System.Data;


namespace DVLD_Business
{
    public class clsPeople
    {



        public static DataTable GetAllPeople()
        {
            return clsPeopleData.GetAllPeople();
        }


    }
}
