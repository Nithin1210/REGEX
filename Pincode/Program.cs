using System;

namespace Pincode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sample uc1_REGEX !");
            ValidatePincode uc1 = new ValidatePincode();
            uc1.uc1Validate("516001");

            Console.WriteLine("Sample uc2_REGEX !");
            ValidatePincode uc2 = new ValidatePincode();
            uc2.uc2Validate("516001");

            Console.WriteLine("Sample uc3_REGEX !");
            ValidatePincode uc3 = new ValidatePincode();
            uc3.uc3Validate("516001");

            Console.WriteLine("Sample uc4_REGEX !");
            ValidatePincode uc4 = new ValidatePincode();
            uc4.uc4Validate("516 001");

            //ValidatePincode uc1 = new ValidatePincode();
            //uc1.uc1Validate("abc");
        }
    }
}