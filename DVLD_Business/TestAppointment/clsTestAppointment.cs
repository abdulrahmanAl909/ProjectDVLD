using DVLD_DataAccess;
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

        public clsTestAppointment()
        {
            this.TestAppointmentID = -1;
            this.TestTypeID = -1;
            this.LocalLicenseApplicationID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = -1;
            this.CreateByUserID = -1;
            this.IsLocked = false;
            this.RetakeTestApplicationID = -1;
        }

        private clsTestAppointment(int TestAppointmentID, int TestTypeID,int LocalLicenseApplicationID
            ,DateTime AppointmentDate,decimal PaidFees,int CreateByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalLicenseApplicationID = LocalLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreateByUserID = CreateByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
        }

        private bool _AddTestAppointment()
        {
            this.TestTypeID = clsTestAppointmentData.AddNewAppointment(TestTypeID, LocalLicenseApplicationID
                , AppointmentDate, PaidFees, CreateByUserID, IsLocked, RetakeTestApplicationID);

            return (this.TestAppointmentID != -1);
        }

        private bool _UpdateTestAppointment()
        {
            return clsTestAppointmentData.UpdateAppointment(this.TestAppointmentID, this.AppointmentDate);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if(_AddTestAppointment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateTestAppointment();
  
            }
            return false;
        }

    }
}
