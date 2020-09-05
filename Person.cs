using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Week6NoahUkura
{
    public class Person
    {
        protected string feedback;
        private string fName;
        private string mName; 
        private string lName; 
        private string street1;
        private string street2;
        private string city; 
        private string state; 
        private string zip;
        private string phone;
        private string email;

        public string FName
        {
            get
            {
                return fName;
            }
            set
            {
                if (ValidationLibrary.IsItFilledIn(value))
                {
                    fName = value;
                }
                else
                {
                    feedback += "\nError: Please enter the first name";
                }
                
            }
        }
        public string MName
        {
            get
            {
                return mName;
            }
            set
            {
                if (ValidationLibrary.IsItFilledIn(value))
                {
                    mName = value;
                }
                else
                {
                    feedback += "\nError: Please enter the middle name";
                }
            }
        }
        public string LName
        {
            get
            {
                return lName;
            }
            set
            {
                if (ValidationLibrary.IsItFilledIn(value))
                {
                    lName = value;
                }
                else
                {
                    feedback += "\nError: Please enter the last name";
                }
            }
        }
        public string Street1
        {
            get
            {
                return street1;
            }
            set
            {
                if (ValidationLibrary.IsItFilledIn(value))
                {
                    street1 = value;
                }
                else
                {
                    feedback += "\nError: Please enter the street1 name";
                }
            }
        }
        public string Street2
        {
            get
            {
                return street2;
            }
            set
            {
                if (ValidationLibrary.IsItFilledIn(value))
                {
                    street2 = value;
                }
                else
                {
                    feedback += "\nError: Please enter the street2 name";
                }
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                if (ValidationLibrary.IsItFilledIn(value))
                {
                    city = value;
                }
                else
                {
                    feedback += "\nError: Please enter the city name";
                }
            }
        }
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                if (ValidationLibrary.IsItFilledIn(value))
                {
                    state = value;
                }
                else
                {
                    feedback += "\nError: Please enter the state name";
                }
                if (ValidationLibrary.ValidState(value))
                {
                    state = value;
                }
                else
                {
                    feedback += "\nError: Invalid state name, please enter the state in two letters. Rhode Island (RI)";
                }
            }
        }
        public string Zip
        {
            get
            {
                return zip;
            }
            set
            {
                if (ValidationLibrary.IsItFilledIn(value))
                {
                    zip = value;
                }
                else
                {
                    feedback += "\nError: Please enter the zip code";
                }
                if (ValidationLibrary.ValidZip(value))
                {
                    zip = value;
                }
                else
                {
                    feedback += "\nError: Invalid Zip, Please enter a 5 digit number";
                }

            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                if (ValidationLibrary.IsItFilledIn(value))
                {
                    phone = value;
                }
                else
                {
                    feedback += "\nError: Please enter the phone number";
                }
                if (ValidationLibrary.ValidPhone(value))
                {
                    phone = value;
                }
                else
                {
                    feedback += "\nError: Invalid Phone Format. Enter 10 numbers";
                }

            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (ValidationLibrary.IsItFilledIn(value))
                {
                    email = value;
                }
                else
                {
                    feedback += "\nError: Please enter the email address";
                }
                if (ValidationLibrary.ValidEmail(value))
                {
                    email = value;
                }
                else
                {
                    feedback += "\nError: Invalid Email Format. ex. John@email.com";
                }
                
            }

        }
        public string Feedback
        {
            get
            {
                return feedback;
            }
            //set
            //{
            //    feedback = value;
            //}
        }
        public Person()
        {
            fName = "";
            mName = "";
            lName = "";
            street1 = "";
            street2 = "";
            city = "";
            state = "";
            phone = "";
            email = "";
            feedback = "";
        }
    }
    
}
