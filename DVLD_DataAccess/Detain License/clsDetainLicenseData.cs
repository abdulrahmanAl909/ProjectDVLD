using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsDetainLicenseData
    {

        public static DataTable GetAllDetains()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"SELECT DetainedLicenses.DetainID, DetainedLicenses.LicenseID, DetainedLicenses.DetainDate, DetainedLicenses.IsReleased,
                             DetainedLicenses.FineFees, DetainedLicenses.ReleaseDate, People.NationalNo,
                              FullName= People.FirstName + ' ' + People.SecondName+ ' ' +isnull(People.ThirdName,'')+ ' ' + People.LastName, 
                              DetainedLicenses.ReleaseApplicationID
                              FROM   DetainedLicenses INNER JOIN
                              Applications ON DetainedLicenses.ReleaseApplicationID = Applications.ApplicationID INNER JOIN
                              People ON Applications.ApplicantPersonID = People.PersonID";

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

        public static bool GetDetainByID(int DetainID,ref int LicenseID,ref DateTime DetainDate,ref decimal FineFees,
            ref int CreatedByUserID,ref bool IsReleased,ref DateTime ReleaseDate,ref int ReleasedByUserID,ref int ReleaseApplicationID)
        {
            bool IsFount = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"select * From DetainedLicenses
                             where DetainID =@DetainID ";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFount = true;

                    LicenseID = (int)reader["LicenseID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = (decimal)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];

                    if (reader["DetainDate"] != DBNull.Value)
                    {
                        DetainDate = (DateTime)reader["DetainDate"];
                    }
                    else
                    {
                        DetainDate = DateTime.Now;
                    }


                    if (reader["ReleasedByUserID"] != DBNull.Value)
                    {
                        ReleasedByUserID = (int)reader["ReleasedByUserID"];
                    }
                    else
                    {
                        ReleasedByUserID =-1;
                    }


                    if (reader["ReleaseApplicationID"] != DBNull.Value)
                    {
                        ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                    }
                    else
                    {
                        ReleaseApplicationID = -1;
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

        public static DataTable GetAllDetainsByFilter(string ColumnName, int FilterBy)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = $@"SELECT DetainedLicenses.DetainID, DetainedLicenses.LicenseID, DetainedLicenses.DetainDate, DetainedLicenses.IsReleased,
                             DetainedLicenses.FineFees, DetainedLicenses.ReleaseDate, People.NationalNo,
                              FullName= People.FirstName + ' ' + People.SecondName+ ' ' +isnull(People.ThirdName,'')+ ' ' + People.LastName, 
                              DetainedLicenses.ReleaseApplicationID
                              FROM   DetainedLicenses INNER JOIN
                              Applications ON DetainedLicenses.ReleaseApplicationID = Applications.ApplicationID INNER JOIN
                              People ON Applications.ApplicantPersonID = People.PersonID
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

        public static DataTable GetAllDetainsByFilter(string ColumnName, string FilterBy)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = $@"Select * From(
                             SELECT DetainedLicenses.DetainID, DetainedLicenses.LicenseID, DetainedLicenses.DetainDate, DetainedLicenses.IsReleased,
                             DetainedLicenses.FineFees, DetainedLicenses.ReleaseDate, People.NationalNo,
                              FullName= People.FirstName + ' ' + People.SecondName+ ' ' +isnull(People.ThirdName,'')+ ' ' + People.LastName, 
                              DetainedLicenses.ReleaseApplicationID
                              FROM   DetainedLicenses INNER JOIN
                              Applications ON DetainedLicenses.ReleaseApplicationID = Applications.ApplicationID INNER JOIN
                              People ON Applications.ApplicantPersonID = People.PersonID)A
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

        public static DataTable GetAllDetainsByFilter(string ColumnName, bool FilterBy)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = $@"SELECT DetainedLicenses.DetainID, DetainedLicenses.LicenseID, DetainedLicenses.DetainDate, DetainedLicenses.IsReleased,
                             DetainedLicenses.FineFees, DetainedLicenses.ReleaseDate, People.NationalNo,
                              FullName= People.FirstName + ' ' + People.SecondName+ ' ' +isnull(People.ThirdName,'')+ ' ' + People.LastName, 
                              DetainedLicenses.ReleaseApplicationID
                              FROM   DetainedLicenses INNER JOIN
                              Applications ON DetainedLicenses.ReleaseApplicationID = Applications.ApplicationID INNER JOIN
                              People ON Applications.ApplicantPersonID = People.PersonID
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

        public static int AddDetain(int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID
            , bool IsReleased)
        {
            int NewDetainID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"INSERT INTO [dbo].[DetainedLicenses]
           ([LicenseID],[DetainDate],[FineFees],[CreatedByUserID],[IsReleased],[ReleaseDate],[ReleasedByUserID],[ReleaseApplicationID])
            VALUES
           (@LicenseID,@DetainDate,@FineFees,@CreatedByUserID,@IsReleased,@ReleaseDate,@ReleasedByUserID,@ReleaseApplicationID);
            Select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);
            command.Parameters.AddWithValue("@ReleaseDate", System.DBNull.Value);
            command.Parameters.AddWithValue("@ReleasedByUserID", System.DBNull.Value);
            command.Parameters.AddWithValue("@ReleaseApplicationID", System.DBNull.Value);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertvalue))
                {
                    NewDetainID = insertvalue;
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

            return NewDetainID;
        }

        public static bool UpdateDetain(int DetainID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int RowAffectid = 0;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"UPDATE [dbo].[DetainedLicenses]
                             SET [IsReleased] =@IsReleased
                              ,[ReleaseDate] = @ReleaseDate
                              ,[ReleasedByUserID] =@ReleasedByUserID
                              ,[ReleaseApplicationID] =@ReleaseApplicationID
                         WHERE @DetainID = DetainID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);
            command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

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

        public static bool GetIsRelease(int DetainID)
        {
            bool IsRelease = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"select IsReleased From DetainedLicenses
                             where DetainID = @DetainID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && bool.TryParse(result.ToString(), out bool insertvalue))
                {
                    IsRelease = insertvalue;
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
            return IsRelease;

        }

        public static bool IsLicenseDetain(int LicenseID)
        {
            bool IsFount = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"select Fount = 1 From DetainedLicenses
                             where LicenseID =@LicenseID and IsReleased=0";

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
