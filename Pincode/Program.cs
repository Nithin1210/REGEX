﻿using System;

namespace Pincode
{
    public class Program
    {
        static string[] allemails = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" };
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(" # Validation Statements ");
                Console.WriteLine("\nEnter the Option :\n1.Validate Pincode \n2.Validate Email\n3.All_mails Check");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)

                {
                    case 1:
                        Console.WriteLine("Sample uc1_Pincode !");
                        ValidatePincode uc1 = new ValidatePincode();
                        uc1.uc1Validate("516001");

                        Console.WriteLine("Sample uc2_Pincode !");
                        ValidatePincode uc2 = new ValidatePincode();
                        uc2.uc2Validate("516001");

                        Console.WriteLine("Sample uc3_Pincode !");
                        ValidatePincode uc3 = new ValidatePincode();
                        uc3.uc3Validate("516001");

                        Console.WriteLine("Sample uc4_Pincode !");
                        ValidatePincode uc4 = new ValidatePincode();
                        uc4.uc4Validate("516 001");
                        break;
                    case 2:
                        Console.WriteLine("Sample UC1_email !");
                        ValidateEmail uc1Email = new ValidateEmail();
                        uc1Email.uc1Validate("abc");

                        Console.WriteLine("Sample UC2_email !");
                        ValidateEmail uc2Email = new ValidateEmail();
                        uc2Email.uc2Validate("@bridelabz");

                        Console.WriteLine("Sample UC3_email !");
                        ValidateEmail uc3Email = new ValidateEmail();
                        uc3Email.uc3Validate(".co");

                        Console.WriteLine("Sample UC4_email !");
                        ValidateEmail uc4Email = new ValidateEmail();
                        uc4Email.uc4Validate("abc.xyz@bridgelabz.com");

                        Console.WriteLine("Sample UC5_Full Email : !");
                        ValidateEmail uc5Email = new ValidateEmail();
                        uc5Email.uc5Validate("abc.xyz@bridgelabz.com");
                        break;

                    case 3:
                        Console.WriteLine("Sample Emails to Text Check !");
                        ValidateEmail email = new ValidateEmail();
                        foreach(string emails in allemails)
                        {
                            Console.WriteLine(emails);
                            email.uc5Validate(emails);
                        }
                        break;

                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("!! Enter the Correct input !!");
                        break;

                }


            }

        }
    }
}