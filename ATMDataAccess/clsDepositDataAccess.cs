using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMDataAccess
{
    public class clsDepositDataAccess
    {

        public static bool logDeposit(int accountID , double amount , DateTime date)
        {
            int numberOfAffectedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "INSERT INTO Deposits (AccountID,Amount,Date) VALUES (@accountID,@amount,@date)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@accountID", accountID);
            command.Parameters.AddWithValue("@amount", (decimal)amount);
            command.Parameters.AddWithValue("@date", date);

            try
            {
                connection.Open();

                numberOfAffectedRows = command.ExecuteNonQuery();

            } catch (Exception exception)
            {

                Console.WriteLine("DEBUG: Exception {0}", exception.Message);

            } finally
            {
                connection.Close();
            }
            
            return numberOfAffectedRows >= 1;
        }


        public static DataTable getAllDeposits(int accountID)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM Deposits WHERE AccountID = @accountID";

            SqlCommand command = new SqlCommand(query,connection);

            command.Parameters.AddWithValue("@accountID", accountID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                dataTable.Load(reader);

            } catch(Exception exception)
            {

                Console.WriteLine("DEBUG: Exception {0}", exception.Message);

            } finally
            {
                connection.Close();
            }


            return dataTable;
        }


    }
}
