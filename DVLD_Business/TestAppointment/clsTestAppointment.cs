using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsTestAppointment
    {
        enum enMode { Add , Update}
        enMode Mode = enMode.Add;

        clsLoaclApplication LocalInfo;

        public int TestAppointmentID { set; get; }

        public int TestTypeID { set; get; }

        public int LocalLicenseApplicationID { set; get; }

        public DateTime AppointmentDate { set; get; }

        public decimal PaidFees { set; get; }

        public int CreateByUserID { set; get; }

        public bool IsLocked { set; get; }

        public int RetakeTestApplicationID { set; get; }


    }
}
