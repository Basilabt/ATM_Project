using ATMDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMBusiness
{
    public class clsClient
    {
        public int clientID { set; get; }
        public int personID { set; get; }

        // Composition
        public clsPerson person { set; get; }

        clsClient()
        {
            this.clientID = -1;
            this.personID = -1;
        }

        private clsClient(int clientID, int personID)
        {
            this.clientID = clientID;
            this.personID = personID;
            this.person = clsPerson.findPersonByID(personID);

            Console.WriteLine("DEBUG: PersonID = {0}", this.person.personID);
            Console.WriteLine("DEBUG: First Name = {0}", this.person.firstName);
            Console.WriteLine("DEBUG: Fullname = {0}", this.person.fullname);
        }

        public static clsClient findClientByID(int clientID)
        {
            int personID = -1;

            if(clsClientDataAccess.findClientByID(clientID,ref personID))
            {
                return new clsClient(clientID, personID);
            }

            return null;
        }
    }
}
