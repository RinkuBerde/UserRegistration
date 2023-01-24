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
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_FIRSTNAME);
        }        
    }
}

