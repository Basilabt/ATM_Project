using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ATMDataAccess
{
    public class clsAccountDataAccess
    {

        public static bool findByUsernameAndPassword(string username , string password,ref int accountID , ref int clientID , ref double balance , ref bool isActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM Accounts WHERE Username = @username AND Password = @password;" ;

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            try
            {
                connection.Open();


                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    accountID = (int)reader["AccountID"];
                    clientID = (int)reader["ClientID"];
                    balance = (Double)(decimal)reader["Balance"];
                    isActive = (bool)reader["IsActive"];

                }



            } catch (Exception exception)
            {
                Console.WriteLine("DEBUG: {0}",exception.Message);

            } finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool withdraw(int accountID , double amount)
        {
            int numberOfAffectedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "UPDATE Accounts SET Balance = Balance - @amount WHERE AccountID = @accountID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@amount",amount);
            command.Parameters.AddWithValue("@accountID", accountID);

            try
            {
                connection.Open();

                 numberOfAffectedRows = command.ExecuteNonQuery();

            } catch(Exception exception)
            { 
                
                Console.WriteLine("DEBUG: Exception {0}", exception.Message);

            } finally
            {
                connection.Close();
            }



            return numberOfAffectedRows >= 1;
        }

        public static bool deposit(int accountID , double amount)
        {
            int numberOfAffectetedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "UPDATE Accounts SET Balance = Balance + @amount WHERE AccountID = @accountID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@amount", amount);
            command.Parameters.AddWithValue("@accountID", accountID);

            try
            {
                connection.Open();

                numberOfAffectetedRows = command.ExecuteNonQuery();

            } catch(Exception exception)
            {

                Console.WriteLine("DEBUG: Exception {0}", exception.Message);

            } finally
            {
                connection.Close();
            }


            return numberOfAffectetedRows >= 1;
        }

        public static bool getBalance(int accountID , ref double balance)
        {
            bool isRetrieved = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT Balance FROM Accounts WHERE AccountID = @accountID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@accountID", accountID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isRetrieved = true;

                    balance = (double)(decimal)reader["Balance"];
                    
                }

                reader.Close();


            } catch (Exception exception)
            {
                Console.WriteLine("DEBUG: Exception {0}", exception.Message);
            } finally
            {
                connection.Close();
            }





            return isRetrieved;
        }

    }
}
