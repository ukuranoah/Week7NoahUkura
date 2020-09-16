using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Noah Ukura SE145 Validation Library
namespace Week6NoahUkura
{
    class ValidationLibrary
    {
        //checking for valid email
        public static bool ValidEmail(string temp)
        {
            bool blnResult = true;

            int atLocation = temp.IndexOf("@");
            int NextatLocation = temp.IndexOf("@", atLocation + 1);
            int periodLocation = temp.LastIndexOf(".");
            //checks if email is at least 8 chars
            if(temp.Length < 8)
            {
                blnResult = false;
            }
            //checks if @ location is located before the first 2 chars
            else if(atLocation < 2)
            {
                blnResult = false;
            }
            else if(periodLocation + 2 > (temp.Length))
            {
                blnResult = false;
            }
            return blnResult;
        }
        //checks if the phone number is 10 numbers or less
        public static bool ValidPhone(string temp)
        {
            bool result = false;
            if(temp.Length != 11)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        public static bool ValidCPhone(string temp)
        {
            bool result = false;
            if (temp.Length != 11)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        //checks Zip under 5 numbers
        public static bool ValidZip(string temp)
        {
            bool result = false;
            if(temp.Length != 6)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;

        }
        //checking for state that is only 2 letters
        public static bool ValidState(string temp)
        {
            bool result = false;
            if (temp.Length == 2)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;

        }

        public static bool IsItFilledIn(string temp)
        {
            bool result = false;

            if (temp.Length > 0)
            {
                result = true;
            }

            return result;
        }
        public static bool ValidIG(string temp)
        {
            bool blnResult = false;
            if (temp.Length < 18 || !(temp.Substring(0, 18).Contains("www.instagram.com/")))
            {
                blnResult = false;
            }
            else
            {
                blnResult = true;
            }
            return blnResult;
        }
        public static bool ValidTPurchases(double temp)
        {
            bool blnResult = false;
            string newtemp = temp.ToString();
            if(newtemp.Length == 0)
            {
                blnResult = false;
            }
            else
            {
                blnResult = true;
            }
            return blnResult;
        }
        public static bool IsAMember(bool temp)
        {
            bool blnResult = false;
            if(temp == true)
            {
                blnResult = false;
            }
            else
            {
                blnResult = true;
            }
            return blnResult;
        }
        public static bool IsAPastDate(DateTime temp)
        {
            bool blnResult;
            if (temp != DateTime.Now && temp > DateTime.Now)
            {
                blnResult = false;
            }
            else
            {
                blnResult = true;
            }
            return blnResult;
        }

    }
}
