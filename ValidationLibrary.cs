using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Noah Ukura SE145 Validation Library
namespace lab4
{
    class ValidationLibrary
    {
        //checks if there is a response
        public static bool IsBlank(string temp)
        {
            bool result = false;
            if (temp.Length > 0)
            {
                result = true;
            }
            return result;
        }
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
            if(temp.Length <= 10)
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
            if(temp.Length <= 5)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;

        }
    }
}
