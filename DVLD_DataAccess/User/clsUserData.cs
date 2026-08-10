using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsUserData
    {
        public static DataTable GetAllUsers()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"SELECT Users.UserID, Users.PersonID,FullName= People.FirstName + ' ' + People.SecondName+ ' ' +isnull(People.ThirdName,'')+ ' ' + People.LastName, Users.UserName,Users.IsActive
                           FROM  Users INNER JOIN
                           People ON Users.PersonID = People.PersonID";

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

        public static DataTable GetAllColumnName()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"Select Top(1) UserID , PersonID , UserName , IsActive From Users";

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

        public static bool GetUserInfoByID(int UserID,ref int PersonID,ref string UserName,ref string UserPassword,ref bool IsActive)
        {
            bool IsFount = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"Select * From Users
                           Where UserID=@UserID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    IsFount = true;

                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    UserPassword = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
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

        public static int AddNewUser(int PersonID,string UserName , string UserPassword , bool IsActive)
        {
            int NewUserID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"INSERT INTO [dbo].[Users]
           ([PersonID],[UserName],[Password],[IsActive])
            VALUES (@PersonID,@UserName,@UserPassword,@IsActive);
            Select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@UserPassword", UserPassword);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if(result!=null && int.TryParse(result.ToString(),out int insertvalue))
                {
                    NewUserID = insertvalue;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error" + e.Message);
            }
            finally
            {
                connection.Close();
            }

            return NewUserID;
        }

        public static bool UpdateUser(int UserID, int PersonID, string UserName, string UserPassword, bool IsActive)
        {
            int RowAffectid = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"UPDATE [dbo].[Users]
                           SET [PersonID] = @PersonID
                              ,[UserName] = @UserName
                              ,[Password] = @UserPassword
                              ,[IsActive] = @IsActive
                             WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@UserPassword", UserPassword);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();

                RowAffectid = command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error" + e.Message);
            }
            finally
            {
                connection.Close();
            }

            return (RowAffectid>0);
        }
       
        public static bool DeleteUser(int UserID)
        {
            int RowAffectid = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"DELETE FROM [dbo].[Users]
                             WHERE UserID=@UserID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                RowAffectid = command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error" + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return (RowAffectid > 0);
        }

        public static bool IsUserExist(int UserID)
        {
            bool IsFount = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"Select Fount=1 From Users 
                             Where UserID=@UserID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                IsFount = reader.HasRows;
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


    }
}
