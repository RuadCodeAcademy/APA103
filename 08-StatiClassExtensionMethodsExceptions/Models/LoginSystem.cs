using _08_StatiClassExtensionMethodsExceptions.Exceptions;
using _08_StatiClassExtensionMethodsExceptions.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StatiClassExtensionMethodsExceptions.Models
{
    internal class LoginSystem
    {
        private User[] users;
        private const int MaxAttempts = 3;

        public LoginSystem()
        {
            users = new User[3];
            users[0] = new User("admin", "admin123");
            users[1] = new User("student", "student123");
            users[2] = new User("teacher", "teacher123");
        }

        private void ValidateUsername(string username)
        {
            if (username.Length == 0 || username.Length < 3)
            {
                throw new InvalidUsernameException(
                    "Username bos ola bilmez ve 3-dən az simvol ola bilmez!"
                );
            }
        }

        private void ValidatePassword(string password)
        {
            if (password.Length == 0)
            {
                throw new InvalidPasswordException();
            }
            if (password.Length < 6)
            {
                throw new InvalidPasswordException("Password en azi 6 simvoldan ibaret olmalidir");
            }
        }

        private User FindUser(string username)
        {
            foreach (var user in users)
            {
                if (user.Name == username)
                {
                    return user;
                }
            }
            throw new UserNotFoundException(username);
        }

        public bool Login(string username, string password)
        {
            ValidateUsername(username);
            ValidatePassword(password);

            User user = FindUser(username);

            if (user.IsLocked)
                throw new AccountBlockedException($"Hesab bloklanib: {username}");

            if (user.Password == password)
            {
                user.ResetFailedAttempts();
                Console.WriteLine($"Login successful! Welcome, {username}!");
                return true;
            }
            else
            {
                user.AddFailedAttempt();

                if (user.IsLocked)
                {
                    throw new AccountBlockedException($"Hesab bloklanib: {username}");
                }
                else
                {
                    int attemptsLeft = MaxAttempts - user.FailedAttempts;
                    throw new IncorrectPasswordException(attemptsLeft);
                }
            }
        }















    }










}

