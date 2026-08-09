using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Reflection;


namespace DVLD_DataAccess
{
    public class clsPersonData
    {


       public static DataTable GetAllPeople()
       {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"SELECT People.PersonID, People.NationalNo,FirstName,SecondName,ThirdName, LastName ,People.DateOfBirth,
                 Gendor = case when Gendor = 0 then 'Male' when Gendor = 1 then 'Femail' else'UnKnows' End,
                 People.Phone, People.Email, Countries.CountryName FROM People
                 INNER JOIN Countries ON People.NationalityCountryID = Countries.CountryID";

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
            catch(Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
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

            string quary = @"SELECT top(1) People.PersonID, People.NationalNo, People.FirstName,
                            People.SecondName, People.ThirdName, People.LastName, 
                            People.Gendor,People.Phone, People.Email, Countries.CountryName
                            FROM   People INNER JOIN
                            Countries ON People.NationalityCountryID = Countries.CountryID";

            SqlCommand command = new SqlCommand(quary, connection);

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
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);

            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

        public static DataTable GetAllPeopleByFilter(string ColumnName , string FilterBy)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

          
            string quary = $@"SELECT People.PersonID, People.NationalNo,FirstName,SecondName,ThirdName, LastName ,People.DateOfBirth,
                 Gendor = case when Gendor = 0 then 'Male' when Gendor = 1 then 'Femail' else'UnKnows' End,
                 People.Phone, People.Email, Countries.CountryName FROM People
                 INNER JOIN Countries ON People.NationalityCountryID = Countries.CountryID
                 where {ColumnName} LIKE  '' + @FilterBy + '%'";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@FilterBy", FilterBy);

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
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);

            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

        public static DataTable GetAllPeopleByFilter(string ColumnName, int FilterBy)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = $@"SELECT People.PersonID, People.NationalNo,FirstName,SecondName,ThirdName, LastName ,People.DateOfBirth,
                 Gendor = case when Gendor = 0 then 'Male' when Gendor = 1 then 'Femail' else'UnKnows' End,
                 People.Phone, People.Email, Countries.CountryName FROM People
                 INNER JOIN Countries ON People.NationalityCountryID = Countries.CountryID
                 where {ColumnName} = @FilterBy";

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
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);

            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

        public static bool GetPersonInfoByID(int PersonID,ref string NationalNo,ref string FirstName, ref string SecondName,ref string ThirdName,
            ref string LastName,ref DateTime DateOfBirth,ref byte Gendor,ref string Address,ref string Phone
            , ref string Email,ref int CountryID,ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = "select * From People where PersonID=@PersonID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;

                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (byte)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    CountryID = (int)reader["NationalityCountryID"];

                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)reader["ThirdName"];
                    }
                    else
                    {
                        ThirdName = "";
                    }

                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }

                    if (reader["ImagePath"]!=DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }
                }
                else
                {
                    isFound = false;
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
            return isFound;
        }

        public static bool GetPersonInfoByNationalNo(ref int PersonID,string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName,
                    ref string LastName, ref DateTime DateOfBirth, ref byte Gendor, ref string Address, ref string Phone
                    , ref string Email, ref int CountryID, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = "select * From People where NationalNo=@NationalNo";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (byte)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    CountryID = (int)reader["NationalityCountryID"];

                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)reader["ThirdName"];
                    }
                    else
                    {
                        ThirdName = "";
                    }

                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }

                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }
                }
                else
                {
                    isFound = false;
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
            return isFound;
        }
        public static int AddNewPerson(string NationalNo ,string FirstName
            , string SecondName, string ThirdName,string LastName,
             DateTime DateOfBirth,byte Gendor, string Address, string Phone,
             string Email, int CountryID, string ImagePath)
        {
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"INSERT INTO [dbo].[People]
           ([NationalNo],[FirstName],[SecondName],[ThirdName],[LastName],[DateOfBirth],[Gendor],[Address]
            ,[Phone],[Email],[NationalityCountryID],[ImagePath])
            VALUES (@NationalNo,@FirstName,@SecondName,@ThirdName,@LastName,@DateOfBirth,
                    @Gendor,@Address,@Phone,@Email,@CountryID,@ImagePath);
                     Select SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@LastName",LastName);
            command.Parameters.AddWithValue("@DateOfBirth",DateOfBirth);
            command.Parameters.AddWithValue("@Gendor",(byte)Gendor);
            command.Parameters.AddWithValue("@Address",Address);
            command.Parameters.AddWithValue("@Phone",Phone);
            command.Parameters.AddWithValue("@CountryID",CountryID);

            if (ThirdName != "")
            {
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            }
            else
            {
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            }

            if (Email != "")
            {
                command.Parameters.AddWithValue("@Email", Email);
            }
            else
            {
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            }


            if (ImagePath!="")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if(result!=null && int.TryParse(result.ToString(),out int insertID))
                {
                    PersonID = insertID;
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
            return (PersonID);
        }

        public static bool UpdatePerson(int PersonID,string NationalNo, string FirstName
            , string SecondName, string ThirdName, string LastName,
             DateTime DateOfBirth, byte Gendor, string Address, string Phone,
             string Email, int CountryID, string ImagePath)
        {
            int RowAffectid = 0;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"UPDATE [dbo].[People]
                          SET [NationalNo] =@NationalNo
                             ,[FirstName] = @FirstName
                             ,[SecondName] =@SecondName
                             ,[ThirdName] =@ThirdName
                             ,[LastName] = @LastName
                             ,[DateOfBirth] = @DateOfBirth
                             ,[Gendor] =@Gendor
                             ,[Address] = @Address
                             ,[Phone] = @Phone
                             ,[Email] =@Email
                             ,[NationalityCountryID] =@CountryID
                             ,[ImagePath] = @ImagePath
                             WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", (byte)Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            if (ThirdName != "")
            {
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            }
            else
            {
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            }

            if (Email != "")
            {
                command.Parameters.AddWithValue("@Email", Email);
            }
            else
            {
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            }

            if (ImagePath != "")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }


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

        public static bool DeletePerson(int PersonID)
        {
            int RowAffectid = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"DELETE FROM [dbo].[People]
                           WHERE PersonID=@PersonID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static bool IsPersonExist(int PersonID)
        {
            bool isFount = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"select Fount=1 From People
                             where PersonID=@PersonID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

         
                isFount = reader.HasRows;
                reader.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error " + e.Message);
                isFount = false;
            }
            finally
            {
                connection.Close();
            }

            return isFount;   
        }

        public static bool IsPersonExist(string NationalNo)
        {
            bool isFount = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"select Fount=1 From People
                             where NationalNo=@NationalNo";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                isFount = reader.HasRows;
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
                isFount = false;
            }
            finally
            {
                connection.Close();
            }

            return isFount;
        }

    }
}
