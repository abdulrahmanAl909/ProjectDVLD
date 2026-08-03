using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Reflection;


namespace DVLD_DataAccess
{
    public class clsPersonData
    {
        enum enGendor { Male=0 , Female=1};

        enGendor GlobalGendor = enGendor.Male;

       public static DataTable GetAllPeople()
       {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary ="SELECT People.PersonID, People.NationalNo,FullName=FirstName + ' ' +SecondName + ' '+ThirdName+ ' ' + LastName ,People.DateOfBirth," +
                " Gendor = case when Gendor = 0 then 'Male' when Gendor = 1 then 'Femail' else'UnKnows' End," +
                " People.Address, People.Phone, People.Email, Countries.CountryName FROM People" +
                " INNER JOIN Countries ON People.NationalityCountryID = Countries.CountryID";

            SqlCommand command = new SqlCommand(quary, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    dataTable.Load(reader);
                }
                reader.Close();
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

        public static bool GetPersonInfoByID()
        {
            return false;
        }

        public static bool GetPersonInfoByNational()
        {
            return false;
        }

        public static int AddNewPerson(ref string NationalNo ,ref string FirstName
            ,ref string SecondName, ref string ThirdName, ref string LastName,
            ref DateTime DateOfBirth,ref int Gendor,ref string Address, ref string Phone,
            ref string Email,ref int CountryID,ref string ImagePath)
        {
            return 0;
        }

        public static bool UpdatePerson()
        {
            return false;
        }

        public static bool DeletePerson()
        {
            return false;
        }

        public static bool IsPersonExist()
        {
            return false;
        }






        //public static bool IsPersonExist()
        //{
        //    return false;
        //}

    }



}
