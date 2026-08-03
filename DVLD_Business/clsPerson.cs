using DVLD_DataAccess;
using System;
using System.Data;


namespace DVLD_Business
{
    public class clsPerson
    {



        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }


    }
}
