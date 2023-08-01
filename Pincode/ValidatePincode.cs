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
        public void Validate(string input )
        {
            bool result = Regex.IsMatch(input, uc1);
                if(result)
                    Console.WriteLine("Valid");
                else
                    Console.WriteLine("! inValid");
        }


    }
}
