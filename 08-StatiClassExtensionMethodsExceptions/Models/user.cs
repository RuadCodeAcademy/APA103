using _08_StatiClassExtensionMethodsExceptions.Exceptions;
using _08_StatiClassExtensionMethodsExceptions.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StatiClassExtensionMethodsExceptions.Models
{
    internal class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public int FailedAttempts { get; private set; } = 0;
        public bool IsLocked => FailedAttempts >= 3;

        public User(string name, string password)
        {
            Name = Helper.Capitalize(name.Trim());
            Password = password;
        }

        public void AddFailedAttempt()
        {
            FailedAttempts++;
        }

        public void ResetFailedAttempts()
        {
            FailedAttempts = 0;
        }


    }
}

