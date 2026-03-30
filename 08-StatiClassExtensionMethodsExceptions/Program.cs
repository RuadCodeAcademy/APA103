using _08_StatiClassExtensionMethodsExceptions.Exceptions;
using _08_StatiClassExtensionMethodsExceptions.Models;

namespace _08_StatiClassExtensionMethodsExceptions
{
    using System;

    class Program
    {
        static void Main()
        {
            
            LoginSystem loginSystem = new LoginSystem();

            while (true)
            {
                Console.Write("Username: ");
                string username = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                try
                {
                    
                    bool success = loginSystem.Login(username, password);

                    if (success)
                    {
                        
                        break;
                    }
                }
                catch (InvalidUsernameException ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                }
                catch (InvalidPasswordException ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                }
                catch (UserNotFoundException ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);

                    
                    Console.WriteLine("Available users:");
                    foreach (var user in new string[] { "Admin", "Student", "Teacher" })
                    {
                        Console.WriteLine(" - " + user);
                    }
                }
                catch (IncorrectPasswordException ex)
                {
                    Console.WriteLine("WARNING: " + ex.Message);
                }
                catch (AccountBlockedException ex)
                {
                    Console.WriteLine("CRITICAL: " + ex.Message + " Contact admin.");
                    break; 
                }
                catch (Exception ex)
                {
                    Console.WriteLine("UNEXPECTED ERROR: " + ex.Message);
                }

                Console.WriteLine(); 
            }

            Console.WriteLine("Program bitdi.");
        }
    }

}
