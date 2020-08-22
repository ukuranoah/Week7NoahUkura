using lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5NoahUkura
{
    class Person
    {
        private string fName, mName, lName, street1, street2, city, state, zip, phone, email;
        public string FName
        {
            get
            {
                return fName;
            }
            set
            {
                fName = value;
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
                mName = value;
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
                lName = value;
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
                street1 = value;
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
                street2 = value;
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
                city = value;
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
                state = value;
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
                zip = value;

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
                if (ValidationLibrary.ValidPhone(value))
                {
                    phone = value;
                }
                else
                {
                    Feedback = "ERROR: Invalid Phone Format. Enter 10 or less numbers";
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
                if (ValidationLibrary.ValidEmail(value))
                {
                    email = value;
                }
                else
                {
                   Feedback = "ERROR: Invalid Email Format.";
                }
                
            }

        }
        public string Feedback { get; internal set; }
    }
}
