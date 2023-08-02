using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pincode
{
    public class ValidatePincode
    {
        string uc1 = "^[0-9]{6}$";
        string uc4 = "^[0-9]{3}[ ][0-9]{3}$";
        public void uc1Validate(string input )
        {
            bool result = Regex.IsMatch(input, uc1);
                if(result)
                    Console.WriteLine("Valid");
                else
                    Console.WriteLine("! inValid");
        }
        public void uc2Validate(string input)
        {
            bool result = Regex.IsMatch(input, uc1);
            if (result)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("! inValid");
        }
        public void uc3Validate(string input)
        {
            bool result = Regex.IsMatch(input, uc1);
            if (result)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("! inValid");
        }
        public void uc4Validate(string input)
        {
            bool result = Regex.IsMatch(input, uc4);
            if (result)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("! inValid");
        }


    }
}
