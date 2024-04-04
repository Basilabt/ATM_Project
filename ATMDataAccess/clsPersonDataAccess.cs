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
    public class clsPersonDataAccess
    {

        public static bool findPersonByID(int personID,ref string firstName , ref string secondName , ref string thirdName, ref string lastName , ref byte gender , ref DateTime birthDate , ref string phoneNumber , ref string email)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM People WHERE PersonID = @personID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@personID", personID);

            try
            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;

                    firstName = (string)reader["FirstName"];
                    secondName = (string)reader["SecondName"];
                    thirdName = (string)reader["ThirdName"];
                    lastName = (string)reader["LastName"];
                    gender = (byte)reader["Gender"];
                    birthDate = (DateTime)reader["BirthDate"];
                    phoneNumber = (string)reader["PhoneNumber"];
                    email = (string)reader["Email"];
     
                }

                reader.Close();


            } catch (Exception exception)
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
