using System;

namespace Pincode
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Sample Demo of REGEX !");
            ValidatePincode obj = new ValidatePincode();
            obj.Validate("516001");
        }
    }
}