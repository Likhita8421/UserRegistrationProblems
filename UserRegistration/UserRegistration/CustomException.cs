using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex_User_Registration
{
    public class CustomExceptions : Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRSTNAME, INVALID_LASTNAME, INVALID_MOBILE_NUMBER, INVALID_EMAIL, INVALID_PASSWORD
        }
        private ExceptionType type;
        public CustomExceptions(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}