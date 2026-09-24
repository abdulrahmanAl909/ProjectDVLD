using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsDriverData
    {
        public static DataTable GetAllDriver()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"SELECT  Drivers.DriverID, Drivers.PersonID,People.NationalNo,FullName = People.FirstName + ' ' + People.SecondName + ' ' + ISNULL(People.ThirdName,'') + ' ' + People.LastName, 
                                Drivers.CreatedDate, ActiveLicense = CAST(L.IsActive AS VARCHAR(5))
                            FROM Drivers INNER JOIN People ON Drivers.PersonID = People.PersonID
                            CROSS APPLY (
                            SELECT TOP 1 IsActive 
                            FROM Licenses 
                            WHERE Licenses.DriverID = Drivers.DriverID 
                            ORDER BY IsActive DESC
                            ) L;";

            SqlCommand command = new SqlCommand(quary, connection);

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
                Console.WriteLine("Error " + e.Message);
            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }

        public static DataTable GetAllDriverByFilter(string ColumnName, int FilterBy)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = $@"SELECT * FROM (
                             SELECT Drivers.DriverID, Drivers.PersonID, People.NationalNo,FullName = People.FirstName + ' ' + People.SecondName + ' ' + ISNULL(People.ThirdName,'') + ' ' + People.LastName, 
                                 Drivers.CreatedDate, ActiveLicense = CAST(L.IsActive AS VARCHAR(5))
                             FROM Drivers 
                             INNER JOIN People ON Drivers.PersonID = People.PersonID
                             CROSS APPLY (
                                 SELECT TOP 1 IsActive 
                                 FROM Licenses 
                                 WHERE Licenses.DriverID = Drivers.DriverID 
                                 ORDER BY IsActive DESC
                             ) L
                         ) AS MainTable
                         WHERE {ColumnName} = @FilterBy;";

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

        public static DataTable GetAllDriverByFilter(string ColumnName, string FilterBy)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = $@"SELECT * FROM (
                            SELECT Drivers.DriverID, Drivers.PersonID, People.NationalNo,FullName = People.FirstName + ' ' + People.SecondName + ' ' + ISNULL(People.ThirdName,'') + ' ' + People.LastName, Drivers.CreatedDate,ActiveLicense = CAST(L.IsActive AS VARCHAR(5))                           FROM Drivers 
                            INNER JOIN People ON Drivers.PersonID = People.PersonID
                            CROSS APPLY (
                                SELECT TOP 1 IsActive 
                                FROM Licenses 
                                WHERE Licenses.DriverID = Drivers.DriverID 
                                ORDER BY IsActive DESC
                            ) L
                        ) AS MainTable
                        WHERE {ColumnName} LIKE '' + @FilterBy + '%';";

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

        public static int AddNewDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            int NewDriver = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"INSERT INTO [dbo].[Drivers]
                            ([PersonID],[CreatedByUserID],[CreatedDate])
                            VALUES(@PersonID,@CreatedByUserID,@CreatedDate);
                            Select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertvalue))
                {
                    NewDriver = insertvalue;
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

            return NewDriver;
        }

        public static int IsDriverExist(int PersonID)
        {
            int DriverID =-1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"select DriverID From Drivers
                             where PersonID =@PersonID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertvalue))
                {
                    DriverID = insertvalue;
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
            return DriverID;
        }
    }
}
