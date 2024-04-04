using ATMDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMBusiness
{
    public class clsPerson
    {
       public enum enGender
        {
            male = 0, female = 1
        }

        public int personID { set; get; }
        public string firstName { set; get; }
        public string secondName { set; get; }
        public string thirdName { set; get; }
        public string lastName { set; get; }

        public string fullname
        {
            get
            {
                return firstName + " " + secondName + " " + thirdName + " " + lastName;
            }
        }

        public enGender gender { set; get; }
        public DateTime birthDate { set; get; }
        public string phoneNumber { set; get; }
        public string email { set; get; }

        clsPerson()
        {
            this.personID = -1;
            this.firstName = "";
            this.secondName = "";
            this.thirdName = "";
            this.lastName = "";
            this.gender = enGender.male;
            this.birthDate = DateTime.Now;
            this.phoneNumber = "";
            this.email = "";
        }

        private clsPerson(int personID, string firstName, string secondName, string thirdName, string lastName, enGender gender, DateTime birthDate, string phoneNumber, string email)
        {
            this.personID = personID;
            this.firstName = firstName;
            this.secondName = secondName;
            this.thirdName = thirdName;
            this.lastName = lastName;
            this.gender = gender;
            this.birthDate = birthDate;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public static clsPerson findPersonByID(int personID)
        {
            string firstName = "", secondName = "", thirdName = "", lastName = "", phoneNumber = "", email = "";
            byte gender = 0;
            DateTime birthDate = DateTime.Now;

            if(clsPersonDataAccess.findPersonByID(personID,ref firstName,ref secondName,ref thirdName,ref lastName,ref gender,ref birthDate,ref phoneNumber,ref email))
            {
                return new clsPerson(personID,firstName,secondName,thirdName,lastName,(gender == 0) ? enGender.male : enGender.female,birthDate,phoneNumber,email);
            }

            return null;
        }
    }
}
