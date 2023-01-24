using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UserRegistration
{
    internal class Validate
    {       
        //Regular expression or validating first name
       public static string REGEX_FIRSTNAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        // Regular expression for last name
        public static string Regex_LastName = "^[A-Z]{1}[A-Za-z]{2,}$";
        //Regular expression for valid email
        public const string Regex_Email = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        //Regular expression for Phone Name validation ---- country code followed by space and 10 digit numbers
        public const string Regex_PhoneNumber = "[+][1-9]{1,2}[ ][0-9]{10}$";
        //Regular expression for Password validation ---- min 8 characters
        public const string Regex_Password1 = "^[A-Za-z0-9]{8,}$";
        //Regular expression to match previous condition + atleast one Upper Case
        public const string Regex_Password2 = "^(?=.*[A-Z]).{8,}$";
        //Regular expression below will match all previous conditions + atleast one numeric value
        public const string Regex_Password3 = "^(?=.*[A-Z])(?=.*[0-9]).{8,}$";
        //Regular expression below will match previous conditions + exactly one special character
        public const string Regex_Password4 = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[&%$#@^*!~]).{8,}$"; 
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_FIRSTNAME);
        }
        public bool ValidateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, Regex_LastName);
        }
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, Regex_Email);
        }
        public bool ValidateMobile(string PhoneNumber)
        {
            return Regex.IsMatch(PhoneNumber, Regex_PhoneNumber);
        }
        public bool ValidatePassword1(string password)
        {
            return Regex.IsMatch(password, Regex_Password1);
        }
        public bool ValidatePassword2(string password2)
        {
            return Regex.IsMatch(password2, Regex_Password2);
        }
        public bool ValidatePassword3(string password3)
        {
            return Regex.IsMatch(password3, Regex_Password3);
        }
        public bool ValidatePassword4(string password4)
        {
            return Regex.IsMatch(password4, Regex_Password4);
        }
        //Method to test each Valid and Invalid email provided separately for testing
        public void Test()
        {
            Validate validate = new Validate();
            Console.WriteLine("A. Valid Emails");
            string[] validEmails = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" };
            for (int i = 0; i < validEmails.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + validEmails[i] + " : " + validate.ValidateEmail(validEmails[i]));
            }
            Console.WriteLine("\nB. Invalid Emails");
            string[] invalidEmails = { "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
            for (int i = 0; i < invalidEmails.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + invalidEmails[i] + " : " + validate.ValidateEmail(invalidEmails[i]));
            }
        }

    }
}

