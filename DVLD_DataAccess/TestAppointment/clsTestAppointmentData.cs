using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_DataAccess
{
    public class clsTestAppointmentData
    {

        public static DataTable GetAllTestAppointment(int LocalID, int TestType)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"select TestAppointmentID,AppointmentDate,PaidFees , IsLocked 
                             From TestAppointments where LocalDrivingLicenseApplicationID=@LocalID and
                             TestTypeID=@TestType";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@LocalID", LocalID);
            command.Parameters.AddWithValue("@TestType", TestType);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    dataTable.Load(reader);
                }
                reader.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Errpr " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

        public static bool GetTestAppointmentByID(int TestAppointmentID, ref int TestTypeID, ref int LocalLicenseApplicationID
          , ref DateTime AppointmentDate, ref decimal PaidFees, ref int CreateByUserID, ref bool IsLocked, ref int RetakeTestApplicationID)
        {
            bool IsFount = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"select * From TestAppointments
                            where TestAppointmentID=@TestAppointmentID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFount = true;

                    TestTypeID = (int)reader["TestTypeID"];
                    LocalLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreateByUserID = (int)reader["CreateByUserID"];
                    IsLocked = (bool)reader["IsLocked"];

                    if (reader["RetakeTestApplicationID"] != DBNull.Value)
                    {
                        RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];
                    }
                    else
                    {
                        RetakeTestApplicationID = -1;
                    }

                }
                else
                {
                    IsFount = false;
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            finally
            {
                connection.Close();
            }

            return IsFount;
        }

        public static int AddNewAppointment(int TestTypeID, int LocalLicenseApplicationID,DateTime AppointmentDate,
            decimal PaidFees, int CreateByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            int TestAppointmentID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"INSERT INTO [dbo].[TestAppointments]
                            ([TestTypeID],[LocalDrivingLicenseApplicationID],[AppointmentDate],[PaidFees],
                            [CreatedByUserID],[IsLocked],[RetakeTestApplicationID])
                            VALUES (@TestTypeID , @LocalLicenseApplicationID , @AppointmentDate,
                            @PaidFees , @CreateByUserID , @IsLocked , @RetakeTestApplicationID);
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

        public static bool IsAppointmentExist(int LocalID , int TestType , bool IsLocked)
        {
            int Count = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"select Count(TestAppointmentID) From TestAppointments
                            where LocalDrivingLicenseApplicationID=@LocalID and TestTypeID=@TestType and IsLocked=@IsLocked";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@LocalID", LocalID);
            command.Parameters.AddWithValue("@TestType", TestType);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertvalue))
                {
                    Count = insertvalue;
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
            return (Count != 0);
        }

        public static bool ChangeIsLockedToTure(int TestAppointmentID, bool IsLocked)
        {
            int RowAffectid = 0;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"UPDATE [dbo].[TestAppointments]
                            SET [IsLocked] = @IsLocked
                            WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);


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
