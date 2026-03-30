using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StatiClassExtensionMethodsExceptions.Exceptions
{
    internal class UserNotFoundException:Exception
    {

        public UserNotFoundException(string username): base($"User '{username}' tapilmadi!") { }
         
    }
}
