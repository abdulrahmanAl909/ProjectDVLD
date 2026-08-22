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

            string quary = @"SELECT LDLAppID= LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID, DrivingClass= LicenseClasses.ClassName, People.NationalNo,FullName= People.FirstName + ' ' + People.SecondName+ ' ' +isnull(People.ThirdName,'')+ ' ' + People.LastName, Applications.ApplicationDate,PassedTest=0 ,Status=
                             case 
                             When ApplicationStatus=1 then 'New'
                             When ApplicationStatus=2 then 'Cancelled'
                             else 'Completed'
                             End
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

        public static bool GetLocalApplicationByID(int LocalApplicationID,ref int ApplicationID,ref int LicenseClassID)
        {
            bool IsFount = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"Select * From LocalDrivingLicenseApplications
                             Where LocalDrivingLicenseApplicationID=@LocalApplicationID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@LocalApplicationID", LocalApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    IsFount = true;

                    ApplicationID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
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

        public static int AddNewLocalApplication(int ApplicationID , int LicenseClassID)
        {
            int AddNewLocalApplication = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"INSERT INTO [dbo].[LocalDrivingLicenseApplications]
                            ([ApplicationID],[LicenseClassID])
                             VALUES(@ApplicationID,@LicenseClassID);
                             Select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertvalue))
                {
                    AddNewLocalApplication = insertvalue;
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
            return AddNewLocalApplication;
        }

        public static bool UpdateLocalApplication(int LocalApplicationID, int LicenseClassID)
        {
            int RowAffectid = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"UPDATE [dbo].[LocalDrivingLicenseApplications]
                            SET [LicenseClassID] =@LicenseClassID
                            WHERE LocalDrivingLicenseApplicationID=@LocalApplicationID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@LocalApplicationID", LocalApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();

                RowAffectid = command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return (RowAffectid > 0);
        }

        public static bool CheckHasOrder(int AppPersonID,int AppType, byte AppStatus)
        {
            bool IsHasRow = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"select Fount=1 From Applications
                           where ApplicantPersonID=@AppPersonID and ApplicationTypeID=@AppType
                           and ApplicationStatus=@AppStatus";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@AppPersonID", AppPersonID);
            command.Parameters.AddWithValue("@AppType", AppType);
            command.Parameters.AddWithValue("@AppStatus", AppStatus);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                IsHasRow = reader.HasRows;
            }
            catch(Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return (!IsHasRow);
        }


    }
}
