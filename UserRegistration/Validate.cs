using System;
using System.Collections.Generic;
using System.Linq;
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

    }
}

