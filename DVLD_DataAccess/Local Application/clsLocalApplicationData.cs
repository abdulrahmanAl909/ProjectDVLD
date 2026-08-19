using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsLocalApplicationData
    {

        public static DataTable GetAllLocalApplication()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"SELECT LDLAppID= LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID, DrivingClass= LicenseClasses.ClassName, People.NationalNo,FullName= People.FirstName + ' ' + People.SecondName+ ' ' +isnull(People.ThirdName,'')+ ' ' + People.LastName, Applications.ApplicationDate,PassedTest=0 ,Status= Applications.ApplicationStatus
                           FROM LocalDrivingLicenseApplications INNER JOIN
                           Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID INNER JOIN
                           People ON Applications.ApplicantPersonID = People.PersonID INNER JOIN
                           LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID";

            SqlCommand command = new SqlCommand(quary, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    dataTable.Load(reader);
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

            return dataTable;
        }

        public static DataTable GetAllApplicationByFilter(string ColumnName, int FilterBy)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = $@"select * From
                           (SELECT LDLAppID= LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID, DrivingClass= LicenseClasses.ClassName, People.NationalNo,FullName= People.FirstName + ' ' + People.SecondName+ ' ' +isnull(People.ThirdName,'')+ ' ' + People.LastName, Applications.ApplicationDate,PassedTest=0 ,Status= Applications.ApplicationStatus
                           FROM LocalDrivingLicenseApplications INNER JOIN
                           Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID INNER JOIN
                           People ON Applications.ApplicantPersonID = People.PersonID INNER JOIN
                           LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID) A1
                           Where {ColumnName} =@FilterBy";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@FilterBy", FilterBy);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dataTable.Load(reader);
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
            return dataTable;
        }

        public static DataTable GetAllApplicationByFilter(string ColumnName, string FilterBy)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = $@"select * From
                           (SELECT LDLAppID= LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID, DrivingClass= LicenseClasses.ClassName, People.NationalNo,FullName= People.FirstName + ' ' + People.SecondName+ ' ' +isnull(People.ThirdName,'')+ ' ' + People.LastName, Applications.ApplicationDate,PassedTest=0 ,Status= Applications.ApplicationStatus
                           FROM LocalDrivingLicenseApplications INNER JOIN
                           Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID INNER JOIN
                           People ON Applications.ApplicantPersonID = People.PersonID INNER JOIN
                           LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID) A1
                           Where {ColumnName} LIKE '' +  @FilterBy + '%'";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@FilterBy", FilterBy);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dataTable.Load(reader);
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
            return dataTable;
        }

        public static DataTable GetAllApplicationByFilter(string ColumnName, byte FilterBy)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = $@"select * From
                           (SELECT LDLAppID= LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID, DrivingClass= LicenseClasses.ClassName, People.NationalNo,FullName= People.FirstName + ' ' + People.SecondName+ ' ' +isnull(People.ThirdName,'')+ ' ' + People.LastName, Applications.ApplicationDate,PassedTest=0 ,Status= Applications.ApplicationStatus
                           FROM LocalDrivingLicenseApplications INNER JOIN
                           Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID INNER JOIN
                           People ON Applications.ApplicantPersonID = People.PersonID INNER JOIN
                           LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID) A1
                           Where {ColumnName} =@FilterBy";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@FilterBy", FilterBy);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dataTable.Load(reader);
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
            return dataTable;
        }

        public static bool GetApplicationInfoByID(int AppID,ref int AppPersonID,ref DateTime AppDate,ref int AppType,ref byte AppStatus,
            ref DateTime LastStatusDate,ref decimal PaidFees,ref int CreatedByUserID)
        {
            bool IsFount = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"SELECT LDLAppID= LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID, DrivingClass= LicenseClasses.ClassName, People.NationalNo,FullName= People.FirstName + ' ' + People.SecondName+ ' ' +isnull(People.ThirdName,'')+ ' ' + People.LastName, Applications.ApplicationDate,PassedTest=0 ,Status= Applications.ApplicationStatus
                           FROM LocalDrivingLicenseApplications INNER JOIN
                           Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID INNER JOIN
                           People ON Applications.ApplicantPersonID = People.PersonID INNER JOIN
                           LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID
                           Where LocalDrivingLicenseApplicationID = @AppID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@AppID", AppID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    IsFount = true;

                    AppPersonID = (int)reader["ApplicantPersonID"];
                    AppDate = (DateTime)reader["ApplicationDate"];
                    AppType = (int)reader["ApplicationTypeID"];
                    AppStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                }
                else
                {
                    IsFount = false;
                }
                reader.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsFount;
        }

        public static int AddNewLocalApplication(int AppPersonID , DateTime AppDate , int AppType , byte AppStatus,
            DateTime LastStatusDate , decimal PaidFees , int CreatedByUserID)
        {
            int ApplicatonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"
            INSERT INTO [dbo].[Applications]
           ([ApplicantPersonID],[ApplicationDate],[ApplicationTypeID],[ApplicationStatus],[LastStatusDate],[PaidFees],[CreatedByUserID])
            VALUES (@AppPersonID,@AppDate,@AppType,@AppStatus,@LastStatusDate,@PaidFees,@CreatedByUserID);
            Select SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@AppPersonID", AppPersonID);
            command.Parameters.AddWithValue("@AppDate", AppDate);
            command.Parameters.AddWithValue("@AppType", AppType);
            command.Parameters.AddWithValue("@AppStatus", AppStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertID))
                {
                    ApplicatonID = insertID;
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

            return ApplicatonID;
        }

        public static bool UpdateLocalApplication(int AppID,int AppPersonID, DateTime AppDate, int AppType, byte AppStatus,
            DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            int RowAffectid = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"UPDATE [dbo].[Applications]
                           SET [ApplicantPersonID] =@AppPersonID
                           ,[ApplicationDate] =@AppDate
                           ,[ApplicationTypeID] =@AppType
                           ,[ApplicationStatus] = @AppStatus
                           ,[LastStatusDate] =@LastStatusDate
                           ,[PaidFees] =@PaidFees
                           ,[CreatedByUserID] = @CreatedByUserID
                           WHERE ApplicationID = @AppID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@AppID", AppID);
            command.Parameters.AddWithValue("@AppPersonID", AppPersonID);
            command.Parameters.AddWithValue("@AppDate", AppDate);
            command.Parameters.AddWithValue("@AppType", AppType);
            command.Parameters.AddWithValue("@AppStatus", AppStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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
            return (RowAffectid>0);
        }




    }
}
