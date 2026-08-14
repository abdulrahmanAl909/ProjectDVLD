using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsApplicationType
    {

        //int ID { set; get; }

        //string Title { set; get; }

        //decimal Fees { set; get; }

        //public clsApplicationType()
        //{
        //    this.ID = -1;
        //    this.Title = "";
        //    this.Fees = -1;
        //}

        //private clsApplicationType(int ID , string Title , decimal Fees)
        //{
        //    this.ID = ID;
        //    this.Title = Title;
        //    this.Fees = Fees; ;
        //}

        public static DataTable GetAllApplicationsType()
        {
            return clsApplicationsTypeData.GetAllApllicationType();
        }

        public static bool UpdateFees(int ID, string Title , decimal Fees)
        {
            return clsApplicationsTypeData.UpdateFees(ID, Title, Fees);
        }

    }
}
