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

    }
}
