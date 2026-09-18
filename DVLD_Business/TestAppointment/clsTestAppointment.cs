using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsTestAppointment
    {
        enum enMode { Add , Update}
        enMode Mode = enMode.Add;

        public clsLoaclApplication LocalInfo;

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

            //LocalInfo = clsLoaclApplication.GetLocalApplicationByID(this.LocalLicenseApplicationID);

            Mode = enMode.Add;
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

            LocalInfo = clsLoaclApplication.GetLocalApplicationByID(LocalLicenseApplicationID);

            Mode = enMode.Update;
        }

        public clsTestAppointment(int LocalID)
        {
            LocalInfo = clsLoaclApplication.GetLocalApplicationByID(LocalID);
        }
        private bool _AddTestAppointment()
        {
            this.TestAppointmentID = clsTestAppointmentData.AddNewAppointment(TestTypeID, LocalLicenseApplicationID
                , AppointmentDate, PaidFees, CreateByUserID, IsLocked, RetakeTestApplicationID);

            return (this.TestAppointmentID != -1);
        }

        private bool _UpdateTestAppointment()
        {
            return clsTestAppointmentData.UpdateAppointment(this.TestAppointmentID, this.AppointmentDate);
        }

        public static clsTestAppointment GetTestAppointmentByID(int TestAppointmentID)
        {
           int TestTypeID = -1, LocalLicenseApplicationID = -1, CreateByUserID = -1, RetakeTestApplicationID = -1;
           DateTime AppointmentDate = DateTime.Now;
           decimal PaidFees = -1;
           bool IsLocked = false;

            if(clsTestAppointmentData.GetTestAppointmentByID(TestAppointmentID ,ref TestTypeID
                ,ref LocalLicenseApplicationID, ref AppointmentDate,ref PaidFees,ref CreateByUserID
                ,ref IsLocked , ref RetakeTestApplicationID))
            {
                return new clsTestAppointment(TestAppointmentID, TestTypeID,LocalLicenseApplicationID,
                    AppointmentDate, PaidFees, CreateByUserID, IsLocked, RetakeTestApplicationID);
            }
            else
            {
                return null;
            }

        }

        public static DataTable GetAllTestAppointment(int LocalID, int TestType)
        {
            return clsTestAppointmentData.GetAllTestAppointment(LocalID, TestType);
        }

        //public void FillInfoForLocalApplication(int LocalApplication)
        //{
        //    LocalInfo = clsLoaclApplication.GetLocalApplicationByID(LocalApplication);
        //}

        public static bool IsAppointmentExsit(int LocalID,int TestType , bool Islocked)
        {
            return clsTestAppointmentData.IsAppointmentExist(LocalID,TestType ,Islocked);
        }

        public static bool ChangeIsLockedToTrue(int TestAppointmentID)
        {
            return clsTestAppointmentData.ChangeIsLockedToTure(TestAppointmentID, true);
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
