using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsLicenseClassData
    {
        public static DataTable GetAllLicenseClass()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"select * From LicenseClasses";

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

        public static DataTable GetClassName()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"select ClassName From LicenseClasses";

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

        public static bool GetLicenseClassByID(int LicenseClassID,ref string ClassName,ref string ClassDescriptionm,
          ref byte MinimumAllowedAge,ref byte DefaultValidityLength,ref decimal ClassFees)
        {
            bool IsFount = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"select * From LicenseClasses
                             where LicenseClassID=@LicenseClassID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    IsFount = true;

                    ClassName = (string)reader["ClassName"];
                    ClassDescriptionm = (string)reader["ClassDescriptionm"];
                    MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                    ClassFees = (decimal)reader["ClassFees"];

                }
                else
                {
                    IsFount = false;
                }
                    reader.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error ", e.Message);
            }
            finally
            {
                connection.Close();
            }

            return IsFount;
        }

    }
}
