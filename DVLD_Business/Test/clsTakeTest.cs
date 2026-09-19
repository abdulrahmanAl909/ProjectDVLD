using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsTakeTest
    {

        public clsTestAppointment TestAppointmentInfo;

        public int TestID { set; get; }

        public int TestAppointmentID { set; get; }

        public bool TestResult { set; get; }

        public string Notes { set; get; }

        public int CreateByUserID { set; get; }

        public bool CheckAddNewTest()
        {
            this.TestID = clsTakeTestData.AddNewTest(this.TestAppointmentID, this.TestResult, this.Notes, this.CreateByUserID);

            return (this.TestID != -1);
        }

        public clsTakeTest(int TestAppoimentID)
        {
            this.TestID = -1;
            this.TestResult = false;
            this.Notes = "";
            this.CreateByUserID = -1;

            this.TestAppointmentID = TestAppoimentID;
            TestAppointmentInfo = clsTestAppointment.GetTestAppointmentByID(TestAppointmentID);
        }

        public static bool? CheckTestResult(int AppointmentID)
        {
            return clsTakeTestData.CheckTestResult(AppointmentID);
        }

    }
}
