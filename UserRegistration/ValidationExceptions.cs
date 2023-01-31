using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class ValidationExceptions:Exception
    {
        
        public enum ExceptionType
        {
            INVALID_FIRST_NAME,
            INVALID_LAST_NAME,
            INVALID_EMAIL,
            INVALID_MOBILE_NUMBER,
            INVALID_PASSWORD
        }

        public ExceptionType type;
        public ValidationExceptions(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
    


