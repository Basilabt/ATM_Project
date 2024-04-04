using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMDataAccess
{
    public class clsClientDataAccess
    {

        public static bool findClientByID(int clientID , ref int personID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM Clients WHERE ClientID = @clientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@clientID", clientID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {

                    personID = (int)reader["PersonID"];

                    isFound = true;

                }

                reader.Close();


            } catch(Exception exception)
            {

                Console.WriteLine("DEBUG: {0}", exception.Message);

            } finally
            {
                connection.Close();
            }


            return isFound;

        }



    }
}
