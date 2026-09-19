using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsTakeTestData
    {

        public static int AddNewTest(int TestAppointmentID,bool TestResult,string Notes,int CreateByUserID)
        {
            int TestID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"INSERT INTO [dbo].[Tests]
                           ([TestAppointmentID],[TestResult],[Notes],[CreatedByUserID])
                           VALUES(@TestAppointmentID,@TestResult,@Notes,@CreateByUserID);
                           Select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@CreateByUserID", CreateByUserID);


            if (Notes != "")
            {
                command.Parameters.AddWithValue("@Notes", Notes);
            }
            else
            {
                command.Parameters.AddWithValue("@Notes", System.DBNull.Value);
            }

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertvalue))
                {
                    TestID = insertvalue;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e.Message);
            }
            finally
            {
                connection.Close();
            }

            return TestID;
        }

        public static bool? CheckTestResult(int AppointmentID)
        {
            bool? TestResult = null;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"select TestResult From Tests
                             where TestAppointmentID = @AppointmentID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

            try
            {
                connection.Open();


                object result = command.ExecuteScalar();

                if (result != null && bool.TryParse(result.ToString(), out bool insertvalue))
                {
                    TestResult = insertvalue;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            finally
            {
                connection.Close();
            }

            return TestResult; 
        }


    }
}
