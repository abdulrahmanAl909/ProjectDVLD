using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{ 
    public class clsInternationalLicenseData
    {
        public static DataTable GetAllInternationalLicense()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"SELECT InterLicenseID = InternationalLicenseID, ApplicationID, DriverID,LocalLicenseID = IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive
                             FROM InternationalLicenses";

            SqlCommand command = new SqlCommand(quary, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
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

        public static bool GetInternaionalByID(int InternationalID,ref int ApplicationID,
            ref int DriverID,ref int IssuedUsingLocalLicenseID
            ,ref DateTime IssueDate,ref DateTime ExpirationDate,ref bool IsActive,ref int CreateByUserID)
        {
            bool IsFount = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"select * From InternationalLicenses
                             where InternationalLicenseID=@InternationalID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@InternationalID", InternationalID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFount = true;

                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IsActive = (bool)reader["IsActive"];
                    CreateByUserID = (int)reader["CreateByUserID"];
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

        public static DataTable GetAllLicenseByFilter(string ColumnName, int FilterBy)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = $@"SELECT InterLicenseID = InternationalLicenseID, ApplicationID, DriverID,LocalLicenseID = IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive
                              FROM InternationalLicenses
                              Where {ColumnName} = @FilterBy";

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

        public static DataTable GetAllLicenseByFilter(string ColumnName, bool FilterBy)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = $@"SELECT InterLicenseID = InternationalLicenseID, ApplicationID, DriverID,LocalLicenseID = IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive
                              FROM InternationalLicenses
                              Where {ColumnName} = @FilterBy";

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

        public static DataTable GetInternationalLicense(int DriverID)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"SELECT InterLicenseID = InternationalLicenseID, ApplicationID,
                             LocalLicenseID= IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive
                             FROM   InternationalLicenses
                             where DriverID =@DriverID";
                             
            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
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

        public static int AddNewInternational(int ApplicationID , int DriverID , int IssuedUsingLocalLicenseID,
            DateTime IssueDate , DateTime ExpirationDate , bool IsActive , int CreateByUserID)
        {
            int NewInternational = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"INSERT INTO [dbo].[InternationalLicenses]
           ([ApplicationID],[DriverID],[IssuedUsingLocalLicenseID],[IssueDate],[ExpirationDate],[IsActive],[CreatedByUserID])
           VALUES(@ApplicationID ,@DriverID ,@IssuedUsingLocalLicenseID,@IssueDate
           ,@ExpirationDate,@IsActive,@CreateByUserID);
            Select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreateByUserID", CreateByUserID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertvalue))
                {
                    NewInternational = insertvalue;
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

            return NewInternational;
        }

        public static bool IsInternationalExsit(int LicenseID)
        {
            bool IsFount = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"select Fount=1 From InternationalLicenses
                            where IssuedUsingLocalLicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                IsFount = reader.HasRows;
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

    }
}
