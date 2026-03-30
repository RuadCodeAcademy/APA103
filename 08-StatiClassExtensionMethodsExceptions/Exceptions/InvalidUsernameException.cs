using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StatiClassExtensionMethodsExceptions.Exceptions
{
    internal class InvalidUsernameException:Exception
    {
        public InvalidUsernameException() : base("Username bos ola bilmez!!!") { }
        public InvalidUsernameException(string message) : base(message) { }
    }
}
