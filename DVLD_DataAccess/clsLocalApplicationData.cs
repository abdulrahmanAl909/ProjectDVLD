using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsLocalApplicationData
    {




        public static int AddNewApplication(int AppPersonID , DateTime AppDate , int AppType , byte AppStatus,
            DateTime LastStatusDate , decimal PaidFees , int CreatedByUserID)
        {
            int ApplicatonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"
            INSERT INTO [dbo].[Applications]
           ([ApplicantPersonID],[ApplicationDate],[ApplicationTypeID],[ApplicationStatus],[LastStatusDate],[PaidFees],[CreatedByUserID])
            VALUES (@AppPersonID,@AppDate,@AppType,@AppStatus,@LastStatusDate,@PaidFees,@CreatedByUserID);
            Select SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@AppPersonID", AppPersonID);
            command.Parameters.AddWithValue("@AppDate", AppDate);
            command.Parameters.AddWithValue("@AppType", AppType);
            command.Parameters.AddWithValue("@AppStatus", AppStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertID))
                {
                    ApplicatonID = insertID;
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

            return ApplicatonID;
        }

        public static bool UpdateApplication(int AppID,int AppPersonID, DateTime AppDate, int AppType, byte AppStatus,
            DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            int RowAffectid = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string quary = @"UPDATE [dbo].[Applications]
                           SET [ApplicantPersonID] =@AppPersonID
                           ,[ApplicationDate] =@AppDate
                           ,[ApplicationTypeID] =@AppType
                           ,[ApplicationStatus] = @AppStatus
                           ,[LastStatusDate] =@LastStatusDate
                           ,[PaidFees] =@PaidFees
                           ,[CreatedByUserID] = @CreatedByUserID
                           WHERE ApplicationID = @AppID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@AppID", AppID);
            command.Parameters.AddWithValue("@AppPersonID", AppPersonID);
            command.Parameters.AddWithValue("@AppDate", AppDate);
            command.Parameters.AddWithValue("@AppType", AppType);
            command.Parameters.AddWithValue("@AppStatus", AppStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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


    }
}
