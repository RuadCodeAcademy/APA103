using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StatiClassExtensionMethodsExceptions.Exceptions
{
    internal class IncorrectPasswordException:Exception
    {
        public int AttemptsLeft { get; set; }

        public IncorrectPasswordException(int attemptsLeft)
            : base($"Password is incorrect. Attempts left: {attemptsLeft}")
        {
            AttemptsLeft = attemptsLeft;
        }


    }
}
