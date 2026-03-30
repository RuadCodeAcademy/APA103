using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StatiClassExtensionMethodsExceptions.Exceptions
{
    internal class AccountBlockedException:Exception
    {
        
    public AccountBlockedException(string message) : base(message) { }
    
}
}
