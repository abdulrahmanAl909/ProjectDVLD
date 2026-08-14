using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsTestTypeData
    {

        public static DataTable GetAllTestType()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"select ID = TestTypeID , Title = TestTypeTitle 
                            ,Description = TestTypeDescription , Fees = TestTypeFees  From TestTypes";

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

        public static bool UpdateTestType(int ID , string Title , string Description , decimal Fees)
        {
            int RowAffected = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"UPDATE [dbo].[TestTypes]
                           SET [TestTypeTitle] = @Title
                           ,[TestTypeDescription] = @Description
                           ,[TestTypeFees] = @Fees
                           WHERE TestTypeID = @ID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Description", Description);
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
