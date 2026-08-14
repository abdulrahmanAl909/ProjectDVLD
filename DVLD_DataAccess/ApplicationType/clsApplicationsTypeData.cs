using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsApplicationsTypeData
    {
        public static DataTable GetAllApllicationType()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"select ID = ApplicationTypeID , Title = ApplicationTypeTitle ,
                            Fees = ApplicationFees From ApplicationTypes";

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

        public static bool UpdateFees(int ID , string Title, decimal Fees)
        {
            int RowAffected = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"UPDATE [dbo].[ApplicationTypes]
                           SET [ApplicationTypeTitle] = @Title
                          ,[ApplicationFees] = @Fees
                           WHERE ApplicationTypeID = @ID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("ID", ID);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Fees", Fees);

            try
            {
                connection.Open();

                RowAffected = command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            finally
            {
                connection.Close();
            }

            return RowAffected > 0;
        }
    }
}
