using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsTestAppointmentData
    {



        public static int AddNewAppointment(int TestTypeID, int LocalLicenseApplicationID,DateTime AppointmentDate,
            decimal PaidFees, int CreateByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            int TestAppointmentID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"INSERT INTO [dbo].[TestAppointments]
                            ([TestTypeID],[LocalDrivingLicenseApplicationID],[AppointmentDate],[PaidFees],
                            [CreatedByUserID],[IsLocked],[RetakeTestApplicationID])
                            VALUES (@TestTypeID , @LocalLicenseApplicationID , @AppointmentDate,
                            @PaidFees , @CreateByUserID , @IsLocked , @RetakeTestApplicationID;
                            Select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalLicenseApplicationID", LocalLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreateByUserID", CreateByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);

            if (RetakeTestApplicationID != -1)
            {
                command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            }
            else
            {
                command.Parameters.AddWithValue("@RetakeTestApplicationID", System.DBNull.Value);
            }

            try
            {
                connection.Open();
                
                object result = command.ExecuteScalar();
                
                if (result != null && int.TryParse(result.ToString(), out int insertvalue))
                {
                    TestAppointmentID = insertvalue;
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

            return TestAppointmentID;
        }

        public static bool UpdateAppointment(int TestAppointmentID ,DateTime AppointmentDate)
        {
            int RowAffectid = 0;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"UPDATE [dbo].[TestAppointments]
                            SET [AppointmentDate] = @AppointmentDate
                            WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);

            try
            {
                connection.Open();

                RowAffectid = command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return (RowAffectid > 0);
        }

    }
}
