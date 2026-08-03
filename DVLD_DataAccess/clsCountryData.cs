using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsCountryData
    {
        public static DataTable GetAllCountry()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = "select * From Countries";

            SqlCommand command = new SqlCommand(quary, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
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


    }
}
